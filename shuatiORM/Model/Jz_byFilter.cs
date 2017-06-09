/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    数据表Jz_byFilter对应的业务逻辑层Jz_byFilter
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_byFilter_Entity:Jz_byFilter
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,SortRules from Jz_byFilter
delete from Jz_byFilter
INSERT INTO Jz_byFilter (Id,SortRules)
     VALUES
           ('','')
UPDATE Jz_byFilter SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.SortRules = valObj2.SortRules; 
        valObj.Id = "";
        valObj.SortRules = ""; 
        "Id": $("#txt_Id").val(),
        "SortRules": $("#txt_SortRules").val(), 
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
    /// <para>与Jz_byFilter数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_byFilter : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_byFilter Factory()
        {
            return new Jz_byFilter();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [Enum-{INTELLIGENCE:普通排序},{NEAREST:离我最近},{LATEST_RELEASE:最新发布},{POPULAR_JOB:热门兼职},{HIGH_SALARY:薪资最高},{APPLY_COUNT:招聘人数}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _SortRules
        {            
            get { return this.SortRules; }
            set { this.SortRules = value; }
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
        
        /// <summary> [Enum-{INTELLIGENCE:普通排序},{NEAREST:离我最近},{LATEST_RELEASE:最新发布},{POPULAR_JOB:热门兼职},{HIGH_SALARY:薪资最高},{APPLY_COUNT:招聘人数}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string SortRules
        {
            get { return this.m_sortrules; }
            set //
            {
                if (!sortrules_initialized || m_sortrules != value)
                {
                    this.m_sortrules = value;
                }
                sortrules_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jz_byFilter].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[Enum-{INTELLIGENCE:普通排序},{NEAREST:离我最近},{LATEST_RELEASE:最新发布},{POPULAR_JOB:热门兼职},{HIGH_SALARY:薪资最高},{APPLY_COUNT:招聘人数}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem SortRules =  new AttributeItem("[Jz_byFilter].[SortRules]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_sortrules;
        /// <summary></summary>
        protected bool sortrules_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_byFilter";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.sortrules_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_byFilter value = new Jz_byFilter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SortRules"))
				value.sortrules_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_byFilter Clone()
        {
            return (Jz_byFilter)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_byFilter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_byFilter() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_byFilter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_byFilter(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_byFilter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_byFilter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_byFilter(int id1, string sortrules1)
        {
            
            this.Id = id1;
            
            this.SortRules = sortrules1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_byFilter FromIView(IView view)
        {
            return (Jz_byFilter)IView.GetITable(view, "Jz_byFilter");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_byFilter GetOneInstance()
        {
            Jz_byFilter value = new Jz_byFilter();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_byFilter Retrieve()
        {
            BLLTable<Jz_byFilter>.GetRowData(this);
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
			    			
			    case "SortRules":
			        return SortRules;
			
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
			    			
			    case "SortRules":
			        this.SortRules = Convert.ToString(AttributeValue);
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
				
				case "SortRules":
					return sortrules_initialized;
				
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
				
				case "SortRules":
					sortrules_initialized = ret;
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
                AttributeItem attr = Jz_byFilter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (sortrules_initialized)
			{
                AttributeItem attr = Jz_byFilter.Attribute.SortRules;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SortRules);
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
        public class Jz_byFilterJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[Enum-{INTELLIGENCE:普通排序},{NEAREST:离我最近},{LATEST_RELEASE:最新发布},{POPULAR_JOB:热门兼职},{HIGH_SALARY:薪资最高},{APPLY_COUNT:招聘人数}][CtrlTypeDic-{SelectDrop}]</summary>
            public string SortRules { get; set; }
        }
        #endregion
    }
}