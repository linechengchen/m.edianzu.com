using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class KaiSa
    {
        public static string Encrypt(string text)
        {
            string fenge1 = "`";
            if (text.Contains("`"))
                fenge1 = "";
            string fenge2 = "É";
            if (text.Contains("É"))
                fenge2 = "";
            string fenge3 = "ò";
            if (text.Contains("ò"))
                fenge3 = "";
            //string encrptString = "copyright";
            StringBuilder encrptString = new StringBuilder("copyright");
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char newChar = (char)(c + 3);
                    if (!char.IsLetter(newChar))
                    {
                        newChar -= (char)26;
                    }
                    //encrptString += newChar;
                    encrptString.Append(newChar);
                }
                else if (c == '{' && fenge1 != "")
                {
                    //encrptString += fenge1;
                    encrptString.Append(fenge1);
                }
                else if (c == '}' && fenge2 != "")
                {
                    //encrptString += fenge2;
                    encrptString.Append(fenge2);
                }
                else if (c == ':' && fenge3 != "")
                {
                    //encrptString += fenge3;
                    encrptString.Append(fenge3);
                }
                else
                {
                    //encrptString += c;
                    encrptString.Append(c);
                }
            }
            return encrptString.ToString();
        }
        public static string Decrypt(string text)
        {            
            string decrptString = string.Empty;
            for (int i = 0; i < text.Length;i++ )
            {
                char c = text[i];
                if (char.IsLetter(c))
                {
                    char newChar = (char)(c - 3);
                    if (!char.IsLetter(newChar))
                    {
                        newChar += (char)26;
                    }
                    decrptString += newChar;
                }
                else
                {
                    decrptString += c;
                }
            }
            return decrptString;
        }
    }
}
