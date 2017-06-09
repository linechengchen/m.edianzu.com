/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表THighSchool对应的业务逻辑层THighSchool
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 THighSchool_Entity:THighSchool
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Name,City_id,Intro,IsZhongDian,Province,Address,IsSchool,GradeJson,ClassJson,Create_by,Create_by_name from THighSchool
delete from THighSchool
INSERT INTO THighSchool (Id,Name,City_id,Intro,IsZhongDian,Province,Address,IsSchool,GradeJson,ClassJson,Create_by,Create_by_name)
     VALUES
           ('','','','','','','','','','','','')
UPDATE THighSchool SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.City_id = valObj2.City_id;
        valObj.Intro = valObj2.Intro;
        valObj.IsZhongDian = valObj2.IsZhongDian;
        valObj.Province = valObj2.Province;
        valObj.Address = valObj2.Address;
        valObj.IsSchool = valObj2.IsSchool;
        valObj.GradeJson = valObj2.GradeJson;
        valObj.ClassJson = valObj2.ClassJson;
        valObj.Create_by = valObj2.Create_by;
        valObj.Create_by_name = valObj2.Create_by_name; 
        valObj.Id = "";
        valObj.Name = "";
        valObj.City_id = "";
        valObj.Intro = "";
        valObj.IsZhongDian = "";
        valObj.Province = "";
        valObj.Address = "";
        valObj.IsSchool = "";
        valObj.GradeJson = "";
        valObj.ClassJson = "";
        valObj.Create_by = "";
        valObj.Create_by_name = ""; 
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "City_id": $("#txt_City_id").val(),
        "Intro": $("#txt_Intro").val(),
        "IsZhongDian": $("#txt_IsZhongDian").val(),
        "Province": $("#txt_Province").val(),
        "Address": $("#txt_Address").val(),
        "IsSchool": $("#txt_IsSchool").val(),
        "GradeJson": $("#txt_GradeJson").val(),
        "ClassJson": $("#txt_ClassJson").val(),
        "Create_by": $("#txt_Create_by").val(),
        "Create_by_name": $("#txt_Create_by_name").val(), 
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
    /// <para>高中</para>
    /// <para>与THighSchool数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class THighSchool : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static THighSchool Factory()
        {
            return new THighSchool();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 城市标识:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> 是中路店:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsZhongDian
        {            
            get { return this.IsZhongDian; }
            set { this.IsZhongDian = value; }
        }
        
        /// <summary> 省:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> 地址:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> 是学院:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsSchool
        {            
            get { return this.IsSchool; }
            set { this.IsSchool = value; }
        }
        
        /// <summary> 程度的JSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GradeJson
        {            
            get { return this.GradeJson; }
            set { this.GradeJson = value; }
        }
        
        /// <summary> 一流的JSON:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _ClassJson
        {            
            get { return this.ClassJson; }
            set { this.ClassJson = value; }
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
        #endregion
        #region 类字段清单2
        
        /// <summary> ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 城市标识:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 简介:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是中路店:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int IsZhongDian
        {
            get { return this.m_iszhongdian; }
            set //
            {
                if (!iszhongdian_initialized || m_iszhongdian != value)
                {
                    this.m_iszhongdian = value;
                }
                iszhongdian_initialized = true;
            }
        }
        
        /// <summary> 省:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 地址:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是学院:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int IsSchool
        {
            get { return this.m_isschool; }
            set //
            {
                if (!isschool_initialized || m_isschool != value)
                {
                    this.m_isschool = value;
                }
                isschool_initialized = true;
            }
        }
        
        /// <summary> 程度的JSON:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string GradeJson
        {
            get { return this.m_gradejson; }
            set //
            {
                if (!gradejson_initialized || m_gradejson != value)
                {
                    this.m_gradejson = value;
                }
                gradejson_initialized = true;
            }
        }
        
        /// <summary> 一流的JSON:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string ClassJson
        {
            get { return this.m_classjson; }
            set //
            {
                if (!classjson_initialized || m_classjson != value)
                {
                    this.m_classjson = value;
                }
                classjson_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[THighSchool].[Id]", typeof(int), 4, default(int));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[THighSchool].[Name]", typeof(string), 50, default(string));
            
            /// <summary>城市标识:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[THighSchool].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>简介:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[THighSchool].[Intro]", typeof(string), 1000, default(string));
            
            /// <summary>是中路店:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsZhongDian =  new AttributeItem("[THighSchool].[IsZhongDian]", typeof(int), 4, default(int));
            
            /// <summary>省:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[THighSchool].[Province]", typeof(string), 50, default(string));
            
            /// <summary>地址:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Address =  new AttributeItem("[THighSchool].[Address]", typeof(string), 500, default(string));
            
            /// <summary>是学院:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsSchool =  new AttributeItem("[THighSchool].[IsSchool]", typeof(int), 4, default(int));
            
            /// <summary>程度的JSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GradeJson =  new AttributeItem("[THighSchool].[GradeJson]", typeof(string), 50, default(string));
            
            /// <summary>一流的JSON:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem ClassJson =  new AttributeItem("[THighSchool].[ClassJson]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[THighSchool].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by_name =  new AttributeItem("[THighSchool].[Create_by_name]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private int m_iszhongdian;
        /// <summary></summary>
        protected bool iszhongdian_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private int m_isschool;
        /// <summary></summary>
        protected bool isschool_initialized = false;
        
        private string m_gradejson;
        /// <summary></summary>
        protected bool gradejson_initialized = false;
        
        private string m_classjson;
        /// <summary></summary>
        protected bool classjson_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_create_by_name;
        /// <summary></summary>
        protected bool create_by_name_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "THighSchool";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.iszhongdian_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.isschool_initialized = IsLoadAllAttributes;this.gradejson_initialized = IsLoadAllAttributes;this.classjson_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.create_by_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			THighSchool value = new THighSchool();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsZhongDian"))
				value.iszhongdian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsSchool"))
				value.isschool_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GradeJson"))
				value.gradejson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassJson"))
				value.classjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by_name"))
				value.create_by_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new THighSchool Clone()
        {
            return (THighSchool)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static THighSchool()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public THighSchool() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public THighSchool(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public THighSchool(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public THighSchool(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public THighSchool(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public THighSchool(int id1, string name1, string city_id1, string intro1, int iszhongdian1, string province1, string address1, int isschool1, string gradejson1, string classjson1, string create_by1, string create_by_name1)
        {
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.City_id = city_id1;
            
            this.Intro = intro1;
            
            this.IsZhongDian = iszhongdian1;
            
            this.Province = province1;
            
            this.Address = address1;
            
            this.IsSchool = isschool1;
            
            this.GradeJson = gradejson1;
            
            this.ClassJson = classjson1;
            
            this.Create_by = create_by1;
            
            this.Create_by_name = create_by_name1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static THighSchool FromIView(IView view)
        {
            return (THighSchool)IView.GetITable(view, "THighSchool");
        }
        /// <summary>获得一个实例  </summary>
        public static THighSchool GetOneInstance()
        {
            THighSchool value = new THighSchool();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public THighSchool Retrieve()
        {
            BLLTable<THighSchool>.GetRowData(this);
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
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "IsZhongDian":
			        return IsZhongDian;
			    			
			    case "Province":
			        return Province;
			    			
			    case "Address":
			        return Address;
			    			
			    case "IsSchool":
			        return IsSchool;
			    			
			    case "GradeJson":
			        return GradeJson;
			    			
			    case "ClassJson":
			        return ClassJson;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "Create_by_name":
			        return Create_by_name;
			
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
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsZhongDian":
			        this.IsZhongDian = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsSchool":
			        this.IsSchool = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GradeJson":
			        this.GradeJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassJson":
			        this.ClassJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by_name":
			        this.Create_by_name = Convert.ToString(AttributeValue);
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
				
				case "City_id":
					return city_id_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "IsZhongDian":
					return iszhongdian_initialized;
				
				case "Province":
					return province_initialized;
				
				case "Address":
					return address_initialized;
				
				case "IsSchool":
					return isschool_initialized;
				
				case "GradeJson":
					return gradejson_initialized;
				
				case "ClassJson":
					return classjson_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "Create_by_name":
					return create_by_name_initialized;
				
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
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "IsZhongDian":
					iszhongdian_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "IsSchool":
					isschool_initialized = ret;
					return true;
				
				case "GradeJson":
					gradejson_initialized = ret;
					return true;
				
				case "ClassJson":
					classjson_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "Create_by_name":
					create_by_name_initialized = ret;
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
                AttributeItem attr = THighSchool.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (iszhongdian_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.IsZhongDian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsZhongDian);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (isschool_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.IsSchool;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsSchool);
                }
			}
			
			if (gradejson_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.GradeJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GradeJson);
                }
			}
			
			if (classjson_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.ClassJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassJson);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (create_by_name_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Create_by_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by_name);
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
        public class THighSchoolJson
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>城市标识:[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
            
            /// <summary>简介:[CtrlTypeDic-{Text}]</summary>
            public string Intro { get; set; }
            
            /// <summary>是中路店:[CtrlTypeDic-{InputString}]</summary>
            public int IsZhongDian { get; set; }
            
            /// <summary>省:[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>地址:[CtrlTypeDic-{Text}]</summary>
            public string Address { get; set; }
            
            /// <summary>是学院:[CtrlTypeDic-{InputString}]</summary>
            public int IsSchool { get; set; }
            
            /// <summary>程度的JSON:[CtrlTypeDic-{InputString}]</summary>
            public string GradeJson { get; set; }
            
            /// <summary>一流的JSON:[CtrlTypeDic-{Text}]</summary>
            public string ClassJson { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by_name { get; set; }
        }
        #endregion
    }
}