using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class BLL233
    {
        public St_TiMu233 GetTiMu233Cond(St_TTimuDaXue valObj2)
        {
            St_TiMu233 valObj = new St_TiMu233();
            if (valObj2.KemuId!=0)
            {
                valObj.ClassId = Convert.ToString(valObj2.KemuId);//
            }
            if (!String.IsNullOrEmpty(valObj2._Sourceid))//试卷id
            {
                valObj.PaperId = (valObj2._Sourceid);//
            }
            if (!String.IsNullOrEmpty(valObj2.OptionType))
            {
                valObj.ExamType = get233OptionType(valObj2.OptionType);//
            }
            return valObj;
        }
        public St_TTimuDaXue GetTTimuDaXue(St_TiMu233 valObj2)
        {
            St_TTimuDaXue valObj = new St_TTimuDaXue();
            valObj.Id = Convert.ToInt32(valObj2.ExamId);//Convert.ToString(valObj2.Id);
            valObj.QuestionId = Convert.ToInt32(valObj2.OrderId);
            //valObj.PaperInfo = valObj2.PaperInfo;
            //valObj.IsRepeatTf = valObj2.IsRepeatTf;

            //1单选，2多选，3不定项选择题，4判断题，7简答题=计算分析题
            valObj.Answer = valObj2.Answer.Replace("A", "1").Replace("B", "2").Replace("C", "3").Replace("D", "4");
            if (valObj.Answer == valObj2.Answer)
                valObj.Answer = valObj2.Answer.Replace("0", "1").Replace("1", "2").Replace("2", "3").Replace("3", "4").Replace("4", "5")
                    .Replace("5", "6").Replace("6", "7").Replace("7", "8").Replace("8", "9");
            
            //Analysis
            valObj.Explain = valObj2.Analysis;
            //valObj.UserDeNumStats = valObj2.UserDeNumStats;
            valObj.Question = valObj2.Content;
            
            valObj.OptionType = getDaxueOptionType(valObj2.ExamType);//
           // valObj.SelectNum = valObj2.SelectNum;
            valObj.LinkExam = valObj2.LinkExam;
            valObj.OrderId = valObj2.OrderId;
            //valObj.RulesId = valObj2.RulesId;
            valObj.DiggUp = valObj2.DiggUp;
            valObj.DiggDown = valObj2.DiggDown;
            //valObj.Weight = valObj2.Weight;
            //valObj.DeNums = valObj2.DeNums;
            //valObj.UserDeNum = valObj2.UserDeNum;
            //valObj.DiscussCount = valObj2.DiscussCount;
            //valObj.ExamDiscussCount = valObj2.ExamDiscussCount;
            //valObj.AnswerDiscussCount = valObj2.AnswerDiscussCount;
            //valObj.VedioDiscussCount = valObj2.VedioDiscussCount;
            //valObj.MyDiscussCount = valObj2.MyDiscussCount;
            //valObj.ExpanddoExamNum = valObj2.ExpanddoExamNum;
            //valObj.ExpandPercent = valObj2.ExpandPercent;
            //valObj.FavNum = valObj2.FavNum;
            //valObj.IsFavorites = valObj2.IsFavorites;
            //valObj.FavInfo = valObj2.FavInfo;

            //valObj.Question = valObj2.Question;
            //valObj.QuestionCount = valObj2.QuestionCount;
            valObj.Teacher = valObj2.Teacher;
            valObj.Knowledge = valObj2.Knowledge;
            //valObj.ExamNewStats = valObj2.ExamNewStats;
            //valObj.RightOrWrong = valObj2.RightOrWrong;
            //valObj.NewestNote = valObj2.NewestNote;
            //valObj.Md5 = valObj2.Md5;
            valObj.OptionStr = valObj2.OptionList;

            ////这里的问题要解决
            valObj._Sourceid = valObj2.SubQuestion;

            valObj.KemuId = Convert.ToInt32(valObj2.ClassId);
            valObj.Sourceid = valObj2.PaperId;
            valObj.SourceFile = valObj2.PaperName;            
            //valObj.ClassName = valObj2.ClassName;
            valObj._SourceZhangjie = valObj2.PaperShortName;
            
            //历年真题；type=1，
            valObj._ExamType = (valObj2.Type1 == "1") ? "历年真题" : "模拟卷";

            valObj.YearId = valObj2.YearId;
            //valObj.TypeIdUrl = valObj2.TypeIdUrl;
            valObj.Url = valObj2.Url;
            //valObj.Answer123 = valObj2.Answer123;
            //valObj.AnswerABC = valObj2.AnswerABC;

            return valObj;
        }

        //public St_TiMu233 GetTiMu233(St_TTimuDaXue valObj2)
        //{
        //    St_TiMu233 valObj = new St_TiMu233();
        //    valObj.Id = valObj2.Id;
        //    valObj.ExamId = valObj2.ExamId;
        //    valObj.PaperInfo = valObj2.PaperInfo;
        //    valObj.IsRepeatTf = valObj2.IsRepeatTf;
        //    valObj.Answer = valObj2.Answer;
        //    valObj.Analysis = valObj2.Analysis;
        //    valObj.UserDeNumStats = valObj2.UserDeNumStats;
        //    valObj.Content = valObj2.Content;
        //    valObj.ExamType = valObj2.ExamType;
        //    valObj.SelectNum = valObj2.SelectNum;
        //    valObj.LinkExam = valObj2.LinkExam;
        //    valObj.OrderId = valObj2.OrderId;
        //    valObj.RulesId = valObj2.RulesId;
        //    valObj.DiggUp = valObj2.DiggUp;
        //    valObj.DiggDown = valObj2.DiggDown;
        //    valObj.Weight = valObj2.Weight;
        //    valObj.DeNums = valObj2.DeNums;
        //    valObj.UserDeNum = valObj2.UserDeNum;
        //    valObj.DiscussCount = valObj2.DiscussCount;
        //    valObj.ExamDiscussCount = valObj2.ExamDiscussCount;
        //    valObj.AnswerDiscussCount = valObj2.AnswerDiscussCount;
        //    valObj.VedioDiscussCount = valObj2.VedioDiscussCount;
        //    valObj.MyDiscussCount = valObj2.MyDiscussCount;
        //    valObj.ExpanddoExamNum = valObj2.ExpanddoExamNum;
        //    valObj.ExpandPercent = valObj2.ExpandPercent;
        //    valObj.FavNum = valObj2.FavNum;
        //    valObj.IsFavorites = valObj2.IsFavorites;
        //    valObj.FavInfo = valObj2.FavInfo;
        //    valObj.Question = valObj2.Question;
        //    valObj.QuestionCount = valObj2.QuestionCount;
        //    valObj.Teacher = valObj2.Teacher;
        //    valObj.Knowledge = valObj2.Knowledge;
        //    valObj.ExamNewStats = valObj2.ExamNewStats;
        //    valObj.RightOrWrong = valObj2.RightOrWrong;
        //    valObj.NewestNote = valObj2.NewestNote;
        //    valObj.Md5 = valObj2.Md5;
        //    valObj.OptionList = valObj2.OptionList;
        //    valObj.SubQuestion = valObj2.SubQuestion;
        //    valObj.ClassId = valObj2.ClassId;
        //    valObj.PaperId = valObj2.PaperId;
        //    valObj.PaperName = valObj2.PaperName;
        //    valObj.ClassName = valObj2.ClassName;
        //    valObj.PaperShortName = valObj2.PaperShortName;
        //    valObj.Type1 = valObj2.Type1;
        //    valObj.YearId = valObj2.YearId;
        //    valObj.TypeIdUrl = valObj2.TypeIdUrl;
        //    valObj.Url = valObj2.Url;
        //    valObj.Answer123 = valObj2.Answer123;
        //    valObj.AnswerABC = valObj2.AnswerABC;
        //}

        //1单选，2多选，3不定项选择题，4判断题，7简答题=计算分析题
        public string get233OptionType(string optionType)
        {
            switch (optionType)
            {
                case "0":
                    return "1";
                case "1":
                    return "2";
                case "2":
                    return "4";
                case "3":
                    return "7";
                case "4":
                    return "3";
            }
            return "";
        }

        //1单选，2多选，3不定项选择题，4判断题，7简答题=计算分析题
        public string getDaxueOptionType(string optionType233)
        {
            switch (optionType233)
            {
                case "1":
                    return "0";
                case "2":
                    return "1";
                case "4":
                    return "2";
                case "7":
                    return "3";
                case "3":
                    return "4";
            }
            return "";
        }
    }