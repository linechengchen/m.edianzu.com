using AgileFrame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ScHelper 的摘要说明
/// </summary>
public class ScHelper
{
	public ScHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static AFDictionary<string, string> dic1 = new AFDictionary<string, string>();
    public static AFDictionary<string, string> getScOld()
    {
        if (dic1.Count > 0)
            return dic1;
        string sc2sc = @"196=1952
198=1953
205=2042
208=2072
246=2162
235=2252
236=2253
350=3102
351=3103

352=3122
342=3123

360=3202
747=7462
797=7872

795=7912
796=7913
";
        foreach (string s1 in sc2sc.Split('\n'))
        {
            if (!string.IsNullOrEmpty(s1))
            {
                string[] s2s = s1.Split('=');
                if (s2s.Length == 2)
                {
                    if (!dic1.ContainsKey(s2s[0]))
                        dic1.Add(s2s[0], s2s[1]);
                }
            }
        }
        return dic1;
    }

    public static string getSc(System.Web.UI.Page p1)
    {
        return getSc(p1.Request["sc"]);
    }

    public static string getSc(string sc)
    {
        string sc1 = "";
        if (!string.IsNullOrEmpty(sc))
        {
            AFDictionary<string, string> dic1 = getScOld();
            sc1 = Convert.ToString(sc).Trim();
            if (!string.IsNullOrEmpty(sc1) && dic1.ContainsKey(sc1))
            {
                return dic1[sc1];
            }
        }
        return sc1;
    }
}