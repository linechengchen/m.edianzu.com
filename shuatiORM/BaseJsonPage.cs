using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Core;

/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class BaseJsonPage //: System.Web.UI.Page
{
    /// <summary>
    /// HttpContext.Request   System.Web.HttpContext.Current.Request
    /// </summary>
    /// <param name="Request"></param>
    /// <param name="Response"></param>
    /// <returns></returns>
    public string checkClientInfo()
    {
        HttpRequest Request = System.Web.HttpContext.Current.Request;
        for (int i = 0; i < Request.Headers.Count; i++)
        {
            string key = Request.Headers.GetKey(i);
            string value = Request.Headers.GetValues(i)[0];

            // In the HTTP header, we find a key "Connection" with value "Keep-Alive".
            // We can use the key as the username, and the value as the password
            if (key == "user_id")//Connection
            {
                //if (ModelState.IsValid)
                //{
                //    if (WebSecurity.Login(key, value, persistCookie: model.RememberMe))
                //    {
                //        return RedirectToLocal(returnUrl);
                //    }
                //}

                //ModelState.AddModelError("", "提供的用户名或密码不正确。");
                //return View(model);
            }
        }
        return "";
    }

    //dotnet产生key的方式，对应改成js，在客户端产生key，并放在Headers的userkey内。
    public string getUserKey()
    {
        string long1 = DateTime.Now.Ticks.ToString();
        int key1 = Convert.ToInt32(long1[long1.Length - 3]) + 2 * Convert.ToInt32(long1[long1.Length - 2]) + Convert.ToInt32(long1[long1.Length - 1]);
        int key2 = Convert.ToInt32(long1[long1.Length - 4]) + 3 * Convert.ToInt32(long1[long1.Length - 3]) + Convert.ToInt32(long1[long1.Length - 1]);
        string long2 = key1.ToString().PadRight(3, '0') + key2.ToString().PadRight(3, '0') + long1;
        return long2;
    }
    public string lastkey = "";//上一次用户访问的key
    public bool check()
    {
        string long2 = HttpContext.Current.Request.Headers.Get("userkey");
        //防止使用同一个key进行采集数据资料
        if (lastkey == HttpContext.Current.Session["userkey"] || string.IsNullOrEmpty(long2))
            return false;
        int key1 = Convert.ToInt32(long2.Substring(0, 3));
        int key2 = Convert.ToInt32(long2.Substring(3, 6));
        string long1 = long2.Substring(6);
        //简单的加密方式
        if(key1 == Convert.ToInt32(long1[long1.Length - 3]) + 2 * Convert.ToInt32(long1[long1.Length - 2]) + Convert.ToInt32(long1[long1.Length - 1])
            && key2 == Convert.ToInt32(long1[long1.Length - 4]) + 3 * Convert.ToInt32(long1[long1.Length - 3]) + Convert.ToInt32(long1[long1.Length - 1]))
        {
            lastkey = long2;
            HttpContext.Current.Session["lastkey"] = long2;
            return true;
        }
        return false;
    }
    
    public string getClientInfo(HttpRequest Request, HttpResponse Response)
    {
        System.Web.HttpBrowserCapabilities browser = Request.Browser;
        string sinfo = "Browser Capabilities\n"
           + "Type = " + browser.Type + "\n"
           + "Name = " + browser.Browser + "\n"
           + "Version = " + browser.Version + "\n"
           + "Major Version = " + browser.MajorVersion + "\n"
           + "Minor Version = " + browser.MinorVersion + "\n"
           + "Platform = " + browser.Platform + "\n"
           + "Is Beta = " + browser.Beta + "\n"
           + "Is Crawler = " + browser.Crawler + "\n"
           + "Is AOL = " + browser.AOL + "\n"
           + "Is Win16 = " + browser.Win16 + "\n"
           + "Is Win32 = " + browser.Win32 + "\n"
           + "Supports Frames = " + browser.Frames + "\n"
           + "Supports Tables = " + browser.Tables + "\n"
           + "Supports Cookies = " + browser.Cookies + "\n"
           + "Supports VBScript = " + browser.VBScript + "\n"
           + "Supports JavaScript = " + browser.JavaScript + "\n"
           + "Supports Java Applets = " + browser.JavaApplets + "\n"
           + "Supports ActiveX Controls = " + browser.ActiveXControls + "\n";

        string sinfo1 = "";
        HttpBrowserCapabilities b = Request.Browser;
        sinfo1 += ("浏览器名称和版本号：" + b.Type + "<br>");
        sinfo1 += ("名称：" + b.Browser + "<br>");
        sinfo1 += ("版本：" + b.Version + "<br>");
        sinfo1 += ("操作平台：" + b.Platform + "<br>");
        sinfo1 += ("是否支持框架：" + b.Frames + "<br>");
        sinfo1 += ("是否支持表格：" + b.Tables + "<br>");
        sinfo1 += ("是否支持cookies：" + b.Cookies + "<br>");

        //浏览器名称和版本号：IE6 
        //名称：IE 
        //版本：6.0 
        //操作平台：WinXP 
        //是否支持框架：True 
        //是否支持表格：True 
        //是否支持cookies：True

        //Page.
        if (Request.Browser.EcmaScriptVersion.Major > 0 && Request.Browser.W3CDomVersion.Major > 0)//判断是否支持脚本    
        {
            sinfo1 += ("浏览器名称与版本号：" + Request.Browser.Type + "<br />");
            sinfo1 += ("浏览器版本号：" + Request.Browser.Version + "<br />");
            sinfo1 += ("浏览器主版本号：" + Request.Browser.MajorVersion + "<br />");
            sinfo1 += ("浏览器名称：" + Request.Browser.Browser);
        }
        return sinfo1;
    }

    //对用户访问进行判断 如果是的话返回true，否则返回false  
    public bool choose_net(string userAgent)
    {
        if (userAgent.IndexOf("MicroMessenger") > -1)// Nokia phones and emulators   
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>  
    /// 获取客户端Ip  
    /// </summary>  
    /// <returns></returns>  
    public String GetClientIp()
    {
        String clientIP = "";
        if (System.Web.HttpContext.Current != null)
        {
            clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(clientIP) || (clientIP.ToLower() == "unknown"))
            {
                clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_REAL_IP"];
                if (string.IsNullOrEmpty(clientIP))
                {
                    clientIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
            }
            else
            {
                clientIP = clientIP.Split(',')[0];
            }
        }
        return clientIP;
    }
}