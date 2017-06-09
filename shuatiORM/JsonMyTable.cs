using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{    
    public class Data<MyTable> where MyTable : ITableImplement, new()
    {
	    public string total  { get; set; }
	    public string userId  { get; set; }
        public string pageIndex { get; set; }
        public List<MyTable> dataList { get; set; }

        public string ToJson()
        {
            StringBuilder sb1 = new StringBuilder("{");
            sb1.Append("\"total\":\"").Append(total).Append("\"")
                .Append("\"userId\":\"").Append(userId).Append("\"")
                .Append("\"pageIndex\":\"").Append(pageIndex).Append("\"")
                .Append("\"dataList\":\"").Append(JsonServiceBase.ToJson(dataList)).Append("\"");
            return sb1.Append("}").ToString();
        }
    }

//    {\"code\":200,\"msg\":\"返回数据成功\",\"data\":
//    {
//        \"page\" : \"1\",
//        \"guanggaos\":
//        [
//            {\"ggName\":\"hongqiaoyiyuan\",\"showSum\" : \"999"  }
//        ]
//    }
//}

    public class RootObject<MyTable> where MyTable : ITableImplement, new()
    {
        public string code { get; set; }
        public string msg { get; set; }
        public Data<MyTable> data { get; set; }

        public string ToJson()
        {
            StringBuilder sb1 = new StringBuilder("{");
            sb1.Append("\"code\":\"").Append(code).Append("\"")
                .Append("\"msg\":\"").Append(msg).Append("\"")
                .Append("\"data\":\"").Append(data.ToJson()).Append("\"");
            return sb1.Append("}").ToString();
        }
    }
}