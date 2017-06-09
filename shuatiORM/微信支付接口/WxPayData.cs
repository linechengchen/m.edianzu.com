using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model.小程序接口
{
    //支付
    public class WxPayData
    {
        //采用排序的Dictionary的好处是方便对数据包进行签名，不用再签名之前再做一次排序
        private SortedDictionary<string, object> m_values = new SortedDictionary<string, object>();

        public string MakeSign()
        {
            return "";
        }

        /// <summary>
        /// 默认构造函数
        /// 如果initDefault为true，则自动填入字段（appid,mch_id,time_stamp,nonce_str,out_trade_no,）
        /// </summary>
        public WxPayData(bool initDefault = false)
        {
            if (initDefault)
            {
                Init();
            }
        }
        string APPID = "";
        string MCHID = "";

        public void Init()
        {
            Init(APPID, MCHID);
        }

        /// <summary>
        /// 对象初始化后，自动填入字段（appid,mch_id,time_stamp,nonce_str,out_trade_no,）
        /// </summary>
        public void Init(string APPID, string MCHID)
        {
            //初始化几个参数
            this.SetValue("appid", APPID);//公众帐号id //WxPayConfig.
            this.SetValue("mch_id", MCHID);//商户号 //WxPayConfig.
            this.SetValue("nonce_str", WxPayApi.GenerateNonceStr());//随机字符串
            this.SetValue("out_trade_no", WxPayApi.GenerateOutTradeNo(MCHID.Length));//随机字符串//WxPayConfig.MCHID
        }

        public SortedDictionary<string, object> GetValues()
        {
            return m_values;
        }
        public void SetValue(string key, string value)
        {
            if (m_values.ContainsKey(key))
                m_values[key] = value;
            else
                m_values.Add(key, value);
        }
    }
}
