/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/8 16:32:41
  Description:    数据表V_index对应的业务逻辑层V_index
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 V_index_Entity:V_index
 * 
************************************************************/
/************************************************************
SQL代码：
select Jin_e,Qi_shu,Price,Goods_Name,Category_Name,Goods_img,Is_index,Is_hot,Img_index,Zulin_index,Uuid,Category_Code from V_index
delete from V_index
INSERT INTO V_index (Jin_e,Qi_shu,Price,Goods_Name,Category_Name,Goods_img,Is_index,Is_hot,Img_index,Zulin_index,Uuid,Category_Code)
     VALUES
           ('','','','','','','','','','','','')
UPDATE V_index SET ...
变量赋值代码：
 *         valObj.Jin_e = valObj2.Jin_e;
        valObj.Qi_shu = valObj2.Qi_shu;
        valObj.Price = valObj2.Price;
        valObj.Goods_Name = valObj2.Goods_Name;
        valObj.Category_Name = valObj2.Category_Name;
        valObj.Goods_img = valObj2.Goods_img;
        valObj.Is_index = valObj2.Is_index;
        valObj.Is_hot = valObj2.Is_hot;
        valObj.Img_index = valObj2.Img_index;
        valObj.Zulin_index = valObj2.Zulin_index;
        valObj.Uuid = valObj2.Uuid;
        valObj.Category_Code = valObj2.Category_Code; 
        valObj.Jin_e = "";
        valObj.Qi_shu = "";
        valObj.Price = "";
        valObj.Goods_Name = "";
        valObj.Category_Name = "";
        valObj.Goods_img = "";
        valObj.Is_index = "";
        valObj.Is_hot = "";
        valObj.Img_index = "";
        valObj.Zulin_index = "";
        valObj.Uuid = "";
        valObj.Category_Code = ""; 
        "Jin_e": $("#txt_Jin_e").val(),
        "Qi_shu": $("#txt_Qi_shu").val(),
        "Price": $("#txt_Price").val(),
        "Goods_Name": $("#txt_Goods_Name").val(),
        "Category_Name": $("#txt_Category_Name").val(),
        "Goods_img": $("#txt_Goods_img").val(),
        "Is_index": $("#txt_Is_index").val(),
        "Is_hot": $("#txt_Is_hot").val(),
        "Img_index": $("#txt_Img_index").val(),
        "Zulin_index": $("#txt_Zulin_index").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Category_Code": $("#txt_Category_Code").val(), 
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
    /// <para>Category__Goods__Image__Zulin:[Inner-{Category:0},{Goods:1},{Image:2},{Zulin:3}]</para>
    /// <para>与V_index数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class V_index : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static V_index Factory()
        {
            return new V_index();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public double _Jin_e
        {            
            get { return this.Jin_e; }
            set { this.Jin_e = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Qi_shu
        {            
            get { return this.Qi_shu; }
            set { this.Qi_shu = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public double _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Goods_Name
        {            
            get { return this.Goods_Name; }
            set { this.Goods_Name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Category_Name
        {            
            get { return this.Category_Name; }
            set { this.Category_Name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Goods_img
        {            
            get { return this.Goods_img; }
            set { this.Goods_img = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Is_index
        {            
            get { return this.Is_index; }
            set { this.Is_index = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Is_hot
        {            
            get { return this.Is_hot; }
            set { this.Is_hot = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Img_index
        {            
            get { return this.Img_index; }
            set { this.Img_index = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Zulin_index
        {            
            get { return this.Zulin_index; }
            set { this.Zulin_index = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Category_Code
        {            
            get { return this.Category_Code; }
            set { this.Category_Code = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public double Jin_e
        {
            get { return this.m_jin_e; }
            set //
            {
                if (!jin_e_initialized || m_jin_e != value)
                {
                    this.m_jin_e = value;
                }
                jin_e_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Qi_shu
        {
            get { return this.m_qi_shu; }
            set //
            {
                if (!qi_shu_initialized || m_qi_shu != value)
                {
                    this.m_qi_shu = value;
                }
                qi_shu_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public double Price
        {
            get { return this.m_price; }
            set //
            {
                if (!price_initialized || m_price != value)
                {
                    this.m_price = value;
                }
                price_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Goods_Name
        {
            get { return this.m_goods_name; }
            set //
            {
                if (!goods_name_initialized || m_goods_name != value)
                {
                    this.m_goods_name = value;
                }
                goods_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Category_Name
        {
            get { return this.m_category_name; }
            set //
            {
                if (!category_name_initialized || m_category_name != value)
                {
                    this.m_category_name = value;
                }
                category_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Goods_img
        {
            get { return this.m_goods_img; }
            set //
            {
                if (!goods_img_initialized || m_goods_img != value)
                {
                    this.m_goods_img = value;
                }
                goods_img_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Is_index
        {
            get { return this.m_is_index; }
            set //
            {
                if (!is_index_initialized || m_is_index != value)
                {
                    this.m_is_index = value;
                }
                is_index_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Is_hot
        {
            get { return this.m_is_hot; }
            set //
            {
                if (!is_hot_initialized || m_is_hot != value)
                {
                    this.m_is_hot = value;
                }
                is_hot_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Img_index
        {
            get { return this.m_img_index; }
            set //
            {
                if (!img_index_initialized || m_img_index != value)
                {
                    this.m_img_index = value;
                }
                img_index_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Zulin_index
        {
            get { return this.m_zulin_index; }
            set //
            {
                if (!zulin_index_initialized || m_zulin_index != value)
                {
                    this.m_zulin_index = value;
                }
                zulin_index_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Category_Code
        {
            get { return this.m_category_code; }
            set //
            {
                if (!category_code_initialized || m_category_code != value)
                {
                    this.m_category_code = value;
                }
                category_code_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Jin_e =  new AttributeItem("[V_index].[Jin_e]", typeof(double), 8, default(double));
            
            /// <summary></summary>
            public static AttributeItem Qi_shu =  new AttributeItem("[V_index].[Qi_shu]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Price =  new AttributeItem("[V_index].[Price]", typeof(double), 8, default(double));
            
            /// <summary></summary>
            public static AttributeItem Goods_Name =  new AttributeItem("[V_index].[Goods_Name]", typeof(string), 500, default(string));
            
            /// <summary></summary>
            public static AttributeItem Category_Name =  new AttributeItem("[V_index].[Category_Name]", typeof(string), 500, default(string));
            
            /// <summary></summary>
            public static AttributeItem Goods_img =  new AttributeItem("[V_index].[Goods_img]", typeof(string), 500, default(string));
            
            /// <summary></summary>
            public static AttributeItem Is_index =  new AttributeItem("[V_index].[Is_index]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Is_hot =  new AttributeItem("[V_index].[Is_hot]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Img_index =  new AttributeItem("[V_index].[Img_index]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Zulin_index =  new AttributeItem("[V_index].[Zulin_index]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[V_index].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Category_Code =  new AttributeItem("[V_index].[Category_Code]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private double m_jin_e;
        /// <summary></summary>
        protected bool jin_e_initialized = false;
        
        private int m_qi_shu;
        /// <summary></summary>
        protected bool qi_shu_initialized = false;
        
        private double m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private string m_goods_name;
        /// <summary></summary>
        protected bool goods_name_initialized = false;
        
        private string m_category_name;
        /// <summary></summary>
        protected bool category_name_initialized = false;
        
        private string m_goods_img;
        /// <summary></summary>
        protected bool goods_img_initialized = false;
        
        private bool m_is_index;
        /// <summary></summary>
        protected bool is_index_initialized = false;
        
        private int m_is_hot;
        /// <summary></summary>
        protected bool is_hot_initialized = false;
        
        private bool m_img_index;
        /// <summary></summary>
        protected bool img_index_initialized = false;
        
        private bool m_zulin_index;
        /// <summary></summary>
        protected bool zulin_index_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private int m_category_code;
        /// <summary></summary>
        protected bool category_code_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_index";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.jin_e_initialized = IsLoadAllAttributes;this.qi_shu_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.goods_name_initialized = IsLoadAllAttributes;this.category_name_initialized = IsLoadAllAttributes;this.goods_img_initialized = IsLoadAllAttributes;this.is_index_initialized = IsLoadAllAttributes;this.is_hot_initialized = IsLoadAllAttributes;this.img_index_initialized = IsLoadAllAttributes;this.zulin_index_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.category_code_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_index value = new V_index();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jin_e"))
				value.jin_e_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qi_shu"))
				value.qi_shu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_Name"))
				value.goods_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_Name"))
				value.category_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_img"))
				value.goods_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_index"))
				value.is_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_hot"))
				value.is_hot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Img_index"))
				value.img_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Zulin_index"))
				value.zulin_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_Code"))
				value.category_code_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new V_index Clone()
        {
            return (V_index)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static V_index()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public V_index() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public V_index(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public V_index(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public V_index(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public V_index(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public V_index(double jin_e1, int qi_shu1, double price1, string goods_name1, string category_name1, string goods_img1, bool is_index1, int is_hot1, bool img_index1, bool zulin_index1, Guid uuid1, int category_code1)
        {
            
            this.Jin_e = jin_e1;
            
            this.Qi_shu = qi_shu1;
            
            this.Price = price1;
            
            this.Goods_Name = goods_name1;
            
            this.Category_Name = category_name1;
            
            this.Goods_img = goods_img1;
            
            this.Is_index = is_index1;
            
            this.Is_hot = is_hot1;
            
            this.Img_index = img_index1;
            
            this.Zulin_index = zulin_index1;
            
            this.Uuid = uuid1;
            
            this.Category_Code = category_code1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static V_index FromIView(IView view)
        {
            return (V_index)IView.GetITable(view, "V_index");
        }
        /// <summary>获得一个实例  </summary>
        public static V_index GetOneInstance()
        {
            V_index value = new V_index();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public V_index Retrieve()
        {
            BLLTable<V_index>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Jin_e":
			        return Jin_e;
			    			
			    case "Qi_shu":
			        return Qi_shu;
			    			
			    case "Price":
			        return Price;
			    			
			    case "Goods_Name":
			        return Goods_Name;
			    			
			    case "Category_Name":
			        return Category_Name;
			    			
			    case "Goods_img":
			        return Goods_img;
			    			
			    case "Is_index":
			        return Is_index;
			    			
			    case "Is_hot":
			        return Is_hot;
			    			
			    case "Img_index":
			        return Img_index;
			    			
			    case "Zulin_index":
			        return Zulin_index;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Category_Code":
			        return Category_Code;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Jin_e":
			        this.Jin_e = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Qi_shu":
			        this.Qi_shu = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Goods_Name":
			        this.Goods_Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_Name":
			        this.Category_Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Goods_img":
			        this.Goods_img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_index":
			        this.Is_index = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Is_hot":
			        this.Is_hot = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Img_index":
			        this.Img_index = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Zulin_index":
			        this.Zulin_index = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Category_Code":
			        this.Category_Code = Convert.ToInt32(AttributeValue);
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
				case "Jin_e":
					return jin_e_initialized;
				
				case "Qi_shu":
					return qi_shu_initialized;
				
				case "Price":
					return price_initialized;
				
				case "Goods_Name":
					return goods_name_initialized;
				
				case "Category_Name":
					return category_name_initialized;
				
				case "Goods_img":
					return goods_img_initialized;
				
				case "Is_index":
					return is_index_initialized;
				
				case "Is_hot":
					return is_hot_initialized;
				
				case "Img_index":
					return img_index_initialized;
				
				case "Zulin_index":
					return zulin_index_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Category_Code":
					return category_code_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Jin_e":
					jin_e_initialized = ret;
					return true;
				
				case "Qi_shu":
					qi_shu_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "Goods_Name":
					goods_name_initialized = ret;
					return true;
				
				case "Category_Name":
					category_name_initialized = ret;
					return true;
				
				case "Goods_img":
					goods_img_initialized = ret;
					return true;
				
				case "Is_index":
					is_index_initialized = ret;
					return true;
				
				case "Is_hot":
					is_hot_initialized = ret;
					return true;
				
				case "Img_index":
					img_index_initialized = ret;
					return true;
				
				case "Zulin_index":
					zulin_index_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Category_Code":
					category_code_initialized = ret;
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

			
			if (jin_e_initialized)
			{
                AttributeItem attr = V_index.Attribute.Jin_e;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jin_e);
                }
			}
			
			if (qi_shu_initialized)
			{
                AttributeItem attr = V_index.Attribute.Qi_shu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qi_shu);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = V_index.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (goods_name_initialized)
			{
                AttributeItem attr = V_index.Attribute.Goods_Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_Name);
                }
			}
			
			if (category_name_initialized)
			{
                AttributeItem attr = V_index.Attribute.Category_Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_Name);
                }
			}
			
			if (goods_img_initialized)
			{
                AttributeItem attr = V_index.Attribute.Goods_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_img);
                }
			}
			
			if (is_index_initialized)
			{
                AttributeItem attr = V_index.Attribute.Is_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_index);
                }
			}
			
			if (is_hot_initialized)
			{
                AttributeItem attr = V_index.Attribute.Is_hot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_hot);
                }
			}
			
			if (img_index_initialized)
			{
                AttributeItem attr = V_index.Attribute.Img_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Img_index);
                }
			}
			
			if (zulin_index_initialized)
			{
                AttributeItem attr = V_index.Attribute.Zulin_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Zulin_index);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = V_index.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (category_code_initialized)
			{
                AttributeItem attr = V_index.Attribute.Category_Code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_Code);
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
        public class V_indexJson
        {
            
            /// <summary></summary>
            public double Jin_e { get; set; }
            
            /// <summary></summary>
            public int Qi_shu { get; set; }
            
            /// <summary></summary>
            public double Price { get; set; }
            
            /// <summary></summary>
            public string Goods_Name { get; set; }
            
            /// <summary></summary>
            public string Category_Name { get; set; }
            
            /// <summary></summary>
            public string Goods_img { get; set; }
            
            /// <summary></summary>
            public bool Is_index { get; set; }
            
            /// <summary></summary>
            public int Is_hot { get; set; }
            
            /// <summary></summary>
            public bool Img_index { get; set; }
            
            /// <summary></summary>
            public bool Zulin_index { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public int Category_Code { get; set; }
        }
        #endregion
    }
}