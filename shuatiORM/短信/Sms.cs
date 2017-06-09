using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using AgileFrame.Core;

//namespace server_http_api
//{
    //App Key  刷题宝典
    //04aacac596f7783dbb6c3a26891826cc
    //App Secret
    //d86ce66940cd

    public class SmsShuati
    {
        public static String appKey = "04aacac596f7783dbb6c3a26891826cc";//TO开发者：假数据，具体参考开发文档
        public static String appSecret = "d86ce66940cd";//TO开发者：假数据，具体参考开发文档
        public static string sendMsgYanZheng(string mobile, string content)
        {
            return Sms.sendMsgYanZheng(appKey, appSecret, mobile, content);
        }
    }

    public class SmsXueba
    {
        public static String appKey = "da21658c9abe24dfc06b93b15a381e4a";//TO开发者：假数据，具体参考开发文档
        public static String appSecret = "41a05f976ac0";//TO开发者：假数据，具体参考开发文档 
        public static string sendMsgYanZheng(string mobile, string content)
        {
            return Sms.sendMsgYanZheng(appKey, appSecret, mobile, content);
        }
    }

    public class SmsAibang
    {
        public static String appKey = "76846c33d12dc28f6f55e6c935354d9e";//TO开发者：假数据，具体参考开发文档
        public static String appSecret = "8aeba9febc7f";//TO开发者：假数据，具体参考开发文档 
        public static string sendMsgYanZheng(string mobile, string content)
        {
            return Sms.sendMsgYanZheng(appKey, appSecret, mobile, content);
        }
    }
    
    //mobile	String	是	目标手机号
    //deviceId	String	否	目标设备号，可选参数
    //templateid	int	否	模板编号(如不指定则使用配置的默认模版)
    //codeLen	int	否	验证码长度，范围4～10，默认为4
    public class Sms
    {
        public static void Main(string[] args)
        {

        }
        //curl -X POST -H "AppKey: go9dnk49bkd9jd9vmel1kglw0803mgq3" -H "CurTime: 1443592222"
        //-H "CheckSum: 9e9db3b6c9abb2e1962cf3e6f7316fcc55583f86" -H "Nonce: 4tgggergigwow323t23t" 
        //-H "Content-Type: application/x-www-form-urlencoded" 
        //-d 'mobile=13812345678' 'https://api.netease.im/sms/sendcode.action'
        public static string sendMsgYanZheng(string appKey, string appSecret, string mobile, string content)
        {
            if (string.IsNullOrEmpty(mobile) || mobile.Length != 11 || !mobile.StartsWith("1"))
                return "-1";

            String url = "https://api.netease.im/nimserver/user/create.action";
            url += "?accid=helloworld";//TO开发者：accid填要创建的id

            appKey = "04aacac596f7783dbb6c3a26891826cc";//TO开发者：假数据，具体参考开发文档
            appSecret = "d86ce66940cd";//TO开发者：假数据，具体参考开发文档
            String nonce = "12345";//TO开发者：具体参考开发文档

            TimeSpan ts = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1);
            Int32 ticks = System.Convert.ToInt32(ts.TotalSeconds);
            String curTime = ticks.ToString();
            String checkSum = CheckSumBuilder.getCheckSum(appSecret, nonce, curTime);

            // 设置请求的header
            IDictionary<object, String> headers = new Dictionary<object, String>();
            headers["AppKey"] = appKey;
            headers["Nonce"] = nonce;
            headers["CurTime"] = curTime;
            headers["CheckSum"] = checkSum;
            headers["ContentType"] = "application/x-www-form-urlencoded;charset=utf-8";
            string responseFromServer = "";
            string code = "";
            //responseFromServer = HttpClient.HttpPost(url, null, headers);
            //code = StringHelper.CutString(responseFromServer, "\"code\":", ",");
            //if (code == "200")
            {
                string token = StringHelper.CutString(responseFromServer, "\"token\":\"", "\"");
                string accid = StringHelper.CutString(responseFromServer, "\"accid\":\"", "\"");

                url = "https://api.netease.im/sms/sendcode.action?1=1";
                url += "&mobile=" + mobile;//18605887655";//TO开发者：accid填要创建的id
                //url += "&templateid=1";//TO开发者：accid填要创建的id

                responseFromServer = HttpClient.HttpPost(url, null, headers);

                code = StringHelper.CutString(responseFromServer, "\"code\":", ",");
                string obj = StringHelper.CutString(responseFromServer, "\"obj\":\"", "\"");
                string msg = StringHelper.CutString(responseFromServer, "\"msg\":\"", "\"");
                return obj;
            }
            return "";
        }
        //"Content-Type": "application/json; charset=utf-8"
        //{
        //  "code": 200,
        //  "msg": "88",
        //  "obj": "1908"
        //}
    }
    public class CheckSumBuilder
    {
        // 计算并获取CheckSum
        public static String getCheckSum(String appSecret, String nonce, String curTime)
        {
            byte[] data = Encoding.Default.GetBytes(appSecret + nonce + curTime);
            byte[] result;

            SHA1 sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            result = sha.ComputeHash(data);

            return getFormattedText(result);
        }

        // 计算并获取md5值
        public static String getMD5(String requestBody)
        {
            if (requestBody == null)
                return null;

            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(requestBody));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder(256);

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return getFormattedText(Encoding.Default.GetBytes(sBuilder.ToString()));
        }

        private static String getFormattedText(byte[] bytes)
        {
            char[] HEX_DIGITS = { '0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            int len = bytes.Length;
            StringBuilder buf = new StringBuilder(len * 2);
            for (int j = 0; j < len; j++) {
                buf.Append(HEX_DIGITS[(bytes[j] >> 4) & 0x0f]);
                buf.Append(HEX_DIGITS[bytes[j] & 0x0f]);
            }
            return buf.ToString();
        }
    }

    public class HttpClient
    {
        public static string HttpPost(string url, Stream data, IDictionary<object, string> headers = null)
        {
            System.Net.WebRequest request = HttpWebRequest.Create(url);
            request.Method = "POST";
            if (data != null)
            request.ContentLength = data.Length;
            //request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            if (headers != null)
            {
                foreach (var v in headers)
                {
                    if (v.Key is HttpRequestHeader)
                        request.Headers[(HttpRequestHeader)v.Key] = v.Value;
                    else
                        request.Headers[v.Key.ToString()] = v.Value;
                }
            }
            string responseFromServer = "";
            HttpWebResponse response = null;
            try
            {
                // Get the response.
                response = (HttpWebResponse)request.GetResponse();
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(response.StatusDescription);
            }
            return responseFromServer;
        }
    }
//}
