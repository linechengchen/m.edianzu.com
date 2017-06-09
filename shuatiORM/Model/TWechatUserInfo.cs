/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:26
  Description:    数据表TWechatUserInfo对应的业务逻辑层TWechatUserInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TWechatUserInfo_Entity:TWechatUserInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select ID,PassWord,UserName,ShowName,ShowSex,NickName,OpenId,Subscribe,Gender,City,Province,Language,HeadImgUrl,SubscribeTime,UnionId,Errcode,ErrMsg,PhoneNum,DeviceId,DeviceIdShort,HeadImg,Qq from TWechatUserInfo
delete from TWechatUserInfo
INSERT INTO TWechatUserInfo (ID,PassWord,UserName,ShowName,ShowSex,NickName,OpenId,Subscribe,Gender,City,Province,Language,HeadImgUrl,SubscribeTime,UnionId,Errcode,ErrMsg,PhoneNum,DeviceId,DeviceIdShort,HeadImg,Qq)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','')
UPDATE TWechatUserInfo SET ...
变量赋值代码：
 *         valObj.ID = valObj2.ID;
        valObj.PassWord = valObj2.PassWord;
        valObj.UserName = valObj2.UserName;
        valObj.ShowName = valObj2.ShowName;
        valObj.ShowSex = valObj2.ShowSex;
        valObj.NickName = valObj2.NickName;
        valObj.OpenId = valObj2.OpenId;
        valObj.Subscribe = valObj2.Subscribe;
        valObj.Gender = valObj2.Gender;
        valObj.City = valObj2.City;
        valObj.Province = valObj2.Province;
        valObj.Language = valObj2.Language;
        valObj.HeadImgUrl = valObj2.HeadImgUrl;
        valObj.SubscribeTime = valObj2.SubscribeTime;
        valObj.UnionId = valObj2.UnionId;
        valObj.Errcode = valObj2.Errcode;
        valObj.ErrMsg = valObj2.ErrMsg;
        valObj.PhoneNum = valObj2.PhoneNum;
        valObj.DeviceId = valObj2.DeviceId;
        valObj.DeviceIdShort = valObj2.DeviceIdShort;
        valObj.HeadImg = valObj2.HeadImg;
        valObj.Qq = valObj2.Qq; 
        valObj.ID = "";
        valObj.PassWord = "";
        valObj.UserName = "";
        valObj.ShowName = "";
        valObj.ShowSex = "";
        valObj.NickName = "";
        valObj.OpenId = "";
        valObj.Subscribe = "";
        valObj.Gender = "";
        valObj.City = "";
        valObj.Province = "";
        valObj.Language = "";
        valObj.HeadImgUrl = "";
        valObj.SubscribeTime = "";
        valObj.UnionId = "";
        valObj.Errcode = "";
        valObj.ErrMsg = "";
        valObj.PhoneNum = "";
        valObj.DeviceId = "";
        valObj.DeviceIdShort = "";
        valObj.HeadImg = "";
        valObj.Qq = ""; 
        "ID": $("#txt_ID").val(),
        "PassWord": $("#txt_PassWord").val(),
        "UserName": $("#txt_UserName").val(),
        "ShowName": $("#txt_ShowName").val(),
        "ShowSex": $("#txt_ShowSex").val(),
        "NickName": $("#txt_NickName").val(),
        "OpenId": $("#txt_OpenId").val(),
        "Subscribe": $("#txt_Subscribe").val(),
        "Gender": $("#txt_Gender").val(),
        "City": $("#txt_City").val(),
        "Province": $("#txt_Province").val(),
        "Language": $("#txt_Language").val(),
        "HeadImgUrl": $("#txt_HeadImgUrl").val(),
        "SubscribeTime": $("#txt_SubscribeTime").val(),
        "UnionId": $("#txt_UnionId").val(),
        "Errcode": $("#txt_Errcode").val(),
        "ErrMsg": $("#txt_ErrMsg").val(),
        "PhoneNum": $("#txt_PhoneNum").val(),
        "DeviceId": $("#txt_DeviceId").val(),
        "DeviceIdShort": $("#txt_DeviceIdShort").val(),
        "HeadImg": $("#txt_HeadImg").val(),
        "Qq": $("#txt_Qq").val(), 
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
    /// <para>微信用户信息:[IDField-{ID:0}]</para>
    /// <para>与TWechatUserInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TWechatUserInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TWechatUserInfo Factory()
        {
            return new TWechatUserInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> 密码:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PassWord
        {            
            get { return this.PassWord; }
            set { this.PassWord = value; }
        }
        
        /// <summary> 用户登录名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserName
        {            
            get { return this.UserName; }
            set { this.UserName = value; }
        }
        
        /// <summary> 用户的昵称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShowName
        {            
            get { return this.ShowName; }
            set { this.ShowName = value; }
        }
        
        /// <summary> 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShowSex
        {            
            get { return this.ShowSex; }
            set { this.ShowSex = value; }
        }
        
        /// <summary> 用户的昵称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NickName
        {            
            get { return this.NickName; }
            set { this.NickName = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> 用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Subscribe
        {            
            get { return this.Subscribe; }
            set { this.Subscribe = value; }
        }
        
        /// <summary> 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Gender
        {            
            get { return this.Gender; }
            set { this.Gender = value; }
        }
        
        /// <summary> 用户所在城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> 用户所在省份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> 用户的语言，简体中文为zh_CN:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Language
        {            
            get { return this.Language; }
            set { this.Language = value; }
        }
        
        /// <summary> 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HeadImgUrl
        {            
            get { return this.HeadImgUrl; }
            set { this.HeadImgUrl = value; }
        }
        
        /// <summary> 用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SubscribeTime
        {            
            get { return this.SubscribeTime; }
            set { this.SubscribeTime = value; }
        }
        
        /// <summary> 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UnionId
        {            
            get { return this.UnionId; }
            set { this.UnionId = value; }
        }
        
        /// <summary> 错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Errcode
        {            
            get { return this.Errcode; }
            set { this.Errcode = value; }
        }
        
        /// <summary> 错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ErrMsg
        {            
            get { return this.ErrMsg; }
            set { this.ErrMsg = value; }
        }
        
        /// <summary> 手机号-可登陆:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PhoneNum
        {            
            get { return this.PhoneNum; }
            set { this.PhoneNum = value; }
        }
        
        /// <summary> 设备Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DeviceId
        {            
            get { return this.DeviceId; }
            set { this.DeviceId = value; }
        }
        
        /// <summary> 设备Id后六位:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DeviceIdShort
        {            
            get { return this.DeviceIdShort; }
            set { this.DeviceIdShort = value; }
        }
        
        /// <summary> 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HeadImg
        {            
            get { return this.HeadImg; }
            set { this.HeadImg = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Qq
        {            
            get { return this.Qq; }
            set { this.Qq = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 密码:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PassWord
        {
            get { return this.m_password; }
            set //
            {
                if (!password_initialized || m_password != value)
                {
                    this.m_password = value;
                }
                password_initialized = true;
            }
        }
        
        /// <summary> 用户登录名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserName
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
        
        /// <summary> 用户的昵称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ShowName
        {
            get { return this.m_showname; }
            set //
            {
                if (!showname_initialized || m_showname != value)
                {
                    this.m_showname = value;
                }
                showname_initialized = true;
            }
        }
        
        /// <summary> 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ShowSex
        {
            get { return this.m_showsex; }
            set //
            {
                if (!showsex_initialized || m_showsex != value)
                {
                    this.m_showsex = value;
                }
                showsex_initialized = true;
            }
        }
        
        /// <summary> 用户的昵称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NickName
        {
            get { return this.m_nickname; }
            set //
            {
                if (!nickname_initialized || m_nickname != value)
                {
                    this.m_nickname = value;
                }
                nickname_initialized = true;
            }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OpenId
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
        
        /// <summary> 用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Subscribe
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
        
        /// <summary> 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Gender
        {
            get { return this.m_gender; }
            set //
            {
                if (!gender_initialized || m_gender != value)
                {
                    this.m_gender = value;
                }
                gender_initialized = true;
            }
        }
        
        /// <summary> 用户所在城市:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 用户所在省份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 用户的语言，简体中文为zh_CN:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string HeadImgUrl
        {
            get { return this.m_headimgurl; }
            set //
            {
                if (!headimgurl_initialized || m_headimgurl != value)
                {
                    this.m_headimgurl = value;
                }
                headimgurl_initialized = true;
            }
        }
        
        /// <summary> 用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SubscribeTime
        {
            get { return this.m_subscribetime; }
            set //
            {
                if (!subscribetime_initialized || m_subscribetime != value)
                {
                    this.m_subscribetime = value;
                }
                subscribetime_initialized = true;
            }
        }
        
        /// <summary> 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UnionId
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
        
        /// <summary> 错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Errcode
        {
            get { return this.m_errcode; }
            set //
            {
                if (!errcode_initialized || m_errcode != value)
                {
                    this.m_errcode = value;
                }
                errcode_initialized = true;
            }
        }
        
        /// <summary> 错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ErrMsg
        {
            get { return this.m_errmsg; }
            set //
            {
                if (!errmsg_initialized || m_errmsg != value)
                {
                    this.m_errmsg = value;
                }
                errmsg_initialized = true;
            }
        }
        
        /// <summary> 手机号-可登陆:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PhoneNum
        {
            get { return this.m_phonenum; }
            set //
            {
                if (!phonenum_initialized || m_phonenum != value)
                {
                    this.m_phonenum = value;
                }
                phonenum_initialized = true;
            }
        }
        
        /// <summary> 设备Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DeviceId
        {
            get { return this.m_deviceid; }
            set //
            {
                if (!deviceid_initialized || m_deviceid != value)
                {
                    this.m_deviceid = value;
                }
                deviceid_initialized = true;
            }
        }
        
        /// <summary> 设备Id后六位:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DeviceIdShort
        {
            get { return this.m_deviceidshort; }
            set //
            {
                if (!deviceidshort_initialized || m_deviceidshort != value)
                {
                    this.m_deviceidshort = value;
                }
                deviceidshort_initialized = true;
            }
        }
        
        /// <summary> 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string HeadImg
        {
            get { return this.m_headimg; }
            set //
            {
                if (!headimg_initialized || m_headimg != value)
                {
                    this.m_headimg = value;
                }
                headimg_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Qq
        {
            get { return this.m_qq; }
            set //
            {
                if (!qq_initialized || m_qq != value)
                {
                    this.m_qq = value;
                }
                qq_initialized = true;
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
            public static AttributeItem ID =  new AttributeItem("[TWechatUserInfo].[ID]", typeof(int), 4, default(int));
            
            /// <summary>密码:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PassWord =  new AttributeItem("[TWechatUserInfo].[PassWord]", typeof(string), 200, default(string));
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserName =  new AttributeItem("[TWechatUserInfo].[UserName]", typeof(string), 200, default(string));
            
            /// <summary>用户的昵称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShowName =  new AttributeItem("[TWechatUserInfo].[ShowName]", typeof(string), 200, default(string));
            
            /// <summary>用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShowSex =  new AttributeItem("[TWechatUserInfo].[ShowSex]", typeof(string), 200, default(string));
            
            /// <summary>用户的昵称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NickName =  new AttributeItem("[TWechatUserInfo].[NickName]", typeof(string), 200, default(string));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[TWechatUserInfo].[OpenId]", typeof(string), 200, default(string));
            
            /// <summary>用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Subscribe =  new AttributeItem("[TWechatUserInfo].[Subscribe]", typeof(string), 200, default(string));
            
            /// <summary>用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Gender =  new AttributeItem("[TWechatUserInfo].[Gender]", typeof(string), 4, default(string));
            
            /// <summary>用户所在城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[TWechatUserInfo].[City]", typeof(string), 200, default(string));
            
            /// <summary>用户所在省份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[TWechatUserInfo].[Province]", typeof(string), 200, default(string));
            
            /// <summary>用户的语言，简体中文为zh_CN:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Language =  new AttributeItem("[TWechatUserInfo].[Language]", typeof(string), 200, default(string));
            
            /// <summary>用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HeadImgUrl =  new AttributeItem("[TWechatUserInfo].[HeadImgUrl]", typeof(string), 200, default(string));
            
            /// <summary>用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SubscribeTime =  new AttributeItem("[TWechatUserInfo].[SubscribeTime]", typeof(string), 200, default(string));
            
            /// <summary>只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UnionId =  new AttributeItem("[TWechatUserInfo].[UnionId]", typeof(string), 200, default(string));
            
            /// <summary>错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Errcode =  new AttributeItem("[TWechatUserInfo].[Errcode]", typeof(string), 200, default(string));
            
            /// <summary>错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrMsg =  new AttributeItem("[TWechatUserInfo].[ErrMsg]", typeof(string), 200, default(string));
            
            /// <summary>手机号-可登陆:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PhoneNum =  new AttributeItem("[TWechatUserInfo].[PhoneNum]", typeof(string), 50, default(string));
            
            /// <summary>设备Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DeviceId =  new AttributeItem("[TWechatUserInfo].[DeviceId]", typeof(string), 50, default(string));
            
            /// <summary>设备Id后六位:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DeviceIdShort =  new AttributeItem("[TWechatUserInfo].[DeviceIdShort]", typeof(string), 50, default(string));
            
            /// <summary>用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HeadImg =  new AttributeItem("[TWechatUserInfo].[HeadImg]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qq =  new AttributeItem("[TWechatUserInfo].[Qq]", typeof(string), 10, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_password;
        /// <summary></summary>
        protected bool password_initialized = false;
        
        private string m_username;
        /// <summary></summary>
        protected bool username_initialized = false;
        
        private string m_showname;
        /// <summary></summary>
        protected bool showname_initialized = false;
        
        private string m_showsex;
        /// <summary></summary>
        protected bool showsex_initialized = false;
        
        private string m_nickname;
        /// <summary></summary>
        protected bool nickname_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_subscribe;
        /// <summary></summary>
        protected bool subscribe_initialized = false;
        
        private string m_gender;
        /// <summary></summary>
        protected bool gender_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_language;
        /// <summary></summary>
        protected bool language_initialized = false;
        
        private string m_headimgurl;
        /// <summary></summary>
        protected bool headimgurl_initialized = false;
        
        private string m_subscribetime;
        /// <summary></summary>
        protected bool subscribetime_initialized = false;
        
        private string m_unionid;
        /// <summary></summary>
        protected bool unionid_initialized = false;
        
        private string m_errcode;
        /// <summary></summary>
        protected bool errcode_initialized = false;
        
        private string m_errmsg;
        /// <summary></summary>
        protected bool errmsg_initialized = false;
        
        private string m_phonenum;
        /// <summary></summary>
        protected bool phonenum_initialized = false;
        
        private string m_deviceid;
        /// <summary></summary>
        protected bool deviceid_initialized = false;
        
        private string m_deviceidshort;
        /// <summary></summary>
        protected bool deviceidshort_initialized = false;
        
        private string m_headimg;
        /// <summary></summary>
        protected bool headimg_initialized = false;
        
        private string m_qq;
        /// <summary></summary>
        protected bool qq_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TWechatUserInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.password_initialized = IsLoadAllAttributes;this.username_initialized = IsLoadAllAttributes;this.showname_initialized = IsLoadAllAttributes;this.showsex_initialized = IsLoadAllAttributes;this.nickname_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.subscribe_initialized = IsLoadAllAttributes;this.gender_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.language_initialized = IsLoadAllAttributes;this.headimgurl_initialized = IsLoadAllAttributes;this.subscribetime_initialized = IsLoadAllAttributes;this.unionid_initialized = IsLoadAllAttributes;this.errcode_initialized = IsLoadAllAttributes;this.errmsg_initialized = IsLoadAllAttributes;this.phonenum_initialized = IsLoadAllAttributes;this.deviceid_initialized = IsLoadAllAttributes;this.deviceidshort_initialized = IsLoadAllAttributes;this.headimg_initialized = IsLoadAllAttributes;this.qq_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TWechatUserInfo value = new TWechatUserInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PassWord"))
				value.password_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserName"))
				value.username_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShowName"))
				value.showname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShowSex"))
				value.showsex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NickName"))
				value.nickname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subscribe"))
				value.subscribe_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Gender"))
				value.gender_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Language"))
				value.language_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HeadImgUrl"))
				value.headimgurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SubscribeTime"))
				value.subscribetime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UnionId"))
				value.unionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Errcode"))
				value.errcode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrMsg"))
				value.errmsg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PhoneNum"))
				value.phonenum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DeviceId"))
				value.deviceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DeviceIdShort"))
				value.deviceidshort_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HeadImg"))
				value.headimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qq"))
				value.qq_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TWechatUserInfo Clone()
        {
            return (TWechatUserInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TWechatUserInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TWechatUserInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TWechatUserInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TWechatUserInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TWechatUserInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TWechatUserInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TWechatUserInfo(int id1, string password1, string username1, string showname1, string showsex1, string nickname1, string openid1, string subscribe1, string gender1, string city1, string province1, string language1, string headimgurl1, string subscribetime1, string unionid1, string errcode1, string errmsg1, string phonenum1, string deviceid1, string deviceidshort1, string headimg1, string qq1)
        {
            
            this.ID = id1;
            
            this.PassWord = password1;
            
            this.UserName = username1;
            
            this.ShowName = showname1;
            
            this.ShowSex = showsex1;
            
            this.NickName = nickname1;
            
            this.OpenId = openid1;
            
            this.Subscribe = subscribe1;
            
            this.Gender = gender1;
            
            this.City = city1;
            
            this.Province = province1;
            
            this.Language = language1;
            
            this.HeadImgUrl = headimgurl1;
            
            this.SubscribeTime = subscribetime1;
            
            this.UnionId = unionid1;
            
            this.Errcode = errcode1;
            
            this.ErrMsg = errmsg1;
            
            this.PhoneNum = phonenum1;
            
            this.DeviceId = deviceid1;
            
            this.DeviceIdShort = deviceidshort1;
            
            this.HeadImg = headimg1;
            
            this.Qq = qq1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TWechatUserInfo FromIView(IView view)
        {
            return (TWechatUserInfo)IView.GetITable(view, "TWechatUserInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static TWechatUserInfo GetOneInstance()
        {
            TWechatUserInfo value = new TWechatUserInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TWechatUserInfo Retrieve()
        {
            BLLTable<TWechatUserInfo>.GetRowData(this);
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
			    			
			    case "PassWord":
			        return PassWord;
			    			
			    case "UserName":
			        return UserName;
			    			
			    case "ShowName":
			        return ShowName;
			    			
			    case "ShowSex":
			        return ShowSex;
			    			
			    case "NickName":
			        return NickName;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "Subscribe":
			        return Subscribe;
			    			
			    case "Gender":
			        return Gender;
			    			
			    case "City":
			        return City;
			    			
			    case "Province":
			        return Province;
			    			
			    case "Language":
			        return Language;
			    			
			    case "HeadImgUrl":
			        return HeadImgUrl;
			    			
			    case "SubscribeTime":
			        return SubscribeTime;
			    			
			    case "UnionId":
			        return UnionId;
			    			
			    case "Errcode":
			        return Errcode;
			    			
			    case "ErrMsg":
			        return ErrMsg;
			    			
			    case "PhoneNum":
			        return PhoneNum;
			    			
			    case "DeviceId":
			        return DeviceId;
			    			
			    case "DeviceIdShort":
			        return DeviceIdShort;
			    			
			    case "HeadImg":
			        return HeadImg;
			    			
			    case "Qq":
			        return Qq;
			
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
			    			
			    case "PassWord":
			        this.PassWord = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserName":
			        this.UserName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShowName":
			        this.ShowName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShowSex":
			        this.ShowSex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NickName":
			        this.NickName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Subscribe":
			        this.Subscribe = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Gender":
			        this.Gender = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Language":
			        this.Language = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HeadImgUrl":
			        this.HeadImgUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SubscribeTime":
			        this.SubscribeTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UnionId":
			        this.UnionId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Errcode":
			        this.Errcode = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ErrMsg":
			        this.ErrMsg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PhoneNum":
			        this.PhoneNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DeviceId":
			        this.DeviceId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DeviceIdShort":
			        this.DeviceIdShort = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HeadImg":
			        this.HeadImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qq":
			        this.Qq = Convert.ToString(AttributeValue);
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
				
				case "PassWord":
					return password_initialized;
				
				case "UserName":
					return username_initialized;
				
				case "ShowName":
					return showname_initialized;
				
				case "ShowSex":
					return showsex_initialized;
				
				case "NickName":
					return nickname_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "Subscribe":
					return subscribe_initialized;
				
				case "Gender":
					return gender_initialized;
				
				case "City":
					return city_initialized;
				
				case "Province":
					return province_initialized;
				
				case "Language":
					return language_initialized;
				
				case "HeadImgUrl":
					return headimgurl_initialized;
				
				case "SubscribeTime":
					return subscribetime_initialized;
				
				case "UnionId":
					return unionid_initialized;
				
				case "Errcode":
					return errcode_initialized;
				
				case "ErrMsg":
					return errmsg_initialized;
				
				case "PhoneNum":
					return phonenum_initialized;
				
				case "DeviceId":
					return deviceid_initialized;
				
				case "DeviceIdShort":
					return deviceidshort_initialized;
				
				case "HeadImg":
					return headimg_initialized;
				
				case "Qq":
					return qq_initialized;
				
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
				
				case "PassWord":
					password_initialized = ret;
					return true;
				
				case "UserName":
					username_initialized = ret;
					return true;
				
				case "ShowName":
					showname_initialized = ret;
					return true;
				
				case "ShowSex":
					showsex_initialized = ret;
					return true;
				
				case "NickName":
					nickname_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "Subscribe":
					subscribe_initialized = ret;
					return true;
				
				case "Gender":
					gender_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "Language":
					language_initialized = ret;
					return true;
				
				case "HeadImgUrl":
					headimgurl_initialized = ret;
					return true;
				
				case "SubscribeTime":
					subscribetime_initialized = ret;
					return true;
				
				case "UnionId":
					unionid_initialized = ret;
					return true;
				
				case "Errcode":
					errcode_initialized = ret;
					return true;
				
				case "ErrMsg":
					errmsg_initialized = ret;
					return true;
				
				case "PhoneNum":
					phonenum_initialized = ret;
					return true;
				
				case "DeviceId":
					deviceid_initialized = ret;
					return true;
				
				case "DeviceIdShort":
					deviceidshort_initialized = ret;
					return true;
				
				case "HeadImg":
					headimg_initialized = ret;
					return true;
				
				case "Qq":
					qq_initialized = ret;
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
                AttributeItem attr = TWechatUserInfo.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (password_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.PassWord;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PassWord);
                }
			}
			
			if (username_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.UserName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserName);
                }
			}
			
			if (showname_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.ShowName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShowName);
                }
			}
			
			if (showsex_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.ShowSex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShowSex);
                }
			}
			
			if (nickname_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.NickName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NickName);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (subscribe_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Subscribe;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subscribe);
                }
			}
			
			if (gender_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Gender;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Gender);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (language_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Language;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Language);
                }
			}
			
			if (headimgurl_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.HeadImgUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HeadImgUrl);
                }
			}
			
			if (subscribetime_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.SubscribeTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SubscribeTime);
                }
			}
			
			if (unionid_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.UnionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UnionId);
                }
			}
			
			if (errcode_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Errcode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Errcode);
                }
			}
			
			if (errmsg_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.ErrMsg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrMsg);
                }
			}
			
			if (phonenum_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.PhoneNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PhoneNum);
                }
			}
			
			if (deviceid_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.DeviceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DeviceId);
                }
			}
			
			if (deviceidshort_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.DeviceIdShort;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DeviceIdShort);
                }
			}
			
			if (headimg_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.HeadImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HeadImg);
                }
			}
			
			if (qq_initialized)
			{
                AttributeItem attr = TWechatUserInfo.Attribute.Qq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qq);
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
        public class TWechatUserInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ID { get; set; }
            
            /// <summary>密码:[CtrlTypeDic-{InputString}]</summary>
            public string PassWord { get; set; }
            
            /// <summary>用户登录名:[CtrlTypeDic-{InputString}]</summary>
            public string UserName { get; set; }
            
            /// <summary>用户的昵称:[CtrlTypeDic-{InputString}]</summary>
            public string ShowName { get; set; }
            
            /// <summary>用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]</summary>
            public string ShowSex { get; set; }
            
            /// <summary>用户的昵称:[CtrlTypeDic-{InputString}]</summary>
            public string NickName { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>用户是否订阅该公众号标识，值为0时，代表此用户没有关注该公众号，拉取不到其余信息。:[CtrlTypeDic-{InputString}]</summary>
            public string Subscribe { get; set; }
            
            /// <summary>用户的性别，值为1时是男性，值为2时是女性，值为0时是未知:[CtrlTypeDic-{InputString}]</summary>
            public string Gender { get; set; }
            
            /// <summary>用户所在城市:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>用户所在省份:[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>用户的语言，简体中文为zh_CN:[CtrlTypeDic-{InputString}]</summary>
            public string Language { get; set; }
            
            /// <summary>用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]</summary>
            public string HeadImgUrl { get; set; }
            
            /// <summary>用户关注时间，为时间戳。如果用户曾多次关注，则取最后关注时间:[CtrlTypeDic-{InputString}]</summary>
            public string SubscribeTime { get; set; }
            
            /// <summary>只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。:[CtrlTypeDic-{InputString}]</summary>
            public string UnionId { get; set; }
            
            /// <summary>错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]</summary>
            public string Errcode { get; set; }
            
            /// <summary>错误时微信会返回错误码等信息:[CtrlTypeDic-{InputString}]</summary>
            public string ErrMsg { get; set; }
            
            /// <summary>手机号-可登陆:[CtrlTypeDic-{InputString}]</summary>
            public string PhoneNum { get; set; }
            
            /// <summary>设备Id:[CtrlTypeDic-{InputString}]</summary>
            public string DeviceId { get; set; }
            
            /// <summary>设备Id后六位:[CtrlTypeDic-{InputString}]</summary>
            public string DeviceIdShort { get; set; }
            
            /// <summary>用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。:[CtrlTypeDic-{InputString}]</summary>
            public string HeadImg { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Qq { get; set; }
        }
        #endregion
    }
}