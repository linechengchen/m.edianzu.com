using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Data;
using System.Data.Common;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Orm.PersistenceLayer.Robot.Model;
using System.Text.RegularExpressions;
using System.IO;

namespace AgileFrame.Core
{
    /// <summary>
    /// Json服务
    /// </summary>
    public partial class JsonService
    {
        //http://www.bejson.com/go.php?u=http://www.bejson.com/jsonviewernew/
        //[ { "id": "1001", "sendName": "马云无耻", "sendId": "1004", "title": "Apple", "date": "2013/09/08 05:05:05", "fieFlag": "0", "content": "这是一条测试数据这是一条测试数据这是一条测试数据这是一条测试数据这是一条测试数据", "receiveList": [ { "receiveName": "王老五", "receiveId": "1008" }, { "receiveName": "周星驰", "receiveId": "1007" }, { "receiveName": "李老六", "receiveId": "1006" }, { "receiveName": "张三丰", "receiveId": "1005" } ] } ]

        /// <summary>
        /// 长度不能大于20哦
        /// </summary>
        public static int Length = 20000;
        public JsonService()
        {

        }

        public JsonService(int length)
        {
            Length = length;
        }
        public bool isEnumChinese = true;
        bool isDebug = false;
        public JsonService(bool isDebug, bool isEnumChinese1)
        {
            this.isDebug = isDebug;
            this.isEnumChinese = isEnumChinese1;
        }
        public JsonService(bool isDebug)
        {
            this.isDebug = isDebug;
        }

        public JsonService(int length, bool isDebug)
        {
            Length = length;
            this.isDebug = isDebug;
        }

        public static string filterJson2(string sourceStr)
        {
            if (string.IsNullOrEmpty(sourceStr)) return "";
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr,"\\", "\\\\");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\b", "\\\b");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\t", "\\\t");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\n", "\\\n");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\n", "\\\n");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\f", "\\\f");
            //sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\r", "\\\r");

            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\\", "\\\\");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\b", "\\b");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\t", "\\t");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\n", "\\n");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\n", "\\n");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\f", "\\f");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\r", "\\r");
            //sourceStr = sourceStr.Replace("/", "\\/");
            sourceStr = StringHelper.ReplaceNonCase(sourceStr, "\"", "\\\"");
            return sourceStr;
        }

        public static string filterJson(string s)
        {
            return filterJson2(s);

            if (string.IsNullOrEmpty(s)) return "";

            StringBuilder sb = new StringBuilder(s.Length + 100);
            //sb.Append('"');
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.ToCharArray()[i];
                switch (c)
                {
                    case '"':
                        sb.Append("\\\"");
                        break;
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    //case '/':
                    //    sb.Append("\\/");
                        break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            //sb.Append('"');
            return sb.ToString();
        }
        private string filter(string theString)
        {
            theString = theString.Replace(">", "&gt;");
            theString = theString.Replace("<", "&lt;");
            theString = theString.Replace(" ", "&nbsp;");
            theString = theString.Replace("\"", "&quot;");
            theString = theString.Replace("\'", "&#39;");
            theString = theString.Replace("\\", "\\\\");//对斜线的转义  
            theString = theString.Replace("\n", "\\n");  //注意php中替换的时候只能用双引号"\n"
            theString = theString.Replace("\r", "\\r");
            return theString;
        }

        /// <summary>
        /// 获得 键值对 Dictionary(key,value)
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static Dictionary<string, object> FromJsonUrlDetail(string jsonStr)
        {
            Dictionary<string, object> mytable = new Dictionary<string, object>();
            int count = 0;
            try
            {
                StringBuilder output = new StringBuilder(jsonStr);
                int head = jsonStr.IndexOf("|");
                if (head != 0)
                    count = Convert.ToInt32(jsonStr.Substring(0, head).Trim());
                if (count == 0)
                    return mytable;
                output.Remove(0, head + 1);
                string[] ps = output.ToString().Split('|');
                foreach (string p in ps)
                {
                    if (p.Length > 0)
                    {
                        string[] names = p.Split('`');
                        if (names.Length == 2)
                        {
                            string fieldname = names[0];
                            string value = names[1];
                            mytable.Add(fieldname, value);
                            count--;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleService.Error("FromJsonDetail:" + ex.Message + ex.StackTrace);
            }
            if (count < 0)
                ConsoleService.Warn("FromJson's crc is wrong, count = " + count);
            return mytable;
        }
        /// <summary>
        /// js转换为对象 0|ROLE_TYPE`1| 或者 1|ROLE_TYPE`1|
        /// 为url写的缩略型json串 js转换为对象 0|ROLE_TYPE`1| 或者 1|ROLE_TYPE`1|
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public  MyTable FromJsonUrl<MyTable>(string jsonStr) where MyTable : ITable, new()
        {
            MyTable mytable = new MyTable();
            int count = 0;
            try
            {
                StringBuilder output = new StringBuilder(jsonStr);
                int head1 = jsonStr.IndexOf("|");
                if (head1 > 0)
                {
                    if (mytable._TableName.ToLower() == ITableImplement.defaultTableName.ToLower())
                        mytable._TableName = Convert.ToString(jsonStr.Substring(0, head1).Trim());
                }
                else
                    return mytable;
                int head2 = jsonStr.IndexOf("|", head1 + 1);
                if (head2 > 0)
                {
                    string countStr = jsonStr.Substring(head1 + 1, head2 - head1 - 1).Trim();
                    count = Convert.ToInt32(countStr);
                }
                else
                    return mytable;
                if (count == 0)
                    return mytable;
                output.Remove(0, head2 + 1);

                string output1 = Convert.ToString(output);
                string[] psArray = output1.Split('|');
                foreach (string ps in psArray)
                {
                    if (ps.Length > 0)
                    {
                        string[] values = ps.Split('`');
                        if (values.Length == 2)
                        {
                            count--;
                            string fieldname = values[0];
                            string value = values[1];
                            if (fieldname == "af_where")
                            {
                                mytable.af_WhereSQL = StringHelper.ReplaceNonCase(value, replaceFenGe, "|");
                            }
                            else if (fieldname == "af_top")
                            {
                                mytable.af_TopText = value;
                            }
                            else if (fieldname == "af_pageby")
                            {
                                mytable.af_PageByAttributeItem = new AttributeItem(value);
                            }
                            else if (fieldname == "af_pagebyorder")
                            {
                                mytable.af_PageByOrder = (Order)(Convert.ToInt32(value));
                            }
                            else if (fieldname == "af_orderby")
                            {
                                mytable.af_OrderByItem = OrderByItem.Deserialize(value);
                            }
                            else
                            {
                                mytable.SetValue(new AttributeItem(mytable._TableName, fieldname), StringHelper.ReplaceNonCase(value, replaceFenGe, "|"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleService.Error("FromJson188:" + ex.Message + "|" + jsonStr);
                throw new Exception("FromJson188:" + ex.Message + "|" + jsonStr);
            }
            if (count < 0)
                ConsoleService.Warn("FromJson's crc is wrong, count = " + count);
            return mytable;
            //MyTable output = Newtonsoft.Json.JavaScriptConvert.DeserializeObject<MyTable>(jsonStr);
            //return output;
        }
        internal  bool FromJson<MyTable>(MyTable table, string jsonStr1) where MyTable : ITable, new()
        {
            if (string.IsNullOrEmpty(jsonStr1)) return false;
            try
            {
                string jsonStr = jsonStr1.Trim();
                jsonStr = jsonStr.TrimStart('{').TrimEnd('}');
                string[] jsonlist1 = jsonStr.Split(',');
                foreach (string js1 in jsonlist1)
                {
                    string[] keys = js1.Split(':');
                    if (keys.Length != 2)
                        continue;
                    string key1 = keys[0].Trim().Trim(':');
                    string value1 = keys[1].Trim().Trim(':');
                    table.SetValue(key1, value1);
                }
                return true;
            }
            catch (Exception ex1)
            {
                return false;
            }
            return false;
        }
        internal  bool FromJsonUrl<MyTable>(MyTable table, string jsonStr) where MyTable : ITable, new()
        {
            try
            {
                MyTable table2 = FromJsonUrl<MyTable>(jsonStr);
            }
            catch (Exception ex)
            {
                ConsoleService.Error("FromJson204:" + ex.Message + "|" + jsonStr);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 实体类转为json字符串
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytable"></param>
        /// <returns></returns>
        public string ToJson<MyTable>(MyTable mytable) where MyTable : ITableImplement, new()
        {
            return ToJson(mytable, 0);
        }
        /// <summary>
        /// 实体类数组转为json字符串
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytableList"></param>
        /// <returns></returns>
        public string ToJson<MyTable>(List<MyTable> mytableList) where MyTable : ITableImplement, new()
        {
            return ToJson(mytableList, 0);
        }
        /// <summary>
        /// 实体类数组转为json字符串
        /// [
        ///    {\"examId\":4052110,\"paperInfo\":\"111\"},
        ///    {\"examId\":4052110,\"paperInfo\":\"111\"}
        ///  ]
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytableList"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string ToJson<MyTable>(List<MyTable> mytableList, int length) where MyTable : ITableImplement, new()
        {
            StringBuilder output = new StringBuilder("[");
            int count = 0;
            foreach (MyTable table1 in mytableList)
            {
                count++;
                string json1 = ToJson(table1);
                output.Append(json1).Append(",");//table1.ToJson()
            }
            StringBuilder output1 = new StringBuilder(output.ToString().TrimEnd(',')).Append("]");
            return output1.ToString();
        }
        public string ToJsonZh<MyTable>(MyTable mytable) where MyTable : ITable, new()
        {
            StringBuilder output = new StringBuilder("{");
            int count = 0;
            try
            {
                List<AttributeItem> attrs = mytable.af_GetAttributes();
                foreach (AttributeItem attr in attrs)
                {
                    object value = attr.ZhName;
                    //if (value != null)
                    {
                        string value1 = Convert.ToString(value);
                        //if ((length > 0 && value1.Length > length) || value1.Length > Length)
                        //{
                        //    value1 = StringHelper.CutString(value1, length);
                        //}
                        value1 = filterJson(value1);
                        if (isDebug)
                        {
                            output.Append("\"").Append(attr.FieldName + "_zh").Append("\"").Append(":").Append("\"").Append(value1).Append("\"").Append(",");
                        }
                        count++;
                    }
                }
                output.Append(mytable.af_JsonAppend());//.Append(",");
            }
            catch (Exception ex)
            {
                ConsoleService.Error("ToJson235:" + ex.StackTrace);
            }
            StringBuilder output1 = new StringBuilder(output.ToString().TrimEnd(',')).Append("}");
            return output1.ToString();
        }
        public bool isLower = false;
        public bool isHeadLower = false;
        public string ToJsonKeyValue<MyTable>(MyTable mytable, int length) where MyTable : ITableImplement, new()
        {
            StringBuilder output = new StringBuilder(256);
            int count = 0;
            try
            {
                List<object> values = new List<object>();
                AttributeItem[] attrs = mytable.af_GetAvailableAttributeItem(ref values);
                for (int i = 0; i < attrs.Length; i++)
                {
                    AttributeItem attr = attrs[i];
                    object value = values[i];
                    //if (value != null)
                    {
                        string value1 = Convert.ToString(value);
                        if (value1.Length == 4)
                        {
                            if (value1 == "True") value1 = "true";
                        }
                        else if (value1.Length == 5)
                        {
                            if (value1 == "False") value1 = "false";
                        }
                        else if ((length > 0 && value1.Length > length) || value1.Length > Length)
                        {
                            value1 = StringHelper.CutString(value1, length);
                        }
                        //if (value1.Length < 100)
                        if (attr.jsonPre.Length > 0)//字符串才需要转义
                            value1 = filterJson(value1);
                        if (isLower)
                            output.Append("\"").Append(attr.FieldName.ToLower()).Append("\"").Append(":");
                        else if (isHeadLower)
                            output.Append("\"").Append(attr.FieldName[0].ToString().ToLower()).Append(attr.FieldName.Substring(1)).Append("\"").Append(":");
                        else
                            output.Append("\"").Append(attr.FieldName).Append("\"").Append(":");

                        //if (attr.FieldName.ToLower() == "hasAuthenticate".ToLower())
                        //{

                        //}
                        //public string enumTemplate = "{\"chinese\": \"zhname\",\"key\": \"value\"}";
                        //attr.GetJson(ref output, value1);
                        attr.GetJson(ref output, value1, isEnumChinese);//枚举量

                        output.Append(",");
                        count++;
                    }
                }
                //zlg重点
                Dictionary<List<ITableImplement>, string> Sub1 = mytable.Sub1();
                if (Sub1 != null)
                {
                    foreach (List<ITableImplement> list1 in Sub1.Keys)
                    {
                        string tbName = Sub1[list1];
                        if (string.IsNullOrEmpty(tbName) && list1 != null)
                        {
                            tbName = list1[0]._TableName;//TableName();
                        }
                        output.Append("\"").Append(tbName).Append("\"").Append(":");
                        output.Append(ToJson(list1));
                        output.Append(",");
                    }
                }
                Dictionary<ITableImplement, string> Sub2 = mytable.Sub2();
                if (Sub2 != null)
                {
                    foreach (ITableImplement list1 in Sub2.Keys)
                    {
                        string tbName = Sub2[list1];
                        if (string.IsNullOrEmpty(tbName) && list1 != null)
                        {
                            tbName = list1._TableName;//.TableName();
                        }
                        output.Append("\"").Append(tbName).Append("\"").Append(":");
                        output.Append(ToJson(list1));
                        output.Append(",");
                    }
                }
                Dictionary<string, string> Sub3 = mytable.Sub3();
                if (Sub3 != null)
                {
                    foreach (string list1 in Sub3.Keys)
                    {
                        string tbName = Sub3[list1];
                        if (string.IsNullOrEmpty(tbName) && list1 != null)
                        {
                            continue;// tbName = list1.TableName();
                        }
                        output.Append("\"").Append(tbName).Append("\"").Append(":");
                        output.Append(list1);
                        output.Append(",");
                    }
                }
                output.Append(mytable.af_JsonAppend());//.Append(",");
            }
            catch (Exception ex)
            {
                ConsoleService.Error("ToJson235:" + ex.StackTrace);
            }
            StringBuilder output1 = new StringBuilder(output.ToString().TrimEnd(','));
            return output1.ToString();
        }
        /// <summary>
        /// 实体类转为json字符串
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytable"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string ToJson<MyTable>(MyTable mytable, int length) where MyTable : ITableImplement, new()
        {
            StringBuilder output = new StringBuilder("{")
                .Append(ToJsonKeyValue(mytable, 0).TrimEnd(',')).Append("}");
            return output.ToString();
        }

        private  string replaceFenGe = "`br`";
        /// <summary>
        /// 为url写的缩略型json串
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytable"></param>
        /// <returns></returns>
        public  string ToJsonUrl<MyTable>(MyTable mytable, int length) where MyTable : ITable, new()
        {
            StringBuilder output = new StringBuilder(256);
            int count = 0;
            try
            {
                List<AttributeItem> attrs = mytable.af_GetAttributes();
                foreach (AttributeItem attr in attrs)
                {
                    object value = mytable.GetValue(attr);
                    //if (value != null)
                    {
                        string value1 = Convert.ToString(value);
                        if ((length > 0 && value1.Length > length) || value1.Length > Length)
                            value1 = "";

                        if (value1 != null && value1.Contains("|"))
                            value1 = StringHelper.ReplaceNonCase(value1, "|", replaceFenGe);

                        output.Append(attr.FieldName).Append("`").Append(value1).Append("|");
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleService.Error("ToJson235:" + ex.StackTrace);
            }
            try
            {
                if (!string.IsNullOrEmpty(mytable.af_WhereSQL))
                {
                    string where1 = mytable.af_WhereSQL;
                    if (where1.Contains("|"))
                        where1 = StringHelper.ReplaceNonCase(where1, "|", replaceFenGe);
                    output.Append("af_where").Append("`").Append(where1).Append("|");
                    count++;
                }
                if (!string.IsNullOrEmpty(mytable.af_TopText))
                {
                    output.Append("af_top").Append("`").Append(mytable.af_TopText).Append("|");
                    count++;
                }
                if (mytable.af_PageByAttributeItem != null)
                {
                    string orderstr = mytable.af_PageByAttributeItem.LongName;
                    output.Append("af_pageby").Append("`").Append(orderstr).Append("|");
                    count++;
                }
                if (mytable.af_PageByOrder != default(Order))
                {
                    int orderstr = (int)mytable.af_PageByOrder;
                    output.Append("af_pagebyorder").Append("`").Append(orderstr).Append("|");
                    count++;
                }
                if (mytable.af_OrderByItem != null && mytable.af_OrderByItem.Count > 0)
                {
                    string orderstr = OrderByItem.Serialize(mytable.af_OrderByItem);
                    output.Append("af_orderby").Append("`").Append(orderstr).Append("|");
                    count++;
                }
            }
            catch (Exception ex)
            {
                ConsoleService.Error("ToJson270:" + ex.StackTrace);
            }

            output.Insert(0, count + "|");//校验位     
            output.Insert(0, mytable._TableName + "|");//表名     
            return output.ToString().TrimEnd('|');
        }
        /// <summary>
        /// 为url写的缩略型json串
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <param name="mytable"></param>
        /// <returns></returns>
        public  string ToJsonUrl<MyTable>(MyTable mytable) where MyTable : ITable, new()
        {
            return ToJsonUrl(mytable, 0);
        }


        /// <summary>
        /// 手工建立json对象字符串
        /// </summary>
        public  string ToJson(string tbname, Dictionary<string, string> dics)
        {
            StringBuilder output = new StringBuilder(256);
            try
            {
                int count = 0;
                foreach (string key in dics.Keys)
                {
                    object value = dics[key];
                    if (key != null && value != null)
                    {
                        output.Append(key).Append("`").Append(value).Append("|");
                        count++;
                    }
                }
                output.Insert(0, count + "|");//校验位
            }
            catch (Exception ex)
            {
                ConsoleService.Error("ToJson:" + ex.Message + ex.StackTrace);
            }
            return output.ToString();
        }

        //DataTable转成Json
        public  string DataTableToJson(string jsonName, DataTable dt)
        {
            StringBuilder Json = new StringBuilder(256);
            Json.Append("{\"" + jsonName + "\":[");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Json.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Json.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":\"" + dt.Rows[i][j].ToString() + "\"");
                        if (j < dt.Columns.Count - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");
                    if (i < dt.Rows.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("]}");
            return Json.ToString();
        }

        //List转成json
        public  string ObjectToJson<T>(string jsonName, IList<T> IL)
        {
            StringBuilder Json = new StringBuilder(256);
            Json.Append("{\"" + jsonName + "\":[");
            if (IL.Count > 0)
            {
                for (int i = 0; i < IL.Count; i++)
                {
                    T obj = Activator.CreateInstance<T>();
                    Type type = obj.GetType();
                    PropertyInfo[] pis = type.GetProperties();
                    Json.Append("{");
                    for (int j = 0; j < pis.Length; j++)
                    {
                        Json.Append("\"" + pis[j].Name.ToString() + "\":\"" + pis[j].GetValue(IL[i], null) + "\"");
                        if (j < pis.Length - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");
                    if (i < IL.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("]}");
            return Json.ToString();
        }
    }
}


///// <summary>
//        /// 
//        /// </summary>
//        /// <typeparam name="MyTable"></typeparam>
//        /// <param name="jsonStr"></param>
//        /// <returns></returns>
//        public  MyTable FromJson1<MyTable>(string jsonStr, MyTable mytable) where MyTable : IUserXml, new()
//        {
//            int count = 0;
//            try
//            {
//                StringBuilder output = new StringBuilder(jsonStr);
//                int head = jsonStr.IndexOf("|");
//                if (head != 0)
//                    count = Convert.ToInt32(jsonStr.Substring(0, head).Trim());
//                if (count == 0)
//                    return mytable;
//                output.Remove(0, head + 1);
//                string[] ps = output.ToString().Split('|');
//                foreach (string p in ps)
//                {
//                    if (p.Length > 0)
//                    {
//                        string[] names = p.Split('`');
//                        if (names.Length == 2)
//                        {
//                            string fieldname = names[0];
//                            string value = names[1];
//                            mytable.SetValue(new AttributeItem(mytable.GetType().Name, fieldname), value);
//                            count--;
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                ConsoleService.Error("FromJson058:" + ex.Message + ex.StackTrace);
//            }
//            if (count < 0)
//                ConsoleService.Warn("FromJson's crc is wrong, count = " + count);
//            return mytable;
//            //MyTable output = Newtonsoft.Json.JavaScriptConvert.DeserializeObject<MyTable>(jsonStr);
//            //return output;
//        }
//        public  string ToJson1<MyTable>(MyTable mytable) where MyTable : IUserXml, new()
//        {
//            StringBuilder output = new StringBuilder(256);
//            try
//            {
//                List<AttributeItem> attrs = mytable._GetAttributes();
//                int count = 0;
//                foreach (AttributeItem attr in attrs)
//                {
//                    object value = mytable.GetValue(attr);
//                    if (value != null && value.ToString().Length < Length)
//                    {
//                        output.Append(attr.FieldName).Append("`").Append(value).Append("|");
//                        count++;
//                    }
//                }
//                output.Insert(0, count + "|");//校验位
//            }
//            catch { }
//            return output.ToString();
//        }