/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:20
  Description:    数据表Jz_partJobs对应的业务逻辑层Jz_partJobs
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_partJobs_Entity:Jz_partJobs
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,PartJobId,PartJobUuid,AddressDetail,AreaId,Category,ClearingForm,CompanyType,CompanyUuid,Contacter,CreateTime,Duration,EntryCount,EntryDeadline,HotScore,JobCount,JobTime,JobTimeStandard,Latitude,Longitude,NeedInterview,NewJobStandTime,PartJobLogo,PartJobTitle,Salary,SalaryTimeUnit,SalaryUnit,SexRequire,Status,TownId,Type,ViewCount,AddressBuilding,PartJobTags,BondMoney,ModifyTime,User_id,ClassificationId,ParentId,SalaryTicketType,WorkTime,CompanyId,JobDescription,Bonus,Welfare,ContentPrompt,HealthRequire,HeightRequire,InterviewTime,InterviewAddress,NeedHeight,NeedHealth,Users,Distance from Jz_partJobs
delete from Jz_partJobs
INSERT INTO Jz_partJobs (Id,PartJobId,PartJobUuid,AddressDetail,AreaId,Category,ClearingForm,CompanyType,CompanyUuid,Contacter,CreateTime,Duration,EntryCount,EntryDeadline,HotScore,JobCount,JobTime,JobTimeStandard,Latitude,Longitude,NeedInterview,NewJobStandTime,PartJobLogo,PartJobTitle,Salary,SalaryTimeUnit,SalaryUnit,SexRequire,Status,TownId,Type,ViewCount,AddressBuilding,PartJobTags,BondMoney,ModifyTime,User_id,ClassificationId,ParentId,SalaryTicketType,WorkTime,CompanyId,JobDescription,Bonus,Welfare,ContentPrompt,HealthRequire,HeightRequire,InterviewTime,InterviewAddress,NeedHeight,NeedHealth,Users,Distance)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Jz_partJobs SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.PartJobId = valObj2.PartJobId;
        valObj.PartJobUuid = valObj2.PartJobUuid;
        valObj.AddressDetail = valObj2.AddressDetail;
        valObj.AreaId = valObj2.AreaId;
        valObj.Category = valObj2.Category;
        valObj.ClearingForm = valObj2.ClearingForm;
        valObj.CompanyType = valObj2.CompanyType;
        valObj.CompanyUuid = valObj2.CompanyUuid;
        valObj.Contacter = valObj2.Contacter;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Duration = valObj2.Duration;
        valObj.EntryCount = valObj2.EntryCount;
        valObj.EntryDeadline = valObj2.EntryDeadline;
        valObj.HotScore = valObj2.HotScore;
        valObj.JobCount = valObj2.JobCount;
        valObj.JobTime = valObj2.JobTime;
        valObj.JobTimeStandard = valObj2.JobTimeStandard;
        valObj.Latitude = valObj2.Latitude;
        valObj.Longitude = valObj2.Longitude;
        valObj.NeedInterview = valObj2.NeedInterview;
        valObj.NewJobStandTime = valObj2.NewJobStandTime;
        valObj.PartJobLogo = valObj2.PartJobLogo;
        valObj.PartJobTitle = valObj2.PartJobTitle;
        valObj.Salary = valObj2.Salary;
        valObj.SalaryTimeUnit = valObj2.SalaryTimeUnit;
        valObj.SalaryUnit = valObj2.SalaryUnit;
        valObj.SexRequire = valObj2.SexRequire;
        valObj.Status = valObj2.Status;
        valObj.TownId = valObj2.TownId;
        valObj.Type = valObj2.Type;
        valObj.ViewCount = valObj2.ViewCount;
        valObj.AddressBuilding = valObj2.AddressBuilding;
        valObj.PartJobTags = valObj2.PartJobTags;
        valObj.BondMoney = valObj2.BondMoney;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.ClassificationId = valObj2.ClassificationId;
        valObj.ParentId = valObj2.ParentId;
        valObj.SalaryTicketType = valObj2.SalaryTicketType;
        valObj.WorkTime = valObj2.WorkTime;
        valObj.CompanyId = valObj2.CompanyId;
        valObj.JobDescription = valObj2.JobDescription;
        valObj.Bonus = valObj2.Bonus;
        valObj.Welfare = valObj2.Welfare;
        valObj.ContentPrompt = valObj2.ContentPrompt;
        valObj.HealthRequire = valObj2.HealthRequire;
        valObj.HeightRequire = valObj2.HeightRequire;
        valObj.InterviewTime = valObj2.InterviewTime;
        valObj.InterviewAddress = valObj2.InterviewAddress;
        valObj.NeedHeight = valObj2.NeedHeight;
        valObj.NeedHealth = valObj2.NeedHealth;
        valObj.Users = valObj2.Users;
        valObj.Distance = valObj2.Distance; 
        valObj.Id = "";
        valObj.PartJobId = "";
        valObj.PartJobUuid = "";
        valObj.AddressDetail = "";
        valObj.AreaId = "";
        valObj.Category = "";
        valObj.ClearingForm = "";
        valObj.CompanyType = "";
        valObj.CompanyUuid = "";
        valObj.Contacter = "";
        valObj.CreateTime = "";
        valObj.Duration = "";
        valObj.EntryCount = "";
        valObj.EntryDeadline = "";
        valObj.HotScore = "";
        valObj.JobCount = "";
        valObj.JobTime = "";
        valObj.JobTimeStandard = "";
        valObj.Latitude = "";
        valObj.Longitude = "";
        valObj.NeedInterview = "";
        valObj.NewJobStandTime = "";
        valObj.PartJobLogo = "";
        valObj.PartJobTitle = "";
        valObj.Salary = "";
        valObj.SalaryTimeUnit = "";
        valObj.SalaryUnit = "";
        valObj.SexRequire = "";
        valObj.Status = "";
        valObj.TownId = "";
        valObj.Type = "";
        valObj.ViewCount = "";
        valObj.AddressBuilding = "";
        valObj.PartJobTags = "";
        valObj.BondMoney = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.ClassificationId = "";
        valObj.ParentId = "";
        valObj.SalaryTicketType = "";
        valObj.WorkTime = "";
        valObj.CompanyId = "";
        valObj.JobDescription = "";
        valObj.Bonus = "";
        valObj.Welfare = "";
        valObj.ContentPrompt = "";
        valObj.HealthRequire = "";
        valObj.HeightRequire = "";
        valObj.InterviewTime = "";
        valObj.InterviewAddress = "";
        valObj.NeedHeight = "";
        valObj.NeedHealth = "";
        valObj.Users = "";
        valObj.Distance = ""; 
        "Id": $("#txt_Id").val(),
        "PartJobId": $("#txt_PartJobId").val(),
        "PartJobUuid": $("#txt_PartJobUuid").val(),
        "AddressDetail": $("#txt_AddressDetail").val(),
        "AreaId": $("#txt_AreaId").val(),
        "Category": $("#txt_Category").val(),
        "ClearingForm": $("#txt_ClearingForm").val(),
        "CompanyType": $("#txt_CompanyType").val(),
        "CompanyUuid": $("#txt_CompanyUuid").val(),
        "Contacter": $("#txt_Contacter").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Duration": $("#txt_Duration").val(),
        "EntryCount": $("#txt_EntryCount").val(),
        "EntryDeadline": $("#txt_EntryDeadline").val(),
        "HotScore": $("#txt_HotScore").val(),
        "JobCount": $("#txt_JobCount").val(),
        "JobTime": $("#txt_JobTime").val(),
        "JobTimeStandard": $("#txt_JobTimeStandard").val(),
        "Latitude": $("#txt_Latitude").val(),
        "Longitude": $("#txt_Longitude").val(),
        "NeedInterview": $("#txt_NeedInterview").val(),
        "NewJobStandTime": $("#txt_NewJobStandTime").val(),
        "PartJobLogo": $("#txt_PartJobLogo").val(),
        "PartJobTitle": $("#txt_PartJobTitle").val(),
        "Salary": $("#txt_Salary").val(),
        "SalaryTimeUnit": $("#txt_SalaryTimeUnit").val(),
        "SalaryUnit": $("#txt_SalaryUnit").val(),
        "SexRequire": $("#txt_SexRequire").val(),
        "Status": $("#txt_Status").val(),
        "TownId": $("#txt_TownId").val(),
        "Type": $("#txt_Type").val(),
        "ViewCount": $("#txt_ViewCount").val(),
        "AddressBuilding": $("#txt_AddressBuilding").val(),
        "PartJobTags": $("#txt_PartJobTags").val(),
        "BondMoney": $("#txt_BondMoney").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(),
        "ClassificationId": $("#txt_ClassificationId").val(),
        "ParentId": $("#txt_ParentId").val(),
        "SalaryTicketType": $("#txt_SalaryTicketType").val(),
        "WorkTime": $("#txt_WorkTime").val(),
        "CompanyId": $("#txt_CompanyId").val(),
        "JobDescription": $("#txt_JobDescription").val(),
        "Bonus": $("#txt_Bonus").val(),
        "Welfare": $("#txt_Welfare").val(),
        "ContentPrompt": $("#txt_ContentPrompt").val(),
        "HealthRequire": $("#txt_HealthRequire").val(),
        "HeightRequire": $("#txt_HeightRequire").val(),
        "InterviewTime": $("#txt_InterviewTime").val(),
        "InterviewAddress": $("#txt_InterviewAddress").val(),
        "NeedHeight": $("#txt_NeedHeight").val(),
        "NeedHealth": $("#txt_NeedHealth").val(),
        "Users": $("#txt_Users").val(),
        "Distance": $("#txt_Distance").val(), 
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
    /// <para>兼职表</para>
    /// <para>与Jz_partJobs数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_partJobs : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_partJobs Factory()
        {
            return new Jz_partJobs();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 部分职位编号:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _PartJobId
        {            
            get { return this.PartJobId; }
            set { this.PartJobId = value; }
        }
        
        /// <summary> 部分职位uuid:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _PartJobUuid
        {            
            get { return this.PartJobUuid; }
            set { this.PartJobUuid = value; }
        }
        
        /// <summary> 详细地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AddressDetail
        {            
            get { return this.AddressDetail; }
            set { this.AddressDetail = value; }
        }
        
        /// <summary> 地区id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AreaId
        {            
            get { return this.AreaId; }
            set { this.AreaId = value; }
        }
        
        /// <summary> 类别:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category
        {            
            get { return this.Category; }
            set { this.Category = value; }
        }
        
        /// <summary> 结算方式:[Enum-{YEAR:年结},{DAY:日结},{WEEK:周结},{MONTH:月结},{OVER:完工结算},{OTHER:其他结算}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _ClearingForm
        {            
            get { return this.ClearingForm; }
            set { this.ClearingForm = value; }
        }
        
        /// <summary> 公司类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyType
        {            
            get { return this.CompanyType; }
            set { this.CompanyType = value; }
        }
        
        /// <summary> 公司uuid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _CompanyUuid
        {            
            get { return this.CompanyUuid; }
            set { this.CompanyUuid = value; }
        }
        
        /// <summary> 联系人:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Contacter
        {            
            get { return this.Contacter; }
            set { this.Contacter = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 持续时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Duration
        {            
            get { return this.Duration; }
            set { this.Duration = value; }
        }
        
        /// <summary> 入口计数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _EntryCount
        {            
            get { return this.EntryCount; }
            set { this.EntryCount = value; }
        }
        
        /// <summary> 报名截止日期:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _EntryDeadline
        {            
            get { return this.EntryDeadline; }
            set { this.EntryDeadline = value; }
        }
        
        /// <summary> 热度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _HotScore
        {            
            get { return this.HotScore; }
            set { this.HotScore = value; }
        }
        
        /// <summary> 作业数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _JobCount
        {            
            get { return this.JobCount; }
            set { this.JobCount = value; }
        }
        
        /// <summary> 作业时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _JobTime
        {            
            get { return this.JobTime; }
            set { this.JobTime = value; }
        }
        
        /// <summary> 工作时间标准:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _JobTimeStandard
        {            
            get { return this.JobTimeStandard; }
            set { this.JobTimeStandard = value; }
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
        
        /// <summary> 是否需要面试:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _NeedInterview
        {            
            get { return this.NeedInterview; }
            set { this.NeedInterview = value; }
        }
        
        /// <summary> 新工作时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NewJobStandTime
        {            
            get { return this.NewJobStandTime; }
            set { this.NewJobStandTime = value; }
        }
        
        /// <summary> 部分工作的标志:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PartJobLogo
        {            
            get { return this.PartJobLogo; }
            set { this.PartJobLogo = value; }
        }
        
        /// <summary> 部分工作主题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PartJobTitle
        {            
            get { return this.PartJobTitle; }
            set { this.PartJobTitle = value; }
        }
        
        /// <summary> 工资:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Salary
        {            
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        
        /// <summary> 工资的时间单位:[Enum-{TIMES:元/次},{DAY:元/天},{HOUR:元/小时}][CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _SalaryTimeUnit
        {            
            get { return this.SalaryTimeUnit; }
            set { this.SalaryTimeUnit = value; }
        }
        
        /// <summary> 工资单位:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _SalaryUnit
        {            
            get { return this.SalaryUnit; }
            set { this.SalaryUnit = value; }
        }
        
        /// <summary> 性别要求:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SexRequire
        {            
            get { return this.SexRequire; }
            set { this.SexRequire = value; }
        }
        
        /// <summary> 现状:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> 镇id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TownId
        {            
            get { return this.TownId; }
            set { this.TownId = value; }
        }
        
        /// <summary> 类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> 查看数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ViewCount
        {            
            get { return this.ViewCount; }
            set { this.ViewCount = value; }
        }
        
        /// <summary> 地址建筑:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AddressBuilding
        {            
            get { return this.AddressBuilding; }
            set { this.AddressBuilding = value; }
        }
        
        /// <summary> 部分工作标签:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PartJobTags
        {            
            get { return this.PartJobTags; }
            set { this.PartJobTags = value; }
        }
        
        /// <summary> 债券的钱:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BondMoney
        {            
            get { return this.BondMoney; }
            set { this.BondMoney = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ParentId
        {            
            get { return this.ParentId; }
            set { this.ParentId = value; }
        }
        
        /// <summary> 工资票种:[CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public bool _SalaryTicketType
        {            
            get { return this.SalaryTicketType; }
            set { this.SalaryTicketType = value; }
        }
        
        /// <summary> 工作时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WorkTime
        {            
            get { return this.WorkTime; }
            set { this.WorkTime = value; }
        }
        
        /// <summary> 公司id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyId
        {            
            get { return this.CompanyId; }
            set { this.CompanyId = value; }
        }
        
        /// <summary> 工作描述:[CtrlTypeDic-{InputPhone}] Attribute_IsNotNull </summary>
        public string _JobDescription
        {            
            get { return this.JobDescription; }
            set { this.JobDescription = value; }
        }
        
        /// <summary> 奖金:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Bonus
        {            
            get { return this.Bonus; }
            set { this.Bonus = value; }
        }
        
        /// <summary> 福利:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Welfare
        {            
            get { return this.Welfare; }
            set { this.Welfare = value; }
        }
        
        /// <summary> 内容提示:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ContentPrompt
        {            
            get { return this.ContentPrompt; }
            set { this.ContentPrompt = value; }
        }
        
        /// <summary> 卫生要求:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HealthRequire
        {            
            get { return this.HealthRequire; }
            set { this.HealthRequire = value; }
        }
        
        /// <summary> 身高要求:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HeightRequire
        {            
            get { return this.HeightRequire; }
            set { this.HeightRequire = value; }
        }
        
        /// <summary> 面试时间:[CtrlTypeDic-{InputDecimal}] Attribute_IsNotNull </summary>
        public DateTime _InterviewTime
        {            
            get { return this.InterviewTime; }
            set { this.InterviewTime = value; }
        }
        
        /// <summary> 面试地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _InterviewAddress
        {            
            get { return this.InterviewAddress; }
            set { this.InterviewAddress = value; }
        }
        
        /// <summary> 要求身高:[CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public bool _NeedHeight
        {            
            get { return this.NeedHeight; }
            set { this.NeedHeight = value; }
        }
        
        /// <summary> 要求健康:[CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public bool _NeedHealth
        {            
            get { return this.NeedHealth; }
            set { this.NeedHealth = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Users
        {            
            get { return this.Users; }
            set { this.Users = value; }
        }
        
        /// <summary> 持续时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Distance
        {            
            get { return this.Distance; }
            set { this.Distance = value; }
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
        
        /// <summary> 部分职位编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PartJobId
        {
            get { return this.m_partjobid; }
            set //
            {
                if (!partjobid_initialized || m_partjobid != value)
                {
                    this.m_partjobid = value;
                }
                partjobid_initialized = true;
            }
        }
        
        /// <summary> 部分职位uuid:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid PartJobUuid
        {
            get { return this.m_partjobuuid; }
            set //
            {
                if (!partjobuuid_initialized || m_partjobuuid != value)
                {
                    this.m_partjobuuid = value;
                }
                partjobuuid_initialized = true;
            }
        }
        
        /// <summary> 详细地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AddressDetail
        {
            get { return this.m_addressdetail; }
            set //
            {
                if (!addressdetail_initialized || m_addressdetail != value)
                {
                    this.m_addressdetail = value;
                }
                addressdetail_initialized = true;
            }
        }
        
        /// <summary> 地区id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 类别:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category
        {
            get { return this.m_category; }
            set //
            {
                if (!category_initialized || m_category != value)
                {
                    this.m_category = value;
                }
                category_initialized = true;
            }
        }
        
        /// <summary> 结算方式:[Enum-{YEAR:年结},{DAY:日结},{WEEK:周结},{MONTH:月结},{OVER:完工结算},{OTHER:其他结算}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string ClearingForm
        {
            get { return this.m_clearingform; }
            set //
            {
                if (!clearingform_initialized || m_clearingform != value)
                {
                    this.m_clearingform = value;
                }
                clearingform_initialized = true;
            }
        }
        
        /// <summary> 公司类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 公司uuid:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 联系人:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Contacter
        {
            get { return this.m_contacter; }
            set //
            {
                if (!contacter_initialized || m_contacter != value)
                {
                    this.m_contacter = value;
                }
                contacter_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CreateTime
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
        
        /// <summary> 持续时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Duration
        {
            get { return this.m_duration; }
            set //
            {
                if (!duration_initialized || m_duration != value)
                {
                    this.m_duration = value;
                }
                duration_initialized = true;
            }
        }
        
        /// <summary> 入口计数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int EntryCount
        {
            get { return this.m_entrycount; }
            set //
            {
                if (!entrycount_initialized || m_entrycount != value)
                {
                    this.m_entrycount = value;
                }
                entrycount_initialized = true;
            }
        }
        
        /// <summary> 报名截止日期:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string EntryDeadline
        {
            get { return this.m_entrydeadline; }
            set //
            {
                if (!entrydeadline_initialized || m_entrydeadline != value)
                {
                    this.m_entrydeadline = value;
                }
                entrydeadline_initialized = true;
            }
        }
        
        /// <summary> 热度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int HotScore
        {
            get { return this.m_hotscore; }
            set //
            {
                if (!hotscore_initialized || m_hotscore != value)
                {
                    this.m_hotscore = value;
                }
                hotscore_initialized = true;
            }
        }
        
        /// <summary> 作业数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int JobCount
        {
            get { return this.m_jobcount; }
            set //
            {
                if (!jobcount_initialized || m_jobcount != value)
                {
                    this.m_jobcount = value;
                }
                jobcount_initialized = true;
            }
        }
        
        /// <summary> 作业时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string JobTime
        {
            get { return this.m_jobtime; }
            set //
            {
                if (!jobtime_initialized || m_jobtime != value)
                {
                    this.m_jobtime = value;
                }
                jobtime_initialized = true;
            }
        }
        
        /// <summary> 工作时间标准:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string JobTimeStandard
        {
            get { return this.m_jobtimestandard; }
            set //
            {
                if (!jobtimestandard_initialized || m_jobtimestandard != value)
                {
                    this.m_jobtimestandard = value;
                }
                jobtimestandard_initialized = true;
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
        
        /// <summary> 是否需要面试:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool NeedInterview
        {
            get { return this.m_needinterview; }
            set //
            {
                if (!needinterview_initialized || m_needinterview != value)
                {
                    this.m_needinterview = value;
                }
                needinterview_initialized = true;
            }
        }
        
        /// <summary> 新工作时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NewJobStandTime
        {
            get { return this.m_newjobstandtime; }
            set //
            {
                if (!newjobstandtime_initialized || m_newjobstandtime != value)
                {
                    this.m_newjobstandtime = value;
                }
                newjobstandtime_initialized = true;
            }
        }
        
        /// <summary> 部分工作的标志:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PartJobLogo
        {
            get { return this.m_partjoblogo; }
            set //
            {
                if (!partjoblogo_initialized || m_partjoblogo != value)
                {
                    this.m_partjoblogo = value;
                }
                partjoblogo_initialized = true;
            }
        }
        
        /// <summary> 部分工作主题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PartJobTitle
        {
            get { return this.m_partjobtitle; }
            set //
            {
                if (!partjobtitle_initialized || m_partjobtitle != value)
                {
                    this.m_partjobtitle = value;
                }
                partjobtitle_initialized = true;
            }
        }
        
        /// <summary> 工资:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Salary
        {
            get { return this.m_salary; }
            set //
            {
                if (!salary_initialized || m_salary != value)
                {
                    this.m_salary = value;
                }
                salary_initialized = true;
            }
        }
        
        /// <summary> 工资的时间单位:[Enum-{TIMES:元/次},{DAY:元/天},{HOUR:元/小时}][CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string SalaryTimeUnit
        {
            get { return this.m_salarytimeunit; }
            set //
            {
                if (!salarytimeunit_initialized || m_salarytimeunit != value)
                {
                    this.m_salarytimeunit = value;
                }
                salarytimeunit_initialized = true;
            }
        }
        
        /// <summary> 工资单位:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal SalaryUnit
        {
            get { return this.m_salaryunit; }
            set //
            {
                if (!salaryunit_initialized || m_salaryunit != value)
                {
                    this.m_salaryunit = value;
                }
                salaryunit_initialized = true;
            }
        }
        
        /// <summary> 性别要求:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SexRequire
        {
            get { return this.m_sexrequire; }
            set //
            {
                if (!sexrequire_initialized || m_sexrequire != value)
                {
                    this.m_sexrequire = value;
                }
                sexrequire_initialized = true;
            }
        }
        
        /// <summary> 现状:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 镇id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 查看数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ViewCount
        {
            get { return this.m_viewcount; }
            set //
            {
                if (!viewcount_initialized || m_viewcount != value)
                {
                    this.m_viewcount = value;
                }
                viewcount_initialized = true;
            }
        }
        
        /// <summary> 地址建筑:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AddressBuilding
        {
            get { return this.m_addressbuilding; }
            set //
            {
                if (!addressbuilding_initialized || m_addressbuilding != value)
                {
                    this.m_addressbuilding = value;
                }
                addressbuilding_initialized = true;
            }
        }
        
        /// <summary> 部分工作标签:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PartJobTags
        {
            get { return this.m_partjobtags; }
            set //
            {
                if (!partjobtags_initialized || m_partjobtags != value)
                {
                    this.m_partjobtags = value;
                }
                partjobtags_initialized = true;
            }
        }
        
        /// <summary> 债券的钱:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BondMoney
        {
            get { return this.m_bondmoney; }
            set //
            {
                if (!bondmoney_initialized || m_bondmoney != value)
                {
                    this.m_bondmoney = value;
                }
                bondmoney_initialized = true;
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
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ClassificationId
        {
            get { return this.m_classificationid; }
            set //
            {
                if (!classificationid_initialized || m_classificationid != value)
                {
                    this.m_classificationid = value;
                }
                classificationid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ParentId
        {
            get { return this.m_parentid; }
            set //
            {
                if (!parentid_initialized || m_parentid != value)
                {
                    this.m_parentid = value;
                }
                parentid_initialized = true;
            }
        }
        
        /// <summary> 工资票种:[CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public bool SalaryTicketType
        {
            get { return this.m_salarytickettype; }
            set //
            {
                if (!salarytickettype_initialized || m_salarytickettype != value)
                {
                    this.m_salarytickettype = value;
                }
                salarytickettype_initialized = true;
            }
        }
        
        /// <summary> 工作时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WorkTime
        {
            get { return this.m_worktime; }
            set //
            {
                if (!worktime_initialized || m_worktime != value)
                {
                    this.m_worktime = value;
                }
                worktime_initialized = true;
            }
        }
        
        /// <summary> 公司id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 工作描述:[CtrlTypeDic-{InputPhone}]，推荐使用 "_"符号开头 </summary>
        public string JobDescription
        {
            get { return this.m_jobdescription; }
            set //
            {
                if (!jobdescription_initialized || m_jobdescription != value)
                {
                    this.m_jobdescription = value;
                }
                jobdescription_initialized = true;
            }
        }
        
        /// <summary> 奖金:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Bonus
        {
            get { return this.m_bonus; }
            set //
            {
                if (!bonus_initialized || m_bonus != value)
                {
                    this.m_bonus = value;
                }
                bonus_initialized = true;
            }
        }
        
        /// <summary> 福利:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Welfare
        {
            get { return this.m_welfare; }
            set //
            {
                if (!welfare_initialized || m_welfare != value)
                {
                    this.m_welfare = value;
                }
                welfare_initialized = true;
            }
        }
        
        /// <summary> 内容提示:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ContentPrompt
        {
            get { return this.m_contentprompt; }
            set //
            {
                if (!contentprompt_initialized || m_contentprompt != value)
                {
                    this.m_contentprompt = value;
                }
                contentprompt_initialized = true;
            }
        }
        
        /// <summary> 卫生要求:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string HealthRequire
        {
            get { return this.m_healthrequire; }
            set //
            {
                if (!healthrequire_initialized || m_healthrequire != value)
                {
                    this.m_healthrequire = value;
                }
                healthrequire_initialized = true;
            }
        }
        
        /// <summary> 身高要求:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string HeightRequire
        {
            get { return this.m_heightrequire; }
            set //
            {
                if (!heightrequire_initialized || m_heightrequire != value)
                {
                    this.m_heightrequire = value;
                }
                heightrequire_initialized = true;
            }
        }
        
        /// <summary> 面试时间:[CtrlTypeDic-{InputDecimal}]，推荐使用 "_"符号开头 </summary>
        public DateTime InterviewTime
        {
            get { return this.m_interviewtime; }
            set //
            {
                if (!interviewtime_initialized || m_interviewtime != value)
                {
                    this.m_interviewtime = value;
                }
                interviewtime_initialized = true;
            }
        }
        
        /// <summary> 面试地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string InterviewAddress
        {
            get { return this.m_interviewaddress; }
            set //
            {
                if (!interviewaddress_initialized || m_interviewaddress != value)
                {
                    this.m_interviewaddress = value;
                }
                interviewaddress_initialized = true;
            }
        }
        
        /// <summary> 要求身高:[CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public bool NeedHeight
        {
            get { return this.m_needheight; }
            set //
            {
                if (!needheight_initialized || m_needheight != value)
                {
                    this.m_needheight = value;
                }
                needheight_initialized = true;
            }
        }
        
        /// <summary> 要求健康:[CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public bool NeedHealth
        {
            get { return this.m_needhealth; }
            set //
            {
                if (!needhealth_initialized || m_needhealth != value)
                {
                    this.m_needhealth = value;
                }
                needhealth_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Users
        {
            get { return this.m_users; }
            set //
            {
                if (!users_initialized || m_users != value)
                {
                    this.m_users = value;
                }
                users_initialized = true;
            }
        }
        
        /// <summary> 持续时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Distance
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_partJobs].[Id]", typeof(int), 4, default(int));
            
            /// <summary>部分职位编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobId =  new AttributeItem("[Jz_partJobs].[PartJobId]", typeof(int), 4, default(int));
            
            /// <summary>部分职位uuid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobUuid =  new AttributeItem("[Jz_partJobs].[PartJobUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>详细地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AddressDetail =  new AttributeItem("[Jz_partJobs].[AddressDetail]", typeof(string), 100, default(string));
            
            /// <summary>地区id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AreaId =  new AttributeItem("[Jz_partJobs].[AreaId]", typeof(int), 4, default(int));
            
            /// <summary>类别:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category =  new AttributeItem("[Jz_partJobs].[Category]", typeof(string), 100, default(string));
            
            /// <summary>结算方式:[Enum-{YEAR:年结},{DAY:日结},{WEEK:周结},{MONTH:月结},{OVER:完工结算},{OTHER:其他结算}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem ClearingForm =  new AttributeItem("[Jz_partJobs].[ClearingForm]", typeof(string), 100, default(string));
            
            /// <summary>公司类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyType =  new AttributeItem("[Jz_partJobs].[CompanyType]", typeof(string), 100, default(string));
            
            /// <summary>公司uuid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyUuid =  new AttributeItem("[Jz_partJobs].[CompanyUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>联系人:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Contacter =  new AttributeItem("[Jz_partJobs].[Contacter]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_partJobs].[CreateTime]", typeof(string), 100, default(string));
            
            /// <summary>持续时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Duration =  new AttributeItem("[Jz_partJobs].[Duration]", typeof(string), 100, default(string));
            
            /// <summary>入口计数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EntryCount =  new AttributeItem("[Jz_partJobs].[EntryCount]", typeof(int), 4, default(int));
            
            /// <summary>报名截止日期:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EntryDeadline =  new AttributeItem("[Jz_partJobs].[EntryDeadline]", typeof(string), 100, default(string));
            
            /// <summary>热度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HotScore =  new AttributeItem("[Jz_partJobs].[HotScore]", typeof(int), 4, default(int));
            
            /// <summary>作业数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem JobCount =  new AttributeItem("[Jz_partJobs].[JobCount]", typeof(int), 4, default(int));
            
            /// <summary>作业时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem JobTime =  new AttributeItem("[Jz_partJobs].[JobTime]", typeof(string), 100, default(string));
            
            /// <summary>工作时间标准:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem JobTimeStandard =  new AttributeItem("[Jz_partJobs].[JobTimeStandard]", typeof(string), 100, default(string));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Latitude =  new AttributeItem("[Jz_partJobs].[Latitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Longitude =  new AttributeItem("[Jz_partJobs].[Longitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary>是否需要面试:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem NeedInterview =  new AttributeItem("[Jz_partJobs].[NeedInterview]", typeof(bool), 1, default(bool));
            
            /// <summary>新工作时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NewJobStandTime =  new AttributeItem("[Jz_partJobs].[NewJobStandTime]", typeof(string), 100, default(string));
            
            /// <summary>部分工作的标志:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobLogo =  new AttributeItem("[Jz_partJobs].[PartJobLogo]", typeof(string), 200, default(string));
            
            /// <summary>部分工作主题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobTitle =  new AttributeItem("[Jz_partJobs].[PartJobTitle]", typeof(string), 100, default(string));
            
            /// <summary>工资:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Salary =  new AttributeItem("[Jz_partJobs].[Salary]", typeof(string), 100, default(string));
            
            /// <summary>工资的时间单位:[Enum-{TIMES:元/次},{DAY:元/天},{HOUR:元/小时}][CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem SalaryTimeUnit =  new AttributeItem("[Jz_partJobs].[SalaryTimeUnit]", typeof(string), 30, default(string));
            
            /// <summary>工资单位:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SalaryUnit =  new AttributeItem("[Jz_partJobs].[SalaryUnit]", typeof(decimal), 18, default(decimal));
            
            /// <summary>性别要求:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SexRequire =  new AttributeItem("[Jz_partJobs].[SexRequire]", typeof(string), 100, default(string));
            
            /// <summary>现状:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Jz_partJobs].[Status]", typeof(string), 100, default(string));
            
            /// <summary>镇id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownId =  new AttributeItem("[Jz_partJobs].[TownId]", typeof(int), 4, default(int));
            
            /// <summary>类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Jz_partJobs].[Type]", typeof(string), 100, default(string));
            
            /// <summary>查看数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ViewCount =  new AttributeItem("[Jz_partJobs].[ViewCount]", typeof(int), 4, default(int));
            
            /// <summary>地址建筑:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AddressBuilding =  new AttributeItem("[Jz_partJobs].[AddressBuilding]", typeof(string), 100, default(string));
            
            /// <summary>部分工作标签:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobTags =  new AttributeItem("[Jz_partJobs].[PartJobTags]", typeof(string), 100, default(string));
            
            /// <summary>债券的钱:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BondMoney =  new AttributeItem("[Jz_partJobs].[BondMoney]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_partJobs].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_partJobs].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[Jz_partJobs].[ClassificationId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ParentId =  new AttributeItem("[Jz_partJobs].[ParentId]", typeof(int), 4, default(int));
            
            /// <summary>工资票种:[CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem SalaryTicketType =  new AttributeItem("[Jz_partJobs].[SalaryTicketType]", typeof(bool), 1, default(bool));
            
            /// <summary>工作时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkTime =  new AttributeItem("[Jz_partJobs].[WorkTime]", typeof(string), 100, default(string));
            
            /// <summary>公司id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyId =  new AttributeItem("[Jz_partJobs].[CompanyId]", typeof(int), 4, default(int));
            
            /// <summary>工作描述:[CtrlTypeDic-{InputPhone}]</summary>
            public static AttributeItem JobDescription =  new AttributeItem("[Jz_partJobs].[JobDescription]", typeof(string), 1000, default(string));
            
            /// <summary>奖金:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Bonus =  new AttributeItem("[Jz_partJobs].[Bonus]", typeof(string), 50, default(string));
            
            /// <summary>福利:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Welfare =  new AttributeItem("[Jz_partJobs].[Welfare]", typeof(string), 50, default(string));
            
            /// <summary>内容提示:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ContentPrompt =  new AttributeItem("[Jz_partJobs].[ContentPrompt]", typeof(string), 100, default(string));
            
            /// <summary>卫生要求:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HealthRequire =  new AttributeItem("[Jz_partJobs].[HealthRequire]", typeof(string), 100, default(string));
            
            /// <summary>身高要求:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HeightRequire =  new AttributeItem("[Jz_partJobs].[HeightRequire]", typeof(string), 100, default(string));
            
            /// <summary>面试时间:[CtrlTypeDic-{InputDecimal}]</summary>
            public static AttributeItem InterviewTime =  new AttributeItem("[Jz_partJobs].[InterviewTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>面试地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem InterviewAddress =  new AttributeItem("[Jz_partJobs].[InterviewAddress]", typeof(string), 100, default(string));
            
            /// <summary>要求身高:[CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem NeedHeight =  new AttributeItem("[Jz_partJobs].[NeedHeight]", typeof(bool), 1, default(bool));
            
            /// <summary>要求健康:[CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem NeedHealth =  new AttributeItem("[Jz_partJobs].[NeedHealth]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Users =  new AttributeItem("[Jz_partJobs].[Users]", typeof(int), 4, default(int));
            
            /// <summary>持续时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Distance =  new AttributeItem("[Jz_partJobs].[Distance]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_partjobid;
        /// <summary></summary>
        protected bool partjobid_initialized = false;
        
        private Guid m_partjobuuid;
        /// <summary></summary>
        protected bool partjobuuid_initialized = false;
        
        private string m_addressdetail;
        /// <summary></summary>
        protected bool addressdetail_initialized = false;
        
        private int m_areaid;
        /// <summary></summary>
        protected bool areaid_initialized = false;
        
        private string m_category;
        /// <summary></summary>
        protected bool category_initialized = false;
        
        private string m_clearingform;
        /// <summary></summary>
        protected bool clearingform_initialized = false;
        
        private string m_companytype;
        /// <summary></summary>
        protected bool companytype_initialized = false;
        
        private Guid m_companyuuid;
        /// <summary></summary>
        protected bool companyuuid_initialized = false;
        
        private string m_contacter;
        /// <summary></summary>
        protected bool contacter_initialized = false;
        
        private string m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_duration;
        /// <summary></summary>
        protected bool duration_initialized = false;
        
        private int m_entrycount;
        /// <summary></summary>
        protected bool entrycount_initialized = false;
        
        private string m_entrydeadline;
        /// <summary></summary>
        protected bool entrydeadline_initialized = false;
        
        private int m_hotscore;
        /// <summary></summary>
        protected bool hotscore_initialized = false;
        
        private int m_jobcount;
        /// <summary></summary>
        protected bool jobcount_initialized = false;
        
        private string m_jobtime;
        /// <summary></summary>
        protected bool jobtime_initialized = false;
        
        private string m_jobtimestandard;
        /// <summary></summary>
        protected bool jobtimestandard_initialized = false;
        
        private decimal m_latitude;
        /// <summary></summary>
        protected bool latitude_initialized = false;
        
        private decimal m_longitude;
        /// <summary></summary>
        protected bool longitude_initialized = false;
        
        private bool m_needinterview;
        /// <summary></summary>
        protected bool needinterview_initialized = false;
        
        private string m_newjobstandtime;
        /// <summary></summary>
        protected bool newjobstandtime_initialized = false;
        
        private string m_partjoblogo;
        /// <summary></summary>
        protected bool partjoblogo_initialized = false;
        
        private string m_partjobtitle;
        /// <summary></summary>
        protected bool partjobtitle_initialized = false;
        
        private string m_salary;
        /// <summary></summary>
        protected bool salary_initialized = false;
        
        private string m_salarytimeunit;
        /// <summary></summary>
        protected bool salarytimeunit_initialized = false;
        
        private decimal m_salaryunit;
        /// <summary></summary>
        protected bool salaryunit_initialized = false;
        
        private string m_sexrequire;
        /// <summary></summary>
        protected bool sexrequire_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private int m_townid;
        /// <summary></summary>
        protected bool townid_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private int m_viewcount;
        /// <summary></summary>
        protected bool viewcount_initialized = false;
        
        private string m_addressbuilding;
        /// <summary></summary>
        protected bool addressbuilding_initialized = false;
        
        private string m_partjobtags;
        /// <summary></summary>
        protected bool partjobtags_initialized = false;
        
        private int m_bondmoney;
        /// <summary></summary>
        protected bool bondmoney_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_classificationid;
        /// <summary></summary>
        protected bool classificationid_initialized = false;
        
        private int m_parentid;
        /// <summary></summary>
        protected bool parentid_initialized = false;
        
        private bool m_salarytickettype;
        /// <summary></summary>
        protected bool salarytickettype_initialized = false;
        
        private string m_worktime;
        /// <summary></summary>
        protected bool worktime_initialized = false;
        
        private int m_companyid;
        /// <summary></summary>
        protected bool companyid_initialized = false;
        
        private string m_jobdescription;
        /// <summary></summary>
        protected bool jobdescription_initialized = false;
        
        private string m_bonus;
        /// <summary></summary>
        protected bool bonus_initialized = false;
        
        private string m_welfare;
        /// <summary></summary>
        protected bool welfare_initialized = false;
        
        private string m_contentprompt;
        /// <summary></summary>
        protected bool contentprompt_initialized = false;
        
        private string m_healthrequire;
        /// <summary></summary>
        protected bool healthrequire_initialized = false;
        
        private string m_heightrequire;
        /// <summary></summary>
        protected bool heightrequire_initialized = false;
        
        private DateTime m_interviewtime;
        /// <summary></summary>
        protected bool interviewtime_initialized = false;
        
        private string m_interviewaddress;
        /// <summary></summary>
        protected bool interviewaddress_initialized = false;
        
        private bool m_needheight;
        /// <summary></summary>
        protected bool needheight_initialized = false;
        
        private bool m_needhealth;
        /// <summary></summary>
        protected bool needhealth_initialized = false;
        
        private int m_users;
        /// <summary></summary>
        protected bool users_initialized = false;
        
        private string m_distance;
        /// <summary></summary>
        protected bool distance_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_partJobs";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.partjobid_initialized = IsLoadAllAttributes;this.partjobuuid_initialized = IsLoadAllAttributes;this.addressdetail_initialized = IsLoadAllAttributes;this.areaid_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;this.clearingform_initialized = IsLoadAllAttributes;this.companytype_initialized = IsLoadAllAttributes;this.companyuuid_initialized = IsLoadAllAttributes;this.contacter_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.duration_initialized = IsLoadAllAttributes;this.entrycount_initialized = IsLoadAllAttributes;this.entrydeadline_initialized = IsLoadAllAttributes;this.hotscore_initialized = IsLoadAllAttributes;this.jobcount_initialized = IsLoadAllAttributes;this.jobtime_initialized = IsLoadAllAttributes;this.jobtimestandard_initialized = IsLoadAllAttributes;this.latitude_initialized = IsLoadAllAttributes;this.longitude_initialized = IsLoadAllAttributes;this.needinterview_initialized = IsLoadAllAttributes;this.newjobstandtime_initialized = IsLoadAllAttributes;this.partjoblogo_initialized = IsLoadAllAttributes;this.partjobtitle_initialized = IsLoadAllAttributes;this.salary_initialized = IsLoadAllAttributes;this.salarytimeunit_initialized = IsLoadAllAttributes;this.salaryunit_initialized = IsLoadAllAttributes;this.sexrequire_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.townid_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.viewcount_initialized = IsLoadAllAttributes;this.addressbuilding_initialized = IsLoadAllAttributes;this.partjobtags_initialized = IsLoadAllAttributes;this.bondmoney_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;this.parentid_initialized = IsLoadAllAttributes;this.salarytickettype_initialized = IsLoadAllAttributes;this.worktime_initialized = IsLoadAllAttributes;this.companyid_initialized = IsLoadAllAttributes;this.jobdescription_initialized = IsLoadAllAttributes;this.bonus_initialized = IsLoadAllAttributes;this.welfare_initialized = IsLoadAllAttributes;this.contentprompt_initialized = IsLoadAllAttributes;this.healthrequire_initialized = IsLoadAllAttributes;this.heightrequire_initialized = IsLoadAllAttributes;this.interviewtime_initialized = IsLoadAllAttributes;this.interviewaddress_initialized = IsLoadAllAttributes;this.needheight_initialized = IsLoadAllAttributes;this.needhealth_initialized = IsLoadAllAttributes;this.users_initialized = IsLoadAllAttributes;this.distance_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_partJobs value = new Jz_partJobs();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobId"))
				value.partjobid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobUuid"))
				value.partjobuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddressDetail"))
				value.addressdetail_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AreaId"))
				value.areaid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClearingForm"))
				value.clearingform_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyType"))
				value.companytype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyUuid"))
				value.companyuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Contacter"))
				value.contacter_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Duration"))
				value.duration_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EntryCount"))
				value.entrycount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EntryDeadline"))
				value.entrydeadline_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HotScore"))
				value.hotscore_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JobCount"))
				value.jobcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JobTime"))
				value.jobtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JobTimeStandard"))
				value.jobtimestandard_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Latitude"))
				value.latitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Longitude"))
				value.longitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NeedInterview"))
				value.needinterview_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NewJobStandTime"))
				value.newjobstandtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobLogo"))
				value.partjoblogo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobTitle"))
				value.partjobtitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary"))
				value.salary_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SalaryTimeUnit"))
				value.salarytimeunit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SalaryUnit"))
				value.salaryunit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SexRequire"))
				value.sexrequire_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownId"))
				value.townid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ViewCount"))
				value.viewcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddressBuilding"))
				value.addressbuilding_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobTags"))
				value.partjobtags_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BondMoney"))
				value.bondmoney_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationId"))
				value.classificationid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ParentId"))
				value.parentid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SalaryTicketType"))
				value.salarytickettype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkTime"))
				value.worktime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyId"))
				value.companyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JobDescription"))
				value.jobdescription_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Bonus"))
				value.bonus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Welfare"))
				value.welfare_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ContentPrompt"))
				value.contentprompt_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HealthRequire"))
				value.healthrequire_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HeightRequire"))
				value.heightrequire_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"InterviewTime"))
				value.interviewtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"InterviewAddress"))
				value.interviewaddress_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NeedHeight"))
				value.needheight_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NeedHealth"))
				value.needhealth_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Users"))
				value.users_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Distance"))
				value.distance_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_partJobs Clone()
        {
            return (Jz_partJobs)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_partJobs()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_partJobs() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_partJobs(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_partJobs(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_partJobs(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_partJobs(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_partJobs(int id1, int partjobid1, Guid partjobuuid1, string addressdetail1, int areaid1, string category1, string clearingform1, string companytype1, Guid companyuuid1, string contacter1, string createtime1, string duration1, int entrycount1, string entrydeadline1, int hotscore1, int jobcount1, string jobtime1, string jobtimestandard1, decimal latitude1, decimal longitude1, bool needinterview1, string newjobstandtime1, string partjoblogo1, string partjobtitle1, string salary1, string salarytimeunit1, decimal salaryunit1, string sexrequire1, string status1, int townid1, string type1, int viewcount1, string addressbuilding1, string partjobtags1, int bondmoney1, DateTime modifytime1, Guid user_id1, int classificationid1, int parentid1, bool salarytickettype1, string worktime1, int companyid1, string jobdescription1, string bonus1, string welfare1, string contentprompt1, string healthrequire1, string heightrequire1, DateTime interviewtime1, string interviewaddress1, bool needheight1, bool needhealth1, int users1, string distance1)
        {
            
            this.Id = id1;
            
            this.PartJobId = partjobid1;
            
            this.PartJobUuid = partjobuuid1;
            
            this.AddressDetail = addressdetail1;
            
            this.AreaId = areaid1;
            
            this.Category = category1;
            
            this.ClearingForm = clearingform1;
            
            this.CompanyType = companytype1;
            
            this.CompanyUuid = companyuuid1;
            
            this.Contacter = contacter1;
            
            this.CreateTime = createtime1;
            
            this.Duration = duration1;
            
            this.EntryCount = entrycount1;
            
            this.EntryDeadline = entrydeadline1;
            
            this.HotScore = hotscore1;
            
            this.JobCount = jobcount1;
            
            this.JobTime = jobtime1;
            
            this.JobTimeStandard = jobtimestandard1;
            
            this.Latitude = latitude1;
            
            this.Longitude = longitude1;
            
            this.NeedInterview = needinterview1;
            
            this.NewJobStandTime = newjobstandtime1;
            
            this.PartJobLogo = partjoblogo1;
            
            this.PartJobTitle = partjobtitle1;
            
            this.Salary = salary1;
            
            this.SalaryTimeUnit = salarytimeunit1;
            
            this.SalaryUnit = salaryunit1;
            
            this.SexRequire = sexrequire1;
            
            this.Status = status1;
            
            this.TownId = townid1;
            
            this.Type = type1;
            
            this.ViewCount = viewcount1;
            
            this.AddressBuilding = addressbuilding1;
            
            this.PartJobTags = partjobtags1;
            
            this.BondMoney = bondmoney1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.ClassificationId = classificationid1;
            
            this.ParentId = parentid1;
            
            this.SalaryTicketType = salarytickettype1;
            
            this.WorkTime = worktime1;
            
            this.CompanyId = companyid1;
            
            this.JobDescription = jobdescription1;
            
            this.Bonus = bonus1;
            
            this.Welfare = welfare1;
            
            this.ContentPrompt = contentprompt1;
            
            this.HealthRequire = healthrequire1;
            
            this.HeightRequire = heightrequire1;
            
            this.InterviewTime = interviewtime1;
            
            this.InterviewAddress = interviewaddress1;
            
            this.NeedHeight = needheight1;
            
            this.NeedHealth = needhealth1;
            
            this.Users = users1;
            
            this.Distance = distance1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_partJobs FromIView(IView view)
        {
            return (Jz_partJobs)IView.GetITable(view, "Jz_partJobs");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_partJobs GetOneInstance()
        {
            Jz_partJobs value = new Jz_partJobs();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_partJobs Retrieve()
        {
            BLLTable<Jz_partJobs>.GetRowData(this);
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
			    			
			    case "PartJobId":
			        return PartJobId;
			    			
			    case "PartJobUuid":
			        return PartJobUuid;
			    			
			    case "AddressDetail":
			        return AddressDetail;
			    			
			    case "AreaId":
			        return AreaId;
			    			
			    case "Category":
			        return Category;
			    			
			    case "ClearingForm":
			        return ClearingForm;
			    			
			    case "CompanyType":
			        return CompanyType;
			    			
			    case "CompanyUuid":
			        return CompanyUuid;
			    			
			    case "Contacter":
			        return Contacter;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Duration":
			        return Duration;
			    			
			    case "EntryCount":
			        return EntryCount;
			    			
			    case "EntryDeadline":
			        return EntryDeadline;
			    			
			    case "HotScore":
			        return HotScore;
			    			
			    case "JobCount":
			        return JobCount;
			    			
			    case "JobTime":
			        return JobTime;
			    			
			    case "JobTimeStandard":
			        return JobTimeStandard;
			    			
			    case "Latitude":
			        return Latitude;
			    			
			    case "Longitude":
			        return Longitude;
			    			
			    case "NeedInterview":
			        return NeedInterview;
			    			
			    case "NewJobStandTime":
			        return NewJobStandTime;
			    			
			    case "PartJobLogo":
			        return PartJobLogo;
			    			
			    case "PartJobTitle":
			        return PartJobTitle;
			    			
			    case "Salary":
			        return Salary;
			    			
			    case "SalaryTimeUnit":
			        return SalaryTimeUnit;
			    			
			    case "SalaryUnit":
			        return SalaryUnit;
			    			
			    case "SexRequire":
			        return SexRequire;
			    			
			    case "Status":
			        return Status;
			    			
			    case "TownId":
			        return TownId;
			    			
			    case "Type":
			        return Type;
			    			
			    case "ViewCount":
			        return ViewCount;
			    			
			    case "AddressBuilding":
			        return AddressBuilding;
			    			
			    case "PartJobTags":
			        return PartJobTags;
			    			
			    case "BondMoney":
			        return BondMoney;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "ClassificationId":
			        return ClassificationId;
			    			
			    case "ParentId":
			        return ParentId;
			    			
			    case "SalaryTicketType":
			        return SalaryTicketType;
			    			
			    case "WorkTime":
			        return WorkTime;
			    			
			    case "CompanyId":
			        return CompanyId;
			    			
			    case "JobDescription":
			        return JobDescription;
			    			
			    case "Bonus":
			        return Bonus;
			    			
			    case "Welfare":
			        return Welfare;
			    			
			    case "ContentPrompt":
			        return ContentPrompt;
			    			
			    case "HealthRequire":
			        return HealthRequire;
			    			
			    case "HeightRequire":
			        return HeightRequire;
			    			
			    case "InterviewTime":
			        return InterviewTime;
			    			
			    case "InterviewAddress":
			        return InterviewAddress;
			    			
			    case "NeedHeight":
			        return NeedHeight;
			    			
			    case "NeedHealth":
			        return NeedHealth;
			    			
			    case "Users":
			        return Users;
			    			
			    case "Distance":
			        return Distance;
			
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
			    			
			    case "PartJobId":
			        this.PartJobId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "PartJobUuid":
			        this.PartJobUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "AddressDetail":
			        this.AddressDetail = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AreaId":
			        this.AreaId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Category":
			        this.Category = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClearingForm":
			        this.ClearingForm = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyType":
			        this.CompanyType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyUuid":
			        this.CompanyUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Contacter":
			        this.Contacter = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Duration":
			        this.Duration = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "EntryCount":
			        this.EntryCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "EntryDeadline":
			        this.EntryDeadline = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HotScore":
			        this.HotScore = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "JobCount":
			        this.JobCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "JobTime":
			        this.JobTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "JobTimeStandard":
			        this.JobTimeStandard = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Latitude":
			        this.Latitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Longitude":
			        this.Longitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "NeedInterview":
			        this.NeedInterview = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "NewJobStandTime":
			        this.NewJobStandTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobLogo":
			        this.PartJobLogo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobTitle":
			        this.PartJobTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Salary":
			        this.Salary = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SalaryTimeUnit":
			        this.SalaryTimeUnit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SalaryUnit":
			        this.SalaryUnit = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "SexRequire":
			        this.SexRequire = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TownId":
			        this.TownId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ViewCount":
			        this.ViewCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AddressBuilding":
			        this.AddressBuilding = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobTags":
			        this.PartJobTags = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BondMoney":
			        this.BondMoney = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "ClassificationId":
			        this.ClassificationId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ParentId":
			        this.ParentId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SalaryTicketType":
			        this.SalaryTicketType = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "WorkTime":
			        this.WorkTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyId":
			        this.CompanyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "JobDescription":
			        this.JobDescription = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Bonus":
			        this.Bonus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Welfare":
			        this.Welfare = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ContentPrompt":
			        this.ContentPrompt = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HealthRequire":
			        this.HealthRequire = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HeightRequire":
			        this.HeightRequire = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "InterviewTime":
			        this.InterviewTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "InterviewAddress":
			        this.InterviewAddress = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NeedHeight":
			        this.NeedHeight = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "NeedHealth":
			        this.NeedHealth = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Users":
			        this.Users = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Distance":
			        this.Distance = Convert.ToString(AttributeValue);
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
				
				case "PartJobId":
					return partjobid_initialized;
				
				case "PartJobUuid":
					return partjobuuid_initialized;
				
				case "AddressDetail":
					return addressdetail_initialized;
				
				case "AreaId":
					return areaid_initialized;
				
				case "Category":
					return category_initialized;
				
				case "ClearingForm":
					return clearingform_initialized;
				
				case "CompanyType":
					return companytype_initialized;
				
				case "CompanyUuid":
					return companyuuid_initialized;
				
				case "Contacter":
					return contacter_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Duration":
					return duration_initialized;
				
				case "EntryCount":
					return entrycount_initialized;
				
				case "EntryDeadline":
					return entrydeadline_initialized;
				
				case "HotScore":
					return hotscore_initialized;
				
				case "JobCount":
					return jobcount_initialized;
				
				case "JobTime":
					return jobtime_initialized;
				
				case "JobTimeStandard":
					return jobtimestandard_initialized;
				
				case "Latitude":
					return latitude_initialized;
				
				case "Longitude":
					return longitude_initialized;
				
				case "NeedInterview":
					return needinterview_initialized;
				
				case "NewJobStandTime":
					return newjobstandtime_initialized;
				
				case "PartJobLogo":
					return partjoblogo_initialized;
				
				case "PartJobTitle":
					return partjobtitle_initialized;
				
				case "Salary":
					return salary_initialized;
				
				case "SalaryTimeUnit":
					return salarytimeunit_initialized;
				
				case "SalaryUnit":
					return salaryunit_initialized;
				
				case "SexRequire":
					return sexrequire_initialized;
				
				case "Status":
					return status_initialized;
				
				case "TownId":
					return townid_initialized;
				
				case "Type":
					return type_initialized;
				
				case "ViewCount":
					return viewcount_initialized;
				
				case "AddressBuilding":
					return addressbuilding_initialized;
				
				case "PartJobTags":
					return partjobtags_initialized;
				
				case "BondMoney":
					return bondmoney_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "ClassificationId":
					return classificationid_initialized;
				
				case "ParentId":
					return parentid_initialized;
				
				case "SalaryTicketType":
					return salarytickettype_initialized;
				
				case "WorkTime":
					return worktime_initialized;
				
				case "CompanyId":
					return companyid_initialized;
				
				case "JobDescription":
					return jobdescription_initialized;
				
				case "Bonus":
					return bonus_initialized;
				
				case "Welfare":
					return welfare_initialized;
				
				case "ContentPrompt":
					return contentprompt_initialized;
				
				case "HealthRequire":
					return healthrequire_initialized;
				
				case "HeightRequire":
					return heightrequire_initialized;
				
				case "InterviewTime":
					return interviewtime_initialized;
				
				case "InterviewAddress":
					return interviewaddress_initialized;
				
				case "NeedHeight":
					return needheight_initialized;
				
				case "NeedHealth":
					return needhealth_initialized;
				
				case "Users":
					return users_initialized;
				
				case "Distance":
					return distance_initialized;
				
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
				
				case "PartJobId":
					partjobid_initialized = ret;
					return true;
				
				case "PartJobUuid":
					partjobuuid_initialized = ret;
					return true;
				
				case "AddressDetail":
					addressdetail_initialized = ret;
					return true;
				
				case "AreaId":
					areaid_initialized = ret;
					return true;
				
				case "Category":
					category_initialized = ret;
					return true;
				
				case "ClearingForm":
					clearingform_initialized = ret;
					return true;
				
				case "CompanyType":
					companytype_initialized = ret;
					return true;
				
				case "CompanyUuid":
					companyuuid_initialized = ret;
					return true;
				
				case "Contacter":
					contacter_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Duration":
					duration_initialized = ret;
					return true;
				
				case "EntryCount":
					entrycount_initialized = ret;
					return true;
				
				case "EntryDeadline":
					entrydeadline_initialized = ret;
					return true;
				
				case "HotScore":
					hotscore_initialized = ret;
					return true;
				
				case "JobCount":
					jobcount_initialized = ret;
					return true;
				
				case "JobTime":
					jobtime_initialized = ret;
					return true;
				
				case "JobTimeStandard":
					jobtimestandard_initialized = ret;
					return true;
				
				case "Latitude":
					latitude_initialized = ret;
					return true;
				
				case "Longitude":
					longitude_initialized = ret;
					return true;
				
				case "NeedInterview":
					needinterview_initialized = ret;
					return true;
				
				case "NewJobStandTime":
					newjobstandtime_initialized = ret;
					return true;
				
				case "PartJobLogo":
					partjoblogo_initialized = ret;
					return true;
				
				case "PartJobTitle":
					partjobtitle_initialized = ret;
					return true;
				
				case "Salary":
					salary_initialized = ret;
					return true;
				
				case "SalaryTimeUnit":
					salarytimeunit_initialized = ret;
					return true;
				
				case "SalaryUnit":
					salaryunit_initialized = ret;
					return true;
				
				case "SexRequire":
					sexrequire_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "TownId":
					townid_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "ViewCount":
					viewcount_initialized = ret;
					return true;
				
				case "AddressBuilding":
					addressbuilding_initialized = ret;
					return true;
				
				case "PartJobTags":
					partjobtags_initialized = ret;
					return true;
				
				case "BondMoney":
					bondmoney_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "ClassificationId":
					classificationid_initialized = ret;
					return true;
				
				case "ParentId":
					parentid_initialized = ret;
					return true;
				
				case "SalaryTicketType":
					salarytickettype_initialized = ret;
					return true;
				
				case "WorkTime":
					worktime_initialized = ret;
					return true;
				
				case "CompanyId":
					companyid_initialized = ret;
					return true;
				
				case "JobDescription":
					jobdescription_initialized = ret;
					return true;
				
				case "Bonus":
					bonus_initialized = ret;
					return true;
				
				case "Welfare":
					welfare_initialized = ret;
					return true;
				
				case "ContentPrompt":
					contentprompt_initialized = ret;
					return true;
				
				case "HealthRequire":
					healthrequire_initialized = ret;
					return true;
				
				case "HeightRequire":
					heightrequire_initialized = ret;
					return true;
				
				case "InterviewTime":
					interviewtime_initialized = ret;
					return true;
				
				case "InterviewAddress":
					interviewaddress_initialized = ret;
					return true;
				
				case "NeedHeight":
					needheight_initialized = ret;
					return true;
				
				case "NeedHealth":
					needhealth_initialized = ret;
					return true;
				
				case "Users":
					users_initialized = ret;
					return true;
				
				case "Distance":
					distance_initialized = ret;
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
                AttributeItem attr = Jz_partJobs.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (partjobid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.PartJobId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobId);
                }
			}
			
			if (partjobuuid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.PartJobUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobUuid);
                }
			}
			
			if (addressdetail_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.AddressDetail;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddressDetail);
                }
			}
			
			if (areaid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.AreaId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AreaId);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
                }
			}
			
			if (clearingform_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ClearingForm;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClearingForm);
                }
			}
			
			if (companytype_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.CompanyType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyType);
                }
			}
			
			if (companyuuid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.CompanyUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyUuid);
                }
			}
			
			if (contacter_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Contacter;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Contacter);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (duration_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Duration;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Duration);
                }
			}
			
			if (entrycount_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.EntryCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EntryCount);
                }
			}
			
			if (entrydeadline_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.EntryDeadline;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EntryDeadline);
                }
			}
			
			if (hotscore_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.HotScore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HotScore);
                }
			}
			
			if (jobcount_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.JobCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JobCount);
                }
			}
			
			if (jobtime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.JobTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JobTime);
                }
			}
			
			if (jobtimestandard_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.JobTimeStandard;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JobTimeStandard);
                }
			}
			
			if (latitude_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Latitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Latitude);
                }
			}
			
			if (longitude_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Longitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Longitude);
                }
			}
			
			if (needinterview_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.NeedInterview;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NeedInterview);
                }
			}
			
			if (newjobstandtime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.NewJobStandTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NewJobStandTime);
                }
			}
			
			if (partjoblogo_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.PartJobLogo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobLogo);
                }
			}
			
			if (partjobtitle_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.PartJobTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobTitle);
                }
			}
			
			if (salary_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Salary;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary);
                }
			}
			
			if (salarytimeunit_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.SalaryTimeUnit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SalaryTimeUnit);
                }
			}
			
			if (salaryunit_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.SalaryUnit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SalaryUnit);
                }
			}
			
			if (sexrequire_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.SexRequire;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SexRequire);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (townid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.TownId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownId);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (viewcount_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ViewCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ViewCount);
                }
			}
			
			if (addressbuilding_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.AddressBuilding;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddressBuilding);
                }
			}
			
			if (partjobtags_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.PartJobTags;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobTags);
                }
			}
			
			if (bondmoney_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.BondMoney;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BondMoney);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
                }
			}
			
			if (parentid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ParentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ParentId);
                }
			}
			
			if (salarytickettype_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.SalaryTicketType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SalaryTicketType);
                }
			}
			
			if (worktime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.WorkTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkTime);
                }
			}
			
			if (companyid_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.CompanyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyId);
                }
			}
			
			if (jobdescription_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.JobDescription;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JobDescription);
                }
			}
			
			if (bonus_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Bonus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Bonus);
                }
			}
			
			if (welfare_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Welfare;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Welfare);
                }
			}
			
			if (contentprompt_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.ContentPrompt;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ContentPrompt);
                }
			}
			
			if (healthrequire_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.HealthRequire;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HealthRequire);
                }
			}
			
			if (heightrequire_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.HeightRequire;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HeightRequire);
                }
			}
			
			if (interviewtime_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.InterviewTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(InterviewTime);
                }
			}
			
			if (interviewaddress_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.InterviewAddress;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(InterviewAddress);
                }
			}
			
			if (needheight_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.NeedHeight;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NeedHeight);
                }
			}
			
			if (needhealth_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.NeedHealth;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NeedHealth);
                }
			}
			
			if (users_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Users;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Users);
                }
			}
			
			if (distance_initialized)
			{
                AttributeItem attr = Jz_partJobs.Attribute.Distance;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Distance);
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
        public class Jz_partJobsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>部分职位编号:[CtrlTypeDic-{InputString}]</summary>
            public int PartJobId { get; set; }
            
            /// <summary>部分职位uuid:[CtrlTypeDic-{InputString}]</summary>
            public Guid PartJobUuid { get; set; }
            
            /// <summary>详细地址:[CtrlTypeDic-{InputString}]</summary>
            public string AddressDetail { get; set; }
            
            /// <summary>地区id:[CtrlTypeDic-{InputString}]</summary>
            public int AreaId { get; set; }
            
            /// <summary>类别:[CtrlTypeDic-{InputString}]</summary>
            public string Category { get; set; }
            
            /// <summary>结算方式:[Enum-{YEAR:年结},{DAY:日结},{WEEK:周结},{MONTH:月结},{OVER:完工结算},{OTHER:其他结算}][CtrlTypeDic-{SelectDrop}]</summary>
            public string ClearingForm { get; set; }
            
            /// <summary>公司类型:[CtrlTypeDic-{InputString}]</summary>
            public string CompanyType { get; set; }
            
            /// <summary>公司uuid:[CtrlTypeDic-{InputString}]</summary>
            public Guid CompanyUuid { get; set; }
            
            /// <summary>联系人:[CtrlTypeDic-{InputString}]</summary>
            public string Contacter { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CreateTime { get; set; }
            
            /// <summary>持续时间:[CtrlTypeDic-{InputString}]</summary>
            public string Duration { get; set; }
            
            /// <summary>入口计数:[CtrlTypeDic-{InputString}]</summary>
            public int EntryCount { get; set; }
            
            /// <summary>报名截止日期:[CtrlTypeDic-{InputString}]</summary>
            public string EntryDeadline { get; set; }
            
            /// <summary>热度:[CtrlTypeDic-{InputString}]</summary>
            public int HotScore { get; set; }
            
            /// <summary>作业数:[CtrlTypeDic-{InputString}]</summary>
            public int JobCount { get; set; }
            
            /// <summary>作业时间:[CtrlTypeDic-{InputString}]</summary>
            public string JobTime { get; set; }
            
            /// <summary>工作时间标准:[CtrlTypeDic-{InputString}]</summary>
            public string JobTimeStandard { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Latitude { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Longitude { get; set; }
            
            /// <summary>是否需要面试:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool NeedInterview { get; set; }
            
            /// <summary>新工作时间:[CtrlTypeDic-{InputString}]</summary>
            public string NewJobStandTime { get; set; }
            
            /// <summary>部分工作的标志:[CtrlTypeDic-{InputString}]</summary>
            public string PartJobLogo { get; set; }
            
            /// <summary>部分工作主题:[CtrlTypeDic-{InputString}]</summary>
            public string PartJobTitle { get; set; }
            
            /// <summary>工资:[CtrlTypeDic-{InputString}]</summary>
            public string Salary { get; set; }
            
            /// <summary>工资的时间单位:[Enum-{TIMES:元/次},{DAY:元/天},{HOUR:元/小时}][CtrlTypeDic-{SmallText}]</summary>
            public string SalaryTimeUnit { get; set; }
            
            /// <summary>工资单位:[CtrlTypeDic-{InputString}]</summary>
            public decimal SalaryUnit { get; set; }
            
            /// <summary>性别要求:[CtrlTypeDic-{InputString}]</summary>
            public string SexRequire { get; set; }
            
            /// <summary>现状:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>镇id:[CtrlTypeDic-{InputString}]</summary>
            public int TownId { get; set; }
            
            /// <summary>类型:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>查看数:[CtrlTypeDic-{InputString}]</summary>
            public int ViewCount { get; set; }
            
            /// <summary>地址建筑:[CtrlTypeDic-{InputString}]</summary>
            public string AddressBuilding { get; set; }
            
            /// <summary>部分工作标签:[CtrlTypeDic-{InputString}]</summary>
            public string PartJobTags { get; set; }
            
            /// <summary>债券的钱:[CtrlTypeDic-{InputString}]</summary>
            public int BondMoney { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public int ClassificationId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ParentId { get; set; }
            
            /// <summary>工资票种:[CtrlTypeDic-{SelectMultiple}]</summary>
            public bool SalaryTicketType { get; set; }
            
            /// <summary>工作时间:[CtrlTypeDic-{InputString}]</summary>
            public string WorkTime { get; set; }
            
            /// <summary>公司id:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyId { get; set; }
            
            /// <summary>工作描述:[CtrlTypeDic-{InputPhone}]</summary>
            public string JobDescription { get; set; }
            
            /// <summary>奖金:[CtrlTypeDic-{InputString}]</summary>
            public string Bonus { get; set; }
            
            /// <summary>福利:[CtrlTypeDic-{InputString}]</summary>
            public string Welfare { get; set; }
            
            /// <summary>内容提示:[CtrlTypeDic-{InputString}]</summary>
            public string ContentPrompt { get; set; }
            
            /// <summary>卫生要求:[CtrlTypeDic-{InputString}]</summary>
            public string HealthRequire { get; set; }
            
            /// <summary>身高要求:[CtrlTypeDic-{InputString}]</summary>
            public string HeightRequire { get; set; }
            
            /// <summary>面试时间:[CtrlTypeDic-{InputDecimal}]</summary>
            public DateTime InterviewTime { get; set; }
            
            /// <summary>面试地址:[CtrlTypeDic-{InputString}]</summary>
            public string InterviewAddress { get; set; }
            
            /// <summary>要求身高:[CtrlTypeDic-{SelectMultiple}]</summary>
            public bool NeedHeight { get; set; }
            
            /// <summary>要求健康:[CtrlTypeDic-{SelectMultiple}]</summary>
            public bool NeedHealth { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Users { get; set; }
            
            /// <summary>持续时间:[CtrlTypeDic-{InputString}]</summary>
            public string Distance { get; set; }
        }
        #endregion
    }
}