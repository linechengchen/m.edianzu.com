using AgileFrame.Core;
using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
//using AgileFrame.Core;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Drawing;

namespace 刷题导入工具
{
    public class WebGet
    {
        public bool txtSave = true;
        public bool imgSave = true;
        public bool checkAll = true;
        public string SaveFile(string path1, string filename, string url)
        {
            string filefullName = "";
            try
            {
                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(url.Trim())) 
                    return "";
                if (!Directory.Exists(path1))
                {
                    Directory.CreateDirectory(path1);
                }
                if (!string.IsNullOrEmpty(filename))
                {
                    filefullName = Path.Combine(path1, filename);
                }
                else
                {
                    string filename1 = Path.GetFileName(url);
                    filename1 = AgileFrame.Core.StringHelper.CutOutString(filename1, "?", "");
                    filefullName = Path.Combine(path1, filename1);
                    //string ext1 = MimeMapping.GetMimeMapping(url);
                }
                //
                if (true || !File.Exists(filefullName))//
                {
                    string ContentType = MimeMapping.GetContentTypeByUrl(url);
                    Encoding Encoding1 = Encoding.UTF8;
                    if (ContentType.Contains("image"))
                    {
                        Image img1 = GetWebImage(url, null);
                        if (img1 != null)
                            img1.Save(filefullName);
                        else
                            return "";
                    }
                    else if (ContentType.Contains("mpeg"))
                    {
                        string path = GetUrltoFile(url, filefullName);
                    }
                    else
                    {
                        string html1 = GetUrltoHtml2(url, Encoding1);
                        if (txtSave && !string.IsNullOrEmpty(html1) && html1 != "[]")
                        {
                            if (!Path.GetFileName(filefullName.Trim('/').Trim('\\')).Contains("."))
                                filefullName = filefullName.Trim('/').Trim('\\') + ".html";
                            File.WriteAllText(filefullName, html1);
                        }
                        return html1;
                    }
                }
                else
                {
                    Console.Write("存在.");
                }
            }catch(Exception ex1)
            {
                ex1.ToString();
            }
            return filefullName;
        }
        public static string accept = "";
        /// <summary>
        /// 获取网页验证码图片
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cookie"></param>
        /// <returns></returns>
        public static Image GetWebImage(string url, CookieContainer cookie)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //request.Referer = referer;
                request.UserAgent = userAgent;
                request.Accept = "image/webp,*/*;q=0.8";
                if (cookie != null)
                    request.CookieContainer = cookie;

                //request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.ContentType = MimeMapping.GetContentTypeByUrl(url);// contentType;
                request.KeepAlive = true;
                request.UseDefaultCredentials = true;
                //  request.Proxy = null;
                Stream stream = request.GetResponse().GetResponseStream();
                Image image = Image.FromStream(stream);
                return image;
            }catch(Exception ex)
            {
                Cs.Error("74==" + url + "==" + ex.ToString());
            }
            return null;
        }
        public string rootDir1;
        public AFDictionary<string, string> srcList = new AFDictionary<string, string>();
        public string Username = "";
        public string Password = "";
        public string GetWebByHeader(string url, string header, string cookieStr, string requestForm)
        {
            if (srcList.Count == 0)
                Cs.Green("链接：" + url);
            if (srcList.ContainsKey(url) && srcList[url]!="")
            {
                return "";
            }
            srcList.Add(url, "");
            string paramUrl = StringHelper.CutString(url, "?", "");
            string rootUrl1 = StringHelper.CutString(url.Replace("http://", "").Replace("https://", ""), "", "/");
            if (string.IsNullOrEmpty(rootUrl1))
                rootUrl1 = url;

            string url11 = url.Replace("http://", "").Replace("https://", "");
            if(url11.Contains("?"))
                url11 = StringHelper.CutString(url, "", "?");
            string midUrl1 = StringHelper.CutString(url11, "/", "");

            string fileName1 = Path.Combine(rootDir1, midUrl1);
            
            Directory.CreateDirectory(Path.GetDirectoryName(fileName1));

            string htmlSource = null;
            List<string> csslist = new List<string>();
            List<string> jslist = new List<string>();
            List<string> imglist = new List<string>();
            List<string> hreflist = new List<string>();
            if (string.IsNullOrEmpty(header))
            {
                header =
    @"GET http://api.qess.me/recommendbooks/1/41 HTTP/1.1
Host: api.qess.me
Connection: keep-alive
Accept: */*
Origin: http://mp.qess.me
OriginType: mp
User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36 MicroMessenger/6.5.2.501 NetType/WIFI WindowsWechat QBCore/3.43.27.400 QQBrowser/9.0.2524.400
token: b8dc2e6e0b7d634bcf67be3e4093ef84
version: 2.0
Referer: http://mp.qess.me/pages/indexPage_textbookList.html?recommendId=39&type=1&winzoom=1
Accept-Encoding: gzip, deflate
Accept-Language: zh-CN,zh;q=0.8,en-us;q=0.6,en;q=0.5;q=0.4
";
            }
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteCertificateValidationCallback);
                //图片和视频————
                string ContentType = MimeMapping.GetContentTypeByUrl(url);
                Encoding Encoding1 = Encoding.UTF8;
                if (ContentType.Contains("image")
                    ||url.EndsWith(".png") || url.EndsWith(".jpg") || url.EndsWith(".jpeg") || url.EndsWith(".gif"))
                {
                    if (imgSave){
                        Image img1 = GetWebImage(url, null);
                        if (img1 != null)
                            img1.Save(fileName1);
                    }
                }
                else if (ContentType.Contains("mpeg"))
                {
                    string path = GetUrltoFile(url, fileName1);
                }
                else
                {
                    //html代码--
                    HttpWebRequest request = getRequest(url, header, cookieStr, requestForm);

                    if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                    {
                        request.Credentials = new NetworkCredential(Username, Password);
                    }
                    //request.CookieContainer.Add();
                    //request.ContentType = MimeMapping.GetContentTypeByUrl(url);// contentType;
                    request.KeepAlive = true;
                    //request.UseDefaultCredentials = true;
                    //  request.Proxy = null;
                    //if (url.EndsWith(".png") || url.EndsWith(".jpg") || url.EndsWith(".gif"))
                    //{
                    //    request.Accept = "image/webp,*/*;q=0.8";
                    //    request.ContentType = MimeMapping.GetContentTypeByUrl(url);// contentType;
                    //    //request.KeepAlive = true;
                    //}

                    bool retFailed = true;
                    if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                    {
                        try
                        {
                            wc.Credentials = new NetworkCredential(Username, Password);                            
                            wc.Encoding = Encoding.UTF8;
                            htmlSource = wc.DownloadString(url);
                            retFailed = false;
                        }
                        catch (Exception ex1)
                        {
                            retFailed = true;
                            Cs.Warn(ex1.ToString());
                        }
                    }
                    if (retFailed)
                    {
                        try
                        {
                            //接收响应 firefox
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                            Console.Write(".");
                            Stream stream = response.GetResponseStream();

                            //if (url.EndsWith(".png") || url.EndsWith(".jpg") || url.EndsWith(".jpeg") || url.EndsWith(".gif"))
                            //{
                            //    if (imgSave)
                            //    {
                            //        Image image = Image.FromStream(stream);
                            //        //if(url.EndsWith("jpg"))
                            //        image.Save(fileName1);
                            //    }
                            //    return fileName1;
                            //}
                            //else
                            {
                                System.IO.StreamReader sr = new System.IO.StreamReader(stream, System.Text.Encoding.UTF8);
                                //htmlSource = (sr.ReadToEnd());
                                htmlSource = "";
                                byte[] buf = new byte[1024];
                                while (true)
                                {
                                    int len = stream.Read(buf, 0, buf.Length);
                                    if (len <= 0)//[2011-8-22]  修改len < 0 =》 len <= 0 解决死循环
                                        break;
                                    //.GetEncoding("utf-8")
                                    htmlSource += System.Text.Encoding.UTF8.GetString(buf, 0, len);
                                }
                                srcList.Add(url, htmlSource);
                                if (txtSave)
                                {
                                    if (!Path.GetFileName(fileName1.Trim('/').Trim('\\')).Contains("."))
                                    {
                                        fileName1 = fileName1.Trim('/').Trim('\\') + ".html";
                                        File.WriteAllText(fileName1.Trim('/').Trim('\\'), htmlSource);
                                    }
                                }
                            }
                        }
                        catch (Exception ex1)
                        {
                            retFailed = true;
                            Cs.Warn(ex1.ToString());
                        }
                    }
                    srcList.Add(url, htmlSource);

                    if (url.EndsWith(".css") || url.EndsWith(".js"))
                    {
                        return htmlSource;
                    }
                    if (txtSave)
                    {
                        //如果是网页，需要获取页面上所有其他资源
                        csslist = StringHelper.CutStringForAll(htmlSource, "<link ", ">");
                        foreach (string css1 in csslist)
                        {
                            string css2 = StringHelper.CutString(css1, "href=\"", "\"");
                            if (!string.IsNullOrEmpty(css2))
                            {
                                string url2 = getAbsoluteUrl(css2, url);
                                //string html2 = GetUrltoHtml2(url2, Encoding.UTF8);
                                string html3 = GetWebByHeader(url2, header, cookieStr, requestForm);
                            }
                        }
                        jslist = StringHelper.CutStringForAll(htmlSource, "<script ", "></script>");
                        foreach (string js1 in jslist)
                        {
                            string js2 = StringHelper.CutString(js1, "src=\"", "\"");
                            if (!string.IsNullOrEmpty(js2))
                            {
                                string url2 = getAbsoluteUrl(js2, url);
                                string html2 = GetWebByHeader(url2, header, cookieStr, requestForm);
                            }
                        }
                    }
                    if (imgSave)
                    {
                        imglist = StringHelper.CutStringForAll(htmlSource, "<img ", ">");
                        foreach (string img1 in imglist)
                        {
                            string img2 = StringHelper.CutString(img1, "src=\"", "\"");
                            if (!string.IsNullOrEmpty(img2))
                            {
                                if (img2.EndsWith(".jpg") || img2.EndsWith(".png") || img2.EndsWith(".jpeg"))
                                {
                                    string url2 = getAbsoluteUrl(img2, url);
                                    string html3 = GetWebByHeader(url2, header, cookieStr, requestForm);
                                }
                            }
                        }
                    }
                    if (checkAll)
                    {
                        hreflist = StringHelper.CutStringForAll(htmlSource, "<a ", ">");
                        foreach (string href1 in hreflist)
                        {
                            string href2 = StringHelper.CutString(href1, "href=\"", "\"");
                            if (!string.IsNullOrEmpty(href2.Trim('/').Trim('\\')))
                            {
                                string url2 = getAbsoluteUrl(href2, url);
                                Cs.Green("子链接：" + url2);
                                if (".zip.rar.sit.xml.mpeg.".Contains(Path.GetExtension(url2)))
                                {
                                }
                                else if (url2.Contains("miibeian.gov.cn/") || url2.Contains("baidu.com")) { }
                                else if (!srcList.ContainsKey(url2))
                                {
                                    string html2 = GetWebByHeader(url2, header, cookieStr, requestForm);
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cs.Error("74==" + url + "==" + ex.ToString());
            }

            return htmlSource;
        }
        public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
        public static string GetUrltoHtml111(string uri, Encoding Encoding1)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding1;

            Console.WriteLine("Sending an HTTP GET request to " + uri);

            byte[] bResponse = wc.DownloadData(uri);

            string strResponse = Encoding1.GetString(bResponse);//Encoding.ASCII.GetString(bResponse);

            Console.WriteLine("HTTP response is: ");

            Console.WriteLine(strResponse);
            return strResponse;
        }
        public CookieAwareWebClient wc = new CookieAwareWebClient();
        public void AddCookie(Cookie c1)
        {
            //var client = new CookieAwareWebClient();
            //client.BaseAddress = @"https://www.site.com/any/base/url/";
            //var loginData = new NameValueCollection();
            //loginData.Add("login", "YourLogin");
            //loginData.Add("password", "YourPassword");
            //client.UploadValues("login.php", "POST", loginData);

            ////Now you are logged in and can request pages    
            //string htmlSource = client.DownloadString("index.php");
                        
            //var client = new CookieAwareWebClient();
            //client.cookie = new CookieContainer();
            //client.cookie.Add(new Cookie("wxuserinforset", "mobile_k2f6fhi", "/", ".233.com"));
            //client.cookie.Add(new Cookie("nTalk_CACHE_DATA", "uid:kf_9278_ISME9754_22657099", "/", ".233.com"));
            //client.cookie.Add(new Cookie("ASP.NET_SessionId", "gdctu15u0yfodgxwartvag4y", "/", ".233.com"));
            //client.cookie.Add(new Cookie("Auth", "14AA0E9CE0921CE8530CEA0EDCC72C9571B9A6DB246DBA7869C9C4FE41AA17193C130D17827CE533B59F43D87F9E7527F80B268ED65BC26C", "/", ".233.com"));

            //Stream st = client.OpenRead(@"http://m.wx.233.com/odata/exam/GetExerciseNewList?type=1&typeId=354001&examType=&classId=0&completedTf=0");
            //StreamReader sr = new StreamReader(st);
            //string res = sr.ReadToEnd();

            wc.cookie.Add(c1);
        }

        public static string userAgent = 
@"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36";
        public static string cookieStr =
            @"
Cookie: Token=b8dc2e6e0b7d634bcf67be3e4093ef84; isLogin=true; openid=o0g4tt3rNNXVMfbw6DiEps02Wu6Y; city_name=%E5%8C%97%E4%BA%AC; cityInfo=4; name=1193658; nick_name=yunshuer; user_id=c49ef69b-3a2a-4002-9d1a-996edb402779; phone=18605887655; Hm_lvt_1958976bdfd7dc01acfaabd54ae2d104=1485609430; Hm_lpvt_1958976bdfd7dc01acfaabd54ae2d104=1485609731
";
        public void ClearCookie(string cookieStr)
        {
            wc.cookie = new CookieContainer();
        }
        public static string getAbsoluteUrl(string relativeUrl, string referUrl)
        {
            Uri baseUri = new Uri(referUrl); // http://www.enet.com.cn/enews/inforcenter/designmore.jsp
            Uri absoluteUri = new Uri(baseUri, relativeUrl);//相对绝对路径都在这里转 这里的urlx ="../test.html"
            return absoluteUri.ToString();//   http://www.enet.com.cn/enews/test.html   
        }
        //string requestForm = "userName=1693372175&userPassword=123456";     //拼接Form表单里的信息
        public static HttpWebRequest getRequest(string url, string headerStr1, string cookieStr1, string requestForm)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request. = Encoding.UTF8;
            if (!string.IsNullOrEmpty(requestForm))
            {
                byte[] postdatabyte = Encoding.UTF8.GetBytes(requestForm); 
                request.ContentLength = postdatabyte.Length;
                request.AllowAutoRedirect = false;
                //request.RequestUri.AbsolutePath
                if (postdatabyte != null && postdatabyte.Length > 0)
                {
                    Stream stream;
                    stream = request.GetRequestStream();
                    stream.Write(postdatabyte, 0, postdatabyte.Length); //设置请求主体的内容
                    stream.Close();
                }
            }
            //cookieStr1
            Dictionary<string, string> dics1 = getKeyValue(cookieStr1, "=");
            string urlRoot1 = Path.GetPathRoot(url);
            urlRoot1 = StringHelper.CutString(url, "http://", "/");
            //urlRoot1 = StringHelper.CutString(urlRoot1, ".", "");
            if (request.CookieContainer == null)
                request.CookieContainer = new CookieContainer();
            foreach (string key1 in dics1.Keys)
            {
                string value1 = dics1[key1];
                string value2 = HttpUtility.UrlEncode(value1, Encoding.UTF8);
                //WebGet.AddCookie(new Cookie("wxuserinforset", "mobile_k2f6fhi", "/", ".233.com"));
                Cookie c1 = new Cookie(key1, value2, "/", urlRoot1);//".qess.me"
                request.CookieContainer.Add(c1);//request.CookieContainer.PerDomainCapacity = 20
                //WebGet.AddCookie(c1);
            }
            //headerStr1
            Dictionary<string, string> dics2 = getKeyValue(headerStr1, ":");
            if (headerStr1.Contains("HTTP/1.1"))
                request.ProtocolVersion = new Version("1.1");
            foreach(string key1 in dics2.Keys)
            {
                string value1 = dics2[key1];
                try
                {
                    try
                    {
                        if (key1 != "GET" && key1 != "POST" && !"Host|Connection|User-Agent|Accept|Referer|".Contains(key1))
                            request.Headers.Add(key1, value1);
                    }
                    catch (Exception ex)
                    {
                        //Cs.Warn(ex.ToString());
                    }
                    switch (key1)
                    {
                        case "GET":
                            request.Method = dics2[key1]; break;
                        case "POST":
                            request.Method = dics2[key1]; break;

                        case "KeepAlive":
                            request.KeepAlive = true; break;
                        case "Host":
                            request.Host = dics2[key1]; break;
                        case "Connection":
                            if (dics2[key1].Contains("keep-alive"))
                                request.KeepAlive = true; break;
                        case "Accept":
                            request.Accept = dics2[key1]; break;
                        //case "OriginType":
                        //    value1 = dics2[key1];
                        //    request.Headers.Add(key1, value1);
                        //    request.ContentType = dics2[key1]; break;
                        case "User-Agent":
                            request.UserAgent = dics2[key1]; break;

                        case "Referer":
                            request.Referer = dics2[key1]; break;
                        //case "version":
                        //    value1 = dics2[key1];
                        //    request.Headers.Add(key1, value1);
                            //request.ProtocolVersion = new Version(dics[key1]);
                            break;
                        case "Agent":
                            request.UserAgent = dics2[key1]; break;
                        default:
                            value1 = dics2[key1];
                            break;
                    }
                }catch(Exception ex)
                {
                    Cs.Warn(ex.ToString());
                }
            }
            return request;
        }

        public static Dictionary<string, string> getKeyValue(string cookieStr2, string fenge1)
        {
            Dictionary<string, string> dics = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(cookieStr2))
            {
                string cookieStr1 = cookieStr2.Replace("\r\n", "|").Replace("\n", "|").Replace("\r", "|").Replace("Cookie:", "").Trim();//.Replace(" ", "");
                List<string> cookielist = new List<string>();
                cookielist.AddRange(cookieStr1.Split('|'));
                foreach (string c1 in cookielist)
                {
                    if (!string.IsNullOrEmpty(c1) && !c1.Trim().StartsWith("//"))
                    {
                        List<string> cookielist1 = new List<string>();
                        if (c1.StartsWith("GET ") || c1.StartsWith("POST "))
                        {
                            //if (!dics.ContainsKey("GET"))
                            //    dics.Add("GET", "GET");//c1.Replace("GET ", ""));
                        } 
                        else if (c1.Contains(fenge1))
                        {
                            cookielist1.AddRange(c1.Split(fenge1[0]));
                        }                  
                        if (cookielist1.Count >= 2)
                        {
                            string name1 = cookielist1[0];
                            string value1 = "";
                            for (int i = 1; i < cookielist1.Count; i++)
                            {
                                value1 += cookielist1[i] + fenge1;
                            }
                            value1 = value1.TrimEnd(fenge1[0]);
                            if (!dics.ContainsKey(name1.Trim()))
                                dics.Add(name1.Trim(), value1.Trim());
                        }
                    }
                }
                if (cookieStr1.StartsWith("GET "))
                    dics.Add("GET", "GET");
                else if (cookieStr1.StartsWith("POST "))
                    dics.Add("POST", "POST");
            }
            return dics;
        }

        public List<Cookie> AddCookie(string cookieStr2)
        {
            List<Cookie> clist = new List<Cookie>();
            Dictionary<string, string> dics = getKeyValue(cookieStr2, ":");
            if (dics.Count > 0)
            {
                foreach (string name1 in dics.Keys)
                {
                    string value1 = dics[name1];
                    //WebGet.AddCookie(new Cookie("wxuserinforset", "mobile_k2f6fhi", "/", ".233.com"));
                    clist.Add(new Cookie(name1, value1, "/", ".qess.me"));
                    AddCookie(new Cookie(name1, value1, "/", ".qess.me"));
                }
            }
            return clist;
        }

        public string GetUrltoHtml2(string uri, Encoding Encoding1)
        {
            if (string.IsNullOrEmpty(uri) || string.IsNullOrEmpty(uri.Trim())) return "";
            //wc = new CookieAwareWebClient();
            wc.Encoding = Encoding1;
            
            //html1 = "";
            //get1(uri);
            //while (html1 == "")
            //{
            //    Wait(100);
            //    //Wait(2000);
            //}
            //return html1;
            Console.WriteLine("Sending an HTTP GET request to " + uri);

            //Application.DoEvents();
            Thread.Sleep(10);
            //Application.DoEvents();
            Stream st = null;
            StreamReader sr = null;
            try
            {
                st = wc.OpenRead(uri);
                sr = new StreamReader(st);
                string res = sr.ReadToEnd();
                return res;
            }
            catch (Exception ex1)
            {
                Cs.Error(ex1.ToString());
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (st != null)
                    st.Close();
            }
            Console.WriteLine("HTTP Response is ");

            //Console.WriteLine(res);
            return "";
        }
        public void get1(string url1)
        {
            wc.DownloadStringAsync(new Uri(url1));
            wc.DownloadStringCompleted += wc_DownloadStringCompleted;
        }
        string html1 = "";
        public void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            html1 = e.Result;
        }
        //public void Wait(int sec1)
        //{
        //    for (int i = 1; i < sec1; i++)
        //    {
        //        Thread.Sleep(1);
        //        //Application.DoEvents();
        //    }
        //}
        public string GetUrltoDir(string URLAddress, string receivePath)
        {
            WebClient wc = new WebClient();
            //wc.Encoding = Encoding1;            

            wc.DownloadFile(URLAddress, receivePath + System.IO.Path.GetFileName(URLAddress));

            return System.IO.Path.GetFileName(URLAddress);
        }

        public string GetUrltoFile(string URLAddress, string receiveFile)
        {
            WebClient wc = new WebClient();
            //wc.Encoding = Encoding1;            

            wc.DownloadFile(URLAddress, receiveFile);
            return receiveFile;
        }
        /// <summary>
        /// 获取html
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Encoding1"></param>
        /// <returns></returns>
        public static string GetUrltoHtml(string Url, Encoding Encoding1)
        {
            try
            {
                System.Net.WebRequest wReq = System.Net.WebRequest.Create(Url);
                // Get the response instance.
                System.Net.WebResponse wResp = wReq.GetResponse();
                System.IO.Stream respStream = wResp.GetResponseStream();
                // Dim reader As StreamReader = New StreamReader(respStream)
                using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding1))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (System.Exception ex)
            {
                Cs.Fatal("93" + ex.ToString());
                //errorMsg = ex.Message;
            }
            return "";
        }
    }


//    static void Main(string[] args)
// 9         {
//10             DateTime prevDateTime = DateTime.MinValue;
//11 
//12             for (int i = 0; i < 10; i++)
//13             {
//14                 try
//15                 {
//16                     var url = "http://cnblogs.com";
//17 
//18                     var request = (HttpWebRequest)HttpWebRequest.Create(url);
//19 
//20                     request.Method = "Head";
//21 
//22                     if (i > 0)
//23                     {
//24                         request.IfModifiedSince = prevDateTime;
//25                     }
//26 
//27                     request.Timeout = 3000;
//28 
//29                     var response = (HttpWebResponse)request.GetResponse();
//30 
//31                     var code = response.StatusCode;
//32 
//33                     //如果服务器返回状态是200，则认为网页已更新，记得当时的服务器时间
//34                     if (code == HttpStatusCode.OK)
//35                     {
//36                         prevDateTime = Convert.ToDateTime(response.Headers[HttpResponseHeader.Date]);
//37                     }
//38 
//39                     Console.WriteLine("当前服务器的状态码:{0}", code);
//40                 }
//41                 catch (WebException ex)
//42                 {
//43                     if (ex.Response != null)
//44                     {
//45                         var code = (ex.Response as HttpWebResponse).StatusCode;
//46 
//47                         Console.WriteLine("当前服务器的状态码:{0}", code);
//48                     }
//49                 }
//50             }
//51         }

    // 通过自己定义一个静态类
    // 将所有的Content Type都扔进去吧
    // 调用的时候直接调用静态方法即可。
    public static class MimeMapping
    {
        public static string GetContentTypeByUrl(string url)
        {
            //需要调用的时候
            string contentType = MimeMapping.GetMimeMapping(url);
            //Console.WriteLine("{0}'s MIME TYPE: {1}", file, contentType);
            return contentType;
        }
        private static Hashtable _mimeMappingTable;

        private static void AddMimeMapping(string extension, string MimeType)
        {
            MimeMapping._mimeMappingTable.Add(extension, MimeType);
        }
        /// <summary>
        /// 找到扩展名
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static string GetMimeMapping(string FileName)
        {
            FileName = FileName.Replace("/", @"\");
            string text = null;
            int num = FileName.LastIndexOf('.');
            if (0 < num && num > FileName.LastIndexOf('\\'))
            {
                text = (string)MimeMapping._mimeMappingTable[FileName.Substring(num)];
            }
            if (text == null)
            {
                text = (string)MimeMapping._mimeMappingTable[".*"];
            }
            return text;
        }

        static MimeMapping()
        {
            MimeMapping._mimeMappingTable = new Hashtable(190, StringComparer.CurrentCultureIgnoreCase);
            MimeMapping.AddMimeMapping(".323", "text/h323");
            MimeMapping.AddMimeMapping(".asx", "video/x-ms-asf");
            MimeMapping.AddMimeMapping(".acx", "application/internet-property-stream");
            MimeMapping.AddMimeMapping(".ai", "application/postscript");
            MimeMapping.AddMimeMapping(".aif", "audio/x-aiff");
            MimeMapping.AddMimeMapping(".aiff", "audio/aiff");
            MimeMapping.AddMimeMapping(".axs", "application/olescript");
            MimeMapping.AddMimeMapping(".aifc", "audio/aiff");
            MimeMapping.AddMimeMapping(".asr", "video/x-ms-asf");
            MimeMapping.AddMimeMapping(".avi", "video/x-msvideo");
            MimeMapping.AddMimeMapping(".asf", "video/x-ms-asf");
            MimeMapping.AddMimeMapping(".au", "audio/basic");
            MimeMapping.AddMimeMapping(".application", "application/x-ms-application");
            MimeMapping.AddMimeMapping(".bin", "application/octet-stream");
            MimeMapping.AddMimeMapping(".bas", "text/plain");
            MimeMapping.AddMimeMapping(".bcpio", "application/x-bcpio");
            MimeMapping.AddMimeMapping(".bmp", "image/bmp");
            MimeMapping.AddMimeMapping(".cdf", "application/x-cdf");
            MimeMapping.AddMimeMapping(".cat", "application/vndms-pkiseccat");
            MimeMapping.AddMimeMapping(".crt", "application/x-x509-ca-cert");
            MimeMapping.AddMimeMapping(".c", "text/plain");
            MimeMapping.AddMimeMapping(".css", "text/css");
            MimeMapping.AddMimeMapping(".cer", "application/x-x509-ca-cert");
            MimeMapping.AddMimeMapping(".crl", "application/pkix-crl");
            MimeMapping.AddMimeMapping(".cmx", "image/x-cmx");
            MimeMapping.AddMimeMapping(".csh", "application/x-csh");
            MimeMapping.AddMimeMapping(".cod", "image/cis-cod");
            MimeMapping.AddMimeMapping(".cpio", "application/x-cpio");
            MimeMapping.AddMimeMapping(".clp", "application/x-msclip");
            MimeMapping.AddMimeMapping(".crd", "application/x-mscardfile");
            MimeMapping.AddMimeMapping(".deploy", "application/octet-stream");
            MimeMapping.AddMimeMapping(".dll", "application/x-msdownload");
            MimeMapping.AddMimeMapping(".dot", "application/msword");
            MimeMapping.AddMimeMapping(".doc", "application/msword");
            MimeMapping.AddMimeMapping(".dvi", "application/x-dvi");
            MimeMapping.AddMimeMapping(".dir", "application/x-director");
            MimeMapping.AddMimeMapping(".dxr", "application/x-director");
            MimeMapping.AddMimeMapping(".der", "application/x-x509-ca-cert");
            MimeMapping.AddMimeMapping(".dib", "image/bmp");
            MimeMapping.AddMimeMapping(".dcr", "application/x-director");
            MimeMapping.AddMimeMapping(".disco", "text/xml");
            MimeMapping.AddMimeMapping(".exe", "application/octet-stream");
            MimeMapping.AddMimeMapping(".etx", "text/x-setext");
            MimeMapping.AddMimeMapping(".evy", "application/envoy");
            MimeMapping.AddMimeMapping(".eml", "message/rfc822");
            MimeMapping.AddMimeMapping(".eps", "application/postscript");
            MimeMapping.AddMimeMapping(".flr", "x-world/x-vrml");
            MimeMapping.AddMimeMapping(".fif", "application/fractals");
            MimeMapping.AddMimeMapping(".gtar", "application/x-gtar");
            MimeMapping.AddMimeMapping(".gif", "image/gif");
            MimeMapping.AddMimeMapping(".gz", "application/x-gzip");
            MimeMapping.AddMimeMapping(".hta", "application/hta");
            MimeMapping.AddMimeMapping(".htc", "text/x-component");
            MimeMapping.AddMimeMapping(".htt", "text/webviewhtml");
            MimeMapping.AddMimeMapping(".h", "text/plain");
            MimeMapping.AddMimeMapping(".hdf", "application/x-hdf");
            MimeMapping.AddMimeMapping(".hlp", "application/winhlp");
            MimeMapping.AddMimeMapping(".html", "text/html");
            MimeMapping.AddMimeMapping(".htm", "text/html");
            MimeMapping.AddMimeMapping(".hqx", "application/mac-binhex40");
            MimeMapping.AddMimeMapping(".isp", "application/x-internet-signup");
            MimeMapping.AddMimeMapping(".iii", "application/x-iphone");
            MimeMapping.AddMimeMapping(".ief", "image/ief");
            MimeMapping.AddMimeMapping(".ivf", "video/x-ivf");
            MimeMapping.AddMimeMapping(".ins", "application/x-internet-signup");
            MimeMapping.AddMimeMapping(".ico", "image/x-icon");
            MimeMapping.AddMimeMapping(".jpg", "image/jpeg");
            MimeMapping.AddMimeMapping(".jfif", "image/pjpeg");
            MimeMapping.AddMimeMapping(".jpe", "image/jpeg");
            MimeMapping.AddMimeMapping(".jpeg", "image/jpeg");
            MimeMapping.AddMimeMapping(".js", "application/x-javascript");
            MimeMapping.AddMimeMapping(".lsx", "video/x-la-asf");
            MimeMapping.AddMimeMapping(".latex", "application/x-latex");
            MimeMapping.AddMimeMapping(".lsf", "video/x-la-asf");
            MimeMapping.AddMimeMapping(".manifest", "application/x-ms-manifest");
            MimeMapping.AddMimeMapping(".mhtml", "message/rfc822");
            MimeMapping.AddMimeMapping(".mny", "application/x-msmoney");
            MimeMapping.AddMimeMapping(".mht", "message/rfc822");
            MimeMapping.AddMimeMapping(".mid", "audio/mid");
            MimeMapping.AddMimeMapping(".mpv2", "video/mpeg");
            MimeMapping.AddMimeMapping(".man", "application/x-troff-man");
            MimeMapping.AddMimeMapping(".mvb", "application/x-msmediaview");
            MimeMapping.AddMimeMapping(".mpeg", "video/mpeg");
            MimeMapping.AddMimeMapping(".m3u", "audio/x-mpegurl");
            MimeMapping.AddMimeMapping(".mdb", "application/x-msaccess");
            MimeMapping.AddMimeMapping(".mpp", "application/vnd.ms-project");
            MimeMapping.AddMimeMapping(".m1v", "video/mpeg");
            MimeMapping.AddMimeMapping(".mpa", "video/mpeg");
            MimeMapping.AddMimeMapping(".me", "application/x-troff-me");
            MimeMapping.AddMimeMapping(".m13", "application/x-msmediaview");
            MimeMapping.AddMimeMapping(".movie", "video/x-sgi-movie");
            MimeMapping.AddMimeMapping(".m14", "application/x-msmediaview");
            MimeMapping.AddMimeMapping(".mpe", "video/mpeg");
            MimeMapping.AddMimeMapping(".mp2", "video/mpeg");
            MimeMapping.AddMimeMapping(".mov", "video/quicktime");
            MimeMapping.AddMimeMapping(".mp3", "audio/mpeg");

            MimeMapping.AddMimeMapping(".mp4", "audio/mpeg");
            MimeMapping.AddMimeMapping(".flv", "audio/mpeg");

            //MimeMapping.AddMimeMapping(".flv", "application/octet-stream");
            //MimeMapping.AddMimeMapping(".flv", "application/octet-stream");

            MimeMapping.AddMimeMapping(".mpg", "video/mpeg");
            MimeMapping.AddMimeMapping(".ms", "application/x-troff-ms");
            MimeMapping.AddMimeMapping(".nc", "application/x-netcdf");
            MimeMapping.AddMimeMapping(".nws", "message/rfc822");
            MimeMapping.AddMimeMapping(".oda", "application/oda");
            MimeMapping.AddMimeMapping(".ods", "application/oleobject");
            MimeMapping.AddMimeMapping(".pmc", "application/x-perfmon");
            MimeMapping.AddMimeMapping(".p7r", "application/x-pkcs7-certreqresp");
            MimeMapping.AddMimeMapping(".p7b", "application/x-pkcs7-certificates");
            MimeMapping.AddMimeMapping(".p7s", "application/pkcs7-signature");
            MimeMapping.AddMimeMapping(".pmw", "application/x-perfmon");
            MimeMapping.AddMimeMapping(".ps", "application/postscript");
            MimeMapping.AddMimeMapping(".p7c", "application/pkcs7-mime");
            MimeMapping.AddMimeMapping(".pbm", "image/x-portable-bitmap");
            MimeMapping.AddMimeMapping(".ppm", "image/x-portable-pixmap");
            MimeMapping.AddMimeMapping(".pub", "application/x-mspublisher");
            MimeMapping.AddMimeMapping(".pnm", "image/x-portable-anymap");
            MimeMapping.AddMimeMapping(".png", "image/png");
            MimeMapping.AddMimeMapping(".pml", "application/x-perfmon");
            MimeMapping.AddMimeMapping(".p10", "application/pkcs10");
            MimeMapping.AddMimeMapping(".pfx", "application/x-pkcs12");
            MimeMapping.AddMimeMapping(".p12", "application/x-pkcs12");
            MimeMapping.AddMimeMapping(".pdf", "application/pdf");
            MimeMapping.AddMimeMapping(".pps", "application/vnd.ms-powerpoint");
            MimeMapping.AddMimeMapping(".p7m", "application/pkcs7-mime");
            MimeMapping.AddMimeMapping(".pko", "application/vndms-pkipko");
            MimeMapping.AddMimeMapping(".ppt", "application/vnd.ms-powerpoint");
            MimeMapping.AddMimeMapping(".pmr", "application/x-perfmon");
            MimeMapping.AddMimeMapping(".pma", "application/x-perfmon");
            MimeMapping.AddMimeMapping(".pot", "application/vnd.ms-powerpoint");
            MimeMapping.AddMimeMapping(".prf", "application/pics-rules");
            MimeMapping.AddMimeMapping(".pgm", "image/x-portable-graymap");
            MimeMapping.AddMimeMapping(".qt", "video/quicktime");
            MimeMapping.AddMimeMapping(".ra", "audio/x-pn-realaudio");
            MimeMapping.AddMimeMapping(".rgb", "image/x-rgb");
            MimeMapping.AddMimeMapping(".ram", "audio/x-pn-realaudio");
            MimeMapping.AddMimeMapping(".rmi", "audio/mid");
            MimeMapping.AddMimeMapping(".ras", "image/x-cmu-raster");
            MimeMapping.AddMimeMapping(".roff", "application/x-troff");
            MimeMapping.AddMimeMapping(".rtf", "application/rtf");
            MimeMapping.AddMimeMapping(".rtx", "text/richtext");
            MimeMapping.AddMimeMapping(".sv4crc", "application/x-sv4crc");
            MimeMapping.AddMimeMapping(".spc", "application/x-pkcs7-certificates");
            MimeMapping.AddMimeMapping(".setreg", "application/set-registration-initiation");
            MimeMapping.AddMimeMapping(".snd", "audio/basic");
            MimeMapping.AddMimeMapping(".stl", "application/vndms-pkistl");
            MimeMapping.AddMimeMapping(".setpay", "application/set-payment-initiation");
            MimeMapping.AddMimeMapping(".stm", "text/html");
            MimeMapping.AddMimeMapping(".shar", "application/x-shar");
            MimeMapping.AddMimeMapping(".sh", "application/x-sh");
            MimeMapping.AddMimeMapping(".sit", "application/x-stuffit");
            MimeMapping.AddMimeMapping(".spl", "application/futuresplash");
            MimeMapping.AddMimeMapping(".sct", "text/scriptlet");
            MimeMapping.AddMimeMapping(".scd", "application/x-msschedule");
            MimeMapping.AddMimeMapping(".sst", "application/vndms-pkicertstore");
            MimeMapping.AddMimeMapping(".src", "application/x-wais-source");
            MimeMapping.AddMimeMapping(".sv4cpio", "application/x-sv4cpio");
            MimeMapping.AddMimeMapping(".tex", "application/x-tex");
            MimeMapping.AddMimeMapping(".tgz", "application/x-compressed");
            MimeMapping.AddMimeMapping(".t", "application/x-troff");
            MimeMapping.AddMimeMapping(".tar", "application/x-tar");
            MimeMapping.AddMimeMapping(".tr", "application/x-troff");
            MimeMapping.AddMimeMapping(".tif", "image/tiff");
            MimeMapping.AddMimeMapping(".txt", "text/plain");
            MimeMapping.AddMimeMapping(".texinfo", "application/x-texinfo");
            MimeMapping.AddMimeMapping(".trm", "application/x-msterminal");
            MimeMapping.AddMimeMapping(".tiff", "image/tiff");
            MimeMapping.AddMimeMapping(".tcl", "application/x-tcl");
            MimeMapping.AddMimeMapping(".texi", "application/x-texinfo");
            MimeMapping.AddMimeMapping(".tsv", "text/tab-separated-values");
            MimeMapping.AddMimeMapping(".ustar", "application/x-ustar");
            MimeMapping.AddMimeMapping(".uls", "text/iuls");
            MimeMapping.AddMimeMapping(".vcf", "text/x-vcard");
            MimeMapping.AddMimeMapping(".wps", "application/vnd.ms-works");
            MimeMapping.AddMimeMapping(".wav", "audio/wav");
            MimeMapping.AddMimeMapping(".wrz", "x-world/x-vrml");
            MimeMapping.AddMimeMapping(".wri", "application/x-mswrite");
            MimeMapping.AddMimeMapping(".wks", "application/vnd.ms-works");
            MimeMapping.AddMimeMapping(".wmf", "application/x-msmetafile");
            MimeMapping.AddMimeMapping(".wcm", "application/vnd.ms-works");
            MimeMapping.AddMimeMapping(".wrl", "x-world/x-vrml");
            MimeMapping.AddMimeMapping(".wdb", "application/vnd.ms-works");
            MimeMapping.AddMimeMapping(".wsdl", "text/xml");
            MimeMapping.AddMimeMapping(".xap", "application/x-silverlight-app");
            MimeMapping.AddMimeMapping(".xml", "text/xml");
            MimeMapping.AddMimeMapping(".xlm", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xaf", "x-world/x-vrml");
            MimeMapping.AddMimeMapping(".xla", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xls", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xof", "x-world/x-vrml");
            MimeMapping.AddMimeMapping(".xlt", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xlc", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xsl", "text/xml");
            MimeMapping.AddMimeMapping(".xbm", "image/x-xbitmap");
            MimeMapping.AddMimeMapping(".xlw", "application/vnd.ms-excel");
            MimeMapping.AddMimeMapping(".xpm", "image/x-xpixmap");
            MimeMapping.AddMimeMapping(".xwd", "image/x-xwindowdump");
            MimeMapping.AddMimeMapping(".xsd", "text/xml");
            MimeMapping.AddMimeMapping(".z", "application/x-compress");
            MimeMapping.AddMimeMapping(".zip", "application/x-zip-compressed");
            MimeMapping.AddMimeMapping(".*", "application/octet-stream");
        }
    }
}