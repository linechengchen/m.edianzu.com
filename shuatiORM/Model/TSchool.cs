/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表TSchool对应的业务逻辑层TSchool
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TSchool_Entity:TSchool
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Name,IsHot,City,Province,X,Y,Seq,Address,Intro,Tel,SchoolUrl,Is985,Create_by,Create_by_name,City_id from TSchool
delete from TSchool
INSERT INTO TSchool (Id,Name,IsHot,City,Province,X,Y,Seq,Address,Intro,Tel,SchoolUrl,Is985,Create_by,Create_by_name,City_id)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE TSchool SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.IsHot = valObj2.IsHot;
        valObj.City = valObj2.City;
        valObj.Province = valObj2.Province;
        valObj.X = valObj2.X;
        valObj.Y = valObj2.Y;
        valObj.Seq = valObj2.Seq;
        valObj.Address = valObj2.Address;
        valObj.Intro = valObj2.Intro;
        valObj.Tel = valObj2.Tel;
        valObj.SchoolUrl = valObj2.SchoolUrl;
        valObj.Is985 = valObj2.Is985;
        valObj.Create_by = valObj2.Create_by;
        valObj.Create_by_name = valObj2.Create_by_name;
        valObj.City_id = valObj2.City_id; 
        valObj.Id = "";
        valObj.Name = "";
        valObj.IsHot = "";
        valObj.City = "";
        valObj.Province = "";
        valObj.X = "";
        valObj.Y = "";
        valObj.Seq = "";
        valObj.Address = "";
        valObj.Intro = "";
        valObj.Tel = "";
        valObj.SchoolUrl = "";
        valObj.Is985 = "";
        valObj.Create_by = "";
        valObj.Create_by_name = "";
        valObj.City_id = ""; 
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "IsHot": $("#txt_IsHot").val(),
        "City": $("#txt_City").val(),
        "Province": $("#txt_Province").val(),
        "X": $("#txt_X").val(),
        "Y": $("#txt_Y").val(),
        "Seq": $("#txt_Seq").val(),
        "Address": $("#txt_Address").val(),
        "Intro": $("#txt_Intro").val(),
        "Tel": $("#txt_Tel").val(),
        "SchoolUrl": $("#txt_SchoolUrl").val(),
        "Is985": $("#txt_Is985").val(),
        "Create_by": $("#txt_Create_by").val(),
        "Create_by_name": $("#txt_Create_by_name").val(),
        "City_id": $("#txt_City_id").val(), 
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
    /// <para>学校信息</para>
    /// <para>与TSchool数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TSchool : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TSchool Factory()
        {
            return new TSchool();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 学校名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 是否热搜:[Enum-{0:是},{1:否}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> 城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _X
        {            
            get { return this.X; }
            set { this.X = value; }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Y
        {            
            get { return this.Y; }
            set { this.Y = value; }
        }
        
        /// <summary> 排序id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Tel
        {            
            get { return this.Tel; }
            set { this.Tel = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _SchoolUrl
        {            
            get { return this.SchoolUrl; }
            set { this.SchoolUrl = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _Is985
        {            
            get { return this.Is985; }
            set { this.Is985 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by_name
        {            
            get { return this.Create_by_name; }
            set { this.Create_by_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
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
        
        /// <summary> 学校名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否热搜:[Enum-{0:是},{1:否}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
            }
        }
        
        /// <summary> 城市:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Province
        {
            get { return this.m_province; }
            set //
            {
                if (!province_initialized || m_province != value)
                {
                    this.m_province = value;
                }
                province_initialized = true;
            }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal X
        {
            get { return this.m_x; }
            set //
            {
                if (!x_initialized || m_x != value)
                {
                    this.m_x = value;
                }
                x_initialized = true;
            }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Y
        {
            get { return this.m_y; }
            set //
            {
                if (!y_initialized || m_y != value)
                {
                    this.m_y = value;
                }
                y_initialized = true;
            }
        }
        
        /// <summary> 排序id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Address
        {
            get { return this.m_address; }
            set //
            {
                if (!address_initialized || m_address != value)
                {
                    this.m_address = value;
                }
                address_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Intro
        {
            get { return this.m_intro; }
            set //
            {
                if (!intro_initialized || m_intro != value)
                {
                    this.m_intro = value;
                }
                intro_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Tel
        {
            get { return this.m_tel; }
            set //
            {
                if (!tel_initialized || m_tel != value)
                {
                    this.m_tel = value;
                }
                tel_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string SchoolUrl
        {
            get { return this.m_schoolurl; }
            set //
            {
                if (!schoolurl_initialized || m_schoolurl != value)
                {
                    this.m_schoolurl = value;
                }
                schoolurl_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string Is985
        {
            get { return this.m_is985; }
            set //
            {
                if (!is985_initialized || m_is985 != value)
                {
                    this.m_is985 = value;
                }
                is985_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Create_by
        {
            get { return this.m_create_by; }
            set //
            {
                if (!create_by_initialized || m_create_by != value)
                {
                    this.m_create_by = value;
                }
                create_by_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Create_by_name
        {
            get { return this.m_create_by_name; }
            set //
            {
                if (!create_by_name_initialized || m_create_by_name != value)
                {
                    this.m_create_by_name = value;
                }
                create_by_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string City_id
        {
            get { return this.m_city_id; }
            set //
            {
                if (!city_id_initialized || m_city_id != value)
                {
                    this.m_city_id = value;
                }
                city_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TSchool].[Id]", typeof(int), 4, default(int));
            
            /// <summary>学校名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[TSchool].[Name]", typeof(string), 100, default(string));
            
            /// <summary>是否热搜:[Enum-{0:是},{1:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[TSchool].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[TSchool].[City]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[TSchool].[Province]", typeof(string), 100, default(string));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X =  new AttributeItem("[TSchool].[X]", typeof(decimal), 10, default(decimal));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Y =  new AttributeItem("[TSchool].[Y]", typeof(decimal), 10, default(decimal));
            
            /// <summary>排序id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[TSchool].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Address =  new AttributeItem("[TSchool].[Address]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[TSchool].[Intro]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Tel =  new AttributeItem("[TSchool].[Tel]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem SchoolUrl =  new AttributeItem("[TSchool].[SchoolUrl]", typeof(string), 550, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem Is985 =  new AttributeItem("[TSchool].[Is985]", typeof(string), 300, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[TSchool].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by_name =  new AttributeItem("[TSchool].[Create_by_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[TSchool].[City_id]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private decimal m_x;
        /// <summary></summary>
        protected bool x_initialized = false;
        
        private decimal m_y;
        /// <summary></summary>
        protected bool y_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private string m_tel;
        /// <summary></summary>
        protected bool tel_initialized = false;
        
        private string m_schoolurl;
        /// <summary></summary>
        protected bool schoolurl_initialized = false;
        
        private string m_is985;
        /// <summary></summary>
        protected bool is985_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_create_by_name;
        /// <summary></summary>
        protected bool create_by_name_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TSchool";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.x_initialized = IsLoadAllAttributes;this.y_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.tel_initialized = IsLoadAllAttributes;this.schoolurl_initialized = IsLoadAllAttributes;this.is985_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.create_by_name_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TSchool value = new TSchool();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X"))
				value.x_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Y"))
				value.y_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tel"))
				value.tel_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SchoolUrl"))
				value.schoolurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is985"))
				value.is985_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by_name"))
				value.create_by_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TSchool Clone()
        {
            return (TSchool)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TSchool()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TSchool() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TSchool(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TSchool(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TSchool(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TSchool(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TSchool(int id1, string name1, bool ishot1, string city1, string province1, decimal x1, decimal y1, int seq1, string address1, string intro1, string tel1, string schoolurl1, string is9851, string create_by1, string create_by_name1, string city_id1)
        {
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.IsHot = ishot1;
            
            this.City = city1;
            
            this.Province = province1;
            
            this.X = x1;
            
            this.Y = y1;
            
            this.Seq = seq1;
            
            this.Address = address1;
            
            this.Intro = intro1;
            
            this.Tel = tel1;
            
            this.SchoolUrl = schoolurl1;
            
            this.Is985 = is9851;
            
            this.Create_by = create_by1;
            
            this.Create_by_name = create_by_name1;
            
            this.City_id = city_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TSchool FromIView(IView view)
        {
            return (TSchool)IView.GetITable(view, "TSchool");
        }
        /// <summary>获得一个实例  </summary>
        public static TSchool GetOneInstance()
        {
            TSchool value = new TSchool();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TSchool Retrieve()
        {
            BLLTable<TSchool>.GetRowData(this);
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
			    			
			    case "Name":
			        return Name;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "City":
			        return City;
			    			
			    case "Province":
			        return Province;
			    			
			    case "X":
			        return X;
			    			
			    case "Y":
			        return Y;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "Tel":
			        return Tel;
			    			
			    case "SchoolUrl":
			        return SchoolUrl;
			    			
			    case "Is985":
			        return Is985;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "Create_by_name":
			        return Create_by_name;
			    			
			    case "City_id":
			        return City_id;
			
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
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X":
			        this.X = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Y":
			        this.Y = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tel":
			        this.Tel = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SchoolUrl":
			        this.SchoolUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is985":
			        this.Is985 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by_name":
			        this.Create_by_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
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
				
				case "Name":
					return name_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "City":
					return city_initialized;
				
				case "Province":
					return province_initialized;
				
				case "X":
					return x_initialized;
				
				case "Y":
					return y_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "Tel":
					return tel_initialized;
				
				case "SchoolUrl":
					return schoolurl_initialized;
				
				case "Is985":
					return is985_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "Create_by_name":
					return create_by_name_initialized;
				
				case "City_id":
					return city_id_initialized;
				
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
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "X":
					x_initialized = ret;
					return true;
				
				case "Y":
					y_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "Tel":
					tel_initialized = ret;
					return true;
				
				case "SchoolUrl":
					schoolurl_initialized = ret;
					return true;
				
				case "Is985":
					is985_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "Create_by_name":
					create_by_name_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
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
                AttributeItem attr = TSchool.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = TSchool.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = TSchool.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (x_initialized)
			{
                AttributeItem attr = TSchool.Attribute.X;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X);
                }
			}
			
			if (y_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Y;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Y);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (tel_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Tel;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tel);
                }
			}
			
			if (schoolurl_initialized)
			{
                AttributeItem attr = TSchool.Attribute.SchoolUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SchoolUrl);
                }
			}
			
			if (is985_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Is985;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is985);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (create_by_name_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Create_by_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by_name);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = TSchool.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
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
        public class TSchoolJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>学校名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>是否热搜:[Enum-{0:是},{1:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal X { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Y { get; set; }
            
            /// <summary>排序id:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Address { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Intro { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Tel { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string SchoolUrl { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string Is985 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
        }
        #endregion
    }
}