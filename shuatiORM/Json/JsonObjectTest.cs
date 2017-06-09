using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class JsonObjectTest
    {
        public string Test()
        {
            RootObject r1 = new RootObject();
            List<Jz_userImages> listuserimage = new List<Jz_userImages>();
            listuserimage = BLLTable<Jz_userImages>.Select();
            List<Jz_resume> listresume = new List<Jz_resume>();
            List<Jz_userEducation> listuserEducation = new List<Jz_userEducation>();
            Jz_resume resume1 = BLLTable<Jz_resume>.GetRowData(1);

            if (!string.IsNullOrEmpty(resume1.Tags))
            {
                Jz_userTagVOs cond1 = new Jz_userTagVOs();
                cond1.In(Jz_userTagVOs.Attribute.UserTagId, resume1.Tags.Trim(','));
                Jz_userTagVOs val1 = new Jz_userTagVOs();
                val1._Name = "";
                List<Jz_userTagVOs> listUserTag = BLLTable<Jz_userTagVOs>.Select(val1, cond1);
                r1.Add(listUserTag, "userTags");
            }
            listuserEducation = BLLTable<Jz_userEducation>.Select(3);
            
            r1.Add(listuserEducation, "userEducations");
            r1.Add(listuserEducation[0], "userEducation");
            r1.Add(listuserimage, "userImages");
            r1.Add(resume1);
            r1.isDebug = true;
            r1.isShuati = true;
            string json1 = r1.ToJsonHeadLower();
            return json1;
        }
    }
}
