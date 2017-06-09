using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class Base64
    {
        public static string toString(string strPath)
        {
            //            string strPath =  "aHR0cDovLzIwMy44MS4yOS40Njo1NTU3L1
            //9iYWlkdS9yaW5ncy9taWRpLzIwMDA3MzgwLTE2Lm1pZA==";   
            if (string.IsNullOrEmpty(strPath)) return strPath;
            byte[] bpath = Convert.FromBase64String(strPath);
            strPath = System.Text.ASCIIEncoding.Default.GetString(bpath);
            return strPath;
        }
        public static string toBase64(string strPath)
        {
            //            string strPath =  "aHR0cDovLzIwMy44MS4yOS40Njo1NTU3L1
            //9iYWlkdS9yaW5ncy9taWRpLzIwMDA3MzgwLTE2Lm1pZA==";        
            if (string.IsNullOrEmpty(strPath)) return strPath;
            byte[] bpath = Convert.FromBase64String(strPath);
            strPath = System.Text.ASCIIEncoding.Default.GetString(bpath);
            return strPath;
        }
    }
}
