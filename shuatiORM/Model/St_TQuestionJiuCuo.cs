/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    数据表St_TQuestionJiuCuo对应的业务逻辑层St_TQuestionJiuCuo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TQuestionJiuCuo_Entity:St_TQuestionJiuCuo
 * 
************************************************************/
/************************************************************
SQL代码：
select AutoId,Answer,CreateTime,KemuId,OpenId,QuestionAutoId,QuestionId from St_TQuestionJiuCuo
delete from St_TQuestionJiuCuo
INSERT INTO St_TQuestionJiuCuo (AutoId,Answer,CreateTime,KemuId,OpenId,QuestionAutoId,QuestionId)
     VALUES
           ('','','','','','','')
UPDATE St_TQuestionJiuCuo SET ...
变量赋值代码：
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Answer = valObj2.Answer;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.KemuId = valObj2.KemuId;
        valObj.OpenId = valObj2.OpenId;
        valObj.QuestionAutoId = valObj2.QuestionAutoId;
        valObj.QuestionId = valObj2.QuestionId; 
        valObj.AutoId = "";
        valObj.Answer = "";
        valObj.CreateTime = "";
        valObj.KemuId = "";
        valObj.OpenId = "";
        valObj.QuestionAutoId = "";
        valObj.QuestionId = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Answer": $("#txt_Answer").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "KemuId": $("#txt_KemuId").val(),
        "OpenId": $("#txt_OpenId").val(),
        "QuestionAutoId": $("#txt_QuestionAutoId").val(),
        "QuestionId": $("#txt_QuestionId").val(), 
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
    /// <para>与St_TQuestionJiuCuo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TQuestionJiuCuo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TQuestionJiuCuo Factory()
        {
            return new St_TQuestionJiuCuo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer
        {            
            get { return this.Answer; }
            set { this.Answer = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionAutoId
        {            
            get { return this.QuestionAutoId; }
            set { this.QuestionAutoId = value; }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QuestionId
        {            
            get { return this.QuestionId; }
            set { this.QuestionId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Answer
        {
            get { return this.m_answer; }
            set //
            {
                if (!answer_initialized || m_answer != value)
                {
                    this.m_answer = value;
                }
                answer_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int QuestionAutoId
        {
            get { return this.m_questionautoid; }
            set //
            {
                if (!questionautoid_initialized || m_questionautoid != value)
                {
                    this.m_questionautoid = value;
                }
                questionautoid_initialized = true;
            }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string QuestionId
        {
            get { return this.m_questionid; }
            set //
            {
                if (!questionid_initialized || m_questionid != value)
                {
                    this.m_questionid = value;
                }
                questionid_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TQuestionJiuCuo].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[St_TQuestionJiuCuo].[Answer]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TQuestionJiuCuo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TQuestionJiuCuo].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TQuestionJiuCuo].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionAutoId =  new AttributeItem("[St_TQuestionJiuCuo].[QuestionAutoId]", typeof(int), 4, default(int));
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionId =  new AttributeItem("[St_TQuestionJiuCuo].[QuestionId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private int m_questionautoid;
        /// <summary></summary>
        protected bool questionautoid_initialized = false;
        
        private string m_questionid;
        /// <summary></summary>
        protected bool questionid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TQuestionJiuCuo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.questionautoid_initialized = IsLoadAllAttributes;this.questionid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TQuestionJiuCuo value = new St_TQuestionJiuCuo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionAutoId"))
				value.questionautoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionId"))
				value.questionid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TQuestionJiuCuo Clone()
        {
            return (St_TQuestionJiuCuo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TQuestionJiuCuo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TQuestionJiuCuo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TQuestionJiuCuo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TQuestionJiuCuo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TQuestionJiuCuo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TQuestionJiuCuo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TQuestionJiuCuo(int autoid1, string answer1, DateTime createtime1, string kemuid1, string openid1, int questionautoid1, string questionid1)
        {
            
            this.AutoId = autoid1;
            
            this.Answer = answer1;
            
            this.CreateTime = createtime1;
            
            this.KemuId = kemuid1;
            
            this.OpenId = openid1;
            
            this.QuestionAutoId = questionautoid1;
            
            this.QuestionId = questionid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TQuestionJiuCuo FromIView(IView view)
        {
            return (St_TQuestionJiuCuo)IView.GetITable(view, "St_TQuestionJiuCuo");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TQuestionJiuCuo GetOneInstance()
        {
            St_TQuestionJiuCuo value = new St_TQuestionJiuCuo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TQuestionJiuCuo Retrieve()
        {
            BLLTable<St_TQuestionJiuCuo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "QuestionAutoId":
			        return QuestionAutoId;
			    			
			    case "QuestionId":
			        return QuestionId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Answer":
			        this.Answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionAutoId":
			        this.QuestionAutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "QuestionId":
			        this.QuestionId = Convert.ToString(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "Answer":
					return answer_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "QuestionAutoId":
					return questionautoid_initialized;
				
				case "QuestionId":
					return questionid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "QuestionAutoId":
					questionautoid_initialized = ret;
					return true;
				
				case "QuestionId":
					questionid_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (questionautoid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.QuestionAutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionAutoId);
                }
			}
			
			if (questionid_initialized)
			{
                AttributeItem attr = St_TQuestionJiuCuo.Attribute.QuestionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionId);
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
        public class St_TQuestionJiuCuoJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int QuestionAutoId { get; set; }
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public string QuestionId { get; set; }
        }
        #endregion
    }
}