/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:40
  Description:    数据表St_TUserZsInfo2对应的业务逻辑层St_TUserZsInfo2
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TUserZsInfo2_Entity:St_TUserZsInfo2
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,CreateTime,KemuInfoJson,OpenId,UserId,ZsInfoJson from St_TUserZsInfo2
delete from St_TUserZsInfo2
INSERT INTO St_TUserZsInfo2 (Id,CreateTime,KemuInfoJson,OpenId,UserId,ZsInfoJson)
     VALUES
           ('','','','','','')
UPDATE St_TUserZsInfo2 SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.KemuInfoJson = valObj2.KemuInfoJson;
        valObj.OpenId = valObj2.OpenId;
        valObj.UserId = valObj2.UserId;
        valObj.ZsInfoJson = valObj2.ZsInfoJson; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.KemuInfoJson = "";
        valObj.OpenId = "";
        valObj.UserId = "";
        valObj.ZsInfoJson = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "KemuInfoJson": $("#txt_KemuInfoJson").val(),
        "OpenId": $("#txt_OpenId").val(),
        "UserId": $("#txt_UserId").val(),
        "ZsInfoJson": $("#txt_ZsInfoJson").val(), 
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
    /// <para>ZST用户信息</para>
    /// <para>与St_TUserZsInfo2数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TUserZsInfo2 : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TUserZsInfo2 Factory()
        {
            return new St_TUserZsInfo2();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 科目信息JSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuInfoJson
        {            
            get { return this.KemuInfoJson; }
            set { this.KemuInfoJson = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> 评论人ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserId
        {            
            get { return this.UserId; }
            set { this.UserId = value; }
        }
        
        /// <summary> ZS信息JSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsInfoJson
        {            
            get { return this.ZsInfoJson; }
            set { this.ZsInfoJson = value; }
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
        
        /// <summary> 科目信息JSON:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KemuInfoJson
        {
            get { return this.m_kemuinfojson; }
            set //
            {
                if (!kemuinfojson_initialized || m_kemuinfojson != value)
                {
                    this.m_kemuinfojson = value;
                }
                kemuinfojson_initialized = true;
            }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OpenId
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> 评论人ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserId
        {
            get { return this.m_userid; }
            set //
            {
                if (!userid_initialized || m_userid != value)
                {
                    this.m_userid = value;
                }
                userid_initialized = true;
            }
        }
        
        /// <summary> ZS信息JSON:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ZsInfoJson
        {
            get { return this.m_zsinfojson; }
            set //
            {
                if (!zsinfojson_initialized || m_zsinfojson != value)
                {
                    this.m_zsinfojson = value;
                }
                zsinfojson_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_TUserZsInfo2].[Id]", typeof(int), 4, default(int));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TUserZsInfo2].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>科目信息JSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuInfoJson =  new AttributeItem("[St_TUserZsInfo2].[KemuInfoJson]", typeof(string), -1, default(string));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TUserZsInfo2].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>评论人ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserId =  new AttributeItem("[St_TUserZsInfo2].[UserId]", typeof(string), 50, default(string));
            
            /// <summary>ZS信息JSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsInfoJson =  new AttributeItem("[St_TUserZsInfo2].[ZsInfoJson]", typeof(string), -1, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_kemuinfojson;
        /// <summary></summary>
        protected bool kemuinfojson_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_userid;
        /// <summary></summary>
        protected bool userid_initialized = false;
        
        private string m_zsinfojson;
        /// <summary></summary>
        protected bool zsinfojson_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TUserZsInfo2";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.kemuinfojson_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.userid_initialized = IsLoadAllAttributes;this.zsinfojson_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TUserZsInfo2 value = new St_TUserZsInfo2();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuInfoJson"))
				value.kemuinfojson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserId"))
				value.userid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsInfoJson"))
				value.zsinfojson_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TUserZsInfo2 Clone()
        {
            return (St_TUserZsInfo2)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TUserZsInfo2()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TUserZsInfo2() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TUserZsInfo2(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TUserZsInfo2(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TUserZsInfo2(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TUserZsInfo2(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TUserZsInfo2(int id1, DateTime createtime1, string kemuinfojson1, string openid1, string userid1, string zsinfojson1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.KemuInfoJson = kemuinfojson1;
            
            this.OpenId = openid1;
            
            this.UserId = userid1;
            
            this.ZsInfoJson = zsinfojson1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TUserZsInfo2 FromIView(IView view)
        {
            return (St_TUserZsInfo2)IView.GetITable(view, "St_TUserZsInfo2");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TUserZsInfo2 GetOneInstance()
        {
            St_TUserZsInfo2 value = new St_TUserZsInfo2();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TUserZsInfo2 Retrieve()
        {
            BLLTable<St_TUserZsInfo2>.GetRowData(this);
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
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "KemuInfoJson":
			        return KemuInfoJson;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "UserId":
			        return UserId;
			    			
			    case "ZsInfoJson":
			        return ZsInfoJson;
			
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
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "KemuInfoJson":
			        this.KemuInfoJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserId":
			        this.UserId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsInfoJson":
			        this.ZsInfoJson = Convert.ToString(AttributeValue);
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
				
				case "CreateTime":
					return createtime_initialized;
				
				case "KemuInfoJson":
					return kemuinfojson_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "UserId":
					return userid_initialized;
				
				case "ZsInfoJson":
					return zsinfojson_initialized;
				
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
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "KemuInfoJson":
					kemuinfojson_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "UserId":
					userid_initialized = ret;
					return true;
				
				case "ZsInfoJson":
					zsinfojson_initialized = ret;
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
                AttributeItem attr = St_TUserZsInfo2.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (kemuinfojson_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.KemuInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuInfoJson);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (userid_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.UserId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserId);
                }
			}
			
			if (zsinfojson_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.ZsInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsInfoJson);
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
        public class St_TUserZsInfo2Json
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>科目信息JSON:[CtrlTypeDic-{InputString}]</summary>
            public string KemuInfoJson { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>评论人ID:[CtrlTypeDic-{InputString}]</summary>
            public string UserId { get; set; }
            
            /// <summary>ZS信息JSON:[CtrlTypeDic-{InputString}]</summary>
            public string ZsInfoJson { get; set; }
        }
        #endregion
    }
}