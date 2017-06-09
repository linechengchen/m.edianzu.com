/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    数据表St_TiMuJiaoKao对应的业务逻辑层St_TiMuJiaoKao
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TiMuJiaoKao_Entity:St_TiMuJiaoKao
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Answer,Answer123,AnswerABC,AutoId,ChapterId,Difficulty,Explain,FalseCount,Kemu,Label,MediaContent,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,Optionnum,OptionType,Question,QuestionId,SourceFile,Sourceid,SourceZhangjie,TrueCount,Url,WrongRate from St_TiMuJiaoKao
delete from St_TiMuJiaoKao
INSERT INTO St_TiMuJiaoKao (Id,Answer,Answer123,AnswerABC,AutoId,ChapterId,Difficulty,Explain,FalseCount,Kemu,Label,MediaContent,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,Optionnum,OptionType,Question,QuestionId,SourceFile,Sourceid,SourceZhangjie,TrueCount,Url,WrongRate)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE St_TiMuJiaoKao SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Answer = valObj2.Answer;
        valObj.Answer123 = valObj2.Answer123;
        valObj.AnswerABC = valObj2.AnswerABC;
        valObj.AutoId = valObj2.AutoId;
        valObj.ChapterId = valObj2.ChapterId;
        valObj.Difficulty = valObj2.Difficulty;
        valObj.Explain = valObj2.Explain;
        valObj.FalseCount = valObj2.FalseCount;
        valObj.Kemu = valObj2.Kemu;
        valObj.Label = valObj2.Label;
        valObj.MediaContent = valObj2.MediaContent;
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
        valObj.Optionnum = valObj2.Optionnum;
        valObj.OptionType = valObj2.OptionType;
        valObj.Question = valObj2.Question;
        valObj.QuestionId = valObj2.QuestionId;
        valObj.SourceFile = valObj2.SourceFile;
        valObj.Sourceid = valObj2.Sourceid;
        valObj.SourceZhangjie = valObj2.SourceZhangjie;
        valObj.TrueCount = valObj2.TrueCount;
        valObj.Url = valObj2.Url;
        valObj.WrongRate = valObj2.WrongRate; 
        valObj.Id = "";
        valObj.Answer = "";
        valObj.Answer123 = "";
        valObj.AnswerABC = "";
        valObj.AutoId = "";
        valObj.ChapterId = "";
        valObj.Difficulty = "";
        valObj.Explain = "";
        valObj.FalseCount = "";
        valObj.Kemu = "";
        valObj.Label = "";
        valObj.MediaContent = "";
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
        valObj.Optionnum = "";
        valObj.OptionType = "";
        valObj.Question = "";
        valObj.QuestionId = "";
        valObj.SourceFile = "";
        valObj.Sourceid = "";
        valObj.SourceZhangjie = "";
        valObj.TrueCount = "";
        valObj.Url = "";
        valObj.WrongRate = ""; 
        "Id": $("#txt_Id").val(),
        "Answer": $("#txt_Answer").val(),
        "Answer123": $("#txt_Answer123").val(),
        "AnswerABC": $("#txt_AnswerABC").val(),
        "AutoId": $("#txt_AutoId").val(),
        "ChapterId": $("#txt_ChapterId").val(),
        "Difficulty": $("#txt_Difficulty").val(),
        "Explain": $("#txt_Explain").val(),
        "FalseCount": $("#txt_FalseCount").val(),
        "Kemu": $("#txt_Kemu").val(),
        "Label": $("#txt_Label").val(),
        "MediaContent": $("#txt_MediaContent").val(),
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
        "Optionnum": $("#txt_Optionnum").val(),
        "OptionType": $("#txt_OptionType").val(),
        "Question": $("#txt_Question").val(),
        "QuestionId": $("#txt_QuestionId").val(),
        "SourceFile": $("#txt_SourceFile").val(),
        "Sourceid": $("#txt_Sourceid").val(),
        "SourceZhangjie": $("#txt_SourceZhangjie").val(),
        "TrueCount": $("#txt_TrueCount").val(),
        "Url": $("#txt_Url").val(),
        "WrongRate": $("#txt_WrongRate").val(), 
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
    /// <para>驾考题库</para>
    /// <para>与St_TiMuJiaoKao数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TiMuJiaoKao : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TiMuJiaoKao Factory()
        {
            return new St_TiMuJiaoKao();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public string _Id
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
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterId
        {            
            get { return this.ChapterId; }
            set { this.ChapterId = value; }
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
        
        /// <summary> 错误次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _FalseCount
        {            
            get { return this.FalseCount; }
            set { this.FalseCount = value; }
        }
        
        /// <summary> 科目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> 章节:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Label
        {            
            get { return this.Label; }
            set { this.Label = value; }
        }
        
        /// <summary> 媒体内容:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaContent
        {            
            get { return this.MediaContent; }
            set { this.MediaContent = value; }
        }
        
        /// <summary> 媒体高度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaHeight
        {            
            get { return this.MediaHeight; }
            set { this.MediaHeight = value; }
        }
        
        /// <summary> 媒体类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
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
        
        /// <summary> 多选题答案个数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Optionnum
        {            
            get { return this.Optionnum; }
            set { this.Optionnum = value; }
        }
        
        /// <summary> 选项类型1为4选项，2为2选项:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionType
        {            
            get { return this.OptionType; }
            set { this.OptionType = value; }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Question
        {            
            get { return this.Question; }
            set { this.Question = value; }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QuestionId
        {            
            get { return this.QuestionId; }
            set { this.QuestionId = value; }
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
        
        /// <summary> 正确次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TrueCount
        {            
            get { return this.TrueCount; }
            set { this.TrueCount = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary> 错误率:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WrongRate
        {            
            get { return this.WrongRate; }
            set { this.WrongRate = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 媒体类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 选项类型1为4选项，2为2选项:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string QuestionId
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TiMuJiaoKao].[Id]", typeof(string), 20, default(string));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[St_TiMuJiaoKao].[Answer]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer123 =  new AttributeItem("[St_TiMuJiaoKao].[Answer123]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerABC =  new AttributeItem("[St_TiMuJiaoKao].[AnswerABC]", typeof(string), 50, default(string));
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TiMuJiaoKao].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterId =  new AttributeItem("[St_TiMuJiaoKao].[ChapterId]", typeof(string), 200, default(string));
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Difficulty =  new AttributeItem("[St_TiMuJiaoKao].[Difficulty]", typeof(string), 200, default(string));
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Explain =  new AttributeItem("[St_TiMuJiaoKao].[Explain]", typeof(string), 2000, default(string));
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FalseCount =  new AttributeItem("[St_TiMuJiaoKao].[FalseCount]", typeof(string), 200, default(string));
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[St_TiMuJiaoKao].[Kemu]", typeof(string), 200, default(string));
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Label =  new AttributeItem("[St_TiMuJiaoKao].[Label]", typeof(string), 200, default(string));
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaContent =  new AttributeItem("[St_TiMuJiaoKao].[MediaContent]", typeof(string), 200, default(string));
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaHeight =  new AttributeItem("[St_TiMuJiaoKao].[MediaHeight]", typeof(string), 200, default(string));
            
            /// <summary>媒体类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaType =  new AttributeItem("[St_TiMuJiaoKao].[MediaType]", typeof(string), 200, default(string));
            
            /// <summary>媒体宽度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaWidth =  new AttributeItem("[St_TiMuJiaoKao].[MediaWidth]", typeof(string), 200, default(string));
            
            /// <summary>A:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionA =  new AttributeItem("[St_TiMuJiaoKao].[OptionA]", typeof(string), 200, default(string));
            
            /// <summary>B:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionB =  new AttributeItem("[St_TiMuJiaoKao].[OptionB]", typeof(string), 200, default(string));
            
            /// <summary>C:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionC =  new AttributeItem("[St_TiMuJiaoKao].[OptionC]", typeof(string), 200, default(string));
            
            /// <summary>D:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionD =  new AttributeItem("[St_TiMuJiaoKao].[OptionD]", typeof(string), 200, default(string));
            
            /// <summary>E:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionE =  new AttributeItem("[St_TiMuJiaoKao].[OptionE]", typeof(string), 200, default(string));
            
            /// <summary>F:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionF =  new AttributeItem("[St_TiMuJiaoKao].[OptionF]", typeof(string), 200, default(string));
            
            /// <summary>G:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionG =  new AttributeItem("[St_TiMuJiaoKao].[OptionG]", typeof(string), 200, default(string));
            
            /// <summary>H:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionH =  new AttributeItem("[St_TiMuJiaoKao].[OptionH]", typeof(string), 200, default(string));
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Optionnum =  new AttributeItem("[St_TiMuJiaoKao].[Optionnum]", typeof(string), 200, default(string));
            
            /// <summary>选项类型1为4选项，2为2选项:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionType =  new AttributeItem("[St_TiMuJiaoKao].[OptionType]", typeof(string), 200, default(string));
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question =  new AttributeItem("[St_TiMuJiaoKao].[Question]", typeof(string), 200, default(string));
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionId =  new AttributeItem("[St_TiMuJiaoKao].[QuestionId]", typeof(string), 200, default(string));
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceFile =  new AttributeItem("[St_TiMuJiaoKao].[SourceFile]", typeof(string), 200, default(string));
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sourceid =  new AttributeItem("[St_TiMuJiaoKao].[Sourceid]", typeof(string), 200, default(string));
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceZhangjie =  new AttributeItem("[St_TiMuJiaoKao].[SourceZhangjie]", typeof(string), 200, default(string));
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TrueCount =  new AttributeItem("[St_TiMuJiaoKao].[TrueCount]", typeof(string), 200, default(string));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[St_TiMuJiaoKao].[Url]", typeof(string), 200, default(string));
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WrongRate =  new AttributeItem("[St_TiMuJiaoKao].[WrongRate]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private string m_answer123;
        /// <summary></summary>
        protected bool answer123_initialized = false;
        
        private string m_answerabc;
        /// <summary></summary>
        protected bool answerabc_initialized = false;
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_chapterid;
        /// <summary></summary>
        protected bool chapterid_initialized = false;
        
        private string m_difficulty;
        /// <summary></summary>
        protected bool difficulty_initialized = false;
        
        private string m_explain;
        /// <summary></summary>
        protected bool explain_initialized = false;
        
        private string m_falsecount;
        /// <summary></summary>
        protected bool falsecount_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private string m_label;
        /// <summary></summary>
        protected bool label_initialized = false;
        
        private string m_mediacontent;
        /// <summary></summary>
        protected bool mediacontent_initialized = false;
        
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
        
        private string m_optionnum;
        /// <summary></summary>
        protected bool optionnum_initialized = false;
        
        private string m_optiontype;
        /// <summary></summary>
        protected bool optiontype_initialized = false;
        
        private string m_question;
        /// <summary></summary>
        protected bool question_initialized = false;
        
        private string m_questionid;
        /// <summary></summary>
        protected bool questionid_initialized = false;
        
        private string m_sourcefile;
        /// <summary></summary>
        protected bool sourcefile_initialized = false;
        
        private string m_sourceid;
        /// <summary></summary>
        protected bool sourceid_initialized = false;
        
        private string m_sourcezhangjie;
        /// <summary></summary>
        protected bool sourcezhangjie_initialized = false;
        
        private string m_truecount;
        /// <summary></summary>
        protected bool truecount_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private string m_wrongrate;
        /// <summary></summary>
        protected bool wrongrate_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TiMuJiaoKao";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.answer123_initialized = IsLoadAllAttributes;this.answerabc_initialized = IsLoadAllAttributes;this.autoid_initialized = IsLoadAllAttributes;this.chapterid_initialized = IsLoadAllAttributes;this.difficulty_initialized = IsLoadAllAttributes;this.explain_initialized = IsLoadAllAttributes;this.falsecount_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.label_initialized = IsLoadAllAttributes;this.mediacontent_initialized = IsLoadAllAttributes;this.mediaheight_initialized = IsLoadAllAttributes;this.mediatype_initialized = IsLoadAllAttributes;this.mediawidth_initialized = IsLoadAllAttributes;this.optiona_initialized = IsLoadAllAttributes;this.optionb_initialized = IsLoadAllAttributes;this.optionc_initialized = IsLoadAllAttributes;this.optiond_initialized = IsLoadAllAttributes;this.optione_initialized = IsLoadAllAttributes;this.optionf_initialized = IsLoadAllAttributes;this.optiong_initialized = IsLoadAllAttributes;this.optionh_initialized = IsLoadAllAttributes;this.optionnum_initialized = IsLoadAllAttributes;this.optiontype_initialized = IsLoadAllAttributes;this.question_initialized = IsLoadAllAttributes;this.questionid_initialized = IsLoadAllAttributes;this.sourcefile_initialized = IsLoadAllAttributes;this.sourceid_initialized = IsLoadAllAttributes;this.sourcezhangjie_initialized = IsLoadAllAttributes;this.truecount_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.wrongrate_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TiMuJiaoKao value = new St_TiMuJiaoKao();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer123"))
				value.answer123_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerABC"))
				value.answerabc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterId"))
				value.chapterid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Difficulty"))
				value.difficulty_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Explain"))
				value.explain_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FalseCount"))
				value.falsecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Label"))
				value.label_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaContent"))
				value.mediacontent_initialized = true;
            
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
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Optionnum"))
				value.optionnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionType"))
				value.optiontype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question"))
				value.question_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionId"))
				value.questionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceFile"))
				value.sourcefile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sourceid"))
				value.sourceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceZhangjie"))
				value.sourcezhangjie_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TrueCount"))
				value.truecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WrongRate"))
				value.wrongrate_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TiMuJiaoKao Clone()
        {
            return (St_TiMuJiaoKao)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TiMuJiaoKao()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TiMuJiaoKao() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TiMuJiaoKao(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TiMuJiaoKao(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TiMuJiaoKao(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TiMuJiaoKao(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TiMuJiaoKao(string id1, string answer1, string answer1231, string answerabc1, int autoid1, string chapterid1, string difficulty1, string explain1, string falsecount1, string kemu1, string label1, string mediacontent1, string mediaheight1, string mediatype1, string mediawidth1, string optiona1, string optionb1, string optionc1, string optiond1, string optione1, string optionf1, string optiong1, string optionh1, string optionnum1, string optiontype1, string question1, string questionid1, string sourcefile1, string sourceid1, string sourcezhangjie1, string truecount1, string url1, string wrongrate1)
        {
            
            this.Id = id1;
            
            this.Answer = answer1;
            
            this.Answer123 = answer1231;
            
            this.AnswerABC = answerabc1;
            
            this.AutoId = autoid1;
            
            this.ChapterId = chapterid1;
            
            this.Difficulty = difficulty1;
            
            this.Explain = explain1;
            
            this.FalseCount = falsecount1;
            
            this.Kemu = kemu1;
            
            this.Label = label1;
            
            this.MediaContent = mediacontent1;
            
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
            
            this.Optionnum = optionnum1;
            
            this.OptionType = optiontype1;
            
            this.Question = question1;
            
            this.QuestionId = questionid1;
            
            this.SourceFile = sourcefile1;
            
            this.Sourceid = sourceid1;
            
            this.SourceZhangjie = sourcezhangjie1;
            
            this.TrueCount = truecount1;
            
            this.Url = url1;
            
            this.WrongRate = wrongrate1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TiMuJiaoKao FromIView(IView view)
        {
            return (St_TiMuJiaoKao)IView.GetITable(view, "St_TiMuJiaoKao");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TiMuJiaoKao GetOneInstance()
        {
            St_TiMuJiaoKao value = new St_TiMuJiaoKao();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TiMuJiaoKao Retrieve()
        {
            BLLTable<St_TiMuJiaoKao>.GetRowData(this);
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
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "Answer123":
			        return Answer123;
			    			
			    case "AnswerABC":
			        return AnswerABC;
			    			
			    case "AutoId":
			        return AutoId;
			    			
			    case "ChapterId":
			        return ChapterId;
			    			
			    case "Difficulty":
			        return Difficulty;
			    			
			    case "Explain":
			        return Explain;
			    			
			    case "FalseCount":
			        return FalseCount;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "Label":
			        return Label;
			    			
			    case "MediaContent":
			        return MediaContent;
			    			
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
			    			
			    case "Optionnum":
			        return Optionnum;
			    			
			    case "OptionType":
			        return OptionType;
			    			
			    case "Question":
			        return Question;
			    			
			    case "QuestionId":
			        return QuestionId;
			    			
			    case "SourceFile":
			        return SourceFile;
			    			
			    case "Sourceid":
			        return Sourceid;
			    			
			    case "SourceZhangjie":
			        return SourceZhangjie;
			    			
			    case "TrueCount":
			        return TrueCount;
			    			
			    case "Url":
			        return Url;
			    			
			    case "WrongRate":
			        return WrongRate;
			
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
			        this.Id = Convert.ToString(AttributeValue);
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
			    			
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ChapterId":
			        this.ChapterId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Difficulty":
			        this.Difficulty = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Explain":
			        this.Explain = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "FalseCount":
			        this.FalseCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Label":
			        this.Label = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaContent":
			        this.MediaContent = Convert.ToString(AttributeValue);
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
			    			
			    case "Optionnum":
			        this.Optionnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionType":
			        this.OptionType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question":
			        this.Question = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionId":
			        this.QuestionId = Convert.ToString(AttributeValue);
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
			    			
			    case "TrueCount":
			        this.TrueCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WrongRate":
			        this.WrongRate = Convert.ToString(AttributeValue);
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
				
				case "Answer":
					return answer_initialized;
				
				case "Answer123":
					return answer123_initialized;
				
				case "AnswerABC":
					return answerabc_initialized;
				
				case "AutoId":
					return autoid_initialized;
				
				case "ChapterId":
					return chapterid_initialized;
				
				case "Difficulty":
					return difficulty_initialized;
				
				case "Explain":
					return explain_initialized;
				
				case "FalseCount":
					return falsecount_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "Label":
					return label_initialized;
				
				case "MediaContent":
					return mediacontent_initialized;
				
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
				
				case "Optionnum":
					return optionnum_initialized;
				
				case "OptionType":
					return optiontype_initialized;
				
				case "Question":
					return question_initialized;
				
				case "QuestionId":
					return questionid_initialized;
				
				case "SourceFile":
					return sourcefile_initialized;
				
				case "Sourceid":
					return sourceid_initialized;
				
				case "SourceZhangjie":
					return sourcezhangjie_initialized;
				
				case "TrueCount":
					return truecount_initialized;
				
				case "Url":
					return url_initialized;
				
				case "WrongRate":
					return wrongrate_initialized;
				
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
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "Answer123":
					answer123_initialized = ret;
					return true;
				
				case "AnswerABC":
					answerabc_initialized = ret;
					return true;
				
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "ChapterId":
					chapterid_initialized = ret;
					return true;
				
				case "Difficulty":
					difficulty_initialized = ret;
					return true;
				
				case "Explain":
					explain_initialized = ret;
					return true;
				
				case "FalseCount":
					falsecount_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "Label":
					label_initialized = ret;
					return true;
				
				case "MediaContent":
					mediacontent_initialized = ret;
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
				
				case "Optionnum":
					optionnum_initialized = ret;
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
				
				case "SourceFile":
					sourcefile_initialized = ret;
					return true;
				
				case "Sourceid":
					sourceid_initialized = ret;
					return true;
				
				case "SourceZhangjie":
					sourcezhangjie_initialized = ret;
					return true;
				
				case "TrueCount":
					truecount_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "WrongRate":
					wrongrate_initialized = ret;
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
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (answer123_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Answer123;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer123);
                }
			}
			
			if (answerabc_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.AnswerABC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerABC);
                }
			}
			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (chapterid_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.ChapterId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterId);
                }
			}
			
			if (difficulty_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Difficulty;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Difficulty);
                }
			}
			
			if (explain_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Explain;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Explain);
                }
			}
			
			if (falsecount_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.FalseCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FalseCount);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (label_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Label;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Label);
                }
			}
			
			if (mediacontent_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.MediaContent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaContent);
                }
			}
			
			if (mediaheight_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.MediaHeight;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaHeight);
                }
			}
			
			if (mediatype_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.MediaType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaType);
                }
			}
			
			if (mediawidth_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.MediaWidth;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaWidth);
                }
			}
			
			if (optiona_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionA;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionA);
                }
			}
			
			if (optionb_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionB;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionB);
                }
			}
			
			if (optionc_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionC);
                }
			}
			
			if (optiond_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionD;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionD);
                }
			}
			
			if (optione_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionE;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionE);
                }
			}
			
			if (optionf_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionF;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionF);
                }
			}
			
			if (optiong_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionG;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionG);
                }
			}
			
			if (optionh_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionH;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionH);
                }
			}
			
			if (optionnum_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Optionnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Optionnum);
                }
			}
			
			if (optiontype_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.OptionType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionType);
                }
			}
			
			if (question_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Question;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question);
                }
			}
			
			if (questionid_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.QuestionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionId);
                }
			}
			
			if (sourcefile_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.SourceFile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceFile);
                }
			}
			
			if (sourceid_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Sourceid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sourceid);
                }
			}
			
			if (sourcezhangjie_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.SourceZhangjie;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceZhangjie);
                }
			}
			
			if (truecount_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.TrueCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TrueCount);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (wrongrate_initialized)
			{
                AttributeItem attr = St_TiMuJiaoKao.Attribute.WrongRate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WrongRate);
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
        public class St_TiMuJiaoKaoJson
        {
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Answer123 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string AnswerABC { get; set; }
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterId { get; set; }
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public string Difficulty { get; set; }
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public string Explain { get; set; }
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public string FalseCount { get; set; }
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu { get; set; }
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public string Label { get; set; }
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public string MediaContent { get; set; }
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public string MediaHeight { get; set; }
            
            /// <summary>媒体类型:[CtrlTypeDic-{InputString}]</summary>
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
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public string Optionnum { get; set; }
            
            /// <summary>选项类型1为4选项，2为2选项:[CtrlTypeDic-{InputString}]</summary>
            public string OptionType { get; set; }
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public string Question { get; set; }
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public string QuestionId { get; set; }
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public string SourceFile { get; set; }
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public string Sourceid { get; set; }
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public string SourceZhangjie { get; set; }
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public string TrueCount { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public string WrongRate { get; set; }
        }
        #endregion
    }
}