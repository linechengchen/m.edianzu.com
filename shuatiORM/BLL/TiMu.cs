using AgileFrame.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// TiMu 的摘要说明
/// </summary>
public class TiMuXuanZe
{
    public string sourcefile = "";
    public string sourceid = "";
    public string zhangjie = "1";
    public string id = "";
    public string tixing = "";
    public string questionstr = "";
    public string optionstr = "";
    public string answerstr = "";
    public string fav = "0";
    public string jiexi = "";

    public int optionnum = 0;
    public string txt = "";
    public string file = "";
    public List<string> listOption = new List<string>();

    //只有这里与 导入软件有关。保存到文件
    public string ToStringSave()
    {
        return "|源件:" + file + "\n|源件id:" + sourceid + "\n|章节:" + zhangjie + "\n|编号:" + id + "\n|题型:" + tixing + "\n|考题:" + questionstr.Replace("\"", "").Replace("|", "").Replace("`", "") + "\n|选项:"
            + optionstr.Replace("\"", "").Replace("`", "")
            + "\n|答案:" + answerstr.Replace("\"", "").Replace("|", "").Replace("`", "")
            + "\n|解析:" + jiexi.Replace("\"", "").Replace("|", "").Replace("`", "")

            + "\n";
    }

    public TiMuXuanZe()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public override string ToString()
    {
        return this.file + "|章节:" + zhangjie + "\n|编号:" + id + "\n|题型:" + tixing + "\n|考题:" + questionstr.Replace("\"", "").Replace("|", "").Replace("`", "") + "\n|选项:"
            + optionstr.Replace("\"", "").Replace("|", "").Replace("`", "")
            + "\n|答案:" + answerstr.Replace("\"", "").Replace("|", "").Replace("`", "") + "\n|"
            + "\n|解析:" + answerstr.Replace("\"", "").Replace("|", "").Replace("`", "") + "\n|";
    }
    public string toJson()
    {
        string jsonText =
            "{" +
            "\"id\":\"" + id + "\"," +
            "\"tixing\":\"" + tixing + "\"," +
            "\"questionstr\":\"" + questionstr + "\"," +
            "\"optionstr\":\"" + optionstr + "\"," +
            "\"answerstr\":\"" + answerstr + "\"," +
            "\"fav\":\"" + fav + "\"" +
            "\"jiexi\":\"" + jiexi + "\"" +
            "}";
        return jsonText;
    }

    public static TiMuXuanZe From(string s1)
    {
        TiMuXuanZe t1 = new TiMuXuanZe();
        try
        {
            if (s1.Contains("题型:2"))
            {

            }
            t1.sourcefile = (StringHelper.CutString(s1, "|源件:", "|源件").Trim('\n').Trim());
            t1.sourceid = (StringHelper.CutString(s1, "|源件id:", "|章节").Trim('\n').Trim());
            t1.zhangjie = (StringHelper.CutString(s1, "|章节:", "|编号").Trim('\n').Trim());
            t1.id = (StringHelper.CutString(s1, "|编号:", "|题型").Trim('\n').Trim());
            t1.tixing = (StringHelper.CutString(s1, "|题型:", "|考题").Trim('\n').Trim());
            t1.questionstr = StringHelper.CutString(s1, "|考题:", "|选项").Trim('\n').Trim();
            t1.optionstr = StringHelper.CutString(s1, "|选项:", "|答案").Trim('\n').Replace("|A", "A").Trim();
            t1.answerstr = StringHelper.CutString(s1, "|答案:", "|解析").Trim('\n').Trim();
            t1.jiexi = StringHelper.CutString(s1, "|解析:", "").Trim('\n').Trim();
        }
        catch (Exception ex)
        {
            Cs.Error(ex.ToString());
        }
        if (t1.id == "") return null;
        if (t1.questionstr == "") return null;
        if ((t1.tixing == "0" || t1.tixing == "1") && t1.optionstr == "") return null;
        if (t1.answerstr == "") return null;
        return t1;
    }

    public static AFDictionary<string, TiMuXuanZe> fromTxt(string fileName)
    {
        AFDictionary<string, TiMuXuanZe> timulist = new AFDictionary<string, TiMuXuanZe>();
        try
        {
            if (File.Exists(fileName))
            {
                string content1 = File.ReadAllText(fileName, System.Text.Encoding.Default);
                content1 = content1.Replace("\r\n", "\n").Replace("\r\n\r\n", "");

                string[] clist = StringHelper.Split(content1, "/**********/");

                foreach (string s1 in clist)
                {
                    if (s1.Contains("题型:2"))
                    {

                    }
                    TiMuXuanZe t1 = From(s1);
                    if (t1 != null)
                    {
                        t1.id = (timulist.Count + 1).ToString();
                        try
                        {
                            if (!timulist.ContainsKey(t1.id))
                                timulist.Add(t1.id, t1);
                        }
                        catch (Exception ex2)
                        {
                            Cs.Error(ex2.ToString());
                        }
                    }
                }
                Cs.Warn(fileName + ",读题目：" + timulist.Count);
            }
        }
        catch (Exception ex)
        {
            Cs.Error(ex.ToString());
        }
        return timulist;
    }
    public string getQuestion()
    {
        return "";
    }
}
