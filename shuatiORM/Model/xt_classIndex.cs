/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:59
  Description:    数据表Xt_classIndex对应的业务逻辑层Xt_classIndex
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_classIndex_Entity:Xt_classIndex
 * 
************************************************************/
/************************************************************
SQL代码：
select Teacher_name,Name,Active,Major,Course_code,Courser_caption,Courser_content,Category,Weight_config,Uuid,Expr2,Teacher_id from Xt_classIndex
delete from Xt_classIndex
INSERT INTO Xt_classIndex (Teacher_name,Name,Active,Major,Course_code,Courser_caption,Courser_content,Category,Weight_config,Uuid,Expr2,Teacher_id)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xt_classIndex SET ...
变量赋值代码：
 *         valObj.Teacher_name = valObj2.Teacher_name;
        valObj.Name = valObj2.Name;
        valObj.Active = valObj2.Active;
        valObj.Major = valObj2.Major;
        valObj.Course_code = valObj2.Course_code;
        valObj.Courser_caption = valObj2.Courser_caption;
        valObj.Courser_content = valObj2.Courser_content;
        valObj.Category = valObj2.Category;
        valObj.Weight_config = valObj2.Weight_config;
        valObj.Uuid = valObj2.Uuid;
        valObj.Expr2 = valObj2.Expr2;
        valObj.Teacher_id = valObj2.Teacher_id; 
        valObj.Teacher_name = "";
        valObj.Name = "";
        valObj.Active = "";
        valObj.Major = "";
        valObj.Course_code = "";
        valObj.Courser_caption = "";
        valObj.Courser_content = "";
        valObj.Category = "";
        valObj.Weight_config = "";
        valObj.Uuid = "";
        valObj.Expr2 = "";
        valObj.Teacher_id = ""; 
        "Teacher_name": $("#txt_Teacher_name").val(),
        "Name": $("#txt_Name").val(),
        "Active": $("#txt_Active").val(),
        "Major": $("#txt_Major").val(),
        "Course_code": $("#txt_Course_code").val(),
        "Courser_caption": $("#txt_Courser_caption").val(),
        "Courser_content": $("#txt_Courser_content").val(),
        "Category": $("#txt_Category").val(),
        "Weight_config": $("#txt_Weight_config").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Expr2": $("#txt_Expr2").val(),
        "Teacher_id": $("#txt_Teacher_id").val(), 
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
    /// <para>班级表__老师用户信息表:[Inner-{Xt_course:0},{Xt_teacher:1}]</para>
    /// <para>与Xt_classIndex数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_classIndex : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_classIndex Factory()
        {
            return new Xt_classIndex();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Teacher_name
        {            
            get { return this.Teacher_name; }
            set { this.Teacher_name = value; }
        }
        
        /// <summary> 名称 Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 活跃度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Active
        {            
            get { return this.Active; }
            set { this.Active = value; }
        }
        
        /// <summary> 专业,分类 Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
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
        
        /// <summary> 权重配置:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weight_config
        {            
            get { return this.Weight_config; }
            set { this.Weight_config = value; }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Expr2
        {            
            get { return this.Expr2; }
            set { this.Expr2 = value; }
        }
        
        /// <summary> 老师ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Teacher_name
        {
            get { return this.m_teacher_name; }
            set //
            {
                if (!teacher_name_initialized || m_teacher_name != value)
                {
                    this.m_teacher_name = value;
                }
                teacher_name_initialized = true;
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
        
        /// <summary> 活跃度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Active
        {
            get { return this.m_active; }
            set //
            {
                if (!active_initialized || m_active != value)
                {
                    this.m_active = value;
                }
                active_initialized = true;
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
        
        /// <summary> 权重配置:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Weight_config
        {
            get { return this.m_weight_config; }
            set //
            {
                if (!weight_config_initialized || m_weight_config != value)
                {
                    this.m_weight_config = value;
                }
                weight_config_initialized = true;
            }
        }
        
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
        public Guid Expr2
        {
            get { return this.m_expr2; }
            set //
            {
                if (!expr2_initialized || m_expr2 != value)
                {
                    this.m_expr2 = value;
                }
                expr2_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Teacher_name =  new AttributeItem("[Xt_classIndex].[Teacher_name]", typeof(string), 100, default(string));
            
            /// <summary>名称</summary>
            public static AttributeItem Name =  new AttributeItem("[Xt_classIndex].[Name]", typeof(string), 100, default(string));
            
            /// <summary>活跃度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Active =  new AttributeItem("[Xt_classIndex].[Active]", typeof(string), 100, default(string));
            
            /// <summary>专业,分类</summary>
            public static AttributeItem Major =  new AttributeItem("[Xt_classIndex].[Major]", typeof(string), 100, default(string));
            
            /// <summary>课程编码，邀请学生用的</summary>
            public static AttributeItem Course_code =  new AttributeItem("[Xt_classIndex].[Course_code]", typeof(string), 12, default(string));
            
            /// <summary>课程标题</summary>
            public static AttributeItem Courser_caption =  new AttributeItem("[Xt_classIndex].[Courser_caption]", typeof(string), 200, default(string));
            
            /// <summary>课程介绍</summary>
            public static AttributeItem Courser_content =  new AttributeItem("[Xt_classIndex].[Courser_content]", typeof(string), 500, default(string));
            
            /// <summary>课程分类</summary>
            public static AttributeItem Category =  new AttributeItem("[Xt_classIndex].[Category]", typeof(string), 50, default(string));
            
            /// <summary>权重配置:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weight_config =  new AttributeItem("[Xt_classIndex].[Weight_config]", typeof(string), 100, default(string));
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_classIndex].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Expr2 =  new AttributeItem("[Xt_classIndex].[Expr2]", typeof(Guid), 16, default(Guid));
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xt_classIndex].[Teacher_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_teacher_name;
        /// <summary></summary>
        protected bool teacher_name_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_active;
        /// <summary></summary>
        protected bool active_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
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
        
        private string m_weight_config;
        /// <summary></summary>
        protected bool weight_config_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private Guid m_expr2;
        /// <summary></summary>
        protected bool expr2_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_classIndex";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.teacher_name_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.active_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.course_code_initialized = IsLoadAllAttributes;this.courser_caption_initialized = IsLoadAllAttributes;this.courser_content_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;this.weight_config_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.expr2_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_classIndex value = new Xt_classIndex();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_name"))
				value.teacher_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Active"))
				value.active_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_code"))
				value.course_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_caption"))
				value.courser_caption_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_content"))
				value.courser_content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weight_config"))
				value.weight_config_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Expr2"))
				value.expr2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_classIndex Clone()
        {
            return (Xt_classIndex)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_classIndex()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_classIndex() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_classIndex(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_classIndex(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_classIndex(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_classIndex(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_classIndex(string teacher_name1, string name1, string active1, string major1, string course_code1, string courser_caption1, string courser_content1, string category1, string weight_config1, Guid uuid1, Guid expr21, string teacher_id1)
        {
            
            this.Teacher_name = teacher_name1;
            
            this.Name = name1;
            
            this.Active = active1;
            
            this.Major = major1;
            
            this.Course_code = course_code1;
            
            this.Courser_caption = courser_caption1;
            
            this.Courser_content = courser_content1;
            
            this.Category = category1;
            
            this.Weight_config = weight_config1;
            
            this.Uuid = uuid1;
            
            this.Expr2 = expr21;
            
            this.Teacher_id = teacher_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_classIndex FromIView(IView view)
        {
            return (Xt_classIndex)IView.GetITable(view, "Xt_classIndex");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_classIndex GetOneInstance()
        {
            Xt_classIndex value = new Xt_classIndex();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_classIndex Retrieve()
        {
            BLLTable<Xt_classIndex>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Teacher_name":
			        return Teacher_name;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Active":
			        return Active;
			    			
			    case "Major":
			        return Major;
			    			
			    case "Course_code":
			        return Course_code;
			    			
			    case "Courser_caption":
			        return Courser_caption;
			    			
			    case "Courser_content":
			        return Courser_content;
			    			
			    case "Category":
			        return Category;
			    			
			    case "Weight_config":
			        return Weight_config;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Expr2":
			        return Expr2;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Teacher_name":
			        this.Teacher_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Active":
			        this.Active = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
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
			    			
			    case "Weight_config":
			        this.Weight_config = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Expr2":
			        this.Expr2 = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
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
				case "Teacher_name":
					return teacher_name_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Active":
					return active_initialized;
				
				case "Major":
					return major_initialized;
				
				case "Course_code":
					return course_code_initialized;
				
				case "Courser_caption":
					return courser_caption_initialized;
				
				case "Courser_content":
					return courser_content_initialized;
				
				case "Category":
					return category_initialized;
				
				case "Weight_config":
					return weight_config_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Expr2":
					return expr2_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Teacher_name":
					teacher_name_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Active":
					active_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
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
				
				case "Weight_config":
					weight_config_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Expr2":
					expr2_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
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

			
			if (teacher_name_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Teacher_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_name);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (active_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Active;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Active);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (course_code_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Course_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_code);
                }
			}
			
			if (courser_caption_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Courser_caption;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_caption);
                }
			}
			
			if (courser_content_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Courser_content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_content);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
                }
			}
			
			if (weight_config_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Weight_config;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weight_config);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (expr2_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Expr2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Expr2);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xt_classIndex.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
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
        public class Xt_classIndexJson
        {
            
            /// <summary></summary>
            public string Teacher_name { get; set; }
            
            /// <summary>名称</summary>
            public string Name { get; set; }
            
            /// <summary>活跃度:[CtrlTypeDic-{InputString}]</summary>
            public string Active { get; set; }
            
            /// <summary>专业,分类</summary>
            public string Major { get; set; }
            
            /// <summary>课程编码，邀请学生用的</summary>
            public string Course_code { get; set; }
            
            /// <summary>课程标题</summary>
            public string Courser_caption { get; set; }
            
            /// <summary>课程介绍</summary>
            public string Courser_content { get; set; }
            
            /// <summary>课程分类</summary>
            public string Category { get; set; }
            
            /// <summary>权重配置:[CtrlTypeDic-{InputString}]</summary>
            public string Weight_config { get; set; }
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public Guid Expr2 { get; set; }
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
        }
        #endregion
    }
}