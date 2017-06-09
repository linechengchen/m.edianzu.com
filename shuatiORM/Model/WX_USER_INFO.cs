/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/5 20:26:11
  Description:    数据表WX_USER_INFO对应的业务逻辑层WX_USER_INFO
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 WX_USER_INFO_Entity:WX_USER_INFO
 * 
************************************************************/
/************************************************************
SQL代码：
select ID,Appid,AuthSession3rd,AuthSessionKey,City,Country,CreateTime,Groupid,Head_img_url,Language,Nick_name,Openid,Phone_number,Province,RedirectUrl,Ref_id,Remark,Rmrk3,Sc,ScName,Sex,SourceId,Subscribe,Subscribe_time,Unionid,User_id,User_type from WX_USER_INFO
delete from WX_USER_INFO
INSERT INTO WX_USER_INFO (ID,Appid,AuthSession3rd,AuthSessionKey,City,Country,CreateTime,Groupid,Head_img_url,Language,Nick_name,Openid,Phone_number,Province,RedirectUrl,Ref_id,Remark,Rmrk3,Sc,ScName,Sex,SourceId,Subscribe,Subscribe_time,Unionid,User_id,User_type)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE WX_USER_INFO SET ...
变量赋值代码：
 *         valObj.ID = valObj2.ID;
        valObj.Appid = valObj2.Appid;
        valObj.AuthSession3rd = valObj2.AuthSession3rd;
        valObj.AuthSessionKey = valObj2.AuthSessionKey;
        valObj.City = valObj2.City;
        valObj.Country = valObj2.Country;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Groupid = valObj2.Groupid;
        valObj.Head_img_url = valObj2.Head_img_url;
        valObj.Language = valObj2.Language;
        valObj.Nick_name = valObj2.Nick_name;
        valObj.Openid = valObj2.Openid;
        valObj.Phone_number = valObj2.Phone_number;
        valObj.Province = valObj2.Province;
        valObj.RedirectUrl = valObj2.RedirectUrl;
        valObj.Ref_id = valObj2.Ref_id;
        valObj.Remark = valObj2.Remark;
        valObj.Rmrk3 = valObj2.Rmrk3;
        valObj.Sc = valObj2.Sc;
        valObj.ScName = valObj2.ScName;
        valObj.Sex = valObj2.Sex;
        valObj.SourceId = valObj2.SourceId;
        valObj.Subscribe = valObj2.Subscribe;
        valObj.Subscribe_time = valObj2.Subscribe_time;
        valObj.Unionid = valObj2.Unionid;
        valObj.User_id = valObj2.User_id;
        valObj.User_type = valObj2.User_type; 
        valObj.ID = "";
        valObj.Appid = "";
        valObj.AuthSession3rd = "";
        valObj.AuthSessionKey = "";
        valObj.City = "";
        valObj.Country = "";
        valObj.CreateTime = "";
        valObj.Groupid = "";
        valObj.Head_img_url = "";
        valObj.Language = "";
        valObj.Nick_name = "";
        valObj.Openid = "";
        valObj.Phone_number = "";
        valObj.Province = "";
        valObj.RedirectUrl = "";
        valObj.Ref_id = "";
        valObj.Remark = "";
        valObj.Rmrk3 = "";
        valObj.Sc = "";
        valObj.ScName = "";
        valObj.Sex = "";
        valObj.SourceId = "";
        valObj.Subscribe = "";
        valObj.Subscribe_time = "";
        valObj.Unionid = "";
        valObj.User_id = "";
        valObj.User_type = ""; 
        "ID": $("#txt_ID").val(),
        "Appid": $("#txt_Appid").val(),
        "AuthSession3rd": $("#txt_AuthSession3rd").val(),
        "AuthSessionKey": $("#txt_AuthSessionKey").val(),
        "City": $("#txt_City").val(),
        "Country": $("#txt_Country").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Groupid": $("#txt_Groupid").val(),
        "Head_img_url": $("#txt_Head_img_url").val(),
        "Language": $("#txt_Language").val(),
        "Nick_name": $("#txt_Nick_name").val(),
        "Openid": $("#txt_Openid").val(),
        "Phone_number": $("#txt_Phone_number").val(),
        "Province": $("#txt_Province").val(),
        "RedirectUrl": $("#txt_RedirectUrl").val(),
        "Ref_id": $("#txt_Ref_id").val(),
        "Remark": $("#txt_Remark").val(),
        "Rmrk3": $("#txt_Rmrk3").val(),
        "Sc": $("#txt_Sc").val(),
        "ScName": $("#txt_ScName").val(),
        "Sex": $("#txt_Sex").val(),
        "SourceId": $("#txt_SourceId").val(),
        "Subscribe": $("#txt_Subscribe").val(),
        "Subscribe_time": $("#txt_Subscribe_time").val(),
        "Unionid": $("#txt_Unionid").val(),
        "User_id": $("#txt_User_id").val(),
        "User_type": $("#txt_User_type").val(), 
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
    /// <para>微信用户信息</para>
    /// <para>与WX_USER_INFO数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class WX_USER_INFO : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static WX_USER_INFO Factory()
        {
            return new WX_USER_INFO();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _AuthSession3rd
        {            
            get { return this.AuthSession3rd; }
            set { this.AuthSession3rd = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _AuthSessionKey
        {            
            get { return this.AuthSessionKey; }
            set { this.AuthSessionKey = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Country
        {            
            get { return this.Country; }
            set { this.Country = value; }
        }
        
        /// <summary>  Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Groupid
        {            
            get { return this.Groupid; }
            set { this.Groupid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Head_img_url
        {            
            get { return this.Head_img_url; }
            set { this.Head_img_url = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Language
        {            
            get { return this.Language; }
            set { this.Language = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Nick_name
        {            
            get { return this.Nick_name; }
            set { this.Nick_name = value; }
        }
        
        /// <summary>  Attribute </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_number
        {            
            get { return this.Phone_number; }
            set { this.Phone_number = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _RedirectUrl
        {            
            get { return this.RedirectUrl; }
            set { this.RedirectUrl = value; }
        }
        
        /// <summary> 关联ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Ref_id
        {            
            get { return this.Ref_id; }
            set { this.Ref_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Remark
        {            
            get { return this.Remark; }
            set { this.Remark = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Rmrk3
        {            
            get { return this.Rmrk3; }
            set { this.Rmrk3 = value; }
        }
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ScName
        {            
            get { return this.ScName; }
            set { this.ScName = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _SourceId
        {            
            get { return this.SourceId; }
            set { this.SourceId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Subscribe
        {            
            get { return this.Subscribe; }
            set { this.Subscribe = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Subscribe_time
        {            
            get { return this.Subscribe_time; }
            set { this.Subscribe_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Unionid
        {            
            get { return this.Unionid; }
            set { this.Unionid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 用户类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_type
        {            
            get { return this.User_type; }
            set { this.User_type = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int ID
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Appid
        {
            get { return this.m_appid; }
            set //
            {
                if (!appid_initialized || m_appid != value)
                {
                    this.m_appid = value;
                }
                appid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string AuthSession3rd
        {
            get { return this.m_authsession3rd; }
            set //
            {
                if (!authsession3rd_initialized || m_authsession3rd != value)
                {
                    this.m_authsession3rd = value;
                }
                authsession3rd_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string AuthSessionKey
        {
            get { return this.m_authsessionkey; }
            set //
            {
                if (!authsessionkey_initialized || m_authsessionkey != value)
                {
                    this.m_authsessionkey = value;
                }
                authsessionkey_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Country
        {
            get { return this.m_country; }
            set //
            {
                if (!country_initialized || m_country != value)
                {
                    this.m_country = value;
                }
                country_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Groupid
        {
            get { return this.m_groupid; }
            set //
            {
                if (!groupid_initialized || m_groupid != value)
                {
                    this.m_groupid = value;
                }
                groupid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Head_img_url
        {
            get { return this.m_head_img_url; }
            set //
            {
                if (!head_img_url_initialized || m_head_img_url != value)
                {
                    this.m_head_img_url = value;
                }
                head_img_url_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Language
        {
            get { return this.m_language; }
            set //
            {
                if (!language_initialized || m_language != value)
                {
                    this.m_language = value;
                }
                language_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Nick_name
        {
            get { return this.m_nick_name; }
            set //
            {
                if (!nick_name_initialized || m_nick_name != value)
                {
                    this.m_nick_name = value;
                }
                nick_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Openid
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_number
        {
            get { return this.m_phone_number; }
            set //
            {
                if (!phone_number_initialized || m_phone_number != value)
                {
                    this.m_phone_number = value;
                }
                phone_number_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string RedirectUrl
        {
            get { return this.m_redirecturl; }
            set //
            {
                if (!redirecturl_initialized || m_redirecturl != value)
                {
                    this.m_redirecturl = value;
                }
                redirecturl_initialized = true;
            }
        }
        
        /// <summary> 关联ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Ref_id
        {
            get { return this.m_ref_id; }
            set //
            {
                if (!ref_id_initialized || m_ref_id != value)
                {
                    this.m_ref_id = value;
                }
                ref_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Rmrk3
        {
            get { return this.m_rmrk3; }
            set //
            {
                if (!rmrk3_initialized || m_rmrk3 != value)
                {
                    this.m_rmrk3 = value;
                }
                rmrk3_initialized = true;
            }
        }
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ScName
        {
            get { return this.m_scname; }
            set //
            {
                if (!scname_initialized || m_scname != value)
                {
                    this.m_scname = value;
                }
                scname_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Sex
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string SourceId
        {
            get { return this.m_sourceid; }
            set //
            {
                if (!sourceid_initialized || m_sourceid != value)
                {
                    this.m_sourceid = value;
                }
                sourceid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Subscribe
        {
            get { return this.m_subscribe; }
            set //
            {
                if (!subscribe_initialized || m_subscribe != value)
                {
                    this.m_subscribe = value;
                }
                subscribe_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Subscribe_time
        {
            get { return this.m_subscribe_time; }
            set //
            {
                if (!subscribe_time_initialized || m_subscribe_time != value)
                {
                    this.m_subscribe_time = value;
                }
                subscribe_time_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Unionid
        {
            get { return this.m_unionid; }
            set //
            {
                if (!unionid_initialized || m_unionid != value)
                {
                    this.m_unionid = value;
                }
                unionid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 用户类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string User_type
        {
            get { return this.m_user_type; }
            set //
            {
                if (!user_type_initialized || m_user_type != value)
                {
                    this.m_user_type = value;
                }
                user_type_initialized = true;
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
            public static AttributeItem ID =  new AttributeItem("[WX_USER_INFO].[ID]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Appid =  new AttributeItem("[WX_USER_INFO].[Appid]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem AuthSession3rd =  new AttributeItem("[WX_USER_INFO].[AuthSession3rd]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem AuthSessionKey =  new AttributeItem("[WX_USER_INFO].[AuthSessionKey]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem City =  new AttributeItem("[WX_USER_INFO].[City]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Country =  new AttributeItem("[WX_USER_INFO].[Country]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem CreateTime =  new AttributeItem("[WX_USER_INFO].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Groupid =  new AttributeItem("[WX_USER_INFO].[Groupid]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Head_img_url =  new AttributeItem("[WX_USER_INFO].[Head_img_url]", typeof(string), -1, default(string));
            
            /// <summary></summary>
            public static AttributeItem Language =  new AttributeItem("[WX_USER_INFO].[Language]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Nick_name =  new AttributeItem("[WX_USER_INFO].[Nick_name]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Openid =  new AttributeItem("[WX_USER_INFO].[Openid]", typeof(string), 36, default(string));
            
            /// <summary>手机号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_number =  new AttributeItem("[WX_USER_INFO].[Phone_number]", typeof(string), 20, default(string));
            
            /// <summary></summary>
            public static AttributeItem Province =  new AttributeItem("[WX_USER_INFO].[Province]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem RedirectUrl =  new AttributeItem("[WX_USER_INFO].[RedirectUrl]", typeof(string), 200, default(string));
            
            /// <summary>关联ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Ref_id =  new AttributeItem("[WX_USER_INFO].[Ref_id]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Remark =  new AttributeItem("[WX_USER_INFO].[Remark]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Rmrk3 =  new AttributeItem("[WX_USER_INFO].[Rmrk3]", typeof(string), 36, default(string));
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[WX_USER_INFO].[Sc]", typeof(string), 50, default(string));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ScName =  new AttributeItem("[WX_USER_INFO].[ScName]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Sex =  new AttributeItem("[WX_USER_INFO].[Sex]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem SourceId =  new AttributeItem("[WX_USER_INFO].[SourceId]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Subscribe =  new AttributeItem("[WX_USER_INFO].[Subscribe]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Subscribe_time =  new AttributeItem("[WX_USER_INFO].[Subscribe_time]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Unionid =  new AttributeItem("[WX_USER_INFO].[Unionid]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[WX_USER_INFO].[User_id]", typeof(string), 16, default(string));
            
            /// <summary>用户类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_type =  new AttributeItem("[WX_USER_INFO].[User_type]", typeof(string), 1, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private string m_authsession3rd;
        /// <summary></summary>
        protected bool authsession3rd_initialized = false;
        
        private string m_authsessionkey;
        /// <summary></summary>
        protected bool authsessionkey_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_country;
        /// <summary></summary>
        protected bool country_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_groupid;
        /// <summary></summary>
        protected bool groupid_initialized = false;
        
        private string m_head_img_url;
        /// <summary></summary>
        protected bool head_img_url_initialized = false;
        
        private string m_language;
        /// <summary></summary>
        protected bool language_initialized = false;
        
        private string m_nick_name;
        /// <summary></summary>
        protected bool nick_name_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_phone_number;
        /// <summary></summary>
        protected bool phone_number_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_redirecturl;
        /// <summary></summary>
        protected bool redirecturl_initialized = false;
        
        private string m_ref_id;
        /// <summary></summary>
        protected bool ref_id_initialized = false;
        
        private string m_remark;
        /// <summary></summary>
        protected bool remark_initialized = false;
        
        private string m_rmrk3;
        /// <summary></summary>
        protected bool rmrk3_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_scname;
        /// <summary></summary>
        protected bool scname_initialized = false;
        
        private int m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_sourceid;
        /// <summary></summary>
        protected bool sourceid_initialized = false;
        
        private int m_subscribe;
        /// <summary></summary>
        protected bool subscribe_initialized = false;
        
        private string m_subscribe_time;
        /// <summary></summary>
        protected bool subscribe_time_initialized = false;
        
        private string m_unionid;
        /// <summary></summary>
        protected bool unionid_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_user_type;
        /// <summary></summary>
        protected bool user_type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "WX_USER_INFO";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.appid_initialized = IsLoadAllAttributes;this.authsession3rd_initialized = IsLoadAllAttributes;this.authsessionkey_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.country_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.groupid_initialized = IsLoadAllAttributes;this.head_img_url_initialized = IsLoadAllAttributes;this.language_initialized = IsLoadAllAttributes;this.nick_name_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.phone_number_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.redirecturl_initialized = IsLoadAllAttributes;this.ref_id_initialized = IsLoadAllAttributes;this.remark_initialized = IsLoadAllAttributes;this.rmrk3_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.scname_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.sourceid_initialized = IsLoadAllAttributes;this.subscribe_initialized = IsLoadAllAttributes;this.subscribe_time_initialized = IsLoadAllAttributes;this.unionid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.user_type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			WX_USER_INFO value = new WX_USER_INFO();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AuthSession3rd"))
				value.authsession3rd_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AuthSessionKey"))
				value.authsessionkey_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Country"))
				value.country_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Groupid"))
				value.groupid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Head_img_url"))
				value.head_img_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Language"))
				value.language_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nick_name"))
				value.nick_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_number"))
				value.phone_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RedirectUrl"))
				value.redirecturl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ref_id"))
				value.ref_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Remark"))
				value.remark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Rmrk3"))
				value.rmrk3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ScName"))
				value.scname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceId"))
				value.sourceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subscribe"))
				value.subscribe_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subscribe_time"))
				value.subscribe_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Unionid"))
				value.unionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_type"))
				value.user_type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new WX_USER_INFO Clone()
        {
            return (WX_USER_INFO)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static WX_USER_INFO()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public WX_USER_INFO() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public WX_USER_INFO(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public WX_USER_INFO(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public WX_USER_INFO(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public WX_USER_INFO(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public WX_USER_INFO(int id1, string appid1, string authsession3rd1, string authsessionkey1, string city1, string country1, DateTime createtime1, int groupid1, string head_img_url1, string language1, string nick_name1, string openid1, string phone_number1, string province1, string redirecturl1, string ref_id1, string remark1, string rmrk31, string sc1, string scname1, int sex1, string sourceid1, int subscribe1, string subscribe_time1, string unionid1, string user_id1, string user_type1)
        {
            
            this.ID = id1;
            
            this.Appid = appid1;
            
            this.AuthSession3rd = authsession3rd1;
            
            this.AuthSessionKey = authsessionkey1;
            
            this.City = city1;
            
            this.Country = country1;
            
            this.CreateTime = createtime1;
            
            this.Groupid = groupid1;
            
            this.Head_img_url = head_img_url1;
            
            this.Language = language1;
            
            this.Nick_name = nick_name1;
            
            this.Openid = openid1;
            
            this.Phone_number = phone_number1;
            
            this.Province = province1;
            
            this.RedirectUrl = redirecturl1;
            
            this.Ref_id = ref_id1;
            
            this.Remark = remark1;
            
            this.Rmrk3 = rmrk31;
            
            this.Sc = sc1;
            
            this.ScName = scname1;
            
            this.Sex = sex1;
            
            this.SourceId = sourceid1;
            
            this.Subscribe = subscribe1;
            
            this.Subscribe_time = subscribe_time1;
            
            this.Unionid = unionid1;
            
            this.User_id = user_id1;
            
            this.User_type = user_type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static WX_USER_INFO FromIView(IView view)
        {
            return (WX_USER_INFO)IView.GetITable(view, "WX_USER_INFO");
        }
        /// <summary>获得一个实例  </summary>
        public static WX_USER_INFO GetOneInstance()
        {
            WX_USER_INFO value = new WX_USER_INFO();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public WX_USER_INFO Retrieve()
        {
            BLLTable<WX_USER_INFO>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ID":
			        return ID;
			    			
			    case "Appid":
			        return Appid;
			    			
			    case "AuthSession3rd":
			        return AuthSession3rd;
			    			
			    case "AuthSessionKey":
			        return AuthSessionKey;
			    			
			    case "City":
			        return City;
			    			
			    case "Country":
			        return Country;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Groupid":
			        return Groupid;
			    			
			    case "Head_img_url":
			        return Head_img_url;
			    			
			    case "Language":
			        return Language;
			    			
			    case "Nick_name":
			        return Nick_name;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Phone_number":
			        return Phone_number;
			    			
			    case "Province":
			        return Province;
			    			
			    case "RedirectUrl":
			        return RedirectUrl;
			    			
			    case "Ref_id":
			        return Ref_id;
			    			
			    case "Remark":
			        return Remark;
			    			
			    case "Rmrk3":
			        return Rmrk3;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "ScName":
			        return ScName;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "SourceId":
			        return SourceId;
			    			
			    case "Subscribe":
			        return Subscribe;
			    			
			    case "Subscribe_time":
			        return Subscribe_time;
			    			
			    case "Unionid":
			        return Unionid;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "User_type":
			        return User_type;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AuthSession3rd":
			        this.AuthSession3rd = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AuthSessionKey":
			        this.AuthSessionKey = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Country":
			        this.Country = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Groupid":
			        this.Groupid = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Head_img_url":
			        this.Head_img_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Language":
			        this.Language = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Nick_name":
			        this.Nick_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_number":
			        this.Phone_number = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RedirectUrl":
			        this.RedirectUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ref_id":
			        this.Ref_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Remark":
			        this.Remark = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Rmrk3":
			        this.Rmrk3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ScName":
			        this.ScName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SourceId":
			        this.SourceId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Subscribe":
			        this.Subscribe = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Subscribe_time":
			        this.Subscribe_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Unionid":
			        this.Unionid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
                    this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_type":
			        this.User_type = Convert.ToString(AttributeValue);
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
				case "ID":
					return id_initialized;
				
				case "Appid":
					return appid_initialized;
				
				case "AuthSession3rd":
					return authsession3rd_initialized;
				
				case "AuthSessionKey":
					return authsessionkey_initialized;
				
				case "City":
					return city_initialized;
				
				case "Country":
					return country_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Groupid":
					return groupid_initialized;
				
				case "Head_img_url":
					return head_img_url_initialized;
				
				case "Language":
					return language_initialized;
				
				case "Nick_name":
					return nick_name_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Phone_number":
					return phone_number_initialized;
				
				case "Province":
					return province_initialized;
				
				case "RedirectUrl":
					return redirecturl_initialized;
				
				case "Ref_id":
					return ref_id_initialized;
				
				case "Remark":
					return remark_initialized;
				
				case "Rmrk3":
					return rmrk3_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "ScName":
					return scname_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "SourceId":
					return sourceid_initialized;
				
				case "Subscribe":
					return subscribe_initialized;
				
				case "Subscribe_time":
					return subscribe_time_initialized;
				
				case "Unionid":
					return unionid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "User_type":
					return user_type_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ID":
					id_initialized = ret;
					return true;
				
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "AuthSession3rd":
					authsession3rd_initialized = ret;
					return true;
				
				case "AuthSessionKey":
					authsessionkey_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Country":
					country_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Groupid":
					groupid_initialized = ret;
					return true;
				
				case "Head_img_url":
					head_img_url_initialized = ret;
					return true;
				
				case "Language":
					language_initialized = ret;
					return true;
				
				case "Nick_name":
					nick_name_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Phone_number":
					phone_number_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "RedirectUrl":
					redirecturl_initialized = ret;
					return true;
				
				case "Ref_id":
					ref_id_initialized = ret;
					return true;
				
				case "Remark":
					remark_initialized = ret;
					return true;
				
				case "Rmrk3":
					rmrk3_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "ScName":
					scname_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "SourceId":
					sourceid_initialized = ret;
					return true;
				
				case "Subscribe":
					subscribe_initialized = ret;
					return true;
				
				case "Subscribe_time":
					subscribe_time_initialized = ret;
					return true;
				
				case "Unionid":
					unionid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "User_type":
					user_type_initialized = ret;
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
                AttributeItem attr = WX_USER_INFO.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (appid_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (authsession3rd_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.AuthSession3rd;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AuthSession3rd);
                }
			}
			
			if (authsessionkey_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.AuthSessionKey;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AuthSessionKey);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (country_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Country;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Country);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (groupid_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Groupid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Groupid);
                }
			}
			
			if (head_img_url_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Head_img_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Head_img_url);
                }
			}
			
			if (language_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Language;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Language);
                }
			}
			
			if (nick_name_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Nick_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nick_name);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (phone_number_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Phone_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_number);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (redirecturl_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.RedirectUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RedirectUrl);
                }
			}
			
			if (ref_id_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Ref_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ref_id);
                }
			}
			
			if (remark_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Remark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Remark);
                }
			}
			
			if (rmrk3_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Rmrk3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Rmrk3);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (scname_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.ScName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ScName);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (sourceid_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.SourceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceId);
                }
			}
			
			if (subscribe_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Subscribe;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subscribe);
                }
			}
			
			if (subscribe_time_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Subscribe_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subscribe_time);
                }
			}
			
			if (unionid_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.Unionid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Unionid);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (user_type_initialized)
			{
                AttributeItem attr = WX_USER_INFO.Attribute.User_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_type);
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
        public class WX_USER_INFOJson
        {
            
            /// <summary></summary>
            public int ID { get; set; }
            
            /// <summary></summary>
            public string Appid { get; set; }
            
            /// <summary></summary>
            public string AuthSession3rd { get; set; }
            
            /// <summary></summary>
            public string AuthSessionKey { get; set; }
            
            /// <summary></summary>
            public string City { get; set; }
            
            /// <summary></summary>
            public string Country { get; set; }
            
            /// <summary></summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary></summary>
            public int Groupid { get; set; }
            
            /// <summary></summary>
            public string Head_img_url { get; set; }
            
            /// <summary></summary>
            public string Language { get; set; }
            
            /// <summary></summary>
            public string Nick_name { get; set; }
            
            /// <summary></summary>
            public string Openid { get; set; }
            
            /// <summary>手机号:[CtrlTypeDic-{InputString}]</summary>
            public string Phone_number { get; set; }
            
            /// <summary></summary>
            public string Province { get; set; }
            
            /// <summary></summary>
            public string RedirectUrl { get; set; }
            
            /// <summary>关联ID:[CtrlTypeDic-{InputString}]</summary>
            public string Ref_id { get; set; }
            
            /// <summary></summary>
            public string Remark { get; set; }
            
            /// <summary></summary>
            public string Rmrk3 { get; set; }
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string ScName { get; set; }
            
            /// <summary></summary>
            public int Sex { get; set; }
            
            /// <summary></summary>
            public string SourceId { get; set; }
            
            /// <summary></summary>
            public int Subscribe { get; set; }
            
            /// <summary></summary>
            public string Subscribe_time { get; set; }
            
            /// <summary></summary>
            public string Unionid { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
            
            /// <summary>用户类型:[CtrlTypeDic-{InputString}]</summary>
            public string User_type { get; set; }
        }
        #endregion
    }
}