using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.Script.Serialization;//命名空间：json序列化dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//命名空间：三层结构，业务逻辑层
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Web;//命名空间：三层结构，实体层

public partial class BasePageShuati : System.Web.UI.Page
{
    #region cookie操作
    #region##删除cookies
    /////<summary>
    ///// 删除cookies
    /////</summary>
    //public void DelCookeis()
    //{
    //    if (Request.Cookies["Porschev"] != null)
    //    {
    //        HttpCookie cookies = new HttpCookie("Porschev");
    //        cookies.Expires = DateTime.Now.AddDays(-1);
    //        Response.Cookies.Add(cookies);
    //    }
    //}
    #endregion
    #region##删除cookies
    ///<summary>
    /// 删除cookies
    ///</summary>
    public void DelCookeis()
    {
        foreach (string cookiename in Request.Cookies.AllKeys)
        {
            HttpCookie cookies = Request.Cookies[cookiename];
            if (cookies != null)
            {
                cookies.Expires = DateTime.Today.AddDays(-1);
                Response.Cookies.Add(cookies);
                Request.Cookies.Remove(cookiename);
            }
        }
    }
    #endregion
    #region##得到cookies
    ///<summary>
    /// 得到cookies
    ///</summary>
    //public void GetCookies()
    //{
    //    HttpCookie cookies = Request.Cookies["Porschev"];
    //    string name = cookies["name"];   //通过key取出对应value，多key同理取
    //}
    #endregion
    #region##修改cookies
    ///<summary>
    /// 修改cookies
    ///</summary>
    public void ModCookies()
    {
        HttpCookie cookies = Request.Cookies["Porschev"];
        cookies["name"] = "wilson Z";
        //加上下面一句
        Response.Cookies["Porschev"].Expires = DateTime.Now.AddMinutes(-1);
    }
    #endregion
    #region##修改cookies
    ///<summary>
    /// 修改cookies
    ///</summary>
    //public void ModCookies()
    //{
    //    HttpCookie cookies = Request.Cookies["Porschev"];
    //    cookies["name"] = "wilson Z";
    //}        
    #endregion
    #region##添加cookeis
    ///<summary>
    /// 添加cookeis
    ///</summary>
    public void AddCookies(string name, string value)
    {
        HttpCookie cookies = new HttpCookie("Porschev");
        cookies["name"] = "Zhong Wei";
        cookies["sex"] = "1";
        cookies.Expires = DateTime.Now.AddMinutes(20);
        Response.Cookies.Add(cookies);
    }
    #endregion
    #endregion cookie操作

    #region 公共封装接口代码

    #region 设置值
    //从页面request中获取参数赋值到对象中
    public void RequestSet<MyTable>(MyTable table1, AttributeItem attr1, params string[] names)
        where MyTable : ITableImplement, new()
    {
        setRequest(table1, attr1, names);
    }
    //从页面request中获取参数赋值到对象中
    public void setRequest<MyTable>(MyTable table1, AttributeItem attr1, params string[] names)
        where MyTable : ITableImplement, new()
    {
        if (names != null)
            foreach (string name in names)
            {
                if (!string.IsNullOrEmpty(Request.QueryString[name]))
                {
                    table1.SetValue(attr1, Request.QueryString[name]);
                    break;
                }
            }
    }
    //request获取所有参数
    public MyTable RequestSet<MyTable>(MyTable itable)
        where MyTable : ITableImplement, new()
    {
        return set(itable);
    }
    public MyTable RequestSet<MyTable>(MyTable itable, params AttributeItem[] noAttrs)
        where MyTable : ITableImplement, new()
    {
        if (noAttrs != null && noAttrs.Length > 0)
        {
            foreach (AttributeItem attr in noAttrs)
            {
                itable.SetInitialized(attr, false);
            }
        }
        return set(itable);
    }
    //request获取所有参数
    public MyTable setRequest<MyTable>(MyTable itable)
        where MyTable : ITableImplement, new()
    {
        return set(itable);
    }
    //request获取所有参数
    public MyTable set<MyTable>(MyTable itable)
        where MyTable : ITableImplement, new()
    {
        return set(itable, "");
    }
    bool isNotContainsZero = true;
    //request获取所有参数
    public MyTable set<MyTable>(MyTable itable, string pre1)
        where MyTable : ITableImplement, new()
    {
        int count = 0;
        List<AttributeItem> list1 = itable.af_GetAttributes();
        if (list1.Count == 0)
        {
            MyTable itable2 = new MyTable(); itable2.LoadAllAttributes(true); 
            list1 = itable2.af_GetAttributes();
        }
        foreach (AttributeItem attr1 in list1)
        {
            if (noAttrs.Contains(attr1)) continue;
            string f1 = Request.QueryString[pre1 + attr1.FieldName];
            if (!string.IsNullOrEmpty(f1) && (isNotContainsZero && f1 != "0"))
            {
                count++;
                itable.SetValue(attr1, f1);
            }
            else
                itable.SetInitialized(attr1, false);
        }
        if (count == 0)//可能是post对象进来，是否需要处理
        {
            string js1 = null;
            try
            {
                js1 = getString();
                if (js1.StartsWith("{"))
                {
                    JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    //PostData = javaScriptSerializer.Deserialize<PostData>(js1);//字符串反序列化
                    //string email = Convert.ToString(Request.Form["email"]);
                    Response.Write("{\"code\":444, \"message\":\"老师提示请修改前端，因前端postAjax传参方式为json字符串模式\r\n\"");
                    Response.Write(js1);
                    Response.End();
                }
                else
                {
                    //string email = Convert.ToString(Request.Form["email"]);
                    //Response.Write("前端传参方式为非json字符串模式\r\n");
                    //Response.Write(js1);
                    //Response.End();
                }
            }
            catch (Exception ex1) { Response.Write("{\"code\":444, \"message\":\"" + js1 + "==异常==" + ex1.Message + "\""); Response.End(); }
        }
        return itable;
    }
    //得到post字符串
    public string getString()
    {
        string json1 = (Request.InputStream != null) ? (new System.IO.StreamReader(Request.InputStream).ReadToEnd()) : ""; Request.InputStream.Close();
        return json1;
    }
    #endregion

    public List<AttributeItem> noAttrs = new List<AttributeItem>(); 

    #endregion


    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
    }

    #region 课程学校老师的id获取
    private string College_id = "";
    private string Teacher_id = "";
    /// <summary>
    /// 课程id
    /// </summary>
    public string Course_id = "";
    public string user_id = "";
    Xt_course cc1 = null;

    /// <summary>
    /// 课程id
    /// </summary>
    /// <returns></returns>
    public string getCourse_id()
    {
        return Course_id;
    }
    /// <summary>
    /// 获取老师id
    /// </summary>
    /// <returns></returns>
    public string getTeacher_id()
    {
        if (Session["Teacher_id"] != null)
            return Convert.ToString(Session["Teacher_id"]);
        if (!string.IsNullOrEmpty(Teacher_id))
        {
            return Teacher_id;
        }
        if (!string.IsNullOrEmpty(Course_id))
        {
            if (string.IsNullOrEmpty(Teacher_id))
            {
                if (cc1 == null)
                    cc1 = BLLTable<Xt_course>.SelectOne(Xt_course.Attribute.Uuid, Course_id);
                if (cc1 != null)
                {
                    Teacher_id = cc1.Teacher_id;
                    Session["Teacher_id"] = Teacher_id;
                    return Teacher_id;
                }
            }
        }
        return Teacher_id;
    }
    /// <summary>
    /// 获取大学id
    /// </summary>
    /// <returns></returns>
    public string getCollege_id()
    {
        if (Session["College_id"] != null)
            return Convert.ToString(Session["College_id"]);
        if (!string.IsNullOrEmpty(College_id))
        {
            return College_id;
        }
        if (!string.IsNullOrEmpty(Course_id))
        {
            if (!string.IsNullOrEmpty(College_id))
            {
                if (cc1 == null)
                    cc1 = BLLTable<Xt_course>.SelectOne(Xt_course.Attribute.Uuid, Course_id);
                if (cc1 != null)
                {
                    College_id = cc1.College_id;
                    Session["College_id"] = College_id;
                    return College_id;
                }
            }
        }
        return Course_id;
    }
    protected override void OnPreLoad(EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["user_id"]))
            user_id = Request["user_id"];

        if (!string.IsNullOrEmpty(Request["Teacher_id"]))
            Teacher_id = Request["Teacher_id"];
        if (!string.IsNullOrEmpty(Request["College_id"]))
            College_id = Request["College_id"];

        if (!string.IsNullOrEmpty(Request["classes_id"]))
            Course_id = Request["classes_id"];
        if (!string.IsNullOrEmpty(Request["Course_id"]))
            Course_id = Request["Course_id"];

        if (!string.IsNullOrEmpty(Course_id))
            Session["Course_id"] = Course_id;

        base.OnPreLoad(e);
    }
    /// <summary>
    /// Category_ids  1,2,3  Category_names 中国,互联网
    /// </summary>
    /// <param name="category"></param>
    /// <param name="Category_ids"></param>
    /// <param name="Category_names"></param>
    /// <returns></returns>
    public int Split_category(string category, ref StringBuilder Category_ids, ref StringBuilder Category_names)
    {
        int count1 = 0;
        if (string.IsNullOrEmpty(category)) return count1;
        string[] category1 = category.Split(',');

        foreach (string v1 in category1)
        {
            if (string.IsNullOrEmpty(v1) || v1 == "0") continue;

            string[] category2 = v1.Split('_');
            if (category2.Length == 2)
            {
                count1++;
                string id = category2[0];
                string name = category2[1];
                Category_ids.Append(id).Append(",");
                Category_names.Append(name).Append(",");
            }
            else
            {
                Cs.Error("异常" + v1);
            }
        }
        if (Category_names.Length > 0)
            Category_names.Remove(Category_names.Length - 1, 1);
        if (Category_ids.Length > 0)
            Category_ids.Remove(Category_ids.Length - 1, 1);
        return count1;
    }

    #endregion 课程学校老师的id获取
}