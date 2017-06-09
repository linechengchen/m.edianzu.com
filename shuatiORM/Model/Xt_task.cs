/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    数据表Xt_task对应的业务逻辑层Xt_task
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_task_Entity:Xt_task
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Id,Knowledge,Title,Cover,Category_ids,Category_names,Endtime,Related_course,Difficulty,Share,Group_work,Comment,Create_time,Content,Task_type from Xt_task
delete from Xt_task
INSERT INTO Xt_task (Uuid,Id,Knowledge,Title,Cover,Category_ids,Category_names,Endtime,Related_course,Difficulty,Share,Group_work,Comment,Create_time,Content,Task_type)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE Xt_task SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Id = valObj2.Id;
        valObj.Knowledge = valObj2.Knowledge;
        valObj.Title = valObj2.Title;
        valObj.Cover = valObj2.Cover;
        valObj.Category_ids = valObj2.Category_ids;
        valObj.Category_names = valObj2.Category_names;
        valObj.Endtime = valObj2.Endtime;
        valObj.Related_course = valObj2.Related_course;
        valObj.Difficulty = valObj2.Difficulty;
        valObj.Share = valObj2.Share;
        valObj.Group_work = valObj2.Group_work;
        valObj.Comment = valObj2.Comment;
        valObj.Create_time = valObj2.Create_time;
        valObj.Content = valObj2.Content;
        valObj.Task_type = valObj2.Task_type; 
        valObj.Uuid = "";
        valObj.Id = "";
        valObj.Knowledge = "";
        valObj.Title = "";
        valObj.Cover = "";
        valObj.Category_ids = "";
        valObj.Category_names = "";
        valObj.Endtime = "";
        valObj.Related_course = "";
        valObj.Difficulty = "";
        valObj.Share = "";
        valObj.Group_work = "";
        valObj.Comment = "";
        valObj.Create_time = "";
        valObj.Content = "";
        valObj.Task_type = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Id": $("#txt_Id").val(),
        "Knowledge": $("#txt_Knowledge").val(),
        "Title": $("#txt_Title").val(),
        "Cover": $("#txt_Cover").val(),
        "Category_ids": $("#txt_Category_ids").val(),
        "Category_names": $("#txt_Category_names").val(),
        "Endtime": $("#txt_Endtime").val(),
        "Related_course": $("#txt_Related_course").val(),
        "Difficulty": $("#txt_Difficulty").val(),
        "Share": $("#txt_Share").val(),
        "Group_work": $("#txt_Group_work").val(),
        "Comment": $("#txt_Comment").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Content": $("#txt_Content").val(),
        "Task_type": $("#txt_Task_type").val(), 
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
    /// <para>作业表</para>
    /// <para>与Xt_task数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_task : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_task Factory()
        {
            return new Xt_task();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 知识/技能点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge
        {            
            get { return this.Knowledge; }
            set { this.Knowledge = value; }
        }
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> 封面:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Cover
        {            
            get { return this.Cover; }
            set { this.Cover = value; }
        }
        
        /// <summary> 所属类别:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_ids
        {            
            get { return this.Category_ids; }
            set { this.Category_ids = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_names
        {            
            get { return this.Category_names; }
            set { this.Category_names = value; }
        }
        
        /// <summary> 截止时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Endtime
        {            
            get { return this.Endtime; }
            set { this.Endtime = value; }
        }
        
        /// <summary> 关联课程:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Related_course
        {            
            get { return this.Related_course; }
            set { this.Related_course = value; }
        }
        
        /// <summary> 难易程度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Difficulty
        {            
            get { return this.Difficulty; }
            set { this.Difficulty = value; }
        }
        
        /// <summary> 共享设置:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Share
        {            
            get { return this.Share; }
            set { this.Share = value; }
        }
        
        /// <summary> 是否小组作业:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Group_work
        {            
            get { return this.Group_work; }
            set { this.Group_work = value; }
        }
        
        /// <summary> 点评设置:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Comment
        {            
            get { return this.Comment; }
            set { this.Comment = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> 作业类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Task_type
        {            
            get { return this.Task_type; }
            set { this.Task_type = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 知识/技能点:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> 封面:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Cover
        {
            get { return this.m_cover; }
            set //
            {
                if (!cover_initialized || m_cover != value)
                {
                    this.m_cover = value;
                }
                cover_initialized = true;
            }
        }
        
        /// <summary> 所属类别:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 截止时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Endtime
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
        
        /// <summary> 关联课程:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Related_course
        {
            get { return this.m_related_course; }
            set //
            {
                if (!related_course_initialized || m_related_course != value)
                {
                    this.m_related_course = value;
                }
                related_course_initialized = true;
            }
        }
        
        /// <summary> 难易程度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 共享设置:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Share
        {
            get { return this.m_share; }
            set //
            {
                if (!share_initialized || m_share != value)
                {
                    this.m_share = value;
                }
                share_initialized = true;
            }
        }
        
        /// <summary> 是否小组作业:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Group_work
        {
            get { return this.m_group_work; }
            set //
            {
                if (!group_work_initialized || m_group_work != value)
                {
                    this.m_group_work = value;
                }
                group_work_initialized = true;
            }
        }
        
        /// <summary> 点评设置:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Comment
        {
            get { return this.m_comment; }
            set //
            {
                if (!comment_initialized || m_comment != value)
                {
                    this.m_comment = value;
                }
                comment_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 作业类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Task_type
        {
            get { return this.m_task_type; }
            set //
            {
                if (!task_type_initialized || m_task_type != value)
                {
                    this.m_task_type = value;
                }
                task_type_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_task].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_task].[Id]", typeof(int), 4, default(int));
            
            /// <summary>知识/技能点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge =  new AttributeItem("[Xt_task].[Knowledge]", typeof(string), 100, default(string));
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_task].[Title]", typeof(string), 100, default(string));
            
            /// <summary>封面:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Cover =  new AttributeItem("[Xt_task].[Cover]", typeof(string), 100, default(string));
            
            /// <summary>所属类别:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_ids =  new AttributeItem("[Xt_task].[Category_ids]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_names =  new AttributeItem("[Xt_task].[Category_names]", typeof(string), 100, default(string));
            
            /// <summary>截止时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Endtime =  new AttributeItem("[Xt_task].[Endtime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>关联课程:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Related_course =  new AttributeItem("[Xt_task].[Related_course]", typeof(string), 100, default(string));
            
            /// <summary>难易程度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Difficulty =  new AttributeItem("[Xt_task].[Difficulty]", typeof(string), 10, default(string));
            
            /// <summary>共享设置:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Share =  new AttributeItem("[Xt_task].[Share]", typeof(string), 10, default(string));
            
            /// <summary>是否小组作业:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_work =  new AttributeItem("[Xt_task].[Group_work]", typeof(string), 1, default(string));
            
            /// <summary>点评设置:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Comment =  new AttributeItem("[Xt_task].[Comment]", typeof(string), 10, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_task].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xt_task].[Content]", typeof(string), -1, default(string));
            
            /// <summary>作业类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_type =  new AttributeItem("[Xt_task].[Task_type]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_knowledge;
        /// <summary></summary>
        protected bool knowledge_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_cover;
        /// <summary></summary>
        protected bool cover_initialized = false;
        
        private string m_category_ids;
        /// <summary></summary>
        protected bool category_ids_initialized = false;
        
        private string m_category_names;
        /// <summary></summary>
        protected bool category_names_initialized = false;
        
        private DateTime m_endtime;
        /// <summary></summary>
        protected bool endtime_initialized = false;
        
        private string m_related_course;
        /// <summary></summary>
        protected bool related_course_initialized = false;
        
        private string m_difficulty;
        /// <summary></summary>
        protected bool difficulty_initialized = false;
        
        private string m_share;
        /// <summary></summary>
        protected bool share_initialized = false;
        
        private string m_group_work;
        /// <summary></summary>
        protected bool group_work_initialized = false;
        
        private string m_comment;
        /// <summary></summary>
        protected bool comment_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_task_type;
        /// <summary></summary>
        protected bool task_type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_task";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.knowledge_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.cover_initialized = IsLoadAllAttributes;this.category_ids_initialized = IsLoadAllAttributes;this.category_names_initialized = IsLoadAllAttributes;this.endtime_initialized = IsLoadAllAttributes;this.related_course_initialized = IsLoadAllAttributes;this.difficulty_initialized = IsLoadAllAttributes;this.share_initialized = IsLoadAllAttributes;this.group_work_initialized = IsLoadAllAttributes;this.comment_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.task_type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_task value = new Xt_task();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge"))
				value.knowledge_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Cover"))
				value.cover_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_ids"))
				value.category_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_names"))
				value.category_names_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Endtime"))
				value.endtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Related_course"))
				value.related_course_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Difficulty"))
				value.difficulty_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Share"))
				value.share_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_work"))
				value.group_work_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Comment"))
				value.comment_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_type"))
				value.task_type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_task Clone()
        {
            return (Xt_task)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_task()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_task() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_task(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_task(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_task(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_task(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_task(Guid uuid1, int id1, string knowledge1, string title1, string cover1, string category_ids1, string category_names1, DateTime endtime1, string related_course1, string difficulty1, string share1, string group_work1, string comment1, DateTime create_time1, string content1, string task_type1)
        {
            
            this.Uuid = uuid1;
            
            this.Id = id1;
            
            this.Knowledge = knowledge1;
            
            this.Title = title1;
            
            this.Cover = cover1;
            
            this.Category_ids = category_ids1;
            
            this.Category_names = category_names1;
            
            this.Endtime = endtime1;
            
            this.Related_course = related_course1;
            
            this.Difficulty = difficulty1;
            
            this.Share = share1;
            
            this.Group_work = group_work1;
            
            this.Comment = comment1;
            
            this.Create_time = create_time1;
            
            this.Content = content1;
            
            this.Task_type = task_type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_task FromIView(IView view)
        {
            return (Xt_task)IView.GetITable(view, "Xt_task");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_task GetOneInstance()
        {
            Xt_task value = new Xt_task();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_task Retrieve()
        {
            BLLTable<Xt_task>.GetRowData(this);
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
			    			
			    case "Id":
			        return Id;
			    			
			    case "Knowledge":
			        return Knowledge;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Cover":
			        return Cover;
			    			
			    case "Category_ids":
			        return Category_ids;
			    			
			    case "Category_names":
			        return Category_names;
			    			
			    case "Endtime":
			        return Endtime;
			    			
			    case "Related_course":
			        return Related_course;
			    			
			    case "Difficulty":
			        return Difficulty;
			    			
			    case "Share":
			        return Share;
			    			
			    case "Group_work":
			        return Group_work;
			    			
			    case "Comment":
			        return Comment;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Content":
			        return Content;
			    			
			    case "Task_type":
			        return Task_type;
			
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
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Knowledge":
			        this.Knowledge = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Cover":
			        this.Cover = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_ids":
			        this.Category_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_names":
			        this.Category_names = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Endtime":
			        this.Endtime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Related_course":
			        this.Related_course = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Difficulty":
			        this.Difficulty = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Share":
			        this.Share = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Group_work":
			        this.Group_work = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Comment":
			        this.Comment = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_type":
			        this.Task_type = Convert.ToString(AttributeValue);
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
				
				case "Id":
					return id_initialized;
				
				case "Knowledge":
					return knowledge_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Cover":
					return cover_initialized;
				
				case "Category_ids":
					return category_ids_initialized;
				
				case "Category_names":
					return category_names_initialized;
				
				case "Endtime":
					return endtime_initialized;
				
				case "Related_course":
					return related_course_initialized;
				
				case "Difficulty":
					return difficulty_initialized;
				
				case "Share":
					return share_initialized;
				
				case "Group_work":
					return group_work_initialized;
				
				case "Comment":
					return comment_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Content":
					return content_initialized;
				
				case "Task_type":
					return task_type_initialized;
				
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
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Knowledge":
					knowledge_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Cover":
					cover_initialized = ret;
					return true;
				
				case "Category_ids":
					category_ids_initialized = ret;
					return true;
				
				case "Category_names":
					category_names_initialized = ret;
					return true;
				
				case "Endtime":
					endtime_initialized = ret;
					return true;
				
				case "Related_course":
					related_course_initialized = ret;
					return true;
				
				case "Difficulty":
					difficulty_initialized = ret;
					return true;
				
				case "Share":
					share_initialized = ret;
					return true;
				
				case "Group_work":
					group_work_initialized = ret;
					return true;
				
				case "Comment":
					comment_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "Task_type":
					task_type_initialized = ret;
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
                AttributeItem attr = Xt_task.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (knowledge_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Knowledge;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (cover_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Cover;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Cover);
                }
			}
			
			if (category_ids_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Category_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_ids);
                }
			}
			
			if (category_names_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Category_names;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_names);
                }
			}
			
			if (endtime_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Endtime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Endtime);
                }
			}
			
			if (related_course_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Related_course;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Related_course);
                }
			}
			
			if (difficulty_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Difficulty;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Difficulty);
                }
			}
			
			if (share_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Share;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Share);
                }
			}
			
			if (group_work_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Group_work;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_work);
                }
			}
			
			if (comment_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Comment;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Comment);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (task_type_initialized)
			{
                AttributeItem attr = Xt_task.Attribute.Task_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_type);
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
        public class Xt_taskJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>知识/技能点:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge { get; set; }
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>封面:[CtrlTypeDic-{InputString}]</summary>
            public string Cover { get; set; }
            
            /// <summary>所属类别:[CtrlTypeDic-{InputString}]</summary>
            public string Category_ids { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Category_names { get; set; }
            
            /// <summary>截止时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Endtime { get; set; }
            
            /// <summary>关联课程:[CtrlTypeDic-{InputString}]</summary>
            public string Related_course { get; set; }
            
            /// <summary>难易程度:[CtrlTypeDic-{InputString}]</summary>
            public string Difficulty { get; set; }
            
            /// <summary>共享设置:[CtrlTypeDic-{InputString}]</summary>
            public string Share { get; set; }
            
            /// <summary>是否小组作业:[CtrlTypeDic-{InputString}]</summary>
            public string Group_work { get; set; }
            
            /// <summary>点评设置:[CtrlTypeDic-{InputString}]</summary>
            public string Comment { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Content { get; set; }
            
            /// <summary>作业类型:[CtrlTypeDic-{InputString}]</summary>
            public string Task_type { get; set; }
        }
        #endregion
    }
}