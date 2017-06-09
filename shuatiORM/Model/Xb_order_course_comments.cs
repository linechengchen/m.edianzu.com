/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:02
  Description:    数据表Xb_order_course_comments对应的业务逻辑层Xb_order_course_comments
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_order_course_comments_Entity:Xb_order_course_comments
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Course_name,CreateTime,Grade_name,Is_selection,ModifyTime,Qingqing_order_course_id,Student_appraise_time,Student_comment_word,Student_phrases,Teacher_appraise_time,Teacher_comment_word,Total_count,Total_study_time,User_id,Uuid from Xb_order_course_comments
delete from Xb_order_course_comments
INSERT INTO Xb_order_course_comments (Id,Course_name,CreateTime,Grade_name,Is_selection,ModifyTime,Qingqing_order_course_id,Student_appraise_time,Student_comment_word,Student_phrases,Teacher_appraise_time,Teacher_comment_word,Total_count,Total_study_time,User_id,Uuid)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE Xb_order_course_comments SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Course_name = valObj2.Course_name;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Grade_name = valObj2.Grade_name;
        valObj.Is_selection = valObj2.Is_selection;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Qingqing_order_course_id = valObj2.Qingqing_order_course_id;
        valObj.Student_appraise_time = valObj2.Student_appraise_time;
        valObj.Student_comment_word = valObj2.Student_comment_word;
        valObj.Student_phrases = valObj2.Student_phrases;
        valObj.Teacher_appraise_time = valObj2.Teacher_appraise_time;
        valObj.Teacher_comment_word = valObj2.Teacher_comment_word;
        valObj.Total_count = valObj2.Total_count;
        valObj.Total_study_time = valObj2.Total_study_time;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Course_name = "";
        valObj.CreateTime = "";
        valObj.Grade_name = "";
        valObj.Is_selection = "";
        valObj.ModifyTime = "";
        valObj.Qingqing_order_course_id = "";
        valObj.Student_appraise_time = "";
        valObj.Student_comment_word = "";
        valObj.Student_phrases = "";
        valObj.Teacher_appraise_time = "";
        valObj.Teacher_comment_word = "";
        valObj.Total_count = "";
        valObj.Total_study_time = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Course_name": $("#txt_Course_name").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Grade_name": $("#txt_Grade_name").val(),
        "Is_selection": $("#txt_Is_selection").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Qingqing_order_course_id": $("#txt_Qingqing_order_course_id").val(),
        "Student_appraise_time": $("#txt_Student_appraise_time").val(),
        "Student_comment_word": $("#txt_Student_comment_word").val(),
        "Student_phrases": $("#txt_Student_phrases").val(),
        "Teacher_appraise_time": $("#txt_Teacher_appraise_time").val(),
        "Teacher_comment_word": $("#txt_Teacher_comment_word").val(),
        "Total_count": $("#txt_Total_count").val(),
        "Total_study_time": $("#txt_Total_study_time").val(),
        "User_id": $("#txt_User_id").val(),
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
    /// <para>与Xb_order_course_comments数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_order_course_comments : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_order_course_comments Factory()
        {
            return new Xb_order_course_comments();
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
        public string _Course_name
        {            
            get { return this.Course_name; }
            set { this.Course_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Grade_name
        {            
            get { return this.Grade_name; }
            set { this.Grade_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Is_selection
        {            
            get { return this.Is_selection; }
            set { this.Is_selection = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Qingqing_order_course_id
        {            
            get { return this.Qingqing_order_course_id; }
            set { this.Qingqing_order_course_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Student_appraise_time
        {            
            get { return this.Student_appraise_time; }
            set { this.Student_appraise_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_comment_word
        {            
            get { return this.Student_comment_word; }
            set { this.Student_comment_word = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_phrases
        {            
            get { return this.Student_phrases; }
            set { this.Student_phrases = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Teacher_appraise_time
        {            
            get { return this.Teacher_appraise_time; }
            set { this.Teacher_appraise_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_comment_word
        {            
            get { return this.Teacher_comment_word; }
            set { this.Teacher_comment_word = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Total_count
        {            
            get { return this.Total_count; }
            set { this.Total_count = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Total_study_time
        {            
            get { return this.Total_study_time; }
            set { this.Total_study_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        public string Course_name
        {
            get { return this.m_course_name; }
            set //
            {
                if (!course_name_initialized || m_course_name != value)
                {
                    this.m_course_name = value;
                }
                course_name_initialized = true;
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
        public string Grade_name
        {
            get { return this.m_grade_name; }
            set //
            {
                if (!grade_name_initialized || m_grade_name != value)
                {
                    this.m_grade_name = value;
                }
                grade_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Is_selection
        {
            get { return this.m_is_selection; }
            set //
            {
                if (!is_selection_initialized || m_is_selection != value)
                {
                    this.m_is_selection = value;
                }
                is_selection_initialized = true;
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
        public decimal Qingqing_order_course_id
        {
            get { return this.m_qingqing_order_course_id; }
            set //
            {
                if (!qingqing_order_course_id_initialized || m_qingqing_order_course_id != value)
                {
                    this.m_qingqing_order_course_id = value;
                }
                qingqing_order_course_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Student_appraise_time
        {
            get { return this.m_student_appraise_time; }
            set //
            {
                if (!student_appraise_time_initialized || m_student_appraise_time != value)
                {
                    this.m_student_appraise_time = value;
                }
                student_appraise_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Student_comment_word
        {
            get { return this.m_student_comment_word; }
            set //
            {
                if (!student_comment_word_initialized || m_student_comment_word != value)
                {
                    this.m_student_comment_word = value;
                }
                student_comment_word_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Student_phrases
        {
            get { return this.m_student_phrases; }
            set //
            {
                if (!student_phrases_initialized || m_student_phrases != value)
                {
                    this.m_student_phrases = value;
                }
                student_phrases_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Teacher_appraise_time
        {
            get { return this.m_teacher_appraise_time; }
            set //
            {
                if (!teacher_appraise_time_initialized || m_teacher_appraise_time != value)
                {
                    this.m_teacher_appraise_time = value;
                }
                teacher_appraise_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher_comment_word
        {
            get { return this.m_teacher_comment_word; }
            set //
            {
                if (!teacher_comment_word_initialized || m_teacher_comment_word != value)
                {
                    this.m_teacher_comment_word = value;
                }
                teacher_comment_word_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Total_count
        {
            get { return this.m_total_count; }
            set //
            {
                if (!total_count_initialized || m_total_count != value)
                {
                    this.m_total_count = value;
                }
                total_count_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Total_study_time
        {
            get { return this.m_total_study_time; }
            set //
            {
                if (!total_study_time_initialized || m_total_study_time != value)
                {
                    this.m_total_study_time = value;
                }
                total_study_time_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_order_course_comments].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_name =  new AttributeItem("[Xb_order_course_comments].[Course_name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_order_course_comments].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade_name =  new AttributeItem("[Xb_order_course_comments].[Grade_name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_selection =  new AttributeItem("[Xb_order_course_comments].[Is_selection]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_order_course_comments].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qingqing_order_course_id =  new AttributeItem("[Xb_order_course_comments].[Qingqing_order_course_id]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_appraise_time =  new AttributeItem("[Xb_order_course_comments].[Student_appraise_time]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_comment_word =  new AttributeItem("[Xb_order_course_comments].[Student_comment_word]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_phrases =  new AttributeItem("[Xb_order_course_comments].[Student_phrases]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_appraise_time =  new AttributeItem("[Xb_order_course_comments].[Teacher_appraise_time]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_comment_word =  new AttributeItem("[Xb_order_course_comments].[Teacher_comment_word]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Total_count =  new AttributeItem("[Xb_order_course_comments].[Total_count]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Total_study_time =  new AttributeItem("[Xb_order_course_comments].[Total_study_time]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_order_course_comments].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_order_course_comments].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_course_name;
        /// <summary></summary>
        protected bool course_name_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_grade_name;
        /// <summary></summary>
        protected bool grade_name_initialized = false;
        
        private bool m_is_selection;
        /// <summary></summary>
        protected bool is_selection_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private decimal m_qingqing_order_course_id;
        /// <summary></summary>
        protected bool qingqing_order_course_id_initialized = false;
        
        private int m_student_appraise_time;
        /// <summary></summary>
        protected bool student_appraise_time_initialized = false;
        
        private string m_student_comment_word;
        /// <summary></summary>
        protected bool student_comment_word_initialized = false;
        
        private string m_student_phrases;
        /// <summary></summary>
        protected bool student_phrases_initialized = false;
        
        private int m_teacher_appraise_time;
        /// <summary></summary>
        protected bool teacher_appraise_time_initialized = false;
        
        private string m_teacher_comment_word;
        /// <summary></summary>
        protected bool teacher_comment_word_initialized = false;
        
        private int m_total_count;
        /// <summary></summary>
        protected bool total_count_initialized = false;
        
        private string m_total_study_time;
        /// <summary></summary>
        protected bool total_study_time_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
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
            return "Xb_order_course_comments";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.course_name_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.grade_name_initialized = IsLoadAllAttributes;this.is_selection_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.qingqing_order_course_id_initialized = IsLoadAllAttributes;this.student_appraise_time_initialized = IsLoadAllAttributes;this.student_comment_word_initialized = IsLoadAllAttributes;this.student_phrases_initialized = IsLoadAllAttributes;this.teacher_appraise_time_initialized = IsLoadAllAttributes;this.teacher_comment_word_initialized = IsLoadAllAttributes;this.total_count_initialized = IsLoadAllAttributes;this.total_study_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_order_course_comments value = new Xb_order_course_comments();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_name"))
				value.course_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade_name"))
				value.grade_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_selection"))
				value.is_selection_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qingqing_order_course_id"))
				value.qingqing_order_course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_appraise_time"))
				value.student_appraise_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_comment_word"))
				value.student_comment_word_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_phrases"))
				value.student_phrases_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_appraise_time"))
				value.teacher_appraise_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_comment_word"))
				value.teacher_comment_word_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_count"))
				value.total_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_study_time"))
				value.total_study_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_order_course_comments Clone()
        {
            return (Xb_order_course_comments)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_order_course_comments()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_order_course_comments() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_order_course_comments(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_order_course_comments(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_order_course_comments(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_order_course_comments(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_order_course_comments(int id1, string course_name1, DateTime createtime1, string grade_name1, bool is_selection1, DateTime modifytime1, decimal qingqing_order_course_id1, int student_appraise_time1, string student_comment_word1, string student_phrases1, int teacher_appraise_time1, string teacher_comment_word1, int total_count1, string total_study_time1, Guid user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Course_name = course_name1;
            
            this.CreateTime = createtime1;
            
            this.Grade_name = grade_name1;
            
            this.Is_selection = is_selection1;
            
            this.ModifyTime = modifytime1;
            
            this.Qingqing_order_course_id = qingqing_order_course_id1;
            
            this.Student_appraise_time = student_appraise_time1;
            
            this.Student_comment_word = student_comment_word1;
            
            this.Student_phrases = student_phrases1;
            
            this.Teacher_appraise_time = teacher_appraise_time1;
            
            this.Teacher_comment_word = teacher_comment_word1;
            
            this.Total_count = total_count1;
            
            this.Total_study_time = total_study_time1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_order_course_comments FromIView(IView view)
        {
            return (Xb_order_course_comments)IView.GetITable(view, "Xb_order_course_comments");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_order_course_comments GetOneInstance()
        {
            Xb_order_course_comments value = new Xb_order_course_comments();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_order_course_comments Retrieve()
        {
            BLLTable<Xb_order_course_comments>.GetRowData(this);
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
			    			
			    case "Course_name":
			        return Course_name;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Grade_name":
			        return Grade_name;
			    			
			    case "Is_selection":
			        return Is_selection;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Qingqing_order_course_id":
			        return Qingqing_order_course_id;
			    			
			    case "Student_appraise_time":
			        return Student_appraise_time;
			    			
			    case "Student_comment_word":
			        return Student_comment_word;
			    			
			    case "Student_phrases":
			        return Student_phrases;
			    			
			    case "Teacher_appraise_time":
			        return Teacher_appraise_time;
			    			
			    case "Teacher_comment_word":
			        return Teacher_comment_word;
			    			
			    case "Total_count":
			        return Total_count;
			    			
			    case "Total_study_time":
			        return Total_study_time;
			    			
			    case "User_id":
			        return User_id;
			    			
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
			    			
			    case "Course_name":
			        this.Course_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Grade_name":
			        this.Grade_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_selection":
			        this.Is_selection = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Qingqing_order_course_id":
			        this.Qingqing_order_course_id = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Student_appraise_time":
			        this.Student_appraise_time = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Student_comment_word":
			        this.Student_comment_word = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_phrases":
			        this.Student_phrases = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_appraise_time":
			        this.Teacher_appraise_time = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_comment_word":
			        this.Teacher_comment_word = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Total_count":
			        this.Total_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Total_study_time":
			        this.Total_study_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				
				case "Course_name":
					return course_name_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Grade_name":
					return grade_name_initialized;
				
				case "Is_selection":
					return is_selection_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Qingqing_order_course_id":
					return qingqing_order_course_id_initialized;
				
				case "Student_appraise_time":
					return student_appraise_time_initialized;
				
				case "Student_comment_word":
					return student_comment_word_initialized;
				
				case "Student_phrases":
					return student_phrases_initialized;
				
				case "Teacher_appraise_time":
					return teacher_appraise_time_initialized;
				
				case "Teacher_comment_word":
					return teacher_comment_word_initialized;
				
				case "Total_count":
					return total_count_initialized;
				
				case "Total_study_time":
					return total_study_time_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "Course_name":
					course_name_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Grade_name":
					grade_name_initialized = ret;
					return true;
				
				case "Is_selection":
					is_selection_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Qingqing_order_course_id":
					qingqing_order_course_id_initialized = ret;
					return true;
				
				case "Student_appraise_time":
					student_appraise_time_initialized = ret;
					return true;
				
				case "Student_comment_word":
					student_comment_word_initialized = ret;
					return true;
				
				case "Student_phrases":
					student_phrases_initialized = ret;
					return true;
				
				case "Teacher_appraise_time":
					teacher_appraise_time_initialized = ret;
					return true;
				
				case "Teacher_comment_word":
					teacher_comment_word_initialized = ret;
					return true;
				
				case "Total_count":
					total_count_initialized = ret;
					return true;
				
				case "Total_study_time":
					total_study_time_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = Xb_order_course_comments.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (course_name_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Course_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_name);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (grade_name_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Grade_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade_name);
                }
			}
			
			if (is_selection_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Is_selection;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_selection);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (qingqing_order_course_id_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Qingqing_order_course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qingqing_order_course_id);
                }
			}
			
			if (student_appraise_time_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Student_appraise_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_appraise_time);
                }
			}
			
			if (student_comment_word_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Student_comment_word;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_comment_word);
                }
			}
			
			if (student_phrases_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Student_phrases;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_phrases);
                }
			}
			
			if (teacher_appraise_time_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Teacher_appraise_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_appraise_time);
                }
			}
			
			if (teacher_comment_word_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Teacher_comment_word;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_comment_word);
                }
			}
			
			if (total_count_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Total_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_count);
                }
			}
			
			if (total_study_time_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Total_study_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_study_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_order_course_comments.Attribute.Uuid;
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
        public class Xb_order_course_commentsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Course_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Grade_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_selection { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Qingqing_order_course_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Student_appraise_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_comment_word { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_phrases { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Teacher_appraise_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_comment_word { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Total_count { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Total_study_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}