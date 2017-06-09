/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    数据表Xt_knowledge对应的业务逻辑层Xt_knowledge
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_knowledge_Entity:Xt_knowledge
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Category_ids,Category_names,Knowledge_name from Xt_knowledge
delete from Xt_knowledge
INSERT INTO Xt_knowledge (Uuid,Category_ids,Category_names,Knowledge_name)
     VALUES
           ('','','','')
UPDATE Xt_knowledge SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Category_ids = valObj2.Category_ids;
        valObj.Category_names = valObj2.Category_names;
        valObj.Knowledge_name = valObj2.Knowledge_name; 
        valObj.Uuid = "";
        valObj.Category_ids = "";
        valObj.Category_names = "";
        valObj.Knowledge_name = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Category_ids": $("#txt_Category_ids").val(),
        "Category_names": $("#txt_Category_names").val(),
        "Knowledge_name": $("#txt_Knowledge_name").val(), 
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
    /// <para>知识表</para>
    /// <para>与Xt_knowledge数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_knowledge : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_knowledge Factory()
        {
            return new Xt_knowledge();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_ids
        {            
            get { return this.Category_ids; }
            set { this.Category_ids = value; }
        }
        
        /// <summary> 分类名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_names
        {            
            get { return this.Category_names; }
            set { this.Category_names = value; }
        }
        
        /// <summary> 知识名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge_name
        {            
            get { return this.Knowledge_name; }
            set { this.Knowledge_name = value; }
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
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category_ids
        {
            get { return this.m_category_ids; }
            set //
            {
                if (!category_ids_initialized || m_category_ids != value)
                {
                    this.m_category_ids = value;
                }
                category_ids_initialized = true;
            }
        }
        
        /// <summary> 分类名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category_names
        {
            get { return this.m_category_names; }
            set //
            {
                if (!category_names_initialized || m_category_names != value)
                {
                    this.m_category_names = value;
                }
                category_names_initialized = true;
            }
        }
        
        /// <summary> 知识名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Knowledge_name
        {
            get { return this.m_knowledge_name; }
            set //
            {
                if (!knowledge_name_initialized || m_knowledge_name != value)
                {
                    this.m_knowledge_name = value;
                }
                knowledge_name_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_knowledge].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_ids =  new AttributeItem("[Xt_knowledge].[Category_ids]", typeof(string), 100, default(string));
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_names =  new AttributeItem("[Xt_knowledge].[Category_names]", typeof(string), 100, default(string));
            
            /// <summary>知识名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge_name =  new AttributeItem("[Xt_knowledge].[Knowledge_name]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_category_ids;
        /// <summary></summary>
        protected bool category_ids_initialized = false;
        
        private string m_category_names;
        /// <summary></summary>
        protected bool category_names_initialized = false;
        
        private string m_knowledge_name;
        /// <summary></summary>
        protected bool knowledge_name_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_knowledge";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.category_ids_initialized = IsLoadAllAttributes;this.category_names_initialized = IsLoadAllAttributes;this.knowledge_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_knowledge value = new Xt_knowledge();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_ids"))
				value.category_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_names"))
				value.category_names_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge_name"))
				value.knowledge_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_knowledge Clone()
        {
            return (Xt_knowledge)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_knowledge()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_knowledge() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_knowledge(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_knowledge(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_knowledge(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_knowledge(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_knowledge(Guid uuid1, string category_ids1, string category_names1, string knowledge_name1)
        {
            
            this.Uuid = uuid1;
            
            this.Category_ids = category_ids1;
            
            this.Category_names = category_names1;
            
            this.Knowledge_name = knowledge_name1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_knowledge FromIView(IView view)
        {
            return (Xt_knowledge)IView.GetITable(view, "Xt_knowledge");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_knowledge GetOneInstance()
        {
            Xt_knowledge value = new Xt_knowledge();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_knowledge Retrieve()
        {
            BLLTable<Xt_knowledge>.GetRowData(this);
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
			    			
			    case "Category_ids":
			        return Category_ids;
			    			
			    case "Category_names":
			        return Category_names;
			    			
			    case "Knowledge_name":
			        return Knowledge_name;
			
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
			    			
			    case "Category_ids":
			        this.Category_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_names":
			        this.Category_names = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Knowledge_name":
			        this.Knowledge_name = Convert.ToString(AttributeValue);
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
				
				case "Category_ids":
					return category_ids_initialized;
				
				case "Category_names":
					return category_names_initialized;
				
				case "Knowledge_name":
					return knowledge_name_initialized;
				
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
				
				case "Category_ids":
					category_ids_initialized = ret;
					return true;
				
				case "Category_names":
					category_names_initialized = ret;
					return true;
				
				case "Knowledge_name":
					knowledge_name_initialized = ret;
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
                AttributeItem attr = Xt_knowledge.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (category_ids_initialized)
			{
                AttributeItem attr = Xt_knowledge.Attribute.Category_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_ids);
                }
			}
			
			if (category_names_initialized)
			{
                AttributeItem attr = Xt_knowledge.Attribute.Category_names;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_names);
                }
			}
			
			if (knowledge_name_initialized)
			{
                AttributeItem attr = Xt_knowledge.Attribute.Knowledge_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge_name);
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
        public class Xt_knowledgeJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public string Category_ids { get; set; }
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public string Category_names { get; set; }
            
            /// <summary>知识名称:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge_name { get; set; }
        }
        #endregion
    }
}