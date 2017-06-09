using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class JWeChat
    {
        /// <summary>
        /// 
        /// </summary>
        public int oper_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wechat_openid { get; set; }
    }

    public class JResultCode
    {
        /// <summary>
        /// 
        /// </summary>
        public string resultCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string data { get; set; }
    }
}
