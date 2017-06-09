/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:02
  Description:    数据表Xb_lession_appointInfo对应的业务逻辑层Xb_lession_appointInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_lession_appointInfo_Entity:Xb_lession_appointInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Absent,AppointId,BbsIsVideo,CanUseAppInClass,CourseID,CourseNameLesson,CourseNameTop,CourseNameUnit,CourseUrl,CreateTime,EndTime,IsEvaluate,IsGrading,IsHaveReview,IsNewGrading,IsPreview,IsSale,ModifyTime,PointType,StartTime,Status,Tag,TeachType,TeachValue,TeaID,TeaName,TeaPic,TeaScore,UsePoint,Uuid from Xb_lession_appointInfo
delete from Xb_lession_appointInfo
INSERT INTO Xb_lession_appointInfo (Id,Absent,AppointId,BbsIsVideo,CanUseAppInClass,CourseID,CourseNameLesson,CourseNameTop,CourseNameUnit,CourseUrl,CreateTime,EndTime,IsEvaluate,IsGrading,IsHaveReview,IsNewGrading,IsPreview,IsSale,ModifyTime,PointType,StartTime,Status,Tag,TeachType,TeachValue,TeaID,TeaName,TeaPic,TeaScore,UsePoint,Uuid)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_lession_appointInfo SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Absent = valObj2.Absent;
        valObj.AppointId = valObj2.AppointId;
        valObj.BbsIsVideo = valObj2.BbsIsVideo;
        valObj.CanUseAppInClass = valObj2.CanUseAppInClass;
        valObj.CourseID = valObj2.CourseID;
        valObj.CourseNameLesson = valObj2.CourseNameLesson;
        valObj.CourseNameTop = valObj2.CourseNameTop;
        valObj.CourseNameUnit = valObj2.CourseNameUnit;
        valObj.CourseUrl = valObj2.CourseUrl;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.EndTime = valObj2.EndTime;
        valObj.IsEvaluate = valObj2.IsEvaluate;
        valObj.IsGrading = valObj2.IsGrading;
        valObj.IsHaveReview = valObj2.IsHaveReview;
        valObj.IsNewGrading = valObj2.IsNewGrading;
        valObj.IsPreview = valObj2.IsPreview;
        valObj.IsSale = valObj2.IsSale;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.PointType = valObj2.PointType;
        valObj.StartTime = valObj2.StartTime;
        valObj.Status = valObj2.Status;
        valObj.Tag = valObj2.Tag;
        valObj.TeachType = valObj2.TeachType;
        valObj.TeachValue = valObj2.TeachValue;
        valObj.TeaID = valObj2.TeaID;
        valObj.TeaName = valObj2.TeaName;
        valObj.TeaPic = valObj2.TeaPic;
        valObj.TeaScore = valObj2.TeaScore;
        valObj.UsePoint = valObj2.UsePoint;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Absent = "";
        valObj.AppointId = "";
        valObj.BbsIsVideo = "";
        valObj.CanUseAppInClass = "";
        valObj.CourseID = "";
        valObj.CourseNameLesson = "";
        valObj.CourseNameTop = "";
        valObj.CourseNameUnit = "";
        valObj.CourseUrl = "";
        valObj.CreateTime = "";
        valObj.EndTime = "";
        valObj.IsEvaluate = "";
        valObj.IsGrading = "";
        valObj.IsHaveReview = "";
        valObj.IsNewGrading = "";
        valObj.IsPreview = "";
        valObj.IsSale = "";
        valObj.ModifyTime = "";
        valObj.PointType = "";
        valObj.StartTime = "";
        valObj.Status = "";
        valObj.Tag = "";
        valObj.TeachType = "";
        valObj.TeachValue = "";
        valObj.TeaID = "";
        valObj.TeaName = "";
        valObj.TeaPic = "";
        valObj.TeaScore = "";
        valObj.UsePoint = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Absent": $("#txt_Absent").val(),
        "AppointId": $("#txt_AppointId").val(),
        "BbsIsVideo": $("#txt_BbsIsVideo").val(),
        "CanUseAppInClass": $("#txt_CanUseAppInClass").val(),
        "CourseID": $("#txt_CourseID").val(),
        "CourseNameLesson": $("#txt_CourseNameLesson").val(),
        "CourseNameTop": $("#txt_CourseNameTop").val(),
        "CourseNameUnit": $("#txt_CourseNameUnit").val(),
        "CourseUrl": $("#txt_CourseUrl").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "EndTime": $("#txt_EndTime").val(),
        "IsEvaluate": $("#txt_IsEvaluate").val(),
        "IsGrading": $("#txt_IsGrading").val(),
        "IsHaveReview": $("#txt_IsHaveReview").val(),
        "IsNewGrading": $("#txt_IsNewGrading").val(),
        "IsPreview": $("#txt_IsPreview").val(),
        "IsSale": $("#txt_IsSale").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "PointType": $("#txt_PointType").val(),
        "StartTime": $("#txt_StartTime").val(),
        "Status": $("#txt_Status").val(),
        "Tag": $("#txt_Tag").val(),
        "TeachType": $("#txt_TeachType").val(),
        "TeachValue": $("#txt_TeachValue").val(),
        "TeaID": $("#txt_TeaID").val(),
        "TeaName": $("#txt_TeaName").val(),
        "TeaPic": $("#txt_TeaPic").val(),
        "TeaScore": $("#txt_TeaScore").val(),
        "UsePoint": $("#txt_UsePoint").val(),
        "Uuid": $("#txt_Uuid").val(), 
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
    /// <para></para>
    /// <para>与Xb_lession_appointInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_lession_appointInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_lession_appointInfo Factory()
        {
            return new Xb_lession_appointInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Absent
        {            
            get { return this.Absent; }
            set { this.Absent = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AppointId
        {            
            get { return this.AppointId; }
            set { this.AppointId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BbsIsVideo
        {            
            get { return this.BbsIsVideo; }
            set { this.BbsIsVideo = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CanUseAppInClass
        {            
            get { return this.CanUseAppInClass; }
            set { this.CanUseAppInClass = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CourseID
        {            
            get { return this.CourseID; }
            set { this.CourseID = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CourseNameLesson
        {            
            get { return this.CourseNameLesson; }
            set { this.CourseNameLesson = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CourseNameTop
        {            
            get { return this.CourseNameTop; }
            set { this.CourseNameTop = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CourseNameUnit
        {            
            get { return this.CourseNameUnit; }
            set { this.CourseNameUnit = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CourseUrl
        {            
            get { return this.CourseUrl; }
            set { this.CourseUrl = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _EndTime
        {            
            get { return this.EndTime; }
            set { this.EndTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsEvaluate
        {            
            get { return this.IsEvaluate; }
            set { this.IsEvaluate = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsGrading
        {            
            get { return this.IsGrading; }
            set { this.IsGrading = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsHaveReview
        {            
            get { return this.IsHaveReview; }
            set { this.IsHaveReview = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsNewGrading
        {            
            get { return this.IsNewGrading; }
            set { this.IsNewGrading = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsPreview
        {            
            get { return this.IsPreview; }
            set { this.IsPreview = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsSale
        {            
            get { return this.IsSale; }
            set { this.IsSale = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PointType
        {            
            get { return this.PointType; }
            set { this.PointType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _StartTime
        {            
            get { return this.StartTime; }
            set { this.StartTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Tag
        {            
            get { return this.Tag; }
            set { this.Tag = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeachType
        {            
            get { return this.TeachType; }
            set { this.TeachType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeachValue
        {            
            get { return this.TeachValue; }
            set { this.TeachValue = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TeaID
        {            
            get { return this.TeaID; }
            set { this.TeaID = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeaName
        {            
            get { return this.TeaName; }
            set { this.TeaName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeaPic
        {            
            get { return this.TeaPic; }
            set { this.TeaPic = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _TeaScore
        {            
            get { return this.TeaScore; }
            set { this.TeaScore = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UsePoint
        {            
            get { return this.UsePoint; }
            set { this.UsePoint = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
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
        public string Absent
        {
            get { return this.m_absent; }
            set //
            {
                if (!absent_initialized || m_absent != value)
                {
                    this.m_absent = value;
                }
                absent_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AppointId
        {
            get { return this.m_appointid; }
            set //
            {
                if (!appointid_initialized || m_appointid != value)
                {
                    this.m_appointid = value;
                }
                appointid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BbsIsVideo
        {
            get { return this.m_bbsisvideo; }
            set //
            {
                if (!bbsisvideo_initialized || m_bbsisvideo != value)
                {
                    this.m_bbsisvideo = value;
                }
                bbsisvideo_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CanUseAppInClass
        {
            get { return this.m_canuseappinclass; }
            set //
            {
                if (!canuseappinclass_initialized || m_canuseappinclass != value)
                {
                    this.m_canuseappinclass = value;
                }
                canuseappinclass_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CourseID
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CourseNameLesson
        {
            get { return this.m_coursenamelesson; }
            set //
            {
                if (!coursenamelesson_initialized || m_coursenamelesson != value)
                {
                    this.m_coursenamelesson = value;
                }
                coursenamelesson_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CourseNameTop
        {
            get { return this.m_coursenametop; }
            set //
            {
                if (!coursenametop_initialized || m_coursenametop != value)
                {
                    this.m_coursenametop = value;
                }
                coursenametop_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CourseNameUnit
        {
            get { return this.m_coursenameunit; }
            set //
            {
                if (!coursenameunit_initialized || m_coursenameunit != value)
                {
                    this.m_coursenameunit = value;
                }
                coursenameunit_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CourseUrl
        {
            get { return this.m_courseurl; }
            set //
            {
                if (!courseurl_initialized || m_courseurl != value)
                {
                    this.m_courseurl = value;
                }
                courseurl_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string EndTime
        {
            get { return this.m_endtime; }
            set //
            {
                if (!endtime_initialized || m_endtime != value)
                {
                    this.m_endtime = value;
                }
                endtime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsEvaluate
        {
            get { return this.m_isevaluate; }
            set //
            {
                if (!isevaluate_initialized || m_isevaluate != value)
                {
                    this.m_isevaluate = value;
                }
                isevaluate_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsGrading
        {
            get { return this.m_isgrading; }
            set //
            {
                if (!isgrading_initialized || m_isgrading != value)
                {
                    this.m_isgrading = value;
                }
                isgrading_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsHaveReview
        {
            get { return this.m_ishavereview; }
            set //
            {
                if (!ishavereview_initialized || m_ishavereview != value)
                {
                    this.m_ishavereview = value;
                }
                ishavereview_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsNewGrading
        {
            get { return this.m_isnewgrading; }
            set //
            {
                if (!isnewgrading_initialized || m_isnewgrading != value)
                {
                    this.m_isnewgrading = value;
                }
                isnewgrading_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int IsPreview
        {
            get { return this.m_ispreview; }
            set //
            {
                if (!ispreview_initialized || m_ispreview != value)
                {
                    this.m_ispreview = value;
                }
                ispreview_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsSale
        {
            get { return this.m_issale; }
            set //
            {
                if (!issale_initialized || m_issale != value)
                {
                    this.m_issale = value;
                }
                issale_initialized = true;
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
        public string PointType
        {
            get { return this.m_pointtype; }
            set //
            {
                if (!pointtype_initialized || m_pointtype != value)
                {
                    this.m_pointtype = value;
                }
                pointtype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string StartTime
        {
            get { return this.m_starttime; }
            set //
            {
                if (!starttime_initialized || m_starttime != value)
                {
                    this.m_starttime = value;
                }
                starttime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Tag
        {
            get { return this.m_tag; }
            set //
            {
                if (!tag_initialized || m_tag != value)
                {
                    this.m_tag = value;
                }
                tag_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeachType
        {
            get { return this.m_teachtype; }
            set //
            {
                if (!teachtype_initialized || m_teachtype != value)
                {
                    this.m_teachtype = value;
                }
                teachtype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeachValue
        {
            get { return this.m_teachvalue; }
            set //
            {
                if (!teachvalue_initialized || m_teachvalue != value)
                {
                    this.m_teachvalue = value;
                }
                teachvalue_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TeaID
        {
            get { return this.m_teaid; }
            set //
            {
                if (!teaid_initialized || m_teaid != value)
                {
                    this.m_teaid = value;
                }
                teaid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeaName
        {
            get { return this.m_teaname; }
            set //
            {
                if (!teaname_initialized || m_teaname != value)
                {
                    this.m_teaname = value;
                }
                teaname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeaPic
        {
            get { return this.m_teapic; }
            set //
            {
                if (!teapic_initialized || m_teapic != value)
                {
                    this.m_teapic = value;
                }
                teapic_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal TeaScore
        {
            get { return this.m_teascore; }
            set //
            {
                if (!teascore_initialized || m_teascore != value)
                {
                    this.m_teascore = value;
                }
                teascore_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UsePoint
        {
            get { return this.m_usepoint; }
            set //
            {
                if (!usepoint_initialized || m_usepoint != value)
                {
                    this.m_usepoint = value;
                }
                usepoint_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_lession_appointInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Absent =  new AttributeItem("[Xb_lession_appointInfo].[Absent]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AppointId =  new AttributeItem("[Xb_lession_appointInfo].[AppointId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BbsIsVideo =  new AttributeItem("[Xb_lession_appointInfo].[BbsIsVideo]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CanUseAppInClass =  new AttributeItem("[Xb_lession_appointInfo].[CanUseAppInClass]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseID =  new AttributeItem("[Xb_lession_appointInfo].[CourseID]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseNameLesson =  new AttributeItem("[Xb_lession_appointInfo].[CourseNameLesson]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseNameTop =  new AttributeItem("[Xb_lession_appointInfo].[CourseNameTop]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseNameUnit =  new AttributeItem("[Xb_lession_appointInfo].[CourseNameUnit]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseUrl =  new AttributeItem("[Xb_lession_appointInfo].[CourseUrl]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_lession_appointInfo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EndTime =  new AttributeItem("[Xb_lession_appointInfo].[EndTime]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsEvaluate =  new AttributeItem("[Xb_lession_appointInfo].[IsEvaluate]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsGrading =  new AttributeItem("[Xb_lession_appointInfo].[IsGrading]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsHaveReview =  new AttributeItem("[Xb_lession_appointInfo].[IsHaveReview]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsNewGrading =  new AttributeItem("[Xb_lession_appointInfo].[IsNewGrading]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsPreview =  new AttributeItem("[Xb_lession_appointInfo].[IsPreview]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsSale =  new AttributeItem("[Xb_lession_appointInfo].[IsSale]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_lession_appointInfo].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PointType =  new AttributeItem("[Xb_lession_appointInfo].[PointType]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StartTime =  new AttributeItem("[Xb_lession_appointInfo].[StartTime]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xb_lession_appointInfo].[Status]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tag =  new AttributeItem("[Xb_lession_appointInfo].[Tag]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeachType =  new AttributeItem("[Xb_lession_appointInfo].[TeachType]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeachValue =  new AttributeItem("[Xb_lession_appointInfo].[TeachValue]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeaID =  new AttributeItem("[Xb_lession_appointInfo].[TeaID]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeaName =  new AttributeItem("[Xb_lession_appointInfo].[TeaName]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeaPic =  new AttributeItem("[Xb_lession_appointInfo].[TeaPic]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeaScore =  new AttributeItem("[Xb_lession_appointInfo].[TeaScore]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UsePoint =  new AttributeItem("[Xb_lession_appointInfo].[UsePoint]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_lession_appointInfo].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_absent;
        /// <summary></summary>
        protected bool absent_initialized = false;
        
        private int m_appointid;
        /// <summary></summary>
        protected bool appointid_initialized = false;
        
        private int m_bbsisvideo;
        /// <summary></summary>
        protected bool bbsisvideo_initialized = false;
        
        private int m_canuseappinclass;
        /// <summary></summary>
        protected bool canuseappinclass_initialized = false;
        
        private int m_courseid;
        /// <summary></summary>
        protected bool courseid_initialized = false;
        
        private string m_coursenamelesson;
        /// <summary></summary>
        protected bool coursenamelesson_initialized = false;
        
        private string m_coursenametop;
        /// <summary></summary>
        protected bool coursenametop_initialized = false;
        
        private string m_coursenameunit;
        /// <summary></summary>
        protected bool coursenameunit_initialized = false;
        
        private string m_courseurl;
        /// <summary></summary>
        protected bool courseurl_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_endtime;
        /// <summary></summary>
        protected bool endtime_initialized = false;
        
        private string m_isevaluate;
        /// <summary></summary>
        protected bool isevaluate_initialized = false;
        
        private string m_isgrading;
        /// <summary></summary>
        protected bool isgrading_initialized = false;
        
        private string m_ishavereview;
        /// <summary></summary>
        protected bool ishavereview_initialized = false;
        
        private string m_isnewgrading;
        /// <summary></summary>
        protected bool isnewgrading_initialized = false;
        
        private int m_ispreview;
        /// <summary></summary>
        protected bool ispreview_initialized = false;
        
        private string m_issale;
        /// <summary></summary>
        protected bool issale_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_pointtype;
        /// <summary></summary>
        protected bool pointtype_initialized = false;
        
        private string m_starttime;
        /// <summary></summary>
        protected bool starttime_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_tag;
        /// <summary></summary>
        protected bool tag_initialized = false;
        
        private string m_teachtype;
        /// <summary></summary>
        protected bool teachtype_initialized = false;
        
        private string m_teachvalue;
        /// <summary></summary>
        protected bool teachvalue_initialized = false;
        
        private int m_teaid;
        /// <summary></summary>
        protected bool teaid_initialized = false;
        
        private string m_teaname;
        /// <summary></summary>
        protected bool teaname_initialized = false;
        
        private string m_teapic;
        /// <summary></summary>
        protected bool teapic_initialized = false;
        
        private decimal m_teascore;
        /// <summary></summary>
        protected bool teascore_initialized = false;
        
        private string m_usepoint;
        /// <summary></summary>
        protected bool usepoint_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_lession_appointInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.absent_initialized = IsLoadAllAttributes;this.appointid_initialized = IsLoadAllAttributes;this.bbsisvideo_initialized = IsLoadAllAttributes;this.canuseappinclass_initialized = IsLoadAllAttributes;this.courseid_initialized = IsLoadAllAttributes;this.coursenamelesson_initialized = IsLoadAllAttributes;this.coursenametop_initialized = IsLoadAllAttributes;this.coursenameunit_initialized = IsLoadAllAttributes;this.courseurl_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.endtime_initialized = IsLoadAllAttributes;this.isevaluate_initialized = IsLoadAllAttributes;this.isgrading_initialized = IsLoadAllAttributes;this.ishavereview_initialized = IsLoadAllAttributes;this.isnewgrading_initialized = IsLoadAllAttributes;this.ispreview_initialized = IsLoadAllAttributes;this.issale_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.pointtype_initialized = IsLoadAllAttributes;this.starttime_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.tag_initialized = IsLoadAllAttributes;this.teachtype_initialized = IsLoadAllAttributes;this.teachvalue_initialized = IsLoadAllAttributes;this.teaid_initialized = IsLoadAllAttributes;this.teaname_initialized = IsLoadAllAttributes;this.teapic_initialized = IsLoadAllAttributes;this.teascore_initialized = IsLoadAllAttributes;this.usepoint_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_lession_appointInfo value = new Xb_lession_appointInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Absent"))
				value.absent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AppointId"))
				value.appointid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BbsIsVideo"))
				value.bbsisvideo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CanUseAppInClass"))
				value.canuseappinclass_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseID"))
				value.courseid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseNameLesson"))
				value.coursenamelesson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseNameTop"))
				value.coursenametop_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseNameUnit"))
				value.coursenameunit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseUrl"))
				value.courseurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EndTime"))
				value.endtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsEvaluate"))
				value.isevaluate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsGrading"))
				value.isgrading_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHaveReview"))
				value.ishavereview_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsNewGrading"))
				value.isnewgrading_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsPreview"))
				value.ispreview_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsSale"))
				value.issale_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PointType"))
				value.pointtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StartTime"))
				value.starttime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tag"))
				value.tag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeachType"))
				value.teachtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeachValue"))
				value.teachvalue_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeaID"))
				value.teaid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeaName"))
				value.teaname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeaPic"))
				value.teapic_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeaScore"))
				value.teascore_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UsePoint"))
				value.usepoint_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_lession_appointInfo Clone()
        {
            return (Xb_lession_appointInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_lession_appointInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_lession_appointInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_lession_appointInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_lession_appointInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_lession_appointInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_lession_appointInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_lession_appointInfo(int id1, string absent1, int appointid1, int bbsisvideo1, int canuseappinclass1, int courseid1, string coursenamelesson1, string coursenametop1, string coursenameunit1, string courseurl1, DateTime createtime1, string endtime1, string isevaluate1, string isgrading1, string ishavereview1, string isnewgrading1, int ispreview1, string issale1, DateTime modifytime1, string pointtype1, string starttime1, string status1, string tag1, string teachtype1, string teachvalue1, int teaid1, string teaname1, string teapic1, decimal teascore1, string usepoint1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Absent = absent1;
            
            this.AppointId = appointid1;
            
            this.BbsIsVideo = bbsisvideo1;
            
            this.CanUseAppInClass = canuseappinclass1;
            
            this.CourseID = courseid1;
            
            this.CourseNameLesson = coursenamelesson1;
            
            this.CourseNameTop = coursenametop1;
            
            this.CourseNameUnit = coursenameunit1;
            
            this.CourseUrl = courseurl1;
            
            this.CreateTime = createtime1;
            
            this.EndTime = endtime1;
            
            this.IsEvaluate = isevaluate1;
            
            this.IsGrading = isgrading1;
            
            this.IsHaveReview = ishavereview1;
            
            this.IsNewGrading = isnewgrading1;
            
            this.IsPreview = ispreview1;
            
            this.IsSale = issale1;
            
            this.ModifyTime = modifytime1;
            
            this.PointType = pointtype1;
            
            this.StartTime = starttime1;
            
            this.Status = status1;
            
            this.Tag = tag1;
            
            this.TeachType = teachtype1;
            
            this.TeachValue = teachvalue1;
            
            this.TeaID = teaid1;
            
            this.TeaName = teaname1;
            
            this.TeaPic = teapic1;
            
            this.TeaScore = teascore1;
            
            this.UsePoint = usepoint1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_lession_appointInfo FromIView(IView view)
        {
            return (Xb_lession_appointInfo)IView.GetITable(view, "Xb_lession_appointInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_lession_appointInfo GetOneInstance()
        {
            Xb_lession_appointInfo value = new Xb_lession_appointInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_lession_appointInfo Retrieve()
        {
            BLLTable<Xb_lession_appointInfo>.GetRowData(this);
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
			    			
			    case "Absent":
			        return Absent;
			    			
			    case "AppointId":
			        return AppointId;
			    			
			    case "BbsIsVideo":
			        return BbsIsVideo;
			    			
			    case "CanUseAppInClass":
			        return CanUseAppInClass;
			    			
			    case "CourseID":
			        return CourseID;
			    			
			    case "CourseNameLesson":
			        return CourseNameLesson;
			    			
			    case "CourseNameTop":
			        return CourseNameTop;
			    			
			    case "CourseNameUnit":
			        return CourseNameUnit;
			    			
			    case "CourseUrl":
			        return CourseUrl;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "EndTime":
			        return EndTime;
			    			
			    case "IsEvaluate":
			        return IsEvaluate;
			    			
			    case "IsGrading":
			        return IsGrading;
			    			
			    case "IsHaveReview":
			        return IsHaveReview;
			    			
			    case "IsNewGrading":
			        return IsNewGrading;
			    			
			    case "IsPreview":
			        return IsPreview;
			    			
			    case "IsSale":
			        return IsSale;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "PointType":
			        return PointType;
			    			
			    case "StartTime":
			        return StartTime;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Tag":
			        return Tag;
			    			
			    case "TeachType":
			        return TeachType;
			    			
			    case "TeachValue":
			        return TeachValue;
			    			
			    case "TeaID":
			        return TeaID;
			    			
			    case "TeaName":
			        return TeaName;
			    			
			    case "TeaPic":
			        return TeaPic;
			    			
			    case "TeaScore":
			        return TeaScore;
			    			
			    case "UsePoint":
			        return UsePoint;
			    			
			    case "Uuid":
			        return Uuid;
			
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
			    			
			    case "Absent":
			        this.Absent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AppointId":
			        this.AppointId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "BbsIsVideo":
			        this.BbsIsVideo = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CanUseAppInClass":
			        this.CanUseAppInClass = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CourseID":
			        this.CourseID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CourseNameLesson":
			        this.CourseNameLesson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CourseNameTop":
			        this.CourseNameTop = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CourseNameUnit":
			        this.CourseNameUnit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CourseUrl":
			        this.CourseUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "EndTime":
			        this.EndTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsEvaluate":
			        this.IsEvaluate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsGrading":
			        this.IsGrading = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHaveReview":
			        this.IsHaveReview = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsNewGrading":
			        this.IsNewGrading = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsPreview":
			        this.IsPreview = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IsSale":
			        this.IsSale = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "PointType":
			        this.PointType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StartTime":
			        this.StartTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tag":
			        this.Tag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeachType":
			        this.TeachType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeachValue":
			        this.TeachValue = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeaID":
			        this.TeaID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TeaName":
			        this.TeaName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeaPic":
			        this.TeaPic = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeaScore":
			        this.TeaScore = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "UsePoint":
			        this.UsePoint = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "Absent":
					return absent_initialized;
				
				case "AppointId":
					return appointid_initialized;
				
				case "BbsIsVideo":
					return bbsisvideo_initialized;
				
				case "CanUseAppInClass":
					return canuseappinclass_initialized;
				
				case "CourseID":
					return courseid_initialized;
				
				case "CourseNameLesson":
					return coursenamelesson_initialized;
				
				case "CourseNameTop":
					return coursenametop_initialized;
				
				case "CourseNameUnit":
					return coursenameunit_initialized;
				
				case "CourseUrl":
					return courseurl_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "EndTime":
					return endtime_initialized;
				
				case "IsEvaluate":
					return isevaluate_initialized;
				
				case "IsGrading":
					return isgrading_initialized;
				
				case "IsHaveReview":
					return ishavereview_initialized;
				
				case "IsNewGrading":
					return isnewgrading_initialized;
				
				case "IsPreview":
					return ispreview_initialized;
				
				case "IsSale":
					return issale_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "PointType":
					return pointtype_initialized;
				
				case "StartTime":
					return starttime_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Tag":
					return tag_initialized;
				
				case "TeachType":
					return teachtype_initialized;
				
				case "TeachValue":
					return teachvalue_initialized;
				
				case "TeaID":
					return teaid_initialized;
				
				case "TeaName":
					return teaname_initialized;
				
				case "TeaPic":
					return teapic_initialized;
				
				case "TeaScore":
					return teascore_initialized;
				
				case "UsePoint":
					return usepoint_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
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
				
				case "Absent":
					absent_initialized = ret;
					return true;
				
				case "AppointId":
					appointid_initialized = ret;
					return true;
				
				case "BbsIsVideo":
					bbsisvideo_initialized = ret;
					return true;
				
				case "CanUseAppInClass":
					canuseappinclass_initialized = ret;
					return true;
				
				case "CourseID":
					courseid_initialized = ret;
					return true;
				
				case "CourseNameLesson":
					coursenamelesson_initialized = ret;
					return true;
				
				case "CourseNameTop":
					coursenametop_initialized = ret;
					return true;
				
				case "CourseNameUnit":
					coursenameunit_initialized = ret;
					return true;
				
				case "CourseUrl":
					courseurl_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "EndTime":
					endtime_initialized = ret;
					return true;
				
				case "IsEvaluate":
					isevaluate_initialized = ret;
					return true;
				
				case "IsGrading":
					isgrading_initialized = ret;
					return true;
				
				case "IsHaveReview":
					ishavereview_initialized = ret;
					return true;
				
				case "IsNewGrading":
					isnewgrading_initialized = ret;
					return true;
				
				case "IsPreview":
					ispreview_initialized = ret;
					return true;
				
				case "IsSale":
					issale_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "PointType":
					pointtype_initialized = ret;
					return true;
				
				case "StartTime":
					starttime_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Tag":
					tag_initialized = ret;
					return true;
				
				case "TeachType":
					teachtype_initialized = ret;
					return true;
				
				case "TeachValue":
					teachvalue_initialized = ret;
					return true;
				
				case "TeaID":
					teaid_initialized = ret;
					return true;
				
				case "TeaName":
					teaname_initialized = ret;
					return true;
				
				case "TeaPic":
					teapic_initialized = ret;
					return true;
				
				case "TeaScore":
					teascore_initialized = ret;
					return true;
				
				case "UsePoint":
					usepoint_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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
                AttributeItem attr = Xb_lession_appointInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (absent_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.Absent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Absent);
                }
			}
			
			if (appointid_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.AppointId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AppointId);
                }
			}
			
			if (bbsisvideo_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.BbsIsVideo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BbsIsVideo);
                }
			}
			
			if (canuseappinclass_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CanUseAppInClass;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CanUseAppInClass);
                }
			}
			
			if (courseid_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CourseID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseID);
                }
			}
			
			if (coursenamelesson_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CourseNameLesson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseNameLesson);
                }
			}
			
			if (coursenametop_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CourseNameTop;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseNameTop);
                }
			}
			
			if (coursenameunit_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CourseNameUnit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseNameUnit);
                }
			}
			
			if (courseurl_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CourseUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseUrl);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (endtime_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.EndTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EndTime);
                }
			}
			
			if (isevaluate_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsEvaluate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsEvaluate);
                }
			}
			
			if (isgrading_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsGrading;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsGrading);
                }
			}
			
			if (ishavereview_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsHaveReview;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHaveReview);
                }
			}
			
			if (isnewgrading_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsNewGrading;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsNewGrading);
                }
			}
			
			if (ispreview_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsPreview;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsPreview);
                }
			}
			
			if (issale_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.IsSale;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsSale);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (pointtype_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.PointType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PointType);
                }
			}
			
			if (starttime_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.StartTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StartTime);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (tag_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.Tag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tag);
                }
			}
			
			if (teachtype_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeachType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeachType);
                }
			}
			
			if (teachvalue_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeachValue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeachValue);
                }
			}
			
			if (teaid_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeaID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeaID);
                }
			}
			
			if (teaname_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeaName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeaName);
                }
			}
			
			if (teapic_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeaPic;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeaPic);
                }
			}
			
			if (teascore_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.TeaScore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeaScore);
                }
			}
			
			if (usepoint_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.UsePoint;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UsePoint);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_lession_appointInfo.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
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
        public class Xb_lession_appointInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Absent { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int AppointId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int BbsIsVideo { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int CanUseAppInClass { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int CourseID { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CourseNameLesson { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CourseNameTop { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CourseNameUnit { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CourseUrl { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string EndTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsEvaluate { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsGrading { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsHaveReview { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsNewGrading { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int IsPreview { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsSale { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PointType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string StartTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Tag { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeachType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeachValue { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int TeaID { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeaName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeaPic { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal TeaScore { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string UsePoint { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}