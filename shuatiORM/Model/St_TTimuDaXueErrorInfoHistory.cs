/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:40
  Description:    数据表St_TTimuDaXueErrorInfoHistory对应的业务逻辑层St_TTimuDaXueErrorInfoHistory
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TTimuDaXueErrorInfoHistory_Entity:St_TTimuDaXueErrorInfoHistory
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,AnswerSum,CreateTime,ErrJson,ErrorSum,KemuId,OpenId,TimuIds,User_id from St_TTimuDaXueErrorInfoHistory
delete from St_TTimuDaXueErrorInfoHistory
INSERT INTO St_TTimuDaXueErrorInfoHistory (Id,AnswerSum,CreateTime,ErrJson,ErrorSum,KemuId,OpenId,TimuIds,User_id)
     VALUES
           ('','','','','','','','','')
UPDATE St_TTimuDaXueErrorInfoHistory SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.AnswerSum = valObj2.AnswerSum;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ErrJson = valObj2.ErrJson;
        valObj.ErrorSum = valObj2.ErrorSum;
        valObj.KemuId = valObj2.KemuId;
        valObj.OpenId = valObj2.OpenId;
        valObj.TimuIds = valObj2.TimuIds;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.AnswerSum = "";
        valObj.CreateTime = "";
        valObj.ErrJson = "";
        valObj.ErrorSum = "";
        valObj.KemuId = "";
        valObj.OpenId = "";
        valObj.TimuIds = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "AnswerSum": $("#txt_AnswerSum").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ErrJson": $("#txt_ErrJson").val(),
        "ErrorSum": $("#txt_ErrorSum").val(),
        "KemuId": $("#txt_KemuId").val(),
        "OpenId": $("#txt_OpenId").val(),
        "TimuIds": $("#txt_TimuIds").val(),
        "User_id": $("#txt_User_id").val(), 
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
    /// <para>[IDField-{Id:0}]</para>
    /// <para>与St_TTimuDaXueErrorInfoHistory数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TTimuDaXueErrorInfoHistory : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TTimuDaXueErrorInfoHistory Factory()
        {
            return new St_TTimuDaXueErrorInfoHistory();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 答题总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AnswerSum
        {            
            get { return this.AnswerSum; }
            set { this.AnswerSum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ErrJson
        {            
            get { return this.ErrJson; }
            set { this.ErrJson = value; }
        }
        
        /// <summary> 错误总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ErrorSum
        {            
            get { return this.ErrorSum; }
            set { this.ErrorSum = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> 题目编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TimuIds
        {            
            get { return this.TimuIds; }
            set { this.TimuIds = value; }
        }
        
        /// <summary> 用户编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        
        /// <summary> 答题总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AnswerSum
        {
            get { return this.m_answersum; }
            set //
            {
                if (!answersum_initialized || m_answersum != value)
                {
                    this.m_answersum = value;
                }
                answersum_initialized = true;
            }
        }
        
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
        public string ErrJson
        {
            get { return this.m_errjson; }
            set //
            {
                if (!errjson_initialized || m_errjson != value)
                {
                    this.m_errjson = value;
                }
                errjson_initialized = true;
            }
        }
        
        /// <summary> 错误总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ErrorSum
        {
            get { return this.m_errorsum; }
            set //
            {
                if (!errorsum_initialized || m_errorsum != value)
                {
                    this.m_errorsum = value;
                }
                errorsum_initialized = true;
            }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
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
        
        /// <summary> 题目编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TimuIds
        {
            get { return this.m_timuids; }
            set //
            {
                if (!timuids_initialized || m_timuids != value)
                {
                    this.m_timuids = value;
                }
                timuids_initialized = true;
            }
        }
        
        /// <summary> 用户编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[Id]", typeof(int), 4, default(int));
            
            /// <summary>答题总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerSum =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[AnswerSum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrJson =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[ErrJson]", typeof(string), -1, default(string));
            
            /// <summary>错误总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrorSum =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[ErrorSum]", typeof(int), 4, default(int));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>题目编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TimuIds =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[TimuIds]", typeof(string), 500, default(string));
            
            /// <summary>用户编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_TTimuDaXueErrorInfoHistory].[User_id]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_answersum;
        /// <summary></summary>
        protected bool answersum_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_errjson;
        /// <summary></summary>
        protected bool errjson_initialized = false;
        
        private int m_errorsum;
        /// <summary></summary>
        protected bool errorsum_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_timuids;
        /// <summary></summary>
        protected bool timuids_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TTimuDaXueErrorInfoHistory";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.answersum_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.errjson_initialized = IsLoadAllAttributes;this.errorsum_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.timuids_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TTimuDaXueErrorInfoHistory value = new St_TTimuDaXueErrorInfoHistory();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerSum"))
				value.answersum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrJson"))
				value.errjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrorSum"))
				value.errorsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimuIds"))
				value.timuids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TTimuDaXueErrorInfoHistory Clone()
        {
            return (St_TTimuDaXueErrorInfoHistory)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TTimuDaXueErrorInfoHistory()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TTimuDaXueErrorInfoHistory() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TTimuDaXueErrorInfoHistory(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TTimuDaXueErrorInfoHistory(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TTimuDaXueErrorInfoHistory(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TTimuDaXueErrorInfoHistory(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TTimuDaXueErrorInfoHistory(int id1, int answersum1, DateTime createtime1, string errjson1, int errorsum1, string kemuid1, string openid1, string timuids1, string user_id1)
        {
            
            this.Id = id1;
            
            this.AnswerSum = answersum1;
            
            this.CreateTime = createtime1;
            
            this.ErrJson = errjson1;
            
            this.ErrorSum = errorsum1;
            
            this.KemuId = kemuid1;
            
            this.OpenId = openid1;
            
            this.TimuIds = timuids1;
            
            this.User_id = user_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TTimuDaXueErrorInfoHistory FromIView(IView view)
        {
            return (St_TTimuDaXueErrorInfoHistory)IView.GetITable(view, "St_TTimuDaXueErrorInfoHistory");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TTimuDaXueErrorInfoHistory GetOneInstance()
        {
            St_TTimuDaXueErrorInfoHistory value = new St_TTimuDaXueErrorInfoHistory();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TTimuDaXueErrorInfoHistory Retrieve()
        {
            BLLTable<St_TTimuDaXueErrorInfoHistory>.GetRowData(this);
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
			    			
			    case "AnswerSum":
			        return AnswerSum;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ErrJson":
			        return ErrJson;
			    			
			    case "ErrorSum":
			        return ErrorSum;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "TimuIds":
			        return TimuIds;
			    			
			    case "User_id":
			        return User_id;
			
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
			    			
			    case "AnswerSum":
			        this.AnswerSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ErrJson":
			        this.ErrJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ErrorSum":
			        this.ErrorSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimuIds":
			        this.TimuIds = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
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
				
				case "AnswerSum":
					return answersum_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ErrJson":
					return errjson_initialized;
				
				case "ErrorSum":
					return errorsum_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "TimuIds":
					return timuids_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "AnswerSum":
					answersum_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ErrJson":
					errjson_initialized = ret;
					return true;
				
				case "ErrorSum":
					errorsum_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "TimuIds":
					timuids_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (answersum_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.AnswerSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerSum);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (errjson_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.ErrJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrJson);
                }
			}
			
			if (errorsum_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.ErrorSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrorSum);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (timuids_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.TimuIds;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimuIds);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfoHistory.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
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
        public class St_TTimuDaXueErrorInfoHistoryJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>答题总数:[CtrlTypeDic-{InputString}]</summary>
            public int AnswerSum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ErrJson { get; set; }
            
            /// <summary>错误总数:[CtrlTypeDic-{InputString}]</summary>
            public int ErrorSum { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>题目编号:[CtrlTypeDic-{InputString}]</summary>
            public string TimuIds { get; set; }
            
            /// <summary>用户编号:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}