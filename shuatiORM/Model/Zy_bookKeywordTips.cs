/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:34
  Description:    数据表Zy_bookKeywordTips对应的业务逻辑层Zy_bookKeywordTips
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Zy_bookKeywordTips_Entity:Zy_bookKeywordTips
 * 
************************************************************/
/************************************************************
SQL代码：
select Name,Id,TableId from Zy_bookKeywordTips
delete from Zy_bookKeywordTips
INSERT INTO Zy_bookKeywordTips (Name,Id,TableId)
     VALUES
           ('','','')
UPDATE Zy_bookKeywordTips SET ...
变量赋值代码：
 *         valObj.Name = valObj2.Name;
        valObj.Id = valObj2.Id;
        valObj.TableId = valObj2.TableId; 
        valObj.Name = "";
        valObj.Id = "";
        valObj.TableId = ""; 
        "Name": $("#txt_Name").val(),
        "Id": $("#txt_Id").val(),
        "TableId": $("#txt_TableId").val(), 
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
    /// <para>关键词TZY版图书</para>
    /// <para>与Zy_bookKeywordTips数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Zy_bookKeywordTips : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Zy_bookKeywordTips Factory()
        {
            return new Zy_bookKeywordTips();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 编号:[CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 表的ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TableId
        {            
            get { return this.TableId; }
            set { this.TableId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 表的ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TableId
        {
            get { return this.m_tableid; }
            set //
            {
                if (!tableid_initialized || m_tableid != value)
                {
                    this.m_tableid = value;
                }
                tableid_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Zy_bookKeywordTips].[Name]", typeof(string), 200, default(string));
            
            /// <summary>编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Zy_bookKeywordTips].[Id]", typeof(int), 4, default(int));
            
            /// <summary>表的ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TableId =  new AttributeItem("[Zy_bookKeywordTips].[TableId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_tableid;
        /// <summary></summary>
        protected bool tableid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Zy_bookKeywordTips";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.name_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.tableid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Zy_bookKeywordTips value = new Zy_bookKeywordTips();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TableId"))
				value.tableid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Zy_bookKeywordTips Clone()
        {
            return (Zy_bookKeywordTips)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Zy_bookKeywordTips()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Zy_bookKeywordTips() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Zy_bookKeywordTips(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Zy_bookKeywordTips(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Zy_bookKeywordTips(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Zy_bookKeywordTips(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Zy_bookKeywordTips(string name1, int id1, int tableid1)
        {
            
            this.Name = name1;
            
            this.Id = id1;
            
            this.TableId = tableid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Zy_bookKeywordTips FromIView(IView view)
        {
            return (Zy_bookKeywordTips)IView.GetITable(view, "Zy_bookKeywordTips");
        }
        /// <summary>获得一个实例  </summary>
        public static Zy_bookKeywordTips GetOneInstance()
        {
            Zy_bookKeywordTips value = new Zy_bookKeywordTips();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Zy_bookKeywordTips Retrieve()
        {
            BLLTable<Zy_bookKeywordTips>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Name":
			        return Name;
			    			
			    case "Id":
			        return Id;
			    			
			    case "TableId":
			        return TableId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TableId":
			        this.TableId = Convert.ToInt32(AttributeValue);
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
				case "Name":
					return name_initialized;
				
				case "Id":
					return id_initialized;
				
				case "TableId":
					return tableid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "TableId":
					tableid_initialized = ret;
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

			
			if (name_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (tableid_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.TableId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TableId);
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
        public class Zy_bookKeywordTipsJson
        {
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>编号:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>表的ID:[CtrlTypeDic-{InputString}]</summary>
            public int TableId { get; set; }
        }
        #endregion
    }
}