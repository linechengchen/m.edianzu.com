/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    数据表Xt_notice对应的业务逻辑层Xt_notice
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_notice_Entity:Xt_notice
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Title,Context,From_user,To_user,Type,Type_name,Notice_ref_id,Create_time,Course_id,Status,Is_deal,Modify_time from Xt_notice
delete from Xt_notice
INSERT INTO Xt_notice (Uuid,Title,Context,From_user,To_user,Type,Type_name,Notice_ref_id,Create_time,Course_id,Status,Is_deal,Modify_time)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xt_notice SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Title = valObj2.Title;
        valObj.Context = valObj2.Context;
        valObj.From_user = valObj2.From_user;
        valObj.To_user = valObj2.To_user;
        valObj.Type = valObj2.Type;
        valObj.Type_name = valObj2.Type_name;
        valObj.Notice_ref_id = valObj2.Notice_ref_id;
        valObj.Create_time = valObj2.Create_time;
        valObj.Course_id = valObj2.Course_id;
        valObj.Status = valObj2.Status;
        valObj.Is_deal = valObj2.Is_deal;
        valObj.Modify_time = valObj2.Modify_time; 
        valObj.Uuid = "";
        valObj.Title = "";
        valObj.Context = "";
        valObj.From_user = "";
        valObj.To_user = "";
        valObj.Type = "";
        valObj.Type_name = "";
        valObj.Notice_ref_id = "";
        valObj.Create_time = "";
        valObj.Course_id = "";
        valObj.Status = "";
        valObj.Is_deal = "";
        valObj.Modify_time = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Title": $("#txt_Title").val(),
        "Context": $("#txt_Context").val(),
        "From_user": $("#txt_From_user").val(),
        "To_user": $("#txt_To_user").val(),
        "Type": $("#txt_Type").val(),
        "Type_name": $("#txt_Type_name").val(),
        "Notice_ref_id": $("#txt_Notice_ref_id").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Status": $("#txt_Status").val(),
        "Is_deal": $("#txt_Is_deal").val(),
        "Modify_time": $("#txt_Modify_time").val(), 
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
    /// <para>消息</para>
    /// <para>与Xt_notice数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_notice : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_notice Factory()
        {
            return new Xt_notice();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 主题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> 内容:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Context
        {            
            get { return this.Context; }
            set { this.Context = value; }
        }
        
        /// <summary> 来自哪个用户:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _From_user
        {            
            get { return this.From_user; }
            set { this.From_user = value; }
        }
        
        /// <summary> 到哪个用户:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _To_user
        {            
            get { return this.To_user; }
            set { this.To_user = value; }
        }
        
        /// <summary> 类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> 类型名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type_name
        {            
            get { return this.Type_name; }
            set { this.Type_name = value; }
        }
        
        /// <summary> 通知关联ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Notice_ref_id
        {            
            get { return this.Notice_ref_id; }
            set { this.Notice_ref_id = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 状态名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> 是否处理:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_deal
        {            
            get { return this.Is_deal; }
            set { this.Is_deal = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        
        /// <summary> 主题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 内容:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Context
        {
            get { return this.m_context; }
            set //
            {
                if (!context_initialized || m_context != value)
                {
                    this.m_context = value;
                }
                context_initialized = true;
            }
        }
        
        /// <summary> 来自哪个用户:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string From_user
        {
            get { return this.m_from_user; }
            set //
            {
                if (!from_user_initialized || m_from_user != value)
                {
                    this.m_from_user = value;
                }
                from_user_initialized = true;
            }
        }
        
        /// <summary> 到哪个用户:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string To_user
        {
            get { return this.m_to_user; }
            set //
            {
                if (!to_user_initialized || m_to_user != value)
                {
                    this.m_to_user = value;
                }
                to_user_initialized = true;
            }
        }
        
        /// <summary> 类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }
        
        /// <summary> 类型名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Type_name
        {
            get { return this.m_type_name; }
            set //
            {
                if (!type_name_initialized || m_type_name != value)
                {
                    this.m_type_name = value;
                }
                type_name_initialized = true;
            }
        }
        
        /// <summary> 通知关联ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Notice_ref_id
        {
            get { return this.m_notice_ref_id; }
            set //
            {
                if (!notice_ref_id_initialized || m_notice_ref_id != value)
                {
                    this.m_notice_ref_id = value;
                }
                notice_ref_id_initialized = true;
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
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 状态名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Status
        {
            get { return this.m_status; }
            set //
            {
                if (!status_initialized || m_status != value)
                {
                    this.m_status = value;
                }
                status_initialized = true;
            }
        }
        
        /// <summary> 是否处理:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_deal
        {
            get { return this.m_is_deal; }
            set //
            {
                if (!is_deal_initialized || m_is_deal != value)
                {
                    this.m_is_deal = value;
                }
                is_deal_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_notice].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>主题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_notice].[Title]", typeof(string), 100, default(string));
            
            /// <summary>内容:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Context =  new AttributeItem("[Xt_notice].[Context]", typeof(string), 500, default(string));
            
            /// <summary>来自哪个用户:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem From_user =  new AttributeItem("[Xt_notice].[From_user]", typeof(string), 36, default(string));
            
            /// <summary>到哪个用户:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem To_user =  new AttributeItem("[Xt_notice].[To_user]", typeof(string), 36, default(string));
            
            /// <summary>类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xt_notice].[Type]", typeof(string), 1, default(string));
            
            /// <summary>类型名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type_name =  new AttributeItem("[Xt_notice].[Type_name]", typeof(string), 20, default(string));
            
            /// <summary>通知关联ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Notice_ref_id =  new AttributeItem("[Xt_notice].[Notice_ref_id]", typeof(string), 36, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_notice].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_notice].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>状态名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xt_notice].[Status]", typeof(string), 20, default(string));
            
            /// <summary>是否处理:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_deal =  new AttributeItem("[Xt_notice].[Is_deal]", typeof(string), 1, default(string));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_notice].[Modify_time]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_context;
        /// <summary></summary>
        protected bool context_initialized = false;
        
        private string m_from_user;
        /// <summary></summary>
        protected bool from_user_initialized = false;
        
        private string m_to_user;
        /// <summary></summary>
        protected bool to_user_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private string m_type_name;
        /// <summary></summary>
        protected bool type_name_initialized = false;
        
        private string m_notice_ref_id;
        /// <summary></summary>
        protected bool notice_ref_id_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_is_deal;
        /// <summary></summary>
        protected bool is_deal_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_notice";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.context_initialized = IsLoadAllAttributes;this.from_user_initialized = IsLoadAllAttributes;this.to_user_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.type_name_initialized = IsLoadAllAttributes;this.notice_ref_id_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.is_deal_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_notice value = new Xt_notice();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Context"))
				value.context_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"From_user"))
				value.from_user_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"To_user"))
				value.to_user_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type_name"))
				value.type_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notice_ref_id"))
				value.notice_ref_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_deal"))
				value.is_deal_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_notice Clone()
        {
            return (Xt_notice)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_notice()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_notice() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_notice(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_notice(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_notice(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_notice(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_notice(Guid uuid1, string title1, string context1, string from_user1, string to_user1, string type1, string type_name1, string notice_ref_id1, DateTime create_time1, string course_id1, string status1, string is_deal1, DateTime modify_time1)
        {
            
            this.Uuid = uuid1;
            
            this.Title = title1;
            
            this.Context = context1;
            
            this.From_user = from_user1;
            
            this.To_user = to_user1;
            
            this.Type = type1;
            
            this.Type_name = type_name1;
            
            this.Notice_ref_id = notice_ref_id1;
            
            this.Create_time = create_time1;
            
            this.Course_id = course_id1;
            
            this.Status = status1;
            
            this.Is_deal = is_deal1;
            
            this.Modify_time = modify_time1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_notice FromIView(IView view)
        {
            return (Xt_notice)IView.GetITable(view, "Xt_notice");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_notice GetOneInstance()
        {
            Xt_notice value = new Xt_notice();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_notice Retrieve()
        {
            BLLTable<Xt_notice>.GetRowData(this);
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
			    			
			    case "Title":
			        return Title;
			    			
			    case "Context":
			        return Context;
			    			
			    case "From_user":
			        return From_user;
			    			
			    case "To_user":
			        return To_user;
			    			
			    case "Type":
			        return Type;
			    			
			    case "Type_name":
			        return Type_name;
			    			
			    case "Notice_ref_id":
			        return Notice_ref_id;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Is_deal":
			        return Is_deal;
			    			
			    case "Modify_time":
			        return Modify_time;
			
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
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Context":
			        this.Context = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "From_user":
			        this.From_user = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "To_user":
			        this.To_user = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type_name":
			        this.Type_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Notice_ref_id":
			        this.Notice_ref_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_deal":
			        this.Is_deal = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
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
				
				case "Title":
					return title_initialized;
				
				case "Context":
					return context_initialized;
				
				case "From_user":
					return from_user_initialized;
				
				case "To_user":
					return to_user_initialized;
				
				case "Type":
					return type_initialized;
				
				case "Type_name":
					return type_name_initialized;
				
				case "Notice_ref_id":
					return notice_ref_id_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Is_deal":
					return is_deal_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
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
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Context":
					context_initialized = ret;
					return true;
				
				case "From_user":
					from_user_initialized = ret;
					return true;
				
				case "To_user":
					to_user_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "Type_name":
					type_name_initialized = ret;
					return true;
				
				case "Notice_ref_id":
					notice_ref_id_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Is_deal":
					is_deal_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
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
                AttributeItem attr = Xt_notice.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (context_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Context;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Context);
                }
			}
			
			if (from_user_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.From_user;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(From_user);
                }
			}
			
			if (to_user_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.To_user;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(To_user);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (type_name_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Type_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type_name);
                }
			}
			
			if (notice_ref_id_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Notice_ref_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notice_ref_id);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (is_deal_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Is_deal;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_deal);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
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
        public class Xt_noticeJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>主题:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>内容:[CtrlTypeDic-{Text}]</summary>
            public string Context { get; set; }
            
            /// <summary>来自哪个用户:[CtrlTypeDic-{InputString}]</summary>
            public string From_user { get; set; }
            
            /// <summary>到哪个用户:[CtrlTypeDic-{InputString}]</summary>
            public string To_user { get; set; }
            
            /// <summary>类型:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>类型名称:[CtrlTypeDic-{InputString}]</summary>
            public string Type_name { get; set; }
            
            /// <summary>通知关联ID:[CtrlTypeDic-{InputString}]</summary>
            public string Notice_ref_id { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>状态名称:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>是否处理:[CtrlTypeDic-{InputString}]</summary>
            public string Is_deal { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
        }
        #endregion
    }
}