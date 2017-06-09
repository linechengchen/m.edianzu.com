/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:04
  Description:    数据表Xb_teacher_score对应的业务逻辑层Xb_teacher_score
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_teacher_score_Entity:Xb_teacher_score
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Comment_sum,Fav_sum,Score_sum,Score1,Score2,Score3,Score4,Score5,Score6,Score7,Star_sum,Tags,Teacher_id from Xb_teacher_score
delete from Xb_teacher_score
INSERT INTO Xb_teacher_score (Id,Comment_sum,Fav_sum,Score_sum,Score1,Score2,Score3,Score4,Score5,Score6,Score7,Star_sum,Tags,Teacher_id)
     VALUES
           ('','','','','','','','','','','','','','')
UPDATE Xb_teacher_score SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Comment_sum = valObj2.Comment_sum;
        valObj.Fav_sum = valObj2.Fav_sum;
        valObj.Score_sum = valObj2.Score_sum;
        valObj.Score1 = valObj2.Score1;
        valObj.Score2 = valObj2.Score2;
        valObj.Score3 = valObj2.Score3;
        valObj.Score4 = valObj2.Score4;
        valObj.Score5 = valObj2.Score5;
        valObj.Score6 = valObj2.Score6;
        valObj.Score7 = valObj2.Score7;
        valObj.Star_sum = valObj2.Star_sum;
        valObj.Tags = valObj2.Tags;
        valObj.Teacher_id = valObj2.Teacher_id; 
        valObj.Id = "";
        valObj.Comment_sum = "";
        valObj.Fav_sum = "";
        valObj.Score_sum = "";
        valObj.Score1 = "";
        valObj.Score2 = "";
        valObj.Score3 = "";
        valObj.Score4 = "";
        valObj.Score5 = "";
        valObj.Score6 = "";
        valObj.Score7 = "";
        valObj.Star_sum = "";
        valObj.Tags = "";
        valObj.Teacher_id = ""; 
        "Id": $("#txt_Id").val(),
        "Comment_sum": $("#txt_Comment_sum").val(),
        "Fav_sum": $("#txt_Fav_sum").val(),
        "Score_sum": $("#txt_Score_sum").val(),
        "Score1": $("#txt_Score1").val(),
        "Score2": $("#txt_Score2").val(),
        "Score3": $("#txt_Score3").val(),
        "Score4": $("#txt_Score4").val(),
        "Score5": $("#txt_Score5").val(),
        "Score6": $("#txt_Score6").val(),
        "Score7": $("#txt_Score7").val(),
        "Star_sum": $("#txt_Star_sum").val(),
        "Tags": $("#txt_Tags").val(),
        "Teacher_id": $("#txt_Teacher_id").val(), 
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
    /// <para>与Xb_teacher_score数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_score : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_teacher_score Factory()
        {
            return new Xb_teacher_score();
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
        public int _Comment_sum
        {            
            get { return this.Comment_sum; }
            set { this.Comment_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Fav_sum
        {            
            get { return this.Fav_sum; }
            set { this.Fav_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score_sum
        {            
            get { return this.Score_sum; }
            set { this.Score_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score1
        {            
            get { return this.Score1; }
            set { this.Score1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score2
        {            
            get { return this.Score2; }
            set { this.Score2 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score3
        {            
            get { return this.Score3; }
            set { this.Score3 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score4
        {            
            get { return this.Score4; }
            set { this.Score4 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score5
        {            
            get { return this.Score5; }
            set { this.Score5 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score6
        {            
            get { return this.Score6; }
            set { this.Score6 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Score7
        {            
            get { return this.Score7; }
            set { this.Score7 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Star_sum
        {            
            get { return this.Star_sum; }
            set { this.Star_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Tags
        {            
            get { return this.Tags; }
            set { this.Tags = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
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
        public int Comment_sum
        {
            get { return this.m_comment_sum; }
            set //
            {
                if (!comment_sum_initialized || m_comment_sum != value)
                {
                    this.m_comment_sum = value;
                }
                comment_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Fav_sum
        {
            get { return this.m_fav_sum; }
            set //
            {
                if (!fav_sum_initialized || m_fav_sum != value)
                {
                    this.m_fav_sum = value;
                }
                fav_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score_sum
        {
            get { return this.m_score_sum; }
            set //
            {
                if (!score_sum_initialized || m_score_sum != value)
                {
                    this.m_score_sum = value;
                }
                score_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score1
        {
            get { return this.m_score1; }
            set //
            {
                if (!score1_initialized || m_score1 != value)
                {
                    this.m_score1 = value;
                }
                score1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score2
        {
            get { return this.m_score2; }
            set //
            {
                if (!score2_initialized || m_score2 != value)
                {
                    this.m_score2 = value;
                }
                score2_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score3
        {
            get { return this.m_score3; }
            set //
            {
                if (!score3_initialized || m_score3 != value)
                {
                    this.m_score3 = value;
                }
                score3_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score4
        {
            get { return this.m_score4; }
            set //
            {
                if (!score4_initialized || m_score4 != value)
                {
                    this.m_score4 = value;
                }
                score4_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score5
        {
            get { return this.m_score5; }
            set //
            {
                if (!score5_initialized || m_score5 != value)
                {
                    this.m_score5 = value;
                }
                score5_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score6
        {
            get { return this.m_score6; }
            set //
            {
                if (!score6_initialized || m_score6 != value)
                {
                    this.m_score6 = value;
                }
                score6_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Score7
        {
            get { return this.m_score7; }
            set //
            {
                if (!score7_initialized || m_score7 != value)
                {
                    this.m_score7 = value;
                }
                score7_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Star_sum
        {
            get { return this.m_star_sum; }
            set //
            {
                if (!star_sum_initialized || m_star_sum != value)
                {
                    this.m_star_sum = value;
                }
                star_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Tags
        {
            get { return this.m_tags; }
            set //
            {
                if (!tags_initialized || m_tags != value)
                {
                    this.m_tags = value;
                }
                tags_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher_id
        {
            get { return this.m_teacher_id; }
            set //
            {
                if (!teacher_id_initialized || m_teacher_id != value)
                {
                    this.m_teacher_id = value;
                }
                teacher_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_score].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Comment_sum =  new AttributeItem("[Xb_teacher_score].[Comment_sum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Fav_sum =  new AttributeItem("[Xb_teacher_score].[Fav_sum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score_sum =  new AttributeItem("[Xb_teacher_score].[Score_sum]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score1 =  new AttributeItem("[Xb_teacher_score].[Score1]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score2 =  new AttributeItem("[Xb_teacher_score].[Score2]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score3 =  new AttributeItem("[Xb_teacher_score].[Score3]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score4 =  new AttributeItem("[Xb_teacher_score].[Score4]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score5 =  new AttributeItem("[Xb_teacher_score].[Score5]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score6 =  new AttributeItem("[Xb_teacher_score].[Score6]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score7 =  new AttributeItem("[Xb_teacher_score].[Score7]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Star_sum =  new AttributeItem("[Xb_teacher_score].[Star_sum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tags =  new AttributeItem("[Xb_teacher_score].[Tags]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xb_teacher_score].[Teacher_id]", typeof(string), 32, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_comment_sum;
        /// <summary></summary>
        protected bool comment_sum_initialized = false;
        
        private int m_fav_sum;
        /// <summary></summary>
        protected bool fav_sum_initialized = false;
        
        private double m_score_sum;
        /// <summary></summary>
        protected bool score_sum_initialized = false;
        
        private double m_score1;
        /// <summary></summary>
        protected bool score1_initialized = false;
        
        private double m_score2;
        /// <summary></summary>
        protected bool score2_initialized = false;
        
        private double m_score3;
        /// <summary></summary>
        protected bool score3_initialized = false;
        
        private double m_score4;
        /// <summary></summary>
        protected bool score4_initialized = false;
        
        private double m_score5;
        /// <summary></summary>
        protected bool score5_initialized = false;
        
        private double m_score6;
        /// <summary></summary>
        protected bool score6_initialized = false;
        
        private double m_score7;
        /// <summary></summary>
        protected bool score7_initialized = false;
        
        private int m_star_sum;
        /// <summary></summary>
        protected bool star_sum_initialized = false;
        
        private string m_tags;
        /// <summary></summary>
        protected bool tags_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacher_score";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.comment_sum_initialized = IsLoadAllAttributes;this.fav_sum_initialized = IsLoadAllAttributes;this.score_sum_initialized = IsLoadAllAttributes;this.score1_initialized = IsLoadAllAttributes;this.score2_initialized = IsLoadAllAttributes;this.score3_initialized = IsLoadAllAttributes;this.score4_initialized = IsLoadAllAttributes;this.score5_initialized = IsLoadAllAttributes;this.score6_initialized = IsLoadAllAttributes;this.score7_initialized = IsLoadAllAttributes;this.star_sum_initialized = IsLoadAllAttributes;this.tags_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_score value = new Xb_teacher_score();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Comment_sum"))
				value.comment_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fav_sum"))
				value.fav_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_sum"))
				value.score_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score1"))
				value.score1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score2"))
				value.score2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score3"))
				value.score3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score4"))
				value.score4_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score5"))
				value.score5_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score6"))
				value.score6_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score7"))
				value.score7_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Star_sum"))
				value.star_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tags"))
				value.tags_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_teacher_score Clone()
        {
            return (Xb_teacher_score)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_teacher_score()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_teacher_score() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_teacher_score(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_teacher_score(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_teacher_score(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_teacher_score(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_teacher_score(int id1, int comment_sum1, int fav_sum1, double score_sum1, double score11, double score21, double score31, double score41, double score51, double score61, double score71, int star_sum1, string tags1, string teacher_id1)
        {
            
            this.Id = id1;
            
            this.Comment_sum = comment_sum1;
            
            this.Fav_sum = fav_sum1;
            
            this.Score_sum = score_sum1;
            
            this.Score1 = score11;
            
            this.Score2 = score21;
            
            this.Score3 = score31;
            
            this.Score4 = score41;
            
            this.Score5 = score51;
            
            this.Score6 = score61;
            
            this.Score7 = score71;
            
            this.Star_sum = star_sum1;
            
            this.Tags = tags1;
            
            this.Teacher_id = teacher_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_teacher_score FromIView(IView view)
        {
            return (Xb_teacher_score)IView.GetITable(view, "Xb_teacher_score");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_teacher_score GetOneInstance()
        {
            Xb_teacher_score value = new Xb_teacher_score();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_teacher_score Retrieve()
        {
            BLLTable<Xb_teacher_score>.GetRowData(this);
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
			    			
			    case "Comment_sum":
			        return Comment_sum;
			    			
			    case "Fav_sum":
			        return Fav_sum;
			    			
			    case "Score_sum":
			        return Score_sum;
			    			
			    case "Score1":
			        return Score1;
			    			
			    case "Score2":
			        return Score2;
			    			
			    case "Score3":
			        return Score3;
			    			
			    case "Score4":
			        return Score4;
			    			
			    case "Score5":
			        return Score5;
			    			
			    case "Score6":
			        return Score6;
			    			
			    case "Score7":
			        return Score7;
			    			
			    case "Star_sum":
			        return Star_sum;
			    			
			    case "Tags":
			        return Tags;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			
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
			    			
			    case "Comment_sum":
			        this.Comment_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Fav_sum":
			        this.Fav_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Score_sum":
			        this.Score_sum = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score1":
			        this.Score1 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score2":
			        this.Score2 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score3":
			        this.Score3 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score4":
			        this.Score4 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score5":
			        this.Score5 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score6":
			        this.Score6 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Score7":
			        this.Score7 = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Star_sum":
			        this.Star_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Tags":
			        this.Tags = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
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
				
				case "Comment_sum":
					return comment_sum_initialized;
				
				case "Fav_sum":
					return fav_sum_initialized;
				
				case "Score_sum":
					return score_sum_initialized;
				
				case "Score1":
					return score1_initialized;
				
				case "Score2":
					return score2_initialized;
				
				case "Score3":
					return score3_initialized;
				
				case "Score4":
					return score4_initialized;
				
				case "Score5":
					return score5_initialized;
				
				case "Score6":
					return score6_initialized;
				
				case "Score7":
					return score7_initialized;
				
				case "Star_sum":
					return star_sum_initialized;
				
				case "Tags":
					return tags_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
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
				
				case "Comment_sum":
					comment_sum_initialized = ret;
					return true;
				
				case "Fav_sum":
					fav_sum_initialized = ret;
					return true;
				
				case "Score_sum":
					score_sum_initialized = ret;
					return true;
				
				case "Score1":
					score1_initialized = ret;
					return true;
				
				case "Score2":
					score2_initialized = ret;
					return true;
				
				case "Score3":
					score3_initialized = ret;
					return true;
				
				case "Score4":
					score4_initialized = ret;
					return true;
				
				case "Score5":
					score5_initialized = ret;
					return true;
				
				case "Score6":
					score6_initialized = ret;
					return true;
				
				case "Score7":
					score7_initialized = ret;
					return true;
				
				case "Star_sum":
					star_sum_initialized = ret;
					return true;
				
				case "Tags":
					tags_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
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
                AttributeItem attr = Xb_teacher_score.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (comment_sum_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Comment_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Comment_sum);
                }
			}
			
			if (fav_sum_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Fav_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fav_sum);
                }
			}
			
			if (score_sum_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_sum);
                }
			}
			
			if (score1_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score1);
                }
			}
			
			if (score2_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score2);
                }
			}
			
			if (score3_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score3);
                }
			}
			
			if (score4_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score4;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score4);
                }
			}
			
			if (score5_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score5);
                }
			}
			
			if (score6_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score6;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score6);
                }
			}
			
			if (score7_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Score7;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score7);
                }
			}
			
			if (star_sum_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Star_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Star_sum);
                }
			}
			
			if (tags_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Tags;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tags);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xb_teacher_score.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
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
        public class Xb_teacher_scoreJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Comment_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Fav_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score2 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score3 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score4 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score5 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score6 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Score7 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Star_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Tags { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
        }
        #endregion
    }
}