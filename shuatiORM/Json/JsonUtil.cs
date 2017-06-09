using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Json;
using System.Web;

/// <summary>
/// JsonUtil 的摘要说明
/// </summary>
public class JsonUtil
{
	public JsonUtil()
	{
		
	}
    public static JsonObjectCollection getJsonObj<MyTable>(MyTable item, string jsonName) where MyTable : ITableImplement, new()
    {
        //item.SetValue(new AttributeItem("name"), object1);
        JsonObjectCollection obj = new JsonObjectCollection();
        List<object> listObj = new List<object>();
        AttributeItem[] attrList = item.af_GetAvailableAttributeItem(ref listObj);
        for (int i = 0; i < attrList.Length; i++)
        {
            if (listObj[i] is MyTable)
            {
                MyTable item1 = listObj[i] as MyTable;
                obj.Add(getJsonObj(item1, attrList[i].FieldName));
            }
            else if (listObj[i] is List<MyTable>)
            {
                List<MyTable> item2 = listObj[i] as List<MyTable>;
                obj.Add(getJsonObj(item2, attrList[i].FieldName));
            }
            else if (listObj[i] is ITableImplement)
            {
                List<ITableImplement> item2 = listObj[i] as List<ITableImplement>;
                obj.Add(getJsonObj(item2, attrList[i].FieldName));
            }
            else if (listObj[i] is List<ITableImplement>)
            {
                List<ITableImplement> item2 = listObj[i] as List<ITableImplement>;
                obj.Add(getJsonObj(item2, attrList[i].FieldName));
            }
            else
                obj.Add(new JsonStringValue(attrList[i].FieldName, Convert.ToString(listObj[i])));
        }
        if (!string.IsNullOrEmpty(jsonName))
            obj.Name = jsonName;
        return obj;
    }
    public static List<ITableImplement> getTable<MyTable>(List<MyTable> item1) where MyTable : ITableImplement, new()
    {
        List<ITableImplement> itemlist2 = new List<ITableImplement>();
        foreach (ITableImplement item in item1)
        {
            itemlist2.Add(item);
        }
        return itemlist2;
    }
    public static ITableImplement getTable<MyTable>(MyTable item1) where MyTable : ITableImplement, new()
    {
        return (ITableImplement)item1;
    }
    //{"data":{ "retFlag": 0, "message": "登录成功。", "user_id": 1, "userName": "sys", "realName": "管理员", "userType": 1, "roleIDS": "", "email": "", "staffID": 21, "staffName": "管理员", "deptID": 105, "deptName": "", "orgID": 0, "orgName": "", "myDeptIDS": "" },"response":"Checklogin"}
    //private string getJson<MyTable>(MyTable item) where MyTable : ITableImplement, new()
    //{
    //    return getJsonObj(item).ToString();
    //}
    public static JsonArrayCollection getJsonObj<MyTable>(List<MyTable> list, string jsonName) where MyTable : ITableImplement, new()
    {
        JsonArrayCollection arrs = new JsonArrayCollection();
        foreach (MyTable item in list)
        {
            arrs.Add(getJsonObj(item, ""));
        }
        arrs.Name = jsonName;
        return arrs;
    }
    //private JsonArrayCollection getJsonObj<MyTable>(List<List<MyTable>> listList, string jsonName) where MyTable : ITableImplement, new()
    //{
    //    JsonArrayCollection arrs = new JsonArrayCollection();
    //    foreach (List<MyTable> list in listList)
    //    {
    //        arrs.Add(getJsonObj(list, jsonName));
    //    }
    //    return arrs;
    //}
    public static string getJsonStr<MyTable>(Object item) where MyTable : ITableImplement, new()
    {
        //if (item is object)
        //{
        //    object a = new object();
        //}
        //else if (item is List<WEC_CY_ORDER>) {
        //    object a = new object();
        //}

        if (item is MyTable)
        {
            MyTable item1 = item as MyTable;
            return getJsonObj(item1, "").ToString();
        }
        else if (item is List<MyTable>)
        {
            List<MyTable> item2 = item as List<MyTable>;
            return getJsonObj(item2, "").ToString();

        }
        return "";
        //if (item is List<List<MyTable>>)
        //{
        //    List<List<MyTable>> item3 = item as List<List<MyTable>>;
        //    return getJsonObj(item3, "").ToString();
        //}
    }
}