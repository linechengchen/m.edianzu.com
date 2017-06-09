/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:34
  Description:    数据表Zy_book对应的业务逻辑层Zy_book
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Zy_book_Entity:Zy_book
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Seq,OldId,BookName,BookType,Author,ChuBanShe,Keyword,Intro,Other,Path,ImgSrc,OldImgSrc,UserName,CreateTime,ModifyTime,Url,IsTrue,BookTypeId,ReadSum,BookSaleId,CategoryId,RecommendId from Zy_book
delete from Zy_book
INSERT INTO Zy_book (Id,Seq,OldId,BookName,BookType,Author,ChuBanShe,Keyword,Intro,Other,Path,ImgSrc,OldImgSrc,UserName,CreateTime,ModifyTime,Url,IsTrue,BookTypeId,ReadSum,BookSaleId,CategoryId,RecommendId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Zy_book SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Seq = valObj2.Seq;
        valObj.OldId = valObj2.OldId;
        valObj.BookName = valObj2.BookName;
        valObj.BookType = valObj2.BookType;
        valObj.Author = valObj2.Author;
        valObj.ChuBanShe = valObj2.ChuBanShe;
        valObj.Keyword = valObj2.Keyword;
        valObj.Intro = valObj2.Intro;
        valObj.Other = valObj2.Other;
        valObj.Path = valObj2.Path;
        valObj.ImgSrc = valObj2.ImgSrc;
        valObj.OldImgSrc = valObj2.OldImgSrc;
        valObj.UserName = valObj2.UserName;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Url = valObj2.Url;
        valObj.IsTrue = valObj2.IsTrue;
        valObj.BookTypeId = valObj2.BookTypeId;
        valObj.ReadSum = valObj2.ReadSum;
        valObj.BookSaleId = valObj2.BookSaleId;
        valObj.CategoryId = valObj2.CategoryId;
        valObj.RecommendId = valObj2.RecommendId; 
        valObj.Id = "";
        valObj.Seq = "";
        valObj.OldId = "";
        valObj.BookName = "";
        valObj.BookType = "";
        valObj.Author = "";
        valObj.ChuBanShe = "";
        valObj.Keyword = "";
        valObj.Intro = "";
        valObj.Other = "";
        valObj.Path = "";
        valObj.ImgSrc = "";
        valObj.OldImgSrc = "";
        valObj.UserName = "";
        valObj.CreateTime = "";
        valObj.ModifyTime = "";
        valObj.Url = "";
        valObj.IsTrue = "";
        valObj.BookTypeId = "";
        valObj.ReadSum = "";
        valObj.BookSaleId = "";
        valObj.CategoryId = "";
        valObj.RecommendId = ""; 
        "Id": $("#txt_Id").val(),
        "Seq": $("#txt_Seq").val(),
        "OldId": $("#txt_OldId").val(),
        "BookName": $("#txt_BookName").val(),
        "BookType": $("#txt_BookType").val(),
        "Author": $("#txt_Author").val(),
        "ChuBanShe": $("#txt_ChuBanShe").val(),
        "Keyword": $("#txt_Keyword").val(),
        "Intro": $("#txt_Intro").val(),
        "Other": $("#txt_Other").val(),
        "Path": $("#txt_Path").val(),
        "ImgSrc": $("#txt_ImgSrc").val(),
        "OldImgSrc": $("#txt_OldImgSrc").val(),
        "UserName": $("#txt_UserName").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Url": $("#txt_Url").val(),
        "IsTrue": $("#txt_IsTrue").val(),
        "BookTypeId": $("#txt_BookTypeId").val(),
        "ReadSum": $("#txt_ReadSum").val(),
        "BookSaleId": $("#txt_BookSaleId").val(),
        "CategoryId": $("#txt_CategoryId").val(),
        "RecommendId": $("#txt_RecommendId").val(), 
 * ************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// <para>书的ZY</para>
    /// <para>与Zy_book数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Zy_book : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Zy_book Factory()
        {
            return new Zy_book();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> Id:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> 旧的id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _OldId
        {            
            get { return this.OldId; }
            set { this.OldId = value; }
        }
        
        /// <summary> 书的名字:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BookName
        {            
            get { return this.BookName; }
            set { this.BookName = value; }
        }
        
        /// <summary> 类型的书:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BookType
        {            
            get { return this.BookType; }
            set { this.BookType = value; }
        }
        
        /// <summary> 作者:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Author
        {            
            get { return this.Author; }
            set { this.Author = value; }
        }
        
        /// <summary> 楚在她:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChuBanShe
        {            
            get { return this.ChuBanShe; }
            set { this.ChuBanShe = value; }
        }
        
        /// <summary> Keyword:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Keyword
        {            
            get { return this.Keyword; }
            set { this.Keyword = value; }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> 其他的:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Other
        {            
            get { return this.Other; }
            set { this.Other = value; }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> SRC。:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _ImgSrc
        {            
            get { return this.ImgSrc; }
            set { this.ImgSrc = value; }
        }
        
        /// <summary> 旧的SRC。:[CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _OldImgSrc
        {            
            get { return this.OldImgSrc; }
            set { this.OldImgSrc = value; }
        }
        
        /// <summary> 用户登录名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserName
        {            
            get { return this.UserName; }
            set { this.UserName = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> Modify时代:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary> 是真实的:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsTrue
        {            
            get { return this.IsTrue; }
            set { this.IsTrue = value; }
        }
        
        /// <summary> Typeid的书:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BookTypeId
        {            
            get { return this.BookTypeId; }
            set { this.BookTypeId = value; }
        }
        
        /// <summary> 阅读量:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ReadSum
        {            
            get { return this.ReadSum; }
            set { this.ReadSum = value; }
        }
        
        /// <summary> 图书销售的id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BookSaleId
        {            
            get { return this.BookSaleId; }
            set { this.BookSaleId = value; }
        }
        
        /// <summary> 类别ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CategoryId
        {            
            get { return this.CategoryId; }
            set { this.CategoryId = value; }
        }
        
        /// <summary> 推荐ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _RecommendId
        {            
            get { return this.RecommendId; }
            set { this.RecommendId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //private 
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
            }
        }
        
        /// <summary> 旧的id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int OldId
        {
            get { return this.m_oldid; }
            set //
            {
                if (!oldid_initialized || m_oldid != value)
                {
                    this.m_oldid = value;
                }
                oldid_initialized = true;
            }
        }
        
        /// <summary> 书的名字:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string BookName
        {
            get { return this.m_bookname; }
            set //
            {
                if (!bookname_initialized || m_bookname != value)
                {
                    this.m_bookname = value;
                }
                bookname_initialized = true;
            }
        }
        
        /// <summary> 类型的书:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string BookType
        {
            get { return this.m_booktype; }
            set //
            {
                if (!booktype_initialized || m_booktype != value)
                {
                    this.m_booktype = value;
                }
                booktype_initialized = true;
            }
        }
        
        /// <summary> 作者:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Author
        {
            get { return this.m_author; }
            set //
            {
                if (!author_initialized || m_author != value)
                {
                    this.m_author = value;
                }
                author_initialized = true;
            }
        }
        
        /// <summary> 楚在她:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChuBanShe
        {
            get { return this.m_chubanshe; }
            set //
            {
                if (!chubanshe_initialized || m_chubanshe != value)
                {
                    this.m_chubanshe = value;
                }
                chubanshe_initialized = true;
            }
        }
        
        /// <summary> Keyword:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Keyword
        {
            get { return this.m_keyword; }
            set //
            {
                if (!keyword_initialized || m_keyword != value)
                {
                    this.m_keyword = value;
                }
                keyword_initialized = true;
            }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Intro
        {
            get { return this.m_intro; }
            set //
            {
                if (!intro_initialized || m_intro != value)
                {
                    this.m_intro = value;
                }
                intro_initialized = true;
            }
        }
        
        /// <summary> 其他的:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Other
        {
            get { return this.m_other; }
            set //
            {
                if (!other_initialized || m_other != value)
                {
                    this.m_other = value;
                }
                other_initialized = true;
            }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }
        
        /// <summary> SRC。:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string ImgSrc
        {
            get { return this.m_imgsrc; }
            set //
            {
                if (!imgsrc_initialized || m_imgsrc != value)
                {
                    this.m_imgsrc = value;
                }
                imgsrc_initialized = true;
            }
        }
        
        /// <summary> 旧的SRC。:[CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string OldImgSrc
        {
            get { return this.m_oldimgsrc; }
            set //
            {
                if (!oldimgsrc_initialized || m_oldimgsrc != value)
                {
                    this.m_oldimgsrc = value;
                }
                oldimgsrc_initialized = true;
            }
        }
        
        /// <summary> 用户登录名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserName
        {
            get { return this.m_username; }
            set //
            {
                if (!username_initialized || m_username != value)
                {
                    this.m_username = value;
                }
                username_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime CreateTime
        {
            get { return this.m_createtime; }
            set //
            {
                if (!createtime_initialized || m_createtime != value)
                {
                    this.m_createtime = value;
                }
                createtime_initialized = true;
            }
        }
        
        /// <summary> Modify时代:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }
        
        /// <summary> 是真实的:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool IsTrue
        {
            get { return this.m_istrue; }
            set //
            {
                if (!istrue_initialized || m_istrue != value)
                {
                    this.m_istrue = value;
                }
                istrue_initialized = true;
            }
        }
        
        /// <summary> Typeid的书:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BookTypeId
        {
            get { return this.m_booktypeid; }
            set //
            {
                if (!booktypeid_initialized || m_booktypeid != value)
                {
                    this.m_booktypeid = value;
                }
                booktypeid_initialized = true;
            }
        }
        
        /// <summary> 阅读量:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ReadSum
        {
            get { return this.m_readsum; }
            set //
            {
                if (!readsum_initialized || m_readsum != value)
                {
                    this.m_readsum = value;
                }
                readsum_initialized = true;
            }
        }
        
        /// <summary> 图书销售的id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BookSaleId
        {
            get { return this.m_booksaleid; }
            set //
            {
                if (!booksaleid_initialized || m_booksaleid != value)
                {
                    this.m_booksaleid = value;
                }
                booksaleid_initialized = true;
            }
        }
        
        /// <summary> 类别ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CategoryId
        {
            get { return this.m_categoryid; }
            set //
            {
                if (!categoryid_initialized || m_categoryid != value)
                {
                    this.m_categoryid = value;
                }
                categoryid_initialized = true;
            }
        }
        
        /// <summary> 推荐ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int RecommendId
        {
            get { return this.m_recommendid; }
            set //
            {
                if (!recommendid_initialized || m_recommendid != value)
                {
                    this.m_recommendid = value;
                }
                recommendid_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Zy_book].[Id]", typeof(int), 4, default(int));
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[Zy_book].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>旧的id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldId =  new AttributeItem("[Zy_book].[OldId]", typeof(int), 4, default(int));
            
            /// <summary>书的名字:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookName =  new AttributeItem("[Zy_book].[BookName]", typeof(string), 200, default(string));
            
            /// <summary>类型的书:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookType =  new AttributeItem("[Zy_book].[BookType]", typeof(string), 200, default(string));
            
            /// <summary>作者:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Author =  new AttributeItem("[Zy_book].[Author]", typeof(string), 200, default(string));
            
            /// <summary>楚在她:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChuBanShe =  new AttributeItem("[Zy_book].[ChuBanShe]", typeof(string), 200, default(string));
            
            /// <summary>Keyword:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Keyword =  new AttributeItem("[Zy_book].[Keyword]", typeof(string), 500, default(string));
            
            /// <summary>简介:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[Zy_book].[Intro]", typeof(string), -1, default(string));
            
            /// <summary>其他的:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Other =  new AttributeItem("[Zy_book].[Other]", typeof(string), 500, default(string));
            
            /// <summary>路径:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Zy_book].[Path]", typeof(string), 500, default(string));
            
            /// <summary>SRC。:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem ImgSrc =  new AttributeItem("[Zy_book].[ImgSrc]", typeof(string), 1000, default(string));
            
            /// <summary>旧的SRC。:[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem OldImgSrc =  new AttributeItem("[Zy_book].[OldImgSrc]", typeof(string), 300, default(string));
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserName =  new AttributeItem("[Zy_book].[UserName]", typeof(string), 100, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Zy_book].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>Modify时代:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Zy_book].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[Zy_book].[Url]", typeof(string), 200, default(string));
            
            /// <summary>是真实的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsTrue =  new AttributeItem("[Zy_book].[IsTrue]", typeof(bool), 1, default(bool));
            
            /// <summary>Typeid的书:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookTypeId =  new AttributeItem("[Zy_book].[BookTypeId]", typeof(int), 4, default(int));
            
            /// <summary>阅读量:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ReadSum =  new AttributeItem("[Zy_book].[ReadSum]", typeof(int), 4, default(int));
            
            /// <summary>图书销售的id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookSaleId =  new AttributeItem("[Zy_book].[BookSaleId]", typeof(int), 4, default(int));
            
            /// <summary>类别ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CategoryId =  new AttributeItem("[Zy_book].[CategoryId]", typeof(int), 4, default(int));
            
            /// <summary>推荐ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RecommendId =  new AttributeItem("[Zy_book].[RecommendId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private int m_oldid;
        /// <summary></summary>
        protected bool oldid_initialized = false;
        
        private string m_bookname;
        /// <summary></summary>
        protected bool bookname_initialized = false;
        
        private string m_booktype;
        /// <summary></summary>
        protected bool booktype_initialized = false;
        
        private string m_author;
        /// <summary></summary>
        protected bool author_initialized = false;
        
        private string m_chubanshe;
        /// <summary></summary>
        protected bool chubanshe_initialized = false;
        
        private string m_keyword;
        /// <summary></summary>
        protected bool keyword_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private string m_other;
        /// <summary></summary>
        protected bool other_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private string m_imgsrc;
        /// <summary></summary>
        protected bool imgsrc_initialized = false;
        
        private string m_oldimgsrc;
        /// <summary></summary>
        protected bool oldimgsrc_initialized = false;
        
        private string m_username;
        /// <summary></summary>
        protected bool username_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private bool m_istrue;
        /// <summary></summary>
        protected bool istrue_initialized = false;
        
        private int m_booktypeid;
        /// <summary></summary>
        protected bool booktypeid_initialized = false;
        
        private int m_readsum;
        /// <summary></summary>
        protected bool readsum_initialized = false;
        
        private int m_booksaleid;
        /// <summary></summary>
        protected bool booksaleid_initialized = false;
        
        private int m_categoryid;
        /// <summary></summary>
        protected bool categoryid_initialized = false;
        
        private int m_recommendid;
        /// <summary></summary>
        protected bool recommendid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Zy_book";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.oldid_initialized = IsLoadAllAttributes;this.bookname_initialized = IsLoadAllAttributes;this.booktype_initialized = IsLoadAllAttributes;this.author_initialized = IsLoadAllAttributes;this.chubanshe_initialized = IsLoadAllAttributes;this.keyword_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.other_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.imgsrc_initialized = IsLoadAllAttributes;this.oldimgsrc_initialized = IsLoadAllAttributes;this.username_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.istrue_initialized = IsLoadAllAttributes;this.booktypeid_initialized = IsLoadAllAttributes;this.readsum_initialized = IsLoadAllAttributes;this.booksaleid_initialized = IsLoadAllAttributes;this.categoryid_initialized = IsLoadAllAttributes;this.recommendid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Zy_book value = new Zy_book();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldId"))
				value.oldid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookName"))
				value.bookname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookType"))
				value.booktype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Author"))
				value.author_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChuBanShe"))
				value.chubanshe_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Keyword"))
				value.keyword_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Other"))
				value.other_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ImgSrc"))
				value.imgsrc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldImgSrc"))
				value.oldimgsrc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserName"))
				value.username_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsTrue"))
				value.istrue_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookTypeId"))
				value.booktypeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ReadSum"))
				value.readsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookSaleId"))
				value.booksaleid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CategoryId"))
				value.categoryid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RecommendId"))
				value.recommendid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Zy_book Clone()
        {
            return (Zy_book)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Zy_book()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Zy_book() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Zy_book(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Zy_book(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Zy_book(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Zy_book(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Zy_book(int id1, int seq1, int oldid1, string bookname1, string booktype1, string author1, string chubanshe1, string keyword1, string intro1, string other1, string path1, string imgsrc1, string oldimgsrc1, string username1, DateTime createtime1, DateTime modifytime1, string url1, bool istrue1, int booktypeid1, int readsum1, int booksaleid1, int categoryid1, int recommendid1)
        {
            
            this.Id = id1;
            
            this.Seq = seq1;
            
            this.OldId = oldid1;
            
            this.BookName = bookname1;
            
            this.BookType = booktype1;
            
            this.Author = author1;
            
            this.ChuBanShe = chubanshe1;
            
            this.Keyword = keyword1;
            
            this.Intro = intro1;
            
            this.Other = other1;
            
            this.Path = path1;
            
            this.ImgSrc = imgsrc1;
            
            this.OldImgSrc = oldimgsrc1;
            
            this.UserName = username1;
            
            this.CreateTime = createtime1;
            
            this.ModifyTime = modifytime1;
            
            this.Url = url1;
            
            this.IsTrue = istrue1;
            
            this.BookTypeId = booktypeid1;
            
            this.ReadSum = readsum1;
            
            this.BookSaleId = booksaleid1;
            
            this.CategoryId = categoryid1;
            
            this.RecommendId = recommendid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Zy_book FromIView(IView view)
        {
            return (Zy_book)IView.GetITable(view, "Zy_book");
        }
        /// <summary>获得一个实例  </summary>
        public static Zy_book GetOneInstance()
        {
            Zy_book value = new Zy_book();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Zy_book Retrieve()
        {
            BLLTable<Zy_book>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "OldId":
			        return OldId;
			    			
			    case "BookName":
			        return BookName;
			    			
			    case "BookType":
			        return BookType;
			    			
			    case "Author":
			        return Author;
			    			
			    case "ChuBanShe":
			        return ChuBanShe;
			    			
			    case "Keyword":
			        return Keyword;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "Other":
			        return Other;
			    			
			    case "Path":
			        return Path;
			    			
			    case "ImgSrc":
			        return ImgSrc;
			    			
			    case "OldImgSrc":
			        return OldImgSrc;
			    			
			    case "UserName":
			        return UserName;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Url":
			        return Url;
			    			
			    case "IsTrue":
			        return IsTrue;
			    			
			    case "BookTypeId":
			        return BookTypeId;
			    			
			    case "ReadSum":
			        return ReadSum;
			    			
			    case "BookSaleId":
			        return BookSaleId;
			    			
			    case "CategoryId":
			        return CategoryId;
			    			
			    case "RecommendId":
			        return RecommendId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OldId":
			        this.OldId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "BookName":
			        this.BookName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BookType":
			        this.BookType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Author":
			        this.Author = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChuBanShe":
			        this.ChuBanShe = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Keyword":
			        this.Keyword = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Other":
			        this.Other = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ImgSrc":
			        this.ImgSrc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OldImgSrc":
			        this.OldImgSrc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserName":
			        this.UserName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsTrue":
			        this.IsTrue = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "BookTypeId":
			        this.BookTypeId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ReadSum":
			        this.ReadSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "BookSaleId":
			        this.BookSaleId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CategoryId":
			        this.CategoryId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "RecommendId":
			        this.RecommendId = Convert.ToInt32(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					return id_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "OldId":
					return oldid_initialized;
				
				case "BookName":
					return bookname_initialized;
				
				case "BookType":
					return booktype_initialized;
				
				case "Author":
					return author_initialized;
				
				case "ChuBanShe":
					return chubanshe_initialized;
				
				case "Keyword":
					return keyword_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "Other":
					return other_initialized;
				
				case "Path":
					return path_initialized;
				
				case "ImgSrc":
					return imgsrc_initialized;
				
				case "OldImgSrc":
					return oldimgsrc_initialized;
				
				case "UserName":
					return username_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Url":
					return url_initialized;
				
				case "IsTrue":
					return istrue_initialized;
				
				case "BookTypeId":
					return booktypeid_initialized;
				
				case "ReadSum":
					return readsum_initialized;
				
				case "BookSaleId":
					return booksaleid_initialized;
				
				case "CategoryId":
					return categoryid_initialized;
				
				case "RecommendId":
					return recommendid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "OldId":
					oldid_initialized = ret;
					return true;
				
				case "BookName":
					bookname_initialized = ret;
					return true;
				
				case "BookType":
					booktype_initialized = ret;
					return true;
				
				case "Author":
					author_initialized = ret;
					return true;
				
				case "ChuBanShe":
					chubanshe_initialized = ret;
					return true;
				
				case "Keyword":
					keyword_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "Other":
					other_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "ImgSrc":
					imgsrc_initialized = ret;
					return true;
				
				case "OldImgSrc":
					oldimgsrc_initialized = ret;
					return true;
				
				case "UserName":
					username_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "IsTrue":
					istrue_initialized = ret;
					return true;
				
				case "BookTypeId":
					booktypeid_initialized = ret;
					return true;
				
				case "ReadSum":
					readsum_initialized = ret;
					return true;
				
				case "BookSaleId":
					booksaleid_initialized = ret;
					return true;
				
				case "CategoryId":
					categoryid_initialized = ret;
					return true;
				
				case "RecommendId":
					recommendid_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (id_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (oldid_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.OldId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldId);
                }
			}
			
			if (bookname_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.BookName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookName);
                }
			}
			
			if (booktype_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.BookType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookType);
                }
			}
			
			if (author_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Author;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Author);
                }
			}
			
			if (chubanshe_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.ChuBanShe;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChuBanShe);
                }
			}
			
			if (keyword_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Keyword;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Keyword);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (other_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Other;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Other);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (imgsrc_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.ImgSrc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ImgSrc);
                }
			}
			
			if (oldimgsrc_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.OldImgSrc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldImgSrc);
                }
			}
			
			if (username_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.UserName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserName);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (istrue_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.IsTrue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsTrue);
                }
			}
			
			if (booktypeid_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.BookTypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookTypeId);
                }
			}
			
			if (readsum_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.ReadSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ReadSum);
                }
			}
			
			if (booksaleid_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.BookSaleId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookSaleId);
                }
			}
			
			if (categoryid_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.CategoryId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CategoryId);
                }
			}
			
			if (recommendid_initialized)
			{
                AttributeItem attr = Zy_book.Attribute.RecommendId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RecommendId);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class Zy_bookJson
        {
            
            /// <summary>Id:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>旧的id:[CtrlTypeDic-{InputString}]</summary>
            public int OldId { get; set; }
            
            /// <summary>书的名字:[CtrlTypeDic-{InputString}]</summary>
            public string BookName { get; set; }
            
            /// <summary>类型的书:[CtrlTypeDic-{InputString}]</summary>
            public string BookType { get; set; }
            
            /// <summary>作者:[CtrlTypeDic-{InputString}]</summary>
            public string Author { get; set; }
            
            /// <summary>楚在她:[CtrlTypeDic-{InputString}]</summary>
            public string ChuBanShe { get; set; }
            
            /// <summary>Keyword:[CtrlTypeDic-{Text}]</summary>
            public string Keyword { get; set; }
            
            /// <summary>简介:[CtrlTypeDic-{InputString}]</summary>
            public string Intro { get; set; }
            
            /// <summary>其他的:[CtrlTypeDic-{Text}]</summary>
            public string Other { get; set; }
            
            /// <summary>路径:[CtrlTypeDic-{Text}]</summary>
            public string Path { get; set; }
            
            /// <summary>SRC。:[CtrlTypeDic-{Text}]</summary>
            public string ImgSrc { get; set; }
            
            /// <summary>旧的SRC。:[CtrlTypeDic-{SmallText}]</summary>
            public string OldImgSrc { get; set; }
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public string UserName { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>Modify时代:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>是真实的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsTrue { get; set; }
            
            /// <summary>Typeid的书:[CtrlTypeDic-{InputString}]</summary>
            public int BookTypeId { get; set; }
            
            /// <summary>阅读量:[CtrlTypeDic-{InputString}]</summary>
            public int ReadSum { get; set; }
            
            /// <summary>图书销售的id:[CtrlTypeDic-{InputString}]</summary>
            public int BookSaleId { get; set; }
            
            /// <summary>类别ID:[CtrlTypeDic-{InputString}]</summary>
            public int CategoryId { get; set; }
            
            /// <summary>推荐ID:[CtrlTypeDic-{InputString}]</summary>
            public int RecommendId { get; set; }
        }
        #endregion
    }
}