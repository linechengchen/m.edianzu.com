/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    数据表Xt_student_sign对应的业务逻辑层Xt_student_sign
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_student_sign_Entity:Xt_student_sign
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Status,Sign_id,Course_id,Student_id,Lng,Lat,City,Address,Create_time,Remark,Distance,Modify_time,Student_name from Xt_student_sign
delete from Xt_student_sign
INSERT INTO Xt_student_sign (Uuid,Status,Sign_id,Course_id,Student_id,Lng,Lat,City,Address,Create_time,Remark,Distance,Modify_time,Student_name)
     VALUES
           ('','','','','','','','','','','','','','')
UPDATE Xt_student_sign SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Status = valObj2.Status;
        valObj.Sign_id = valObj2.Sign_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Student_id = valObj2.Student_id;
        valObj.Lng = valObj2.Lng;
        valObj.Lat = valObj2.Lat;
        valObj.City = valObj2.City;
        valObj.Address = valObj2.Address;
        valObj.Create_time = valObj2.Create_time;
        valObj.Remark = valObj2.Remark;
        valObj.Distance = valObj2.Distance;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Student_name = valObj2.Student_name; 
        valObj.Uuid = "";
        valObj.Status = "";
        valObj.Sign_id = "";
        valObj.Course_id = "";
        valObj.Student_id = "";
        valObj.Lng = "";
        valObj.Lat = "";
        valObj.City = "";
        valObj.Address = "";
        valObj.Create_time = "";
        valObj.Remark = "";
        valObj.Distance = "";
        valObj.Modify_time = "";
        valObj.Student_name = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Status": $("#txt_Status").val(),
        "Sign_id": $("#txt_Sign_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Lng": $("#txt_Lng").val(),
        "Lat": $("#txt_Lat").val(),
        "City": $("#txt_City").val(),
        "Address": $("#txt_Address").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Remark": $("#txt_Remark").val(),
        "Distance": $("#txt_Distance").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Student_name": $("#txt_Student_name").val(), 
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
    /// <para>学生签到表</para>
    /// <para>与Xt_student_sign数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_sign : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_student_sign Factory()
        {
            return new Xt_student_sign();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 状态:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> 签到id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sign_id
        {            
            get { return this.Sign_id; }
            set { this.Sign_id = value; }
        }
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 学生id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lng
        {            
            get { return this.Lng; }
            set { this.Lng = value; }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lat
        {            
            get { return this.Lat; }
            set { this.Lat = value; }
        }
        
        /// <summary> 城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> 地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 备注:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Remark
        {            
            get { return this.Remark; }
            set { this.Remark = value; }
        }
        
        /// <summary> 与老师发布点名的距离:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Distance
        {            
            get { return this.Distance; }
            set { this.Distance = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> 学生名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_name
        {            
            get { return this.Student_name; }
            set { this.Student_name = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        
        /// <summary> 状态:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Status
        {
            get { return this.m_status; }
            set //
            {
                if (!status_initialized || m_status != value)
                {
                    this.m_status = value;
                }
                status_initialized = true;
            }
        }
        
        /// <summary> 签到id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sign_id
        {
            get { return this.m_sign_id; }
            set //
            {
                if (!sign_id_initialized || m_sign_id != value)
                {
                    this.m_sign_id = value;
                }
                sign_id_initialized = true;
            }
        }
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Course_id
        {
            get { return this.m_course_id; }
            set //
            {
                if (!course_id_initialized || m_course_id != value)
                {
                    this.m_course_id = value;
                }
                course_id_initialized = true;
            }
        }
        
        /// <summary> 学生id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Student_id
        {
            get { return this.m_student_id; }
            set //
            {
                if (!student_id_initialized || m_student_id != value)
                {
                    this.m_student_id = value;
                }
                student_id_initialized = true;
            }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Lng
        {
            get { return this.m_lng; }
            set //
            {
                if (!lng_initialized || m_lng != value)
                {
                    this.m_lng = value;
                }
                lng_initialized = true;
            }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Lat
        {
            get { return this.m_lat; }
            set //
            {
                if (!lat_initialized || m_lat != value)
                {
                    this.m_lat = value;
                }
                lat_initialized = true;
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
        
        /// <summary> 地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 备注:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Remark
        {
            get { return this.m_remark; }
            set //
            {
                if (!remark_initialized || m_remark != value)
                {
                    this.m_remark = value;
                }
                remark_initialized = true;
            }
        }
        
        /// <summary> 与老师发布点名的距离:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Distance
        {
            get { return this.m_distance; }
            set //
            {
                if (!distance_initialized || m_distance != value)
                {
                    this.m_distance = value;
                }
                distance_initialized = true;
            }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
            }
        }
        
        /// <summary> 学生名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Student_name
        {
            get { return this.m_student_name; }
            set //
            {
                if (!student_name_initialized || m_student_name != value)
                {
                    this.m_student_name = value;
                }
                student_name_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_sign].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>状态:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xt_student_sign].[Status]", typeof(string), 1, default(string));
            
            /// <summary>签到id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sign_id =  new AttributeItem("[Xt_student_sign].[Sign_id]", typeof(string), 36, default(string));
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_student_sign].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>学生id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_sign].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lng =  new AttributeItem("[Xt_student_sign].[Lng]", typeof(decimal), 18, default(decimal));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lat =  new AttributeItem("[Xt_student_sign].[Lat]", typeof(decimal), 18, default(decimal));
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[Xt_student_sign].[City]", typeof(string), 100, default(string));
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Xt_student_sign].[Address]", typeof(string), 200, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_student_sign].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>备注:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Remark =  new AttributeItem("[Xt_student_sign].[Remark]", typeof(string), 200, default(string));
            
            /// <summary>与老师发布点名的距离:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Distance =  new AttributeItem("[Xt_student_sign].[Distance]", typeof(decimal), 18, default(decimal));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_student_sign].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>学生名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_name =  new AttributeItem("[Xt_student_sign].[Student_name]", typeof(string), 80, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_sign_id;
        /// <summary></summary>
        protected bool sign_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private decimal m_lng;
        /// <summary></summary>
        protected bool lng_initialized = false;
        
        private decimal m_lat;
        /// <summary></summary>
        protected bool lat_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_remark;
        /// <summary></summary>
        protected bool remark_initialized = false;
        
        private decimal m_distance;
        /// <summary></summary>
        protected bool distance_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_student_name;
        /// <summary></summary>
        protected bool student_name_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_sign";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.sign_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.lng_initialized = IsLoadAllAttributes;this.lat_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.remark_initialized = IsLoadAllAttributes;this.distance_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.student_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_sign value = new Xt_student_sign();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign_id"))
				value.sign_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lng"))
				value.lng_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lat"))
				value.lat_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Remark"))
				value.remark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Distance"))
				value.distance_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_name"))
				value.student_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_student_sign Clone()
        {
            return (Xt_student_sign)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_student_sign()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_student_sign() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_student_sign(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_student_sign(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_student_sign(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_student_sign(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_student_sign(Guid uuid1, string status1, string sign_id1, string course_id1, string student_id1, decimal lng1, decimal lat1, string city1, string address1, DateTime create_time1, string remark1, decimal distance1, DateTime modify_time1, string student_name1)
        {
            
            this.Uuid = uuid1;
            
            this.Status = status1;
            
            this.Sign_id = sign_id1;
            
            this.Course_id = course_id1;
            
            this.Student_id = student_id1;
            
            this.Lng = lng1;
            
            this.Lat = lat1;
            
            this.City = city1;
            
            this.Address = address1;
            
            this.Create_time = create_time1;
            
            this.Remark = remark1;
            
            this.Distance = distance1;
            
            this.Modify_time = modify_time1;
            
            this.Student_name = student_name1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_student_sign FromIView(IView view)
        {
            return (Xt_student_sign)IView.GetITable(view, "Xt_student_sign");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_student_sign GetOneInstance()
        {
            Xt_student_sign value = new Xt_student_sign();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_student_sign Retrieve()
        {
            BLLTable<Xt_student_sign>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Sign_id":
			        return Sign_id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Lng":
			        return Lng;
			    			
			    case "Lat":
			        return Lat;
			    			
			    case "City":
			        return City;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Remark":
			        return Remark;
			    			
			    case "Distance":
			        return Distance;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Student_name":
			        return Student_name;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sign_id":
			        this.Sign_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Lng":
			        this.Lng = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Lat":
			        this.Lat = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Remark":
			        this.Remark = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Distance":
			        this.Distance = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Student_name":
			        this.Student_name = Convert.ToString(AttributeValue);
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
				case "Uuid":
					return uuid_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Sign_id":
					return sign_id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Lng":
					return lng_initialized;
				
				case "Lat":
					return lat_initialized;
				
				case "City":
					return city_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Remark":
					return remark_initialized;
				
				case "Distance":
					return distance_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Student_name":
					return student_name_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Sign_id":
					sign_id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Lng":
					lng_initialized = ret;
					return true;
				
				case "Lat":
					lat_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Remark":
					remark_initialized = ret;
					return true;
				
				case "Distance":
					distance_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Student_name":
					student_name_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (sign_id_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Sign_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (lng_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Lng;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lng);
                }
			}
			
			if (lat_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Lat;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lat);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (remark_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Remark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Remark);
                }
			}
			
			if (distance_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Distance;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Distance);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (student_name_initialized)
			{
                AttributeItem attr = Xt_student_sign.Attribute.Student_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_name);
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
        public class Xt_student_signJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>状态:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>签到id:[CtrlTypeDic-{InputString}]</summary>
            public string Sign_id { get; set; }
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>学生id:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lng { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lat { get; set; }
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>备注:[CtrlTypeDic-{InputString}]</summary>
            public string Remark { get; set; }
            
            /// <summary>与老师发布点名的距离:[CtrlTypeDic-{InputString}]</summary>
            public decimal Distance { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>学生名称:[CtrlTypeDic-{InputString}]</summary>
            public string Student_name { get; set; }
        }
        #endregion
    }
}