using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using 微信运营辅助软件;

public class BLL1
{  
    public static AFDictionary<string, string> iplist = new AFDictionary<string, string>();
    static string _root1 = "";
    public static string root1
    {
        get
        {
            if (_root1 == "" && Directory.Exists(MyConfigurationSettings.GetValue("root")))
            {
                _root1 = MyConfigurationSettings.GetValue("root");
            }
            return _root1;
        }
        set
        {
            _root1 = value;
        }
    }

    protected static AFDictionary<string, St_TTimuDaXue> listMks = new AFDictionary<string, St_TTimuDaXue>();
    protected static AFDictionary<string, St_TTimuDaXue> listJds = new AFDictionary<string, St_TTimuDaXue>();
    protected static AFDictionary<string, St_TTimuDaXue> listMg = new AFDictionary<string, St_TTimuDaXue>();
    protected static AFDictionary<string, St_TTimuDaXue> listSx = new AFDictionary<string, St_TTimuDaXue>();
    public static int readInt = 1;

    public static string file0 = root1 + @"\194瓯江\马克思.txt";

    #region 大学列表分析

    /// <summary>
    /// 3，浙大
    /// </summary>
    public static AFDictionary<string, string> Num_DaxueDic = new AFDictionary<string, string>();
    /// <summary>
    /// 浙大，3
    /// </summary>
    public static AFDictionary<string, string> daxue_NumDic = new AFDictionary<string, string>();
    /// <summary>
    /// 浙大，3浙大
    /// </summary>
    public static AFDictionary<string, string> daxue_NumDaxueDic = new AFDictionary<string, string>();
    /// <summary>
    /// zd,3浙大
    /// </summary>
    public static AFDictionary<string, string> pinyin_NumDaxueDic = new AFDictionary<string, string>();
    //宁大，宁波大学（宁波大学什么分院）
    public static AFDictionary<string, List<string>> daxue_BieMingDic = new AFDictionary<string, List<string>>();
    /// <summary>
    /// 3浙大，浙大
    /// </summary>
    public static AFDictionary<string, string> NumDaxue_daxueDic = new AFDictionary<string, string>();
    /// <summary>
    /// zhedaaibang, 浙大
    /// </summary>
    public static AFDictionary<string, string> wxid_Daxue_DataDic = new AFDictionary<string, string>();

    #endregion 大学列表分析

    public static string file2Wei = root1.Replace("考试题", "") + @"\image\分享\完整版本_num";
    public static string getDaxueName(string scId)
    {
        initDaxue();
        string numDaXue = "";
        if (Num_DaxueDic.TryGetValue(scId, out numDaXue))
        {
            string daxueming1 = StringHelper.GetHanZi(numDaXue);
            if (daxueming1 == "城院") numDaXue = "403商学院";
            numDaXue = daxueming1;
        }
        if(string.IsNullOrEmpty(numDaXue))
        {
            if (Num_DaxueDic.TryGetValue(scId, out numDaXue))
            {
                string daxueming1 = StringHelper.GetHanZi(numDaXue);
                if (daxueming1 == "城院") numDaXue = "403商学院";
                numDaXue = daxueming1;
            }
        }
        return numDaXue;
    }
    public static string getFile(string scId)
    {
        try
        {
            initDaxue();
            if (Directory.Exists(file2Wei))
            {
                string numDaXue = null;
                if (Num_DaxueDic.TryGetValue(scId, out numDaXue))
                {
                    AFDictionary<string, FileInfo> dic1 = btnReNameFile_Click(file2Wei);
                    if (dic1.ContainsKey(numDaXue))
                    {
                        return dic1[numDaXue].Name;
                    }
                    else
                        Cs.Warn(numDaXue + "，找不到文件");
                }
            }
        }
        catch (Exception ex1)
        {
            Cs.Warn(ex1.ToString());
        }
        return scId;
    }
    public static int renameInt = 0;
    public static AFDictionary<string, FileInfo> template_files2 = new AFDictionary<string, FileInfo>();
    public static AFDictionary<string, FileInfo> btnReNameFile_Click(string txtRename1)
    {
        if (template_files2.Count > 0)
            return template_files2;
        renameInt = 0;
        if (!Directory.Exists(txtRename1))
        {
            return template_files2;
        }
        //string[] files = FileService.GetFile(txtRename1);
        int count = 1;
        SortedList<string, FileInfo> template_files1 = FileService.GetFile(txtRename1, "*", ref count);
        bool ret1 = false;
        foreach (string file in template_files1.Keys)
        {
            ret1 = false;
            string f1 = Path.GetFileNameWithoutExtension(file);
            if (f1.StartsWith("~") || f1.StartsWith("="))
                continue;
            if (f1.Contains("树大"))
            {
                "".ToLower();
            }

            string f1DaXue = StringHelper.GetHanZiLianXu(f1);
            if (string.IsNullOrEmpty(f1DaXue))
                continue;

            string f1Num = StringHelper.GetNumericLianXu(f1);

            bool ret2 = false; string daxue11 = "";
            if (daxue_NumDaxueDic.ContainsKey(f1DaXue))
            {
                ret2 = true;
                daxue11 = daxue_NumDaxueDic[f1DaXue];
            }
            else
            {
                foreach (string daxue1 in daxue_NumDaxueDic.Keys)
                {
                    if (string.IsNullOrEmpty(daxue1)) 
                        continue;
                    if (daxue1 == "南大")
                    {
                        daxue1.ToString();
                    }
                    daxue11 = daxue_NumDaxueDic[daxue1];
                    List<string> f1Daxue2 = new List<string>();
                    f1Daxue2.Add(daxue1);
                    if (daxue_BieMingDic.ContainsKey(daxue1))
                        f1Daxue2.AddRange(daxue_BieMingDic[daxue1]);
                    //ret2 = isSameDaXue(f1DaXue, f1Daxue2);
                    if (ret2)
                    {
                        break;
                    }
                }
            }
            if (ret2)
            {
                string f2 = f1.Replace(f1Num + f1DaXue, daxue11);

                if (!template_files2.ContainsKey(daxue11))//f1Num + daxue1
                    template_files2.Add(daxue11, template_files1[file]);

                if (f1 != "" && f2 != "" && f1 != f2)
                {
                    string f3 = file.Replace(@"\" + f1, @"\" + f2);
                    if (File.Exists(file))
                    {
                        try
                        {
                            renameInt++;
                            FileService.Copy(file, f3, true);
                            if (File.Exists(f3))
                            {
                                File.Delete(file);
                            }
                        }
                        catch (Exception ex1)
                        {
                            Cs.Fatal(ex1.Message);
                        }
                    }
                    ret1 = true;
                }
            }
            if (file.EndsWith(".jpg") && !ret1)
            {
                "".ToLower();
                Cs.Warn(f1 + "，没有找到重命名");
            }
        }
        return template_files2;
    }

    public void initDaoruDaxue()
    {        
        #region 初始化大学列表
        string StartupPath = root1;//.Replace("考试题", "");
        string daxueFile1 = @"\\fuwuqi3\微信运营辅助管理软件" + @"\大学列表.txt";
        if(!File.Exists(daxueFile1))
        {
            Cs.Fatal("目录不能访问：" + daxueFile1);
        }
        string daxueFile2 = daxueFile1;
        //try
        //{
        //    if (File.Exists(daxueFile1))
        //    {
        //        File.Copy(daxueFile1, @"c:\大学列表.txt", true);
        //    }
        //    else
        //        daxueFile2 = @"c:\大学列表.txt";
        //}
        //catch (Exception ex1)
        //{
        //    Cs.Error(ex1.ToString());
        //}

        //读取大学列表.txt文件，获取所有爱帮大学，初始化 chklist4 chklist5
        string[] strDaxue1 = File.ReadAllLines(daxueFile2, Encoding.Default);
        int count1 = 0;
        foreach (string strDaXue in strDaxue1)        //
        {
            //792	北京邮电大学	//北邮//17758129465
            if (string.IsNullOrEmpty(strDaXue))
                continue;
            if (string.IsNullOrEmpty(strDaXue) || strDaXue.Trim() == "" || strDaXue.StartsWith("//")) continue;
            string str3 = strDaXue.Replace("\t", "").Replace(" ", "").Trim();//301浙大
            string[] str3s = StringHelper.Split(str3, "//");
            string str2 = str3s[0];
            string ScName = StringHelper.GetHanZi(str2);//浙大

            string ScId = StringHelper.GetNumericLianXu(str2);//浙大

            string ScDescription = strDaXue;

            TscWxInfo val1 = new TscWxInfo();
            val1.Sc_name = ScName;
            val1.Sc_id = ScId;
            val1.Sc_description = ScDescription;

            int ret1 = BLLTable<TscWxInfo>.SaveOrUpdate(val1, TscWxInfo.Attribute.Sc_id);
            if(ret1<1)
            {
                Cs.Fatal("学校更新存在问题：" + ScDescription);
            }
            count1++;
        }
        Cs.WriteLine("总数 " + count1);//daxue_NumDaxueDic.Count);

        #endregion 初始化大学列表

    }

    public static void initDaxue()
    {
        if (daxue_NumDic.Count > 0) return;
        #region 初始化大学列表        
        List<TscWxInfo> list1 = BLLTable<TscWxInfo>.Select(new TscWxInfo());
        foreach(TscWxInfo tsc in list1)
        {
            //792	北京邮电大学	//北邮//17758129465
            if (string.IsNullOrEmpty(tsc.Sc_name) || string.IsNullOrEmpty(tsc.Sc_id))
                continue;

            string strNumDaxueDesc = tsc.Sc_id + tsc.Sc_name + tsc.Sc_description;
            string strNumDaxue = tsc.Sc_id + tsc.Sc_name;
            string strDaxue = tsc.Sc_name;
            
            if (!daxue_BieMingDic.ContainsKey(strDaxue))
            {
                daxue_BieMingDic.Add(strDaxue, new List<string>());//str3s[i], );
            }
            daxue_BieMingDic[strDaxue].Add(strNumDaxueDesc);

            if (string.IsNullOrEmpty(strDaxue) || string.IsNullOrEmpty(strNumDaxue))
                continue;

            if(strNumDaxue.Contains("瓯江"))
            {

            }
            string py2 = pinyin.convertShouZiMu(strNumDaxue).ToLower();
            if (!pinyin_NumDaxueDic.ContainsKey(py2))
                pinyin_NumDaxueDic.Add(py2, strNumDaxue);
            else
                errMsg += ("\r\n 大学列表 存在重复：" + strDaxue);

            if (!daxue_NumDaxueDic.ContainsKey(strDaxue))
                daxue_NumDaxueDic.Add(strDaxue, strNumDaxue);
            else
                errMsg += ("\r\n 大学列表 存在重复：" + strDaxue);

            if (!NumDaxue_daxueDic.ContainsKey(strNumDaxue))
                NumDaxue_daxueDic.Add(strNumDaxue, strDaxue);
            else
                errMsg += ("\r\n 大学列表 存在重复：" + strNumDaxue);

            if (!daxue_NumDic.ContainsKey(strDaxue))
                daxue_NumDic.Add(strDaxue, StringHelper.GetNumericLianXu(strNumDaxue));
            if (!Num_DaxueDic.ContainsKey(tsc.Sc_id))
                Num_DaxueDic.Add(tsc.Sc_id, StringHelper.GetHanZi(strNumDaxue));

        }
        Cs.WriteLine("总数 " + daxue_NumDaxueDic.Count);

        foreach (string str2 in NumDaxue_daxueDic.Keys)
        {
            string str1 = NumDaxue_daxueDic[str2];
            //3浙大，浙大
            //chklist1.Items.Add(new DataForList(str2, str1), false);
        }
        Cs.Warn("data大学 总数 " + NumDaxue_daxueDic.Count);

        #endregion 初始化大学列表
    }

    public static DateTime checkUpdateTime = DateTime.Now;
    public static bool isNeedUpdateing = false;
    //每过十秒钟检查一下，是否需要升级的升级文件
    public static bool isNeedUpdate()
    {
        if (isNeedUpdateing) return false;
        isNeedUpdateing = true;
        double ts1 = DateTime.Now.Subtract(checkUpdateTime).TotalSeconds;
        if (ts1 > 2)
        {
            string p1 = root1.Replace("考试题", "");
            string file1 = Path.Combine(p1, "升级.txt");
            if (File.Exists(file1))
            {
                string f1 = File.ReadAllText(file1);
                checkUpdateTime = DateTime.Now;
                if (f1 == "1")
                {
                    isNeedUpdateing = false;
                    return true;
                }
            }
            else
                Cs.Warn("升级文件不存在");
        }
        isNeedUpdateing = false;
        return false;
    }
    [Obsolete]
    public static AFDictionary<string, St_TTimuDaXue> GetDic(string sc, string kemuId, string leimu)
    {
        AFDictionary<string, int> dic2 = new AFDictionary<string, int>();
        return GetDic(sc, kemuId, leimu, ref dic2);
    }

    public static AFDictionary<string, St_TTimuDaXue> GetDic(string sc, string kemuId, string leimu, ref AFDictionary<string, int> dic2)
    {
        AFDictionary<string, St_TTimuDaXue> dic1 = new AFDictionary<string, St_TTimuDaXue>();

        if (string.IsNullOrEmpty(leimu))
            leimu = "0";
        dic1 = BLL1.GetDic(sc, kemuId, Convert.ToInt32(leimu), ref dic2);

        if (dic1.Count == 0)
        {
            sc = "194";
            dic1 = BLL1.GetDic(sc, kemuId, Convert.ToInt32(leimu), ref dic2);
        }
        return dic1;
    }

    public static AFDictionary<string, FileInfo> dicFileInfo1 = new AFDictionary<string, FileInfo>();
    //所有题目
    public static AFDictionary<string, AFDictionary<string, St_TTimuDaXue>> dicDicTiMu = new AFDictionary<string, AFDictionary<string, St_TTimuDaXue>>();
    //单选题
    public static AFDictionary<string, AFDictionary<string, St_TTimuDaXue>> dicDicTiMu1 = new AFDictionary<string, AFDictionary<string, St_TTimuDaXue>>();
    //多选题
    public static AFDictionary<string, AFDictionary<string, St_TTimuDaXue>> dicDicTiMu2 = new AFDictionary<string, AFDictionary<string, St_TTimuDaXue>>();
    //判断题
    public static AFDictionary<string, AFDictionary<string, St_TTimuDaXue>> dicDicTiMu3 = new AFDictionary<string, AFDictionary<string, St_TTimuDaXue>>();
    //问答题
    public static AFDictionary<string, AFDictionary<string, St_TTimuDaXue>> dicDicTiMu4 = new AFDictionary<string, AFDictionary<string, St_TTimuDaXue>>();
    
    //所有题目
    public static AFDictionary<string, AFDictionary<string, int>> dic2DicTiMu = new AFDictionary<string, AFDictionary<string, int>>();
    //单选题
    public static AFDictionary<string, AFDictionary<string, int>> dic2DicTiMu1 = new AFDictionary<string, AFDictionary<string, int>>();
    //多选题
    public static AFDictionary<string, AFDictionary<string, int>> dic2DicTiMu2 = new AFDictionary<string, AFDictionary<string, int>>();
    //判断题
    public static AFDictionary<string, AFDictionary<string, int>> dic2DicTiMu3 = new AFDictionary<string, AFDictionary<string, int>>();
    //问答题
    public static AFDictionary<string, AFDictionary<string, int>> dic2DicTiMu4 = new AFDictionary<string, AFDictionary<string, int>>();

    public static string GetFile(string sc, string kemuId)
    {
        string file1 = sc + kemuId;
        return file1;
    }
    public static int GetSum(string sc, string kemuId, int optionType)
    {
        string maxQuestionId = "";
        return GetSum(sc, kemuId, optionType, ref maxQuestionId);
    }
    public static int GetSum(string sc, string kemuId, int optionType, ref string maxQuestionId)
    {
        AFDictionary<string, int> dic1=new AFDictionary<string,int>();
        AFDictionary<string, St_TTimuDaXue> d1 = GetDic(sc, kemuId, optionType, ref dic1);
        if (d1.Count > 0)
            maxQuestionId = Convert.ToString(d1.Values[d1.Count - 1].QuestionId);
        return d1.Count;
    }
    public static AFDictionary<string, St_TTimuDaXue> GetDic(string sc, string kemuId, int optionType, ref AFDictionary<string, int> dic1)
    {
        Init(sc, kemuId);

        string file1 = GetFile(sc, kemuId);
        switch (optionType)
        {
            case 0:
                if (dicDicTiMu1.ContainsKey(file1))
                {
                    dic1 = dic2DicTiMu1[file1];
                    return dicDicTiMu1[file1];                    
                } break;
            case 1:
                if (dicDicTiMu2.ContainsKey(file1))
                {
                    dic1 = dic2DicTiMu2[file1];
                    return dicDicTiMu2[file1];
                } break;
            case 2:
                if (dicDicTiMu3.ContainsKey(file1))
                {
                    dic1 = dic2DicTiMu3[file1];
                    return dicDicTiMu3[file1];
                } break;
            case 3:
                if (dicDicTiMu4.ContainsKey(file1))
                {
                    dic1 = dic2DicTiMu4[file1];
                    return dicDicTiMu4[file1];
                } break;
            default:
                if (dicDicTiMu.ContainsKey(file1))
                {
                    dic1 = dic2DicTiMu[file1];
                    return dicDicTiMu[file1];
                } break;
        }
        return new AFDictionary<string, St_TTimuDaXue>();
    }
    public static DateTime now1 = DateTime.MinValue;
    public static AFDictionary<string, St_TTimuDaXue> Init(string sc, string kemuId)
    {
        AFDictionary<string, int> dic1 = new AFDictionary<string, int>();
        return Init(sc, kemuId, ref dic1);
    }
    public static AFDictionary<string, St_TTimuDaXue> Init(string sc, string kemuId, ref AFDictionary<string, int> dic1)
    {
        initDaxue();
        readInt++;
        if (true)//每100次重新加载一次题目。
        {
            if (listMks.Count > 0 && DateTime.Now.Subtract(now1).TotalSeconds < 120)
            {
                now1 = DateTime.Now;
                readInt = 0;
                return listMks;
            }
        }
        St_TTimuDaXue cond1 = new St_TTimuDaXue();
        cond1.Sc = StringHelper.GetNumeric(sc);
        cond1.KemuId = Convert.ToInt32(kemuId);
        List<St_TTimuDaXue> list1 = BLLTable<St_TTimuDaXue>.Select(new St_TTimuDaXue(), cond1);
        int jj = 0;
        foreach (St_TTimuDaXue tt in list1)
        {
            jj++;
            listMks.Add(jj.ToString(), tt);
        }

        #region 其他题型
        AFDictionary<string, St_TTimuDaXue> listMks1 = new AFDictionary<string, St_TTimuDaXue>();
        AFDictionary<string, St_TTimuDaXue> listMks2 = new AFDictionary<string, St_TTimuDaXue>();
        AFDictionary<string, St_TTimuDaXue> listMks3 = new AFDictionary<string, St_TTimuDaXue>();
        AFDictionary<string, St_TTimuDaXue> listMks4 = new AFDictionary<string, St_TTimuDaXue>();

        AFDictionary<string, int> list2Mks = new AFDictionary<string, int>();
        AFDictionary<string, int> list2Mks1 = new AFDictionary<string, int>();
        AFDictionary<string, int> list2Mks2 = new AFDictionary<string, int>();
        AFDictionary<string, int> list2Mks3 = new AFDictionary<string, int>();
        AFDictionary<string, int> list2Mks4 = new AFDictionary<string, int>();

        int i = -1;
        foreach (string id in listMks.Keys)
        {
            i++;
            list2Mks.Add(id, i);
            if (listMks[id].OptionType == "0")
            {
                listMks1.Add(id, listMks[id]);
                list2Mks1.Add(id, list2Mks1.Count);
            }
            if (listMks[id].OptionType == "1")
            {
                listMks2.Add(id, listMks[id]);
                list2Mks2.Add(id, list2Mks2.Count);
            }
            if (listMks[id].OptionType == "2")
            {
                listMks3.Add(id, listMks[id]);
                list2Mks3.Add(id, list2Mks3.Count);
            }
            if (listMks[id].OptionType == "3")
            {
                listMks4.Add(id, listMks[id]);
                list2Mks4.Add(id, list2Mks4.Count);
            }
        }
        string file1 = GetFile(sc, kemuId);
        if (dicDicTiMu.ContainsKey(file1))
            dicDicTiMu[file1] = listMks;
        else
            dicDicTiMu.Add(file1, listMks);

        if (dicDicTiMu1.ContainsKey(file1))
            dicDicTiMu1[file1] = listMks1;
        else
            dicDicTiMu1.Add(file1, listMks1);

        if (dicDicTiMu2.ContainsKey(file1))
            dicDicTiMu2[file1] = listMks2;
        else
            dicDicTiMu2.Add(file1, listMks2);

        if (dicDicTiMu3.ContainsKey(file1))
            dicDicTiMu3[file1] = listMks3;
        else
            dicDicTiMu3.Add(file1, listMks3);

        if (dicDicTiMu4.ContainsKey(file1))
            dicDicTiMu4[file1] = listMks4;
        else
            dicDicTiMu4.Add(file1, listMks4);
        /////

        if (dic2DicTiMu.ContainsKey(file1))
            dic2DicTiMu[file1] = list2Mks;
        else
            dic2DicTiMu.Add(file1, list2Mks);

        if (dic2DicTiMu1.ContainsKey(file1))
            dic2DicTiMu1[file1] = list2Mks1;
        else
            dic2DicTiMu1.Add(file1, list2Mks1);

        if (dic2DicTiMu2.ContainsKey(file1))
            dic2DicTiMu2[file1] = list2Mks2;
        else
            dic2DicTiMu2.Add(file1, list2Mks2);

        if (dic2DicTiMu3.ContainsKey(file1))
            dic2DicTiMu3[file1] = list2Mks3;
        else
            dic2DicTiMu3.Add(file1, list2Mks3);

        if (dic2DicTiMu4.ContainsKey(file1))
            dic2DicTiMu4[file1] = list2Mks4;
        else
            dic2DicTiMu4.Add(file1, list2Mks4);

        #endregion 其他题型

        if (dicDicTiMu.ContainsKey(file1))
        {
            return dicDicTiMu[file1];
        }
        if (dic2DicTiMu.ContainsKey(file1))
        {
            dic1 = dic2DicTiMu[file1];
        }
        return new AFDictionary<string, St_TTimuDaXue>();
    }
    public static List<St_TTimuDaXue> getList(string sc, string kemuId, string leimu, string seq, string readType, int top, ref AFDictionary<string, int> dic1)
    {
        AFDictionary<string, St_TTimuDaXue> dicLeimu1 = BLL1.GetDic(sc, kemuId, leimu, ref dic1);

        int index1 = 0;
        if (dic1.ContainsKey(seq))
            index1 = dic1[seq];
        if (index1 < 0)
            index1 = 0;
        if (top == 0)
            top = 50;
        List<St_TTimuDaXue> list1 = new List<St_TTimuDaXue>();
        list1.AddRange(dicLeimu1.Values);

        if (list1.Count > 0)
        {
            List<St_TTimuDaXue> list2 = new List<St_TTimuDaXue>();
            if ((string.IsNullOrEmpty(readType) || readType == "0") && list1.Count > 0)
            {
                St_TTimuDaXue[] list3 = new St_TTimuDaXue[top];
                list1.CopyTo(index1, list3, 0, top);
                list2.AddRange(list3);
                return list2;
            }
            else
            {
                int index2 = index1 - top;
                if (index2 < 0) index2 = 0;
                St_TTimuDaXue[] list3 = new St_TTimuDaXue[top];
                list1.CopyTo(index2, list3, 0, top);
                list2.AddRange(list3);
                return list2;
            }
        }
        return list1;
    }
    public static St_TTimuDaXue GetBySeq(string sc, string kemuId, string seq, string type, string leimu)
    {
        AFDictionary<string, int> dic2 = new AFDictionary<string, int>();
        AFDictionary<string, St_TTimuDaXue> dic1 = GetDic(sc, kemuId, leimu, ref dic2);
        //if (type == "sequence")
        if (dic1.Values.Length>0&&!string.IsNullOrEmpty(seq))
        {
            List<St_TTimuDaXue> list1 = new List<St_TTimuDaXue>();
            list1.AddRange(dic1.Values);
            //if (dic1.ContainsKey(id))
            //{
            //    return dic1[id];
            //}
            return list1[Convert.ToInt32(seq) - 1];
        }
        return null;
    }
    //public static St_TTimuDaXue Get(string sc, string kemuId, string id, string type, string leimu)
    //{
    //    AFDictionary<string, St_TTimuDaXue> dic1 = Get(sc, kemuId, leimu);
    //    //if (type == "order")
    //    {
    //        if (dic1.ContainsKey(id))
    //        {
    //            return dic1[id];
    //        }
    //    }
    //    return null;
    //}
    public static string errMsg = "";

}
