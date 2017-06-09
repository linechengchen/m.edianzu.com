/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表TSearchKeyword对应的业务逻辑层TSearchKeyword
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TSearchKeyword_Entity:TSearchKeyword
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Keyword,Count,Form from TSearchKeyword
delete from TSearchKeyword
INSERT INTO TSearchKeyword (Id,Keyword,Count,Form)
     VALUES
           ('','','','')
UPDATE TSearchKeyword SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Keyword = valObj2.Keyword;
        valObj.Count = valObj2.Count;
        valObj.Form = valObj2.Form; 
        valObj.Id = "";
        valObj.Keyword = "";
        valObj.Count = "";
        valObj.Form = ""; 
        "Id": $("#txt_Id").val(),
        "Keyword": $("#txt_Keyword").val(),
        "Count": $("#txt_Count").val(),
        "Form": $("#txt_Form").val(), 
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
    /// <para>搜索关键词</para>
    /// <para>与TSearchKeyword数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TSearchKeyword : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TSearchKeyword Factory()
        {
            return new TSearchKeyword();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 关键词:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Keyword
        {            
            get { return this.Keyword; }
            set { this.Keyword = value; }
        }
        
        /// <summary> 计数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Count
        {            
            get { return this.Count; }
            set { this.Count = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form
        {            
            get { return this.Form; }
            set { this.Form = value; }
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
        
        /// <summary> 关键词:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Keyword
        {
            get { return this.m_keyword; }
            set //
            {
                if (!keyword_initialized || m_keyword != value)
                {
                    this.m_keyword = value;
                }
                keyword_initialized = true;
            }
        }
        
        /// <summary> 计数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Count
        {
            get { return this.m_count; }
            set //
            {
                if (!count_initialized || m_count != value)
                {
                    this.m_count = value;
                }
                count_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Form
        {
            get { return this.m_form; }
            set //
            {
                if (!form_initialized || m_form != value)
                {
                    this.m_form = value;
                }
                form_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TSearchKeyword].[Id]", typeof(int), 4, default(int));
            
            /// <summary>关键词:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Keyword =  new AttributeItem("[TSearchKeyword].[Keyword]", typeof(string), 50, default(string));
            
            /// <summary>计数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Count =  new AttributeItem("[TSearchKeyword].[Count]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form =  new AttributeItem("[TSearchKeyword].[Form]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_keyword;
        /// <summary></summary>
        protected bool keyword_initialized = false;
        
        private int m_count;
        /// <summary></summary>
        protected bool count_initialized = false;
        
        private string m_form;
        /// <summary></summary>
        protected bool form_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TSearchKeyword";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.keyword_initialized = IsLoadAllAttributes;this.count_initialized = IsLoadAllAttributes;this.form_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TSearchKeyword value = new TSearchKeyword();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Keyword"))
				value.keyword_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Count"))
				value.count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form"))
				value.form_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TSearchKeyword Clone()
        {
            return (TSearchKeyword)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TSearchKeyword()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TSearchKeyword() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TSearchKeyword(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TSearchKeyword(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TSearchKeyword(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TSearchKeyword(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TSearchKeyword(int id1, string keyword1, int count1, string form1)
        {
            
            this.Id = id1;
            
            this.Keyword = keyword1;
            
            this.Count = count1;
            
            this.Form = form1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TSearchKeyword FromIView(IView view)
        {
            return (TSearchKeyword)IView.GetITable(view, "TSearchKeyword");
        }
        /// <summary>获得一个实例  </summary>
        public static TSearchKeyword GetOneInstance()
        {
            TSearchKeyword value = new TSearchKeyword();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TSearchKeyword Retrieve()
        {
            BLLTable<TSearchKeyword>.GetRowData(this);
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
			    			
			    case "Keyword":
			        return Keyword;
			    			
			    case "Count":
			        return Count;
			    			
			    case "Form":
			        return Form;
			
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
			    			
			    case "Keyword":
			        this.Keyword = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Count":
			        this.Count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Form":
			        this.Form = Convert.ToString(AttributeValue);
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
				
				case "Keyword":
					return keyword_initialized;
				
				case "Count":
					return count_initialized;
				
				case "Form":
					return form_initialized;
				
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
				
				case "Keyword":
					keyword_initialized = ret;
					return true;
				
				case "Count":
					count_initialized = ret;
					return true;
				
				case "Form":
					form_initialized = ret;
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
                AttributeItem attr = TSearchKeyword.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (keyword_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Keyword;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Keyword);
                }
			}
			
			if (count_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Count);
                }
			}
			
			if (form_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Form;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form);
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
        public class TSearchKeywordJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>关键词:[CtrlTypeDic-{InputString}]</summary>
            public string Keyword { get; set; }
            
            /// <summary>计数:[CtrlTypeDic-{InputString}]</summary>
            public int Count { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form { get; set; }
        }
        #endregion
    }
}