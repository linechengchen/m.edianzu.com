/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    数据表Xt_teacher对应的业务逻辑层Xt_teacher
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_teacher_Entity:Xt_teacher
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Create_time,Id,Name,Email,Mobile,Last_login_type,Last_login_time,Modify_time,Sex,Major,College_id,Weixin_id,Real_name,Address,Head,Active,Del_tag,User_id,Certificate,Certificate_data,College_name,Is_review,Review_time,Review_people,Is_authentication from Xt_teacher
delete from Xt_teacher
INSERT INTO Xt_teacher (Uuid,Create_time,Id,Name,Email,Mobile,Last_login_type,Last_login_time,Modify_time,Sex,Major,College_id,Weixin_id,Real_name,Address,Head,Active,Del_tag,User_id,Certificate,Certificate_data,College_name,Is_review,Review_time,Review_people,Is_authentication)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xt_teacher SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Create_time = valObj2.Create_time;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Email = valObj2.Email;
        valObj.Mobile = valObj2.Mobile;
        valObj.Last_login_type = valObj2.Last_login_type;
        valObj.Last_login_time = valObj2.Last_login_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Sex = valObj2.Sex;
        valObj.Major = valObj2.Major;
        valObj.College_id = valObj2.College_id;
        valObj.Weixin_id = valObj2.Weixin_id;
        valObj.Real_name = valObj2.Real_name;
        valObj.Address = valObj2.Address;
        valObj.Head = valObj2.Head;
        valObj.Active = valObj2.Active;
        valObj.Del_tag = valObj2.Del_tag;
        valObj.User_id = valObj2.User_id;
        valObj.Certificate = valObj2.Certificate;
        valObj.Certificate_data = valObj2.Certificate_data;
        valObj.College_name = valObj2.College_name;
        valObj.Is_review = valObj2.Is_review;
        valObj.Review_time = valObj2.Review_time;
        valObj.Review_people = valObj2.Review_people;
        valObj.Is_authentication = valObj2.Is_authentication; 
        valObj.Uuid = "";
        valObj.Create_time = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Email = "";
        valObj.Mobile = "";
        valObj.Last_login_type = "";
        valObj.Last_login_time = "";
        valObj.Modify_time = "";
        valObj.Sex = "";
        valObj.Major = "";
        valObj.College_id = "";
        valObj.Weixin_id = "";
        valObj.Real_name = "";
        valObj.Address = "";
        valObj.Head = "";
        valObj.Active = "";
        valObj.Del_tag = "";
        valObj.User_id = "";
        valObj.Certificate = "";
        valObj.Certificate_data = "";
        valObj.College_name = "";
        valObj.Is_review = "";
        valObj.Review_time = "";
        valObj.Review_people = "";
        valObj.Is_authentication = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Email": $("#txt_Email").val(),
        "Mobile": $("#txt_Mobile").val(),
        "Last_login_type": $("#txt_Last_login_type").val(),
        "Last_login_time": $("#txt_Last_login_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Sex": $("#txt_Sex").val(),
        "Major": $("#txt_Major").val(),
        "College_id": $("#txt_College_id").val(),
        "Weixin_id": $("#txt_Weixin_id").val(),
        "Real_name": $("#txt_Real_name").val(),
        "Address": $("#txt_Address").val(),
        "Head": $("#txt_Head").val(),
        "Active": $("#txt_Active").val(),
        "Del_tag": $("#txt_Del_tag").val(),
        "User_id": $("#txt_User_id").val(),
        "Certificate": $("#txt_Certificate").val(),
        "Certificate_data": $("#txt_Certificate_data").val(),
        "College_name": $("#txt_College_name").val(),
        "Is_review": $("#txt_Is_review").val(),
        "Review_time": $("#txt_Review_time").val(),
        "Review_people": $("#txt_Review_people").val(),
        "Is_authentication": $("#txt_Is_authentication").val(), 
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
    /// <para>老师用户信息表</para>
    /// <para>与Xt_teacher数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_teacher : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_teacher Factory()
        {
            return new Xt_teacher();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 昵称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 邮箱:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> 手机:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Mobile
        {            
            get { return this.Mobile; }
            set { this.Mobile = value; }
        }
        
        /// <summary> 最后登录状态:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Last_login_type
        {            
            get { return this.Last_login_type; }
            set { this.Last_login_type = value; }
        }
        
        /// <summary> 最后登录时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Last_login_time
        {            
            get { return this.Last_login_time; }
            set { this.Last_login_time = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> 性别:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> 专业:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
        }
        
        /// <summary> 大学id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_id
        {            
            get { return this.College_id; }
            set { this.College_id = value; }
        }
        
        /// <summary> 微信id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weixin_id
        {            
            get { return this.Weixin_id; }
            set { this.Weixin_id = value; }
        }
        
        /// <summary> 真实姓名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Real_name
        {            
            get { return this.Real_name; }
            set { this.Real_name = value; }
        }
        
        /// <summary> 地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> 头像:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Head
        {            
            get { return this.Head; }
            set { this.Head = value; }
        }
        
        /// <summary> 活跃:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Active
        {            
            get { return this.Active; }
            set { this.Active = value; }
        }
        
        /// <summary> 删除标签:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Del_tag
        {            
            get { return this.Del_tag; }
            set { this.Del_tag = value; }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 证书url:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Certificate
        {            
            get { return this.Certificate; }
            set { this.Certificate = value; }
        }
        
        /// <summary> 证书数据:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Certificate_data
        {            
            get { return this.Certificate_data; }
            set { this.Certificate_data = value; }
        }
        
        /// <summary> 大学名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_name
        {            
            get { return this.College_name; }
            set { this.College_name = value; }
        }
        
        /// <summary> 是否认证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_review
        {            
            get { return this.Is_review; }
            set { this.Is_review = value; }
        }
        
        /// <summary> 认证时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Review_time
        {            
            get { return this.Review_time; }
            set { this.Review_time = value; }
        }
        
        /// <summary> 认证人:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Review_people
        {            
            get { return this.Review_people; }
            set { this.Review_people = value; }
        }
        
        /// <summary> 是否认证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_authentication
        {            
            get { return this.Is_authentication; }
            set { this.Is_authentication = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Id
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
        
        /// <summary> 昵称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 邮箱:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Email
        {
            get { return this.m_email; }
            set //
            {
                if (!email_initialized || m_email != value)
                {
                    this.m_email = value;
                }
                email_initialized = true;
            }
        }
        
        /// <summary> 手机:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Mobile
        {
            get { return this.m_mobile; }
            set //
            {
                if (!mobile_initialized || m_mobile != value)
                {
                    this.m_mobile = value;
                }
                mobile_initialized = true;
            }
        }
        
        /// <summary> 最后登录状态:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Last_login_type
        {
            get { return this.m_last_login_type; }
            set //
            {
                if (!last_login_type_initialized || m_last_login_type != value)
                {
                    this.m_last_login_type = value;
                }
                last_login_type_initialized = true;
            }
        }
        
        /// <summary> 最后登录时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Last_login_time
        {
            get { return this.m_last_login_time; }
            set //
            {
                if (!last_login_time_initialized || m_last_login_time != value)
                {
                    this.m_last_login_time = value;
                }
                last_login_time_initialized = true;
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
        
        /// <summary> 性别:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> 专业:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Major
        {
            get { return this.m_major; }
            set //
            {
                if (!major_initialized || m_major != value)
                {
                    this.m_major = value;
                }
                major_initialized = true;
            }
        }
        
        /// <summary> 大学id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string College_id
        {
            get { return this.m_college_id; }
            set //
            {
                if (!college_id_initialized || m_college_id != value)
                {
                    this.m_college_id = value;
                }
                college_id_initialized = true;
            }
        }
        
        /// <summary> 微信id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Weixin_id
        {
            get { return this.m_weixin_id; }
            set //
            {
                if (!weixin_id_initialized || m_weixin_id != value)
                {
                    this.m_weixin_id = value;
                }
                weixin_id_initialized = true;
            }
        }
        
        /// <summary> 真实姓名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Real_name
        {
            get { return this.m_real_name; }
            set //
            {
                if (!real_name_initialized || m_real_name != value)
                {
                    this.m_real_name = value;
                }
                real_name_initialized = true;
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
        
        /// <summary> 头像:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Head
        {
            get { return this.m_head; }
            set //
            {
                if (!head_initialized || m_head != value)
                {
                    this.m_head = value;
                }
                head_initialized = true;
            }
        }
        
        /// <summary> 活跃:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Active
        {
            get { return this.m_active; }
            set //
            {
                if (!active_initialized || m_active != value)
                {
                    this.m_active = value;
                }
                active_initialized = true;
            }
        }
        
        /// <summary> 删除标签:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Del_tag
        {
            get { return this.m_del_tag; }
            set //
            {
                if (!del_tag_initialized || m_del_tag != value)
                {
                    this.m_del_tag = value;
                }
                del_tag_initialized = true;
            }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 证书url:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Certificate
        {
            get { return this.m_certificate; }
            set //
            {
                if (!certificate_initialized || m_certificate != value)
                {
                    this.m_certificate = value;
                }
                certificate_initialized = true;
            }
        }
        
        /// <summary> 证书数据:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Certificate_data
        {
            get { return this.m_certificate_data; }
            set //
            {
                if (!certificate_data_initialized || m_certificate_data != value)
                {
                    this.m_certificate_data = value;
                }
                certificate_data_initialized = true;
            }
        }
        
        /// <summary> 大学名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string College_name
        {
            get { return this.m_college_name; }
            set //
            {
                if (!college_name_initialized || m_college_name != value)
                {
                    this.m_college_name = value;
                }
                college_name_initialized = true;
            }
        }
        
        /// <summary> 是否认证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_review
        {
            get { return this.m_is_review; }
            set //
            {
                if (!is_review_initialized || m_is_review != value)
                {
                    this.m_is_review = value;
                }
                is_review_initialized = true;
            }
        }
        
        /// <summary> 认证时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Review_time
        {
            get { return this.m_review_time; }
            set //
            {
                if (!review_time_initialized || m_review_time != value)
                {
                    this.m_review_time = value;
                }
                review_time_initialized = true;
            }
        }
        
        /// <summary> 认证人:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Review_people
        {
            get { return this.m_review_people; }
            set //
            {
                if (!review_people_initialized || m_review_people != value)
                {
                    this.m_review_people = value;
                }
                review_people_initialized = true;
            }
        }
        
        /// <summary> 是否认证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_authentication
        {
            get { return this.m_is_authentication; }
            set //
            {
                if (!is_authentication_initialized || m_is_authentication != value)
                {
                    this.m_is_authentication = value;
                }
                is_authentication_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_teacher].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_teacher].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_teacher].[Id]", typeof(string), 36, default(string));
            
            /// <summary>昵称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xt_teacher].[Name]", typeof(string), 100, default(string));
            
            /// <summary>邮箱:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Email =  new AttributeItem("[Xt_teacher].[Email]", typeof(string), 100, default(string));
            
            /// <summary>手机:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mobile =  new AttributeItem("[Xt_teacher].[Mobile]", typeof(string), 15, default(string));
            
            /// <summary>最后登录状态:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Last_login_type =  new AttributeItem("[Xt_teacher].[Last_login_type]", typeof(string), 1, default(string));
            
            /// <summary>最后登录时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Last_login_time =  new AttributeItem("[Xt_teacher].[Last_login_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_teacher].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>性别:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xt_teacher].[Sex]", typeof(string), 1, default(string));
            
            /// <summary>专业:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Major =  new AttributeItem("[Xt_teacher].[Major]", typeof(string), 100, default(string));
            
            /// <summary>大学id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_id =  new AttributeItem("[Xt_teacher].[College_id]", typeof(string), 36, default(string));
            
            /// <summary>微信id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weixin_id =  new AttributeItem("[Xt_teacher].[Weixin_id]", typeof(string), 36, default(string));
            
            /// <summary>真实姓名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Real_name =  new AttributeItem("[Xt_teacher].[Real_name]", typeof(string), 100, default(string));
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Xt_teacher].[Address]", typeof(string), 100, default(string));
            
            /// <summary>头像:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Head =  new AttributeItem("[Xt_teacher].[Head]", typeof(string), -1, default(string));
            
            /// <summary>活跃:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Active =  new AttributeItem("[Xt_teacher].[Active]", typeof(string), 100, default(string));
            
            /// <summary>删除标签:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Del_tag =  new AttributeItem("[Xt_teacher].[Del_tag]", typeof(string), 1, default(string));
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_teacher].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>证书url:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Certificate =  new AttributeItem("[Xt_teacher].[Certificate]", typeof(string), 200, default(string));
            
            /// <summary>证书数据:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Certificate_data =  new AttributeItem("[Xt_teacher].[Certificate_data]", typeof(string), 16, default(string));
            
            /// <summary>大学名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_name =  new AttributeItem("[Xt_teacher].[College_name]", typeof(string), 100, default(string));
            
            /// <summary>是否认证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_review =  new AttributeItem("[Xt_teacher].[Is_review]", typeof(string), 1, default(string));
            
            /// <summary>认证时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Review_time =  new AttributeItem("[Xt_teacher].[Review_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>认证人:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Review_people =  new AttributeItem("[Xt_teacher].[Review_people]", typeof(string), 36, default(string));
            
            /// <summary>是否认证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_authentication =  new AttributeItem("[Xt_teacher].[Is_authentication]", typeof(string), 1, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private string m_mobile;
        /// <summary></summary>
        protected bool mobile_initialized = false;
        
        private string m_last_login_type;
        /// <summary></summary>
        protected bool last_login_type_initialized = false;
        
        private DateTime m_last_login_time;
        /// <summary></summary>
        protected bool last_login_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
        private string m_college_id;
        /// <summary></summary>
        protected bool college_id_initialized = false;
        
        private string m_weixin_id;
        /// <summary></summary>
        protected bool weixin_id_initialized = false;
        
        private string m_real_name;
        /// <summary></summary>
        protected bool real_name_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private string m_head;
        /// <summary></summary>
        protected bool head_initialized = false;
        
        private string m_active;
        /// <summary></summary>
        protected bool active_initialized = false;
        
        private string m_del_tag;
        /// <summary></summary>
        protected bool del_tag_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_certificate;
        /// <summary></summary>
        protected bool certificate_initialized = false;
        
        private string m_certificate_data;
        /// <summary></summary>
        protected bool certificate_data_initialized = false;
        
        private string m_college_name;
        /// <summary></summary>
        protected bool college_name_initialized = false;
        
        private string m_is_review;
        /// <summary></summary>
        protected bool is_review_initialized = false;
        
        private DateTime m_review_time;
        /// <summary></summary>
        protected bool review_time_initialized = false;
        
        private string m_review_people;
        /// <summary></summary>
        protected bool review_people_initialized = false;
        
        private string m_is_authentication;
        /// <summary></summary>
        protected bool is_authentication_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_teacher";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.mobile_initialized = IsLoadAllAttributes;this.last_login_type_initialized = IsLoadAllAttributes;this.last_login_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.college_id_initialized = IsLoadAllAttributes;this.weixin_id_initialized = IsLoadAllAttributes;this.real_name_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.head_initialized = IsLoadAllAttributes;this.active_initialized = IsLoadAllAttributes;this.del_tag_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.certificate_initialized = IsLoadAllAttributes;this.certificate_data_initialized = IsLoadAllAttributes;this.college_name_initialized = IsLoadAllAttributes;this.is_review_initialized = IsLoadAllAttributes;this.review_time_initialized = IsLoadAllAttributes;this.review_people_initialized = IsLoadAllAttributes;this.is_authentication_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_teacher value = new Xt_teacher();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mobile"))
				value.mobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Last_login_type"))
				value.last_login_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Last_login_time"))
				value.last_login_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_id"))
				value.college_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weixin_id"))
				value.weixin_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Real_name"))
				value.real_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Head"))
				value.head_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Active"))
				value.active_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Del_tag"))
				value.del_tag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Certificate"))
				value.certificate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Certificate_data"))
				value.certificate_data_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_name"))
				value.college_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_review"))
				value.is_review_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Review_time"))
				value.review_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Review_people"))
				value.review_people_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_authentication"))
				value.is_authentication_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_teacher Clone()
        {
            return (Xt_teacher)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_teacher()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_teacher() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_teacher(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_teacher(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_teacher(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_teacher(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_teacher(Guid uuid1, DateTime create_time1, string id1, string name1, string email1, string mobile1, string last_login_type1, DateTime last_login_time1, DateTime modify_time1, string sex1, string major1, string college_id1, string weixin_id1, string real_name1, string address1, string head1, string active1, string del_tag1, string user_id1, string certificate1, string certificate_data1, string college_name1, string is_review1, DateTime review_time1, string review_people1, string is_authentication1)
        {
            
            this.Uuid = uuid1;
            
            this.Create_time = create_time1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Email = email1;
            
            this.Mobile = mobile1;
            
            this.Last_login_type = last_login_type1;
            
            this.Last_login_time = last_login_time1;
            
            this.Modify_time = modify_time1;
            
            this.Sex = sex1;
            
            this.Major = major1;
            
            this.College_id = college_id1;
            
            this.Weixin_id = weixin_id1;
            
            this.Real_name = real_name1;
            
            this.Address = address1;
            
            this.Head = head1;
            
            this.Active = active1;
            
            this.Del_tag = del_tag1;
            
            this.User_id = user_id1;
            
            this.Certificate = certificate1;
            
            this.Certificate_data = certificate_data1;
            
            this.College_name = college_name1;
            
            this.Is_review = is_review1;
            
            this.Review_time = review_time1;
            
            this.Review_people = review_people1;
            
            this.Is_authentication = is_authentication1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_teacher FromIView(IView view)
        {
            return (Xt_teacher)IView.GetITable(view, "Xt_teacher");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_teacher GetOneInstance()
        {
            Xt_teacher value = new Xt_teacher();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_teacher Retrieve()
        {
            BLLTable<Xt_teacher>.GetRowData(this);
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
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Email":
			        return Email;
			    			
			    case "Mobile":
			        return Mobile;
			    			
			    case "Last_login_type":
			        return Last_login_type;
			    			
			    case "Last_login_time":
			        return Last_login_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "Major":
			        return Major;
			    			
			    case "College_id":
			        return College_id;
			    			
			    case "Weixin_id":
			        return Weixin_id;
			    			
			    case "Real_name":
			        return Real_name;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Head":
			        return Head;
			    			
			    case "Active":
			        return Active;
			    			
			    case "Del_tag":
			        return Del_tag;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Certificate":
			        return Certificate;
			    			
			    case "Certificate_data":
			        return Certificate_data;
			    			
			    case "College_name":
			        return College_name;
			    			
			    case "Is_review":
			        return Is_review;
			    			
			    case "Review_time":
			        return Review_time;
			    			
			    case "Review_people":
			        return Review_people;
			    			
			    case "Is_authentication":
			        return Is_authentication;
			
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
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mobile":
			        this.Mobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Last_login_type":
			        this.Last_login_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Last_login_time":
			        this.Last_login_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_id":
			        this.College_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weixin_id":
			        this.Weixin_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Real_name":
			        this.Real_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Head":
			        this.Head = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Active":
			        this.Active = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Del_tag":
			        this.Del_tag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Certificate":
			        this.Certificate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Certificate_data":
			        this.Certificate_data = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_name":
			        this.College_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_review":
			        this.Is_review = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Review_time":
			        this.Review_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Review_people":
			        this.Review_people = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_authentication":
			        this.Is_authentication = Convert.ToString(AttributeValue);
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
				
				case "Create_time":
					return create_time_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Email":
					return email_initialized;
				
				case "Mobile":
					return mobile_initialized;
				
				case "Last_login_type":
					return last_login_type_initialized;
				
				case "Last_login_time":
					return last_login_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "Major":
					return major_initialized;
				
				case "College_id":
					return college_id_initialized;
				
				case "Weixin_id":
					return weixin_id_initialized;
				
				case "Real_name":
					return real_name_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Head":
					return head_initialized;
				
				case "Active":
					return active_initialized;
				
				case "Del_tag":
					return del_tag_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Certificate":
					return certificate_initialized;
				
				case "Certificate_data":
					return certificate_data_initialized;
				
				case "College_name":
					return college_name_initialized;
				
				case "Is_review":
					return is_review_initialized;
				
				case "Review_time":
					return review_time_initialized;
				
				case "Review_people":
					return review_people_initialized;
				
				case "Is_authentication":
					return is_authentication_initialized;
				
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
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "Mobile":
					mobile_initialized = ret;
					return true;
				
				case "Last_login_type":
					last_login_type_initialized = ret;
					return true;
				
				case "Last_login_time":
					last_login_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
					return true;
				
				case "College_id":
					college_id_initialized = ret;
					return true;
				
				case "Weixin_id":
					weixin_id_initialized = ret;
					return true;
				
				case "Real_name":
					real_name_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Head":
					head_initialized = ret;
					return true;
				
				case "Active":
					active_initialized = ret;
					return true;
				
				case "Del_tag":
					del_tag_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Certificate":
					certificate_initialized = ret;
					return true;
				
				case "Certificate_data":
					certificate_data_initialized = ret;
					return true;
				
				case "College_name":
					college_name_initialized = ret;
					return true;
				
				case "Is_review":
					is_review_initialized = ret;
					return true;
				
				case "Review_time":
					review_time_initialized = ret;
					return true;
				
				case "Review_people":
					review_people_initialized = ret;
					return true;
				
				case "Is_authentication":
					is_authentication_initialized = ret;
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
                AttributeItem attr = Xt_teacher.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (mobile_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Mobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mobile);
                }
			}
			
			if (last_login_type_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Last_login_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Last_login_type);
                }
			}
			
			if (last_login_time_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Last_login_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Last_login_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (college_id_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.College_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_id);
                }
			}
			
			if (weixin_id_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Weixin_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weixin_id);
                }
			}
			
			if (real_name_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Real_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Real_name);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (head_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Head;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Head);
                }
			}
			
			if (active_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Active;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Active);
                }
			}
			
			if (del_tag_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Del_tag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Del_tag);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (certificate_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Certificate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Certificate);
                }
			}
			
			if (certificate_data_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Certificate_data;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Certificate_data);
                }
			}
			
			if (college_name_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.College_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_name);
                }
			}
			
			if (is_review_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Is_review;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_review);
                }
			}
			
			if (review_time_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Review_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Review_time);
                }
			}
			
			if (review_people_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Review_people;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Review_people);
                }
			}
			
			if (is_authentication_initialized)
			{
                AttributeItem attr = Xt_teacher.Attribute.Is_authentication;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_authentication);
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
        public class Xt_teacherJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>昵称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>邮箱:[CtrlTypeDic-{InputString}]</summary>
            public string Email { get; set; }
            
            /// <summary>手机:[CtrlTypeDic-{InputString}]</summary>
            public string Mobile { get; set; }
            
            /// <summary>最后登录状态:[CtrlTypeDic-{InputString}]</summary>
            public string Last_login_type { get; set; }
            
            /// <summary>最后登录时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Last_login_time { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>性别:[CtrlTypeDic-{InputString}]</summary>
            public string Sex { get; set; }
            
            /// <summary>专业:[CtrlTypeDic-{InputString}]</summary>
            public string Major { get; set; }
            
            /// <summary>大学id:[CtrlTypeDic-{InputString}]</summary>
            public string College_id { get; set; }
            
            /// <summary>微信id:[CtrlTypeDic-{InputString}]</summary>
            public string Weixin_id { get; set; }
            
            /// <summary>真实姓名:[CtrlTypeDic-{InputString}]</summary>
            public string Real_name { get; set; }
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>头像:[CtrlTypeDic-{InputString}]</summary>
            public string Head { get; set; }
            
            /// <summary>活跃:[CtrlTypeDic-{InputString}]</summary>
            public string Active { get; set; }
            
            /// <summary>删除标签:[CtrlTypeDic-{InputString}]</summary>
            public string Del_tag { get; set; }
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>证书url:[CtrlTypeDic-{InputString}]</summary>
            public string Certificate { get; set; }
            
            /// <summary>证书数据:[CtrlTypeDic-{InputString}]</summary>
            public string Certificate_data { get; set; }
            
            /// <summary>大学名称:[CtrlTypeDic-{InputString}]</summary>
            public string College_name { get; set; }
            
            /// <summary>是否认证:[CtrlTypeDic-{InputString}]</summary>
            public string Is_review { get; set; }
            
            /// <summary>认证时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Review_time { get; set; }
            
            /// <summary>认证人:[CtrlTypeDic-{InputString}]</summary>
            public string Review_people { get; set; }
            
            /// <summary>是否认证:[CtrlTypeDic-{InputString}]</summary>
            public string Is_authentication { get; set; }
        }
        #endregion
    }
}