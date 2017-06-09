/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:05
  Description:    数据表Xb_teacherTagVOs对应的业务逻辑层Xb_teacherTagVOs
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_teacherTagVOs_Entity:Xb_teacherTagVOs
 * 
************************************************************/
/************************************************************
SQL代码：
select CreateTime,Id,Name,Select,TagType,ToUserId,User_id,UserTagId,Uuid from Xb_teacherTagVOs
delete from Xb_teacherTagVOs
INSERT INTO Xb_teacherTagVOs (CreateTime,Id,Name,Select,TagType,ToUserId,User_id,UserTagId,Uuid)
     VALUES
           ('','','','','','','','','')
UPDATE Xb_teacherTagVOs SET ...
变量赋值代码：
 *         valObj.CreateTime = valObj2.CreateTime;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Select = valObj2.Select;
        valObj.TagType = valObj2.TagType;
        valObj.ToUserId = valObj2.ToUserId;
        valObj.User_id = valObj2.User_id;
        valObj.UserTagId = valObj2.UserTagId;
        valObj.Uuid = valObj2.Uuid; 
        valObj.CreateTime = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Select = "";
        valObj.TagType = "";
        valObj.ToUserId = "";
        valObj.User_id = "";
        valObj.UserTagId = "";
        valObj.Uuid = ""; 
        "CreateTime": $("#txt_CreateTime").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Select": $("#txt_Select").val(),
        "TagType": $("#txt_TagType").val(),
        "ToUserId": $("#txt_ToUserId").val(),
        "User_id": $("#txt_User_id").val(),
        "UserTagId": $("#txt_UserTagId").val(),
        "Uuid": $("#txt_Uuid").val(), 
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
    /// <para></para>
    /// <para>与Xb_teacherTagVOs数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacherTagVOs : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_teacherTagVOs Factory()
        {
            return new Xb_teacherTagVOs();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Select
        {            
            get { return this.Select; }
            set { this.Select = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _TagType
        {            
            get { return this.TagType; }
            set { this.TagType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _ToUserId
        {            
            get { return this.ToUserId; }
            set { this.ToUserId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _UserTagId
        {            
            get { return this.UserTagId; }
            set { this.UserTagId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Select
        {
            get { return this.m_select; }
            set //
            {
                if (!select_initialized || m_select != value)
                {
                    this.m_select = value;
                }
                select_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TagType
        {
            get { return this.m_tagtype; }
            set //
            {
                if (!tagtype_initialized || m_tagtype != value)
                {
                    this.m_tagtype = value;
                }
                tagtype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid ToUserId
        {
            get { return this.m_touserid; }
            set //
            {
                if (!touserid_initialized || m_touserid != value)
                {
                    this.m_touserid = value;
                }
                touserid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int UserTagId
        {
            get { return this.m_usertagid; }
            set //private 
            {
                if (!usertagid_initialized || m_usertagid != value)
                {
                    this.m_usertagid = value;
                }
                usertagid_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_teacherTagVOs].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_teacherTagVOs].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_teacherTagVOs].[Name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Select =  new AttributeItem("[Xb_teacherTagVOs].[Select]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TagType =  new AttributeItem("[Xb_teacherTagVOs].[TagType]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ToUserId =  new AttributeItem("[Xb_teacherTagVOs].[ToUserId]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_teacherTagVOs].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserTagId =  new AttributeItem("[Xb_teacherTagVOs].[UserTagId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_teacherTagVOs].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private bool m_select;
        /// <summary></summary>
        protected bool select_initialized = false;
        
        private string m_tagtype;
        /// <summary></summary>
        protected bool tagtype_initialized = false;
        
        private Guid m_touserid;
        /// <summary></summary>
        protected bool touserid_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_usertagid;
        /// <summary></summary>
        protected bool usertagid_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacherTagVOs";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.createtime_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.select_initialized = IsLoadAllAttributes;this.tagtype_initialized = IsLoadAllAttributes;this.touserid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.usertagid_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacherTagVOs value = new Xb_teacherTagVOs();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Select"))
				value.select_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TagType"))
				value.tagtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ToUserId"))
				value.touserid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserTagId"))
				value.usertagid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_teacherTagVOs Clone()
        {
            return (Xb_teacherTagVOs)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_teacherTagVOs()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_teacherTagVOs() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_teacherTagVOs(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_teacherTagVOs(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_teacherTagVOs(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_teacherTagVOs(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_teacherTagVOs(DateTime createtime1, int id1, string name1, bool select1, string tagtype1, Guid touserid1, Guid user_id1, int usertagid1, Guid uuid1)
        {
            
            this.CreateTime = createtime1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Select = select1;
            
            this.TagType = tagtype1;
            
            this.ToUserId = touserid1;
            
            this.User_id = user_id1;
            
            this.UserTagId = usertagid1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_teacherTagVOs FromIView(IView view)
        {
            return (Xb_teacherTagVOs)IView.GetITable(view, "Xb_teacherTagVOs");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_teacherTagVOs GetOneInstance()
        {
            Xb_teacherTagVOs value = new Xb_teacherTagVOs();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_teacherTagVOs Retrieve()
        {
            BLLTable<Xb_teacherTagVOs>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Select":
			        return Select;
			    			
			    case "TagType":
			        return TagType;
			    			
			    case "ToUserId":
			        return ToUserId;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "UserTagId":
			        return UserTagId;
			    			
			    case "Uuid":
			        return Uuid;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Select":
			        this.Select = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "TagType":
			        this.TagType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ToUserId":
			        this.ToUserId = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "UserTagId":
			        this.UserTagId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				case "CreateTime":
					return createtime_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Select":
					return select_initialized;
				
				case "TagType":
					return tagtype_initialized;
				
				case "ToUserId":
					return touserid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "UserTagId":
					return usertagid_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Select":
					select_initialized = ret;
					return true;
				
				case "TagType":
					tagtype_initialized = ret;
					return true;
				
				case "ToUserId":
					touserid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "UserTagId":
					usertagid_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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

			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (select_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.Select;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Select);
                }
			}
			
			if (tagtype_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.TagType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TagType);
                }
			}
			
			if (touserid_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.ToUserId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ToUserId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (usertagid_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.UserTagId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserTagId);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_teacherTagVOs.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
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
        public class Xb_teacherTagVOsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Select { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TagType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid ToUserId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int UserTagId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}