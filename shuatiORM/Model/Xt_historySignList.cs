/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    数据表Xt_historySignList对应的业务逻辑层Xt_historySignList
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_historySignList_Entity:Xt_historySignList
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Uuid,CreateTime,Status,Info,T,Token,ModifyTime,User_id,Classes_id,Title,Lng,Lat,City,Address,Checkin_number,Create_time,Finish_status,Finish_time,Sign,Username from Xt_historySignList
delete from Xt_historySignList
INSERT INTO Xt_historySignList (Id,Uuid,CreateTime,Status,Info,T,Token,ModifyTime,User_id,Classes_id,Title,Lng,Lat,City,Address,Checkin_number,Create_time,Finish_status,Finish_time,Sign,Username)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','')
UPDATE Xt_historySignList SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Status = valObj2.Status;
        valObj.Info = valObj2.Info;
        valObj.T = valObj2.T;
        valObj.Token = valObj2.Token;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.Classes_id = valObj2.Classes_id;
        valObj.Title = valObj2.Title;
        valObj.Lng = valObj2.Lng;
        valObj.Lat = valObj2.Lat;
        valObj.City = valObj2.City;
        valObj.Address = valObj2.Address;
        valObj.Checkin_number = valObj2.Checkin_number;
        valObj.Create_time = valObj2.Create_time;
        valObj.Finish_status = valObj2.Finish_status;
        valObj.Finish_time = valObj2.Finish_time;
        valObj.Sign = valObj2.Sign;
        valObj.Username = valObj2.Username; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.Status = "";
        valObj.Info = "";
        valObj.T = "";
        valObj.Token = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.Classes_id = "";
        valObj.Title = "";
        valObj.Lng = "";
        valObj.Lat = "";
        valObj.City = "";
        valObj.Address = "";
        valObj.Checkin_number = "";
        valObj.Create_time = "";
        valObj.Finish_status = "";
        valObj.Finish_time = "";
        valObj.Sign = "";
        valObj.Username = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Status": $("#txt_Status").val(),
        "Info": $("#txt_Info").val(),
        "T": $("#txt_T").val(),
        "Token": $("#txt_Token").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(),
        "Classes_id": $("#txt_Classes_id").val(),
        "Title": $("#txt_Title").val(),
        "Lng": $("#txt_Lng").val(),
        "Lat": $("#txt_Lat").val(),
        "City": $("#txt_City").val(),
        "Address": $("#txt_Address").val(),
        "Checkin_number": $("#txt_Checkin_number").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Finish_status": $("#txt_Finish_status").val(),
        "Finish_time": $("#txt_Finish_time").val(),
        "Sign": $("#txt_Sign").val(),
        "Username": $("#txt_Username").val(), 
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
    /// <para>历史签到表</para>
    /// <para>与Xt_historySignList数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_historySignList : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_historySignList Factory()
        {
            return new Xt_historySignList();
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
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 状态:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Info
        {            
            get { return this.Info; }
            set { this.Info = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _T
        {            
            get { return this.T; }
            set { this.T = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Token
        {            
            get { return this.Token; }
            set { this.Token = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Classes_id
        {            
            get { return this.Classes_id; }
            set { this.Classes_id = value; }
        }
        
        /// <summary> 主题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Checkin_number
        {            
            get { return this.Checkin_number; }
            set { this.Checkin_number = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 結束状态:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Finish_status
        {            
            get { return this.Finish_status; }
            set { this.Finish_status = value; }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Finish_time
        {            
            get { return this.Finish_time; }
            set { this.Finish_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Sign
        {            
            get { return this.Sign; }
            set { this.Sign = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Username
        {            
            get { return this.Username; }
            set { this.Username = value; }
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
        
        /// <summary> 状态:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Status
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Info
        {
            get { return this.m_info; }
            set //
            {
                if (!info_initialized || m_info != value)
                {
                    this.m_info = value;
                }
                info_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int T
        {
            get { return this.m_t; }
            set //
            {
                if (!t_initialized || m_t != value)
                {
                    this.m_t = value;
                }
                t_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Token
        {
            get { return this.m_token; }
            set //
            {
                if (!token_initialized || m_token != value)
                {
                    this.m_token = value;
                }
                token_initialized = true;
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
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Classes_id
        {
            get { return this.m_classes_id; }
            set //
            {
                if (!classes_id_initialized || m_classes_id != value)
                {
                    this.m_classes_id = value;
                }
                classes_id_initialized = true;
            }
        }
        
        /// <summary> 主题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Checkin_number
        {
            get { return this.m_checkin_number; }
            set //
            {
                if (!checkin_number_initialized || m_checkin_number != value)
                {
                    this.m_checkin_number = value;
                }
                checkin_number_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Create_time
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
        
        /// <summary> 結束状态:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Finish_status
        {
            get { return this.m_finish_status; }
            set //
            {
                if (!finish_status_initialized || m_finish_status != value)
                {
                    this.m_finish_status = value;
                }
                finish_status_initialized = true;
            }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Finish_time
        {
            get { return this.m_finish_time; }
            set //
            {
                if (!finish_time_initialized || m_finish_time != value)
                {
                    this.m_finish_time = value;
                }
                finish_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Sign
        {
            get { return this.m_sign; }
            set //
            {
                if (!sign_initialized || m_sign != value)
                {
                    this.m_sign = value;
                }
                sign_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Username
        {
            get { return this.m_username; }
            set //
            {
                if (!username_initialized || m_username != value)
                {
                    this.m_username = value;
                }
                username_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xt_historySignList].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_historySignList].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xt_historySignList].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>状态:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xt_historySignList].[Status]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Info =  new AttributeItem("[Xt_historySignList].[Info]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem T =  new AttributeItem("[Xt_historySignList].[T]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Token =  new AttributeItem("[Xt_historySignList].[Token]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xt_historySignList].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_historySignList].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Classes_id =  new AttributeItem("[Xt_historySignList].[Classes_id]", typeof(decimal), 18, default(decimal));
            
            /// <summary>主题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_historySignList].[Title]", typeof(string), 100, default(string));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lng =  new AttributeItem("[Xt_historySignList].[Lng]", typeof(decimal), 18, default(decimal));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lat =  new AttributeItem("[Xt_historySignList].[Lat]", typeof(decimal), 18, default(decimal));
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[Xt_historySignList].[City]", typeof(string), 100, default(string));
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Xt_historySignList].[Address]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Checkin_number =  new AttributeItem("[Xt_historySignList].[Checkin_number]", typeof(decimal), 18, default(decimal));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_historySignList].[Create_time]", typeof(decimal), 18, default(decimal));
            
            /// <summary>結束状态:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Finish_status =  new AttributeItem("[Xt_historySignList].[Finish_status]", typeof(decimal), 18, default(decimal));
            
            /// <summary>结束时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Finish_time =  new AttributeItem("[Xt_historySignList].[Finish_time]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sign =  new AttributeItem("[Xt_historySignList].[Sign]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Username =  new AttributeItem("[Xt_historySignList].[Username]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private bool m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_info;
        /// <summary></summary>
        protected bool info_initialized = false;
        
        private int m_t;
        /// <summary></summary>
        protected bool t_initialized = false;
        
        private Guid m_token;
        /// <summary></summary>
        protected bool token_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private decimal m_classes_id;
        /// <summary></summary>
        protected bool classes_id_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
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
        
        private decimal m_checkin_number;
        /// <summary></summary>
        protected bool checkin_number_initialized = false;
        
        private decimal m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private decimal m_finish_status;
        /// <summary></summary>
        protected bool finish_status_initialized = false;
        
        private decimal m_finish_time;
        /// <summary></summary>
        protected bool finish_time_initialized = false;
        
        private int m_sign;
        /// <summary></summary>
        protected bool sign_initialized = false;
        
        private string m_username;
        /// <summary></summary>
        protected bool username_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_historySignList";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.info_initialized = IsLoadAllAttributes;this.t_initialized = IsLoadAllAttributes;this.token_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.classes_id_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.lng_initialized = IsLoadAllAttributes;this.lat_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.checkin_number_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.finish_status_initialized = IsLoadAllAttributes;this.finish_time_initialized = IsLoadAllAttributes;this.sign_initialized = IsLoadAllAttributes;this.username_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_historySignList value = new Xt_historySignList();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Info"))
				value.info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"T"))
				value.t_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Token"))
				value.token_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Classes_id"))
				value.classes_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lng"))
				value.lng_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lat"))
				value.lat_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Checkin_number"))
				value.checkin_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Finish_status"))
				value.finish_status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Finish_time"))
				value.finish_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign"))
				value.sign_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Username"))
				value.username_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_historySignList Clone()
        {
            return (Xt_historySignList)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_historySignList()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_historySignList() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_historySignList(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_historySignList(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_historySignList(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_historySignList(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_historySignList(int id1, Guid uuid1, DateTime createtime1, bool status1, string info1, int t1, Guid token1, DateTime modifytime1, Guid user_id1, decimal classes_id1, string title1, decimal lng1, decimal lat1, string city1, string address1, decimal checkin_number1, decimal create_time1, decimal finish_status1, decimal finish_time1, int sign1, string username1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.Status = status1;
            
            this.Info = info1;
            
            this.T = t1;
            
            this.Token = token1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.Classes_id = classes_id1;
            
            this.Title = title1;
            
            this.Lng = lng1;
            
            this.Lat = lat1;
            
            this.City = city1;
            
            this.Address = address1;
            
            this.Checkin_number = checkin_number1;
            
            this.Create_time = create_time1;
            
            this.Finish_status = finish_status1;
            
            this.Finish_time = finish_time1;
            
            this.Sign = sign1;
            
            this.Username = username1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_historySignList FromIView(IView view)
        {
            return (Xt_historySignList)IView.GetITable(view, "Xt_historySignList");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_historySignList GetOneInstance()
        {
            Xt_historySignList value = new Xt_historySignList();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_historySignList Retrieve()
        {
            BLLTable<Xt_historySignList>.GetRowData(this);
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
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Info":
			        return Info;
			    			
			    case "T":
			        return T;
			    			
			    case "Token":
			        return Token;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Classes_id":
			        return Classes_id;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Lng":
			        return Lng;
			    			
			    case "Lat":
			        return Lat;
			    			
			    case "City":
			        return City;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Checkin_number":
			        return Checkin_number;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Finish_status":
			        return Finish_status;
			    			
			    case "Finish_time":
			        return Finish_time;
			    			
			    case "Sign":
			        return Sign;
			    			
			    case "Username":
			        return Username;
			
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
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Info":
			        this.Info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "T":
			        this.T = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Token":
			        this.Token = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Classes_id":
			        this.Classes_id = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
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
			    			
			    case "Checkin_number":
			        this.Checkin_number = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Finish_status":
			        this.Finish_status = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Finish_time":
			        this.Finish_time = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Sign":
			        this.Sign = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Username":
			        this.Username = Convert.ToString(AttributeValue);
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
				
				case "Uuid":
					return uuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Info":
					return info_initialized;
				
				case "T":
					return t_initialized;
				
				case "Token":
					return token_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Classes_id":
					return classes_id_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Lng":
					return lng_initialized;
				
				case "Lat":
					return lat_initialized;
				
				case "City":
					return city_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Checkin_number":
					return checkin_number_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Finish_status":
					return finish_status_initialized;
				
				case "Finish_time":
					return finish_time_initialized;
				
				case "Sign":
					return sign_initialized;
				
				case "Username":
					return username_initialized;
				
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
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Info":
					info_initialized = ret;
					return true;
				
				case "T":
					t_initialized = ret;
					return true;
				
				case "Token":
					token_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Classes_id":
					classes_id_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
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
				
				case "Checkin_number":
					checkin_number_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Finish_status":
					finish_status_initialized = ret;
					return true;
				
				case "Finish_time":
					finish_time_initialized = ret;
					return true;
				
				case "Sign":
					sign_initialized = ret;
					return true;
				
				case "Username":
					username_initialized = ret;
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
                AttributeItem attr = Xt_historySignList.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (info_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Info);
                }
			}
			
			if (t_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.T;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(T);
                }
			}
			
			if (token_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Token;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Token);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (classes_id_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Classes_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Classes_id);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (lng_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Lng;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lng);
                }
			}
			
			if (lat_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Lat;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lat);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (checkin_number_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Checkin_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Checkin_number);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (finish_status_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Finish_status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Finish_status);
                }
			}
			
			if (finish_time_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Finish_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Finish_time);
                }
			}
			
			if (sign_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Sign;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign);
                }
			}
			
			if (username_initialized)
			{
                AttributeItem attr = Xt_historySignList.Attribute.Username;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Username);
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
        public class Xt_historySignListJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>状态:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Status { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Info { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int T { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Token { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public decimal Classes_id { get; set; }
            
            /// <summary>主题:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lng { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lat { get; set; }
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Checkin_number { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputString}]</summary>
            public decimal Create_time { get; set; }
            
            /// <summary>結束状态:[CtrlTypeDic-{InputString}]</summary>
            public decimal Finish_status { get; set; }
            
            /// <summary>结束时间:[CtrlTypeDic-{InputString}]</summary>
            public decimal Finish_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Sign { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Username { get; set; }
        }
        #endregion
    }
}