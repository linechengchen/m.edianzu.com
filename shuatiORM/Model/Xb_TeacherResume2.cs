/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:05
  Description:    数据表Xb_TeacherResume2对应的业务逻辑层Xb_TeacherResume2
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_TeacherResume2_Entity:Xb_TeacherResume2
 * 
************************************************************/
/************************************************************
SQL代码：
select BornDate,ClassTimerNext,ClassYuyueNext,College,CreateDate,CreateTime,DianZanCount,Experience,ExperienceType,ExperienceYear,Good,GuanzhuCount,HighSchool,HomeworkCity,ID,ImgPath,JiangXueJin,LaiYuan,LiuLanQi,MianShiPingfen1,MianShiPingfen2,MianShiPingfen3,MianShiPingJia,MyInfor,MyVoice,OpenId,OS,PhoneNumber,PingLunCount,Sex,ShebeiPhone,ShebeiXiTong,StarLevel,Tag,TeacherCode,TeacherName,WorkCity,WorkCityDetail,WxCity,WxHeadImage,WxNiChen,WxSex,XiuGaiRen,XiuGaiTime,YuYinJieshao from Xb_TeacherResume2
delete from Xb_TeacherResume2
INSERT INTO Xb_TeacherResume2 (BornDate,ClassTimerNext,ClassYuyueNext,College,CreateDate,CreateTime,DianZanCount,Experience,ExperienceType,ExperienceYear,Good,GuanzhuCount,HighSchool,HomeworkCity,ID,ImgPath,JiangXueJin,LaiYuan,LiuLanQi,MianShiPingfen1,MianShiPingfen2,MianShiPingfen3,MianShiPingJia,MyInfor,MyVoice,OpenId,OS,PhoneNumber,PingLunCount,Sex,ShebeiPhone,ShebeiXiTong,StarLevel,Tag,TeacherCode,TeacherName,WorkCity,WorkCityDetail,WxCity,WxHeadImage,WxNiChen,WxSex,XiuGaiRen,XiuGaiTime,YuYinJieshao)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_TeacherResume2 SET ...
变量赋值代码：
 *         valObj.BornDate = valObj2.BornDate;
        valObj.ClassTimerNext = valObj2.ClassTimerNext;
        valObj.ClassYuyueNext = valObj2.ClassYuyueNext;
        valObj.College = valObj2.College;
        valObj.CreateDate = valObj2.CreateDate;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.DianZanCount = valObj2.DianZanCount;
        valObj.Experience = valObj2.Experience;
        valObj.ExperienceType = valObj2.ExperienceType;
        valObj.ExperienceYear = valObj2.ExperienceYear;
        valObj.Good = valObj2.Good;
        valObj.GuanzhuCount = valObj2.GuanzhuCount;
        valObj.HighSchool = valObj2.HighSchool;
        valObj.HomeworkCity = valObj2.HomeworkCity;
        valObj.ID = valObj2.ID;
        valObj.ImgPath = valObj2.ImgPath;
        valObj.JiangXueJin = valObj2.JiangXueJin;
        valObj.LaiYuan = valObj2.LaiYuan;
        valObj.LiuLanQi = valObj2.LiuLanQi;
        valObj.MianShiPingfen1 = valObj2.MianShiPingfen1;
        valObj.MianShiPingfen2 = valObj2.MianShiPingfen2;
        valObj.MianShiPingfen3 = valObj2.MianShiPingfen3;
        valObj.MianShiPingJia = valObj2.MianShiPingJia;
        valObj.MyInfor = valObj2.MyInfor;
        valObj.MyVoice = valObj2.MyVoice;
        valObj.OpenId = valObj2.OpenId;
        valObj.OS = valObj2.OS;
        valObj.PhoneNumber = valObj2.PhoneNumber;
        valObj.PingLunCount = valObj2.PingLunCount;
        valObj.Sex = valObj2.Sex;
        valObj.ShebeiPhone = valObj2.ShebeiPhone;
        valObj.ShebeiXiTong = valObj2.ShebeiXiTong;
        valObj.StarLevel = valObj2.StarLevel;
        valObj.Tag = valObj2.Tag;
        valObj.TeacherCode = valObj2.TeacherCode;
        valObj.TeacherName = valObj2.TeacherName;
        valObj.WorkCity = valObj2.WorkCity;
        valObj.WorkCityDetail = valObj2.WorkCityDetail;
        valObj.WxCity = valObj2.WxCity;
        valObj.WxHeadImage = valObj2.WxHeadImage;
        valObj.WxNiChen = valObj2.WxNiChen;
        valObj.WxSex = valObj2.WxSex;
        valObj.XiuGaiRen = valObj2.XiuGaiRen;
        valObj.XiuGaiTime = valObj2.XiuGaiTime;
        valObj.YuYinJieshao = valObj2.YuYinJieshao; 
        valObj.BornDate = "";
        valObj.ClassTimerNext = "";
        valObj.ClassYuyueNext = "";
        valObj.College = "";
        valObj.CreateDate = "";
        valObj.CreateTime = "";
        valObj.DianZanCount = "";
        valObj.Experience = "";
        valObj.ExperienceType = "";
        valObj.ExperienceYear = "";
        valObj.Good = "";
        valObj.GuanzhuCount = "";
        valObj.HighSchool = "";
        valObj.HomeworkCity = "";
        valObj.ID = "";
        valObj.ImgPath = "";
        valObj.JiangXueJin = "";
        valObj.LaiYuan = "";
        valObj.LiuLanQi = "";
        valObj.MianShiPingfen1 = "";
        valObj.MianShiPingfen2 = "";
        valObj.MianShiPingfen3 = "";
        valObj.MianShiPingJia = "";
        valObj.MyInfor = "";
        valObj.MyVoice = "";
        valObj.OpenId = "";
        valObj.OS = "";
        valObj.PhoneNumber = "";
        valObj.PingLunCount = "";
        valObj.Sex = "";
        valObj.ShebeiPhone = "";
        valObj.ShebeiXiTong = "";
        valObj.StarLevel = "";
        valObj.Tag = "";
        valObj.TeacherCode = "";
        valObj.TeacherName = "";
        valObj.WorkCity = "";
        valObj.WorkCityDetail = "";
        valObj.WxCity = "";
        valObj.WxHeadImage = "";
        valObj.WxNiChen = "";
        valObj.WxSex = "";
        valObj.XiuGaiRen = "";
        valObj.XiuGaiTime = "";
        valObj.YuYinJieshao = ""; 
        "BornDate": $("#txt_BornDate").val(),
        "ClassTimerNext": $("#txt_ClassTimerNext").val(),
        "ClassYuyueNext": $("#txt_ClassYuyueNext").val(),
        "College": $("#txt_College").val(),
        "CreateDate": $("#txt_CreateDate").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "DianZanCount": $("#txt_DianZanCount").val(),
        "Experience": $("#txt_Experience").val(),
        "ExperienceType": $("#txt_ExperienceType").val(),
        "ExperienceYear": $("#txt_ExperienceYear").val(),
        "Good": $("#txt_Good").val(),
        "GuanzhuCount": $("#txt_GuanzhuCount").val(),
        "HighSchool": $("#txt_HighSchool").val(),
        "HomeworkCity": $("#txt_HomeworkCity").val(),
        "ID": $("#txt_ID").val(),
        "ImgPath": $("#txt_ImgPath").val(),
        "JiangXueJin": $("#txt_JiangXueJin").val(),
        "LaiYuan": $("#txt_LaiYuan").val(),
        "LiuLanQi": $("#txt_LiuLanQi").val(),
        "MianShiPingfen1": $("#txt_MianShiPingfen1").val(),
        "MianShiPingfen2": $("#txt_MianShiPingfen2").val(),
        "MianShiPingfen3": $("#txt_MianShiPingfen3").val(),
        "MianShiPingJia": $("#txt_MianShiPingJia").val(),
        "MyInfor": $("#txt_MyInfor").val(),
        "MyVoice": $("#txt_MyVoice").val(),
        "OpenId": $("#txt_OpenId").val(),
        "OS": $("#txt_OS").val(),
        "PhoneNumber": $("#txt_PhoneNumber").val(),
        "PingLunCount": $("#txt_PingLunCount").val(),
        "Sex": $("#txt_Sex").val(),
        "ShebeiPhone": $("#txt_ShebeiPhone").val(),
        "ShebeiXiTong": $("#txt_ShebeiXiTong").val(),
        "StarLevel": $("#txt_StarLevel").val(),
        "Tag": $("#txt_Tag").val(),
        "TeacherCode": $("#txt_TeacherCode").val(),
        "TeacherName": $("#txt_TeacherName").val(),
        "WorkCity": $("#txt_WorkCity").val(),
        "WorkCityDetail": $("#txt_WorkCityDetail").val(),
        "WxCity": $("#txt_WxCity").val(),
        "WxHeadImage": $("#txt_WxHeadImage").val(),
        "WxNiChen": $("#txt_WxNiChen").val(),
        "WxSex": $("#txt_WxSex").val(),
        "XiuGaiRen": $("#txt_XiuGaiRen").val(),
        "XiuGaiTime": $("#txt_XiuGaiTime").val(),
        "YuYinJieshao": $("#txt_YuYinJieshao").val(), 
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
    /// <para>讲师简历信息:[IDField-{ID:0}]</para>
    /// <para>与Xb_TeacherResume2数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_TeacherResume2 : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_TeacherResume2 Factory()
        {
            return new Xb_TeacherResume2();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 出生年月:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BornDate
        {            
            get { return this.BornDate; }
            set { this.BornDate = value; }
        }
        
        /// <summary> 最近课程时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassTimerNext
        {            
            get { return this.ClassTimerNext; }
            set { this.ClassTimerNext = value; }
        }
        
        /// <summary> 最近是否被预约:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _ClassYuyueNext
        {            
            get { return this.ClassYuyueNext; }
            set { this.ClassYuyueNext = value; }
        }
        
        /// <summary> 大学学校:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College
        {            
            get { return this.College; }
            set { this.College = value; }
        }
        
        /// <summary> 评论时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CreateDate
        {            
            get { return this.CreateDate; }
            set { this.CreateDate = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _DianZanCount
        {            
            get { return this.DianZanCount; }
            set { this.DianZanCount = value; }
        }
        
        /// <summary> 有过哪些辅导或家教经验【小学、初、高中生或亲友小孩】（越详细越好123）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Experience
        {            
            get { return this.Experience; }
            set { this.Experience = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExperienceType
        {            
            get { return this.ExperienceType; }
            set { this.ExperienceType = value; }
        }
        
        /// <summary> 教学年限-新:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExperienceYear
        {            
            get { return this.ExperienceYear; }
            set { this.ExperienceYear = value; }
        }
        
        /// <summary> 擅长的科目与高考成绩（英语、数学等），才艺与才艺等级（钢琴、画画几级）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Good
        {            
            get { return this.Good; }
            set { this.Good = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _GuanzhuCount
        {            
            get { return this.GuanzhuCount; }
            set { this.GuanzhuCount = value; }
        }
        
        /// <summary> 高中学校:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HighSchool
        {            
            get { return this.HighSchool; }
            set { this.HighSchool = value; }
        }
        
        /// <summary> 家乡所在城市:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _HomeworkCity
        {            
            get { return this.HomeworkCity; }
            set { this.HomeworkCity = value; }
        }
        
        /// <summary> 编号:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> 随身照:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ImgPath
        {            
            get { return this.ImgPath; }
            set { this.ImgPath = value; }
        }
        
        /// <summary> 奖学金和特长与竞赛名次:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _JiangXueJin
        {            
            get { return this.JiangXueJin; }
            set { this.JiangXueJin = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _LaiYuan
        {            
            get { return this.LaiYuan; }
            set { this.LaiYuan = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _LiuLanQi
        {            
            get { return this.LiuLanQi; }
            set { this.LiuLanQi = value; }
        }
        
        /// <summary> 面试评分1:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MianShiPingfen1
        {            
            get { return this.MianShiPingfen1; }
            set { this.MianShiPingfen1 = value; }
        }
        
        /// <summary> 面试评分2:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MianShiPingfen2
        {            
            get { return this.MianShiPingfen2; }
            set { this.MianShiPingfen2 = value; }
        }
        
        /// <summary> 面试评分3:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MianShiPingfen3
        {            
            get { return this.MianShiPingfen3; }
            set { this.MianShiPingfen3 = value; }
        }
        
        /// <summary> 面试评价:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MianShiPingJia
        {            
            get { return this.MianShiPingJia; }
            set { this.MianShiPingJia = value; }
        }
        
        /// <summary> 自我介绍MyInfor:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _MyInfor
        {            
            get { return this.MyInfor; }
            set { this.MyInfor = value; }
        }
        
        /// <summary> 自我介绍语音MyVoice:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MyVoice
        {            
            get { return this.MyVoice; }
            set { this.MyVoice = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OS
        {            
            get { return this.OS; }
            set { this.OS = value; }
        }
        
        /// <summary> 电话号码:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PhoneNumber
        {            
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PingLunCount
        {            
            get { return this.PingLunCount; }
            set { this.PingLunCount = value; }
        }
        
        /// <summary> 性别:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShebeiPhone
        {            
            get { return this.ShebeiPhone; }
            set { this.ShebeiPhone = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShebeiXiTong
        {            
            get { return this.ShebeiXiTong; }
            set { this.ShebeiXiTong = value; }
        }
        
        /// <summary> 星级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _StarLevel
        {            
            get { return this.StarLevel; }
            set { this.StarLevel = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Tag
        {            
            get { return this.Tag; }
            set { this.Tag = value; }
        }
        
        /// <summary> 学霸编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherCode
        {            
            get { return this.TeacherCode; }
            set { this.TeacherCode = value; }
        }
        
        /// <summary> 讲师姓名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherName
        {            
            get { return this.TeacherName; }
            set { this.TeacherName = value; }
        }
        
        /// <summary> 意向工作区域（2个以上县市名及工作时间）如:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WorkCity
        {            
            get { return this.WorkCity; }
            set { this.WorkCity = value; }
        }
        
        /// <summary> 家乡所在工作区域（城市和县区名）如:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WorkCityDetail
        {            
            get { return this.WorkCityDetail; }
            set { this.WorkCityDetail = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WxCity
        {            
            get { return this.WxCity; }
            set { this.WxCity = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WxHeadImage
        {            
            get { return this.WxHeadImage; }
            set { this.WxHeadImage = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WxNiChen
        {            
            get { return this.WxNiChen; }
            set { this.WxNiChen = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WxSex
        {            
            get { return this.WxSex; }
            set { this.WxSex = value; }
        }
        
        /// <summary> 修改人:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _XiuGaiRen
        {            
            get { return this.XiuGaiRen; }
            set { this.XiuGaiRen = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _XiuGaiTime
        {            
            get { return this.XiuGaiTime; }
            set { this.XiuGaiTime = value; }
        }
        
        /// <summary> 语音介绍:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YuYinJieshao
        {            
            get { return this.YuYinJieshao; }
            set { this.YuYinJieshao = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 出生年月:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string BornDate
        {
            get { return this.m_borndate; }
            set //
            {
                if (!borndate_initialized || m_borndate != value)
                {
                    this.m_borndate = value;
                }
                borndate_initialized = true;
            }
        }
        
        /// <summary> 最近课程时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ClassTimerNext
        {
            get { return this.m_classtimernext; }
            set //
            {
                if (!classtimernext_initialized || m_classtimernext != value)
                {
                    this.m_classtimernext = value;
                }
                classtimernext_initialized = true;
            }
        }
        
        /// <summary> 最近是否被预约:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool ClassYuyueNext
        {
            get { return this.m_classyuyuenext; }
            set //
            {
                if (!classyuyuenext_initialized || m_classyuyuenext != value)
                {
                    this.m_classyuyuenext = value;
                }
                classyuyuenext_initialized = true;
            }
        }
        
        /// <summary> 大学学校:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string College
        {
            get { return this.m_college; }
            set //
            {
                if (!college_initialized || m_college != value)
                {
                    this.m_college = value;
                }
                college_initialized = true;
            }
        }
        
        /// <summary> 评论时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CreateDate
        {
            get { return this.m_createdate; }
            set //
            {
                if (!createdate_initialized || m_createdate != value)
                {
                    this.m_createdate = value;
                }
                createdate_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int DianZanCount
        {
            get { return this.m_dianzancount; }
            set //
            {
                if (!dianzancount_initialized || m_dianzancount != value)
                {
                    this.m_dianzancount = value;
                }
                dianzancount_initialized = true;
            }
        }
        
        /// <summary> 有过哪些辅导或家教经验【小学、初、高中生或亲友小孩】（越详细越好123）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Experience
        {
            get { return this.m_experience; }
            set //
            {
                if (!experience_initialized || m_experience != value)
                {
                    this.m_experience = value;
                }
                experience_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExperienceType
        {
            get { return this.m_experiencetype; }
            set //
            {
                if (!experiencetype_initialized || m_experiencetype != value)
                {
                    this.m_experiencetype = value;
                }
                experiencetype_initialized = true;
            }
        }
        
        /// <summary> 教学年限-新:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExperienceYear
        {
            get { return this.m_experienceyear; }
            set //
            {
                if (!experienceyear_initialized || m_experienceyear != value)
                {
                    this.m_experienceyear = value;
                }
                experienceyear_initialized = true;
            }
        }
        
        /// <summary> 擅长的科目与高考成绩（英语、数学等），才艺与才艺等级（钢琴、画画几级）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Good
        {
            get { return this.m_good; }
            set //
            {
                if (!good_initialized || m_good != value)
                {
                    this.m_good = value;
                }
                good_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int GuanzhuCount
        {
            get { return this.m_guanzhucount; }
            set //
            {
                if (!guanzhucount_initialized || m_guanzhucount != value)
                {
                    this.m_guanzhucount = value;
                }
                guanzhucount_initialized = true;
            }
        }
        
        /// <summary> 高中学校:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string HighSchool
        {
            get { return this.m_highschool; }
            set //
            {
                if (!highschool_initialized || m_highschool != value)
                {
                    this.m_highschool = value;
                }
                highschool_initialized = true;
            }
        }
        
        /// <summary> 家乡所在城市:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string HomeworkCity
        {
            get { return this.m_homeworkcity; }
            set //
            {
                if (!homeworkcity_initialized || m_homeworkcity != value)
                {
                    this.m_homeworkcity = value;
                }
                homeworkcity_initialized = true;
            }
        }
        
        /// <summary> 编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ID
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
        
        /// <summary> 随身照:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ImgPath
        {
            get { return this.m_imgpath; }
            set //
            {
                if (!imgpath_initialized || m_imgpath != value)
                {
                    this.m_imgpath = value;
                }
                imgpath_initialized = true;
            }
        }
        
        /// <summary> 奖学金和特长与竞赛名次:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string JiangXueJin
        {
            get { return this.m_jiangxuejin; }
            set //
            {
                if (!jiangxuejin_initialized || m_jiangxuejin != value)
                {
                    this.m_jiangxuejin = value;
                }
                jiangxuejin_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string LaiYuan
        {
            get { return this.m_laiyuan; }
            set //
            {
                if (!laiyuan_initialized || m_laiyuan != value)
                {
                    this.m_laiyuan = value;
                }
                laiyuan_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string LiuLanQi
        {
            get { return this.m_liulanqi; }
            set //
            {
                if (!liulanqi_initialized || m_liulanqi != value)
                {
                    this.m_liulanqi = value;
                }
                liulanqi_initialized = true;
            }
        }
        
        /// <summary> 面试评分1:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MianShiPingfen1
        {
            get { return this.m_mianshipingfen1; }
            set //
            {
                if (!mianshipingfen1_initialized || m_mianshipingfen1 != value)
                {
                    this.m_mianshipingfen1 = value;
                }
                mianshipingfen1_initialized = true;
            }
        }
        
        /// <summary> 面试评分2:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MianShiPingfen2
        {
            get { return this.m_mianshipingfen2; }
            set //
            {
                if (!mianshipingfen2_initialized || m_mianshipingfen2 != value)
                {
                    this.m_mianshipingfen2 = value;
                }
                mianshipingfen2_initialized = true;
            }
        }
        
        /// <summary> 面试评分3:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MianShiPingfen3
        {
            get { return this.m_mianshipingfen3; }
            set //
            {
                if (!mianshipingfen3_initialized || m_mianshipingfen3 != value)
                {
                    this.m_mianshipingfen3 = value;
                }
                mianshipingfen3_initialized = true;
            }
        }
        
        /// <summary> 面试评价:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MianShiPingJia
        {
            get { return this.m_mianshipingjia; }
            set //
            {
                if (!mianshipingjia_initialized || m_mianshipingjia != value)
                {
                    this.m_mianshipingjia = value;
                }
                mianshipingjia_initialized = true;
            }
        }
        
        /// <summary> 自我介绍MyInfor:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string MyInfor
        {
            get { return this.m_myinfor; }
            set //
            {
                if (!myinfor_initialized || m_myinfor != value)
                {
                    this.m_myinfor = value;
                }
                myinfor_initialized = true;
            }
        }
        
        /// <summary> 自我介绍语音MyVoice:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MyVoice
        {
            get { return this.m_myvoice; }
            set //
            {
                if (!myvoice_initialized || m_myvoice != value)
                {
                    this.m_myvoice = value;
                }
                myvoice_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OS
        {
            get { return this.m_os; }
            set //
            {
                if (!os_initialized || m_os != value)
                {
                    this.m_os = value;
                }
                os_initialized = true;
            }
        }
        
        /// <summary> 电话号码:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PhoneNumber
        {
            get { return this.m_phonenumber; }
            set //
            {
                if (!phonenumber_initialized || m_phonenumber != value)
                {
                    this.m_phonenumber = value;
                }
                phonenumber_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PingLunCount
        {
            get { return this.m_pingluncount; }
            set //
            {
                if (!pingluncount_initialized || m_pingluncount != value)
                {
                    this.m_pingluncount = value;
                }
                pingluncount_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ShebeiPhone
        {
            get { return this.m_shebeiphone; }
            set //
            {
                if (!shebeiphone_initialized || m_shebeiphone != value)
                {
                    this.m_shebeiphone = value;
                }
                shebeiphone_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ShebeiXiTong
        {
            get { return this.m_shebeixitong; }
            set //
            {
                if (!shebeixitong_initialized || m_shebeixitong != value)
                {
                    this.m_shebeixitong = value;
                }
                shebeixitong_initialized = true;
            }
        }
        
        /// <summary> 星级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string StarLevel
        {
            get { return this.m_starlevel; }
            set //
            {
                if (!starlevel_initialized || m_starlevel != value)
                {
                    this.m_starlevel = value;
                }
                starlevel_initialized = true;
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
        
        /// <summary> 学霸编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeacherCode
        {
            get { return this.m_teachercode; }
            set //
            {
                if (!teachercode_initialized || m_teachercode != value)
                {
                    this.m_teachercode = value;
                }
                teachercode_initialized = true;
            }
        }
        
        /// <summary> 讲师姓名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeacherName
        {
            get { return this.m_teachername; }
            set //
            {
                if (!teachername_initialized || m_teachername != value)
                {
                    this.m_teachername = value;
                }
                teachername_initialized = true;
            }
        }
        
        /// <summary> 意向工作区域（2个以上县市名及工作时间）如:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WorkCity
        {
            get { return this.m_workcity; }
            set //
            {
                if (!workcity_initialized || m_workcity != value)
                {
                    this.m_workcity = value;
                }
                workcity_initialized = true;
            }
        }
        
        /// <summary> 家乡所在工作区域（城市和县区名）如:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WorkCityDetail
        {
            get { return this.m_workcitydetail; }
            set //
            {
                if (!workcitydetail_initialized || m_workcitydetail != value)
                {
                    this.m_workcitydetail = value;
                }
                workcitydetail_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WxCity
        {
            get { return this.m_wxcity; }
            set //
            {
                if (!wxcity_initialized || m_wxcity != value)
                {
                    this.m_wxcity = value;
                }
                wxcity_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WxHeadImage
        {
            get { return this.m_wxheadimage; }
            set //
            {
                if (!wxheadimage_initialized || m_wxheadimage != value)
                {
                    this.m_wxheadimage = value;
                }
                wxheadimage_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WxNiChen
        {
            get { return this.m_wxnichen; }
            set //
            {
                if (!wxnichen_initialized || m_wxnichen != value)
                {
                    this.m_wxnichen = value;
                }
                wxnichen_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WxSex
        {
            get { return this.m_wxsex; }
            set //
            {
                if (!wxsex_initialized || m_wxsex != value)
                {
                    this.m_wxsex = value;
                }
                wxsex_initialized = true;
            }
        }
        
        /// <summary> 修改人:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string XiuGaiRen
        {
            get { return this.m_xiugairen; }
            set //
            {
                if (!xiugairen_initialized || m_xiugairen != value)
                {
                    this.m_xiugairen = value;
                }
                xiugairen_initialized = true;
            }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string XiuGaiTime
        {
            get { return this.m_xiugaitime; }
            set //
            {
                if (!xiugaitime_initialized || m_xiugaitime != value)
                {
                    this.m_xiugaitime = value;
                }
                xiugaitime_initialized = true;
            }
        }
        
        /// <summary> 语音介绍:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string YuYinJieshao
        {
            get { return this.m_yuyinjieshao; }
            set //
            {
                if (!yuyinjieshao_initialized || m_yuyinjieshao != value)
                {
                    this.m_yuyinjieshao = value;
                }
                yuyinjieshao_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>出生年月:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BornDate =  new AttributeItem("[Xb_TeacherResume2].[BornDate]", typeof(string), 50, default(string));
            
            /// <summary>最近课程时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTimerNext =  new AttributeItem("[Xb_TeacherResume2].[ClassTimerNext]", typeof(string), 50, default(string));
            
            /// <summary>最近是否被预约:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem ClassYuyueNext =  new AttributeItem("[Xb_TeacherResume2].[ClassYuyueNext]", typeof(bool), 1, default(bool));
            
            /// <summary>大学学校:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College =  new AttributeItem("[Xb_TeacherResume2].[College]", typeof(string), 100, default(string));
            
            /// <summary>评论时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CreateDate =  new AttributeItem("[Xb_TeacherResume2].[CreateDate]", typeof(string), 200, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_TeacherResume2].[CreateTime]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DianZanCount =  new AttributeItem("[Xb_TeacherResume2].[DianZanCount]", typeof(int), 4, default(int));
            
            /// <summary>有过哪些辅导或家教经验【小学、初、高中生或亲友小孩】（越详细越好123）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Experience =  new AttributeItem("[Xb_TeacherResume2].[Experience]", typeof(string), 2000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExperienceType =  new AttributeItem("[Xb_TeacherResume2].[ExperienceType]", typeof(string), 50, default(string));
            
            /// <summary>教学年限-新:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExperienceYear =  new AttributeItem("[Xb_TeacherResume2].[ExperienceYear]", typeof(string), 50, default(string));
            
            /// <summary>擅长的科目与高考成绩（英语、数学等），才艺与才艺等级（钢琴、画画几级）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Good =  new AttributeItem("[Xb_TeacherResume2].[Good]", typeof(string), 2000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GuanzhuCount =  new AttributeItem("[Xb_TeacherResume2].[GuanzhuCount]", typeof(int), 4, default(int));
            
            /// <summary>高中学校:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HighSchool =  new AttributeItem("[Xb_TeacherResume2].[HighSchool]", typeof(string), 100, default(string));
            
            /// <summary>家乡所在城市:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem HomeworkCity =  new AttributeItem("[Xb_TeacherResume2].[HomeworkCity]", typeof(string), 500, default(string));
            
            /// <summary>编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ID =  new AttributeItem("[Xb_TeacherResume2].[ID]", typeof(int), 4, default(int));
            
            /// <summary>随身照:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ImgPath =  new AttributeItem("[Xb_TeacherResume2].[ImgPath]", typeof(string), 200, default(string));
            
            /// <summary>奖学金和特长与竞赛名次:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem JiangXueJin =  new AttributeItem("[Xb_TeacherResume2].[JiangXueJin]", typeof(string), 1000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem LaiYuan =  new AttributeItem("[Xb_TeacherResume2].[LaiYuan]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem LiuLanQi =  new AttributeItem("[Xb_TeacherResume2].[LiuLanQi]", typeof(string), 200, default(string));
            
            /// <summary>面试评分1:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MianShiPingfen1 =  new AttributeItem("[Xb_TeacherResume2].[MianShiPingfen1]", typeof(string), 200, default(string));
            
            /// <summary>面试评分2:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MianShiPingfen2 =  new AttributeItem("[Xb_TeacherResume2].[MianShiPingfen2]", typeof(string), 200, default(string));
            
            /// <summary>面试评分3:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MianShiPingfen3 =  new AttributeItem("[Xb_TeacherResume2].[MianShiPingfen3]", typeof(string), 200, default(string));
            
            /// <summary>面试评价:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MianShiPingJia =  new AttributeItem("[Xb_TeacherResume2].[MianShiPingJia]", typeof(string), 200, default(string));
            
            /// <summary>自我介绍MyInfor:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem MyInfor =  new AttributeItem("[Xb_TeacherResume2].[MyInfor]", typeof(string), 2000, default(string));
            
            /// <summary>自我介绍语音MyVoice:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MyVoice =  new AttributeItem("[Xb_TeacherResume2].[MyVoice]", typeof(string), 200, default(string));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[Xb_TeacherResume2].[OpenId]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OS =  new AttributeItem("[Xb_TeacherResume2].[OS]", typeof(string), 200, default(string));
            
            /// <summary>电话号码:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PhoneNumber =  new AttributeItem("[Xb_TeacherResume2].[PhoneNumber]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PingLunCount =  new AttributeItem("[Xb_TeacherResume2].[PingLunCount]", typeof(int), 4, default(int));
            
            /// <summary>性别:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_TeacherResume2].[Sex]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShebeiPhone =  new AttributeItem("[Xb_TeacherResume2].[ShebeiPhone]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShebeiXiTong =  new AttributeItem("[Xb_TeacherResume2].[ShebeiXiTong]", typeof(string), 200, default(string));
            
            /// <summary>星级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StarLevel =  new AttributeItem("[Xb_TeacherResume2].[StarLevel]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tag =  new AttributeItem("[Xb_TeacherResume2].[Tag]", typeof(string), 200, default(string));
            
            /// <summary>学霸编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherCode =  new AttributeItem("[Xb_TeacherResume2].[TeacherCode]", typeof(string), 200, default(string));
            
            /// <summary>讲师姓名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherName =  new AttributeItem("[Xb_TeacherResume2].[TeacherName]", typeof(string), 50, default(string));
            
            /// <summary>意向工作区域（2个以上县市名及工作时间）如:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkCity =  new AttributeItem("[Xb_TeacherResume2].[WorkCity]", typeof(string), 500, default(string));
            
            /// <summary>家乡所在工作区域（城市和县区名）如:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkCityDetail =  new AttributeItem("[Xb_TeacherResume2].[WorkCityDetail]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WxCity =  new AttributeItem("[Xb_TeacherResume2].[WxCity]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WxHeadImage =  new AttributeItem("[Xb_TeacherResume2].[WxHeadImage]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WxNiChen =  new AttributeItem("[Xb_TeacherResume2].[WxNiChen]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WxSex =  new AttributeItem("[Xb_TeacherResume2].[WxSex]", typeof(string), 200, default(string));
            
            /// <summary>修改人:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem XiuGaiRen =  new AttributeItem("[Xb_TeacherResume2].[XiuGaiRen]", typeof(string), 200, default(string));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem XiuGaiTime =  new AttributeItem("[Xb_TeacherResume2].[XiuGaiTime]", typeof(string), 200, default(string));
            
            /// <summary>语音介绍:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YuYinJieshao =  new AttributeItem("[Xb_TeacherResume2].[YuYinJieshao]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_borndate;
        /// <summary></summary>
        protected bool borndate_initialized = false;
        
        private string m_classtimernext;
        /// <summary></summary>
        protected bool classtimernext_initialized = false;
        
        private bool m_classyuyuenext;
        /// <summary></summary>
        protected bool classyuyuenext_initialized = false;
        
        private string m_college;
        /// <summary></summary>
        protected bool college_initialized = false;
        
        private string m_createdate;
        /// <summary></summary>
        protected bool createdate_initialized = false;
        
        private string m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_dianzancount;
        /// <summary></summary>
        protected bool dianzancount_initialized = false;
        
        private string m_experience;
        /// <summary></summary>
        protected bool experience_initialized = false;
        
        private string m_experiencetype;
        /// <summary></summary>
        protected bool experiencetype_initialized = false;
        
        private string m_experienceyear;
        /// <summary></summary>
        protected bool experienceyear_initialized = false;
        
        private string m_good;
        /// <summary></summary>
        protected bool good_initialized = false;
        
        private int m_guanzhucount;
        /// <summary></summary>
        protected bool guanzhucount_initialized = false;
        
        private string m_highschool;
        /// <summary></summary>
        protected bool highschool_initialized = false;
        
        private string m_homeworkcity;
        /// <summary></summary>
        protected bool homeworkcity_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_imgpath;
        /// <summary></summary>
        protected bool imgpath_initialized = false;
        
        private string m_jiangxuejin;
        /// <summary></summary>
        protected bool jiangxuejin_initialized = false;
        
        private string m_laiyuan;
        /// <summary></summary>
        protected bool laiyuan_initialized = false;
        
        private string m_liulanqi;
        /// <summary></summary>
        protected bool liulanqi_initialized = false;
        
        private string m_mianshipingfen1;
        /// <summary></summary>
        protected bool mianshipingfen1_initialized = false;
        
        private string m_mianshipingfen2;
        /// <summary></summary>
        protected bool mianshipingfen2_initialized = false;
        
        private string m_mianshipingfen3;
        /// <summary></summary>
        protected bool mianshipingfen3_initialized = false;
        
        private string m_mianshipingjia;
        /// <summary></summary>
        protected bool mianshipingjia_initialized = false;
        
        private string m_myinfor;
        /// <summary></summary>
        protected bool myinfor_initialized = false;
        
        private string m_myvoice;
        /// <summary></summary>
        protected bool myvoice_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_os;
        /// <summary></summary>
        protected bool os_initialized = false;
        
        private string m_phonenumber;
        /// <summary></summary>
        protected bool phonenumber_initialized = false;
        
        private int m_pingluncount;
        /// <summary></summary>
        protected bool pingluncount_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_shebeiphone;
        /// <summary></summary>
        protected bool shebeiphone_initialized = false;
        
        private string m_shebeixitong;
        /// <summary></summary>
        protected bool shebeixitong_initialized = false;
        
        private string m_starlevel;
        /// <summary></summary>
        protected bool starlevel_initialized = false;
        
        private string m_tag;
        /// <summary></summary>
        protected bool tag_initialized = false;
        
        private string m_teachercode;
        /// <summary></summary>
        protected bool teachercode_initialized = false;
        
        private string m_teachername;
        /// <summary></summary>
        protected bool teachername_initialized = false;
        
        private string m_workcity;
        /// <summary></summary>
        protected bool workcity_initialized = false;
        
        private string m_workcitydetail;
        /// <summary></summary>
        protected bool workcitydetail_initialized = false;
        
        private string m_wxcity;
        /// <summary></summary>
        protected bool wxcity_initialized = false;
        
        private string m_wxheadimage;
        /// <summary></summary>
        protected bool wxheadimage_initialized = false;
        
        private string m_wxnichen;
        /// <summary></summary>
        protected bool wxnichen_initialized = false;
        
        private string m_wxsex;
        /// <summary></summary>
        protected bool wxsex_initialized = false;
        
        private string m_xiugairen;
        /// <summary></summary>
        protected bool xiugairen_initialized = false;
        
        private string m_xiugaitime;
        /// <summary></summary>
        protected bool xiugaitime_initialized = false;
        
        private string m_yuyinjieshao;
        /// <summary></summary>
        protected bool yuyinjieshao_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_TeacherResume2";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.borndate_initialized = IsLoadAllAttributes;this.classtimernext_initialized = IsLoadAllAttributes;this.classyuyuenext_initialized = IsLoadAllAttributes;this.college_initialized = IsLoadAllAttributes;this.createdate_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.dianzancount_initialized = IsLoadAllAttributes;this.experience_initialized = IsLoadAllAttributes;this.experiencetype_initialized = IsLoadAllAttributes;this.experienceyear_initialized = IsLoadAllAttributes;this.good_initialized = IsLoadAllAttributes;this.guanzhucount_initialized = IsLoadAllAttributes;this.highschool_initialized = IsLoadAllAttributes;this.homeworkcity_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.imgpath_initialized = IsLoadAllAttributes;this.jiangxuejin_initialized = IsLoadAllAttributes;this.laiyuan_initialized = IsLoadAllAttributes;this.liulanqi_initialized = IsLoadAllAttributes;this.mianshipingfen1_initialized = IsLoadAllAttributes;this.mianshipingfen2_initialized = IsLoadAllAttributes;this.mianshipingfen3_initialized = IsLoadAllAttributes;this.mianshipingjia_initialized = IsLoadAllAttributes;this.myinfor_initialized = IsLoadAllAttributes;this.myvoice_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.os_initialized = IsLoadAllAttributes;this.phonenumber_initialized = IsLoadAllAttributes;this.pingluncount_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.shebeiphone_initialized = IsLoadAllAttributes;this.shebeixitong_initialized = IsLoadAllAttributes;this.starlevel_initialized = IsLoadAllAttributes;this.tag_initialized = IsLoadAllAttributes;this.teachercode_initialized = IsLoadAllAttributes;this.teachername_initialized = IsLoadAllAttributes;this.workcity_initialized = IsLoadAllAttributes;this.workcitydetail_initialized = IsLoadAllAttributes;this.wxcity_initialized = IsLoadAllAttributes;this.wxheadimage_initialized = IsLoadAllAttributes;this.wxnichen_initialized = IsLoadAllAttributes;this.wxsex_initialized = IsLoadAllAttributes;this.xiugairen_initialized = IsLoadAllAttributes;this.xiugaitime_initialized = IsLoadAllAttributes;this.yuyinjieshao_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_TeacherResume2 value = new Xb_TeacherResume2();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"BornDate"))
				value.borndate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTimerNext"))
				value.classtimernext_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassYuyueNext"))
				value.classyuyuenext_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College"))
				value.college_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateDate"))
				value.createdate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DianZanCount"))
				value.dianzancount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Experience"))
				value.experience_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExperienceType"))
				value.experiencetype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExperienceYear"))
				value.experienceyear_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Good"))
				value.good_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GuanzhuCount"))
				value.guanzhucount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HighSchool"))
				value.highschool_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HomeworkCity"))
				value.homeworkcity_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ImgPath"))
				value.imgpath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JiangXueJin"))
				value.jiangxuejin_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"LaiYuan"))
				value.laiyuan_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"LiuLanQi"))
				value.liulanqi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MianShiPingfen1"))
				value.mianshipingfen1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MianShiPingfen2"))
				value.mianshipingfen2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MianShiPingfen3"))
				value.mianshipingfen3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MianShiPingJia"))
				value.mianshipingjia_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MyInfor"))
				value.myinfor_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MyVoice"))
				value.myvoice_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OS"))
				value.os_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PhoneNumber"))
				value.phonenumber_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PingLunCount"))
				value.pingluncount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShebeiPhone"))
				value.shebeiphone_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShebeiXiTong"))
				value.shebeixitong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StarLevel"))
				value.starlevel_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tag"))
				value.tag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherCode"))
				value.teachercode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherName"))
				value.teachername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkCity"))
				value.workcity_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkCityDetail"))
				value.workcitydetail_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WxCity"))
				value.wxcity_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WxHeadImage"))
				value.wxheadimage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WxNiChen"))
				value.wxnichen_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WxSex"))
				value.wxsex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"XiuGaiRen"))
				value.xiugairen_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"XiuGaiTime"))
				value.xiugaitime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YuYinJieshao"))
				value.yuyinjieshao_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_TeacherResume2 Clone()
        {
            return (Xb_TeacherResume2)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_TeacherResume2()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_TeacherResume2() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_TeacherResume2(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_TeacherResume2(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_TeacherResume2(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_TeacherResume2(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_TeacherResume2(string borndate1, string classtimernext1, bool classyuyuenext1, string college1, string createdate1, string createtime1, int dianzancount1, string experience1, string experiencetype1, string experienceyear1, string good1, int guanzhucount1, string highschool1, string homeworkcity1, int id1, string imgpath1, string jiangxuejin1, string laiyuan1, string liulanqi1, string mianshipingfen11, string mianshipingfen21, string mianshipingfen31, string mianshipingjia1, string myinfor1, string myvoice1, string openid1, string os1, string phonenumber1, int pingluncount1, string sex1, string shebeiphone1, string shebeixitong1, string starlevel1, string tag1, string teachercode1, string teachername1, string workcity1, string workcitydetail1, string wxcity1, string wxheadimage1, string wxnichen1, string wxsex1, string xiugairen1, string xiugaitime1, string yuyinjieshao1)
        {
            
            this.BornDate = borndate1;
            
            this.ClassTimerNext = classtimernext1;
            
            this.ClassYuyueNext = classyuyuenext1;
            
            this.College = college1;
            
            this.CreateDate = createdate1;
            
            this.CreateTime = createtime1;
            
            this.DianZanCount = dianzancount1;
            
            this.Experience = experience1;
            
            this.ExperienceType = experiencetype1;
            
            this.ExperienceYear = experienceyear1;
            
            this.Good = good1;
            
            this.GuanzhuCount = guanzhucount1;
            
            this.HighSchool = highschool1;
            
            this.HomeworkCity = homeworkcity1;
            
            this.ID = id1;
            
            this.ImgPath = imgpath1;
            
            this.JiangXueJin = jiangxuejin1;
            
            this.LaiYuan = laiyuan1;
            
            this.LiuLanQi = liulanqi1;
            
            this.MianShiPingfen1 = mianshipingfen11;
            
            this.MianShiPingfen2 = mianshipingfen21;
            
            this.MianShiPingfen3 = mianshipingfen31;
            
            this.MianShiPingJia = mianshipingjia1;
            
            this.MyInfor = myinfor1;
            
            this.MyVoice = myvoice1;
            
            this.OpenId = openid1;
            
            this.OS = os1;
            
            this.PhoneNumber = phonenumber1;
            
            this.PingLunCount = pingluncount1;
            
            this.Sex = sex1;
            
            this.ShebeiPhone = shebeiphone1;
            
            this.ShebeiXiTong = shebeixitong1;
            
            this.StarLevel = starlevel1;
            
            this.Tag = tag1;
            
            this.TeacherCode = teachercode1;
            
            this.TeacherName = teachername1;
            
            this.WorkCity = workcity1;
            
            this.WorkCityDetail = workcitydetail1;
            
            this.WxCity = wxcity1;
            
            this.WxHeadImage = wxheadimage1;
            
            this.WxNiChen = wxnichen1;
            
            this.WxSex = wxsex1;
            
            this.XiuGaiRen = xiugairen1;
            
            this.XiuGaiTime = xiugaitime1;
            
            this.YuYinJieshao = yuyinjieshao1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_TeacherResume2 FromIView(IView view)
        {
            return (Xb_TeacherResume2)IView.GetITable(view, "Xb_TeacherResume2");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_TeacherResume2 GetOneInstance()
        {
            Xb_TeacherResume2 value = new Xb_TeacherResume2();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_TeacherResume2 Retrieve()
        {
            BLLTable<Xb_TeacherResume2>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "BornDate":
			        return BornDate;
			    			
			    case "ClassTimerNext":
			        return ClassTimerNext;
			    			
			    case "ClassYuyueNext":
			        return ClassYuyueNext;
			    			
			    case "College":
			        return College;
			    			
			    case "CreateDate":
			        return CreateDate;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "DianZanCount":
			        return DianZanCount;
			    			
			    case "Experience":
			        return Experience;
			    			
			    case "ExperienceType":
			        return ExperienceType;
			    			
			    case "ExperienceYear":
			        return ExperienceYear;
			    			
			    case "Good":
			        return Good;
			    			
			    case "GuanzhuCount":
			        return GuanzhuCount;
			    			
			    case "HighSchool":
			        return HighSchool;
			    			
			    case "HomeworkCity":
			        return HomeworkCity;
			    			
			    case "ID":
			        return ID;
			    			
			    case "ImgPath":
			        return ImgPath;
			    			
			    case "JiangXueJin":
			        return JiangXueJin;
			    			
			    case "LaiYuan":
			        return LaiYuan;
			    			
			    case "LiuLanQi":
			        return LiuLanQi;
			    			
			    case "MianShiPingfen1":
			        return MianShiPingfen1;
			    			
			    case "MianShiPingfen2":
			        return MianShiPingfen2;
			    			
			    case "MianShiPingfen3":
			        return MianShiPingfen3;
			    			
			    case "MianShiPingJia":
			        return MianShiPingJia;
			    			
			    case "MyInfor":
			        return MyInfor;
			    			
			    case "MyVoice":
			        return MyVoice;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "OS":
			        return OS;
			    			
			    case "PhoneNumber":
			        return PhoneNumber;
			    			
			    case "PingLunCount":
			        return PingLunCount;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "ShebeiPhone":
			        return ShebeiPhone;
			    			
			    case "ShebeiXiTong":
			        return ShebeiXiTong;
			    			
			    case "StarLevel":
			        return StarLevel;
			    			
			    case "Tag":
			        return Tag;
			    			
			    case "TeacherCode":
			        return TeacherCode;
			    			
			    case "TeacherName":
			        return TeacherName;
			    			
			    case "WorkCity":
			        return WorkCity;
			    			
			    case "WorkCityDetail":
			        return WorkCityDetail;
			    			
			    case "WxCity":
			        return WxCity;
			    			
			    case "WxHeadImage":
			        return WxHeadImage;
			    			
			    case "WxNiChen":
			        return WxNiChen;
			    			
			    case "WxSex":
			        return WxSex;
			    			
			    case "XiuGaiRen":
			        return XiuGaiRen;
			    			
			    case "XiuGaiTime":
			        return XiuGaiTime;
			    			
			    case "YuYinJieshao":
			        return YuYinJieshao;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "BornDate":
			        this.BornDate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassTimerNext":
			        this.ClassTimerNext = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassYuyueNext":
			        this.ClassYuyueNext = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "College":
			        this.College = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateDate":
			        this.CreateDate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DianZanCount":
			        this.DianZanCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Experience":
			        this.Experience = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExperienceType":
			        this.ExperienceType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExperienceYear":
			        this.ExperienceYear = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Good":
			        this.Good = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GuanzhuCount":
			        this.GuanzhuCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "HighSchool":
			        this.HighSchool = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HomeworkCity":
			        this.HomeworkCity = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ImgPath":
			        this.ImgPath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "JiangXueJin":
			        this.JiangXueJin = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "LaiYuan":
			        this.LaiYuan = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "LiuLanQi":
			        this.LiuLanQi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MianShiPingfen1":
			        this.MianShiPingfen1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MianShiPingfen2":
			        this.MianShiPingfen2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MianShiPingfen3":
			        this.MianShiPingfen3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MianShiPingJia":
			        this.MianShiPingJia = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MyInfor":
			        this.MyInfor = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MyVoice":
			        this.MyVoice = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OS":
			        this.OS = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PhoneNumber":
			        this.PhoneNumber = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PingLunCount":
			        this.PingLunCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShebeiPhone":
			        this.ShebeiPhone = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShebeiXiTong":
			        this.ShebeiXiTong = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StarLevel":
			        this.StarLevel = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tag":
			        this.Tag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherCode":
			        this.TeacherCode = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherName":
			        this.TeacherName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WorkCity":
			        this.WorkCity = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WorkCityDetail":
			        this.WorkCityDetail = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WxCity":
			        this.WxCity = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WxHeadImage":
			        this.WxHeadImage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WxNiChen":
			        this.WxNiChen = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WxSex":
			        this.WxSex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "XiuGaiRen":
			        this.XiuGaiRen = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "XiuGaiTime":
			        this.XiuGaiTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YuYinJieshao":
			        this.YuYinJieshao = Convert.ToString(AttributeValue);
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
				case "BornDate":
					return borndate_initialized;
				
				case "ClassTimerNext":
					return classtimernext_initialized;
				
				case "ClassYuyueNext":
					return classyuyuenext_initialized;
				
				case "College":
					return college_initialized;
				
				case "CreateDate":
					return createdate_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "DianZanCount":
					return dianzancount_initialized;
				
				case "Experience":
					return experience_initialized;
				
				case "ExperienceType":
					return experiencetype_initialized;
				
				case "ExperienceYear":
					return experienceyear_initialized;
				
				case "Good":
					return good_initialized;
				
				case "GuanzhuCount":
					return guanzhucount_initialized;
				
				case "HighSchool":
					return highschool_initialized;
				
				case "HomeworkCity":
					return homeworkcity_initialized;
				
				case "ID":
					return id_initialized;
				
				case "ImgPath":
					return imgpath_initialized;
				
				case "JiangXueJin":
					return jiangxuejin_initialized;
				
				case "LaiYuan":
					return laiyuan_initialized;
				
				case "LiuLanQi":
					return liulanqi_initialized;
				
				case "MianShiPingfen1":
					return mianshipingfen1_initialized;
				
				case "MianShiPingfen2":
					return mianshipingfen2_initialized;
				
				case "MianShiPingfen3":
					return mianshipingfen3_initialized;
				
				case "MianShiPingJia":
					return mianshipingjia_initialized;
				
				case "MyInfor":
					return myinfor_initialized;
				
				case "MyVoice":
					return myvoice_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "OS":
					return os_initialized;
				
				case "PhoneNumber":
					return phonenumber_initialized;
				
				case "PingLunCount":
					return pingluncount_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "ShebeiPhone":
					return shebeiphone_initialized;
				
				case "ShebeiXiTong":
					return shebeixitong_initialized;
				
				case "StarLevel":
					return starlevel_initialized;
				
				case "Tag":
					return tag_initialized;
				
				case "TeacherCode":
					return teachercode_initialized;
				
				case "TeacherName":
					return teachername_initialized;
				
				case "WorkCity":
					return workcity_initialized;
				
				case "WorkCityDetail":
					return workcitydetail_initialized;
				
				case "WxCity":
					return wxcity_initialized;
				
				case "WxHeadImage":
					return wxheadimage_initialized;
				
				case "WxNiChen":
					return wxnichen_initialized;
				
				case "WxSex":
					return wxsex_initialized;
				
				case "XiuGaiRen":
					return xiugairen_initialized;
				
				case "XiuGaiTime":
					return xiugaitime_initialized;
				
				case "YuYinJieshao":
					return yuyinjieshao_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "BornDate":
					borndate_initialized = ret;
					return true;
				
				case "ClassTimerNext":
					classtimernext_initialized = ret;
					return true;
				
				case "ClassYuyueNext":
					classyuyuenext_initialized = ret;
					return true;
				
				case "College":
					college_initialized = ret;
					return true;
				
				case "CreateDate":
					createdate_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "DianZanCount":
					dianzancount_initialized = ret;
					return true;
				
				case "Experience":
					experience_initialized = ret;
					return true;
				
				case "ExperienceType":
					experiencetype_initialized = ret;
					return true;
				
				case "ExperienceYear":
					experienceyear_initialized = ret;
					return true;
				
				case "Good":
					good_initialized = ret;
					return true;
				
				case "GuanzhuCount":
					guanzhucount_initialized = ret;
					return true;
				
				case "HighSchool":
					highschool_initialized = ret;
					return true;
				
				case "HomeworkCity":
					homeworkcity_initialized = ret;
					return true;
				
				case "ID":
					id_initialized = ret;
					return true;
				
				case "ImgPath":
					imgpath_initialized = ret;
					return true;
				
				case "JiangXueJin":
					jiangxuejin_initialized = ret;
					return true;
				
				case "LaiYuan":
					laiyuan_initialized = ret;
					return true;
				
				case "LiuLanQi":
					liulanqi_initialized = ret;
					return true;
				
				case "MianShiPingfen1":
					mianshipingfen1_initialized = ret;
					return true;
				
				case "MianShiPingfen2":
					mianshipingfen2_initialized = ret;
					return true;
				
				case "MianShiPingfen3":
					mianshipingfen3_initialized = ret;
					return true;
				
				case "MianShiPingJia":
					mianshipingjia_initialized = ret;
					return true;
				
				case "MyInfor":
					myinfor_initialized = ret;
					return true;
				
				case "MyVoice":
					myvoice_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "OS":
					os_initialized = ret;
					return true;
				
				case "PhoneNumber":
					phonenumber_initialized = ret;
					return true;
				
				case "PingLunCount":
					pingluncount_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "ShebeiPhone":
					shebeiphone_initialized = ret;
					return true;
				
				case "ShebeiXiTong":
					shebeixitong_initialized = ret;
					return true;
				
				case "StarLevel":
					starlevel_initialized = ret;
					return true;
				
				case "Tag":
					tag_initialized = ret;
					return true;
				
				case "TeacherCode":
					teachercode_initialized = ret;
					return true;
				
				case "TeacherName":
					teachername_initialized = ret;
					return true;
				
				case "WorkCity":
					workcity_initialized = ret;
					return true;
				
				case "WorkCityDetail":
					workcitydetail_initialized = ret;
					return true;
				
				case "WxCity":
					wxcity_initialized = ret;
					return true;
				
				case "WxHeadImage":
					wxheadimage_initialized = ret;
					return true;
				
				case "WxNiChen":
					wxnichen_initialized = ret;
					return true;
				
				case "WxSex":
					wxsex_initialized = ret;
					return true;
				
				case "XiuGaiRen":
					xiugairen_initialized = ret;
					return true;
				
				case "XiuGaiTime":
					xiugaitime_initialized = ret;
					return true;
				
				case "YuYinJieshao":
					yuyinjieshao_initialized = ret;
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

			
			if (borndate_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.BornDate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BornDate);
                }
			}
			
			if (classtimernext_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ClassTimerNext;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTimerNext);
                }
			}
			
			if (classyuyuenext_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ClassYuyueNext;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassYuyueNext);
                }
			}
			
			if (college_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.College;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College);
                }
			}
			
			if (createdate_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.CreateDate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateDate);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (dianzancount_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.DianZanCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DianZanCount);
                }
			}
			
			if (experience_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.Experience;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Experience);
                }
			}
			
			if (experiencetype_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ExperienceType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExperienceType);
                }
			}
			
			if (experienceyear_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ExperienceYear;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExperienceYear);
                }
			}
			
			if (good_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.Good;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Good);
                }
			}
			
			if (guanzhucount_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.GuanzhuCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GuanzhuCount);
                }
			}
			
			if (highschool_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.HighSchool;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HighSchool);
                }
			}
			
			if (homeworkcity_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.HomeworkCity;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HomeworkCity);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (imgpath_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ImgPath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ImgPath);
                }
			}
			
			if (jiangxuejin_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.JiangXueJin;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JiangXueJin);
                }
			}
			
			if (laiyuan_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.LaiYuan;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(LaiYuan);
                }
			}
			
			if (liulanqi_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.LiuLanQi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(LiuLanQi);
                }
			}
			
			if (mianshipingfen1_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MianShiPingfen1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MianShiPingfen1);
                }
			}
			
			if (mianshipingfen2_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MianShiPingfen2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MianShiPingfen2);
                }
			}
			
			if (mianshipingfen3_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MianShiPingfen3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MianShiPingfen3);
                }
			}
			
			if (mianshipingjia_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MianShiPingJia;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MianShiPingJia);
                }
			}
			
			if (myinfor_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MyInfor;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MyInfor);
                }
			}
			
			if (myvoice_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.MyVoice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MyVoice);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (os_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.OS;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OS);
                }
			}
			
			if (phonenumber_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.PhoneNumber;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PhoneNumber);
                }
			}
			
			if (pingluncount_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.PingLunCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PingLunCount);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (shebeiphone_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ShebeiPhone;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShebeiPhone);
                }
			}
			
			if (shebeixitong_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.ShebeiXiTong;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShebeiXiTong);
                }
			}
			
			if (starlevel_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.StarLevel;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StarLevel);
                }
			}
			
			if (tag_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.Tag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tag);
                }
			}
			
			if (teachercode_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.TeacherCode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherCode);
                }
			}
			
			if (teachername_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.TeacherName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherName);
                }
			}
			
			if (workcity_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WorkCity;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkCity);
                }
			}
			
			if (workcitydetail_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WorkCityDetail;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkCityDetail);
                }
			}
			
			if (wxcity_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WxCity;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WxCity);
                }
			}
			
			if (wxheadimage_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WxHeadImage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WxHeadImage);
                }
			}
			
			if (wxnichen_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WxNiChen;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WxNiChen);
                }
			}
			
			if (wxsex_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.WxSex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WxSex);
                }
			}
			
			if (xiugairen_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.XiuGaiRen;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(XiuGaiRen);
                }
			}
			
			if (xiugaitime_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.XiuGaiTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(XiuGaiTime);
                }
			}
			
			if (yuyinjieshao_initialized)
			{
                AttributeItem attr = Xb_TeacherResume2.Attribute.YuYinJieshao;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YuYinJieshao);
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
        public class Xb_TeacherResume2Json
        {
            
            /// <summary>出生年月:[CtrlTypeDic-{InputString}]</summary>
            public string BornDate { get; set; }
            
            /// <summary>最近课程时间:[CtrlTypeDic-{InputString}]</summary>
            public string ClassTimerNext { get; set; }
            
            /// <summary>最近是否被预约:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool ClassYuyueNext { get; set; }
            
            /// <summary>大学学校:[CtrlTypeDic-{InputString}]</summary>
            public string College { get; set; }
            
            /// <summary>评论时间:[CtrlTypeDic-{InputString}]</summary>
            public string CreateDate { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputString}]</summary>
            public string CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int DianZanCount { get; set; }
            
            /// <summary>有过哪些辅导或家教经验【小学、初、高中生或亲友小孩】（越详细越好123）:[CtrlTypeDic-{InputString}]</summary>
            public string Experience { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ExperienceType { get; set; }
            
            /// <summary>教学年限-新:[CtrlTypeDic-{InputString}]</summary>
            public string ExperienceYear { get; set; }
            
            /// <summary>擅长的科目与高考成绩（英语、数学等），才艺与才艺等级（钢琴、画画几级）:[CtrlTypeDic-{InputString}]</summary>
            public string Good { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int GuanzhuCount { get; set; }
            
            /// <summary>高中学校:[CtrlTypeDic-{InputString}]</summary>
            public string HighSchool { get; set; }
            
            /// <summary>家乡所在城市:[CtrlTypeDic-{Text}]</summary>
            public string HomeworkCity { get; set; }
            
            /// <summary>编号:[CtrlTypeDic-{InputString}]</summary>
            public int ID { get; set; }
            
            /// <summary>随身照:[CtrlTypeDic-{InputString}]</summary>
            public string ImgPath { get; set; }
            
            /// <summary>奖学金和特长与竞赛名次:[CtrlTypeDic-{InputString}]</summary>
            public string JiangXueJin { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string LaiYuan { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string LiuLanQi { get; set; }
            
            /// <summary>面试评分1:[CtrlTypeDic-{InputString}]</summary>
            public string MianShiPingfen1 { get; set; }
            
            /// <summary>面试评分2:[CtrlTypeDic-{InputString}]</summary>
            public string MianShiPingfen2 { get; set; }
            
            /// <summary>面试评分3:[CtrlTypeDic-{InputString}]</summary>
            public string MianShiPingfen3 { get; set; }
            
            /// <summary>面试评价:[CtrlTypeDic-{InputString}]</summary>
            public string MianShiPingJia { get; set; }
            
            /// <summary>自我介绍MyInfor:[CtrlTypeDic-{HTML}]</summary>
            public string MyInfor { get; set; }
            
            /// <summary>自我介绍语音MyVoice:[CtrlTypeDic-{InputString}]</summary>
            public string MyVoice { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string OS { get; set; }
            
            /// <summary>电话号码:[CtrlTypeDic-{InputString}]</summary>
            public string PhoneNumber { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PingLunCount { get; set; }
            
            /// <summary>性别:[CtrlTypeDic-{InputString}]</summary>
            public string Sex { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ShebeiPhone { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ShebeiXiTong { get; set; }
            
            /// <summary>星级:[CtrlTypeDic-{InputString}]</summary>
            public string StarLevel { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Tag { get; set; }
            
            /// <summary>学霸编号:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherCode { get; set; }
            
            /// <summary>讲师姓名:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherName { get; set; }
            
            /// <summary>意向工作区域（2个以上县市名及工作时间）如:[CtrlTypeDic-{InputString}]</summary>
            public string WorkCity { get; set; }
            
            /// <summary>家乡所在工作区域（城市和县区名）如:[CtrlTypeDic-{InputString}]</summary>
            public string WorkCityDetail { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WxCity { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WxHeadImage { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WxNiChen { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WxSex { get; set; }
            
            /// <summary>修改人:[CtrlTypeDic-{InputString}]</summary>
            public string XiuGaiRen { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputString}]</summary>
            public string XiuGaiTime { get; set; }
            
            /// <summary>语音介绍:[CtrlTypeDic-{InputString}]</summary>
            public string YuYinJieshao { get; set; }
        }
        #endregion
    }
}