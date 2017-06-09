/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:01
  Description:    数据表Xb_course_detail对应的业务逻辑层Xb_course_detail
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_course_detail_Entity:Xb_course_detail
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,CourseId,Create_time,Name,Price,Price2,Type from Xb_course_detail
delete from Xb_course_detail
INSERT INTO Xb_course_detail (Id,CourseId,Create_time,Name,Price,Price2,Type)
     VALUES
           ('','','','','','','')
UPDATE Xb_course_detail SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.CourseId = valObj2.CourseId;
        valObj.Create_time = valObj2.Create_time;
        valObj.Name = valObj2.Name;
        valObj.Price = valObj2.Price;
        valObj.Price2 = valObj2.Price2;
        valObj.Type = valObj2.Type; 
        valObj.Id = "";
        valObj.CourseId = "";
        valObj.Create_time = "";
        valObj.Name = "";
        valObj.Price = "";
        valObj.Price2 = "";
        valObj.Type = ""; 
        "Id": $("#txt_Id").val(),
        "CourseId": $("#txt_CourseId").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Name": $("#txt_Name").val(),
        "Price": $("#txt_Price").val(),
        "Price2": $("#txt_Price2").val(),
        "Type": $("#txt_Type").val(), 
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
    /// <para>课程细节</para>
    /// <para>与Xb_course_detail数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_course_detail : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_course_detail Factory()
        {
            return new Xb_course_detail();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 课程编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CourseId
        {            
            get { return this.CourseId; }
            set { this.CourseId = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 价格:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary> 价格2:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Price2
        {            
            get { return this.Price2; }
            set { this.Price2 = value; }
        }
        
        /// <summary> 型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 课程编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CourseId
        {
            get { return this.m_courseid; }
            set //
            {
                if (!courseid_initialized || m_courseid != value)
                {
                    this.m_courseid = value;
                }
                courseid_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
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
        
        /// <summary> 价格:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Price
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
        
        /// <summary> 价格2:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Price2
        {
            get { return this.m_price2; }
            set //
            {
                if (!price2_initialized || m_price2 != value)
                {
                    this.m_price2 = value;
                }
                price2_initialized = true;
            }
        }
        
        /// <summary> 型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_course_detail].[Id]", typeof(int), 4, default(int));
            
            /// <summary>课程编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseId =  new AttributeItem("[Xb_course_detail].[CourseId]", typeof(int), 4, default(int));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_course_detail].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_course_detail].[Name]", typeof(string), 50, default(string));
            
            /// <summary>价格:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price =  new AttributeItem("[Xb_course_detail].[Price]", typeof(string), 10, default(string));
            
            /// <summary>价格2:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price2 =  new AttributeItem("[Xb_course_detail].[Price2]", typeof(string), 10, default(string));
            
            /// <summary>型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xb_course_detail].[Type]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_courseid;
        /// <summary></summary>
        protected bool courseid_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private string m_price2;
        /// <summary></summary>
        protected bool price2_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_course_detail";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.courseid_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.price2_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_course_detail value = new Xb_course_detail();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseId"))
				value.courseid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price2"))
				value.price2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_course_detail Clone()
        {
            return (Xb_course_detail)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_course_detail()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_course_detail() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_course_detail(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_course_detail(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_course_detail(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_course_detail(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_course_detail(int id1, int courseid1, DateTime create_time1, string name1, string price1, string price21, string type1)
        {
            
            this.Id = id1;
            
            this.CourseId = courseid1;
            
            this.Create_time = create_time1;
            
            this.Name = name1;
            
            this.Price = price1;
            
            this.Price2 = price21;
            
            this.Type = type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_course_detail FromIView(IView view)
        {
            return (Xb_course_detail)IView.GetITable(view, "Xb_course_detail");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_course_detail GetOneInstance()
        {
            Xb_course_detail value = new Xb_course_detail();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_course_detail Retrieve()
        {
            BLLTable<Xb_course_detail>.GetRowData(this);
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
			    			
			    case "CourseId":
			        return CourseId;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Price":
			        return Price;
			    			
			    case "Price2":
			        return Price2;
			    			
			    case "Type":
			        return Type;
			
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
			    			
			    case "CourseId":
			        this.CourseId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Price2":
			        this.Price2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
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
				
				case "CourseId":
					return courseid_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Price":
					return price_initialized;
				
				case "Price2":
					return price2_initialized;
				
				case "Type":
					return type_initialized;
				
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
				
				case "CourseId":
					courseid_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "Price2":
					price2_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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
                AttributeItem attr = Xb_course_detail.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (courseid_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.CourseId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseId);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (price2_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Price2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price2);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
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
        public class Xb_course_detailJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>课程编号:[CtrlTypeDic-{InputString}]</summary>
            public int CourseId { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>价格:[CtrlTypeDic-{InputString}]</summary>
            public string Price { get; set; }
            
            /// <summary>价格2:[CtrlTypeDic-{InputString}]</summary>
            public string Price2 { get; set; }
            
            /// <summary>型:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
        }
        #endregion
    }
}