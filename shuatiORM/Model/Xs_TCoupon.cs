/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    数据表Xs_TCoupon对应的业务逻辑层Xs_TCoupon
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xs_TCoupon_Entity:Xs_TCoupon
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,CouponId,Code,User_id,Type,State,UseTime,PowerValue,ShopName,BackgroundImg,BackgroundColor,Logo from Xs_TCoupon
delete from Xs_TCoupon
INSERT INTO Xs_TCoupon (Id,CouponId,Code,User_id,Type,State,UseTime,PowerValue,ShopName,BackgroundImg,BackgroundColor,Logo)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xs_TCoupon SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.CouponId = valObj2.CouponId;
        valObj.Code = valObj2.Code;
        valObj.User_id = valObj2.User_id;
        valObj.Type = valObj2.Type;
        valObj.State = valObj2.State;
        valObj.UseTime = valObj2.UseTime;
        valObj.PowerValue = valObj2.PowerValue;
        valObj.ShopName = valObj2.ShopName;
        valObj.BackgroundImg = valObj2.BackgroundImg;
        valObj.BackgroundColor = valObj2.BackgroundColor;
        valObj.Logo = valObj2.Logo; 
        valObj.Id = "";
        valObj.CouponId = "";
        valObj.Code = "";
        valObj.User_id = "";
        valObj.Type = "";
        valObj.State = "";
        valObj.UseTime = "";
        valObj.PowerValue = "";
        valObj.ShopName = "";
        valObj.BackgroundImg = "";
        valObj.BackgroundColor = "";
        valObj.Logo = ""; 
        "Id": $("#txt_Id").val(),
        "CouponId": $("#txt_CouponId").val(),
        "Code": $("#txt_Code").val(),
        "User_id": $("#txt_User_id").val(),
        "Type": $("#txt_Type").val(),
        "State": $("#txt_State").val(),
        "UseTime": $("#txt_UseTime").val(),
        "PowerValue": $("#txt_PowerValue").val(),
        "ShopName": $("#txt_ShopName").val(),
        "BackgroundImg": $("#txt_BackgroundImg").val(),
        "BackgroundColor": $("#txt_BackgroundColor").val(),
        "Logo": $("#txt_Logo").val(), 
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
    /// <para>优惠券:[IDField-{Id:0}]</para>
    /// <para>与Xs_TCoupon数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xs_TCoupon : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xs_TCoupon Factory()
        {
            return new Xs_TCoupon();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _CouponId
        {            
            get { return this.CouponId; }
            set { this.CouponId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Code
        {            
            get { return this.Code; }
            set { this.Code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _State
        {            
            get { return this.State; }
            set { this.State = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UseTime
        {            
            get { return this.UseTime; }
            set { this.UseTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PowerValue
        {            
            get { return this.PowerValue; }
            set { this.PowerValue = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShopName
        {            
            get { return this.ShopName; }
            set { this.ShopName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BackgroundImg
        {            
            get { return this.BackgroundImg; }
            set { this.BackgroundImg = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BackgroundColor
        {            
            get { return this.BackgroundColor; }
            set { this.BackgroundColor = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Logo
        {            
            get { return this.Logo; }
            set { this.Logo = value; }
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
        public Guid CouponId
        {
            get { return this.m_couponid; }
            set //
            {
                if (!couponid_initialized || m_couponid != value)
                {
                    this.m_couponid = value;
                }
                couponid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Code
        {
            get { return this.m_code; }
            set //
            {
                if (!code_initialized || m_code != value)
                {
                    this.m_code = value;
                }
                code_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string User_id
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
        public string Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int State
        {
            get { return this.m_state; }
            set //
            {
                if (!state_initialized || m_state != value)
                {
                    this.m_state = value;
                }
                state_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UseTime
        {
            get { return this.m_usetime; }
            set //
            {
                if (!usetime_initialized || m_usetime != value)
                {
                    this.m_usetime = value;
                }
                usetime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PowerValue
        {
            get { return this.m_powervalue; }
            set //
            {
                if (!powervalue_initialized || m_powervalue != value)
                {
                    this.m_powervalue = value;
                }
                powervalue_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ShopName
        {
            get { return this.m_shopname; }
            set //
            {
                if (!shopname_initialized || m_shopname != value)
                {
                    this.m_shopname = value;
                }
                shopname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string BackgroundImg
        {
            get { return this.m_backgroundimg; }
            set //
            {
                if (!backgroundimg_initialized || m_backgroundimg != value)
                {
                    this.m_backgroundimg = value;
                }
                backgroundimg_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string BackgroundColor
        {
            get { return this.m_backgroundcolor; }
            set //
            {
                if (!backgroundcolor_initialized || m_backgroundcolor != value)
                {
                    this.m_backgroundcolor = value;
                }
                backgroundcolor_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Logo
        {
            get { return this.m_logo; }
            set //
            {
                if (!logo_initialized || m_logo != value)
                {
                    this.m_logo = value;
                }
                logo_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xs_TCoupon].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CouponId =  new AttributeItem("[Xs_TCoupon].[CouponId]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Code =  new AttributeItem("[Xs_TCoupon].[Code]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xs_TCoupon].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xs_TCoupon].[Type]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem State =  new AttributeItem("[Xs_TCoupon].[State]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UseTime =  new AttributeItem("[Xs_TCoupon].[UseTime]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PowerValue =  new AttributeItem("[Xs_TCoupon].[PowerValue]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShopName =  new AttributeItem("[Xs_TCoupon].[ShopName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BackgroundImg =  new AttributeItem("[Xs_TCoupon].[BackgroundImg]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BackgroundColor =  new AttributeItem("[Xs_TCoupon].[BackgroundColor]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Logo =  new AttributeItem("[Xs_TCoupon].[Logo]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_couponid;
        /// <summary></summary>
        protected bool couponid_initialized = false;
        
        private string m_code;
        /// <summary></summary>
        protected bool code_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private int m_state;
        /// <summary></summary>
        protected bool state_initialized = false;
        
        private string m_usetime;
        /// <summary></summary>
        protected bool usetime_initialized = false;
        
        private string m_powervalue;
        /// <summary></summary>
        protected bool powervalue_initialized = false;
        
        private string m_shopname;
        /// <summary></summary>
        protected bool shopname_initialized = false;
        
        private string m_backgroundimg;
        /// <summary></summary>
        protected bool backgroundimg_initialized = false;
        
        private string m_backgroundcolor;
        /// <summary></summary>
        protected bool backgroundcolor_initialized = false;
        
        private string m_logo;
        /// <summary></summary>
        protected bool logo_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_TCoupon";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.couponid_initialized = IsLoadAllAttributes;this.code_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.state_initialized = IsLoadAllAttributes;this.usetime_initialized = IsLoadAllAttributes;this.powervalue_initialized = IsLoadAllAttributes;this.shopname_initialized = IsLoadAllAttributes;this.backgroundimg_initialized = IsLoadAllAttributes;this.backgroundcolor_initialized = IsLoadAllAttributes;this.logo_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_TCoupon value = new Xs_TCoupon();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CouponId"))
				value.couponid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Code"))
				value.code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"State"))
				value.state_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UseTime"))
				value.usetime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PowerValue"))
				value.powervalue_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShopName"))
				value.shopname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BackgroundImg"))
				value.backgroundimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BackgroundColor"))
				value.backgroundcolor_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Logo"))
				value.logo_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xs_TCoupon Clone()
        {
            return (Xs_TCoupon)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xs_TCoupon()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xs_TCoupon() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xs_TCoupon(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xs_TCoupon(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xs_TCoupon(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xs_TCoupon(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xs_TCoupon(int id1, Guid couponid1, string code1, string user_id1, string type1, int state1, string usetime1, string powervalue1, string shopname1, string backgroundimg1, string backgroundcolor1, string logo1)
        {
            
            this.Id = id1;
            
            this.CouponId = couponid1;
            
            this.Code = code1;
            
            this.User_id = user_id1;
            
            this.Type = type1;
            
            this.State = state1;
            
            this.UseTime = usetime1;
            
            this.PowerValue = powervalue1;
            
            this.ShopName = shopname1;
            
            this.BackgroundImg = backgroundimg1;
            
            this.BackgroundColor = backgroundcolor1;
            
            this.Logo = logo1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xs_TCoupon FromIView(IView view)
        {
            return (Xs_TCoupon)IView.GetITable(view, "Xs_TCoupon");
        }
        /// <summary>获得一个实例  </summary>
        public static Xs_TCoupon GetOneInstance()
        {
            Xs_TCoupon value = new Xs_TCoupon();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xs_TCoupon Retrieve()
        {
            BLLTable<Xs_TCoupon>.GetRowData(this);
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
			    			
			    case "CouponId":
			        return CouponId;
			    			
			    case "Code":
			        return Code;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Type":
			        return Type;
			    			
			    case "State":
			        return State;
			    			
			    case "UseTime":
			        return UseTime;
			    			
			    case "PowerValue":
			        return PowerValue;
			    			
			    case "ShopName":
			        return ShopName;
			    			
			    case "BackgroundImg":
			        return BackgroundImg;
			    			
			    case "BackgroundColor":
			        return BackgroundColor;
			    			
			    case "Logo":
			        return Logo;
			
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
			    			
			    case "CouponId":
			        this.CouponId = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Code":
			        this.Code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "State":
			        this.State = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "UseTime":
			        this.UseTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PowerValue":
			        this.PowerValue = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShopName":
			        this.ShopName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BackgroundImg":
			        this.BackgroundImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BackgroundColor":
			        this.BackgroundColor = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Logo":
			        this.Logo = Convert.ToString(AttributeValue);
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
				
				case "CouponId":
					return couponid_initialized;
				
				case "Code":
					return code_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Type":
					return type_initialized;
				
				case "State":
					return state_initialized;
				
				case "UseTime":
					return usetime_initialized;
				
				case "PowerValue":
					return powervalue_initialized;
				
				case "ShopName":
					return shopname_initialized;
				
				case "BackgroundImg":
					return backgroundimg_initialized;
				
				case "BackgroundColor":
					return backgroundcolor_initialized;
				
				case "Logo":
					return logo_initialized;
				
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
				
				case "CouponId":
					couponid_initialized = ret;
					return true;
				
				case "Code":
					code_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "State":
					state_initialized = ret;
					return true;
				
				case "UseTime":
					usetime_initialized = ret;
					return true;
				
				case "PowerValue":
					powervalue_initialized = ret;
					return true;
				
				case "ShopName":
					shopname_initialized = ret;
					return true;
				
				case "BackgroundImg":
					backgroundimg_initialized = ret;
					return true;
				
				case "BackgroundColor":
					backgroundcolor_initialized = ret;
					return true;
				
				case "Logo":
					logo_initialized = ret;
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
                AttributeItem attr = Xs_TCoupon.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (couponid_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.CouponId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CouponId);
                }
			}
			
			if (code_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Code);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (state_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.State;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(State);
                }
			}
			
			if (usetime_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.UseTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UseTime);
                }
			}
			
			if (powervalue_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.PowerValue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PowerValue);
                }
			}
			
			if (shopname_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.ShopName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShopName);
                }
			}
			
			if (backgroundimg_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.BackgroundImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BackgroundImg);
                }
			}
			
			if (backgroundcolor_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.BackgroundColor;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BackgroundColor);
                }
			}
			
			if (logo_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Logo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Logo);
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
        public class Xs_TCouponJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid CouponId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int State { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string UseTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PowerValue { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ShopName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string BackgroundImg { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string BackgroundColor { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Logo { get; set; }
        }
        #endregion
    }
}