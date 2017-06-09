/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表Tapply对应的业务逻辑层Tapply
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Tapply_Entity:Tapply
 * 
************************************************************/
/************************************************************
SQL代码：
select Timestamp,Status,Exception,Message,Path from Tapply
delete from Tapply
INSERT INTO Tapply (Timestamp,Status,Exception,Message,Path)
     VALUES
           ('','','','','')
UPDATE Tapply SET ...
变量赋值代码：
 *         valObj.Timestamp = valObj2.Timestamp;
        valObj.Status = valObj2.Status;
        valObj.Exception = valObj2.Exception;
        valObj.Message = valObj2.Message;
        valObj.Path = valObj2.Path; 
        valObj.Timestamp = "";
        valObj.Status = "";
        valObj.Exception = "";
        valObj.Message = "";
        valObj.Path = ""; 
        "Timestamp": $("#txt_Timestamp").val(),
        "Status": $("#txt_Status").val(),
        "Exception": $("#txt_Exception").val(),
        "Message": $("#txt_Message").val(),
        "Path": $("#txt_Path").val(), 
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
    /// <para>申请</para>
    /// <para>与Tapply数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Tapply : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Tapply Factory()
        {
            return new Tapply();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Timestamp
        {            
            get { return this.Timestamp; }
            set { this.Timestamp = value; }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Exception
        {            
            get { return this.Exception; }
            set { this.Exception = value; }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Message
        {            
            get { return this.Message; }
            set { this.Message = value; }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Timestamp
        {
            get { return this.m_timestamp; }
            set //
            {
                if (!timestamp_initialized || m_timestamp != value)
                {
                    this.m_timestamp = value;
                }
                timestamp_initialized = true;
            }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Exception
        {
            get { return this.m_exception; }
            set //
            {
                if (!exception_initialized || m_exception != value)
                {
                    this.m_exception = value;
                }
                exception_initialized = true;
            }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Message
        {
            get { return this.m_message; }
            set //
            {
                if (!message_initialized || m_message != value)
                {
                    this.m_message = value;
                }
                message_initialized = true;
            }
        }
        
        /// <summary> 申请:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Timestamp =  new AttributeItem("[Tapply].[Timestamp]", typeof(string), 50, default(string));
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Tapply].[Status]", typeof(string), 50, default(string));
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Exception =  new AttributeItem("[Tapply].[Exception]", typeof(string), 50, default(string));
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Message =  new AttributeItem("[Tapply].[Message]", typeof(string), 50, default(string));
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Tapply].[Path]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_timestamp;
        /// <summary></summary>
        protected bool timestamp_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_exception;
        /// <summary></summary>
        protected bool exception_initialized = false;
        
        private string m_message;
        /// <summary></summary>
        protected bool message_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Tapply";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.timestamp_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.exception_initialized = IsLoadAllAttributes;this.message_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Tapply value = new Tapply();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Timestamp"))
				value.timestamp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Exception"))
				value.exception_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Message"))
				value.message_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Tapply Clone()
        {
            return (Tapply)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Tapply()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Tapply() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Tapply(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Tapply(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Tapply(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Tapply(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Tapply(string timestamp1, string status1, string exception1, string message1, string path1)
        {
            
            this.Timestamp = timestamp1;
            
            this.Status = status1;
            
            this.Exception = exception1;
            
            this.Message = message1;
            
            this.Path = path1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Tapply FromIView(IView view)
        {
            return (Tapply)IView.GetITable(view, "Tapply");
        }
        /// <summary>获得一个实例  </summary>
        public static Tapply GetOneInstance()
        {
            Tapply value = new Tapply();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Tapply Retrieve()
        {
            BLLTable<Tapply>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Timestamp":
			        return Timestamp;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Exception":
			        return Exception;
			    			
			    case "Message":
			        return Message;
			    			
			    case "Path":
			        return Path;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Timestamp":
			        this.Timestamp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Exception":
			        this.Exception = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Message":
			        this.Message = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
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
				case "Timestamp":
					return timestamp_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Exception":
					return exception_initialized;
				
				case "Message":
					return message_initialized;
				
				case "Path":
					return path_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Timestamp":
					timestamp_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Exception":
					exception_initialized = ret;
					return true;
				
				case "Message":
					message_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
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

			
			if (timestamp_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Timestamp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Timestamp);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (exception_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Exception;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Exception);
                }
			}
			
			if (message_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Message;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Message);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
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
        public class TapplyJson
        {
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public string Timestamp { get; set; }
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public string Exception { get; set; }
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public string Message { get; set; }
            
            /// <summary>申请:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
        }
        #endregion
    }
}