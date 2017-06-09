using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    //user_id+秘钥，md5生成token
    public class UserHelper
    {
        internal static string miyao1 = "lkj@#$%^&";
        public static string getToken(Guid user_id)
        {
            return getToken(user_id.ToString());
        }
        public static string getToken(string user_id)
        {
            if (string.IsNullOrEmpty(user_id))
                return "";
            return PassWordService.GetMd5Str(miyao1 + user_id);
        }
        public static TUserInfo getUserInfo(WX_USER_INFO wxUser1)
        {
            TUserInfo user1 = new TUserInfo();
            if (!string.IsNullOrEmpty(wxUser1.User_id))
            {
                user1.User_id = Guid.Parse(wxUser1.User_id);
                user1.Token = getToken(wxUser1.User_id);
            }
            user1.Openid = wxUser1.Openid;
            //user1.SUBSCRIBE = Int32.Parse(subscribe);
            user1.Nick_name = wxUser1.Nick_name;

            if (wxUser1.Sex != 0)
                user1.Gender = Convert.ToString(wxUser1.Sex);// Int32.Parse(sex);

            //user1.LANGUAGE = language;
            user1.City = wxUser1.City;
            //user1.City_id = 36;
            user1.Province = wxUser1.Province;
            //user1.Province_id = "1";

            //user1.COUNTRY = country;
            user1.Head_img_url = wxUser1.Head_img_url;
            //user1.SUBSCRIBE_TIME = subscribe_time;
            //user1.REMARK = remark;

            if (!string.IsNullOrEmpty(wxUser1.Sc) && wxUser1.Sc != "999")
            {
                user1.Sc_id = ScHelper.getSc(wxUser1.Sc);
                TscWxInfo scinfo1 = BLLTable<TscWxInfo>.GetRowData(TscWxInfo.Attribute.Sc_id, user1.Sc_id);
                if(scinfo1!=null && scinfo1.IsNotNull())
                {
                    user1.School_id = scinfo1.School_id;                    
                    user1.School_name = scinfo1.Sc_name;
                }
            }
            return user1;
        }
    }
}
