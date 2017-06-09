using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model.小程序接口
{
    /// <summary>
    /// 微信支付接口
    /// </summary>
    public interface ITenPayApi
    {
        /// <summary>
        /// 生成扫描支付模式一URL
        /// </summary>
        /// <param name="productId">商品ID</param>
        /// <returns></returns>
        string GetPrePayUrl(string productId);

        /// <summary>
        /// 生成直接支付url，支付url有效期为2小时,模式二
        /// </summary>
        /// <param name="info">商品订单数据</param>
        /// <returns></returns>
        string GetPayUrl(WxPayOrderData info);

        /// <summary>
        /// 统一下单。（不需要证书,默认不需要）
        /// 除被扫支付场景以外，商户系统先调用该接口在微信支付服务后台生成预支付交易单，
        /// 返回正确的预支付交易回话标识后再按扫码、JSAPI、APP等不同场景生成交易串调起支付。
        /// </summary>
        /// <param name="info">商品订单数据</param>
        WxPayData UnifiedOrder(WxPayOrderData info);

    }
}
