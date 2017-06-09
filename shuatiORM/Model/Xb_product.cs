/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:03
  Description:    数据表Xb_product对应的业务逻辑层Xb_product
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_product_Entity:Xb_product
 * 
************************************************************/
/************************************************************
SQL代码：
select CreateTime,Date_desc,Discount_price,Expire_days,Id,Is_have_buy,Lesson_num,ModifyTime,Name,Pic,Point_type,Point_value,Price,Selled_num,Uuid,Xb_product_type_id from Xb_product
delete from Xb_product
INSERT INTO Xb_product (CreateTime,Date_desc,Discount_price,Expire_days,Id,Is_have_buy,Lesson_num,ModifyTime,Name,Pic,Point_type,Point_value,Price,Selled_num,Uuid,Xb_product_type_id)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE Xb_product SET ...
变量赋值代码：
 *         valObj.CreateTime = valObj2.CreateTime;
        valObj.Date_desc = valObj2.Date_desc;
        valObj.Discount_price = valObj2.Discount_price;
        valObj.Expire_days = valObj2.Expire_days;
        valObj.Id = valObj2.Id;
        valObj.Is_have_buy = valObj2.Is_have_buy;
        valObj.Lesson_num = valObj2.Lesson_num;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Name = valObj2.Name;
        valObj.Pic = valObj2.Pic;
        valObj.Point_type = valObj2.Point_type;
        valObj.Point_value = valObj2.Point_value;
        valObj.Price = valObj2.Price;
        valObj.Selled_num = valObj2.Selled_num;
        valObj.Uuid = valObj2.Uuid;
        valObj.Xb_product_type_id = valObj2.Xb_product_type_id; 
        valObj.CreateTime = "";
        valObj.Date_desc = "";
        valObj.Discount_price = "";
        valObj.Expire_days = "";
        valObj.Id = "";
        valObj.Is_have_buy = "";
        valObj.Lesson_num = "";
        valObj.ModifyTime = "";
        valObj.Name = "";
        valObj.Pic = "";
        valObj.Point_type = "";
        valObj.Point_value = "";
        valObj.Price = "";
        valObj.Selled_num = "";
        valObj.Uuid = "";
        valObj.Xb_product_type_id = ""; 
        "CreateTime": $("#txt_CreateTime").val(),
        "Date_desc": $("#txt_Date_desc").val(),
        "Discount_price": $("#txt_Discount_price").val(),
        "Expire_days": $("#txt_Expire_days").val(),
        "Id": $("#txt_Id").val(),
        "Is_have_buy": $("#txt_Is_have_buy").val(),
        "Lesson_num": $("#txt_Lesson_num").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Name": $("#txt_Name").val(),
        "Pic": $("#txt_Pic").val(),
        "Point_type": $("#txt_Point_type").val(),
        "Point_value": $("#txt_Point_value").val(),
        "Price": $("#txt_Price").val(),
        "Selled_num": $("#txt_Selled_num").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Xb_product_type_id": $("#txt_Xb_product_type_id").val(), 
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
    /// <para>产品表</para>
    /// <para>与Xb_product数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_product : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_product Factory()
        {
            return new Xb_product();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Date_desc
        {            
            get { return this.Date_desc; }
            set { this.Date_desc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Discount_price
        {            
            get { return this.Discount_price; }
            set { this.Discount_price = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Expire_days
        {            
            get { return this.Expire_days; }
            set { this.Expire_days = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Is_have_buy
        {            
            get { return this.Is_have_buy; }
            set { this.Is_have_buy = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Lesson_num
        {            
            get { return this.Lesson_num; }
            set { this.Lesson_num = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pic
        {            
            get { return this.Pic; }
            set { this.Pic = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Point_type
        {            
            get { return this.Point_type; }
            set { this.Point_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Point_value
        {            
            get { return this.Point_value; }
            set { this.Point_value = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Selled_num
        {            
            get { return this.Selled_num; }
            set { this.Selled_num = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Xb_product_type_id
        {            
            get { return this.Xb_product_type_id; }
            set { this.Xb_product_type_id = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Date_desc
        {
            get { return this.m_date_desc; }
            set //
            {
                if (!date_desc_initialized || m_date_desc != value)
                {
                    this.m_date_desc = value;
                }
                date_desc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Discount_price
        {
            get { return this.m_discount_price; }
            set //
            {
                if (!discount_price_initialized || m_discount_price != value)
                {
                    this.m_discount_price = value;
                }
                discount_price_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Expire_days
        {
            get { return this.m_expire_days; }
            set //
            {
                if (!expire_days_initialized || m_expire_days != value)
                {
                    this.m_expire_days = value;
                }
                expire_days_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Is_have_buy
        {
            get { return this.m_is_have_buy; }
            set //
            {
                if (!is_have_buy_initialized || m_is_have_buy != value)
                {
                    this.m_is_have_buy = value;
                }
                is_have_buy_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Lesson_num
        {
            get { return this.m_lesson_num; }
            set //
            {
                if (!lesson_num_initialized || m_lesson_num != value)
                {
                    this.m_lesson_num = value;
                }
                lesson_num_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Pic
        {
            get { return this.m_pic; }
            set //
            {
                if (!pic_initialized || m_pic != value)
                {
                    this.m_pic = value;
                }
                pic_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Point_type
        {
            get { return this.m_point_type; }
            set //
            {
                if (!point_type_initialized || m_point_type != value)
                {
                    this.m_point_type = value;
                }
                point_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Point_value
        {
            get { return this.m_point_value; }
            set //
            {
                if (!point_value_initialized || m_point_value != value)
                {
                    this.m_point_value = value;
                }
                point_value_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Price
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Selled_num
        {
            get { return this.m_selled_num; }
            set //
            {
                if (!selled_num_initialized || m_selled_num != value)
                {
                    this.m_selled_num = value;
                }
                selled_num_initialized = true;
            }
        }
        
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Xb_product_type_id
        {
            get { return this.m_xb_product_type_id; }
            set //
            {
                if (!xb_product_type_id_initialized || m_xb_product_type_id != value)
                {
                    this.m_xb_product_type_id = value;
                }
                xb_product_type_id_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_product].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Date_desc =  new AttributeItem("[Xb_product].[Date_desc]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Discount_price =  new AttributeItem("[Xb_product].[Discount_price]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Expire_days =  new AttributeItem("[Xb_product].[Expire_days]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_product].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_have_buy =  new AttributeItem("[Xb_product].[Is_have_buy]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lesson_num =  new AttributeItem("[Xb_product].[Lesson_num]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_product].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_product].[Name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pic =  new AttributeItem("[Xb_product].[Pic]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Point_type =  new AttributeItem("[Xb_product].[Point_type]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Point_value =  new AttributeItem("[Xb_product].[Point_value]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price =  new AttributeItem("[Xb_product].[Price]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Selled_num =  new AttributeItem("[Xb_product].[Selled_num]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_product].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Xb_product_type_id =  new AttributeItem("[Xb_product].[Xb_product_type_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_date_desc;
        /// <summary></summary>
        protected bool date_desc_initialized = false;
        
        private int m_discount_price;
        /// <summary></summary>
        protected bool discount_price_initialized = false;
        
        private int m_expire_days;
        /// <summary></summary>
        protected bool expire_days_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_is_have_buy;
        /// <summary></summary>
        protected bool is_have_buy_initialized = false;
        
        private string m_lesson_num;
        /// <summary></summary>
        protected bool lesson_num_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_pic;
        /// <summary></summary>
        protected bool pic_initialized = false;
        
        private string m_point_type;
        /// <summary></summary>
        protected bool point_type_initialized = false;
        
        private int m_point_value;
        /// <summary></summary>
        protected bool point_value_initialized = false;
        
        private int m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private int m_selled_num;
        /// <summary></summary>
        protected bool selled_num_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_xb_product_type_id;
        /// <summary></summary>
        protected bool xb_product_type_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_product";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.createtime_initialized = IsLoadAllAttributes;this.date_desc_initialized = IsLoadAllAttributes;this.discount_price_initialized = IsLoadAllAttributes;this.expire_days_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.is_have_buy_initialized = IsLoadAllAttributes;this.lesson_num_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.pic_initialized = IsLoadAllAttributes;this.point_type_initialized = IsLoadAllAttributes;this.point_value_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.selled_num_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.xb_product_type_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_product value = new Xb_product();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Date_desc"))
				value.date_desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Discount_price"))
				value.discount_price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Expire_days"))
				value.expire_days_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_have_buy"))
				value.is_have_buy_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lesson_num"))
				value.lesson_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pic"))
				value.pic_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Point_type"))
				value.point_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Point_value"))
				value.point_value_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Selled_num"))
				value.selled_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Xb_product_type_id"))
				value.xb_product_type_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_product Clone()
        {
            return (Xb_product)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_product()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_product() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_product(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_product(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_product(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_product(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_product(DateTime createtime1, string date_desc1, int discount_price1, int expire_days1, int id1, int is_have_buy1, string lesson_num1, DateTime modifytime1, string name1, string pic1, string point_type1, int point_value1, int price1, int selled_num1, Guid uuid1, string xb_product_type_id1)
        {
            
            this.CreateTime = createtime1;
            
            this.Date_desc = date_desc1;
            
            this.Discount_price = discount_price1;
            
            this.Expire_days = expire_days1;
            
            this.Id = id1;
            
            this.Is_have_buy = is_have_buy1;
            
            this.Lesson_num = lesson_num1;
            
            this.ModifyTime = modifytime1;
            
            this.Name = name1;
            
            this.Pic = pic1;
            
            this.Point_type = point_type1;
            
            this.Point_value = point_value1;
            
            this.Price = price1;
            
            this.Selled_num = selled_num1;
            
            this.Uuid = uuid1;
            
            this.Xb_product_type_id = xb_product_type_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_product FromIView(IView view)
        {
            return (Xb_product)IView.GetITable(view, "Xb_product");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_product GetOneInstance()
        {
            Xb_product value = new Xb_product();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_product Retrieve()
        {
            BLLTable<Xb_product>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Date_desc":
			        return Date_desc;
			    			
			    case "Discount_price":
			        return Discount_price;
			    			
			    case "Expire_days":
			        return Expire_days;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Is_have_buy":
			        return Is_have_buy;
			    			
			    case "Lesson_num":
			        return Lesson_num;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Pic":
			        return Pic;
			    			
			    case "Point_type":
			        return Point_type;
			    			
			    case "Point_value":
			        return Point_value;
			    			
			    case "Price":
			        return Price;
			    			
			    case "Selled_num":
			        return Selled_num;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Xb_product_type_id":
			        return Xb_product_type_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Date_desc":
			        this.Date_desc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Discount_price":
			        this.Discount_price = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Expire_days":
			        this.Expire_days = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_have_buy":
			        this.Is_have_buy = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Lesson_num":
			        this.Lesson_num = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pic":
			        this.Pic = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Point_type":
			        this.Point_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Point_value":
			        this.Point_value = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Selled_num":
			        this.Selled_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Xb_product_type_id":
			        this.Xb_product_type_id = Convert.ToString(AttributeValue);
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
				case "CreateTime":
					return createtime_initialized;
				
				case "Date_desc":
					return date_desc_initialized;
				
				case "Discount_price":
					return discount_price_initialized;
				
				case "Expire_days":
					return expire_days_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Is_have_buy":
					return is_have_buy_initialized;
				
				case "Lesson_num":
					return lesson_num_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Pic":
					return pic_initialized;
				
				case "Point_type":
					return point_type_initialized;
				
				case "Point_value":
					return point_value_initialized;
				
				case "Price":
					return price_initialized;
				
				case "Selled_num":
					return selled_num_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Xb_product_type_id":
					return xb_product_type_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Date_desc":
					date_desc_initialized = ret;
					return true;
				
				case "Discount_price":
					discount_price_initialized = ret;
					return true;
				
				case "Expire_days":
					expire_days_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_have_buy":
					is_have_buy_initialized = ret;
					return true;
				
				case "Lesson_num":
					lesson_num_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Pic":
					pic_initialized = ret;
					return true;
				
				case "Point_type":
					point_type_initialized = ret;
					return true;
				
				case "Point_value":
					point_value_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "Selled_num":
					selled_num_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Xb_product_type_id":
					xb_product_type_id_initialized = ret;
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

			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (date_desc_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Date_desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Date_desc);
                }
			}
			
			if (discount_price_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Discount_price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Discount_price);
                }
			}
			
			if (expire_days_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Expire_days;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Expire_days);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_have_buy_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Is_have_buy;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_have_buy);
                }
			}
			
			if (lesson_num_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Lesson_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lesson_num);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (pic_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Pic;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pic);
                }
			}
			
			if (point_type_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Point_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Point_type);
                }
			}
			
			if (point_value_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Point_value;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Point_value);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (selled_num_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Selled_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Selled_num);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (xb_product_type_id_initialized)
			{
                AttributeItem attr = Xb_product.Attribute.Xb_product_type_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Xb_product_type_id);
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
        public class Xb_productJson
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Date_desc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Discount_price { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Expire_days { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Is_have_buy { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Lesson_num { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Pic { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Point_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Point_value { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Price { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Selled_num { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Xb_product_type_id { get; set; }
        }
        #endregion
    }
}