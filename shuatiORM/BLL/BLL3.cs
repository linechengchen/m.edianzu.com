using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// BLL3 的摘要说明
/// </summary>
public class BLL3
{ 
    public static AFDictionary<string, string> dicBigZhEn = new AFDictionary<string, string>();
    public static AFDictionary<string, string> dicBigEnZh = new AFDictionary<string, string>();

    public static AFDictionary<string, string> dicZhEn = new AFDictionary<string, string>();
    public static AFDictionary<string, string> dicEnZh = new AFDictionary<string, string>();
    
    static BLL3()
    {
        //大类类名
        dicBigZhEn.Add("会计", "kj");
        dicBigZhEn.Add("司法", "sf");

        //其他科目
        dicZhEn.Add("马克思", "mks");
        dicZhEn.Add("思修", "sx");
        dicZhEn.Add("近代史", "jds");
        dicZhEn.Add("毛概", "mg");
        
        //英语
        dicZhEn.Add("考研英语", "kyyy");
        dicZhEn.Add("英语四级", "yysj");
        dicZhEn.Add("英语六级", "yylj");

        //专业课
        dicZhEn.Add("金融题库", "jrtk");//瓯江
        dicZhEn.Add("军事理论", "jsll");//瓯江

        //医学
        dicZhEn.Add("胞生题库", "bstk");
        dicZhEn.Add("西医综合", "xyzh");

        //会计
        //dicZhEn.Add("会计考试", "kjks");
        //dicZhEn.Add("会计从业2016", "kjcy2016");
        dicZhEn.Add("会计电算化", "kjdsh");
        dicZhEn.Add("会计基础", "kjjc");
        dicZhEn.Add("会计财经法规", "kjcjfg");
        dicZhEn.Add("会计信息系统", "kjxxxx");
        
        //司法
        //dicZhEn.Add("司法考试", "sfks");
        
        foreach (string zh in dicZhEn.Keys)
        {
            dicEnZh.Add(dicZhEn[zh], zh);
        }

        foreach (string zh in dicBigZhEn.Keys)
        {
            dicBigEnZh.Add(dicBigZhEn[zh], zh);
        }
    }

    /// <summary>
    /// 查找 会计 开头的课程
    /// </summary>
    public static AFDictionary<string, string> getSubKcName(string kcName)
    {
        AFDictionary<string, string> dic1 = new AFDictionary<string, string>();
        foreach (string key in dicEnZh.Keys)
        {
            if (key.StartsWith(kcName))
            {
                dic1.Add(key, dicEnZh[key]);
            }
        }
        return dic1;
    }

    public static string getClassZhongWen(string KemuId)
    {
        if (string.IsNullOrEmpty(KemuId)) return "待增加";
        St_kemuInfo val1 = new St_kemuInfo();
        val1.KemuId = 0;
        val1.KemuName = "";
        St_kemuInfo cond1 = new St_kemuInfo();
        cond1.KemuId = Convert.ToInt32(KemuId);
        St_kemuInfo t1 = BLLTable<St_kemuInfo>.GetRowData(val1, cond1);
        if (t1 != null && t1.IsNotNull())
        {
            return t1.KemuName;
        }
        else
        {
            return "待增加";
        }
    }
    public static string getClass(string kcName)
    {
        string title1 = "unload";
        if (dicZhEn.ContainsKey(kcName))
        {
            return dicZhEn[kcName];
        }
        else if (dicBigZhEn.ContainsKey(kcName))
        {
            return dicBigZhEn[kcName];
        }
        return title1;
    }
	public BLL3()
	{
	}
}