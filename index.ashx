<%@ WebHandler Language="C#" Class="index" %>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;//命名空间：json序列化dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//命名空间：三层结构，业务逻辑层
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;//命名空间：三层结构，实体层

public class index : IHttpHandler
{
    
    public void ProcessRequest (HttpContext context) {
        RootObject r1 = new RootObject();
        V_index cond1 = new V_index();
        cond1.Is_index = true;
        cond1.Img_index=true;
        cond1.Zulin_index = true; 
        
  
       
        
        List<V_index> list1 = BLLTable<V_index>.Select(new V_index(),cond1);
        r1.Add(list1, "index");
      
        context.Response.Write(r1.ToJsonHeadLower());
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}