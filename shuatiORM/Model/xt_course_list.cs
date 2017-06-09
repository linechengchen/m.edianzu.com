/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:55:00
  Description:    数据表Xt_course_list对应的业务逻辑层Xt_course_list
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_course_list_Entity:Xt_course_list
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Expr1,Name,Major,Is_delete,Teacher_id,Course_code,Courser_caption,Courser_content,Category,Id,Course_id,Student_id from Xt_course_list
delete from Xt_course_list
INSERT INTO Xt_course_list (Uuid,Expr1,Name,Major,Is_delete,Teacher_id,Course_code,Courser_caption,Courser_content,Category,Id,Course_id,Student_id)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xt_course_list SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Expr1 = valObj2.Expr1;
        valObj.Name = valObj2.Name;
        valObj.Major = valObj2.Major;
        valObj.Is_delete = valObj2.Is_delete;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Course_code = valObj2.Course_code;
        valObj.Courser_caption = valObj2.Courser_caption;
        valObj.Courser_content = valObj2.Courser_content;
        valObj.Category = valObj2.Category;
        valObj.Id = valObj2.Id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Student_id = valObj2.Student_id; 
        valObj.Uuid = "";
        valObj.Expr1 = "";
        valObj.Name = "";
        valObj.Major = "";
        valObj.Is_delete = "";
        valObj.Teacher_id = "";
        valObj.Course_code = "";
        valObj.Courser_caption = "";
        valObj.Courser_content = "";
        valObj.Category = "";
        valObj.Id = "";
        valObj.Course_id = "";
        valObj.Student_id = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Expr1": $("#txt_Expr1").val(),
        "Name": $("#txt_Name").val(),
        "Major": $("#txt_Major").val(),
        "Is_delete": $("#txt_Is_delete").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Course_code": $("#txt_Course_code").val(),
        "Courser_caption": $("#txt_Courser_caption").val(),
        "Courser_content": $("#txt_Courser_content").val(),
        "Category": $("#txt_Category").val(),
        "Id": $("#txt_Id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Student_id": $("#txt_Student_id").val(), 
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
    /// <para>班级表__学生课程关系表__老师用户信息表:[Inner-{Xt_course:0},{Xt_student_course:1},{Xt_teacher:2}]</para>
    /// <para>与Xt_course_list数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_list : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_course_list Factory()
        {
            return new Xt_course_list();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Expr1
        {            
            get { return this.Expr1; }
            set { this.Expr1 = value; }
        }
        
        /// <summary> 名称 Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 专业,分类 Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
        }
        
        /// <summary> 是否删除 Attribute_IsNotNull </summary>
        public string _Is_delete
        {            
            get { return this.Is_delete; }
            set { this.Is_delete = value; }
        }
        
        /// <summary> 老师ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> 课程编码，邀请学生用的 Attribute_IsNotNull </summary>
        public string _Course_code
        {            
            get { return this.Course_code; }
            set { this.Course_code = value; }
        }
        
        /// <summary> 课程标题 Attribute_IsNotNull </summary>
        public string _Courser_caption
        {            
            get { return this.Courser_caption; }
            set { this.Courser_caption = value; }
        }
        
        /// <summary> 课程介绍 Attribute_IsNotNull </summary>
        public string _Courser_content
        {            
            get { return this.Courser_content; }
            set { this.Courser_content = value; }
        }
        
        /// <summary> 课程分类 Attribute_IsNotNull </summary>
        public string _Category
        {            
            get { return this.Category; }
            set { this.Category = value; }
        }
        
        /// <summary> Id Attribute_IsNotNull </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 课程id Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 学生id Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid Expr1
        {
            get { return this.m_expr1; }
            set //
            {
                if (!expr1_initialized || m_expr1 != value)
                {
                    this.m_expr1 = value;
                }
                expr1_initialized = true;
            }
        }
        
        /// <summary> 名称，推荐使用 "_"符号开头 </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> 专业,分类，推荐使用 "_"符号开头 </summary>
        public string Major
        {
            get { return this.m_major; }
            set //
            {
                if (!major_initialized || m_major != value)
                {
                    this.m_major = value;
                }
                major_initialized = true;
            }
        }
        
        /// <summary> 是否删除，推荐使用 "_"符号开头 </summary>
        public string Is_delete
        {
            get { return this.m_is_delete; }
            set //
            {
                if (!is_delete_initialized || m_is_delete != value)
                {
                    this.m_is_delete = value;
                }
                is_delete_initialized = true;
            }
        }
        
        /// <summary> 老师ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 课程编码，邀请学生用的，推荐使用 "_"符号开头 </summary>
        public string Course_code
        {
            get { return this.m_course_code; }
            set //
            {
                if (!course_code_initialized || m_course_code != value)
                {
                    this.m_course_code = value;
                }
                course_code_initialized = true;
            }
        }
        
        /// <summary> 课程标题，推荐使用 "_"符号开头 </summary>
        public string Courser_caption
        {
            get { return this.m_courser_caption; }
            set //
            {
                if (!courser_caption_initialized || m_courser_caption != value)
                {
                    this.m_courser_caption = value;
                }
                courser_caption_initialized = true;
            }
        }
        
        /// <summary> 课程介绍，推荐使用 "_"符号开头 </summary>
        public string Courser_content
        {
            get { return this.m_courser_content; }
            set //
            {
                if (!courser_content_initialized || m_courser_content != value)
                {
                    this.m_courser_content = value;
                }
                courser_content_initialized = true;
            }
        }
        
        /// <summary> 课程分类，推荐使用 "_"符号开头 </summary>
        public string Category
        {
            get { return this.m_category; }
            set //
            {
                if (!category_initialized || m_category != value)
                {
                    this.m_category = value;
                }
                category_initialized = true;
            }
        }
        
        /// <summary> Id，推荐使用 "_"符号开头 </summary>
        public Guid Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 课程id，推荐使用 "_"符号开头 </summary>
        public string Course_id
        {
            get { return this.m_course_id; }
            set //
            {
                if (!course_id_initialized || m_course_id != value)
                {
                    this.m_course_id = value;
                }
                course_id_initialized = true;
            }
        }
        
        /// <summary> 学生id，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_course_list].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Expr1 =  new AttributeItem("[Xt_course_list].[Expr1]", typeof(Guid), 16, default(Guid));
            
            /// <summary>名称</summary>
            public static AttributeItem Name =  new AttributeItem("[Xt_course_list].[Name]", typeof(string), 100, default(string));
            
            /// <summary>专业,分类</summary>
            public static AttributeItem Major =  new AttributeItem("[Xt_course_list].[Major]", typeof(string), 100, default(string));
            
            /// <summary>是否删除</summary>
            public static AttributeItem Is_delete =  new AttributeItem("[Xt_course_list].[Is_delete]", typeof(string), 1, default(string));
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xt_course_list].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>课程编码，邀请学生用的</summary>
            public static AttributeItem Course_code =  new AttributeItem("[Xt_course_list].[Course_code]", typeof(string), 12, default(string));
            
            /// <summary>课程标题</summary>
            public static AttributeItem Courser_caption =  new AttributeItem("[Xt_course_list].[Courser_caption]", typeof(string), 200, default(string));
            
            /// <summary>课程介绍</summary>
            public static AttributeItem Courser_content =  new AttributeItem("[Xt_course_list].[Courser_content]", typeof(string), 500, default(string));
            
            /// <summary>课程分类</summary>
            public static AttributeItem Category =  new AttributeItem("[Xt_course_list].[Category]", typeof(string), 50, default(string));
            
            /// <summary>Id</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_course_list].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>课程id</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_list].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>学生id</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_course_list].[Student_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private Guid m_expr1;
        /// <summary></summary>
        protected bool expr1_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
        private string m_is_delete;
        /// <summary></summary>
        protected bool is_delete_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private string m_course_code;
        /// <summary></summary>
        protected bool course_code_initialized = false;
        
        private string m_courser_caption;
        /// <summary></summary>
        protected bool courser_caption_initialized = false;
        
        private string m_courser_content;
        /// <summary></summary>
        protected bool courser_content_initialized = false;
        
        private string m_category;
        /// <summary></summary>
        protected bool category_initialized = false;
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_list";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.expr1_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.is_delete_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.course_code_initialized = IsLoadAllAttributes;this.courser_caption_initialized = IsLoadAllAttributes;this.courser_content_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_list value = new Xt_course_list();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Expr1"))
				value.expr1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_delete"))
				value.is_delete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_code"))
				value.course_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_caption"))
				value.courser_caption_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_content"))
				value.courser_content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_course_list Clone()
        {
            return (Xt_course_list)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_course_list()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_course_list() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_course_list(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_course_list(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_course_list(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_course_list(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_course_list(Guid uuid1, Guid expr11, string name1, string major1, string is_delete1, string teacher_id1, string course_code1, string courser_caption1, string courser_content1, string category1, Guid id1, string course_id1, string student_id1)
        {
            
            this.Uuid = uuid1;
            
            this.Expr1 = expr11;
            
            this.Name = name1;
            
            this.Major = major1;
            
            this.Is_delete = is_delete1;
            
            this.Teacher_id = teacher_id1;
            
            this.Course_code = course_code1;
            
            this.Courser_caption = courser_caption1;
            
            this.Courser_content = courser_content1;
            
            this.Category = category1;
            
            this.Id = id1;
            
            this.Course_id = course_id1;
            
            this.Student_id = student_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_course_list FromIView(IView view)
        {
            return (Xt_course_list)IView.GetITable(view, "Xt_course_list");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_course_list GetOneInstance()
        {
            Xt_course_list value = new Xt_course_list();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_course_list Retrieve()
        {
            BLLTable<Xt_course_list>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Expr1":
			        return Expr1;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Major":
			        return Major;
			    			
			    case "Is_delete":
			        return Is_delete;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Course_code":
			        return Course_code;
			    			
			    case "Courser_caption":
			        return Courser_caption;
			    			
			    case "Courser_content":
			        return Courser_content;
			    			
			    case "Category":
			        return Category;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Student_id":
			        return Student_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Expr1":
			        this.Expr1 = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_delete":
			        this.Is_delete = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_code":
			        this.Course_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Courser_caption":
			        this.Courser_caption = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Courser_content":
			        this.Courser_content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category":
			        this.Category = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
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
				case "Uuid":
					return uuid_initialized;
				
				case "Expr1":
					return expr1_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Major":
					return major_initialized;
				
				case "Is_delete":
					return is_delete_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Course_code":
					return course_code_initialized;
				
				case "Courser_caption":
					return courser_caption_initialized;
				
				case "Courser_content":
					return courser_content_initialized;
				
				case "Category":
					return category_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Expr1":
					expr1_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
					return true;
				
				case "Is_delete":
					is_delete_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Course_code":
					course_code_initialized = ret;
					return true;
				
				case "Courser_caption":
					courser_caption_initialized = ret;
					return true;
				
				case "Courser_content":
					courser_content_initialized = ret;
					return true;
				
				case "Category":
					category_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (expr1_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Expr1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Expr1);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (is_delete_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Is_delete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_delete);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (course_code_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Course_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_code);
                }
			}
			
			if (courser_caption_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Courser_caption;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_caption);
                }
			}
			
			if (courser_content_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Courser_content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_content);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_course_list.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
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
        public class Xt_course_listJson
        {
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public Guid Expr1 { get; set; }
            
            /// <summary>名称</summary>
            public string Name { get; set; }
            
            /// <summary>专业,分类</summary>
            public string Major { get; set; }
            
            /// <summary>是否删除</summary>
            public string Is_delete { get; set; }
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>课程编码，邀请学生用的</summary>
            public string Course_code { get; set; }
            
            /// <summary>课程标题</summary>
            public string Courser_caption { get; set; }
            
            /// <summary>课程介绍</summary>
            public string Courser_content { get; set; }
            
            /// <summary>课程分类</summary>
            public string Category { get; set; }
            
            /// <summary>Id</summary>
            public Guid Id { get; set; }
            
            /// <summary>课程id</summary>
            public string Course_id { get; set; }
            
            /// <summary>学生id</summary>
            public string Student_id { get; set; }
        }
        #endregion
    }
}