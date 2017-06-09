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
    // 微信公众号 appid secret
    public static string appid = "wx1d5993af684bee55";
    public static string secret = "fdf2d914edb673af7928e669aee0f6a7";


    public static string grant_type = "client_credential";

    // 微信部署url
    public static string wx_gov_url = "http://stbd.javalong.com/";

    // 获取用户信息的access_token参数
    public static string token_url = "https://api.weixin.qq.com/cgi-bin/token";
    public static string toekn_data = string.Format("grant_type={0}&appid={1}&secret={2}", grant_type, appid, secret);


    // 跳转至获取code页面
    public static string wx_url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=http://stbd.javalong.com/st/CodeUrl.aspx&response_type=code&scope=snsapi_base&state=1#wechat_redirect";

    #region  获取用户信息 access_token
    public string userAccessToken()
    {
        string token_result = HttpGet(token_url, toekn_data);
        string access_token = GetJsonValue(token_result, "access_token");

        return access_token;
    }
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
    public string HttpGet(string url, string param)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (param == "" ? "" : "?") + param);
        request.Method = "GET";
        request.ContentType = "text/html;charset=UTF-8";

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
