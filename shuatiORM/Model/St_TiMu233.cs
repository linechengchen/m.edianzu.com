/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    数据表St_TiMu233对应的业务逻辑层St_TiMu233
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TiMu233_Entity:St_TiMu233
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Analysis,Answer,Answer123,AnswerABC,AnswerDiscussCount,ClassId,ClassName,Content,DeNums,DiggDown,DiggUp,DiscussCount,ExamDiscussCount,ExamId,ExamNewStats,ExamType,ExpanddoExamNum,ExpandPercent,FavInfo,FavNum,IsFavorites,IsRepeatTf,KemuId,Knowledge,LinkExam,Md5,MyDiscussCount,NewestNote,OptionList,OrderId,PaperId,PaperInfo,PaperName,PaperShortName,Question,QuestionCount,RightOrWrong,RulesId,SelectNum,SubQuestion,Teacher,Type1,TypeIdUrl,Url,UserDeNum,UserDeNumStats,VedioDiscussCount,Weight,YearId from St_TiMu233
delete from St_TiMu233
INSERT INTO St_TiMu233 (Id,Analysis,Answer,Answer123,AnswerABC,AnswerDiscussCount,ClassId,ClassName,Content,DeNums,DiggDown,DiggUp,DiscussCount,ExamDiscussCount,ExamId,ExamNewStats,ExamType,ExpanddoExamNum,ExpandPercent,FavInfo,FavNum,IsFavorites,IsRepeatTf,KemuId,Knowledge,LinkExam,Md5,MyDiscussCount,NewestNote,OptionList,OrderId,PaperId,PaperInfo,PaperName,PaperShortName,Question,QuestionCount,RightOrWrong,RulesId,SelectNum,SubQuestion,Teacher,Type1,TypeIdUrl,Url,UserDeNum,UserDeNumStats,VedioDiscussCount,Weight,YearId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE St_TiMu233 SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Analysis = valObj2.Analysis;
        valObj.Answer = valObj2.Answer;
        valObj.Answer123 = valObj2.Answer123;
        valObj.AnswerABC = valObj2.AnswerABC;
        valObj.AnswerDiscussCount = valObj2.AnswerDiscussCount;
        valObj.ClassId = valObj2.ClassId;
        valObj.ClassName = valObj2.ClassName;
        valObj.Content = valObj2.Content;
        valObj.DeNums = valObj2.DeNums;
        valObj.DiggDown = valObj2.DiggDown;
        valObj.DiggUp = valObj2.DiggUp;
        valObj.DiscussCount = valObj2.DiscussCount;
        valObj.ExamDiscussCount = valObj2.ExamDiscussCount;
        valObj.ExamId = valObj2.ExamId;
        valObj.ExamNewStats = valObj2.ExamNewStats;
        valObj.ExamType = valObj2.ExamType;
        valObj.ExpanddoExamNum = valObj2.ExpanddoExamNum;
        valObj.ExpandPercent = valObj2.ExpandPercent;
        valObj.FavInfo = valObj2.FavInfo;
        valObj.FavNum = valObj2.FavNum;
        valObj.IsFavorites = valObj2.IsFavorites;
        valObj.IsRepeatTf = valObj2.IsRepeatTf;
        valObj.KemuId = valObj2.KemuId;
        valObj.Knowledge = valObj2.Knowledge;
        valObj.LinkExam = valObj2.LinkExam;
        valObj.Md5 = valObj2.Md5;
        valObj.MyDiscussCount = valObj2.MyDiscussCount;
        valObj.NewestNote = valObj2.NewestNote;
        valObj.OptionList = valObj2.OptionList;
        valObj.OrderId = valObj2.OrderId;
        valObj.PaperId = valObj2.PaperId;
        valObj.PaperInfo = valObj2.PaperInfo;
        valObj.PaperName = valObj2.PaperName;
        valObj.PaperShortName = valObj2.PaperShortName;
        valObj.Question = valObj2.Question;
        valObj.QuestionCount = valObj2.QuestionCount;
        valObj.RightOrWrong = valObj2.RightOrWrong;
        valObj.RulesId = valObj2.RulesId;
        valObj.SelectNum = valObj2.SelectNum;
        valObj.SubQuestion = valObj2.SubQuestion;
        valObj.Teacher = valObj2.Teacher;
        valObj.Type1 = valObj2.Type1;
        valObj.TypeIdUrl = valObj2.TypeIdUrl;
        valObj.Url = valObj2.Url;
        valObj.UserDeNum = valObj2.UserDeNum;
        valObj.UserDeNumStats = valObj2.UserDeNumStats;
        valObj.VedioDiscussCount = valObj2.VedioDiscussCount;
        valObj.Weight = valObj2.Weight;
        valObj.YearId = valObj2.YearId; 
        valObj.Id = "";
        valObj.Analysis = "";
        valObj.Answer = "";
        valObj.Answer123 = "";
        valObj.AnswerABC = "";
        valObj.AnswerDiscussCount = "";
        valObj.ClassId = "";
        valObj.ClassName = "";
        valObj.Content = "";
        valObj.DeNums = "";
        valObj.DiggDown = "";
        valObj.DiggUp = "";
        valObj.DiscussCount = "";
        valObj.ExamDiscussCount = "";
        valObj.ExamId = "";
        valObj.ExamNewStats = "";
        valObj.ExamType = "";
        valObj.ExpanddoExamNum = "";
        valObj.ExpandPercent = "";
        valObj.FavInfo = "";
        valObj.FavNum = "";
        valObj.IsFavorites = "";
        valObj.IsRepeatTf = "";
        valObj.KemuId = "";
        valObj.Knowledge = "";
        valObj.LinkExam = "";
        valObj.Md5 = "";
        valObj.MyDiscussCount = "";
        valObj.NewestNote = "";
        valObj.OptionList = "";
        valObj.OrderId = "";
        valObj.PaperId = "";
        valObj.PaperInfo = "";
        valObj.PaperName = "";
        valObj.PaperShortName = "";
        valObj.Question = "";
        valObj.QuestionCount = "";
        valObj.RightOrWrong = "";
        valObj.RulesId = "";
        valObj.SelectNum = "";
        valObj.SubQuestion = "";
        valObj.Teacher = "";
        valObj.Type1 = "";
        valObj.TypeIdUrl = "";
        valObj.Url = "";
        valObj.UserDeNum = "";
        valObj.UserDeNumStats = "";
        valObj.VedioDiscussCount = "";
        valObj.Weight = "";
        valObj.YearId = ""; 
        "Id": $("#txt_Id").val(),
        "Analysis": $("#txt_Analysis").val(),
        "Answer": $("#txt_Answer").val(),
        "Answer123": $("#txt_Answer123").val(),
        "AnswerABC": $("#txt_AnswerABC").val(),
        "AnswerDiscussCount": $("#txt_AnswerDiscussCount").val(),
        "ClassId": $("#txt_ClassId").val(),
        "ClassName": $("#txt_ClassName").val(),
        "Content": $("#txt_Content").val(),
        "DeNums": $("#txt_DeNums").val(),
        "DiggDown": $("#txt_DiggDown").val(),
        "DiggUp": $("#txt_DiggUp").val(),
        "DiscussCount": $("#txt_DiscussCount").val(),
        "ExamDiscussCount": $("#txt_ExamDiscussCount").val(),
        "ExamId": $("#txt_ExamId").val(),
        "ExamNewStats": $("#txt_ExamNewStats").val(),
        "ExamType": $("#txt_ExamType").val(),
        "ExpanddoExamNum": $("#txt_ExpanddoExamNum").val(),
        "ExpandPercent": $("#txt_ExpandPercent").val(),
        "FavInfo": $("#txt_FavInfo").val(),
        "FavNum": $("#txt_FavNum").val(),
        "IsFavorites": $("#txt_IsFavorites").val(),
        "IsRepeatTf": $("#txt_IsRepeatTf").val(),
        "KemuId": $("#txt_KemuId").val(),
        "Knowledge": $("#txt_Knowledge").val(),
        "LinkExam": $("#txt_LinkExam").val(),
        "Md5": $("#txt_Md5").val(),
        "MyDiscussCount": $("#txt_MyDiscussCount").val(),
        "NewestNote": $("#txt_NewestNote").val(),
        "OptionList": $("#txt_OptionList").val(),
        "OrderId": $("#txt_OrderId").val(),
        "PaperId": $("#txt_PaperId").val(),
        "PaperInfo": $("#txt_PaperInfo").val(),
        "PaperName": $("#txt_PaperName").val(),
        "PaperShortName": $("#txt_PaperShortName").val(),
        "Question": $("#txt_Question").val(),
        "QuestionCount": $("#txt_QuestionCount").val(),
        "RightOrWrong": $("#txt_RightOrWrong").val(),
        "RulesId": $("#txt_RulesId").val(),
        "SelectNum": $("#txt_SelectNum").val(),
        "SubQuestion": $("#txt_SubQuestion").val(),
        "Teacher": $("#txt_Teacher").val(),
        "Type1": $("#txt_Type1").val(),
        "TypeIdUrl": $("#txt_TypeIdUrl").val(),
        "Url": $("#txt_Url").val(),
        "UserDeNum": $("#txt_UserDeNum").val(),
        "UserDeNumStats": $("#txt_UserDeNumStats").val(),
        "VedioDiscussCount": $("#txt_VedioDiscussCount").val(),
        "Weight": $("#txt_Weight").val(),
        "YearId": $("#txt_YearId").val(), 
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
    /// <para>233题库:[IDField-{Id:0}]</para>
    /// <para>与St_TiMu233数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TiMu233 : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TiMu233 Factory()
        {
            return new St_TiMu233();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动编号:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 答案解析:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Analysis
        {            
            get { return this.Analysis; }
            set { this.Analysis = value; }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer
        {            
            get { return this.Answer; }
            set { this.Answer = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer123
        {            
            get { return this.Answer123; }
            set { this.Answer123 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AnswerABC
        {            
            get { return this.AnswerABC; }
            set { this.AnswerABC = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AnswerDiscussCount
        {            
            get { return this.AnswerDiscussCount; }
            set { this.AnswerDiscussCount = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassId
        {            
            get { return this.ClassId; }
            set { this.ClassId = value; }
        }
        
        /// <summary> 科目名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassName
        {            
            get { return this.ClassName; }
            set { this.ClassName = value; }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DeNums
        {            
            get { return this.DeNums; }
            set { this.DeNums = value; }
        }
        
        /// <summary> 差评次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggDown
        {            
            get { return this.DiggDown; }
            set { this.DiggDown = value; }
        }
        
        /// <summary> 好评次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggUp
        {            
            get { return this.DiggUp; }
            set { this.DiggUp = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiscussCount
        {            
            get { return this.DiscussCount; }
            set { this.DiscussCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamDiscussCount
        {            
            get { return this.ExamDiscussCount; }
            set { this.ExamDiscussCount = value; }
        }
        
        /// <summary> 题目ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamId
        {            
            get { return this.ExamId; }
            set { this.ExamId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamNewStats
        {            
            get { return this.ExamNewStats; }
            set { this.ExamNewStats = value; }
        }
        
        /// <summary> 试卷类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamType
        {            
            get { return this.ExamType; }
            set { this.ExamType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExpanddoExamNum
        {            
            get { return this.ExpanddoExamNum; }
            set { this.ExpanddoExamNum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExpandPercent
        {            
            get { return this.ExpandPercent; }
            set { this.ExpandPercent = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _FavInfo
        {            
            get { return this.FavInfo; }
            set { this.FavInfo = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _FavNum
        {            
            get { return this.FavNum; }
            set { this.FavNum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsFavorites
        {            
            get { return this.IsFavorites; }
            set { this.IsFavorites = value; }
        }
        
        /// <summary> 是否做过（0是1否）:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsRepeatTf
        {            
            get { return this.IsRepeatTf; }
            set { this.IsRepeatTf = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge
        {            
            get { return this.Knowledge; }
            set { this.Knowledge = value; }
        }
        
        /// <summary> 对应大题题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _LinkExam
        {            
            get { return this.LinkExam; }
            set { this.LinkExam = value; }
        }
        
        /// <summary> Md5加密:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Md5
        {            
            get { return this.Md5; }
            set { this.Md5 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MyDiscussCount
        {            
            get { return this.MyDiscussCount; }
            set { this.MyDiscussCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NewestNote
        {            
            get { return this.NewestNote; }
            set { this.NewestNote = value; }
        }
        
        /// <summary> 选项列表:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _OptionList
        {            
            get { return this.OptionList; }
            set { this.OptionList = value; }
        }
        
        /// <summary> 试卷题号-顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OrderId
        {            
            get { return this.OrderId; }
            set { this.OrderId = value; }
        }
        
        /// <summary> 试卷Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperId
        {            
            get { return this.PaperId; }
            set { this.PaperId = value; }
        }
        
        /// <summary> 试卷编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperInfo
        {            
            get { return this.PaperInfo; }
            set { this.PaperInfo = value; }
        }
        
        /// <summary> 试卷名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperName
        {            
            get { return this.PaperName; }
            set { this.PaperName = value; }
        }
        
        /// <summary> 试卷简称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperShortName
        {            
            get { return this.PaperShortName; }
            set { this.PaperShortName = value; }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Question
        {            
            get { return this.Question; }
            set { this.Question = value; }
        }
        
        /// <summary> 题目总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QuestionCount
        {            
            get { return this.QuestionCount; }
            set { this.QuestionCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RightOrWrong
        {            
            get { return this.RightOrWrong; }
            set { this.RightOrWrong = value; }
        }
        
        /// <summary> 规则ID(同一类型题目):[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RulesId
        {            
            get { return this.RulesId; }
            set { this.RulesId = value; }
        }
        
        /// <summary> 选项个数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SelectNum
        {            
            get { return this.SelectNum; }
            set { this.SelectNum = value; }
        }
        
        /// <summary> 子选项:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _SubQuestion
        {            
            get { return this.SubQuestion; }
            set { this.SubQuestion = value; }
        }
        
        /// <summary> 出题教师:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher
        {            
            get { return this.Teacher; }
            set { this.Teacher = value; }
        }
        
        /// <summary> 试卷类型:[Enum-{0:历年真题},{1:模拟卷}][CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Type1
        {            
            get { return this.Type1; }
            set { this.Type1 = value; }
        }
        
        /// <summary> Url的typeid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TypeIdUrl
        {            
            get { return this.TypeIdUrl; }
            set { this.TypeIdUrl = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserDeNum
        {            
            get { return this.UserDeNum; }
            set { this.UserDeNum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserDeNumStats
        {            
            get { return this.UserDeNumStats; }
            set { this.UserDeNumStats = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _VedioDiscussCount
        {            
            get { return this.VedioDiscussCount; }
            set { this.VedioDiscussCount = value; }
        }
        
        /// <summary> 权重:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weight
        {            
            get { return this.Weight; }
            set { this.Weight = value; }
        }
        
        /// <summary> 年份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YearId
        {            
            get { return this.YearId; }
            set { this.YearId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 答案解析:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string Analysis
        {
            get { return this.m_analysis; }
            set //
            {
                if (!analysis_initialized || m_analysis != value)
                {
                    this.m_analysis = value;
                }
                analysis_initialized = true;
            }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Answer
        {
            get { return this.m_answer; }
            set //
            {
                if (!answer_initialized || m_answer != value)
                {
                    this.m_answer = value;
                }
                answer_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Answer123
        {
            get { return this.m_answer123; }
            set //
            {
                if (!answer123_initialized || m_answer123 != value)
                {
                    this.m_answer123 = value;
                }
                answer123_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AnswerABC
        {
            get { return this.m_answerabc; }
            set //
            {
                if (!answerabc_initialized || m_answerabc != value)
                {
                    this.m_answerabc = value;
                }
                answerabc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AnswerDiscussCount
        {
            get { return this.m_answerdiscusscount; }
            set //
            {
                if (!answerdiscusscount_initialized || m_answerdiscusscount != value)
                {
                    this.m_answerdiscusscount = value;
                }
                answerdiscusscount_initialized = true;
            }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ClassId
        {
            get { return this.m_classid; }
            set //
            {
                if (!classid_initialized || m_classid != value)
                {
                    this.m_classid = value;
                }
                classid_initialized = true;
            }
        }
        
        /// <summary> 科目名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ClassName
        {
            get { return this.m_classname; }
            set //
            {
                if (!classname_initialized || m_classname != value)
                {
                    this.m_classname = value;
                }
                classname_initialized = true;
            }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string Content
        {
            get { return this.m_content; }
            set //
            {
                if (!content_initialized || m_content != value)
                {
                    this.m_content = value;
                }
                content_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DeNums
        {
            get { return this.m_denums; }
            set //
            {
                if (!denums_initialized || m_denums != value)
                {
                    this.m_denums = value;
                }
                denums_initialized = true;
            }
        }
        
        /// <summary> 差评次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DiggDown
        {
            get { return this.m_diggdown; }
            set //
            {
                if (!diggdown_initialized || m_diggdown != value)
                {
                    this.m_diggdown = value;
                }
                diggdown_initialized = true;
            }
        }
        
        /// <summary> 好评次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DiggUp
        {
            get { return this.m_diggup; }
            set //
            {
                if (!diggup_initialized || m_diggup != value)
                {
                    this.m_diggup = value;
                }
                diggup_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DiscussCount
        {
            get { return this.m_discusscount; }
            set //
            {
                if (!discusscount_initialized || m_discusscount != value)
                {
                    this.m_discusscount = value;
                }
                discusscount_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExamDiscussCount
        {
            get { return this.m_examdiscusscount; }
            set //
            {
                if (!examdiscusscount_initialized || m_examdiscusscount != value)
                {
                    this.m_examdiscusscount = value;
                }
                examdiscusscount_initialized = true;
            }
        }
        
        /// <summary> 题目ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExamId
        {
            get { return this.m_examid; }
            set //
            {
                if (!examid_initialized || m_examid != value)
                {
                    this.m_examid = value;
                }
                examid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExamNewStats
        {
            get { return this.m_examnewstats; }
            set //
            {
                if (!examnewstats_initialized || m_examnewstats != value)
                {
                    this.m_examnewstats = value;
                }
                examnewstats_initialized = true;
            }
        }
        
        /// <summary> 试卷类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExamType
        {
            get { return this.m_examtype; }
            set //
            {
                if (!examtype_initialized || m_examtype != value)
                {
                    this.m_examtype = value;
                }
                examtype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExpanddoExamNum
        {
            get { return this.m_expanddoexamnum; }
            set //
            {
                if (!expanddoexamnum_initialized || m_expanddoexamnum != value)
                {
                    this.m_expanddoexamnum = value;
                }
                expanddoexamnum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExpandPercent
        {
            get { return this.m_expandpercent; }
            set //
            {
                if (!expandpercent_initialized || m_expandpercent != value)
                {
                    this.m_expandpercent = value;
                }
                expandpercent_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string FavInfo
        {
            get { return this.m_favinfo; }
            set //
            {
                if (!favinfo_initialized || m_favinfo != value)
                {
                    this.m_favinfo = value;
                }
                favinfo_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string FavNum
        {
            get { return this.m_favnum; }
            set //
            {
                if (!favnum_initialized || m_favnum != value)
                {
                    this.m_favnum = value;
                }
                favnum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsFavorites
        {
            get { return this.m_isfavorites; }
            set //
            {
                if (!isfavorites_initialized || m_isfavorites != value)
                {
                    this.m_isfavorites = value;
                }
                isfavorites_initialized = true;
            }
        }
        
        /// <summary> 是否做过（0是1否）:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IsRepeatTf
        {
            get { return this.m_isrepeattf; }
            set //
            {
                if (!isrepeattf_initialized || m_isrepeattf != value)
                {
                    this.m_isrepeattf = value;
                }
                isrepeattf_initialized = true;
            }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Knowledge
        {
            get { return this.m_knowledge; }
            set //
            {
                if (!knowledge_initialized || m_knowledge != value)
                {
                    this.m_knowledge = value;
                }
                knowledge_initialized = true;
            }
        }
        
        /// <summary> 对应大题题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string LinkExam
        {
            get { return this.m_linkexam; }
            set //
            {
                if (!linkexam_initialized || m_linkexam != value)
                {
                    this.m_linkexam = value;
                }
                linkexam_initialized = true;
            }
        }
        
        /// <summary> Md5加密:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Md5
        {
            get { return this.m_md5; }
            set //
            {
                if (!md5_initialized || m_md5 != value)
                {
                    this.m_md5 = value;
                }
                md5_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MyDiscussCount
        {
            get { return this.m_mydiscusscount; }
            set //
            {
                if (!mydiscusscount_initialized || m_mydiscusscount != value)
                {
                    this.m_mydiscusscount = value;
                }
                mydiscusscount_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NewestNote
        {
            get { return this.m_newestnote; }
            set //
            {
                if (!newestnote_initialized || m_newestnote != value)
                {
                    this.m_newestnote = value;
                }
                newestnote_initialized = true;
            }
        }
        
        /// <summary> 选项列表:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string OptionList
        {
            get { return this.m_optionlist; }
            set //
            {
                if (!optionlist_initialized || m_optionlist != value)
                {
                    this.m_optionlist = value;
                }
                optionlist_initialized = true;
            }
        }
        
        /// <summary> 试卷题号-顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OrderId
        {
            get { return this.m_orderid; }
            set //
            {
                if (!orderid_initialized || m_orderid != value)
                {
                    this.m_orderid = value;
                }
                orderid_initialized = true;
            }
        }
        
        /// <summary> 试卷Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperId
        {
            get { return this.m_paperid; }
            set //
            {
                if (!paperid_initialized || m_paperid != value)
                {
                    this.m_paperid = value;
                }
                paperid_initialized = true;
            }
        }
        
        /// <summary> 试卷编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperInfo
        {
            get { return this.m_paperinfo; }
            set //
            {
                if (!paperinfo_initialized || m_paperinfo != value)
                {
                    this.m_paperinfo = value;
                }
                paperinfo_initialized = true;
            }
        }
        
        /// <summary> 试卷名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperName
        {
            get { return this.m_papername; }
            set //
            {
                if (!papername_initialized || m_papername != value)
                {
                    this.m_papername = value;
                }
                papername_initialized = true;
            }
        }
        
        /// <summary> 试卷简称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperShortName
        {
            get { return this.m_papershortname; }
            set //
            {
                if (!papershortname_initialized || m_papershortname != value)
                {
                    this.m_papershortname = value;
                }
                papershortname_initialized = true;
            }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Question
        {
            get { return this.m_question; }
            set //
            {
                if (!question_initialized || m_question != value)
                {
                    this.m_question = value;
                }
                question_initialized = true;
            }
        }
        
        /// <summary> 题目总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string QuestionCount
        {
            get { return this.m_questioncount; }
            set //
            {
                if (!questioncount_initialized || m_questioncount != value)
                {
                    this.m_questioncount = value;
                }
                questioncount_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string RightOrWrong
        {
            get { return this.m_rightorwrong; }
            set //
            {
                if (!rightorwrong_initialized || m_rightorwrong != value)
                {
                    this.m_rightorwrong = value;
                }
                rightorwrong_initialized = true;
            }
        }
        
        /// <summary> 规则ID(同一类型题目):[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string RulesId
        {
            get { return this.m_rulesid; }
            set //
            {
                if (!rulesid_initialized || m_rulesid != value)
                {
                    this.m_rulesid = value;
                }
                rulesid_initialized = true;
            }
        }
        
        /// <summary> 选项个数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SelectNum
        {
            get { return this.m_selectnum; }
            set //
            {
                if (!selectnum_initialized || m_selectnum != value)
                {
                    this.m_selectnum = value;
                }
                selectnum_initialized = true;
            }
        }
        
        /// <summary> 子选项:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string SubQuestion
        {
            get { return this.m_subquestion; }
            set //
            {
                if (!subquestion_initialized || m_subquestion != value)
                {
                    this.m_subquestion = value;
                }
                subquestion_initialized = true;
            }
        }
        
        /// <summary> 出题教师:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher
        {
            get { return this.m_teacher; }
            set //
            {
                if (!teacher_initialized || m_teacher != value)
                {
                    this.m_teacher = value;
                }
                teacher_initialized = true;
            }
        }
        
        /// <summary> 试卷类型:[Enum-{0:历年真题},{1:模拟卷}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Type1
        {
            get { return this.m_type1; }
            set //
            {
                if (!type1_initialized || m_type1 != value)
                {
                    this.m_type1 = value;
                }
                type1_initialized = true;
            }
        }
        
        /// <summary> Url的typeid:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TypeIdUrl
        {
            get { return this.m_typeidurl; }
            set //
            {
                if (!typeidurl_initialized || m_typeidurl != value)
                {
                    this.m_typeidurl = value;
                }
                typeidurl_initialized = true;
            }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserDeNum
        {
            get { return this.m_userdenum; }
            set //
            {
                if (!userdenum_initialized || m_userdenum != value)
                {
                    this.m_userdenum = value;
                }
                userdenum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserDeNumStats
        {
            get { return this.m_userdenumstats; }
            set //
            {
                if (!userdenumstats_initialized || m_userdenumstats != value)
                {
                    this.m_userdenumstats = value;
                }
                userdenumstats_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string VedioDiscussCount
        {
            get { return this.m_vediodiscusscount; }
            set //
            {
                if (!vediodiscusscount_initialized || m_vediodiscusscount != value)
                {
                    this.m_vediodiscusscount = value;
                }
                vediodiscusscount_initialized = true;
            }
        }
        
        /// <summary> 权重:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Weight
        {
            get { return this.m_weight; }
            set //
            {
                if (!weight_initialized || m_weight != value)
                {
                    this.m_weight = value;
                }
                weight_initialized = true;
            }
        }
        
        /// <summary> 年份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string YearId
        {
            get { return this.m_yearid; }
            set //
            {
                if (!yearid_initialized || m_yearid != value)
                {
                    this.m_yearid = value;
                }
                yearid_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TiMu233].[Id]", typeof(int), 4, default(int));
            
            /// <summary>答案解析:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Analysis =  new AttributeItem("[St_TiMu233].[Analysis]", typeof(string), -1, default(string));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[St_TiMu233].[Answer]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer123 =  new AttributeItem("[St_TiMu233].[Answer123]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerABC =  new AttributeItem("[St_TiMu233].[AnswerABC]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerDiscussCount =  new AttributeItem("[St_TiMu233].[AnswerDiscussCount]", typeof(string), 200, default(string));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassId =  new AttributeItem("[St_TiMu233].[ClassId]", typeof(string), 200, default(string));
            
            /// <summary>科目名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassName =  new AttributeItem("[St_TiMu233].[ClassName]", typeof(string), 200, default(string));
            
            /// <summary>题目:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Content =  new AttributeItem("[St_TiMu233].[Content]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DeNums =  new AttributeItem("[St_TiMu233].[DeNums]", typeof(string), 200, default(string));
            
            /// <summary>差评次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggDown =  new AttributeItem("[St_TiMu233].[DiggDown]", typeof(string), 200, default(string));
            
            /// <summary>好评次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggUp =  new AttributeItem("[St_TiMu233].[DiggUp]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiscussCount =  new AttributeItem("[St_TiMu233].[DiscussCount]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamDiscussCount =  new AttributeItem("[St_TiMu233].[ExamDiscussCount]", typeof(string), 200, default(string));
            
            /// <summary>题目ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamId =  new AttributeItem("[St_TiMu233].[ExamId]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamNewStats =  new AttributeItem("[St_TiMu233].[ExamNewStats]", typeof(string), 200, default(string));
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamType =  new AttributeItem("[St_TiMu233].[ExamType]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExpanddoExamNum =  new AttributeItem("[St_TiMu233].[ExpanddoExamNum]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExpandPercent =  new AttributeItem("[St_TiMu233].[ExpandPercent]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FavInfo =  new AttributeItem("[St_TiMu233].[FavInfo]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FavNum =  new AttributeItem("[St_TiMu233].[FavNum]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsFavorites =  new AttributeItem("[St_TiMu233].[IsFavorites]", typeof(string), 200, default(string));
            
            /// <summary>是否做过（0是1否）:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsRepeatTf =  new AttributeItem("[St_TiMu233].[IsRepeatTf]", typeof(string), 200, default(string));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TiMu233].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge =  new AttributeItem("[St_TiMu233].[Knowledge]", typeof(string), 200, default(string));
            
            /// <summary>对应大题题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem LinkExam =  new AttributeItem("[St_TiMu233].[LinkExam]", typeof(string), 200, default(string));
            
            /// <summary>Md5加密:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Md5 =  new AttributeItem("[St_TiMu233].[Md5]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MyDiscussCount =  new AttributeItem("[St_TiMu233].[MyDiscussCount]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NewestNote =  new AttributeItem("[St_TiMu233].[NewestNote]", typeof(string), 200, default(string));
            
            /// <summary>选项列表:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem OptionList =  new AttributeItem("[St_TiMu233].[OptionList]", typeof(string), -1, default(string));
            
            /// <summary>试卷题号-顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OrderId =  new AttributeItem("[St_TiMu233].[OrderId]", typeof(string), 200, default(string));
            
            /// <summary>试卷Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperId =  new AttributeItem("[St_TiMu233].[PaperId]", typeof(string), 200, default(string));
            
            /// <summary>试卷编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperInfo =  new AttributeItem("[St_TiMu233].[PaperInfo]", typeof(string), 200, default(string));
            
            /// <summary>试卷名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperName =  new AttributeItem("[St_TiMu233].[PaperName]", typeof(string), 200, default(string));
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperShortName =  new AttributeItem("[St_TiMu233].[PaperShortName]", typeof(string), 200, default(string));
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question =  new AttributeItem("[St_TiMu233].[Question]", typeof(string), 200, default(string));
            
            /// <summary>题目总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionCount =  new AttributeItem("[St_TiMu233].[QuestionCount]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RightOrWrong =  new AttributeItem("[St_TiMu233].[RightOrWrong]", typeof(string), 200, default(string));
            
            /// <summary>规则ID(同一类型题目):[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RulesId =  new AttributeItem("[St_TiMu233].[RulesId]", typeof(string), 200, default(string));
            
            /// <summary>选项个数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SelectNum =  new AttributeItem("[St_TiMu233].[SelectNum]", typeof(string), 200, default(string));
            
            /// <summary>子选项:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem SubQuestion =  new AttributeItem("[St_TiMu233].[SubQuestion]", typeof(string), 2000, default(string));
            
            /// <summary>出题教师:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher =  new AttributeItem("[St_TiMu233].[Teacher]", typeof(string), 200, default(string));
            
            /// <summary>试卷类型:[Enum-{0:历年真题},{1:模拟卷}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type1 =  new AttributeItem("[St_TiMu233].[Type1]", typeof(string), 50, default(string));
            
            /// <summary>Url的typeid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TypeIdUrl =  new AttributeItem("[St_TiMu233].[TypeIdUrl]", typeof(string), 50, default(string));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[St_TiMu233].[Url]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserDeNum =  new AttributeItem("[St_TiMu233].[UserDeNum]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserDeNumStats =  new AttributeItem("[St_TiMu233].[UserDeNumStats]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem VedioDiscussCount =  new AttributeItem("[St_TiMu233].[VedioDiscussCount]", typeof(string), 200, default(string));
            
            /// <summary>权重:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weight =  new AttributeItem("[St_TiMu233].[Weight]", typeof(string), 200, default(string));
            
            /// <summary>年份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YearId =  new AttributeItem("[St_TiMu233].[YearId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_analysis;
        /// <summary></summary>
        protected bool analysis_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private string m_answer123;
        /// <summary></summary>
        protected bool answer123_initialized = false;
        
        private string m_answerabc;
        /// <summary></summary>
        protected bool answerabc_initialized = false;
        
        private string m_answerdiscusscount;
        /// <summary></summary>
        protected bool answerdiscusscount_initialized = false;
        
        private string m_classid;
        /// <summary></summary>
        protected bool classid_initialized = false;
        
        private string m_classname;
        /// <summary></summary>
        protected bool classname_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_denums;
        /// <summary></summary>
        protected bool denums_initialized = false;
        
        private string m_diggdown;
        /// <summary></summary>
        protected bool diggdown_initialized = false;
        
        private string m_diggup;
        /// <summary></summary>
        protected bool diggup_initialized = false;
        
        private string m_discusscount;
        /// <summary></summary>
        protected bool discusscount_initialized = false;
        
        private string m_examdiscusscount;
        /// <summary></summary>
        protected bool examdiscusscount_initialized = false;
        
        private string m_examid;
        /// <summary></summary>
        protected bool examid_initialized = false;
        
        private string m_examnewstats;
        /// <summary></summary>
        protected bool examnewstats_initialized = false;
        
        private string m_examtype;
        /// <summary></summary>
        protected bool examtype_initialized = false;
        
        private string m_expanddoexamnum;
        /// <summary></summary>
        protected bool expanddoexamnum_initialized = false;
        
        private string m_expandpercent;
        /// <summary></summary>
        protected bool expandpercent_initialized = false;
        
        private string m_favinfo;
        /// <summary></summary>
        protected bool favinfo_initialized = false;
        
        private string m_favnum;
        /// <summary></summary>
        protected bool favnum_initialized = false;
        
        private string m_isfavorites;
        /// <summary></summary>
        protected bool isfavorites_initialized = false;
        
        private string m_isrepeattf;
        /// <summary></summary>
        protected bool isrepeattf_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_knowledge;
        /// <summary></summary>
        protected bool knowledge_initialized = false;
        
        private string m_linkexam;
        /// <summary></summary>
        protected bool linkexam_initialized = false;
        
        private string m_md5;
        /// <summary></summary>
        protected bool md5_initialized = false;
        
        private string m_mydiscusscount;
        /// <summary></summary>
        protected bool mydiscusscount_initialized = false;
        
        private string m_newestnote;
        /// <summary></summary>
        protected bool newestnote_initialized = false;
        
        private string m_optionlist;
        /// <summary></summary>
        protected bool optionlist_initialized = false;
        
        private string m_orderid;
        /// <summary></summary>
        protected bool orderid_initialized = false;
        
        private string m_paperid;
        /// <summary></summary>
        protected bool paperid_initialized = false;
        
        private string m_paperinfo;
        /// <summary></summary>
        protected bool paperinfo_initialized = false;
        
        private string m_papername;
        /// <summary></summary>
        protected bool papername_initialized = false;
        
        private string m_papershortname;
        /// <summary></summary>
        protected bool papershortname_initialized = false;
        
        private string m_question;
        /// <summary></summary>
        protected bool question_initialized = false;
        
        private string m_questioncount;
        /// <summary></summary>
        protected bool questioncount_initialized = false;
        
        private string m_rightorwrong;
        /// <summary></summary>
        protected bool rightorwrong_initialized = false;
        
        private string m_rulesid;
        /// <summary></summary>
        protected bool rulesid_initialized = false;
        
        private string m_selectnum;
        /// <summary></summary>
        protected bool selectnum_initialized = false;
        
        private string m_subquestion;
        /// <summary></summary>
        protected bool subquestion_initialized = false;
        
        private string m_teacher;
        /// <summary></summary>
        protected bool teacher_initialized = false;
        
        private string m_type1;
        /// <summary></summary>
        protected bool type1_initialized = false;
        
        private string m_typeidurl;
        /// <summary></summary>
        protected bool typeidurl_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private string m_userdenum;
        /// <summary></summary>
        protected bool userdenum_initialized = false;
        
        private string m_userdenumstats;
        /// <summary></summary>
        protected bool userdenumstats_initialized = false;
        
        private string m_vediodiscusscount;
        /// <summary></summary>
        protected bool vediodiscusscount_initialized = false;
        
        private string m_weight;
        /// <summary></summary>
        protected bool weight_initialized = false;
        
        private string m_yearid;
        /// <summary></summary>
        protected bool yearid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TiMu233";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.analysis_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.answer123_initialized = IsLoadAllAttributes;this.answerabc_initialized = IsLoadAllAttributes;this.answerdiscusscount_initialized = IsLoadAllAttributes;this.classid_initialized = IsLoadAllAttributes;this.classname_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.denums_initialized = IsLoadAllAttributes;this.diggdown_initialized = IsLoadAllAttributes;this.diggup_initialized = IsLoadAllAttributes;this.discusscount_initialized = IsLoadAllAttributes;this.examdiscusscount_initialized = IsLoadAllAttributes;this.examid_initialized = IsLoadAllAttributes;this.examnewstats_initialized = IsLoadAllAttributes;this.examtype_initialized = IsLoadAllAttributes;this.expanddoexamnum_initialized = IsLoadAllAttributes;this.expandpercent_initialized = IsLoadAllAttributes;this.favinfo_initialized = IsLoadAllAttributes;this.favnum_initialized = IsLoadAllAttributes;this.isfavorites_initialized = IsLoadAllAttributes;this.isrepeattf_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.knowledge_initialized = IsLoadAllAttributes;this.linkexam_initialized = IsLoadAllAttributes;this.md5_initialized = IsLoadAllAttributes;this.mydiscusscount_initialized = IsLoadAllAttributes;this.newestnote_initialized = IsLoadAllAttributes;this.optionlist_initialized = IsLoadAllAttributes;this.orderid_initialized = IsLoadAllAttributes;this.paperid_initialized = IsLoadAllAttributes;this.paperinfo_initialized = IsLoadAllAttributes;this.papername_initialized = IsLoadAllAttributes;this.papershortname_initialized = IsLoadAllAttributes;this.question_initialized = IsLoadAllAttributes;this.questioncount_initialized = IsLoadAllAttributes;this.rightorwrong_initialized = IsLoadAllAttributes;this.rulesid_initialized = IsLoadAllAttributes;this.selectnum_initialized = IsLoadAllAttributes;this.subquestion_initialized = IsLoadAllAttributes;this.teacher_initialized = IsLoadAllAttributes;this.type1_initialized = IsLoadAllAttributes;this.typeidurl_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.userdenum_initialized = IsLoadAllAttributes;this.userdenumstats_initialized = IsLoadAllAttributes;this.vediodiscusscount_initialized = IsLoadAllAttributes;this.weight_initialized = IsLoadAllAttributes;this.yearid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TiMu233 value = new St_TiMu233();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Analysis"))
				value.analysis_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer123"))
				value.answer123_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerABC"))
				value.answerabc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerDiscussCount"))
				value.answerdiscusscount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassId"))
				value.classid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassName"))
				value.classname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DeNums"))
				value.denums_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggDown"))
				value.diggdown_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggUp"))
				value.diggup_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiscussCount"))
				value.discusscount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamDiscussCount"))
				value.examdiscusscount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamId"))
				value.examid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamNewStats"))
				value.examnewstats_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamType"))
				value.examtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExpanddoExamNum"))
				value.expanddoexamnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExpandPercent"))
				value.expandpercent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FavInfo"))
				value.favinfo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FavNum"))
				value.favnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsFavorites"))
				value.isfavorites_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsRepeatTf"))
				value.isrepeattf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge"))
				value.knowledge_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"LinkExam"))
				value.linkexam_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Md5"))
				value.md5_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MyDiscussCount"))
				value.mydiscusscount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NewestNote"))
				value.newestnote_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionList"))
				value.optionlist_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OrderId"))
				value.orderid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperId"))
				value.paperid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperInfo"))
				value.paperinfo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperName"))
				value.papername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperShortName"))
				value.papershortname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question"))
				value.question_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionCount"))
				value.questioncount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RightOrWrong"))
				value.rightorwrong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RulesId"))
				value.rulesid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SelectNum"))
				value.selectnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SubQuestion"))
				value.subquestion_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher"))
				value.teacher_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type1"))
				value.type1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TypeIdUrl"))
				value.typeidurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserDeNum"))
				value.userdenum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserDeNumStats"))
				value.userdenumstats_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"VedioDiscussCount"))
				value.vediodiscusscount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weight"))
				value.weight_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YearId"))
				value.yearid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TiMu233 Clone()
        {
            return (St_TiMu233)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TiMu233()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TiMu233() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TiMu233(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TiMu233(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TiMu233(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TiMu233(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TiMu233(int id1, string analysis1, string answer1, string answer1231, string answerabc1, string answerdiscusscount1, string classid1, string classname1, string content1, string denums1, string diggdown1, string diggup1, string discusscount1, string examdiscusscount1, string examid1, string examnewstats1, string examtype1, string expanddoexamnum1, string expandpercent1, string favinfo1, string favnum1, string isfavorites1, string isrepeattf1, int kemuid1, string knowledge1, string linkexam1, string md51, string mydiscusscount1, string newestnote1, string optionlist1, string orderid1, string paperid1, string paperinfo1, string papername1, string papershortname1, string question1, string questioncount1, string rightorwrong1, string rulesid1, string selectnum1, string subquestion1, string teacher1, string type11, string typeidurl1, string url1, string userdenum1, string userdenumstats1, string vediodiscusscount1, string weight1, string yearid1)
        {
            
            this.Id = id1;
            
            this.Analysis = analysis1;
            
            this.Answer = answer1;
            
            this.Answer123 = answer1231;
            
            this.AnswerABC = answerabc1;
            
            this.AnswerDiscussCount = answerdiscusscount1;
            
            this.ClassId = classid1;
            
            this.ClassName = classname1;
            
            this.Content = content1;
            
            this.DeNums = denums1;
            
            this.DiggDown = diggdown1;
            
            this.DiggUp = diggup1;
            
            this.DiscussCount = discusscount1;
            
            this.ExamDiscussCount = examdiscusscount1;
            
            this.ExamId = examid1;
            
            this.ExamNewStats = examnewstats1;
            
            this.ExamType = examtype1;
            
            this.ExpanddoExamNum = expanddoexamnum1;
            
            this.ExpandPercent = expandpercent1;
            
            this.FavInfo = favinfo1;
            
            this.FavNum = favnum1;
            
            this.IsFavorites = isfavorites1;
            
            this.IsRepeatTf = isrepeattf1;
            
            this.KemuId = kemuid1;
            
            this.Knowledge = knowledge1;
            
            this.LinkExam = linkexam1;
            
            this.Md5 = md51;
            
            this.MyDiscussCount = mydiscusscount1;
            
            this.NewestNote = newestnote1;
            
            this.OptionList = optionlist1;
            
            this.OrderId = orderid1;
            
            this.PaperId = paperid1;
            
            this.PaperInfo = paperinfo1;
            
            this.PaperName = papername1;
            
            this.PaperShortName = papershortname1;
            
            this.Question = question1;
            
            this.QuestionCount = questioncount1;
            
            this.RightOrWrong = rightorwrong1;
            
            this.RulesId = rulesid1;
            
            this.SelectNum = selectnum1;
            
            this.SubQuestion = subquestion1;
            
            this.Teacher = teacher1;
            
            this.Type1 = type11;
            
            this.TypeIdUrl = typeidurl1;
            
            this.Url = url1;
            
            this.UserDeNum = userdenum1;
            
            this.UserDeNumStats = userdenumstats1;
            
            this.VedioDiscussCount = vediodiscusscount1;
            
            this.Weight = weight1;
            
            this.YearId = yearid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TiMu233 FromIView(IView view)
        {
            return (St_TiMu233)IView.GetITable(view, "St_TiMu233");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TiMu233 GetOneInstance()
        {
            St_TiMu233 value = new St_TiMu233();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TiMu233 Retrieve()
        {
            BLLTable<St_TiMu233>.GetRowData(this);
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
			    			
			    case "Analysis":
			        return Analysis;
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "Answer123":
			        return Answer123;
			    			
			    case "AnswerABC":
			        return AnswerABC;
			    			
			    case "AnswerDiscussCount":
			        return AnswerDiscussCount;
			    			
			    case "ClassId":
			        return ClassId;
			    			
			    case "ClassName":
			        return ClassName;
			    			
			    case "Content":
			        return Content;
			    			
			    case "DeNums":
			        return DeNums;
			    			
			    case "DiggDown":
			        return DiggDown;
			    			
			    case "DiggUp":
			        return DiggUp;
			    			
			    case "DiscussCount":
			        return DiscussCount;
			    			
			    case "ExamDiscussCount":
			        return ExamDiscussCount;
			    			
			    case "ExamId":
			        return ExamId;
			    			
			    case "ExamNewStats":
			        return ExamNewStats;
			    			
			    case "ExamType":
			        return ExamType;
			    			
			    case "ExpanddoExamNum":
			        return ExpanddoExamNum;
			    			
			    case "ExpandPercent":
			        return ExpandPercent;
			    			
			    case "FavInfo":
			        return FavInfo;
			    			
			    case "FavNum":
			        return FavNum;
			    			
			    case "IsFavorites":
			        return IsFavorites;
			    			
			    case "IsRepeatTf":
			        return IsRepeatTf;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "Knowledge":
			        return Knowledge;
			    			
			    case "LinkExam":
			        return LinkExam;
			    			
			    case "Md5":
			        return Md5;
			    			
			    case "MyDiscussCount":
			        return MyDiscussCount;
			    			
			    case "NewestNote":
			        return NewestNote;
			    			
			    case "OptionList":
			        return OptionList;
			    			
			    case "OrderId":
			        return OrderId;
			    			
			    case "PaperId":
			        return PaperId;
			    			
			    case "PaperInfo":
			        return PaperInfo;
			    			
			    case "PaperName":
			        return PaperName;
			    			
			    case "PaperShortName":
			        return PaperShortName;
			    			
			    case "Question":
			        return Question;
			    			
			    case "QuestionCount":
			        return QuestionCount;
			    			
			    case "RightOrWrong":
			        return RightOrWrong;
			    			
			    case "RulesId":
			        return RulesId;
			    			
			    case "SelectNum":
			        return SelectNum;
			    			
			    case "SubQuestion":
			        return SubQuestion;
			    			
			    case "Teacher":
			        return Teacher;
			    			
			    case "Type1":
			        return Type1;
			    			
			    case "TypeIdUrl":
			        return TypeIdUrl;
			    			
			    case "Url":
			        return Url;
			    			
			    case "UserDeNum":
			        return UserDeNum;
			    			
			    case "UserDeNumStats":
			        return UserDeNumStats;
			    			
			    case "VedioDiscussCount":
			        return VedioDiscussCount;
			    			
			    case "Weight":
			        return Weight;
			    			
			    case "YearId":
			        return YearId;
			
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
			    			
			    case "Analysis":
			        this.Analysis = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Answer":
			        this.Answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Answer123":
			        this.Answer123 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AnswerABC":
			        this.AnswerABC = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AnswerDiscussCount":
			        this.AnswerDiscussCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassId":
			        this.ClassId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassName":
			        this.ClassName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DeNums":
			        this.DeNums = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggDown":
			        this.DiggDown = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggUp":
			        this.DiggUp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiscussCount":
			        this.DiscussCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamDiscussCount":
			        this.ExamDiscussCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamId":
			        this.ExamId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamNewStats":
			        this.ExamNewStats = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamType":
			        this.ExamType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExpanddoExamNum":
			        this.ExpanddoExamNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExpandPercent":
			        this.ExpandPercent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "FavInfo":
			        this.FavInfo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "FavNum":
			        this.FavNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsFavorites":
			        this.IsFavorites = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsRepeatTf":
			        this.IsRepeatTf = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Knowledge":
			        this.Knowledge = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "LinkExam":
			        this.LinkExam = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Md5":
			        this.Md5 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MyDiscussCount":
			        this.MyDiscussCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NewestNote":
			        this.NewestNote = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionList":
			        this.OptionList = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OrderId":
			        this.OrderId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperId":
			        this.PaperId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperInfo":
			        this.PaperInfo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperName":
			        this.PaperName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperShortName":
			        this.PaperShortName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question":
			        this.Question = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionCount":
			        this.QuestionCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RightOrWrong":
			        this.RightOrWrong = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RulesId":
			        this.RulesId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SelectNum":
			        this.SelectNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SubQuestion":
			        this.SubQuestion = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher":
			        this.Teacher = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type1":
			        this.Type1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TypeIdUrl":
			        this.TypeIdUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserDeNum":
			        this.UserDeNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserDeNumStats":
			        this.UserDeNumStats = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "VedioDiscussCount":
			        this.VedioDiscussCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weight":
			        this.Weight = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YearId":
			        this.YearId = Convert.ToString(AttributeValue);
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
				
				case "Analysis":
					return analysis_initialized;
				
				case "Answer":
					return answer_initialized;
				
				case "Answer123":
					return answer123_initialized;
				
				case "AnswerABC":
					return answerabc_initialized;
				
				case "AnswerDiscussCount":
					return answerdiscusscount_initialized;
				
				case "ClassId":
					return classid_initialized;
				
				case "ClassName":
					return classname_initialized;
				
				case "Content":
					return content_initialized;
				
				case "DeNums":
					return denums_initialized;
				
				case "DiggDown":
					return diggdown_initialized;
				
				case "DiggUp":
					return diggup_initialized;
				
				case "DiscussCount":
					return discusscount_initialized;
				
				case "ExamDiscussCount":
					return examdiscusscount_initialized;
				
				case "ExamId":
					return examid_initialized;
				
				case "ExamNewStats":
					return examnewstats_initialized;
				
				case "ExamType":
					return examtype_initialized;
				
				case "ExpanddoExamNum":
					return expanddoexamnum_initialized;
				
				case "ExpandPercent":
					return expandpercent_initialized;
				
				case "FavInfo":
					return favinfo_initialized;
				
				case "FavNum":
					return favnum_initialized;
				
				case "IsFavorites":
					return isfavorites_initialized;
				
				case "IsRepeatTf":
					return isrepeattf_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "Knowledge":
					return knowledge_initialized;
				
				case "LinkExam":
					return linkexam_initialized;
				
				case "Md5":
					return md5_initialized;
				
				case "MyDiscussCount":
					return mydiscusscount_initialized;
				
				case "NewestNote":
					return newestnote_initialized;
				
				case "OptionList":
					return optionlist_initialized;
				
				case "OrderId":
					return orderid_initialized;
				
				case "PaperId":
					return paperid_initialized;
				
				case "PaperInfo":
					return paperinfo_initialized;
				
				case "PaperName":
					return papername_initialized;
				
				case "PaperShortName":
					return papershortname_initialized;
				
				case "Question":
					return question_initialized;
				
				case "QuestionCount":
					return questioncount_initialized;
				
				case "RightOrWrong":
					return rightorwrong_initialized;
				
				case "RulesId":
					return rulesid_initialized;
				
				case "SelectNum":
					return selectnum_initialized;
				
				case "SubQuestion":
					return subquestion_initialized;
				
				case "Teacher":
					return teacher_initialized;
				
				case "Type1":
					return type1_initialized;
				
				case "TypeIdUrl":
					return typeidurl_initialized;
				
				case "Url":
					return url_initialized;
				
				case "UserDeNum":
					return userdenum_initialized;
				
				case "UserDeNumStats":
					return userdenumstats_initialized;
				
				case "VedioDiscussCount":
					return vediodiscusscount_initialized;
				
				case "Weight":
					return weight_initialized;
				
				case "YearId":
					return yearid_initialized;
				
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
				
				case "Analysis":
					analysis_initialized = ret;
					return true;
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "Answer123":
					answer123_initialized = ret;
					return true;
				
				case "AnswerABC":
					answerabc_initialized = ret;
					return true;
				
				case "AnswerDiscussCount":
					answerdiscusscount_initialized = ret;
					return true;
				
				case "ClassId":
					classid_initialized = ret;
					return true;
				
				case "ClassName":
					classname_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "DeNums":
					denums_initialized = ret;
					return true;
				
				case "DiggDown":
					diggdown_initialized = ret;
					return true;
				
				case "DiggUp":
					diggup_initialized = ret;
					return true;
				
				case "DiscussCount":
					discusscount_initialized = ret;
					return true;
				
				case "ExamDiscussCount":
					examdiscusscount_initialized = ret;
					return true;
				
				case "ExamId":
					examid_initialized = ret;
					return true;
				
				case "ExamNewStats":
					examnewstats_initialized = ret;
					return true;
				
				case "ExamType":
					examtype_initialized = ret;
					return true;
				
				case "ExpanddoExamNum":
					expanddoexamnum_initialized = ret;
					return true;
				
				case "ExpandPercent":
					expandpercent_initialized = ret;
					return true;
				
				case "FavInfo":
					favinfo_initialized = ret;
					return true;
				
				case "FavNum":
					favnum_initialized = ret;
					return true;
				
				case "IsFavorites":
					isfavorites_initialized = ret;
					return true;
				
				case "IsRepeatTf":
					isrepeattf_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "Knowledge":
					knowledge_initialized = ret;
					return true;
				
				case "LinkExam":
					linkexam_initialized = ret;
					return true;
				
				case "Md5":
					md5_initialized = ret;
					return true;
				
				case "MyDiscussCount":
					mydiscusscount_initialized = ret;
					return true;
				
				case "NewestNote":
					newestnote_initialized = ret;
					return true;
				
				case "OptionList":
					optionlist_initialized = ret;
					return true;
				
				case "OrderId":
					orderid_initialized = ret;
					return true;
				
				case "PaperId":
					paperid_initialized = ret;
					return true;
				
				case "PaperInfo":
					paperinfo_initialized = ret;
					return true;
				
				case "PaperName":
					papername_initialized = ret;
					return true;
				
				case "PaperShortName":
					papershortname_initialized = ret;
					return true;
				
				case "Question":
					question_initialized = ret;
					return true;
				
				case "QuestionCount":
					questioncount_initialized = ret;
					return true;
				
				case "RightOrWrong":
					rightorwrong_initialized = ret;
					return true;
				
				case "RulesId":
					rulesid_initialized = ret;
					return true;
				
				case "SelectNum":
					selectnum_initialized = ret;
					return true;
				
				case "SubQuestion":
					subquestion_initialized = ret;
					return true;
				
				case "Teacher":
					teacher_initialized = ret;
					return true;
				
				case "Type1":
					type1_initialized = ret;
					return true;
				
				case "TypeIdUrl":
					typeidurl_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "UserDeNum":
					userdenum_initialized = ret;
					return true;
				
				case "UserDeNumStats":
					userdenumstats_initialized = ret;
					return true;
				
				case "VedioDiscussCount":
					vediodiscusscount_initialized = ret;
					return true;
				
				case "Weight":
					weight_initialized = ret;
					return true;
				
				case "YearId":
					yearid_initialized = ret;
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
                AttributeItem attr = St_TiMu233.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (analysis_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Analysis;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Analysis);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (answer123_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Answer123;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer123);
                }
			}
			
			if (answerabc_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.AnswerABC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerABC);
                }
			}
			
			if (answerdiscusscount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.AnswerDiscussCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerDiscussCount);
                }
			}
			
			if (classid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ClassId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassId);
                }
			}
			
			if (classname_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ClassName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassName);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (denums_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.DeNums;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DeNums);
                }
			}
			
			if (diggdown_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.DiggDown;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggDown);
                }
			}
			
			if (diggup_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.DiggUp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggUp);
                }
			}
			
			if (discusscount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.DiscussCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiscussCount);
                }
			}
			
			if (examdiscusscount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExamDiscussCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamDiscussCount);
                }
			}
			
			if (examid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExamId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamId);
                }
			}
			
			if (examnewstats_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExamNewStats;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamNewStats);
                }
			}
			
			if (examtype_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExamType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamType);
                }
			}
			
			if (expanddoexamnum_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExpanddoExamNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExpanddoExamNum);
                }
			}
			
			if (expandpercent_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.ExpandPercent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExpandPercent);
                }
			}
			
			if (favinfo_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.FavInfo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FavInfo);
                }
			}
			
			if (favnum_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.FavNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FavNum);
                }
			}
			
			if (isfavorites_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.IsFavorites;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsFavorites);
                }
			}
			
			if (isrepeattf_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.IsRepeatTf;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsRepeatTf);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (knowledge_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Knowledge;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge);
                }
			}
			
			if (linkexam_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.LinkExam;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(LinkExam);
                }
			}
			
			if (md5_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Md5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Md5);
                }
			}
			
			if (mydiscusscount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.MyDiscussCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MyDiscussCount);
                }
			}
			
			if (newestnote_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.NewestNote;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NewestNote);
                }
			}
			
			if (optionlist_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.OptionList;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionList);
                }
			}
			
			if (orderid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.OrderId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OrderId);
                }
			}
			
			if (paperid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.PaperId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperId);
                }
			}
			
			if (paperinfo_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.PaperInfo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperInfo);
                }
			}
			
			if (papername_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.PaperName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperName);
                }
			}
			
			if (papershortname_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.PaperShortName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperShortName);
                }
			}
			
			if (question_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Question;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question);
                }
			}
			
			if (questioncount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.QuestionCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionCount);
                }
			}
			
			if (rightorwrong_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.RightOrWrong;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RightOrWrong);
                }
			}
			
			if (rulesid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.RulesId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RulesId);
                }
			}
			
			if (selectnum_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.SelectNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SelectNum);
                }
			}
			
			if (subquestion_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.SubQuestion;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SubQuestion);
                }
			}
			
			if (teacher_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Teacher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher);
                }
			}
			
			if (type1_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Type1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type1);
                }
			}
			
			if (typeidurl_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.TypeIdUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TypeIdUrl);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (userdenum_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.UserDeNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserDeNum);
                }
			}
			
			if (userdenumstats_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.UserDeNumStats;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserDeNumStats);
                }
			}
			
			if (vediodiscusscount_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.VedioDiscussCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(VedioDiscussCount);
                }
			}
			
			if (weight_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.Weight;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weight);
                }
			}
			
			if (yearid_initialized)
			{
                AttributeItem attr = St_TiMu233.Attribute.YearId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YearId);
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
        public class St_TiMu233Json
        {
            
            /// <summary>自动编号:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>答案解析:[CtrlTypeDic-{HTML}]</summary>
            public string Analysis { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Answer123 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string AnswerABC { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string AnswerDiscussCount { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public string ClassId { get; set; }
            
            /// <summary>科目名:[CtrlTypeDic-{InputString}]</summary>
            public string ClassName { get; set; }
            
            /// <summary>题目:[CtrlTypeDic-{HTML}]</summary>
            public string Content { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string DeNums { get; set; }
            
            /// <summary>差评次数:[CtrlTypeDic-{InputString}]</summary>
            public string DiggDown { get; set; }
            
            /// <summary>好评次数:[CtrlTypeDic-{InputString}]</summary>
            public string DiggUp { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string DiscussCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ExamDiscussCount { get; set; }
            
            /// <summary>题目ID:[CtrlTypeDic-{InputString}]</summary>
            public string ExamId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ExamNewStats { get; set; }
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public string ExamType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ExpanddoExamNum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ExpandPercent { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string FavInfo { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string FavNum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsFavorites { get; set; }
            
            /// <summary>是否做过（0是1否）:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public string IsRepeatTf { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge { get; set; }
            
            /// <summary>对应大题题号:[CtrlTypeDic-{InputString}]</summary>
            public string LinkExam { get; set; }
            
            /// <summary>Md5加密:[CtrlTypeDic-{InputString}]</summary>
            public string Md5 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string MyDiscussCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string NewestNote { get; set; }
            
            /// <summary>选项列表:[CtrlTypeDic-{HTML}]</summary>
            public string OptionList { get; set; }
            
            /// <summary>试卷题号-顺序号:[CtrlTypeDic-{InputString}]</summary>
            public string OrderId { get; set; }
            
            /// <summary>试卷Id:[CtrlTypeDic-{InputString}]</summary>
            public string PaperId { get; set; }
            
            /// <summary>试卷编号:[CtrlTypeDic-{InputString}]</summary>
            public string PaperInfo { get; set; }
            
            /// <summary>试卷名:[CtrlTypeDic-{InputString}]</summary>
            public string PaperName { get; set; }
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public string PaperShortName { get; set; }
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public string Question { get; set; }
            
            /// <summary>题目总数:[CtrlTypeDic-{InputString}]</summary>
            public string QuestionCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string RightOrWrong { get; set; }
            
            /// <summary>规则ID(同一类型题目):[CtrlTypeDic-{InputString}]</summary>
            public string RulesId { get; set; }
            
            /// <summary>选项个数:[CtrlTypeDic-{InputString}]</summary>
            public string SelectNum { get; set; }
            
            /// <summary>子选项:[CtrlTypeDic-{HTML}]</summary>
            public string SubQuestion { get; set; }
            
            /// <summary>出题教师:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher { get; set; }
            
            /// <summary>试卷类型:[Enum-{0:历年真题},{1:模拟卷}][CtrlTypeDic-{InputString}]</summary>
            public string Type1 { get; set; }
            
            /// <summary>Url的typeid:[CtrlTypeDic-{InputString}]</summary>
            public string TypeIdUrl { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string UserDeNum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string UserDeNumStats { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string VedioDiscussCount { get; set; }
            
            /// <summary>权重:[CtrlTypeDic-{InputString}]</summary>
            public string Weight { get; set; }
            
            /// <summary>年份:[CtrlTypeDic-{InputString}]</summary>
            public string YearId { get; set; }
        }
        #endregion
    }
}