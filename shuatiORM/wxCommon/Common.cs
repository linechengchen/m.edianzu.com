using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Net;
using System.Web;


public class Common
{
    /*
        测试号
     AppId     ：wx8b15f55155a8b996
     AppSecret ：d3d836e009fa023d9785eec549a1321c
     学霸优选
     AppId     ：wx1d5993af684bee55
     AppSecret ：8c2ce78f641208713d4052256c95e127
    刷题宝典 
     AppId     ：wx1f49864edcede162
     AppSecret ：397321322f90543dd09719a1aedcb5a5
     */

    public Common Factory(string key1)
    {
        return new Common();
    }
    // 微信公众号 appid secret 刷题
    public string appid = "wx1f49864edcede162";
    public string secret = "397321322f90543dd09719a1aedcb5a5";

    public string grant_type = "client_credential";

    // 微信公众号 appid secret 学霸

    //public string appid2 = "wx1d5993af684bee55";
    //public string secret2 = "8c2ce78f641208713d4052256c95e127";
    
    // 微信部署url

    public string wx_gov_url = "http://stbd.javalong.com/";

    // 获取用户信息的access_token参数
    public string token_url = "https://api.weixin.qq.com/cgi-bin/token";
    public string token_data
    {
        get{
            return string.Format("grant_type={0}&appid={1}&secret={2}", grant_type, appid, secret);
        }
    }
    //public string token_data2
    //{
    //    get
    //    {
    //        return string.Format("grant_type={0}&appid={1}&secret={2}", grant_type, appid2, secret2);
    //    }
    //}
    public string redirectUrl = "http://stbd.javalong.com/st/wxInfo/CodeUrl.aspx";
    
    //http://cache.baiducontent.com/c?m=9f65cb4a8c8507ed4fece763105392230e54f76238d586482ec3933fc239045c163bbffd707e5619d0c2616401ae4b41eaf02b723d0323b79acd8b5ddacf9528298925377317875612a458f58d197bd565cd1abfa059b0fbb26fcfef85c4de2444ca24127bf0b0dc0c5b549d3eb6033192e3ce135f044c&p=8060f90a85cc43e008e2977c070c89&newp=9c759a46d4c95dfc57ef85354455c1231610db2151d6d01f6b82c825d7331b001c3bbfb423231506d3c07c6605a84b5deef43d7933052ba3dda5c91d9fb4c5747994&user=baidu&fm=sc&query=Response%2ERedirect+weixin&qid=ea271cbc00007f86&p1=1
    // 跳转至获取code页面
    public string wx_url
    {
        get
        {
            return "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=" + HttpUtility.UrlEncode(redirectUrl) + "&response_type=code&scope=snsapi_base&state=1#wechat_redirect";
        }
    }

    public string getwx_url()
    {
        //Common c1 = new Common();
        return this.wx_url;
    }
    public static string getwx_url(string appid, string secret, string redirectUrl)
    {
        Common c1 = new Common();
        c1.appid = appid;
        c1.secret = secret;
        c1.redirectUrl = redirectUrl;
        return c1.wx_url;
    }

    #region  获取用户信息 access_token
    public string userAccessToken()
    {
        string token_result = HttpGet(token_url, token_data);
        string access_token = GetJsonValue(token_result, "access_token");

        return access_token;
    }
    //public string userAccessToken2()
    //{
    //    string token_result = HttpGet(token_url, token_data2);
    //    string access_token = GetJsonValue(token_result, "access_token");

    //    return access_token;
    //}
    #endregion

    #region  随机数 抽奖
    public int GenerateRandom(int min, int max)
    {
        Random random = new Random();
        int reCode = random.Next(min, max);
        return reCode;
    }
    #endregion

    #region  随机数 流水
    public string RandomNum()
    {
        string num;
        string date = System.DateTime.Now.ToString("dd");
        string time = System.DateTime.Now.ToString("hhmmss");

        System.Random Random = new System.Random();
        int Result = Random.Next(0, 9);
        int Result2 = Random.Next(0, 9);
        num = Result2 + date + time + Result;
        return num;
    }
    #endregion

    #region  包括字母随机数
    private static char[] constant = { 
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

    public string GenerateRandom(int Length)
    {
        System.Text.StringBuilder newRandom = new System.Text.StringBuilder(52);
        Random rd = new Random();
        for (int i = 0; i < Length; i++)
        {
            newRandom.Append(constant[rd.Next(52)]);
        }
        return newRandom.ToString();
    }
    #endregion

    #region  GET请求与获取结果
    public string HttpGet(string url)
    {
        return HttpGet(url, "");
    }
    public string HttpGet(string url, string param)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (param == "" ? "" : "?") + param);
        request.Method = "GET";
        request.ContentType = "text/html;charset=UTF-8";
        //request.ContentType = "text/plain";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();

        return retString;
    }
    #endregion

    #region  判断当前页面是否接收到了Get请求
    public bool IsGet()
    {
        return HttpContext.Current.Request.HttpMethod.Equals("GET");
    }

    public bool IsPost()
    {
        return HttpContext.Current.Request.HttpMethod.Equals("POST");
    }
    #endregion

    #region  Json截取
    public string GetJsonValue(string jsonStr, string key)
    {
        string result = string.Empty;
        if (!string.IsNullOrEmpty(jsonStr))
        {
            key = "\"" + key.Trim('"') + "\"";
            int index = jsonStr.IndexOf(key) + key.Length + 1;
            if (index > key.Length + 1)
            {
                //先截逗号，若是最后一个，截“｝”号，取最小值
                int end = jsonStr.IndexOf(',', index);
                if (end == -1)
                {
                    end = jsonStr.IndexOf('}', index);
                }

                result = jsonStr.Substring(index, end - index);
                //过滤引号或空格
                result = result.Trim(new char[] { '"', ' ', '\'' });
            }
        }
        return result;
    }
    #endregion

    #region  Log记录
    public void WriteError(string errorMessage)
    {
        try
        {
            string path = "~/log/" + DateTime.Today.ToString("yyMMdd") + ".txt";

            if (!File.Exists(HttpContext.Current.Server.MapPath(path)))
            {
                File.Create(HttpContext.Current.Server.MapPath(path)).Close();
            }
            using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
            {
                w.WriteLine("\r\nLog Entry : ");
                w.WriteLine("{0}", DateTime.Now.ToString(CultureInfo.InvariantCulture));
                w.WriteLine(errorMessage);
                w.WriteLine("________________________________________________________");
                w.Flush();
                w.Close();
            }
        }
        catch (Exception ex)
        {
            WriteError(ex.Message);
        }
    }
    #endregion


}
