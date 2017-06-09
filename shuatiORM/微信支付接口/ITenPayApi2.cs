using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model.小程序接口
{
    /// <summary>
    /// 微信支付接口
    /// </summary>
    public class ITenPayApi2: ITenPayApi
    {
        public string Json(object e1)
        {
            string _json = JsonConvert.SerializeObject(e1);
            return _json;
        }
        /// <summary>
        /// 模式一
        /// </summary>
        /// <returns></returns>
        public string GetQRCode1()
        {
            object objResult = "";
            string strProductID = Request.Form["productId"];
            string strQRCodeStr = GetPrePayUrl(strProductID);
            if (!string.IsNullOrWhiteSpace(strProductID))
            {
                objResult = new { result = true, str = strQRCodeStr };
            }
            else
            {
                objResult = new { result = false };
            }
            return Json(objResult);
        }
        /**
        * 生成扫描支付模式一URL
        * @param productId 商品ID
        * @return 模式一URL
        */
        public string GetPrePayUrl(string productId)
        {
            WxPayData data = new WxPayData();
            data.SetValue("appid", WxPayConfig.APPID);//公众帐号id
            data.SetValue("mch_id", WxPayConfig.MCHID);//商户号
            data.SetValue("time_stamp", WxPayApi.GenerateTimeStamp());//时间戳
            data.SetValue("nonce_str", WxPayApi.GenerateNonceStr());//随机字符串
            data.SetValue("product_id", productId);//商品ID
            data.SetValue("sign", data.MakeSign());//签名
            string str = ToUrlParams(data.GetValues());//转换为URL串
            string url = "weixin://wxpay/bizpayurl?" + str;
            return url;
        }
        /**
       * 参数数组转换为url格式
       * @param map 参数名与参数值的映射表
       * @return URL字符串
       */
        private string ToUrlParams(SortedDictionary<string, object> map)
        {
            string buff = "";
            foreach (KeyValuePair<string, object> pair in map)
            {
                buff += pair.Key + "=" + pair.Value + "&";
            }
            buff = buff.Trim('&');
            return buff;
        }
    }
}
