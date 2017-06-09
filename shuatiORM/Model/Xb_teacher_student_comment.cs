/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:05
  Description:    数据表Xb_teacher_student_comment对应的业务逻辑层Xb_teacher_student_comment
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_teacher_student_comment_Entity:Xb_teacher_student_comment
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Comment_sub_id,Content,Content_html,Content1,Content2,Create_time,Images,Reply,Reply1,Reply2,Student_id,Teacher_id,Uuid,Voice from Xb_teacher_student_comment
delete from Xb_teacher_student_comment
INSERT INTO Xb_teacher_student_comment (Id,Comment_sub_id,Content,Content_html,Content1,Content2,Create_time,Images,Reply,Reply1,Reply2,Student_id,Teacher_id,Uuid,Voice)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Xb_teacher_student_comment SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Comment_sub_id = valObj2.Comment_sub_id;
        valObj.Content = valObj2.Content;
        valObj.Content_html = valObj2.Content_html;
        valObj.Content1 = valObj2.Content1;
        valObj.Content2 = valObj2.Content2;
        valObj.Create_time = valObj2.Create_time;
        valObj.Images = valObj2.Images;
        valObj.Reply = valObj2.Reply;
        valObj.Reply1 = valObj2.Reply1;
        valObj.Reply2 = valObj2.Reply2;
        valObj.Student_id = valObj2.Student_id;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Uuid = valObj2.Uuid;
        valObj.Voice = valObj2.Voice; 
        valObj.Id = "";
        valObj.Comment_sub_id = "";
        valObj.Content = "";
        valObj.Content_html = "";
        valObj.Content1 = "";
        valObj.Content2 = "";
        valObj.Create_time = "";
        valObj.Images = "";
        valObj.Reply = "";
        valObj.Reply1 = "";
        valObj.Reply2 = "";
        valObj.Student_id = "";
        valObj.Teacher_id = "";
        valObj.Uuid = "";
        valObj.Voice = ""; 
        "Id": $("#txt_Id").val(),
        "Comment_sub_id": $("#txt_Comment_sub_id").val(),
        "Content": $("#txt_Content").val(),
        "Content_html": $("#txt_Content_html").val(),
        "Content1": $("#txt_Content1").val(),
        "Content2": $("#txt_Content2").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Images": $("#txt_Images").val(),
        "Reply": $("#txt_Reply").val(),
        "Reply1": $("#txt_Reply1").val(),
        "Reply2": $("#txt_Reply2").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Voice": $("#txt_Voice").val(), 
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
    /// <para>评价表</para>
    /// <para>与Xb_teacher_student_comment数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_student_comment : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_teacher_student_comment Factory()
        {
            return new Xb_teacher_student_comment();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Comment_sub_id
        {            
            get { return this.Comment_sub_id; }
            set { this.Comment_sub_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Content_html
        {            
            get { return this.Content_html; }
            set { this.Content_html = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Content1
        {            
            get { return this.Content1; }
            set { this.Content1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Content2
        {            
            get { return this.Content2; }
            set { this.Content2 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Images
        {            
            get { return this.Images; }
            set { this.Images = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Reply
        {            
            get { return this.Reply; }
            set { this.Reply = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Reply1
        {            
            get { return this.Reply1; }
            set { this.Reply1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Reply2
        {            
            get { return this.Reply2; }
            set { this.Reply2 = value; }
        }
        
        /// <summary> 学生证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> 教师身份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Voice
        {            
            get { return this.Voice; }
            set { this.Voice = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Comment_sub_id
        {
            get { return this.m_comment_sub_id; }
            set //
            {
                if (!comment_sub_id_initialized || m_comment_sub_id != value)
                {
                    this.m_comment_sub_id = value;
                }
                comment_sub_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string Content
        {
            get { return this.m_content; }
            set //
            {
                if (!content_initialized || m_content != value)
                {
                    this.m_content = value;
                }
                content_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string Content_html
        {
            get { return this.m_content_html; }
            set //
            {
                if (!content_html_initialized || m_content_html != value)
                {
                    this.m_content_html = value;
                }
                content_html_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Content1
        {
            get { return this.m_content1; }
            set //
            {
                if (!content1_initialized || m_content1 != value)
                {
                    this.m_content1 = value;
                }
                content1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Content2
        {
            get { return this.m_content2; }
            set //
            {
                if (!content2_initialized || m_content2 != value)
                {
                    this.m_content2 = value;
                }
                content2_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Images
        {
            get { return this.m_images; }
            set //
            {
                if (!images_initialized || m_images != value)
                {
                    this.m_images = value;
                }
                images_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Reply
        {
            get { return this.m_reply; }
            set //
            {
                if (!reply_initialized || m_reply != value)
                {
                    this.m_reply = value;
                }
                reply_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Reply1
        {
            get { return this.m_reply1; }
            set //
            {
                if (!reply1_initialized || m_reply1 != value)
                {
                    this.m_reply1 = value;
                }
                reply1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Reply2
        {
            get { return this.m_reply2; }
            set //
            {
                if (!reply2_initialized || m_reply2 != value)
                {
                    this.m_reply2 = value;
                }
                reply2_initialized = true;
            }
        }
        
        /// <summary> 学生证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Student_id
        {
            get { return this.m_student_id; }
            set //
            {
                if (!student_id_initialized || m_student_id != value)
                {
                    this.m_student_id = value;
                }
                student_id_initialized = true;
            }
        }
        
        /// <summary> 教师身份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher_id
        {
            get { return this.m_teacher_id; }
            set //
            {
                if (!teacher_id_initialized || m_teacher_id != value)
                {
                    this.m_teacher_id = value;
                }
                teacher_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Uuid
        {
            get { return this.m_uuid; }
            set //
            {
                if (!uuid_initialized || m_uuid != value)
                {
                    this.m_uuid = value;
                }
                uuid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Voice
        {
            get { return this.m_voice; }
            set //
            {
                if (!voice_initialized || m_voice != value)
                {
                    this.m_voice = value;
                }
                voice_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_student_comment].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Comment_sub_id =  new AttributeItem("[Xb_teacher_student_comment].[Comment_sub_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xb_teacher_student_comment].[Content]", typeof(string), 2000, default(string));
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Content_html =  new AttributeItem("[Xb_teacher_student_comment].[Content_html]", typeof(string), 2000, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Content1 =  new AttributeItem("[Xb_teacher_student_comment].[Content1]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Content2 =  new AttributeItem("[Xb_teacher_student_comment].[Content2]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_teacher_student_comment].[Create_time]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Images =  new AttributeItem("[Xb_teacher_student_comment].[Images]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Reply =  new AttributeItem("[Xb_teacher_student_comment].[Reply]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Reply1 =  new AttributeItem("[Xb_teacher_student_comment].[Reply1]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Reply2 =  new AttributeItem("[Xb_teacher_student_comment].[Reply2]", typeof(string), 500, default(string));
            
            /// <summary>学生证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xb_teacher_student_comment].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>教师身份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xb_teacher_student_comment].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_teacher_student_comment].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Voice =  new AttributeItem("[Xb_teacher_student_comment].[Voice]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_comment_sub_id;
        /// <summary></summary>
        protected bool comment_sub_id_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_content_html;
        /// <summary></summary>
        protected bool content_html_initialized = false;
        
        private string m_content1;
        /// <summary></summary>
        protected bool content1_initialized = false;
        
        private string m_content2;
        /// <summary></summary>
        protected bool content2_initialized = false;
        
        private string m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_images;
        /// <summary></summary>
        protected bool images_initialized = false;
        
        private string m_reply;
        /// <summary></summary>
        protected bool reply_initialized = false;
        
        private string m_reply1;
        /// <summary></summary>
        protected bool reply1_initialized = false;
        
        private string m_reply2;
        /// <summary></summary>
        protected bool reply2_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_voice;
        /// <summary></summary>
        protected bool voice_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacher_student_comment";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.comment_sub_id_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.content_html_initialized = IsLoadAllAttributes;this.content1_initialized = IsLoadAllAttributes;this.content2_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.images_initialized = IsLoadAllAttributes;this.reply_initialized = IsLoadAllAttributes;this.reply1_initialized = IsLoadAllAttributes;this.reply2_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.voice_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_student_comment value = new Xb_teacher_student_comment();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Comment_sub_id"))
				value.comment_sub_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content_html"))
				value.content_html_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content1"))
				value.content1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content2"))
				value.content2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Images"))
				value.images_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Reply"))
				value.reply_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Reply1"))
				value.reply1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Reply2"))
				value.reply2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Voice"))
				value.voice_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_teacher_student_comment Clone()
        {
            return (Xb_teacher_student_comment)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_teacher_student_comment()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_teacher_student_comment() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_teacher_student_comment(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_teacher_student_comment(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_teacher_student_comment(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_teacher_student_comment(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_teacher_student_comment(int id1, int comment_sub_id1, string content1, string content_html1, string content11, string content21, string create_time1, string images1, string reply1, string reply11, string reply21, string student_id1, string teacher_id1, Guid uuid1, string voice1)
        {
            
            this.Id = id1;
            
            this.Comment_sub_id = comment_sub_id1;
            
            this.Content = content1;
            
            this.Content_html = content_html1;
            
            this.Content1 = content11;
            
            this.Content2 = content21;
            
            this.Create_time = create_time1;
            
            this.Images = images1;
            
            this.Reply = reply1;
            
            this.Reply1 = reply11;
            
            this.Reply2 = reply21;
            
            this.Student_id = student_id1;
            
            this.Teacher_id = teacher_id1;
            
            this.Uuid = uuid1;
            
            this.Voice = voice1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_teacher_student_comment FromIView(IView view)
        {
            return (Xb_teacher_student_comment)IView.GetITable(view, "Xb_teacher_student_comment");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_teacher_student_comment GetOneInstance()
        {
            Xb_teacher_student_comment value = new Xb_teacher_student_comment();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_teacher_student_comment Retrieve()
        {
            BLLTable<Xb_teacher_student_comment>.GetRowData(this);
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
			    			
			    case "Comment_sub_id":
			        return Comment_sub_id;
			    			
			    case "Content":
			        return Content;
			    			
			    case "Content_html":
			        return Content_html;
			    			
			    case "Content1":
			        return Content1;
			    			
			    case "Content2":
			        return Content2;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Images":
			        return Images;
			    			
			    case "Reply":
			        return Reply;
			    			
			    case "Reply1":
			        return Reply1;
			    			
			    case "Reply2":
			        return Reply2;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Voice":
			        return Voice;
			
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
			    			
			    case "Comment_sub_id":
			        this.Comment_sub_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content_html":
			        this.Content_html = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content1":
			        this.Content1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content2":
			        this.Content2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Images":
			        this.Images = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Reply":
			        this.Reply = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Reply1":
			        this.Reply1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Reply2":
			        this.Reply2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Voice":
			        this.Voice = Convert.ToString(AttributeValue);
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
				
				case "Comment_sub_id":
					return comment_sub_id_initialized;
				
				case "Content":
					return content_initialized;
				
				case "Content_html":
					return content_html_initialized;
				
				case "Content1":
					return content1_initialized;
				
				case "Content2":
					return content2_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Images":
					return images_initialized;
				
				case "Reply":
					return reply_initialized;
				
				case "Reply1":
					return reply1_initialized;
				
				case "Reply2":
					return reply2_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Voice":
					return voice_initialized;
				
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
				
				case "Comment_sub_id":
					comment_sub_id_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "Content_html":
					content_html_initialized = ret;
					return true;
				
				case "Content1":
					content1_initialized = ret;
					return true;
				
				case "Content2":
					content2_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Images":
					images_initialized = ret;
					return true;
				
				case "Reply":
					reply_initialized = ret;
					return true;
				
				case "Reply1":
					reply1_initialized = ret;
					return true;
				
				case "Reply2":
					reply2_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Voice":
					voice_initialized = ret;
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
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (comment_sub_id_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Comment_sub_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Comment_sub_id);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (content_html_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Content_html;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content_html);
                }
			}
			
			if (content1_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Content1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content1);
                }
			}
			
			if (content2_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Content2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content2);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (images_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Images;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Images);
                }
			}
			
			if (reply_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Reply;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Reply);
                }
			}
			
			if (reply1_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Reply1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Reply1);
                }
			}
			
			if (reply2_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Reply2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Reply2);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (voice_initialized)
			{
                AttributeItem attr = Xb_teacher_student_comment.Attribute.Voice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Voice);
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
        public class Xb_teacher_student_commentJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Comment_sub_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public string Content { get; set; }
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public string Content_html { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Content1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Content2 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Images { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Reply { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Reply1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Reply2 { get; set; }
            
            /// <summary>学生证:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>教师身份:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Voice { get; set; }
        }
        #endregion
    }
}