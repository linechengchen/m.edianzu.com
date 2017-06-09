/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    数据表Jz_userEducation对应的业务逻辑层Jz_userEducation
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_userEducation_Entity:Jz_userEducation
 * 
************************************************************/
/************************************************************
SQL代码：
select UserEducationId,CreateTime,School_id,School_name,SchoolType,TownId,TownName,User_id,Major,StartYear,EducationType from Jz_userEducation
delete from Jz_userEducation
INSERT INTO Jz_userEducation (UserEducationId,CreateTime,School_id,School_name,SchoolType,TownId,TownName,User_id,Major,StartYear,EducationType)
     VALUES
           ('','','','','','','','','','','')
UPDATE Jz_userEducation SET ...
变量赋值代码：
 *         valObj.UserEducationId = valObj2.UserEducationId;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.School_id = valObj2.School_id;
        valObj.School_name = valObj2.School_name;
        valObj.SchoolType = valObj2.SchoolType;
        valObj.TownId = valObj2.TownId;
        valObj.TownName = valObj2.TownName;
        valObj.User_id = valObj2.User_id;
        valObj.Major = valObj2.Major;
        valObj.StartYear = valObj2.StartYear;
        valObj.EducationType = valObj2.EducationType; 
        valObj.UserEducationId = "";
        valObj.CreateTime = "";
        valObj.School_id = "";
        valObj.School_name = "";
        valObj.SchoolType = "";
        valObj.TownId = "";
        valObj.TownName = "";
        valObj.User_id = "";
        valObj.Major = "";
        valObj.StartYear = "";
        valObj.EducationType = ""; 
        "UserEducationId": $("#txt_UserEducationId").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "School_id": $("#txt_School_id").val(),
        "School_name": $("#txt_School_name").val(),
        "SchoolType": $("#txt_SchoolType").val(),
        "TownId": $("#txt_TownId").val(),
        "TownName": $("#txt_TownName").val(),
        "User_id": $("#txt_User_id").val(),
        "Major": $("#txt_Major").val(),
        "StartYear": $("#txt_StartYear").val(),
        "EducationType": $("#txt_EducationType").val(), 
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
    /// <para>用户教育</para>
    /// <para>与Jz_userEducation数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_userEducation : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_userEducation Factory()
        {
            return new Jz_userEducation();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 教育用户ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _UserEducationId
        {            
            get { return this.UserEducationId; }
            set { this.UserEducationId = value; }
        }
        
        /// <summary> 创造时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 学校身份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary> 学校名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _School_name
        {            
            get { return this.School_name; }
            set { this.School_name = value; }
        }
        
        /// <summary> 学校类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SchoolType
        {            
            get { return this.SchoolType; }
            set { this.SchoolType = value; }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TownId
        {            
            get { return this.TownId; }
            set { this.TownId = value; }
        }
        
        /// <summary> 小镇的名字:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TownName
        {            
            get { return this.TownName; }
            set { this.TownName = value; }
        }
        
        /// <summary> 用户ID:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 专业:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
        }
        
        /// <summary> 年份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _StartYear
        {            
            get { return this.StartYear; }
            set { this.StartYear = value; }
        }
        
        /// <summary> 学历:[Enum-{COLLEGE:大专},{UNDERGRADUATE:本科},{MASTER_DEGREE:硕士},{DOCTOR:博士}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _EducationType
        {            
            get { return this.EducationType; }
            set { this.EducationType = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 教育用户ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int UserEducationId
        {
            get { return this.m_usereducationid; }
            set //private 
            {
                if (!usereducationid_initialized || m_usereducationid != value)
                {
                    this.m_usereducationid = value;
                }
                usereducationid_initialized = true;
            }
        }
        
        /// <summary> 创造时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 学校身份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
            }
        }
        
        /// <summary> 学校名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string School_name
        {
            get { return this.m_school_name; }
            set //
            {
                if (!school_name_initialized || m_school_name != value)
                {
                    this.m_school_name = value;
                }
                school_name_initialized = true;
            }
        }
        
        /// <summary> 学校类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SchoolType
        {
            get { return this.m_schooltype; }
            set //
            {
                if (!schooltype_initialized || m_schooltype != value)
                {
                    this.m_schooltype = value;
                }
                schooltype_initialized = true;
            }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TownId
        {
            get { return this.m_townid; }
            set //
            {
                if (!townid_initialized || m_townid != value)
                {
                    this.m_townid = value;
                }
                townid_initialized = true;
            }
        }
        
        /// <summary> 小镇的名字:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TownName
        {
            get { return this.m_townname; }
            set //
            {
                if (!townname_initialized || m_townname != value)
                {
                    this.m_townname = value;
                }
                townname_initialized = true;
            }
        }
        
        /// <summary> 用户ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid User_id
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
        
        /// <summary> 专业:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 年份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int StartYear
        {
            get { return this.m_startyear; }
            set //
            {
                if (!startyear_initialized || m_startyear != value)
                {
                    this.m_startyear = value;
                }
                startyear_initialized = true;
            }
        }
        
        /// <summary> 学历:[Enum-{COLLEGE:大专},{UNDERGRADUATE:本科},{MASTER_DEGREE:硕士},{DOCTOR:博士}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string EducationType
        {
            get { return this.m_educationtype; }
            set //
            {
                if (!educationtype_initialized || m_educationtype != value)
                {
                    this.m_educationtype = value;
                }
                educationtype_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>教育用户ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserEducationId =  new AttributeItem("[Jz_userEducation].[UserEducationId]", typeof(int), 4, default(int));
            
            /// <summary>创造时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_userEducation].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>学校身份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[Jz_userEducation].[School_id]", typeof(int), 4, default(int));
            
            /// <summary>学校名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_name =  new AttributeItem("[Jz_userEducation].[School_name]", typeof(string), 50, default(string));
            
            /// <summary>学校类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SchoolType =  new AttributeItem("[Jz_userEducation].[SchoolType]", typeof(string), 50, default(string));
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownId =  new AttributeItem("[Jz_userEducation].[TownId]", typeof(int), 4, default(int));
            
            /// <summary>小镇的名字:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownName =  new AttributeItem("[Jz_userEducation].[TownName]", typeof(string), 50, default(string));
            
            /// <summary>用户ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_userEducation].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>专业:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Major =  new AttributeItem("[Jz_userEducation].[Major]", typeof(string), 50, default(string));
            
            /// <summary>年份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StartYear =  new AttributeItem("[Jz_userEducation].[StartYear]", typeof(int), 4, default(int));
            
            /// <summary>学历:[Enum-{COLLEGE:大专},{UNDERGRADUATE:本科},{MASTER_DEGREE:硕士},{DOCTOR:博士}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EducationType =  new AttributeItem("[Jz_userEducation].[EducationType]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_usereducationid;
        /// <summary></summary>
        protected bool usereducationid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private string m_school_name;
        /// <summary></summary>
        protected bool school_name_initialized = false;
        
        private string m_schooltype;
        /// <summary></summary>
        protected bool schooltype_initialized = false;
        
        private int m_townid;
        /// <summary></summary>
        protected bool townid_initialized = false;
        
        private string m_townname;
        /// <summary></summary>
        protected bool townname_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
        private int m_startyear;
        /// <summary></summary>
        protected bool startyear_initialized = false;
        
        private string m_educationtype;
        /// <summary></summary>
        protected bool educationtype_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_userEducation";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.usereducationid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.school_name_initialized = IsLoadAllAttributes;this.schooltype_initialized = IsLoadAllAttributes;this.townid_initialized = IsLoadAllAttributes;this.townname_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.startyear_initialized = IsLoadAllAttributes;this.educationtype_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_userEducation value = new Jz_userEducation();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserEducationId"))
				value.usereducationid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_name"))
				value.school_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SchoolType"))
				value.schooltype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownId"))
				value.townid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownName"))
				value.townname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StartYear"))
				value.startyear_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EducationType"))
				value.educationtype_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_userEducation Clone()
        {
            return (Jz_userEducation)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_userEducation()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_userEducation() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_userEducation(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_userEducation(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_userEducation(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_userEducation(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_userEducation(int usereducationid1, DateTime createtime1, int school_id1, string school_name1, string schooltype1, int townid1, string townname1, Guid user_id1, string major1, int startyear1, string educationtype1)
        {
            
            this.UserEducationId = usereducationid1;
            
            this.CreateTime = createtime1;
            
            this.School_id = school_id1;
            
            this.School_name = school_name1;
            
            this.SchoolType = schooltype1;
            
            this.TownId = townid1;
            
            this.TownName = townname1;
            
            this.User_id = user_id1;
            
            this.Major = major1;
            
            this.StartYear = startyear1;
            
            this.EducationType = educationtype1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_userEducation FromIView(IView view)
        {
            return (Jz_userEducation)IView.GetITable(view, "Jz_userEducation");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_userEducation GetOneInstance()
        {
            Jz_userEducation value = new Jz_userEducation();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_userEducation Retrieve()
        {
            BLLTable<Jz_userEducation>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "UserEducationId":
			        return UserEducationId;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "School_name":
			        return School_name;
			    			
			    case "SchoolType":
			        return SchoolType;
			    			
			    case "TownId":
			        return TownId;
			    			
			    case "TownName":
			        return TownName;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Major":
			        return Major;
			    			
			    case "StartYear":
			        return StartYear;
			    			
			    case "EducationType":
			        return EducationType;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "UserEducationId":
			        this.UserEducationId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "School_name":
			        this.School_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SchoolType":
			        this.SchoolType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TownId":
			        this.TownId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TownName":
			        this.TownName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StartYear":
			        this.StartYear = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "EducationType":
			        this.EducationType = Convert.ToString(AttributeValue);
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
				case "UserEducationId":
					return usereducationid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "School_name":
					return school_name_initialized;
				
				case "SchoolType":
					return schooltype_initialized;
				
				case "TownId":
					return townid_initialized;
				
				case "TownName":
					return townname_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Major":
					return major_initialized;
				
				case "StartYear":
					return startyear_initialized;
				
				case "EducationType":
					return educationtype_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "UserEducationId":
					usereducationid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "School_name":
					school_name_initialized = ret;
					return true;
				
				case "SchoolType":
					schooltype_initialized = ret;
					return true;
				
				case "TownId":
					townid_initialized = ret;
					return true;
				
				case "TownName":
					townname_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
					return true;
				
				case "StartYear":
					startyear_initialized = ret;
					return true;
				
				case "EducationType":
					educationtype_initialized = ret;
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

			
			if (usereducationid_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.UserEducationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserEducationId);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (school_name_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.School_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_name);
                }
			}
			
			if (schooltype_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.SchoolType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SchoolType);
                }
			}
			
			if (townid_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.TownId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownId);
                }
			}
			
			if (townname_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.TownName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownName);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (startyear_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.StartYear;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StartYear);
                }
			}
			
			if (educationtype_initialized)
			{
                AttributeItem attr = Jz_userEducation.Attribute.EducationType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EducationType);
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
        public class Jz_userEducationJson
        {
            
            /// <summary>教育用户ID:[CtrlTypeDic-{InputString}]</summary>
            public int UserEducationId { get; set; }
            
            /// <summary>创造时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>学校身份:[CtrlTypeDic-{InputString}]</summary>
            public int School_id { get; set; }
            
            /// <summary>学校名称:[CtrlTypeDic-{InputString}]</summary>
            public string School_name { get; set; }
            
            /// <summary>学校类型:[CtrlTypeDic-{InputString}]</summary>
            public string SchoolType { get; set; }
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public int TownId { get; set; }
            
            /// <summary>小镇的名字:[CtrlTypeDic-{InputString}]</summary>
            public string TownName { get; set; }
            
            /// <summary>用户ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>专业:[CtrlTypeDic-{InputString}]</summary>
            public string Major { get; set; }
            
            /// <summary>年份:[CtrlTypeDic-{InputString}]</summary>
            public int StartYear { get; set; }
            
            /// <summary>学历:[Enum-{COLLEGE:大专},{UNDERGRADUATE:本科},{MASTER_DEGREE:硕士},{DOCTOR:博士}][CtrlTypeDic-{InputString}]</summary>
            public string EducationType { get; set; }
        }
        #endregion
    }
}