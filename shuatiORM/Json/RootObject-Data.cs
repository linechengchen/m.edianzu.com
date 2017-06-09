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

namespace System.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonData
    {
        public JsonData(bool isDebug)
        {
            this.isDebug = isDebug;
            dic1 = new AFDictionary<string, string>();
            tablelist = new List<ITableImplement>();
        }

        #region 1数据操作代码-子data也可以有
        public int[] linkPageNumbers = new int[] { 1 };// { get; set; }
        public int pageNum = -1;// { get; set; }
        public int pageSize = -1;// { get; set; }
        public int totalCount = -1;// { get; set; }
        public int totalPageNum = -1;// { get; set; }

        public bool isDebug = false;

        //public AFDictionary<string, int> dicJson1 { get; set; }
        public AFDictionary<string, string> dic1 { get; set; }
        public AFDictionary<string, string> dic2 { get; set; }

        public AFDictionary<AttributeItem, string> dic5 { get; set; }

        public ITableImplement table { get; set; }
        public List<ITableImplement> tablelist { get; set; }

        public string tableName;
        public string tablelistName = null;
        public List<JsonData> datalist1 { get; set; }//数组对象内嵌套
        public JsonData subData
        {
            get
            {
                initDataList();
                JsonData data1 = new JsonData(isDebug);
                datalist1.Add(data1);
                return data1;
            }
        }
        public AFDictionary<string, string> topDic1 { get; set; }

        public JsonData Add(ITableImplement table, string tableName)
        {
            return Add(tableName, table);
        }
        public JsonData Add(string tableName, ITableImplement table)
        {
            this.tableName = tableName;
            this.table = table;
            return this;
        }
        public JsonData Add(ITableImplement table)
        {
            this.table = table;
            return this;
        }
        public JsonData Add<MyTable>(List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            return Add("", tablelist);
        }
        public JsonData Add<MyTable>(List<MyTable> tablelist, string tablelistName) where MyTable : ITableImplement, new()
        {
            return Add(tablelistName, tablelist);
        }
        public JsonData Add<MyTable>(string tablelistName, List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            if (tablelist == null || tablelist.Count == 0) return  this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelist = new List<AgileFrame.Orm.PersistenceLayer.Model.ITableImplement>();
            this.tablelist.AddRange(tablelist);
            return this;
        }
        private string tablelistJson;
        public JsonData Add(string tablelistName, string tablelistJson, int pageSize, int pageIndex, int count)
        {
            if (tablelistJson == null || tablelistJson.Length == 0) return this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelistJson = tablelistJson;
            this.pageNum = pageIndex;
            this.pageSize = pageSize;
            this.totalCount = count;
            this.totalPageNum = 1 + (count / pageSize);
            List<int> list1 = new List<int>();
            for (int i = 0; i < totalPageNum; i++)
            {
                list1.Add(i);
            }
            this.linkPageNumbers = list1.ToArray();
            return this;
        }
        public JsonData Add<MyTable>(string tablelistName, List<MyTable> tablelist, int pageSize, int pageIndex, int count) where MyTable : ITableImplement, new()
        {
            if (tablelist == null || tablelist.Count == 0) return this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelist = new List<AgileFrame.Orm.PersistenceLayer.Model.ITableImplement>();
            this.tablelist.AddRange(tablelist);
            this.pageNum = pageIndex;
            this.pageSize = pageSize;
            this.totalCount = count;
            this.totalPageNum = 1 + (count / pageSize);
            List<int> list1 = new List<int>();
            for (int i = 0; i < totalPageNum; i++)
            {
                list1.Add(i);
            }
            this.linkPageNumbers = list1.ToArray();
            return this;
        }
        //public JsonData Add(string json1)
        //{
        //    if (!dicJson1.ContainsKey(json1))
        //        dicJson1.Add(json1, 1);
        //    return this;
        //}
        public JsonData AddTop(string key1, string value)
        {
            if (topDic1 == null) topDic1 = new AFDictionary<string, string>();
            if (!topDic1.ContainsKey(key1))
                topDic1.Add(key1, value);
            else
                topDic1[key1] = value;
            return this;
        }
        public void initDataList()
        {
            if (datalist1 == null)
                datalist1 = new List<JsonData>();
        }
        #endregion 数据操作代码-子data也可以有
        
        //public void Add<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        //{
        //    if (this.data1 == null)
        //        this.data1 = new JsonData(isDebug);
        //    data1.Add(table1);
        //}
        //public void AddSub<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        //{
        //    if (this.datalist1 == null)
        //        this.datalist1 = new List<JsonData>();
        //    JsonData data = new JsonData(isDebug);
        //    data.Add(table1);
        //    datalist1.Add(data);
        //}
        //public void AddSub<MyTable>(List<MyTable> listTable1) where MyTable : ITableImplement, new()
        //{
        //    if (this.datalist1 == null)
        //        this.datalist1 = new List<JsonData>();
        //    JsonData data = new JsonData(isDebug);
        //    data.Add(listTable1);
        //    datalist1.Add(data);
        //}
        public JsonData Add<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        {
            this.table = table1;
            return this;
        }
        public JsonData Add(string key1, int value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, double value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, float value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, decimal value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, bool value1)
        {
            if (value1)
                return Add2(key1, "true");
            else
                return Add2(key1, "false");
        }
        public JsonData Add2(string key1, string value1)
        {
            if (dic2 == null) dic2 = new AFDictionary<string, string>();
            if (!dic2.ContainsKey(key1))
                dic2.Add(key1, Convert.ToString(value1));
            else
                dic2[key1] = Convert.ToString(value1);
            return this;
        }
        public JsonData Add(string key1, string value)
        {
            if (dic1 == null) dic1 = new AFDictionary<string, string>();
            if (!dic1.ContainsKey(key1))
                dic1.Add(key1, value);
            else
                dic1[key1] = value;
            return this;
        }
        public JsonData Add(Dictionary<string, string> dic1)
        {
            foreach (string key1 in dic1.Keys)
            {
                Add(key1, dic1[key1]);
            }
            return this;
        }
        public JsonData Add(AttributeItem attr, string value)
        {
            return Add(attr.FieldName, value);
        }
        /// <summary>
        /// 枚举字段转变为json对象！
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public JsonData AddEnum(AttributeItem attr)
        {
            if (dic5 == null) dic5 = new AFDictionary<AttributeItem, string>();
            if (!dic5.ContainsKey(attr))
                dic5.Add(attr, attr.FieldNameHeadLower);
            return this;
        }
        /// <summary>
        /// 枚举字段转变为json对象！
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public JsonData AddEnum(string keyName, AttributeItem attr)
        {
            if (dic5 == null) dic5 = new AFDictionary<AttributeItem, string>();
            if (!dic5.ContainsKey(attr))
                dic5.Add(attr, keyName);
            return this;
        }
        public string ToJson(bool jiami, bool isShuati, bool isHeadLower, bool isLower)
        {
            #region 2data数据
            JsonService jsobj = new JsonService(isDebug);
            jsobj.isHeadLower = isHeadLower;
            jsobj.isLower = isLower;
            jsobj.isEnumChinese = !isShuati;

            StringBuilder sbData = new StringBuilder(256);
            if (table != null && table.IsNotNull())
            {
                if (isDebug)
                {
                    string js2 = jsobj.ToJsonZh(table);
                    sbData.Append("\"").Append(table._TableName + "_zh").Append("\":").Append(js2)
                        .Append(",");
                }
                if (!string.IsNullOrEmpty(tableName))
                {
                    sbData.Append("\"").Append(tableName).Append("\"").Append(":");
                    sbData.Append(jsobj.ToJson(table)).Append(",");
                }
                else
                {
                    string sb1 = jsobj.ToJson(table);
                    if (sb1.StartsWith("{"))
                        sbData.Append(sb1.Substring(1, sb1.Length - 2)).Append(",");
                    else
                        sbData.Append(sb1).Append(",");
                }
                if (datalist1 != null && datalist1.Count > 0)
                {
                    StringBuilder sb2 = new StringBuilder(256);
                    foreach (JsonData data2 in datalist1)
                    {
                        string json5 = data2.ToJson(false, isShuati, isHeadLower, isLower);//.TrimEnd(',')
                        if (string.IsNullOrEmpty(json5)) continue;
                        sb2.Append(json5);//.Append(",");
                    }
                    if (sb2.Length > 0)
                        sbData.Append(sb2);
                }
            }
            if (tablelist != null && tablelist.Count > 0)
            {
                tablelistJson = jsobj.ToJson(tablelist);
                if (string.IsNullOrEmpty(tablelistName))
                    tablelistName = tablelist[0]._TableName;
            }
            if (!string.IsNullOrEmpty(tablelistJson))
            {
                if (!isShuati)//非刷题！isShuati带有list
                {
                    if (!string.IsNullOrEmpty(tablelistName))
                    {
                        if (pageNum != -1)//分页页码
                        {
                            //sbData.Append("\"linkPageNumbers\":").Append("[");
                            //if (linkPageNumbers != null && linkPageNumbers.Length > 0)
                            //{
                            //    foreach (int i in linkPageNumbers)
                            //        sbData.Append(i).Append(",");
                            //    sbData.Remove(sbData.Length - 1, 1);
                            //}
                            //sbData.Append("]").Append(",");
                            sbData.Append("\"pageNum\":").Append(pageNum).Append("").Append(",");
                            sbData.Append("\"pageSize\":").Append(pageSize).Append("").Append(",");
                            sbData.Append("\"totalCount\":").Append(totalCount).Append("").Append(",");
                            sbData.Append("\"totalPageNum\":").Append(totalPageNum).Append("").Append(",");
                        }
                        sbData.Append("\"").Append(tablelistName).Append("\"").Append(":");
                        sbData.Append(tablelistJson)
                            .Append(",");
                    }
                    else
                        sbData.Append(tablelistJson.TrimEnd('}').TrimStart('{'))
                            .Append(",");

                    if (isDebug)
                    {
                        if (tablelist != null && tablelist.Count > 0)
                        {
                            string js2 = jsobj.ToJsonZh(tablelist[0]);
                            sbData.Append("\"").Append(tablelist[0]._TableName).Append("_zh\":").Append(js2)
                                .Append(",");
                        }
                    }
                }
                else//刷题！isShuati带有list
                {
                    sbData.Append("\"").Append(tablelistName).Append("\":");
                    sbData.Append("{");
                    if (totalCount >= 0)
                        sbData.Append("\"total\":\"").Append(totalCount).Append("\"").Append(",");
                    if (pageNum >= 0)
                        sbData.Append("\"pageIndex\":\"").Append(pageNum).Append("\"").Append(",");

                    if (isDebug)
                    {
                        if (tablelist != null && tablelist.Count > 0)
                        {
                            string js2 = jsobj.ToJsonZh(tablelist[0]);
                            sbData.Append("\"list_zh\":").Append(js2).Append(",");
                        }
                    }
                    sbData.Append("\"list\":").Append(tablelistJson);
                    sbData.Append("},");
                }
            }
            if (dic1 != null && dic1.Count > 0)
            {
                foreach (string key1 in dic1.Keys)
                {
                    string value1 = dic1[key1];
                    if (!string.IsNullOrEmpty(value1) && (value1.StartsWith("[") || value1.StartsWith("{")))
                        sbData.Append("\"").Append(key1).Append("\":").Append((value1));
                    else
                        sbData.Append("\"").Append(key1).Append("\":").Append("\"").Append(JsonService.filterJson(value1)).Append("\"");
                    sbData.Append(",");
                }
            }
            if (dic2 != null && dic2.Count > 0)
            {
                foreach (string key1 in dic2.Keys)
                {
                    string value1 = dic2[key1];
                    sbData.Append("\"").Append(key1).Append("\":").Append(JsonService.filterJson(value1));
                    sbData.Append(",");
                }
            }
            if (dic5 != null && dic5.Count > 0)
            {
                foreach (AttributeItem key1 in dic5.Keys)
                {
                    //if (string.IsNullOrEmpty(key1.Desc))
                    //    key1.Desc = key1.DataBaseField
                    string enum1 = key1.GetEnumJson(dic5[key1]);
                    if (!string.IsNullOrEmpty(enum1))
                    {
                        sbData.Append(enum1);
                        sbData.Append(",");
                    }
                }
            }
            #endregion data数据-子data也可以有
            return sbData.ToString();
        }
        /*
        public string ToJson2(bool jiami, bool isShuati, bool isHeadLower, bool isLower)
        {
            JsonService jsobj = new JsonService(isDebug);
            jsobj.isHeadLower = isHeadLower;
            jsobj.isLower = isLower;

            StringBuilder sbData = new StringBuilder(256);
            string tbName = null;

            if (!string.IsNullOrEmpty(tableName))
            {
                tbName = tableName;
            }
            else if (tablelist.Count > 0)
            {
                tbName = tablelist[0]._TableName;
            }

            if (tablelist != null && tablelist.Count > 0)
            {
                totalCount = tablelist.Count;
                if (isDebug)
                {
                    try
                    {
                        sbData.Append("\"").Append(tbName).Append("_zh").Append("\":\"").Append(tablelist[0]._ZhName).Append("\",");
                    }
                    catch (Exception ex)
                    {
                        Cs.Error("_ZhName:" + ex.ToString());
                    }
                }
                if (isShuati)//带有list
                {
                    sbData.Append("\"").Append(tbName).Append("\":");
                    sbData.Append("{");
                    if (totalCount >= 0)
                        sbData.Append("\"total\":\"").Append(totalCount).Append("\"").Append(",");
                    if (pageNum >= 0)
                        sbData.Append("\"pageIndex\":\"").Append(pageNum).Append("\"").Append(",");

                    if (isDebug)
                    {
                        string js2 = jsobj.ToJsonZh(tablelist[0]);
                        sbData.Append("\"list_zh\":").Append(js2).Append(",");
                    }
                    string js1 = jsobj.ToJson(tablelist);
                    sbData.Append("\"list\":").Append(js1);
                    sbData.Append("},");
                }
                else
                {
                    sbData.Append("\"").Append(tbName).Append("\":");
                    string js1 = jsobj.ToJson(tablelist);
                    sbData.Append(js1); 
                    sbData.Append(",");

                    if (datalist1 != null && datalist1.Count > 0)
                    {
                        foreach (JsonData data2 in datalist1)
                        {
                            sbData.Append(data2.ToJson(false, isShuati, isHeadLower, isLower));
                            sbData.Append(",");
                        }
                    }

                    if (isDebug)
                    {
                        string js2 = jsobj.ToJsonZh(tablelist[0]);
                        sbData.Append("\"").Append(tbName).Append("_zh\":").Append(js2).Append(",");
                    }
                }
            }
            if (table != null && table.IsNotNull())
            {
                if (!string.IsNullOrEmpty(tableName))
                    tbName = tableName;
                else
                    tbName = table._TableName;
                sbData.Append("\"").Append(tbName).Append("\":").Append(jsobj.ToJson(table)).Append(",");
                if (isDebug)
                {
                    string js2 = jsobj.ToJsonZh(table);
                    sbData.Append("\"").Append(tbName + "_zh").Append("\":").Append(js2).Append(",");
                }
            }
            if (dic1 != null && dic1.Count > 0)
            {
                foreach (string key1 in dic1.Keys)
                {
                    string value1 = dic1[key1];
                    sbData.Append("\"").Append(key1).Append("\":").Append("\"").Append(JsonService.filterJson(value1)).Append("\"");
                    sbData.Append(",");
                }
            }
            return sbData.ToString();
        }
        */
    }

    //public class Data<MyTable> where MyTable : ITableImplement, new()
    //{
    //    public MyTable data { get; set; }

    //    public string ToJson()
    //    {
    //        string tbName = data._TableName;
    //        StringBuilder sb1 = new StringBuilder("");
    //        sb1.Append("\"").Append(tbName).Append("\":").Append(new JsonService(isDebug).ToJson(data));

    //        //追加有误   
    //        return sb1.Append("").ToString();
    //    }
    //}
}