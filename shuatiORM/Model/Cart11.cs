/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:18
  Description:    数据表Cart11对应的业务逻辑层Cart11
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Cart11_Entity:Cart11
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,User_id,TBookSale_id,Quantity,CreateDate,CartState,Dsd,Ccc1 from Cart11
delete from Cart11
INSERT INTO Cart11 (Id,User_id,TBookSale_id,Quantity,CreateDate,CartState,Dsd,Ccc1)
     VALUES
           ('','','','','','','','')
UPDATE Cart11 SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.User_id = valObj2.User_id;
        valObj.TBookSale_id = valObj2.TBookSale_id;
        valObj.Quantity = valObj2.Quantity;
        valObj.CreateDate = valObj2.CreateDate;
        valObj.CartState = valObj2.CartState;
        valObj.Dsd = valObj2.Dsd;
        valObj.Ccc1 = valObj2.Ccc1; 
        valObj.Id = "";
        valObj.User_id = "";
        valObj.TBookSale_id = "";
        valObj.Quantity = "";
        valObj.CreateDate = "";
        valObj.CartState = "";
        valObj.Dsd = "";
        valObj.Ccc1 = ""; 
        "Id": $("#txt_Id").val(),
        "User_id": $("#txt_User_id").val(),
        "TBookSale_id": $("#txt_TBookSale_id").val(),
        "Quantity": $("#txt_Quantity").val(),
        "CreateDate": $("#txt_CreateDate").val(),
        "CartState": $("#txt_CartState").val(),
        "Dsd": $("#txt_Dsd").val(),
        "Ccc1": $("#txt_Ccc1").val(), 
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
    /// <para>与Cart11数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Cart11 : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Cart11 Factory()
        {
            return new Cart11();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TBookSale_id
        {            
            get { return this.TBookSale_id; }
            set { this.TBookSale_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Quantity
        {            
            get { return this.Quantity; }
            set { this.Quantity = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _CreateDate
        {            
            get { return this.CreateDate; }
            set { this.CreateDate = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _CartState
        {            
            get { return this.CartState; }
            set { this.CartState = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Dsd
        {            
            get { return this.Dsd; }
            set { this.Dsd = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Ccc1
        {            
            get { return this.Ccc1; }
            set { this.Ccc1 = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid User_id
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TBookSale_id
        {
            get { return this.m_tbooksale_id; }
            set //
            {
                if (!tbooksale_id_initialized || m_tbooksale_id != value)
                {
                    this.m_tbooksale_id = value;
                }
                tbooksale_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Quantity
        {
            get { return this.m_quantity; }
            set //
            {
                if (!quantity_initialized || m_quantity != value)
                {
                    this.m_quantity = value;
                }
                quantity_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime CreateDate
        {
            get { return this.m_createdate; }
            set //
            {
                if (!createdate_initialized || m_createdate != value)
                {
                    this.m_createdate = value;
                }
                createdate_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CartState
        {
            get { return this.m_cartstate; }
            set //
            {
                if (!cartstate_initialized || m_cartstate != value)
                {
                    this.m_cartstate = value;
                }
                cartstate_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Dsd
        {
            get { return this.m_dsd; }
            set //
            {
                if (!dsd_initialized || m_dsd != value)
                {
                    this.m_dsd = value;
                }
                dsd_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Ccc1
        {
            get { return this.m_ccc1; }
            set //
            {
                if (!ccc1_initialized || m_ccc1 != value)
                {
                    this.m_ccc1 = value;
                }
                ccc1_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Cart11].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Cart11].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TBookSale_id =  new AttributeItem("[Cart11].[TBookSale_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Quantity =  new AttributeItem("[Cart11].[Quantity]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateDate =  new AttributeItem("[Cart11].[CreateDate]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CartState =  new AttributeItem("[Cart11].[CartState]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Dsd =  new AttributeItem("[Cart11].[Dsd]", typeof(string), 10, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Ccc1 =  new AttributeItem("[Cart11].[Ccc1]", typeof(string), 10, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_tbooksale_id;
        /// <summary></summary>
        protected bool tbooksale_id_initialized = false;
        
        private int m_quantity;
        /// <summary></summary>
        protected bool quantity_initialized = false;
        
        private DateTime m_createdate;
        /// <summary></summary>
        protected bool createdate_initialized = false;
        
        private string m_cartstate;
        /// <summary></summary>
        protected bool cartstate_initialized = false;
        
        private string m_dsd;
        /// <summary></summary>
        protected bool dsd_initialized = false;
        
        private string m_ccc1;
        /// <summary></summary>
        protected bool ccc1_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Cart11";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.tbooksale_id_initialized = IsLoadAllAttributes;this.quantity_initialized = IsLoadAllAttributes;this.createdate_initialized = IsLoadAllAttributes;this.cartstate_initialized = IsLoadAllAttributes;this.dsd_initialized = IsLoadAllAttributes;this.ccc1_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Cart11 value = new Cart11();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TBookSale_id"))
				value.tbooksale_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quantity"))
				value.quantity_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateDate"))
				value.createdate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CartState"))
				value.cartstate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dsd"))
				value.dsd_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ccc1"))
				value.ccc1_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Cart11 Clone()
        {
            return (Cart11)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Cart11()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Cart11() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Cart11(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Cart11(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Cart11(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Cart11(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Cart11(int id1, Guid user_id1, string tbooksale_id1, int quantity1, DateTime createdate1, string cartstate1, string dsd1, string ccc11)
        {
            
            this.Id = id1;
            
            this.User_id = user_id1;
            
            this.TBookSale_id = tbooksale_id1;
            
            this.Quantity = quantity1;
            
            this.CreateDate = createdate1;
            
            this.CartState = cartstate1;
            
            this.Dsd = dsd1;
            
            this.Ccc1 = ccc11;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Cart11 FromIView(IView view)
        {
            return (Cart11)IView.GetITable(view, "Cart11");
        }
        /// <summary>获得一个实例  </summary>
        public static Cart11 GetOneInstance()
        {
            Cart11 value = new Cart11();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Cart11 Retrieve()
        {
            BLLTable<Cart11>.GetRowData(this);
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
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "TBookSale_id":
			        return TBookSale_id;
			    			
			    case "Quantity":
			        return Quantity;
			    			
			    case "CreateDate":
			        return CreateDate;
			    			
			    case "CartState":
			        return CartState;
			    			
			    case "Dsd":
			        return Dsd;
			    			
			    case "Ccc1":
			        return Ccc1;
			
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
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "TBookSale_id":
			        this.TBookSale_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Quantity":
			        this.Quantity = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateDate":
			        this.CreateDate = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "CartState":
			        this.CartState = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dsd":
			        this.Dsd = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ccc1":
			        this.Ccc1 = Convert.ToString(AttributeValue);
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
				
				case "User_id":
					return user_id_initialized;
				
				case "TBookSale_id":
					return tbooksale_id_initialized;
				
				case "Quantity":
					return quantity_initialized;
				
				case "CreateDate":
					return createdate_initialized;
				
				case "CartState":
					return cartstate_initialized;
				
				case "Dsd":
					return dsd_initialized;
				
				case "Ccc1":
					return ccc1_initialized;
				
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
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "TBookSale_id":
					tbooksale_id_initialized = ret;
					return true;
				
				case "Quantity":
					quantity_initialized = ret;
					return true;
				
				case "CreateDate":
					createdate_initialized = ret;
					return true;
				
				case "CartState":
					cartstate_initialized = ret;
					return true;
				
				case "Dsd":
					dsd_initialized = ret;
					return true;
				
				case "Ccc1":
					ccc1_initialized = ret;
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
                AttributeItem attr = Cart11.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Cart11.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (tbooksale_id_initialized)
			{
                AttributeItem attr = Cart11.Attribute.TBookSale_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TBookSale_id);
                }
			}
			
			if (quantity_initialized)
			{
                AttributeItem attr = Cart11.Attribute.Quantity;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quantity);
                }
			}
			
			if (createdate_initialized)
			{
                AttributeItem attr = Cart11.Attribute.CreateDate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateDate);
                }
			}
			
			if (cartstate_initialized)
			{
                AttributeItem attr = Cart11.Attribute.CartState;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CartState);
                }
			}
			
			if (dsd_initialized)
			{
                AttributeItem attr = Cart11.Attribute.Dsd;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dsd);
                }
			}
			
			if (ccc1_initialized)
			{
                AttributeItem attr = Cart11.Attribute.Ccc1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ccc1);
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
        public class Cart11Json
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TBookSale_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Quantity { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateDate { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CartState { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Dsd { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Ccc1 { get; set; }
        }
        #endregion
    }
}