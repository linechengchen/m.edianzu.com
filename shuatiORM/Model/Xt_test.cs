/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    数据表Xt_test对应的业务逻辑层Xt_test
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_test_Entity:Xt_test
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Course_id,Exam_name,Info,Category_ids,Category_names,State_time,End_time,Knowledge_id,Is_answer,Is_share,Video_val,Teacher from Xt_test
delete from Xt_test
INSERT INTO Xt_test (Uuid,Course_id,Exam_name,Info,Category_ids,Category_names,State_time,End_time,Knowledge_id,Is_answer,Is_share,Video_val,Teacher)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xt_test SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Course_id = valObj2.Course_id;
        valObj.Exam_name = valObj2.Exam_name;
        valObj.Info = valObj2.Info;
        valObj.Category_ids = valObj2.Category_ids;
        valObj.Category_names = valObj2.Category_names;
        valObj.State_time = valObj2.State_time;
        valObj.End_time = valObj2.End_time;
        valObj.Knowledge_id = valObj2.Knowledge_id;
        valObj.Is_answer = valObj2.Is_answer;
        valObj.Is_share = valObj2.Is_share;
        valObj.Video_val = valObj2.Video_val;
        valObj.Teacher = valObj2.Teacher; 
        valObj.Uuid = "";
        valObj.Course_id = "";
        valObj.Exam_name = "";
        valObj.Info = "";
        valObj.Category_ids = "";
        valObj.Category_names = "";
        valObj.State_time = "";
        valObj.End_time = "";
        valObj.Knowledge_id = "";
        valObj.Is_answer = "";
        valObj.Is_share = "";
        valObj.Video_val = "";
        valObj.Teacher = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Exam_name": $("#txt_Exam_name").val(),
        "Info": $("#txt_Info").val(),
        "Category_ids": $("#txt_Category_ids").val(),
        "Category_names": $("#txt_Category_names").val(),
        "State_time": $("#txt_State_time").val(),
        "End_time": $("#txt_End_time").val(),
        "Knowledge_id": $("#txt_Knowledge_id").val(),
        "Is_answer": $("#txt_Is_answer").val(),
        "Is_share": $("#txt_Is_share").val(),
        "Video_val": $("#txt_Video_val").val(),
        "Teacher": $("#txt_Teacher").val(), 
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
    /// <para>测验表</para>
    /// <para>与Xt_test数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_test : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_test Factory()
        {
            return new Xt_test();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 测试标题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Exam_name
        {            
            get { return this.Exam_name; }
            set { this.Exam_name = value; }
        }
        
        /// <summary> 一句话介绍:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Info
        {            
            get { return this.Info; }
            set { this.Info = value; }
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
        
        /// <summary> 开始时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _State_time
        {            
            get { return this.State_time; }
            set { this.State_time = value; }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _End_time
        {            
            get { return this.End_time; }
            set { this.End_time = value; }
        }
        
        /// <summary> 知识id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge_id
        {            
            get { return this.Knowledge_id; }
            set { this.Knowledge_id = value; }
        }
        
        /// <summary> 是否公布分数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_answer
        {            
            get { return this.Is_answer; }
            set { this.Is_answer = value; }
        }
        
        /// <summary> 是否共享:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_share
        {            
            get { return this.Is_share; }
            set { this.Is_share = value; }
        }
        
        /// <summary> 课程视频id，多个视频,风格:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Video_val
        {            
            get { return this.Video_val; }
            set { this.Video_val = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher
        {            
            get { return this.Teacher; }
            set { this.Teacher = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        
        /// <summary> 班级id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 测试标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Exam_name
        {
            get { return this.m_exam_name; }
            set //
            {
                if (!exam_name_initialized || m_exam_name != value)
                {
                    this.m_exam_name = value;
                }
                exam_name_initialized = true;
            }
        }
        
        /// <summary> 一句话介绍:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Info
        {
            get { return this.m_info; }
            set //
            {
                if (!info_initialized || m_info != value)
                {
                    this.m_info = value;
                }
                info_initialized = true;
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
        
        /// <summary> 开始时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime State_time
        {
            get { return this.m_state_time; }
            set //
            {
                if (!state_time_initialized || m_state_time != value)
                {
                    this.m_state_time = value;
                }
                state_time_initialized = true;
            }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime End_time
        {
            get { return this.m_end_time; }
            set //
            {
                if (!end_time_initialized || m_end_time != value)
                {
                    this.m_end_time = value;
                }
                end_time_initialized = true;
            }
        }
        
        /// <summary> 知识id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Knowledge_id
        {
            get { return this.m_knowledge_id; }
            set //
            {
                if (!knowledge_id_initialized || m_knowledge_id != value)
                {
                    this.m_knowledge_id = value;
                }
                knowledge_id_initialized = true;
            }
        }
        
        /// <summary> 是否公布分数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_answer
        {
            get { return this.m_is_answer; }
            set //
            {
                if (!is_answer_initialized || m_is_answer != value)
                {
                    this.m_is_answer = value;
                }
                is_answer_initialized = true;
            }
        }
        
        /// <summary> 是否共享:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_share
        {
            get { return this.m_is_share; }
            set //
            {
                if (!is_share_initialized || m_is_share != value)
                {
                    this.m_is_share = value;
                }
                is_share_initialized = true;
            }
        }
        
        /// <summary> 课程视频id，多个视频,风格:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Video_val
        {
            get { return this.m_video_val; }
            set //
            {
                if (!video_val_initialized || m_video_val != value)
                {
                    this.m_video_val = value;
                }
                video_val_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_test].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_test].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>测试标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Exam_name =  new AttributeItem("[Xt_test].[Exam_name]", typeof(string), 100, default(string));
            
            /// <summary>一句话介绍:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Info =  new AttributeItem("[Xt_test].[Info]", typeof(string), 100, default(string));
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_ids =  new AttributeItem("[Xt_test].[Category_ids]", typeof(string), 100, default(string));
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_names =  new AttributeItem("[Xt_test].[Category_names]", typeof(string), 100, default(string));
            
            /// <summary>开始时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem State_time =  new AttributeItem("[Xt_test].[State_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>结束时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem End_time =  new AttributeItem("[Xt_test].[End_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>知识id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge_id =  new AttributeItem("[Xt_test].[Knowledge_id]", typeof(string), 36, default(string));
            
            /// <summary>是否公布分数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_answer =  new AttributeItem("[Xt_test].[Is_answer]", typeof(string), 1, default(string));
            
            /// <summary>是否共享:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_share =  new AttributeItem("[Xt_test].[Is_share]", typeof(string), 1, default(string));
            
            /// <summary>课程视频id，多个视频,风格:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Video_val =  new AttributeItem("[Xt_test].[Video_val]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher =  new AttributeItem("[Xt_test].[Teacher]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_exam_name;
        /// <summary></summary>
        protected bool exam_name_initialized = false;
        
        private string m_info;
        /// <summary></summary>
        protected bool info_initialized = false;
        
        private string m_category_ids;
        /// <summary></summary>
        protected bool category_ids_initialized = false;
        
        private string m_category_names;
        /// <summary></summary>
        protected bool category_names_initialized = false;
        
        private DateTime m_state_time;
        /// <summary></summary>
        protected bool state_time_initialized = false;
        
        private DateTime m_end_time;
        /// <summary></summary>
        protected bool end_time_initialized = false;
        
        private string m_knowledge_id;
        /// <summary></summary>
        protected bool knowledge_id_initialized = false;
        
        private string m_is_answer;
        /// <summary></summary>
        protected bool is_answer_initialized = false;
        
        private string m_is_share;
        /// <summary></summary>
        protected bool is_share_initialized = false;
        
        private string m_video_val;
        /// <summary></summary>
        protected bool video_val_initialized = false;
        
        private string m_teacher;
        /// <summary></summary>
        protected bool teacher_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_test";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.exam_name_initialized = IsLoadAllAttributes;this.info_initialized = IsLoadAllAttributes;this.category_ids_initialized = IsLoadAllAttributes;this.category_names_initialized = IsLoadAllAttributes;this.state_time_initialized = IsLoadAllAttributes;this.end_time_initialized = IsLoadAllAttributes;this.knowledge_id_initialized = IsLoadAllAttributes;this.is_answer_initialized = IsLoadAllAttributes;this.is_share_initialized = IsLoadAllAttributes;this.video_val_initialized = IsLoadAllAttributes;this.teacher_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_test value = new Xt_test();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Exam_name"))
				value.exam_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Info"))
				value.info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_ids"))
				value.category_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_names"))
				value.category_names_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"State_time"))
				value.state_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"End_time"))
				value.end_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge_id"))
				value.knowledge_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_answer"))
				value.is_answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_share"))
				value.is_share_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Video_val"))
				value.video_val_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher"))
				value.teacher_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_test Clone()
        {
            return (Xt_test)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_test()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_test() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_test(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_test(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_test(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_test(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_test(Guid uuid1, string course_id1, string exam_name1, string info1, string category_ids1, string category_names1, DateTime state_time1, DateTime end_time1, string knowledge_id1, string is_answer1, string is_share1, string video_val1, string teacher1)
        {
            
            this.Uuid = uuid1;
            
            this.Course_id = course_id1;
            
            this.Exam_name = exam_name1;
            
            this.Info = info1;
            
            this.Category_ids = category_ids1;
            
            this.Category_names = category_names1;
            
            this.State_time = state_time1;
            
            this.End_time = end_time1;
            
            this.Knowledge_id = knowledge_id1;
            
            this.Is_answer = is_answer1;
            
            this.Is_share = is_share1;
            
            this.Video_val = video_val1;
            
            this.Teacher = teacher1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_test FromIView(IView view)
        {
            return (Xt_test)IView.GetITable(view, "Xt_test");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_test GetOneInstance()
        {
            Xt_test value = new Xt_test();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_test Retrieve()
        {
            BLLTable<Xt_test>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Exam_name":
			        return Exam_name;
			    			
			    case "Info":
			        return Info;
			    			
			    case "Category_ids":
			        return Category_ids;
			    			
			    case "Category_names":
			        return Category_names;
			    			
			    case "State_time":
			        return State_time;
			    			
			    case "End_time":
			        return End_time;
			    			
			    case "Knowledge_id":
			        return Knowledge_id;
			    			
			    case "Is_answer":
			        return Is_answer;
			    			
			    case "Is_share":
			        return Is_share;
			    			
			    case "Video_val":
			        return Video_val;
			    			
			    case "Teacher":
			        return Teacher;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Exam_name":
			        this.Exam_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Info":
			        this.Info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_ids":
			        this.Category_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_names":
			        this.Category_names = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "State_time":
			        this.State_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "End_time":
			        this.End_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Knowledge_id":
			        this.Knowledge_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_answer":
			        this.Is_answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_share":
			        this.Is_share = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Video_val":
			        this.Video_val = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher":
			        this.Teacher = Convert.ToString(AttributeValue);
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
				case "Uuid":
					return uuid_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Exam_name":
					return exam_name_initialized;
				
				case "Info":
					return info_initialized;
				
				case "Category_ids":
					return category_ids_initialized;
				
				case "Category_names":
					return category_names_initialized;
				
				case "State_time":
					return state_time_initialized;
				
				case "End_time":
					return end_time_initialized;
				
				case "Knowledge_id":
					return knowledge_id_initialized;
				
				case "Is_answer":
					return is_answer_initialized;
				
				case "Is_share":
					return is_share_initialized;
				
				case "Video_val":
					return video_val_initialized;
				
				case "Teacher":
					return teacher_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Exam_name":
					exam_name_initialized = ret;
					return true;
				
				case "Info":
					info_initialized = ret;
					return true;
				
				case "Category_ids":
					category_ids_initialized = ret;
					return true;
				
				case "Category_names":
					category_names_initialized = ret;
					return true;
				
				case "State_time":
					state_time_initialized = ret;
					return true;
				
				case "End_time":
					end_time_initialized = ret;
					return true;
				
				case "Knowledge_id":
					knowledge_id_initialized = ret;
					return true;
				
				case "Is_answer":
					is_answer_initialized = ret;
					return true;
				
				case "Is_share":
					is_share_initialized = ret;
					return true;
				
				case "Video_val":
					video_val_initialized = ret;
					return true;
				
				case "Teacher":
					teacher_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (exam_name_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Exam_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Exam_name);
                }
			}
			
			if (info_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Info);
                }
			}
			
			if (category_ids_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Category_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_ids);
                }
			}
			
			if (category_names_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Category_names;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_names);
                }
			}
			
			if (state_time_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.State_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(State_time);
                }
			}
			
			if (end_time_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.End_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(End_time);
                }
			}
			
			if (knowledge_id_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Knowledge_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge_id);
                }
			}
			
			if (is_answer_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Is_answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_answer);
                }
			}
			
			if (is_share_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Is_share;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_share);
                }
			}
			
			if (video_val_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Video_val;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Video_val);
                }
			}
			
			if (teacher_initialized)
			{
                AttributeItem attr = Xt_test.Attribute.Teacher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher);
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
        public class Xt_testJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>班级id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>测试标题:[CtrlTypeDic-{InputString}]</summary>
            public string Exam_name { get; set; }
            
            /// <summary>一句话介绍:[CtrlTypeDic-{InputString}]</summary>
            public string Info { get; set; }
            
            /// <summary>分类id:[CtrlTypeDic-{InputString}]</summary>
            public string Category_ids { get; set; }
            
            /// <summary>分类名称:[CtrlTypeDic-{InputString}]</summary>
            public string Category_names { get; set; }
            
            /// <summary>开始时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime State_time { get; set; }
            
            /// <summary>结束时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime End_time { get; set; }
            
            /// <summary>知识id:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge_id { get; set; }
            
            /// <summary>是否公布分数:[CtrlTypeDic-{InputString}]</summary>
            public string Is_answer { get; set; }
            
            /// <summary>是否共享:[CtrlTypeDic-{InputString}]</summary>
            public string Is_share { get; set; }
            
            /// <summary>课程视频id，多个视频,风格:[CtrlTypeDic-{InputString}]</summary>
            public string Video_val { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher { get; set; }
        }
        #endregion
    }
}