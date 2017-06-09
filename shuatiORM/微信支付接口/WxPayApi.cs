using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model.小程序接口
{
    public class WxPayApi
    {
        public static string GenerateOutTradeNo()
        {
            return GenerateOutTradeNo(16);
        }
        public static string GenerateOutTradeNo(int length)
        {
            return GenerateNonceStr(length);
        }

        /** 
        * 生成时间戳，标准北京时间，时区为东八区，自1970年1月1日 0点0分0秒以来的秒数 
        * @return 时间戳 
        */
        public static string GenerateTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /** 
        * 生成随机串，随机串包含字母或数字 
        * @return 随机串 
        */
        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }  
  
        //public static string GenerateNonceStr()
        //{
        //    return GenerateNonceStr(16);
        //}

        public static string GenerateNonceStr(int length)
        {
            Random r1 = new Random();
            // 密码字符集，可任意添加你需要的字符
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder str = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                str.Append(chars[r1.Next(0, chars.Length - 1)]);
            }
            return str.ToString();
        }

    }
}
