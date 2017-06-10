<%@ WebHandler Language="C#" Class="detail" %>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;//命名空间：json序列化dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//命名空间：三层结构，业务逻辑层
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;//命名空间：三层结构，实体层

public class detail : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        RootObject r1 = new RootObject();
        try
        {


            Image cond1 = new Image();
            string uuid = HttpContext.Current.Request["uuid"];

            if(!string.IsNullOrEmpty(uuid))
            {
                cond1.Uuid = Guid.Parse(uuid);
                List<Image> list = new List<Image>();
                list =  BLLTable<Image>.Select(new Image() { }, cond1);
                r1.Add("img", list);
                if(list.Count==0)
                {
                    r1.code = 201;
                    r1.msg = "没有图片";
                }
            }
            else
            {
                r1.code = 201;
                r1.msg = "传入UUid参数为空";
            }

            context.Response.Write(r1.ToJsonHeadLower());
        }
        catch
        {
            r1.code = 2001;
            r1.msg = "try错误";
        }

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}