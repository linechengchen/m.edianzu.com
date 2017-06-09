/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:34
  Description:    数据表Xt_TimuDaXue对应的业务逻辑层Xt_TimuDaXue
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_TimuDaXue_Entity:Xt_TimuDaXue
 * 
************************************************************/
/************************************************************
SQL代码：
select AutoId,Id,Answer,ChapterId,ChapterName,Difficulty,Explain,Label,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,OptionType,Question,QuestionId,MediaContent,FalseCount,TrueCount,WrongRate,SourceFile,Sourceid,SourceZhangjie,Optionnum,Kemu,Url,Sc,Area,User_id,DiggUp,DiggDown,IsRepeatTf,ExamType,Analysis,LinkExam,OrderId,Teacher,Knowledge,YearId,PaperShortName,KemuId,OptionStr,AnswerABC,KaoDian,Score,QuestionIndex,Test_id,Course_id,Category_ids,Category_names,Question_imgs from Xt_TimuDaXue
delete from Xt_TimuDaXue
INSERT INTO Xt_TimuDaXue (AutoId,Id,Answer,ChapterId,ChapterName,Difficulty,Explain,Label,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,OptionType,Question,QuestionId,MediaContent,FalseCount,TrueCount,WrongRate,SourceFile,Sourceid,SourceZhangjie,Optionnum,Kemu,Url,Sc,Area,User_id,DiggUp,DiggDown,IsRepeatTf,ExamType,Analysis,LinkExam,OrderId,Teacher,Knowledge,YearId,PaperShortName,KemuId,OptionStr,AnswerABC,KaoDian,Score,QuestionIndex,Test_id,Course_id,Category_ids,Category_names,Question_imgs)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xt_TimuDaXue SET ...
变量赋值代码：
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Id = valObj2.Id;
        valObj.Answer = valObj2.Answer;
        valObj.ChapterId = valObj2.ChapterId;
        valObj.ChapterName = valObj2.ChapterName;
        valObj.Difficulty = valObj2.Difficulty;
        valObj.Explain = valObj2.Explain;
        valObj.Label = valObj2.Label;
        valObj.MediaHeight = valObj2.MediaHeight;
        valObj.MediaType = valObj2.MediaType;
        valObj.MediaWidth = valObj2.MediaWidth;
        valObj.OptionA = valObj2.OptionA;
        valObj.OptionB = valObj2.OptionB;
        valObj.OptionC = valObj2.OptionC;
        valObj.OptionD = valObj2.OptionD;
        valObj.OptionE = valObj2.OptionE;
        valObj.OptionF = valObj2.OptionF;
        valObj.OptionG = valObj2.OptionG;
        valObj.OptionH = valObj2.OptionH;
        valObj.OptionType = valObj2.OptionType;
        valObj.Question = valObj2.Question;
        valObj.QuestionId = valObj2.QuestionId;
        valObj.MediaContent = valObj2.MediaContent;
        valObj.FalseCount = valObj2.FalseCount;
        valObj.TrueCount = valObj2.TrueCount;
        valObj.WrongRate = valObj2.WrongRate;
        valObj.SourceFile = valObj2.SourceFile;
        valObj.Sourceid = valObj2.Sourceid;
        valObj.SourceZhangjie = valObj2.SourceZhangjie;
        valObj.Optionnum = valObj2.Optionnum;
        valObj.Kemu = valObj2.Kemu;
        valObj.Url = valObj2.Url;
        valObj.Sc = valObj2.Sc;
        valObj.Area = valObj2.Area;
        valObj.User_id = valObj2.User_id;
        valObj.DiggUp = valObj2.DiggUp;
        valObj.DiggDown = valObj2.DiggDown;
        valObj.IsRepeatTf = valObj2.IsRepeatTf;
        valObj.ExamType = valObj2.ExamType;
        valObj.Analysis = valObj2.Analysis;
        valObj.LinkExam = valObj2.LinkExam;
        valObj.OrderId = valObj2.OrderId;
        valObj.Teacher = valObj2.Teacher;
        valObj.Knowledge = valObj2.Knowledge;
        valObj.YearId = valObj2.YearId;
        valObj.PaperShortName = valObj2.PaperShortName;
        valObj.KemuId = valObj2.KemuId;
        valObj.OptionStr = valObj2.OptionStr;
        valObj.AnswerABC = valObj2.AnswerABC;
        valObj.KaoDian = valObj2.KaoDian;
        valObj.Score = valObj2.Score;
        valObj.QuestionIndex = valObj2.QuestionIndex;
        valObj.Test_id = valObj2.Test_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Category_ids = valObj2.Category_ids;
        valObj.Category_names = valObj2.Category_names;
        valObj.Question_imgs = valObj2.Question_imgs; 
        valObj.AutoId = "";
        valObj.Id = "";
        valObj.Answer = "";
        valObj.ChapterId = "";
        valObj.ChapterName = "";
        valObj.Difficulty = "";
        valObj.Explain = "";
        valObj.Label = "";
        valObj.MediaHeight = "";
        valObj.MediaType = "";
        valObj.MediaWidth = "";
        valObj.OptionA = "";
        valObj.OptionB = "";
        valObj.OptionC = "";
        valObj.OptionD = "";
        valObj.OptionE = "";
        valObj.OptionF = "";
        valObj.OptionG = "";
        valObj.OptionH = "";
        valObj.OptionType = "";
        valObj.Question = "";
        valObj.QuestionId = "";
        valObj.MediaContent = "";
        valObj.FalseCount = "";
        valObj.TrueCount = "";
        valObj.WrongRate = "";
        valObj.SourceFile = "";
        valObj.Sourceid = "";
        valObj.SourceZhangjie = "";
        valObj.Optionnum = "";
        valObj.Kemu = "";
        valObj.Url = "";
        valObj.Sc = "";
        valObj.Area = "";
        valObj.User_id = "";
        valObj.DiggUp = "";
        valObj.DiggDown = "";
        valObj.IsRepeatTf = "";
        valObj.ExamType = "";
        valObj.Analysis = "";
        valObj.LinkExam = "";
        valObj.OrderId = "";
        valObj.Teacher = "";
        valObj.Knowledge = "";
        valObj.YearId = "";
        valObj.PaperShortName = "";
        valObj.KemuId = "";
        valObj.OptionStr = "";
        valObj.AnswerABC = "";
        valObj.KaoDian = "";
        valObj.Score = "";
        valObj.QuestionIndex = "";
        valObj.Test_id = "";
        valObj.Course_id = "";
        valObj.Category_ids = "";
        valObj.Category_names = "";
        valObj.Question_imgs = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Id": $("#txt_Id").val(),
        "Answer": $("#txt_Answer").val(),
        "ChapterId": $("#txt_ChapterId").val(),
        "ChapterName": $("#txt_ChapterName").val(),
        "Difficulty": $("#txt_Difficulty").val(),
        "Explain": $("#txt_Explain").val(),
        "Label": $("#txt_Label").val(),
        "MediaHeight": $("#txt_MediaHeight").val(),
        "MediaType": $("#txt_MediaType").val(),
        "MediaWidth": $("#txt_MediaWidth").val(),
        "OptionA": $("#txt_OptionA").val(),
        "OptionB": $("#txt_OptionB").val(),
        "OptionC": $("#txt_OptionC").val(),
        "OptionD": $("#txt_OptionD").val(),
        "OptionE": $("#txt_OptionE").val(),
        "OptionF": $("#txt_OptionF").val(),
        "OptionG": $("#txt_OptionG").val(),
        "OptionH": $("#txt_OptionH").val(),
        "OptionType": $("#txt_OptionType").val(),
        "Question": $("#txt_Question").val(),
        "QuestionId": $("#txt_QuestionId").val(),
        "MediaContent": $("#txt_MediaContent").val(),
        "FalseCount": $("#txt_FalseCount").val(),
        "TrueCount": $("#txt_TrueCount").val(),
        "WrongRate": $("#txt_WrongRate").val(),
        "SourceFile": $("#txt_SourceFile").val(),
        "Sourceid": $("#txt_Sourceid").val(),
        "SourceZhangjie": $("#txt_SourceZhangjie").val(),
        "Optionnum": $("#txt_Optionnum").val(),
        "Kemu": $("#txt_Kemu").val(),
        "Url": $("#txt_Url").val(),
        "Sc": $("#txt_Sc").val(),
        "Area": $("#txt_Area").val(),
        "User_id": $("#txt_User_id").val(),
        "DiggUp": $("#txt_DiggUp").val(),
        "DiggDown": $("#txt_DiggDown").val(),
        "IsRepeatTf": $("#txt_IsRepeatTf").val(),
        "ExamType": $("#txt_ExamType").val(),
        "Analysis": $("#txt_Analysis").val(),
        "LinkExam": $("#txt_LinkExam").val(),
        "OrderId": $("#txt_OrderId").val(),
        "Teacher": $("#txt_Teacher").val(),
        "Knowledge": $("#txt_Knowledge").val(),
        "YearId": $("#txt_YearId").val(),
        "PaperShortName": $("#txt_PaperShortName").val(),
        "KemuId": $("#txt_KemuId").val(),
        "OptionStr": $("#txt_OptionStr").val(),
        "AnswerABC": $("#txt_AnswerABC").val(),
        "KaoDian": $("#txt_KaoDian").val(),
        "Score": $("#txt_Score").val(),
        "QuestionIndex": $("#txt_QuestionIndex").val(),
        "Test_id": $("#txt_Test_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Category_ids": $("#txt_Category_ids").val(),
        "Category_names": $("#txt_Category_names").val(),
        "Question_imgs": $("#txt_Question_imgs").val(), 
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
    /// <para>大学题库:[IDField-{Id:0}]</para>
    /// <para>与Xt_TimuDaXue数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_TimuDaXue : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_TimuDaXue Factory()
        {
            return new Xt_TimuDaXue();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer
        {            
            get { return this.Answer; }
            set { this.Answer = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterId
        {            
            get { return this.ChapterId; }
            set { this.ChapterId = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterName
        {            
            get { return this.ChapterName; }
            set { this.ChapterName = value; }
        }
        
        /// <summary> 难易程序:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Difficulty
        {            
            get { return this.Difficulty; }
            set { this.Difficulty = value; }
        }
        
        /// <summary> 试题解析:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Explain
        {            
            get { return this.Explain; }
            set { this.Explain = value; }
        }
        
        /// <summary> 章节:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Label
        {            
            get { return this.Label; }
            set { this.Label = value; }
        }
        
        /// <summary> 媒体高度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaHeight
        {            
            get { return this.MediaHeight; }
            set { this.MediaHeight = value; }
        }
        
        /// <summary> 媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaType
        {            
            get { return this.MediaType; }
            set { this.MediaType = value; }
        }
        
        /// <summary> 媒体宽度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaWidth
        {            
            get { return this.MediaWidth; }
            set { this.MediaWidth = value; }
        }
        
        /// <summary> A:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionA
        {            
            get { return this.OptionA; }
            set { this.OptionA = value; }
        }
        
        /// <summary> B:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionB
        {            
            get { return this.OptionB; }
            set { this.OptionB = value; }
        }
        
        /// <summary> C:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionC
        {            
            get { return this.OptionC; }
            set { this.OptionC = value; }
        }
        
        /// <summary> D:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionD
        {            
            get { return this.OptionD; }
            set { this.OptionD = value; }
        }
        
        /// <summary> E:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionE
        {            
            get { return this.OptionE; }
            set { this.OptionE = value; }
        }
        
        /// <summary> F:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionF
        {            
            get { return this.OptionF; }
            set { this.OptionF = value; }
        }
        
        /// <summary> G:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionG
        {            
            get { return this.OptionG; }
            set { this.OptionG = value; }
        }
        
        /// <summary> H:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionH
        {            
            get { return this.OptionH; }
            set { this.OptionH = value; }
        }
        
        /// <summary> 题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _OptionType
        {            
            get { return this.OptionType; }
            set { this.OptionType = value; }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Question
        {            
            get { return this.Question; }
            set { this.Question = value; }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionId
        {            
            get { return this.QuestionId; }
            set { this.QuestionId = value; }
        }
        
        /// <summary> 媒体内容:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaContent
        {            
            get { return this.MediaContent; }
            set { this.MediaContent = value; }
        }
        
        /// <summary> 错误次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _FalseCount
        {            
            get { return this.FalseCount; }
            set { this.FalseCount = value; }
        }
        
        /// <summary> 正确次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TrueCount
        {            
            get { return this.TrueCount; }
            set { this.TrueCount = value; }
        }
        
        /// <summary> 错误率:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WrongRate
        {            
            get { return this.WrongRate; }
            set { this.WrongRate = value; }
        }
        
        /// <summary> 源文件:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SourceFile
        {            
            get { return this.SourceFile; }
            set { this.SourceFile = value; }
        }
        
        /// <summary> 源ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sourceid
        {            
            get { return this.Sourceid; }
            set { this.Sourceid = value; }
        }
        
        /// <summary> 源章节:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SourceZhangjie
        {            
            get { return this.SourceZhangjie; }
            set { this.SourceZhangjie = value; }
        }
        
        /// <summary> 多选题答案个数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Optionnum
        {            
            get { return this.Optionnum; }
            set { this.Optionnum = value; }
        }
        
        /// <summary> 科目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary> 源大学微信号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> 地区:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Area
        {            
            get { return this.Area; }
            set { this.Area = value; }
        }
        
        /// <summary> 用户Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 好评:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggUp
        {            
            get { return this.DiggUp; }
            set { this.DiggUp = value; }
        }
        
        /// <summary> 差评:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggDown
        {            
            get { return this.DiggDown; }
            set { this.DiggDown = value; }
        }
        
        /// <summary> 是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsRepeatTf
        {            
            get { return this.IsRepeatTf; }
            set { this.IsRepeatTf = value; }
        }
        
        /// <summary> 试卷类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamType
        {            
            get { return this.ExamType; }
            set { this.ExamType = value; }
        }
        
        /// <summary> 考题分析:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Analysis
        {            
            get { return this.Analysis; }
            set { this.Analysis = value; }
        }
        
        /// <summary> 大题题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _LinkExam
        {            
            get { return this.LinkExam; }
            set { this.LinkExam = value; }
        }
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OrderId
        {            
            get { return this.OrderId; }
            set { this.OrderId = value; }
        }
        
        /// <summary> 出题老师:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher
        {            
            get { return this.Teacher; }
            set { this.Teacher = value; }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge
        {            
            get { return this.Knowledge; }
            set { this.Knowledge = value; }
        }
        
        /// <summary> 试卷年份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YearId
        {            
            get { return this.YearId; }
            set { this.YearId = value; }
        }
        
        /// <summary> 试卷简称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperShortName
        {            
            get { return this.PaperShortName; }
            set { this.PaperShortName = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _OptionStr
        {            
            get { return this.OptionStr; }
            set { this.OptionStr = value; }
        }
        
        /// <summary> 学生提交的纠错答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AnswerABC
        {            
            get { return this.AnswerABC; }
            set { this.AnswerABC = value; }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KaoDian
        {            
            get { return this.KaoDian; }
            set { this.KaoDian = value; }
        }
        
        /// <summary> 分值:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Score
        {            
            get { return this.Score; }
            set { this.Score = value; }
        }
        
        /// <summary> 题目顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionIndex
        {            
            get { return this.QuestionIndex; }
            set { this.QuestionIndex = value; }
        }
        
        /// <summary> (survey_id):[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Test_id
        {            
            get { return this.Test_id; }
            set { this.Test_id = value; }
        }
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_ids
        {            
            get { return this.Category_ids; }
            set { this.Category_ids = value; }
        }
        
        /// <summary> 分类名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_names
        {            
            get { return this.Category_names; }
            set { this.Category_names = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Question_imgs
        {            
            get { return this.Question_imgs; }
            set { this.Question_imgs = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
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
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChapterId
        {
            get { return this.m_chapterid; }
            set //
            {
                if (!chapterid_initialized || m_chapterid != value)
                {
                    this.m_chapterid = value;
                }
                chapterid_initialized = true;
            }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChapterName
        {
            get { return this.m_chaptername; }
            set //
            {
                if (!chaptername_initialized || m_chaptername != value)
                {
                    this.m_chaptername = value;
                }
                chaptername_initialized = true;
            }
        }
        
        /// <summary> 难易程序:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Difficulty
        {
            get { return this.m_difficulty; }
            set //
            {
                if (!difficulty_initialized || m_difficulty != value)
                {
                    this.m_difficulty = value;
                }
                difficulty_initialized = true;
            }
        }
        
        /// <summary> 试题解析:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Explain
        {
            get { return this.m_explain; }
            set //
            {
                if (!explain_initialized || m_explain != value)
                {
                    this.m_explain = value;
                }
                explain_initialized = true;
            }
        }
        
        /// <summary> 章节:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Label
        {
            get { return this.m_label; }
            set //
            {
                if (!label_initialized || m_label != value)
                {
                    this.m_label = value;
                }
                label_initialized = true;
            }
        }
        
        /// <summary> 媒体高度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaHeight
        {
            get { return this.m_mediaheight; }
            set //
            {
                if (!mediaheight_initialized || m_mediaheight != value)
                {
                    this.m_mediaheight = value;
                }
                mediaheight_initialized = true;
            }
        }
        
        /// <summary> 媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaType
        {
            get { return this.m_mediatype; }
            set //
            {
                if (!mediatype_initialized || m_mediatype != value)
                {
                    this.m_mediatype = value;
                }
                mediatype_initialized = true;
            }
        }
        
        /// <summary> 媒体宽度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaWidth
        {
            get { return this.m_mediawidth; }
            set //
            {
                if (!mediawidth_initialized || m_mediawidth != value)
                {
                    this.m_mediawidth = value;
                }
                mediawidth_initialized = true;
            }
        }
        
        /// <summary> A:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionA
        {
            get { return this.m_optiona; }
            set //
            {
                if (!optiona_initialized || m_optiona != value)
                {
                    this.m_optiona = value;
                }
                optiona_initialized = true;
            }
        }
        
        /// <summary> B:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionB
        {
            get { return this.m_optionb; }
            set //
            {
                if (!optionb_initialized || m_optionb != value)
                {
                    this.m_optionb = value;
                }
                optionb_initialized = true;
            }
        }
        
        /// <summary> C:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionC
        {
            get { return this.m_optionc; }
            set //
            {
                if (!optionc_initialized || m_optionc != value)
                {
                    this.m_optionc = value;
                }
                optionc_initialized = true;
            }
        }
        
        /// <summary> D:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionD
        {
            get { return this.m_optiond; }
            set //
            {
                if (!optiond_initialized || m_optiond != value)
                {
                    this.m_optiond = value;
                }
                optiond_initialized = true;
            }
        }
        
        /// <summary> E:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionE
        {
            get { return this.m_optione; }
            set //
            {
                if (!optione_initialized || m_optione != value)
                {
                    this.m_optione = value;
                }
                optione_initialized = true;
            }
        }
        
        /// <summary> F:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionF
        {
            get { return this.m_optionf; }
            set //
            {
                if (!optionf_initialized || m_optionf != value)
                {
                    this.m_optionf = value;
                }
                optionf_initialized = true;
            }
        }
        
        /// <summary> G:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionG
        {
            get { return this.m_optiong; }
            set //
            {
                if (!optiong_initialized || m_optiong != value)
                {
                    this.m_optiong = value;
                }
                optiong_initialized = true;
            }
        }
        
        /// <summary> H:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionH
        {
            get { return this.m_optionh; }
            set //
            {
                if (!optionh_initialized || m_optionh != value)
                {
                    this.m_optionh = value;
                }
                optionh_initialized = true;
            }
        }
        
        /// <summary> 题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string OptionType
        {
            get { return this.m_optiontype; }
            set //
            {
                if (!optiontype_initialized || m_optiontype != value)
                {
                    this.m_optiontype = value;
                }
                optiontype_initialized = true;
            }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int QuestionId
        {
            get { return this.m_questionid; }
            set //
            {
                if (!questionid_initialized || m_questionid != value)
                {
                    this.m_questionid = value;
                }
                questionid_initialized = true;
            }
        }
        
        /// <summary> 媒体内容:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaContent
        {
            get { return this.m_mediacontent; }
            set //
            {
                if (!mediacontent_initialized || m_mediacontent != value)
                {
                    this.m_mediacontent = value;
                }
                mediacontent_initialized = true;
            }
        }
        
        /// <summary> 错误次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string FalseCount
        {
            get { return this.m_falsecount; }
            set //
            {
                if (!falsecount_initialized || m_falsecount != value)
                {
                    this.m_falsecount = value;
                }
                falsecount_initialized = true;
            }
        }
        
        /// <summary> 正确次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TrueCount
        {
            get { return this.m_truecount; }
            set //
            {
                if (!truecount_initialized || m_truecount != value)
                {
                    this.m_truecount = value;
                }
                truecount_initialized = true;
            }
        }
        
        /// <summary> 错误率:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WrongRate
        {
            get { return this.m_wrongrate; }
            set //
            {
                if (!wrongrate_initialized || m_wrongrate != value)
                {
                    this.m_wrongrate = value;
                }
                wrongrate_initialized = true;
            }
        }
        
        /// <summary> 源文件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SourceFile
        {
            get { return this.m_sourcefile; }
            set //
            {
                if (!sourcefile_initialized || m_sourcefile != value)
                {
                    this.m_sourcefile = value;
                }
                sourcefile_initialized = true;
            }
        }
        
        /// <summary> 源ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sourceid
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
        
        /// <summary> 源章节:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SourceZhangjie
        {
            get { return this.m_sourcezhangjie; }
            set //
            {
                if (!sourcezhangjie_initialized || m_sourcezhangjie != value)
                {
                    this.m_sourcezhangjie = value;
                }
                sourcezhangjie_initialized = true;
            }
        }
        
        /// <summary> 多选题答案个数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Optionnum
        {
            get { return this.m_optionnum; }
            set //
            {
                if (!optionnum_initialized || m_optionnum != value)
                {
                    this.m_optionnum = value;
                }
                optionnum_initialized = true;
            }
        }
        
        /// <summary> 科目:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Kemu
        {
            get { return this.m_kemu; }
            set //
            {
                if (!kemu_initialized || m_kemu != value)
                {
                    this.m_kemu = value;
                }
                kemu_initialized = true;
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
        
        /// <summary> 源大学微信号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 地区:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Area
        {
            get { return this.m_area; }
            set //
            {
                if (!area_initialized || m_area != value)
                {
                    this.m_area = value;
                }
                area_initialized = true;
            }
        }
        
        /// <summary> 用户Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 好评:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 差评:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 考题分析:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 大题题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 出题老师:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 试卷年份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string OptionStr
        {
            get { return this.m_optionstr; }
            set //
            {
                if (!optionstr_initialized || m_optionstr != value)
                {
                    this.m_optionstr = value;
                }
                optionstr_initialized = true;
            }
        }
        
        /// <summary> 学生提交的纠错答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KaoDian
        {
            get { return this.m_kaodian; }
            set //
            {
                if (!kaodian_initialized || m_kaodian != value)
                {
                    this.m_kaodian = value;
                }
                kaodian_initialized = true;
            }
        }
        
        /// <summary> 分值:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Score
        {
            get { return this.m_score; }
            set //
            {
                if (!score_initialized || m_score != value)
                {
                    this.m_score = value;
                }
                score_initialized = true;
            }
        }
        
        /// <summary> 题目顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int QuestionIndex
        {
            get { return this.m_questionindex; }
            set //
            {
                if (!questionindex_initialized || m_questionindex != value)
                {
                    this.m_questionindex = value;
                }
                questionindex_initialized = true;
            }
        }
        
        /// <summary> (survey_id):[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Test_id
        {
            get { return this.m_test_id; }
            set //
            {
                if (!test_id_initialized || m_test_id != value)
                {
                    this.m_test_id = value;
                }
                test_id_initialized = true;
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
        
        /// <summary> 分类id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category_ids
        {
            get { return this.m_category_ids; }
            set //
            {
                if (!category_ids_initialized || m_category_ids != value)
                {
                    this.m_category_ids = value;
                }
                category_ids_initialized = true;
            }
        }
        
        /// <summary> 分类名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category_names
        {
            get { return this.m_category_names; }
            set //
            {
                if (!category_names_initialized || m_category_names != value)
                {
                    this.m_category_names = value;
                }
                category_names_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Question_imgs
        {
            get { return this.m_question_imgs; }
            set //
            {
                if (!question_imgs_initialized || m_question_imgs != value)
                {
                    this.m_question_imgs = value;
                }
                question_imgs_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[Xt_TimuDaXue].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_TimuDaXue].[Id]", typeof(int), 4, default(int));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[Xt_TimuDaXue].[Answer]", typeof(string), -1, default(string));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterId =  new AttributeItem("[Xt_TimuDaXue].[ChapterId]", typeof(string), 200, default(string));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterName =  new AttributeItem("[Xt_TimuDaXue].[ChapterName]", typeof(string), 200, default(string));
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Difficulty =  new AttributeItem("[Xt_TimuDaXue].[Difficulty]", typeof(string), 200, default(string));
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Explain =  new AttributeItem("[Xt_TimuDaXue].[Explain]", typeof(string), -1, default(string));
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Label =  new AttributeItem("[Xt_TimuDaXue].[Label]", typeof(string), 200, default(string));
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaHeight =  new AttributeItem("[Xt_TimuDaXue].[MediaHeight]", typeof(string), 200, default(string));
            
            /// <summary>媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaType =  new AttributeItem("[Xt_TimuDaXue].[MediaType]", typeof(string), 200, default(string));
            
            /// <summary>媒体宽度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaWidth =  new AttributeItem("[Xt_TimuDaXue].[MediaWidth]", typeof(string), 200, default(string));
            
            /// <summary>A:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionA =  new AttributeItem("[Xt_TimuDaXue].[OptionA]", typeof(string), 200, default(string));
            
            /// <summary>B:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionB =  new AttributeItem("[Xt_TimuDaXue].[OptionB]", typeof(string), 200, default(string));
            
            /// <summary>C:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionC =  new AttributeItem("[Xt_TimuDaXue].[OptionC]", typeof(string), 200, default(string));
            
            /// <summary>D:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionD =  new AttributeItem("[Xt_TimuDaXue].[OptionD]", typeof(string), 200, default(string));
            
            /// <summary>E:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionE =  new AttributeItem("[Xt_TimuDaXue].[OptionE]", typeof(string), 200, default(string));
            
            /// <summary>F:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionF =  new AttributeItem("[Xt_TimuDaXue].[OptionF]", typeof(string), 200, default(string));
            
            /// <summary>G:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionG =  new AttributeItem("[Xt_TimuDaXue].[OptionG]", typeof(string), 200, default(string));
            
            /// <summary>H:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionH =  new AttributeItem("[Xt_TimuDaXue].[OptionH]", typeof(string), 200, default(string));
            
            /// <summary>题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem OptionType =  new AttributeItem("[Xt_TimuDaXue].[OptionType]", typeof(string), 200, default(string));
            
            /// <summary>题目:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Question =  new AttributeItem("[Xt_TimuDaXue].[Question]", typeof(string), 3000, default(string));
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionId =  new AttributeItem("[Xt_TimuDaXue].[QuestionId]", typeof(int), 4, default(int));
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaContent =  new AttributeItem("[Xt_TimuDaXue].[MediaContent]", typeof(string), 200, default(string));
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FalseCount =  new AttributeItem("[Xt_TimuDaXue].[FalseCount]", typeof(string), 200, default(string));
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TrueCount =  new AttributeItem("[Xt_TimuDaXue].[TrueCount]", typeof(string), 200, default(string));
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WrongRate =  new AttributeItem("[Xt_TimuDaXue].[WrongRate]", typeof(string), 200, default(string));
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceFile =  new AttributeItem("[Xt_TimuDaXue].[SourceFile]", typeof(string), 200, default(string));
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sourceid =  new AttributeItem("[Xt_TimuDaXue].[Sourceid]", typeof(string), 200, default(string));
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceZhangjie =  new AttributeItem("[Xt_TimuDaXue].[SourceZhangjie]", typeof(string), 200, default(string));
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Optionnum =  new AttributeItem("[Xt_TimuDaXue].[Optionnum]", typeof(string), 200, default(string));
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[Xt_TimuDaXue].[Kemu]", typeof(string), 200, default(string));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[Xt_TimuDaXue].[Url]", typeof(string), 200, default(string));
            
            /// <summary>源大学微信号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[Xt_TimuDaXue].[Sc]", typeof(string), 20, default(string));
            
            /// <summary>地区:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Area =  new AttributeItem("[Xt_TimuDaXue].[Area]", typeof(string), 50, default(string));
            
            /// <summary>用户Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_TimuDaXue].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>好评:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggUp =  new AttributeItem("[Xt_TimuDaXue].[DiggUp]", typeof(string), 50, default(string));
            
            /// <summary>差评:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggDown =  new AttributeItem("[Xt_TimuDaXue].[DiggDown]", typeof(string), 50, default(string));
            
            /// <summary>是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsRepeatTf =  new AttributeItem("[Xt_TimuDaXue].[IsRepeatTf]", typeof(string), 50, default(string));
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamType =  new AttributeItem("[Xt_TimuDaXue].[ExamType]", typeof(string), 50, default(string));
            
            /// <summary>考题分析:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Analysis =  new AttributeItem("[Xt_TimuDaXue].[Analysis]", typeof(string), 50, default(string));
            
            /// <summary>大题题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem LinkExam =  new AttributeItem("[Xt_TimuDaXue].[LinkExam]", typeof(string), 50, default(string));
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OrderId =  new AttributeItem("[Xt_TimuDaXue].[OrderId]", typeof(string), 50, default(string));
            
            /// <summary>出题老师:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher =  new AttributeItem("[Xt_TimuDaXue].[Teacher]", typeof(string), 50, default(string));
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge =  new AttributeItem("[Xt_TimuDaXue].[Knowledge]", typeof(string), 50, default(string));
            
            /// <summary>试卷年份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YearId =  new AttributeItem("[Xt_TimuDaXue].[YearId]", typeof(string), 50, default(string));
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperShortName =  new AttributeItem("[Xt_TimuDaXue].[PaperShortName]", typeof(string), 50, default(string));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[Xt_TimuDaXue].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem OptionStr =  new AttributeItem("[Xt_TimuDaXue].[OptionStr]", typeof(string), 3000, default(string));
            
            /// <summary>学生提交的纠错答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerABC =  new AttributeItem("[Xt_TimuDaXue].[AnswerABC]", typeof(string), 50, default(string));
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KaoDian =  new AttributeItem("[Xt_TimuDaXue].[KaoDian]", typeof(string), 200, default(string));
            
            /// <summary>分值:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score =  new AttributeItem("[Xt_TimuDaXue].[Score]", typeof(string), 10, default(string));
            
            /// <summary>题目顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionIndex =  new AttributeItem("[Xt_TimuDaXue].[QuestionIndex]", typeof(int), 4, default(int));
            
            /// <summary>(survey_id):[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Test_id =  new AttributeItem("[Xt_TimuDaXue].[Test_id]", typeof(string), 36, default(string));
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_TimuDaXue].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_ids =  new AttributeItem("[Xt_TimuDaXue].[Category_ids]", typeof(string), 100, default(string));
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_names =  new AttributeItem("[Xt_TimuDaXue].[Category_names]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Question_imgs =  new AttributeItem("[Xt_TimuDaXue].[Question_imgs]", typeof(string), 900, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private string m_chapterid;
        /// <summary></summary>
        protected bool chapterid_initialized = false;
        
        private string m_chaptername;
        /// <summary></summary>
        protected bool chaptername_initialized = false;
        
        private string m_difficulty;
        /// <summary></summary>
        protected bool difficulty_initialized = false;
        
        private string m_explain;
        /// <summary></summary>
        protected bool explain_initialized = false;
        
        private string m_label;
        /// <summary></summary>
        protected bool label_initialized = false;
        
        private string m_mediaheight;
        /// <summary></summary>
        protected bool mediaheight_initialized = false;
        
        private string m_mediatype;
        /// <summary></summary>
        protected bool mediatype_initialized = false;
        
        private string m_mediawidth;
        /// <summary></summary>
        protected bool mediawidth_initialized = false;
        
        private string m_optiona;
        /// <summary></summary>
        protected bool optiona_initialized = false;
        
        private string m_optionb;
        /// <summary></summary>
        protected bool optionb_initialized = false;
        
        private string m_optionc;
        /// <summary></summary>
        protected bool optionc_initialized = false;
        
        private string m_optiond;
        /// <summary></summary>
        protected bool optiond_initialized = false;
        
        private string m_optione;
        /// <summary></summary>
        protected bool optione_initialized = false;
        
        private string m_optionf;
        /// <summary></summary>
        protected bool optionf_initialized = false;
        
        private string m_optiong;
        /// <summary></summary>
        protected bool optiong_initialized = false;
        
        private string m_optionh;
        /// <summary></summary>
        protected bool optionh_initialized = false;
        
        private string m_optiontype;
        /// <summary></summary>
        protected bool optiontype_initialized = false;
        
        private string m_question;
        /// <summary></summary>
        protected bool question_initialized = false;
        
        private int m_questionid;
        /// <summary></summary>
        protected bool questionid_initialized = false;
        
        private string m_mediacontent;
        /// <summary></summary>
        protected bool mediacontent_initialized = false;
        
        private string m_falsecount;
        /// <summary></summary>
        protected bool falsecount_initialized = false;
        
        private string m_truecount;
        /// <summary></summary>
        protected bool truecount_initialized = false;
        
        private string m_wrongrate;
        /// <summary></summary>
        protected bool wrongrate_initialized = false;
        
        private string m_sourcefile;
        /// <summary></summary>
        protected bool sourcefile_initialized = false;
        
        private string m_sourceid;
        /// <summary></summary>
        protected bool sourceid_initialized = false;
        
        private string m_sourcezhangjie;
        /// <summary></summary>
        protected bool sourcezhangjie_initialized = false;
        
        private string m_optionnum;
        /// <summary></summary>
        protected bool optionnum_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_area;
        /// <summary></summary>
        protected bool area_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_diggup;
        /// <summary></summary>
        protected bool diggup_initialized = false;
        
        private string m_diggdown;
        /// <summary></summary>
        protected bool diggdown_initialized = false;
        
        private string m_isrepeattf;
        /// <summary></summary>
        protected bool isrepeattf_initialized = false;
        
        private string m_examtype;
        /// <summary></summary>
        protected bool examtype_initialized = false;
        
        private string m_analysis;
        /// <summary></summary>
        protected bool analysis_initialized = false;
        
        private string m_linkexam;
        /// <summary></summary>
        protected bool linkexam_initialized = false;
        
        private string m_orderid;
        /// <summary></summary>
        protected bool orderid_initialized = false;
        
        private string m_teacher;
        /// <summary></summary>
        protected bool teacher_initialized = false;
        
        private string m_knowledge;
        /// <summary></summary>
        protected bool knowledge_initialized = false;
        
        private string m_yearid;
        /// <summary></summary>
        protected bool yearid_initialized = false;
        
        private string m_papershortname;
        /// <summary></summary>
        protected bool papershortname_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_optionstr;
        /// <summary></summary>
        protected bool optionstr_initialized = false;
        
        private string m_answerabc;
        /// <summary></summary>
        protected bool answerabc_initialized = false;
        
        private string m_kaodian;
        /// <summary></summary>
        protected bool kaodian_initialized = false;
        
        private string m_score;
        /// <summary></summary>
        protected bool score_initialized = false;
        
        private int m_questionindex;
        /// <summary></summary>
        protected bool questionindex_initialized = false;
        
        private string m_test_id;
        /// <summary></summary>
        protected bool test_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_category_ids;
        /// <summary></summary>
        protected bool category_ids_initialized = false;
        
        private string m_category_names;
        /// <summary></summary>
        protected bool category_names_initialized = false;
        
        private string m_question_imgs;
        /// <summary></summary>
        protected bool question_imgs_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_TimuDaXue";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.chapterid_initialized = IsLoadAllAttributes;this.chaptername_initialized = IsLoadAllAttributes;this.difficulty_initialized = IsLoadAllAttributes;this.explain_initialized = IsLoadAllAttributes;this.label_initialized = IsLoadAllAttributes;this.mediaheight_initialized = IsLoadAllAttributes;this.mediatype_initialized = IsLoadAllAttributes;this.mediawidth_initialized = IsLoadAllAttributes;this.optiona_initialized = IsLoadAllAttributes;this.optionb_initialized = IsLoadAllAttributes;this.optionc_initialized = IsLoadAllAttributes;this.optiond_initialized = IsLoadAllAttributes;this.optione_initialized = IsLoadAllAttributes;this.optionf_initialized = IsLoadAllAttributes;this.optiong_initialized = IsLoadAllAttributes;this.optionh_initialized = IsLoadAllAttributes;this.optiontype_initialized = IsLoadAllAttributes;this.question_initialized = IsLoadAllAttributes;this.questionid_initialized = IsLoadAllAttributes;this.mediacontent_initialized = IsLoadAllAttributes;this.falsecount_initialized = IsLoadAllAttributes;this.truecount_initialized = IsLoadAllAttributes;this.wrongrate_initialized = IsLoadAllAttributes;this.sourcefile_initialized = IsLoadAllAttributes;this.sourceid_initialized = IsLoadAllAttributes;this.sourcezhangjie_initialized = IsLoadAllAttributes;this.optionnum_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.area_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.diggup_initialized = IsLoadAllAttributes;this.diggdown_initialized = IsLoadAllAttributes;this.isrepeattf_initialized = IsLoadAllAttributes;this.examtype_initialized = IsLoadAllAttributes;this.analysis_initialized = IsLoadAllAttributes;this.linkexam_initialized = IsLoadAllAttributes;this.orderid_initialized = IsLoadAllAttributes;this.teacher_initialized = IsLoadAllAttributes;this.knowledge_initialized = IsLoadAllAttributes;this.yearid_initialized = IsLoadAllAttributes;this.papershortname_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.optionstr_initialized = IsLoadAllAttributes;this.answerabc_initialized = IsLoadAllAttributes;this.kaodian_initialized = IsLoadAllAttributes;this.score_initialized = IsLoadAllAttributes;this.questionindex_initialized = IsLoadAllAttributes;this.test_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.category_ids_initialized = IsLoadAllAttributes;this.category_names_initialized = IsLoadAllAttributes;this.question_imgs_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_TimuDaXue value = new Xt_TimuDaXue();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterId"))
				value.chapterid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterName"))
				value.chaptername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Difficulty"))
				value.difficulty_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Explain"))
				value.explain_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Label"))
				value.label_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaHeight"))
				value.mediaheight_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaType"))
				value.mediatype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaWidth"))
				value.mediawidth_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionA"))
				value.optiona_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionB"))
				value.optionb_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionC"))
				value.optionc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionD"))
				value.optiond_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionE"))
				value.optione_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionF"))
				value.optionf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionG"))
				value.optiong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionH"))
				value.optionh_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionType"))
				value.optiontype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question"))
				value.question_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionId"))
				value.questionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaContent"))
				value.mediacontent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FalseCount"))
				value.falsecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TrueCount"))
				value.truecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WrongRate"))
				value.wrongrate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceFile"))
				value.sourcefile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sourceid"))
				value.sourceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceZhangjie"))
				value.sourcezhangjie_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Optionnum"))
				value.optionnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Area"))
				value.area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggUp"))
				value.diggup_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggDown"))
				value.diggdown_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsRepeatTf"))
				value.isrepeattf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamType"))
				value.examtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Analysis"))
				value.analysis_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"LinkExam"))
				value.linkexam_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OrderId"))
				value.orderid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher"))
				value.teacher_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge"))
				value.knowledge_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YearId"))
				value.yearid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperShortName"))
				value.papershortname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionStr"))
				value.optionstr_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerABC"))
				value.answerabc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KaoDian"))
				value.kaodian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score"))
				value.score_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionIndex"))
				value.questionindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Test_id"))
				value.test_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_ids"))
				value.category_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_names"))
				value.category_names_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_imgs"))
				value.question_imgs_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_TimuDaXue Clone()
        {
            return (Xt_TimuDaXue)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_TimuDaXue()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_TimuDaXue() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_TimuDaXue(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_TimuDaXue(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_TimuDaXue(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_TimuDaXue(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_TimuDaXue(int autoid1, int id1, string answer1, string chapterid1, string chaptername1, string difficulty1, string explain1, string label1, string mediaheight1, string mediatype1, string mediawidth1, string optiona1, string optionb1, string optionc1, string optiond1, string optione1, string optionf1, string optiong1, string optionh1, string optiontype1, string question1, int questionid1, string mediacontent1, string falsecount1, string truecount1, string wrongrate1, string sourcefile1, string sourceid1, string sourcezhangjie1, string optionnum1, string kemu1, string url1, string sc1, string area1, string user_id1, string diggup1, string diggdown1, string isrepeattf1, string examtype1, string analysis1, string linkexam1, string orderid1, string teacher1, string knowledge1, string yearid1, string papershortname1, int kemuid1, string optionstr1, string answerabc1, string kaodian1, string score1, int questionindex1, string test_id1, string course_id1, string category_ids1, string category_names1, string question_imgs1)
        {
            
            this.AutoId = autoid1;
            
            this.Id = id1;
            
            this.Answer = answer1;
            
            this.ChapterId = chapterid1;
            
            this.ChapterName = chaptername1;
            
            this.Difficulty = difficulty1;
            
            this.Explain = explain1;
            
            this.Label = label1;
            
            this.MediaHeight = mediaheight1;
            
            this.MediaType = mediatype1;
            
            this.MediaWidth = mediawidth1;
            
            this.OptionA = optiona1;
            
            this.OptionB = optionb1;
            
            this.OptionC = optionc1;
            
            this.OptionD = optiond1;
            
            this.OptionE = optione1;
            
            this.OptionF = optionf1;
            
            this.OptionG = optiong1;
            
            this.OptionH = optionh1;
            
            this.OptionType = optiontype1;
            
            this.Question = question1;
            
            this.QuestionId = questionid1;
            
            this.MediaContent = mediacontent1;
            
            this.FalseCount = falsecount1;
            
            this.TrueCount = truecount1;
            
            this.WrongRate = wrongrate1;
            
            this.SourceFile = sourcefile1;
            
            this.Sourceid = sourceid1;
            
            this.SourceZhangjie = sourcezhangjie1;
            
            this.Optionnum = optionnum1;
            
            this.Kemu = kemu1;
            
            this.Url = url1;
            
            this.Sc = sc1;
            
            this.Area = area1;
            
            this.User_id = user_id1;
            
            this.DiggUp = diggup1;
            
            this.DiggDown = diggdown1;
            
            this.IsRepeatTf = isrepeattf1;
            
            this.ExamType = examtype1;
            
            this.Analysis = analysis1;
            
            this.LinkExam = linkexam1;
            
            this.OrderId = orderid1;
            
            this.Teacher = teacher1;
            
            this.Knowledge = knowledge1;
            
            this.YearId = yearid1;
            
            this.PaperShortName = papershortname1;
            
            this.KemuId = kemuid1;
            
            this.OptionStr = optionstr1;
            
            this.AnswerABC = answerabc1;
            
            this.KaoDian = kaodian1;
            
            this.Score = score1;
            
            this.QuestionIndex = questionindex1;
            
            this.Test_id = test_id1;
            
            this.Course_id = course_id1;
            
            this.Category_ids = category_ids1;
            
            this.Category_names = category_names1;
            
            this.Question_imgs = question_imgs1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_TimuDaXue FromIView(IView view)
        {
            return (Xt_TimuDaXue)IView.GetITable(view, "Xt_TimuDaXue");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_TimuDaXue GetOneInstance()
        {
            Xt_TimuDaXue value = new Xt_TimuDaXue();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_TimuDaXue Retrieve()
        {
            BLLTable<Xt_TimuDaXue>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "ChapterId":
			        return ChapterId;
			    			
			    case "ChapterName":
			        return ChapterName;
			    			
			    case "Difficulty":
			        return Difficulty;
			    			
			    case "Explain":
			        return Explain;
			    			
			    case "Label":
			        return Label;
			    			
			    case "MediaHeight":
			        return MediaHeight;
			    			
			    case "MediaType":
			        return MediaType;
			    			
			    case "MediaWidth":
			        return MediaWidth;
			    			
			    case "OptionA":
			        return OptionA;
			    			
			    case "OptionB":
			        return OptionB;
			    			
			    case "OptionC":
			        return OptionC;
			    			
			    case "OptionD":
			        return OptionD;
			    			
			    case "OptionE":
			        return OptionE;
			    			
			    case "OptionF":
			        return OptionF;
			    			
			    case "OptionG":
			        return OptionG;
			    			
			    case "OptionH":
			        return OptionH;
			    			
			    case "OptionType":
			        return OptionType;
			    			
			    case "Question":
			        return Question;
			    			
			    case "QuestionId":
			        return QuestionId;
			    			
			    case "MediaContent":
			        return MediaContent;
			    			
			    case "FalseCount":
			        return FalseCount;
			    			
			    case "TrueCount":
			        return TrueCount;
			    			
			    case "WrongRate":
			        return WrongRate;
			    			
			    case "SourceFile":
			        return SourceFile;
			    			
			    case "Sourceid":
			        return Sourceid;
			    			
			    case "SourceZhangjie":
			        return SourceZhangjie;
			    			
			    case "Optionnum":
			        return Optionnum;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "Url":
			        return Url;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "Area":
			        return Area;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "DiggUp":
			        return DiggUp;
			    			
			    case "DiggDown":
			        return DiggDown;
			    			
			    case "IsRepeatTf":
			        return IsRepeatTf;
			    			
			    case "ExamType":
			        return ExamType;
			    			
			    case "Analysis":
			        return Analysis;
			    			
			    case "LinkExam":
			        return LinkExam;
			    			
			    case "OrderId":
			        return OrderId;
			    			
			    case "Teacher":
			        return Teacher;
			    			
			    case "Knowledge":
			        return Knowledge;
			    			
			    case "YearId":
			        return YearId;
			    			
			    case "PaperShortName":
			        return PaperShortName;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "OptionStr":
			        return OptionStr;
			    			
			    case "AnswerABC":
			        return AnswerABC;
			    			
			    case "KaoDian":
			        return KaoDian;
			    			
			    case "Score":
			        return Score;
			    			
			    case "QuestionIndex":
			        return QuestionIndex;
			    			
			    case "Test_id":
			        return Test_id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Category_ids":
			        return Category_ids;
			    			
			    case "Category_names":
			        return Category_names;
			    			
			    case "Question_imgs":
			        return Question_imgs;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Answer":
			        this.Answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChapterId":
			        this.ChapterId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChapterName":
			        this.ChapterName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Difficulty":
			        this.Difficulty = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Explain":
			        this.Explain = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Label":
			        this.Label = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaHeight":
			        this.MediaHeight = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaType":
			        this.MediaType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaWidth":
			        this.MediaWidth = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionA":
			        this.OptionA = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionB":
			        this.OptionB = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionC":
			        this.OptionC = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionD":
			        this.OptionD = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionE":
			        this.OptionE = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionF":
			        this.OptionF = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionG":
			        this.OptionG = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionH":
			        this.OptionH = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionType":
			        this.OptionType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question":
			        this.Question = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionId":
			        this.QuestionId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "MediaContent":
			        this.MediaContent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "FalseCount":
			        this.FalseCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TrueCount":
			        this.TrueCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WrongRate":
			        this.WrongRate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SourceFile":
			        this.SourceFile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sourceid":
			        this.Sourceid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SourceZhangjie":
			        this.SourceZhangjie = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Optionnum":
			        this.Optionnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Area":
			        this.Area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggUp":
			        this.DiggUp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggDown":
			        this.DiggDown = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsRepeatTf":
			        this.IsRepeatTf = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamType":
			        this.ExamType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Analysis":
			        this.Analysis = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "LinkExam":
			        this.LinkExam = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OrderId":
			        this.OrderId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher":
			        this.Teacher = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Knowledge":
			        this.Knowledge = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YearId":
			        this.YearId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperShortName":
			        this.PaperShortName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OptionStr":
			        this.OptionStr = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AnswerABC":
			        this.AnswerABC = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KaoDian":
			        this.KaoDian = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score":
			        this.Score = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionIndex":
			        this.QuestionIndex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Test_id":
			        this.Test_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_ids":
			        this.Category_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_names":
			        this.Category_names = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question_imgs":
			        this.Question_imgs = Convert.ToString(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Answer":
					return answer_initialized;
				
				case "ChapterId":
					return chapterid_initialized;
				
				case "ChapterName":
					return chaptername_initialized;
				
				case "Difficulty":
					return difficulty_initialized;
				
				case "Explain":
					return explain_initialized;
				
				case "Label":
					return label_initialized;
				
				case "MediaHeight":
					return mediaheight_initialized;
				
				case "MediaType":
					return mediatype_initialized;
				
				case "MediaWidth":
					return mediawidth_initialized;
				
				case "OptionA":
					return optiona_initialized;
				
				case "OptionB":
					return optionb_initialized;
				
				case "OptionC":
					return optionc_initialized;
				
				case "OptionD":
					return optiond_initialized;
				
				case "OptionE":
					return optione_initialized;
				
				case "OptionF":
					return optionf_initialized;
				
				case "OptionG":
					return optiong_initialized;
				
				case "OptionH":
					return optionh_initialized;
				
				case "OptionType":
					return optiontype_initialized;
				
				case "Question":
					return question_initialized;
				
				case "QuestionId":
					return questionid_initialized;
				
				case "MediaContent":
					return mediacontent_initialized;
				
				case "FalseCount":
					return falsecount_initialized;
				
				case "TrueCount":
					return truecount_initialized;
				
				case "WrongRate":
					return wrongrate_initialized;
				
				case "SourceFile":
					return sourcefile_initialized;
				
				case "Sourceid":
					return sourceid_initialized;
				
				case "SourceZhangjie":
					return sourcezhangjie_initialized;
				
				case "Optionnum":
					return optionnum_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "Url":
					return url_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "Area":
					return area_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "DiggUp":
					return diggup_initialized;
				
				case "DiggDown":
					return diggdown_initialized;
				
				case "IsRepeatTf":
					return isrepeattf_initialized;
				
				case "ExamType":
					return examtype_initialized;
				
				case "Analysis":
					return analysis_initialized;
				
				case "LinkExam":
					return linkexam_initialized;
				
				case "OrderId":
					return orderid_initialized;
				
				case "Teacher":
					return teacher_initialized;
				
				case "Knowledge":
					return knowledge_initialized;
				
				case "YearId":
					return yearid_initialized;
				
				case "PaperShortName":
					return papershortname_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "OptionStr":
					return optionstr_initialized;
				
				case "AnswerABC":
					return answerabc_initialized;
				
				case "KaoDian":
					return kaodian_initialized;
				
				case "Score":
					return score_initialized;
				
				case "QuestionIndex":
					return questionindex_initialized;
				
				case "Test_id":
					return test_id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Category_ids":
					return category_ids_initialized;
				
				case "Category_names":
					return category_names_initialized;
				
				case "Question_imgs":
					return question_imgs_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "ChapterId":
					chapterid_initialized = ret;
					return true;
				
				case "ChapterName":
					chaptername_initialized = ret;
					return true;
				
				case "Difficulty":
					difficulty_initialized = ret;
					return true;
				
				case "Explain":
					explain_initialized = ret;
					return true;
				
				case "Label":
					label_initialized = ret;
					return true;
				
				case "MediaHeight":
					mediaheight_initialized = ret;
					return true;
				
				case "MediaType":
					mediatype_initialized = ret;
					return true;
				
				case "MediaWidth":
					mediawidth_initialized = ret;
					return true;
				
				case "OptionA":
					optiona_initialized = ret;
					return true;
				
				case "OptionB":
					optionb_initialized = ret;
					return true;
				
				case "OptionC":
					optionc_initialized = ret;
					return true;
				
				case "OptionD":
					optiond_initialized = ret;
					return true;
				
				case "OptionE":
					optione_initialized = ret;
					return true;
				
				case "OptionF":
					optionf_initialized = ret;
					return true;
				
				case "OptionG":
					optiong_initialized = ret;
					return true;
				
				case "OptionH":
					optionh_initialized = ret;
					return true;
				
				case "OptionType":
					optiontype_initialized = ret;
					return true;
				
				case "Question":
					question_initialized = ret;
					return true;
				
				case "QuestionId":
					questionid_initialized = ret;
					return true;
				
				case "MediaContent":
					mediacontent_initialized = ret;
					return true;
				
				case "FalseCount":
					falsecount_initialized = ret;
					return true;
				
				case "TrueCount":
					truecount_initialized = ret;
					return true;
				
				case "WrongRate":
					wrongrate_initialized = ret;
					return true;
				
				case "SourceFile":
					sourcefile_initialized = ret;
					return true;
				
				case "Sourceid":
					sourceid_initialized = ret;
					return true;
				
				case "SourceZhangjie":
					sourcezhangjie_initialized = ret;
					return true;
				
				case "Optionnum":
					optionnum_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "Area":
					area_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "DiggUp":
					diggup_initialized = ret;
					return true;
				
				case "DiggDown":
					diggdown_initialized = ret;
					return true;
				
				case "IsRepeatTf":
					isrepeattf_initialized = ret;
					return true;
				
				case "ExamType":
					examtype_initialized = ret;
					return true;
				
				case "Analysis":
					analysis_initialized = ret;
					return true;
				
				case "LinkExam":
					linkexam_initialized = ret;
					return true;
				
				case "OrderId":
					orderid_initialized = ret;
					return true;
				
				case "Teacher":
					teacher_initialized = ret;
					return true;
				
				case "Knowledge":
					knowledge_initialized = ret;
					return true;
				
				case "YearId":
					yearid_initialized = ret;
					return true;
				
				case "PaperShortName":
					papershortname_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "OptionStr":
					optionstr_initialized = ret;
					return true;
				
				case "AnswerABC":
					answerabc_initialized = ret;
					return true;
				
				case "KaoDian":
					kaodian_initialized = ret;
					return true;
				
				case "Score":
					score_initialized = ret;
					return true;
				
				case "QuestionIndex":
					questionindex_initialized = ret;
					return true;
				
				case "Test_id":
					test_id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Category_ids":
					category_ids_initialized = ret;
					return true;
				
				case "Category_names":
					category_names_initialized = ret;
					return true;
				
				case "Question_imgs":
					question_imgs_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (chapterid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.ChapterId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterId);
                }
			}
			
			if (chaptername_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.ChapterName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterName);
                }
			}
			
			if (difficulty_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Difficulty;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Difficulty);
                }
			}
			
			if (explain_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Explain;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Explain);
                }
			}
			
			if (label_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Label;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Label);
                }
			}
			
			if (mediaheight_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.MediaHeight;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaHeight);
                }
			}
			
			if (mediatype_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.MediaType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaType);
                }
			}
			
			if (mediawidth_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.MediaWidth;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaWidth);
                }
			}
			
			if (optiona_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionA;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionA);
                }
			}
			
			if (optionb_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionB;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionB);
                }
			}
			
			if (optionc_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionC);
                }
			}
			
			if (optiond_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionD;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionD);
                }
			}
			
			if (optione_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionE;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionE);
                }
			}
			
			if (optionf_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionF;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionF);
                }
			}
			
			if (optiong_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionG;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionG);
                }
			}
			
			if (optionh_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionH;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionH);
                }
			}
			
			if (optiontype_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionType);
                }
			}
			
			if (question_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Question;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question);
                }
			}
			
			if (questionid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.QuestionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionId);
                }
			}
			
			if (mediacontent_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.MediaContent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaContent);
                }
			}
			
			if (falsecount_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.FalseCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FalseCount);
                }
			}
			
			if (truecount_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.TrueCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TrueCount);
                }
			}
			
			if (wrongrate_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.WrongRate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WrongRate);
                }
			}
			
			if (sourcefile_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.SourceFile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceFile);
                }
			}
			
			if (sourceid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Sourceid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sourceid);
                }
			}
			
			if (sourcezhangjie_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.SourceZhangjie;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceZhangjie);
                }
			}
			
			if (optionnum_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Optionnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Optionnum);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (area_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Area);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (diggup_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.DiggUp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggUp);
                }
			}
			
			if (diggdown_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.DiggDown;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggDown);
                }
			}
			
			if (isrepeattf_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.IsRepeatTf;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsRepeatTf);
                }
			}
			
			if (examtype_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.ExamType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamType);
                }
			}
			
			if (analysis_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Analysis;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Analysis);
                }
			}
			
			if (linkexam_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.LinkExam;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(LinkExam);
                }
			}
			
			if (orderid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OrderId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OrderId);
                }
			}
			
			if (teacher_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Teacher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher);
                }
			}
			
			if (knowledge_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Knowledge;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge);
                }
			}
			
			if (yearid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.YearId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YearId);
                }
			}
			
			if (papershortname_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.PaperShortName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperShortName);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (optionstr_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.OptionStr;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionStr);
                }
			}
			
			if (answerabc_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.AnswerABC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerABC);
                }
			}
			
			if (kaodian_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.KaoDian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KaoDian);
                }
			}
			
			if (score_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Score;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score);
                }
			}
			
			if (questionindex_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.QuestionIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionIndex);
                }
			}
			
			if (test_id_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Test_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Test_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (category_ids_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Category_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_ids);
                }
			}
			
			if (category_names_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Category_names;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_names);
                }
			}
			
			if (question_imgs_initialized)
			{
                AttributeItem attr = Xt_TimuDaXue.Attribute.Question_imgs;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_imgs);
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
        public class Xt_TimuDaXueJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterId { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterName { get; set; }
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public string Difficulty { get; set; }
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public string Explain { get; set; }
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public string Label { get; set; }
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public string MediaHeight { get; set; }
            
            /// <summary>媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]</summary>
            public string MediaType { get; set; }
            
            /// <summary>媒体宽度:[CtrlTypeDic-{InputString}]</summary>
            public string MediaWidth { get; set; }
            
            /// <summary>A:[CtrlTypeDic-{InputString}]</summary>
            public string OptionA { get; set; }
            
            /// <summary>B:[CtrlTypeDic-{InputString}]</summary>
            public string OptionB { get; set; }
            
            /// <summary>C:[CtrlTypeDic-{InputString}]</summary>
            public string OptionC { get; set; }
            
            /// <summary>D:[CtrlTypeDic-{InputString}]</summary>
            public string OptionD { get; set; }
            
            /// <summary>E:[CtrlTypeDic-{InputString}]</summary>
            public string OptionE { get; set; }
            
            /// <summary>F:[CtrlTypeDic-{InputString}]</summary>
            public string OptionF { get; set; }
            
            /// <summary>G:[CtrlTypeDic-{InputString}]</summary>
            public string OptionG { get; set; }
            
            /// <summary>H:[CtrlTypeDic-{InputString}]</summary>
            public string OptionH { get; set; }
            
            /// <summary>题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]</summary>
            public string OptionType { get; set; }
            
            /// <summary>题目:[CtrlTypeDic-{HTML}]</summary>
            public string Question { get; set; }
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public int QuestionId { get; set; }
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public string MediaContent { get; set; }
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public string FalseCount { get; set; }
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public string TrueCount { get; set; }
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public string WrongRate { get; set; }
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public string SourceFile { get; set; }
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public string Sourceid { get; set; }
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public string SourceZhangjie { get; set; }
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public string Optionnum { get; set; }
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>源大学微信号:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>地区:[CtrlTypeDic-{InputString}]</summary>
            public string Area { get; set; }
            
            /// <summary>用户Id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>好评:[CtrlTypeDic-{InputString}]</summary>
            public string DiggUp { get; set; }
            
            /// <summary>差评:[CtrlTypeDic-{InputString}]</summary>
            public string DiggDown { get; set; }
            
            /// <summary>是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public string IsRepeatTf { get; set; }
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public string ExamType { get; set; }
            
            /// <summary>考题分析:[CtrlTypeDic-{InputString}]</summary>
            public string Analysis { get; set; }
            
            /// <summary>大题题号:[CtrlTypeDic-{InputString}]</summary>
            public string LinkExam { get; set; }
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public string OrderId { get; set; }
            
            /// <summary>出题老师:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher { get; set; }
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge { get; set; }
            
            /// <summary>试卷年份:[CtrlTypeDic-{InputString}]</summary>
            public string YearId { get; set; }
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public string PaperShortName { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
            /// <summary>选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]</summary>
            public string OptionStr { get; set; }
            
            /// <summary>学生提交的纠错答案:[CtrlTypeDic-{InputString}]</summary>
            public string AnswerABC { get; set; }
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public string KaoDian { get; set; }
            
            /// <summary>分值:[CtrlTypeDic-{InputString}]</summary>
            public string Score { get; set; }
            
            /// <summary>题目顺序号:[CtrlTypeDic-{InputString}]</summary>
            public int QuestionIndex { get; set; }
            
            /// <summary>(survey_id):[CtrlTypeDic-{InputString}]</summary>
            public string Test_id { get; set; }
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public string Category_ids { get; set; }
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public string Category_names { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Question_imgs { get; set; }
        }
        #endregion
    }
}