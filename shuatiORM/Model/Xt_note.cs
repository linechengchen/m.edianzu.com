/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    数据表Xt_note对应的业务逻辑层Xt_note
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_note_Entity:Xt_note
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Id,Classes_id,User_id,Title,Content,Is_top,Create_time,Modify_time,Course_id,Creator,Is_release from Xt_note
delete from Xt_note
INSERT INTO Xt_note (Uuid,Id,Classes_id,User_id,Title,Content,Is_top,Create_time,Modify_time,Course_id,Creator,Is_release)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xt_note SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Id = valObj2.Id;
        valObj.Classes_id = valObj2.Classes_id;
        valObj.User_id = valObj2.User_id;
        valObj.Title = valObj2.Title;
        valObj.Content = valObj2.Content;
        valObj.Is_top = valObj2.Is_top;
        valObj.Create_time = valObj2.Create_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Course_id = valObj2.Course_id;
        valObj.Creator = valObj2.Creator;
        valObj.Is_release = valObj2.Is_release; 
        valObj.Uuid = "";
        valObj.Id = "";
        valObj.Classes_id = "";
        valObj.User_id = "";
        valObj.Title = "";
        valObj.Content = "";
        valObj.Is_top = "";
        valObj.Create_time = "";
        valObj.Modify_time = "";
        valObj.Course_id = "";
        valObj.Creator = "";
        valObj.Is_release = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Id": $("#txt_Id").val(),
        "Classes_id": $("#txt_Classes_id").val(),
        "User_id": $("#txt_User_id").val(),
        "Title": $("#txt_Title").val(),
        "Content": $("#txt_Content").val(),
        "Is_top": $("#txt_Is_top").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Creator": $("#txt_Creator").val(),
        "Is_release": $("#txt_Is_release").val(), 
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
    /// <para>公告通知</para>
    /// <para>与Xt_note数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_note : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_note Factory()
        {
            return new Xt_note();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 公告ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Classes_id
        {            
            get { return this.Classes_id; }
            set { this.Classes_id = value; }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> 内容:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> 是否置顶(1置顶):[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_top
        {            
            get { return this.Is_top; }
            set { this.Is_top = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 创建者:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Creator
        {            
            get { return this.Creator; }
            set { this.Creator = value; }
        }
        
        /// <summary> 是否发布:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_release
        {            
            get { return this.Is_release; }
            set { this.Is_release = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 公告ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        public int Id
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
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Classes_id
        {
            get { return this.m_classes_id; }
            set //
            {
                if (!classes_id_initialized || m_classes_id != value)
                {
                    this.m_classes_id = value;
                }
                classes_id_initialized = true;
            }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string User_id
        {
            get { return this.m_user_id; }
            set //
            {
                if (!user_id_initialized || m_user_id != value)
                {
                    this.m_user_id = value;
                }
                user_id_initialized = true;
            }
        }
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> 内容:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否置顶(1置顶):[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_top
        {
            get { return this.m_is_top; }
            set //
            {
                if (!is_top_initialized || m_is_top != value)
                {
                    this.m_is_top = value;
                }
                is_top_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
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
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
            }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 创建者:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Creator
        {
            get { return this.m_creator; }
            set //
            {
                if (!creator_initialized || m_creator != value)
                {
                    this.m_creator = value;
                }
                creator_initialized = true;
            }
        }
        
        /// <summary> 是否发布:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_release
        {
            get { return this.m_is_release; }
            set //
            {
                if (!is_release_initialized || m_is_release != value)
                {
                    this.m_is_release = value;
                }
                is_release_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>公告ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_note].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_note].[Id]", typeof(int), 4, default(int));
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Classes_id =  new AttributeItem("[Xt_note].[Classes_id]", typeof(string), 36, default(string));
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_note].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_note].[Title]", typeof(string), 100, default(string));
            
            /// <summary>内容:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xt_note].[Content]", typeof(string), -1, default(string));
            
            /// <summary>是否置顶(1置顶):[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_top =  new AttributeItem("[Xt_note].[Is_top]", typeof(string), 1, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_note].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_note].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_note].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>创建者:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Creator =  new AttributeItem("[Xt_note].[Creator]", typeof(string), 36, default(string));
            
            /// <summary>是否发布:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_release =  new AttributeItem("[Xt_note].[Is_release]", typeof(string), 1, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_classes_id;
        /// <summary></summary>
        protected bool classes_id_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_is_top;
        /// <summary></summary>
        protected bool is_top_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_creator;
        /// <summary></summary>
        protected bool creator_initialized = false;
        
        private string m_is_release;
        /// <summary></summary>
        protected bool is_release_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_note";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.classes_id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.is_top_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.creator_initialized = IsLoadAllAttributes;this.is_release_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_note value = new Xt_note();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Classes_id"))
				value.classes_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_top"))
				value.is_top_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creator"))
				value.creator_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_release"))
				value.is_release_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_note Clone()
        {
            return (Xt_note)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_note()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_note() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_note(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_note(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_note(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_note(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_note(Guid uuid1, int id1, string classes_id1, string user_id1, string title1, string content1, string is_top1, DateTime create_time1, DateTime modify_time1, string course_id1, string creator1, string is_release1)
        {
            
            this.Uuid = uuid1;
            
            this.Id = id1;
            
            this.Classes_id = classes_id1;
            
            this.User_id = user_id1;
            
            this.Title = title1;
            
            this.Content = content1;
            
            this.Is_top = is_top1;
            
            this.Create_time = create_time1;
            
            this.Modify_time = modify_time1;
            
            this.Course_id = course_id1;
            
            this.Creator = creator1;
            
            this.Is_release = is_release1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_note FromIView(IView view)
        {
            return (Xt_note)IView.GetITable(view, "Xt_note");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_note GetOneInstance()
        {
            Xt_note value = new Xt_note();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_note Retrieve()
        {
            BLLTable<Xt_note>.GetRowData(this);
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
			    			
			    case "Id":
			        return Id;
			    			
			    case "Classes_id":
			        return Classes_id;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Content":
			        return Content;
			    			
			    case "Is_top":
			        return Is_top;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Creator":
			        return Creator;
			    			
			    case "Is_release":
			        return Is_release;
			
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
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Classes_id":
			        this.Classes_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_top":
			        this.Is_top = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creator":
			        this.Creator = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_release":
			        this.Is_release = Convert.ToString(AttributeValue);
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
				
				case "Id":
					return id_initialized;
				
				case "Classes_id":
					return classes_id_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Content":
					return content_initialized;
				
				case "Is_top":
					return is_top_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Creator":
					return creator_initialized;
				
				case "Is_release":
					return is_release_initialized;
				
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
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Classes_id":
					classes_id_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "Is_top":
					is_top_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Creator":
					creator_initialized = ret;
					return true;
				
				case "Is_release":
					is_release_initialized = ret;
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
                AttributeItem attr = Xt_note.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (classes_id_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Classes_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Classes_id);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (is_top_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Is_top;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_top);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (creator_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Creator;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creator);
                }
			}
			
			if (is_release_initialized)
			{
                AttributeItem attr = Xt_note.Attribute.Is_release;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_release);
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
        public class Xt_noteJson
        {
            
            /// <summary>公告ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public string Classes_id { get; set; }
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>内容:[CtrlTypeDic-{InputString}]</summary>
            public string Content { get; set; }
            
            /// <summary>是否置顶(1置顶):[CtrlTypeDic-{InputString}]</summary>
            public string Is_top { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>创建者:[CtrlTypeDic-{InputString}]</summary>
            public string Creator { get; set; }
            
            /// <summary>是否发布:[CtrlTypeDic-{InputString}]</summary>
            public string Is_release { get; set; }
        }
        #endregion
    }
}