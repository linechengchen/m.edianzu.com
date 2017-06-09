/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:34
  Description:    数据表Zy_chapter对应的业务逻辑层Zy_chapter
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Zy_chapter_Entity:Zy_chapter
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Seq,OldId,BookId,Pid,Intro,Keyword,Path,OldContentHtml,ContentHtml,ImgSrc,ChapterName,UserName,CreateTime,ModifyTime,Url,IsTrue from Zy_chapter
delete from Zy_chapter
INSERT INTO Zy_chapter (Id,Seq,OldId,BookId,Pid,Intro,Keyword,Path,OldContentHtml,ContentHtml,ImgSrc,ChapterName,UserName,CreateTime,ModifyTime,Url,IsTrue)
     VALUES
           ('','','','','','','','','','','','','','','','','')
UPDATE Zy_chapter SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Seq = valObj2.Seq;
        valObj.OldId = valObj2.OldId;
        valObj.BookId = valObj2.BookId;
        valObj.Pid = valObj2.Pid;
        valObj.Intro = valObj2.Intro;
        valObj.Keyword = valObj2.Keyword;
        valObj.Path = valObj2.Path;
        valObj.OldContentHtml = valObj2.OldContentHtml;
        valObj.ContentHtml = valObj2.ContentHtml;
        valObj.ImgSrc = valObj2.ImgSrc;
        valObj.ChapterName = valObj2.ChapterName;
        valObj.UserName = valObj2.UserName;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Url = valObj2.Url;
        valObj.IsTrue = valObj2.IsTrue; 
        valObj.Id = "";
        valObj.Seq = "";
        valObj.OldId = "";
        valObj.BookId = "";
        valObj.Pid = "";
        valObj.Intro = "";
        valObj.Keyword = "";
        valObj.Path = "";
        valObj.OldContentHtml = "";
        valObj.ContentHtml = "";
        valObj.ImgSrc = "";
        valObj.ChapterName = "";
        valObj.UserName = "";
        valObj.CreateTime = "";
        valObj.ModifyTime = "";
        valObj.Url = "";
        valObj.IsTrue = ""; 
        "Id": $("#txt_Id").val(),
        "Seq": $("#txt_Seq").val(),
        "OldId": $("#txt_OldId").val(),
        "BookId": $("#txt_BookId").val(),
        "Pid": $("#txt_Pid").val(),
        "Intro": $("#txt_Intro").val(),
        "Keyword": $("#txt_Keyword").val(),
        "Path": $("#txt_Path").val(),
        "OldContentHtml": $("#txt_OldContentHtml").val(),
        "ContentHtml": $("#txt_ContentHtml").val(),
        "ImgSrc": $("#txt_ImgSrc").val(),
        "ChapterName": $("#txt_ChapterName").val(),
        "UserName": $("#txt_UserName").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Url": $("#txt_Url").val(),
        "IsTrue": $("#txt_IsTrue").val(), 
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
    /// <para>第一章ZY</para>
    /// <para>与Zy_chapter数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Zy_chapter : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Zy_chapter Factory()
        {
            return new Zy_chapter();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 序列:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> 旧身份证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _OldId
        {            
            get { return this.OldId; }
            set { this.OldId = value; }
        }
        
        /// <summary> 本ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BookId
        {            
            get { return this.BookId; }
            set { this.BookId = value; }
        }
        
        /// <summary> PID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Pid
        {            
            get { return this.Pid; }
            set { this.Pid = value; }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> 关键词:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Keyword
        {            
            get { return this.Keyword; }
            set { this.Keyword = value; }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> 旧内容的HTML:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OldContentHtml
        {            
            get { return this.OldContentHtml; }
            set { this.OldContentHtml = value; }
        }
        
        /// <summary> 内容网址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ContentHtml
        {            
            get { return this.ContentHtml; }
            set { this.ContentHtml = value; }
        }
        
        /// <summary> IMGSRC:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _ImgSrc
        {            
            get { return this.ImgSrc; }
            set { this.ImgSrc = value; }
        }
        
        /// <summary> 章名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterName
        {            
            get { return this.ChapterName; }
            set { this.ChapterName = value; }
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
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
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
        
        /// <summary> 是真的:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsTrue
        {            
            get { return this.IsTrue; }
            set { this.IsTrue = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 序列:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 旧身份证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 本ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BookId
        {
            get { return this.m_bookid; }
            set //
            {
                if (!bookid_initialized || m_bookid != value)
                {
                    this.m_bookid = value;
                }
                bookid_initialized = true;
            }
        }
        
        /// <summary> PID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Pid
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
            }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 关键词:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 旧内容的HTML:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OldContentHtml
        {
            get { return this.m_oldcontenthtml; }
            set //
            {
                if (!oldcontenthtml_initialized || m_oldcontenthtml != value)
                {
                    this.m_oldcontenthtml = value;
                }
                oldcontenthtml_initialized = true;
            }
        }
        
        /// <summary> 内容网址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ContentHtml
        {
            get { return this.m_contenthtml; }
            set //
            {
                if (!contenthtml_initialized || m_contenthtml != value)
                {
                    this.m_contenthtml = value;
                }
                contenthtml_initialized = true;
            }
        }
        
        /// <summary> IMGSRC:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 章名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChapterName
        {
            get { return this.m_chaptername; }
            set //
            {
                if (!chaptername_initialized || m_chaptername != value)
                {
                    this.m_chaptername = value;
                }
                chaptername_initialized = true;
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
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是真的:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Zy_chapter].[Id]", typeof(int), 4, default(int));
            
            /// <summary>序列:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[Zy_chapter].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>旧身份证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldId =  new AttributeItem("[Zy_chapter].[OldId]", typeof(int), 4, default(int));
            
            /// <summary>本ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookId =  new AttributeItem("[Zy_chapter].[BookId]", typeof(int), 4, default(int));
            
            /// <summary>PID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pid =  new AttributeItem("[Zy_chapter].[Pid]", typeof(int), 4, default(int));
            
            /// <summary>简介:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[Zy_chapter].[Intro]", typeof(string), 500, default(string));
            
            /// <summary>关键词:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Keyword =  new AttributeItem("[Zy_chapter].[Keyword]", typeof(string), -1, default(string));
            
            /// <summary>路径:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Zy_chapter].[Path]", typeof(string), 500, default(string));
            
            /// <summary>旧内容的HTML:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldContentHtml =  new AttributeItem("[Zy_chapter].[OldContentHtml]", typeof(string), -1, default(string));
            
            /// <summary>内容网址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ContentHtml =  new AttributeItem("[Zy_chapter].[ContentHtml]", typeof(string), -1, default(string));
            
            /// <summary>IMGSRC:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem ImgSrc =  new AttributeItem("[Zy_chapter].[ImgSrc]", typeof(string), 500, default(string));
            
            /// <summary>章名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterName =  new AttributeItem("[Zy_chapter].[ChapterName]", typeof(string), 100, default(string));
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserName =  new AttributeItem("[Zy_chapter].[UserName]", typeof(string), 100, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Zy_chapter].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Zy_chapter].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[Zy_chapter].[Url]", typeof(string), 200, default(string));
            
            /// <summary>是真的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsTrue =  new AttributeItem("[Zy_chapter].[IsTrue]", typeof(bool), 1, default(bool));
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
        
        private int m_bookid;
        /// <summary></summary>
        protected bool bookid_initialized = false;
        
        private int m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private string m_keyword;
        /// <summary></summary>
        protected bool keyword_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private string m_oldcontenthtml;
        /// <summary></summary>
        protected bool oldcontenthtml_initialized = false;
        
        private string m_contenthtml;
        /// <summary></summary>
        protected bool contenthtml_initialized = false;
        
        private string m_imgsrc;
        /// <summary></summary>
        protected bool imgsrc_initialized = false;
        
        private string m_chaptername;
        /// <summary></summary>
        protected bool chaptername_initialized = false;
        
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
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Zy_chapter";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.oldid_initialized = IsLoadAllAttributes;this.bookid_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.keyword_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.oldcontenthtml_initialized = IsLoadAllAttributes;this.contenthtml_initialized = IsLoadAllAttributes;this.imgsrc_initialized = IsLoadAllAttributes;this.chaptername_initialized = IsLoadAllAttributes;this.username_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.istrue_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Zy_chapter value = new Zy_chapter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldId"))
				value.oldid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookId"))
				value.bookid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pid"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Keyword"))
				value.keyword_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldContentHtml"))
				value.oldcontenthtml_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ContentHtml"))
				value.contenthtml_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ImgSrc"))
				value.imgsrc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterName"))
				value.chaptername_initialized = true;
            
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
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Zy_chapter Clone()
        {
            return (Zy_chapter)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Zy_chapter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Zy_chapter() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Zy_chapter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Zy_chapter(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Zy_chapter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Zy_chapter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Zy_chapter(int id1, int seq1, int oldid1, int bookid1, int pid1, string intro1, string keyword1, string path1, string oldcontenthtml1, string contenthtml1, string imgsrc1, string chaptername1, string username1, DateTime createtime1, DateTime modifytime1, string url1, bool istrue1)
        {
            
            this.Id = id1;
            
            this.Seq = seq1;
            
            this.OldId = oldid1;
            
            this.BookId = bookid1;
            
            this.Pid = pid1;
            
            this.Intro = intro1;
            
            this.Keyword = keyword1;
            
            this.Path = path1;
            
            this.OldContentHtml = oldcontenthtml1;
            
            this.ContentHtml = contenthtml1;
            
            this.ImgSrc = imgsrc1;
            
            this.ChapterName = chaptername1;
            
            this.UserName = username1;
            
            this.CreateTime = createtime1;
            
            this.ModifyTime = modifytime1;
            
            this.Url = url1;
            
            this.IsTrue = istrue1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Zy_chapter FromIView(IView view)
        {
            return (Zy_chapter)IView.GetITable(view, "Zy_chapter");
        }
        /// <summary>获得一个实例  </summary>
        public static Zy_chapter GetOneInstance()
        {
            Zy_chapter value = new Zy_chapter();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Zy_chapter Retrieve()
        {
            BLLTable<Zy_chapter>.GetRowData(this);
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
			    			
			    case "BookId":
			        return BookId;
			    			
			    case "Pid":
			        return Pid;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "Keyword":
			        return Keyword;
			    			
			    case "Path":
			        return Path;
			    			
			    case "OldContentHtml":
			        return OldContentHtml;
			    			
			    case "ContentHtml":
			        return ContentHtml;
			    			
			    case "ImgSrc":
			        return ImgSrc;
			    			
			    case "ChapterName":
			        return ChapterName;
			    			
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
			    			
			    case "BookId":
			        this.BookId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pid":
			        this.Pid = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Keyword":
			        this.Keyword = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OldContentHtml":
			        this.OldContentHtml = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ContentHtml":
			        this.ContentHtml = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ImgSrc":
			        this.ImgSrc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChapterName":
			        this.ChapterName = Convert.ToString(AttributeValue);
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
				
				case "BookId":
					return bookid_initialized;
				
				case "Pid":
					return pid_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "Keyword":
					return keyword_initialized;
				
				case "Path":
					return path_initialized;
				
				case "OldContentHtml":
					return oldcontenthtml_initialized;
				
				case "ContentHtml":
					return contenthtml_initialized;
				
				case "ImgSrc":
					return imgsrc_initialized;
				
				case "ChapterName":
					return chaptername_initialized;
				
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
				
				case "BookId":
					bookid_initialized = ret;
					return true;
				
				case "Pid":
					pid_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "Keyword":
					keyword_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "OldContentHtml":
					oldcontenthtml_initialized = ret;
					return true;
				
				case "ContentHtml":
					contenthtml_initialized = ret;
					return true;
				
				case "ImgSrc":
					imgsrc_initialized = ret;
					return true;
				
				case "ChapterName":
					chaptername_initialized = ret;
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
                AttributeItem attr = Zy_chapter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (oldid_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.OldId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldId);
                }
			}
			
			if (bookid_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.BookId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookId);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Pid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pid);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (keyword_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Keyword;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Keyword);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (oldcontenthtml_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.OldContentHtml;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldContentHtml);
                }
			}
			
			if (contenthtml_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.ContentHtml;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ContentHtml);
                }
			}
			
			if (imgsrc_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.ImgSrc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ImgSrc);
                }
			}
			
			if (chaptername_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.ChapterName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterName);
                }
			}
			
			if (username_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.UserName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserName);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (istrue_initialized)
			{
                AttributeItem attr = Zy_chapter.Attribute.IsTrue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsTrue);
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
        public class Zy_chapterJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>序列:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>旧身份证:[CtrlTypeDic-{InputString}]</summary>
            public int OldId { get; set; }
            
            /// <summary>本ID:[CtrlTypeDic-{InputString}]</summary>
            public int BookId { get; set; }
            
            /// <summary>PID:[CtrlTypeDic-{InputString}]</summary>
            public int Pid { get; set; }
            
            /// <summary>简介:[CtrlTypeDic-{Text}]</summary>
            public string Intro { get; set; }
            
            /// <summary>关键词:[CtrlTypeDic-{InputString}]</summary>
            public string Keyword { get; set; }
            
            /// <summary>路径:[CtrlTypeDic-{Text}]</summary>
            public string Path { get; set; }
            
            /// <summary>旧内容的HTML:[CtrlTypeDic-{InputString}]</summary>
            public string OldContentHtml { get; set; }
            
            /// <summary>内容网址:[CtrlTypeDic-{InputString}]</summary>
            public string ContentHtml { get; set; }
            
            /// <summary>IMGSRC:[CtrlTypeDic-{Text}]</summary>
            public string ImgSrc { get; set; }
            
            /// <summary>章名:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterName { get; set; }
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public string UserName { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>是真的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsTrue { get; set; }
        }
        #endregion
    }
}