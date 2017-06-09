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
        public string total { get; set; }
        public string pageIndex { get; set; }
        public List<MyTable> dataList { get; set; }
        public List<List<ITableImplement>> dataListList { get; set; }

        public string ToJson()
        {
            StringBuilder sb1 = new StringBuilder("{");
            sb1.Append("\"total\":\"").Append(total).Append("\"").Append(",")
                .Append("\"userId\":\"").Append(userId).Append("\"").Append(",")
                .Append("\"pageIndex\":\"").Append(pageIndex).Append("\"").Append(",")
                .Append("\"dataList\":").Append(JsonServiceBase.ToJson(dataList));
            return sb1.Append("}").ToString();
        }
    }

    public class ZsData<MyTable> where MyTable : ITableImplement, new()
    {
        public string total { get; set; }
        public string userId { get; set; }
        public string pageIndex { get; set; }
        public List<MyTable> dataList { get; set; }
        public List<List<ITableImplement>> dataListList { get; set; }

        public string ToJson()
        {
            StringBuilder sb1 = new StringBuilder("{");
            sb1.Append("\"total\":\"").Append(total).Append("\"").Append(",")
                .Append("\"userId\":\"").Append(userId).Append("\"").Append(",")
                .Append("\"pageIndex\":\"").Append(pageIndex).Append("\"").Append(",")
                .Append("\"dataList\":").Append(JsonServiceBase.ToJson(dataList));
            return sb1.Append("}").ToString();
        }
    }

//    {\"code\":200,\"msg\":\"返回数据成功\",\"ZsData\":
//    {
//        \"page\" : \"1\",
//        \"guanggaos\":
//        [
//            {\"ggName\":\"hongqiaoyiyuan\",\"showSum\" : \"999"  }
//        ]
//    }
//}

    public class ZsRootObject
    {
        public static string getJsonRoot(List<TzsTypeInfo> zstype1List)
        {
            ZsRootObject<TzsTypeInfo> root1 = new ZsRootObject<TzsTypeInfo>();
            root1.code = "200";
            root1.msg = "成功";
            root1.ZsData = new ZsData<TzsTypeInfo>();
            root1.ZsData.dataList = new List<TzsTypeInfo>();
            root1.ZsData.dataList.AddRange(zstype1List);
            foreach(TzsTypeInfo type1 in zstype1List)
            {
                List<TzsInfo> list1 = BLLTable<TzsInfo>.Select(TzsInfo.Attribute.ZsTypeId, type1.TypeId);

            }
            return root1.ToJson();
        }
    }
    public class ZsRootObject<MyTable> where MyTable : ITableImplement, new()
    {        
        public string code { get; set; }
        public string msg { get; set; }
        public string userId { get; set; }
        public ZsData<MyTable> ZsData { get; set; }

        public string ToJson()
        {
            StringBuilder sb1 = new StringBuilder("{");
            sb1.Append("\"code\":\"").Append(code).Append("\"").Append(",")
                .Append("\"msg\":\"").Append(msg).Append("\"").Append(",")
                .Append("\"ZsData\":").Append(ZsData.ToJson());
            return sb1.Append("}").ToString();
        }
    }
}