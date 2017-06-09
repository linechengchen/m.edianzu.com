/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    数据表Jz_company对应的业务逻辑层Jz_company
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_company_Entity:Jz_company
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,CompanyUuid,AccountAuthorizedManagerId,Address,AreaId,CompanyAccountId,CompanyId,CompanyName,Latitude,Longitude,Name,Position,Role,TownId,AccountName,Authenticated,ChargerName,CompanyLogo,CompanyScale,CompanyShareContent,CompanyShareLogo,CompanyShareTitle,CompanyShareUrl,CompanyType,Email,Industry,Introduction,Qq,CompanyMobile from Jz_company
delete from Jz_company
INSERT INTO Jz_company (Id,CompanyUuid,AccountAuthorizedManagerId,Address,AreaId,CompanyAccountId,CompanyId,CompanyName,Latitude,Longitude,Name,Position,Role,TownId,AccountName,Authenticated,ChargerName,CompanyLogo,CompanyScale,CompanyShareContent,CompanyShareLogo,CompanyShareTitle,CompanyShareUrl,CompanyType,Email,Industry,Introduction,Qq,CompanyMobile)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Jz_company SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.CompanyUuid = valObj2.CompanyUuid;
        valObj.AccountAuthorizedManagerId = valObj2.AccountAuthorizedManagerId;
        valObj.Address = valObj2.Address;
        valObj.AreaId = valObj2.AreaId;
        valObj.CompanyAccountId = valObj2.CompanyAccountId;
        valObj.CompanyId = valObj2.CompanyId;
        valObj.CompanyName = valObj2.CompanyName;
        valObj.Latitude = valObj2.Latitude;
        valObj.Longitude = valObj2.Longitude;
        valObj.Name = valObj2.Name;
        valObj.Position = valObj2.Position;
        valObj.Role = valObj2.Role;
        valObj.TownId = valObj2.TownId;
        valObj.AccountName = valObj2.AccountName;
        valObj.Authenticated = valObj2.Authenticated;
        valObj.ChargerName = valObj2.ChargerName;
        valObj.CompanyLogo = valObj2.CompanyLogo;
        valObj.CompanyScale = valObj2.CompanyScale;
        valObj.CompanyShareContent = valObj2.CompanyShareContent;
        valObj.CompanyShareLogo = valObj2.CompanyShareLogo;
        valObj.CompanyShareTitle = valObj2.CompanyShareTitle;
        valObj.CompanyShareUrl = valObj2.CompanyShareUrl;
        valObj.CompanyType = valObj2.CompanyType;
        valObj.Email = valObj2.Email;
        valObj.Industry = valObj2.Industry;
        valObj.Introduction = valObj2.Introduction;
        valObj.Qq = valObj2.Qq;
        valObj.CompanyMobile = valObj2.CompanyMobile; 
        valObj.Id = "";
        valObj.CompanyUuid = "";
        valObj.AccountAuthorizedManagerId = "";
        valObj.Address = "";
        valObj.AreaId = "";
        valObj.CompanyAccountId = "";
        valObj.CompanyId = "";
        valObj.CompanyName = "";
        valObj.Latitude = "";
        valObj.Longitude = "";
        valObj.Name = "";
        valObj.Position = "";
        valObj.Role = "";
        valObj.TownId = "";
        valObj.AccountName = "";
        valObj.Authenticated = "";
        valObj.ChargerName = "";
        valObj.CompanyLogo = "";
        valObj.CompanyScale = "";
        valObj.CompanyShareContent = "";
        valObj.CompanyShareLogo = "";
        valObj.CompanyShareTitle = "";
        valObj.CompanyShareUrl = "";
        valObj.CompanyType = "";
        valObj.Email = "";
        valObj.Industry = "";
        valObj.Introduction = "";
        valObj.Qq = "";
        valObj.CompanyMobile = ""; 
        "Id": $("#txt_Id").val(),
        "CompanyUuid": $("#txt_CompanyUuid").val(),
        "AccountAuthorizedManagerId": $("#txt_AccountAuthorizedManagerId").val(),
        "Address": $("#txt_Address").val(),
        "AreaId": $("#txt_AreaId").val(),
        "CompanyAccountId": $("#txt_CompanyAccountId").val(),
        "CompanyId": $("#txt_CompanyId").val(),
        "CompanyName": $("#txt_CompanyName").val(),
        "Latitude": $("#txt_Latitude").val(),
        "Longitude": $("#txt_Longitude").val(),
        "Name": $("#txt_Name").val(),
        "Position": $("#txt_Position").val(),
        "Role": $("#txt_Role").val(),
        "TownId": $("#txt_TownId").val(),
        "AccountName": $("#txt_AccountName").val(),
        "Authenticated": $("#txt_Authenticated").val(),
        "ChargerName": $("#txt_ChargerName").val(),
        "CompanyLogo": $("#txt_CompanyLogo").val(),
        "CompanyScale": $("#txt_CompanyScale").val(),
        "CompanyShareContent": $("#txt_CompanyShareContent").val(),
        "CompanyShareLogo": $("#txt_CompanyShareLogo").val(),
        "CompanyShareTitle": $("#txt_CompanyShareTitle").val(),
        "CompanyShareUrl": $("#txt_CompanyShareUrl").val(),
        "CompanyType": $("#txt_CompanyType").val(),
        "Email": $("#txt_Email").val(),
        "Industry": $("#txt_Industry").val(),
        "Introduction": $("#txt_Introduction").val(),
        "Qq": $("#txt_Qq").val(),
        "CompanyMobile": $("#txt_CompanyMobile").val(), 
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
    /// <para>JZ公司</para>
    /// <para>与Jz_company数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_company : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_company Factory()
        {
            return new Jz_company();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _CompanyUuid
        {            
            get { return this.CompanyUuid; }
            set { this.CompanyUuid = value; }
        }
        
        /// <summary> 帐户授权经理编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AccountAuthorizedManagerId
        {            
            get { return this.AccountAuthorizedManagerId; }
            set { this.AccountAuthorizedManagerId = value; }
        }
        
        /// <summary> 地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> 区域ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AreaId
        {            
            get { return this.AreaId; }
            set { this.AreaId = value; }
        }
        
        /// <summary> 公司帐户ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyAccountId
        {            
            get { return this.CompanyAccountId; }
            set { this.CompanyAccountId = value; }
        }
        
        /// <summary> 公司ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyId
        {            
            get { return this.CompanyId; }
            set { this.CompanyId = value; }
        }
        
        /// <summary> 公司名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyName
        {            
            get { return this.CompanyName; }
            set { this.CompanyName = value; }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Latitude
        {            
            get { return this.Latitude; }
            set { this.Latitude = value; }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Longitude
        {            
            get { return this.Longitude; }
            set { this.Longitude = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 位置:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Position
        {            
            get { return this.Position; }
            set { this.Position = value; }
        }
        
        /// <summary> 的作用:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Role
        {            
            get { return this.Role; }
            set { this.Role = value; }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TownId
        {            
            get { return this.TownId; }
            set { this.TownId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AccountName
        {            
            get { return this.AccountName; }
            set { this.AccountName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Authenticated
        {            
            get { return this.Authenticated; }
            set { this.Authenticated = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChargerName
        {            
            get { return this.ChargerName; }
            set { this.ChargerName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyLogo
        {            
            get { return this.CompanyLogo; }
            set { this.CompanyLogo = value; }
        }
        
        /// <summary> 公司规模:[Enum-{ONE:1~20人},{TWO:21~99人}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _CompanyScale
        {            
            get { return this.CompanyScale; }
            set { this.CompanyScale = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyShareContent
        {            
            get { return this.CompanyShareContent; }
            set { this.CompanyShareContent = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyShareLogo
        {            
            get { return this.CompanyShareLogo; }
            set { this.CompanyShareLogo = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyShareTitle
        {            
            get { return this.CompanyShareTitle; }
            set { this.CompanyShareTitle = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyShareUrl
        {            
            get { return this.CompanyShareUrl; }
            set { this.CompanyShareUrl = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyType
        {            
            get { return this.CompanyType; }
            set { this.CompanyType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Industry
        {            
            get { return this.Industry; }
            set { this.Industry = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Introduction
        {            
            get { return this.Introduction; }
            set { this.Introduction = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Qq
        {            
            get { return this.Qq; }
            set { this.Qq = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyMobile
        {            
            get { return this.CompanyMobile; }
            set { this.CompanyMobile = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Id
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
        public Guid CompanyUuid
        {
            get { return this.m_companyuuid; }
            set //
            {
                if (!companyuuid_initialized || m_companyuuid != value)
                {
                    this.m_companyuuid = value;
                }
                companyuuid_initialized = true;
            }
        }
        
        /// <summary> 帐户授权经理编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AccountAuthorizedManagerId
        {
            get { return this.m_accountauthorizedmanagerid; }
            set //
            {
                if (!accountauthorizedmanagerid_initialized || m_accountauthorizedmanagerid != value)
                {
                    this.m_accountauthorizedmanagerid = value;
                }
                accountauthorizedmanagerid_initialized = true;
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
        
        /// <summary> 区域ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AreaId
        {
            get { return this.m_areaid; }
            set //
            {
                if (!areaid_initialized || m_areaid != value)
                {
                    this.m_areaid = value;
                }
                areaid_initialized = true;
            }
        }
        
        /// <summary> 公司帐户ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CompanyAccountId
        {
            get { return this.m_companyaccountid; }
            set //
            {
                if (!companyaccountid_initialized || m_companyaccountid != value)
                {
                    this.m_companyaccountid = value;
                }
                companyaccountid_initialized = true;
            }
        }
        
        /// <summary> 公司ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CompanyId
        {
            get { return this.m_companyid; }
            set //
            {
                if (!companyid_initialized || m_companyid != value)
                {
                    this.m_companyid = value;
                }
                companyid_initialized = true;
            }
        }
        
        /// <summary> 公司名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyName
        {
            get { return this.m_companyname; }
            set //
            {
                if (!companyname_initialized || m_companyname != value)
                {
                    this.m_companyname = value;
                }
                companyname_initialized = true;
            }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Latitude
        {
            get { return this.m_latitude; }
            set //
            {
                if (!latitude_initialized || m_latitude != value)
                {
                    this.m_latitude = value;
                }
                latitude_initialized = true;
            }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Longitude
        {
            get { return this.m_longitude; }
            set //
            {
                if (!longitude_initialized || m_longitude != value)
                {
                    this.m_longitude = value;
                }
                longitude_initialized = true;
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
        
        /// <summary> 位置:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Position
        {
            get { return this.m_position; }
            set //
            {
                if (!position_initialized || m_position != value)
                {
                    this.m_position = value;
                }
                position_initialized = true;
            }
        }
        
        /// <summary> 的作用:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Role
        {
            get { return this.m_role; }
            set //
            {
                if (!role_initialized || m_role != value)
                {
                    this.m_role = value;
                }
                role_initialized = true;
            }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TownId
        {
            get { return this.m_townid; }
            set //
            {
                if (!townid_initialized || m_townid != value)
                {
                    this.m_townid = value;
                }
                townid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AccountName
        {
            get { return this.m_accountname; }
            set //
            {
                if (!accountname_initialized || m_accountname != value)
                {
                    this.m_accountname = value;
                }
                accountname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Authenticated
        {
            get { return this.m_authenticated; }
            set //
            {
                if (!authenticated_initialized || m_authenticated != value)
                {
                    this.m_authenticated = value;
                }
                authenticated_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChargerName
        {
            get { return this.m_chargername; }
            set //
            {
                if (!chargername_initialized || m_chargername != value)
                {
                    this.m_chargername = value;
                }
                chargername_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyLogo
        {
            get { return this.m_companylogo; }
            set //
            {
                if (!companylogo_initialized || m_companylogo != value)
                {
                    this.m_companylogo = value;
                }
                companylogo_initialized = true;
            }
        }
        
        /// <summary> 公司规模:[Enum-{ONE:1~20人},{TWO:21~99人}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string CompanyScale
        {
            get { return this.m_companyscale; }
            set //
            {
                if (!companyscale_initialized || m_companyscale != value)
                {
                    this.m_companyscale = value;
                }
                companyscale_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyShareContent
        {
            get { return this.m_companysharecontent; }
            set //
            {
                if (!companysharecontent_initialized || m_companysharecontent != value)
                {
                    this.m_companysharecontent = value;
                }
                companysharecontent_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyShareLogo
        {
            get { return this.m_companysharelogo; }
            set //
            {
                if (!companysharelogo_initialized || m_companysharelogo != value)
                {
                    this.m_companysharelogo = value;
                }
                companysharelogo_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyShareTitle
        {
            get { return this.m_companysharetitle; }
            set //
            {
                if (!companysharetitle_initialized || m_companysharetitle != value)
                {
                    this.m_companysharetitle = value;
                }
                companysharetitle_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyShareUrl
        {
            get { return this.m_companyshareurl; }
            set //
            {
                if (!companyshareurl_initialized || m_companyshareurl != value)
                {
                    this.m_companyshareurl = value;
                }
                companyshareurl_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyType
        {
            get { return this.m_companytype; }
            set //
            {
                if (!companytype_initialized || m_companytype != value)
                {
                    this.m_companytype = value;
                }
                companytype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Industry
        {
            get { return this.m_industry; }
            set //
            {
                if (!industry_initialized || m_industry != value)
                {
                    this.m_industry = value;
                }
                industry_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Introduction
        {
            get { return this.m_introduction; }
            set //
            {
                if (!introduction_initialized || m_introduction != value)
                {
                    this.m_introduction = value;
                }
                introduction_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyMobile
        {
            get { return this.m_companymobile; }
            set //
            {
                if (!companymobile_initialized || m_companymobile != value)
                {
                    this.m_companymobile = value;
                }
                companymobile_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jz_company].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyUuid =  new AttributeItem("[Jz_company].[CompanyUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>帐户授权经理编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AccountAuthorizedManagerId =  new AttributeItem("[Jz_company].[AccountAuthorizedManagerId]", typeof(int), 4, default(int));
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Jz_company].[Address]", typeof(string), 50, default(string));
            
            /// <summary>区域ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AreaId =  new AttributeItem("[Jz_company].[AreaId]", typeof(int), 4, default(int));
            
            /// <summary>公司帐户ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyAccountId =  new AttributeItem("[Jz_company].[CompanyAccountId]", typeof(int), 4, default(int));
            
            /// <summary>公司ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyId =  new AttributeItem("[Jz_company].[CompanyId]", typeof(int), 4, default(int));
            
            /// <summary>公司名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyName =  new AttributeItem("[Jz_company].[CompanyName]", typeof(string), 50, default(string));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Latitude =  new AttributeItem("[Jz_company].[Latitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Longitude =  new AttributeItem("[Jz_company].[Longitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Jz_company].[Name]", typeof(string), 50, default(string));
            
            /// <summary>位置:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Position =  new AttributeItem("[Jz_company].[Position]", typeof(string), 50, default(string));
            
            /// <summary>的作用:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Role =  new AttributeItem("[Jz_company].[Role]", typeof(string), 50, default(string));
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownId =  new AttributeItem("[Jz_company].[TownId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AccountName =  new AttributeItem("[Jz_company].[AccountName]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Authenticated =  new AttributeItem("[Jz_company].[Authenticated]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChargerName =  new AttributeItem("[Jz_company].[ChargerName]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyLogo =  new AttributeItem("[Jz_company].[CompanyLogo]", typeof(string), 200, default(string));
            
            /// <summary>公司规模:[Enum-{ONE:1~20人},{TWO:21~99人}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem CompanyScale =  new AttributeItem("[Jz_company].[CompanyScale]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyShareContent =  new AttributeItem("[Jz_company].[CompanyShareContent]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyShareLogo =  new AttributeItem("[Jz_company].[CompanyShareLogo]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyShareTitle =  new AttributeItem("[Jz_company].[CompanyShareTitle]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyShareUrl =  new AttributeItem("[Jz_company].[CompanyShareUrl]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyType =  new AttributeItem("[Jz_company].[CompanyType]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Email =  new AttributeItem("[Jz_company].[Email]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Industry =  new AttributeItem("[Jz_company].[Industry]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Introduction =  new AttributeItem("[Jz_company].[Introduction]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qq =  new AttributeItem("[Jz_company].[Qq]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyMobile =  new AttributeItem("[Jz_company].[CompanyMobile]", typeof(string), 20, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_companyuuid;
        /// <summary></summary>
        protected bool companyuuid_initialized = false;
        
        private int m_accountauthorizedmanagerid;
        /// <summary></summary>
        protected bool accountauthorizedmanagerid_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private int m_areaid;
        /// <summary></summary>
        protected bool areaid_initialized = false;
        
        private int m_companyaccountid;
        /// <summary></summary>
        protected bool companyaccountid_initialized = false;
        
        private int m_companyid;
        /// <summary></summary>
        protected bool companyid_initialized = false;
        
        private string m_companyname;
        /// <summary></summary>
        protected bool companyname_initialized = false;
        
        private decimal m_latitude;
        /// <summary></summary>
        protected bool latitude_initialized = false;
        
        private decimal m_longitude;
        /// <summary></summary>
        protected bool longitude_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_position;
        /// <summary></summary>
        protected bool position_initialized = false;
        
        private string m_role;
        /// <summary></summary>
        protected bool role_initialized = false;
        
        private int m_townid;
        /// <summary></summary>
        protected bool townid_initialized = false;
        
        private string m_accountname;
        /// <summary></summary>
        protected bool accountname_initialized = false;
        
        private string m_authenticated;
        /// <summary></summary>
        protected bool authenticated_initialized = false;
        
        private string m_chargername;
        /// <summary></summary>
        protected bool chargername_initialized = false;
        
        private string m_companylogo;
        /// <summary></summary>
        protected bool companylogo_initialized = false;
        
        private string m_companyscale;
        /// <summary></summary>
        protected bool companyscale_initialized = false;
        
        private string m_companysharecontent;
        /// <summary></summary>
        protected bool companysharecontent_initialized = false;
        
        private string m_companysharelogo;
        /// <summary></summary>
        protected bool companysharelogo_initialized = false;
        
        private string m_companysharetitle;
        /// <summary></summary>
        protected bool companysharetitle_initialized = false;
        
        private string m_companyshareurl;
        /// <summary></summary>
        protected bool companyshareurl_initialized = false;
        
        private string m_companytype;
        /// <summary></summary>
        protected bool companytype_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private string m_industry;
        /// <summary></summary>
        protected bool industry_initialized = false;
        
        private string m_introduction;
        /// <summary></summary>
        protected bool introduction_initialized = false;
        
        private string m_qq;
        /// <summary></summary>
        protected bool qq_initialized = false;
        
        private string m_companymobile;
        /// <summary></summary>
        protected bool companymobile_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_company";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.companyuuid_initialized = IsLoadAllAttributes;this.accountauthorizedmanagerid_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.areaid_initialized = IsLoadAllAttributes;this.companyaccountid_initialized = IsLoadAllAttributes;this.companyid_initialized = IsLoadAllAttributes;this.companyname_initialized = IsLoadAllAttributes;this.latitude_initialized = IsLoadAllAttributes;this.longitude_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.position_initialized = IsLoadAllAttributes;this.role_initialized = IsLoadAllAttributes;this.townid_initialized = IsLoadAllAttributes;this.accountname_initialized = IsLoadAllAttributes;this.authenticated_initialized = IsLoadAllAttributes;this.chargername_initialized = IsLoadAllAttributes;this.companylogo_initialized = IsLoadAllAttributes;this.companyscale_initialized = IsLoadAllAttributes;this.companysharecontent_initialized = IsLoadAllAttributes;this.companysharelogo_initialized = IsLoadAllAttributes;this.companysharetitle_initialized = IsLoadAllAttributes;this.companyshareurl_initialized = IsLoadAllAttributes;this.companytype_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.industry_initialized = IsLoadAllAttributes;this.introduction_initialized = IsLoadAllAttributes;this.qq_initialized = IsLoadAllAttributes;this.companymobile_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_company value = new Jz_company();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyUuid"))
				value.companyuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AccountAuthorizedManagerId"))
				value.accountauthorizedmanagerid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AreaId"))
				value.areaid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyAccountId"))
				value.companyaccountid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyId"))
				value.companyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyName"))
				value.companyname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Latitude"))
				value.latitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Longitude"))
				value.longitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Position"))
				value.position_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Role"))
				value.role_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownId"))
				value.townid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AccountName"))
				value.accountname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Authenticated"))
				value.authenticated_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChargerName"))
				value.chargername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyLogo"))
				value.companylogo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyScale"))
				value.companyscale_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyShareContent"))
				value.companysharecontent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyShareLogo"))
				value.companysharelogo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyShareTitle"))
				value.companysharetitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyShareUrl"))
				value.companyshareurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyType"))
				value.companytype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Industry"))
				value.industry_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduction"))
				value.introduction_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qq"))
				value.qq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyMobile"))
				value.companymobile_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_company Clone()
        {
            return (Jz_company)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_company()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_company() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_company(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_company(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_company(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_company(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_company(Guid id1, Guid companyuuid1, int accountauthorizedmanagerid1, string address1, int areaid1, int companyaccountid1, int companyid1, string companyname1, decimal latitude1, decimal longitude1, string name1, string position1, string role1, int townid1, string accountname1, string authenticated1, string chargername1, string companylogo1, string companyscale1, string companysharecontent1, string companysharelogo1, string companysharetitle1, string companyshareurl1, string companytype1, string email1, string industry1, string introduction1, string qq1, string companymobile1)
        {
            
            this.Id = id1;
            
            this.CompanyUuid = companyuuid1;
            
            this.AccountAuthorizedManagerId = accountauthorizedmanagerid1;
            
            this.Address = address1;
            
            this.AreaId = areaid1;
            
            this.CompanyAccountId = companyaccountid1;
            
            this.CompanyId = companyid1;
            
            this.CompanyName = companyname1;
            
            this.Latitude = latitude1;
            
            this.Longitude = longitude1;
            
            this.Name = name1;
            
            this.Position = position1;
            
            this.Role = role1;
            
            this.TownId = townid1;
            
            this.AccountName = accountname1;
            
            this.Authenticated = authenticated1;
            
            this.ChargerName = chargername1;
            
            this.CompanyLogo = companylogo1;
            
            this.CompanyScale = companyscale1;
            
            this.CompanyShareContent = companysharecontent1;
            
            this.CompanyShareLogo = companysharelogo1;
            
            this.CompanyShareTitle = companysharetitle1;
            
            this.CompanyShareUrl = companyshareurl1;
            
            this.CompanyType = companytype1;
            
            this.Email = email1;
            
            this.Industry = industry1;
            
            this.Introduction = introduction1;
            
            this.Qq = qq1;
            
            this.CompanyMobile = companymobile1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_company FromIView(IView view)
        {
            return (Jz_company)IView.GetITable(view, "Jz_company");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_company GetOneInstance()
        {
            Jz_company value = new Jz_company();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_company Retrieve()
        {
            BLLTable<Jz_company>.GetRowData(this);
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
			    			
			    case "CompanyUuid":
			        return CompanyUuid;
			    			
			    case "AccountAuthorizedManagerId":
			        return AccountAuthorizedManagerId;
			    			
			    case "Address":
			        return Address;
			    			
			    case "AreaId":
			        return AreaId;
			    			
			    case "CompanyAccountId":
			        return CompanyAccountId;
			    			
			    case "CompanyId":
			        return CompanyId;
			    			
			    case "CompanyName":
			        return CompanyName;
			    			
			    case "Latitude":
			        return Latitude;
			    			
			    case "Longitude":
			        return Longitude;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Position":
			        return Position;
			    			
			    case "Role":
			        return Role;
			    			
			    case "TownId":
			        return TownId;
			    			
			    case "AccountName":
			        return AccountName;
			    			
			    case "Authenticated":
			        return Authenticated;
			    			
			    case "ChargerName":
			        return ChargerName;
			    			
			    case "CompanyLogo":
			        return CompanyLogo;
			    			
			    case "CompanyScale":
			        return CompanyScale;
			    			
			    case "CompanyShareContent":
			        return CompanyShareContent;
			    			
			    case "CompanyShareLogo":
			        return CompanyShareLogo;
			    			
			    case "CompanyShareTitle":
			        return CompanyShareTitle;
			    			
			    case "CompanyShareUrl":
			        return CompanyShareUrl;
			    			
			    case "CompanyType":
			        return CompanyType;
			    			
			    case "Email":
			        return Email;
			    			
			    case "Industry":
			        return Industry;
			    			
			    case "Introduction":
			        return Introduction;
			    			
			    case "Qq":
			        return Qq;
			    			
			    case "CompanyMobile":
			        return CompanyMobile;
			
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
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CompanyUuid":
			        this.CompanyUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "AccountAuthorizedManagerId":
			        this.AccountAuthorizedManagerId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AreaId":
			        this.AreaId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CompanyAccountId":
			        this.CompanyAccountId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CompanyId":
			        this.CompanyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CompanyName":
			        this.CompanyName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Latitude":
			        this.Latitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Longitude":
			        this.Longitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Position":
			        this.Position = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Role":
			        this.Role = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TownId":
			        this.TownId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AccountName":
			        this.AccountName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Authenticated":
			        this.Authenticated = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChargerName":
			        this.ChargerName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyLogo":
			        this.CompanyLogo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyScale":
			        this.CompanyScale = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyShareContent":
			        this.CompanyShareContent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyShareLogo":
			        this.CompanyShareLogo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyShareTitle":
			        this.CompanyShareTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyShareUrl":
			        this.CompanyShareUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyType":
			        this.CompanyType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Industry":
			        this.Industry = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduction":
			        this.Introduction = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qq":
			        this.Qq = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyMobile":
			        this.CompanyMobile = Convert.ToString(AttributeValue);
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
				
				case "CompanyUuid":
					return companyuuid_initialized;
				
				case "AccountAuthorizedManagerId":
					return accountauthorizedmanagerid_initialized;
				
				case "Address":
					return address_initialized;
				
				case "AreaId":
					return areaid_initialized;
				
				case "CompanyAccountId":
					return companyaccountid_initialized;
				
				case "CompanyId":
					return companyid_initialized;
				
				case "CompanyName":
					return companyname_initialized;
				
				case "Latitude":
					return latitude_initialized;
				
				case "Longitude":
					return longitude_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Position":
					return position_initialized;
				
				case "Role":
					return role_initialized;
				
				case "TownId":
					return townid_initialized;
				
				case "AccountName":
					return accountname_initialized;
				
				case "Authenticated":
					return authenticated_initialized;
				
				case "ChargerName":
					return chargername_initialized;
				
				case "CompanyLogo":
					return companylogo_initialized;
				
				case "CompanyScale":
					return companyscale_initialized;
				
				case "CompanyShareContent":
					return companysharecontent_initialized;
				
				case "CompanyShareLogo":
					return companysharelogo_initialized;
				
				case "CompanyShareTitle":
					return companysharetitle_initialized;
				
				case "CompanyShareUrl":
					return companyshareurl_initialized;
				
				case "CompanyType":
					return companytype_initialized;
				
				case "Email":
					return email_initialized;
				
				case "Industry":
					return industry_initialized;
				
				case "Introduction":
					return introduction_initialized;
				
				case "Qq":
					return qq_initialized;
				
				case "CompanyMobile":
					return companymobile_initialized;
				
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
				
				case "CompanyUuid":
					companyuuid_initialized = ret;
					return true;
				
				case "AccountAuthorizedManagerId":
					accountauthorizedmanagerid_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "AreaId":
					areaid_initialized = ret;
					return true;
				
				case "CompanyAccountId":
					companyaccountid_initialized = ret;
					return true;
				
				case "CompanyId":
					companyid_initialized = ret;
					return true;
				
				case "CompanyName":
					companyname_initialized = ret;
					return true;
				
				case "Latitude":
					latitude_initialized = ret;
					return true;
				
				case "Longitude":
					longitude_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Position":
					position_initialized = ret;
					return true;
				
				case "Role":
					role_initialized = ret;
					return true;
				
				case "TownId":
					townid_initialized = ret;
					return true;
				
				case "AccountName":
					accountname_initialized = ret;
					return true;
				
				case "Authenticated":
					authenticated_initialized = ret;
					return true;
				
				case "ChargerName":
					chargername_initialized = ret;
					return true;
				
				case "CompanyLogo":
					companylogo_initialized = ret;
					return true;
				
				case "CompanyScale":
					companyscale_initialized = ret;
					return true;
				
				case "CompanyShareContent":
					companysharecontent_initialized = ret;
					return true;
				
				case "CompanyShareLogo":
					companysharelogo_initialized = ret;
					return true;
				
				case "CompanyShareTitle":
					companysharetitle_initialized = ret;
					return true;
				
				case "CompanyShareUrl":
					companyshareurl_initialized = ret;
					return true;
				
				case "CompanyType":
					companytype_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "Industry":
					industry_initialized = ret;
					return true;
				
				case "Introduction":
					introduction_initialized = ret;
					return true;
				
				case "Qq":
					qq_initialized = ret;
					return true;
				
				case "CompanyMobile":
					companymobile_initialized = ret;
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
                AttributeItem attr = Jz_company.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (companyuuid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyUuid);
                }
			}
			
			if (accountauthorizedmanagerid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.AccountAuthorizedManagerId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AccountAuthorizedManagerId);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (areaid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.AreaId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AreaId);
                }
			}
			
			if (companyaccountid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyAccountId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyAccountId);
                }
			}
			
			if (companyid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyId);
                }
			}
			
			if (companyname_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyName);
                }
			}
			
			if (latitude_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Latitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Latitude);
                }
			}
			
			if (longitude_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Longitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Longitude);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (position_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Position;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Position);
                }
			}
			
			if (role_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Role;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Role);
                }
			}
			
			if (townid_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.TownId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownId);
                }
			}
			
			if (accountname_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.AccountName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AccountName);
                }
			}
			
			if (authenticated_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Authenticated;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Authenticated);
                }
			}
			
			if (chargername_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.ChargerName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChargerName);
                }
			}
			
			if (companylogo_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyLogo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyLogo);
                }
			}
			
			if (companyscale_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyScale;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyScale);
                }
			}
			
			if (companysharecontent_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyShareContent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyShareContent);
                }
			}
			
			if (companysharelogo_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyShareLogo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyShareLogo);
                }
			}
			
			if (companysharetitle_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyShareTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyShareTitle);
                }
			}
			
			if (companyshareurl_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyShareUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyShareUrl);
                }
			}
			
			if (companytype_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyType);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (industry_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Industry;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Industry);
                }
			}
			
			if (introduction_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Introduction;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduction);
                }
			}
			
			if (qq_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.Qq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qq);
                }
			}
			
			if (companymobile_initialized)
			{
                AttributeItem attr = Jz_company.Attribute.CompanyMobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyMobile);
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
        public class Jz_companyJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public Guid Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid CompanyUuid { get; set; }
            
            /// <summary>帐户授权经理编号:[CtrlTypeDic-{InputString}]</summary>
            public int AccountAuthorizedManagerId { get; set; }
            
            /// <summary>地址:[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>区域ID:[CtrlTypeDic-{InputString}]</summary>
            public int AreaId { get; set; }
            
            /// <summary>公司帐户ID:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyAccountId { get; set; }
            
            /// <summary>公司ID:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyId { get; set; }
            
            /// <summary>公司名称:[CtrlTypeDic-{InputString}]</summary>
            public string CompanyName { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Latitude { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Longitude { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>位置:[CtrlTypeDic-{InputString}]</summary>
            public string Position { get; set; }
            
            /// <summary>的作用:[CtrlTypeDic-{InputString}]</summary>
            public string Role { get; set; }
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public int TownId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string AccountName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Authenticated { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ChargerName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyLogo { get; set; }
            
            /// <summary>公司规模:[Enum-{ONE:1~20人},{TWO:21~99人}][CtrlTypeDic-{SelectDrop}]</summary>
            public string CompanyScale { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyShareContent { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyShareLogo { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyShareTitle { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyShareUrl { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Email { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Industry { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Introduction { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Qq { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyMobile { get; set; }
        }
        #endregion
    }
}