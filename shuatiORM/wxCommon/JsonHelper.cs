/// <summary>
/// FileName: JSONHelper.cs
/// CLRVersion: 2.0.50727.3623
/// Author: Mikel
/// Corporation:
/// Description:JSON格式数据转换助手类
/// 1.将List<T>类型的数据转换为JSON格式
/// 2.将T类型对象转换为JSON格式对象
/// 3.将JSON格式对象转换为T类型对象
/// DateTime: 2011-09-13 14:11:34
/// </summary>
using System;
using System.Collections.Generic;
//using Newtonsoft.Json;  
public static class JsonHelper
{
    /// <summary>
    /// 转换对象为JSON格式数据
    /// </summary>
    /// <typeparam name="T">类</typeparam>
    /// <param name="obj">对象</param>
    /// <returns>字符格式的JSON数据</returns>
    public static string GetJSON<T>(object obj)
    {
        string result = String.Empty;
        try
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer =
            new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                result = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }
    /// <summary>
    /// 转换List<T>的数据为JSON格式
    /// </summary>
    /// <typeparam name="T">类</typeparam>
    /// <param name="vals">列表值</param>
    /// <returns>JSON格式数据</returns>
    public static string JSON<T>(List<T> vals)
    {
        System.Text.StringBuilder st = new System.Text.StringBuilder();
        try
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer s = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));

            foreach (T city in vals)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    s.WriteObject(ms, city);
                    st.Append(System.Text.Encoding.UTF8.GetString(ms.ToArray()));
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return st.ToString();
    }
    /// <summary>
    /// JSON格式字符转换为T类型的对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonStr"></param>
    /// <returns></returns>
    public static T ParseObjectByJson<T>(string jsonStr)
    {
        T obj = Activator.CreateInstance<T>();
        using (System.IO.MemoryStream ms =
        new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonStr)))
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer =
            new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));
            return (T)serializer.ReadObject(ms);
        }
    }
}