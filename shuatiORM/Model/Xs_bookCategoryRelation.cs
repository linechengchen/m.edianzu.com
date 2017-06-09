/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    数据表Xs_bookCategoryRelation对应的业务逻辑层Xs_bookCategoryRelation
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xs_bookCategoryRelation_Entity:Xs_bookCategoryRelation
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,TBookSaleCategoryId,Seq from Xs_bookCategoryRelation
delete from Xs_bookCategoryRelation
INSERT INTO Xs_bookCategoryRelation (Id,TBookSaleCategoryId,Seq)
     VALUES
           ('','','')
UPDATE Xs_bookCategoryRelation SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.TBookSaleCategoryId = valObj2.TBookSaleCategoryId;
        valObj.Seq = valObj2.Seq; 
        valObj.Id = "";
        valObj.TBookSaleCategoryId = "";
        valObj.Seq = ""; 
        "Id": $("#txt_Id").val(),
        "TBookSaleCategoryId": $("#txt_TBookSaleCategoryId").val(),
        "Seq": $("#txt_Seq").val(), 
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
    /// <para>图书销售品类关系</para>
    /// <para>与Xs_bookCategoryRelation数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xs_bookCategoryRelation : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xs_bookCategoryRelation Factory()
        {
            return new Xs_bookCategoryRelation();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 图书销售类别标识:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TBookSaleCategoryId
        {            
            get { return this.TBookSaleCategoryId; }
            set { this.TBookSaleCategoryId = value; }
        }
        
        /// <summary> 序列:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 图书销售类别标识:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TBookSaleCategoryId
        {
            get { return this.m_tbooksalecategoryid; }
            set //
            {
                if (!tbooksalecategoryid_initialized || m_tbooksalecategoryid != value)
                {
                    this.m_tbooksalecategoryid = value;
                }
                tbooksalecategoryid_initialized = true;
            }
        }
        
        /// <summary> 序列:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xs_bookCategoryRelation].[Id]", typeof(int), 4, default(int));
            
            /// <summary>图书销售类别标识:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TBookSaleCategoryId =  new AttributeItem("[Xs_bookCategoryRelation].[TBookSaleCategoryId]", typeof(int), 4, default(int));
            
            /// <summary>序列:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[Xs_bookCategoryRelation].[Seq]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_tbooksalecategoryid;
        /// <summary></summary>
        protected bool tbooksalecategoryid_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_bookCategoryRelation";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.tbooksalecategoryid_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_bookCategoryRelation value = new Xs_bookCategoryRelation();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TBookSaleCategoryId"))
				value.tbooksalecategoryid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xs_bookCategoryRelation Clone()
        {
            return (Xs_bookCategoryRelation)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xs_bookCategoryRelation()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xs_bookCategoryRelation() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xs_bookCategoryRelation(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xs_bookCategoryRelation(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xs_bookCategoryRelation(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xs_bookCategoryRelation(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xs_bookCategoryRelation(int id1, int tbooksalecategoryid1, int seq1)
        {
            
            this.Id = id1;
            
            this.TBookSaleCategoryId = tbooksalecategoryid1;
            
            this.Seq = seq1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xs_bookCategoryRelation FromIView(IView view)
        {
            return (Xs_bookCategoryRelation)IView.GetITable(view, "Xs_bookCategoryRelation");
        }
        /// <summary>获得一个实例  </summary>
        public static Xs_bookCategoryRelation GetOneInstance()
        {
            Xs_bookCategoryRelation value = new Xs_bookCategoryRelation();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xs_bookCategoryRelation Retrieve()
        {
            BLLTable<Xs_bookCategoryRelation>.GetRowData(this);
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
			    			
			    case "TBookSaleCategoryId":
			        return TBookSaleCategoryId;
			    			
			    case "Seq":
			        return Seq;
			
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
			    			
			    case "TBookSaleCategoryId":
			        this.TBookSaleCategoryId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
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
				
				case "TBookSaleCategoryId":
					return tbooksalecategoryid_initialized;
				
				case "Seq":
					return seq_initialized;
				
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
				
				case "TBookSaleCategoryId":
					tbooksalecategoryid_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
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
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (tbooksalecategoryid_initialized)
			{
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.TBookSaleCategoryId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TBookSaleCategoryId);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
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
        public class Xs_bookCategoryRelationJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>图书销售类别标识:[CtrlTypeDic-{InputString}]</summary>
            public int TBookSaleCategoryId { get; set; }
            
            /// <summary>序列:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
        }
        #endregion
    }
}