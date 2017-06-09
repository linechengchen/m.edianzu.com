/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:57
  Description:    数据表Del_VTimuDaXueErrorInfo对应的业务逻辑层Del_VTimuDaXueErrorInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Del_VTimuDaXueErrorInfo_Entity:Del_VTimuDaXueErrorInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select ErrorSum,AnswerSum,OpenId from Del_VTimuDaXueErrorInfo
delete from Del_VTimuDaXueErrorInfo
INSERT INTO Del_VTimuDaXueErrorInfo (ErrorSum,AnswerSum,OpenId)
     VALUES
           ('','','')
UPDATE Del_VTimuDaXueErrorInfo SET ...
变量赋值代码：
 *         valObj.ErrorSum = valObj2.ErrorSum;
        valObj.AnswerSum = valObj2.AnswerSum;
        valObj.OpenId = valObj2.OpenId; 
        valObj.ErrorSum = "";
        valObj.AnswerSum = "";
        valObj.OpenId = ""; 
        "ErrorSum": $("#txt_ErrorSum").val(),
        "AnswerSum": $("#txt_AnswerSum").val(),
        "OpenId": $("#txt_OpenId").val(), 
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
    /// <para>[Inner-{St_TTimuDaXueErrorInfo:0}]</para>
    /// <para>与Del_VTimuDaXueErrorInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Del_VTimuDaXueErrorInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Del_VTimuDaXueErrorInfo Factory()
        {
            return new Del_VTimuDaXueErrorInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 错误总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ErrorSum
        {            
            get { return this.ErrorSum; }
            set { this.ErrorSum = value; }
        }
        
        /// <summary> 答题总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AnswerSum
        {            
            get { return this.AnswerSum; }
            set { this.AnswerSum = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>错误总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrorSum =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[ErrorSum]", typeof(int), 4, default(int));
            
            /// <summary>答题总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerSum =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[AnswerSum]", typeof(int), 4, default(int));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[OpenId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_errorsum;
        /// <summary></summary>
        protected bool errorsum_initialized = false;
        
        private int m_answersum;
        /// <summary></summary>
        protected bool answersum_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Del_VTimuDaXueErrorInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.errorsum_initialized = IsLoadAllAttributes;this.answersum_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Del_VTimuDaXueErrorInfo value = new Del_VTimuDaXueErrorInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrorSum"))
				value.errorsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerSum"))
				value.answersum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Del_VTimuDaXueErrorInfo Clone()
        {
            return (Del_VTimuDaXueErrorInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Del_VTimuDaXueErrorInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Del_VTimuDaXueErrorInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Del_VTimuDaXueErrorInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Del_VTimuDaXueErrorInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Del_VTimuDaXueErrorInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Del_VTimuDaXueErrorInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Del_VTimuDaXueErrorInfo(int errorsum1, int answersum1, string openid1)
        {
            
            this.ErrorSum = errorsum1;
            
            this.AnswerSum = answersum1;
            
            this.OpenId = openid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Del_VTimuDaXueErrorInfo FromIView(IView view)
        {
            return (Del_VTimuDaXueErrorInfo)IView.GetITable(view, "Del_VTimuDaXueErrorInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static Del_VTimuDaXueErrorInfo GetOneInstance()
        {
            Del_VTimuDaXueErrorInfo value = new Del_VTimuDaXueErrorInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Del_VTimuDaXueErrorInfo Retrieve()
        {
            BLLTable<Del_VTimuDaXueErrorInfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ErrorSum":
			        return ErrorSum;
			    			
			    case "AnswerSum":
			        return AnswerSum;
			    			
			    case "OpenId":
			        return OpenId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ErrorSum":
			        this.ErrorSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AnswerSum":
			        this.AnswerSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
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
				case "ErrorSum":
					return errorsum_initialized;
				
				case "AnswerSum":
					return answersum_initialized;
				
				case "OpenId":
					return openid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ErrorSum":
					errorsum_initialized = ret;
					return true;
				
				case "AnswerSum":
					answersum_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
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

			
			if (errorsum_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.ErrorSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrorSum);
                }
			}
			
			if (answersum_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.AnswerSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerSum);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
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
        public class Del_VTimuDaXueErrorInfoJson
        {
            
            /// <summary>错误总数:[CtrlTypeDic-{InputString}]</summary>
            public int ErrorSum { get; set; }
            
            /// <summary>答题总数:[CtrlTypeDic-{InputString}]</summary>
            public int AnswerSum { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
        }
        #endregion
    }
}