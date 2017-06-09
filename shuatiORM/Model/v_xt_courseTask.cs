/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    数据表V_xt_courseTask对应的业务逻辑层V_xt_courseTask
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 V_xt_courseTask_Entity:V_xt_courseTask
 * 
************************************************************/
/************************************************************
SQL代码：
select Title,Create_time,Endtime,Cover,Task_id,Correcting_finish,Correcting_unfinish,Submit_unfinsh,Creatime,Course_id from V_xt_courseTask
delete from V_xt_courseTask
INSERT INTO V_xt_courseTask (Title,Create_time,Endtime,Cover,Task_id,Correcting_finish,Correcting_unfinish,Submit_unfinsh,Creatime,Course_id)
     VALUES
           ('','','','','','','','','','')
UPDATE V_xt_courseTask SET ...
变量赋值代码：
 *         valObj.Title = valObj2.Title;
        valObj.Create_time = valObj2.Create_time;
        valObj.Endtime = valObj2.Endtime;
        valObj.Cover = valObj2.Cover;
        valObj.Task_id = valObj2.Task_id;
        valObj.Correcting_finish = valObj2.Correcting_finish;
        valObj.Correcting_unfinish = valObj2.Correcting_unfinish;
        valObj.Submit_unfinsh = valObj2.Submit_unfinsh;
        valObj.Creatime = valObj2.Creatime;
        valObj.Course_id = valObj2.Course_id; 
        valObj.Title = "";
        valObj.Create_time = "";
        valObj.Endtime = "";
        valObj.Cover = "";
        valObj.Task_id = "";
        valObj.Correcting_finish = "";
        valObj.Correcting_unfinish = "";
        valObj.Submit_unfinsh = "";
        valObj.Creatime = "";
        valObj.Course_id = ""; 
        "Title": $("#txt_Title").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Endtime": $("#txt_Endtime").val(),
        "Cover": $("#txt_Cover").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Correcting_finish": $("#txt_Correcting_finish").val(),
        "Correcting_unfinish": $("#txt_Correcting_unfinish").val(),
        "Submit_unfinsh": $("#txt_Submit_unfinsh").val(),
        "Creatime": $("#txt_Creatime").val(),
        "Course_id": $("#txt_Course_id").val(), 
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
    /// <para>课程作业关联表__作业表:[Inner-{Xt_course_task:0},{Xt_task:1}]</para>
    /// <para>与V_xt_courseTask数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class V_xt_courseTask : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static V_xt_courseTask Factory()
        {
            return new V_xt_courseTask();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 标题 Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 截止时间 Attribute_IsNotNull </summary>
        public DateTime _Endtime
        {            
            get { return this.Endtime; }
            set { this.Endtime = value; }
        }
        
        /// <summary> 封面 Attribute_IsNotNull </summary>
        public string _Cover
        {            
            get { return this.Cover; }
            set { this.Cover = value; }
        }
        
        /// <summary> 作业id Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> 已批改 Attribute_IsNotNull </summary>
        public int _Correcting_finish
        {            
            get { return this.Correcting_finish; }
            set { this.Correcting_finish = value; }
        }
        
        /// <summary> 未批改 Attribute_IsNotNull </summary>
        public int _Correcting_unfinish
        {            
            get { return this.Correcting_unfinish; }
            set { this.Correcting_unfinish = value; }
        }
        
        /// <summary> 未提交 Attribute_IsNotNull </summary>
        public int _Submit_unfinsh
        {            
            get { return this.Submit_unfinsh; }
            set { this.Submit_unfinsh = value; }
        }
        
        /// <summary> 创建时间 Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
        }
        
        /// <summary> 课程id Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 标题，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 截止时间，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 封面，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 作业id，推荐使用 "_"符号开头 </summary>
        public string Task_id
        {
            get { return this.m_task_id; }
            set //
            {
                if (!task_id_initialized || m_task_id != value)
                {
                    this.m_task_id = value;
                }
                task_id_initialized = true;
            }
        }
        
        /// <summary> 已批改，推荐使用 "_"符号开头 </summary>
        public int Correcting_finish
        {
            get { return this.m_correcting_finish; }
            set //
            {
                if (!correcting_finish_initialized || m_correcting_finish != value)
                {
                    this.m_correcting_finish = value;
                }
                correcting_finish_initialized = true;
            }
        }
        
        /// <summary> 未批改，推荐使用 "_"符号开头 </summary>
        public int Correcting_unfinish
        {
            get { return this.m_correcting_unfinish; }
            set //
            {
                if (!correcting_unfinish_initialized || m_correcting_unfinish != value)
                {
                    this.m_correcting_unfinish = value;
                }
                correcting_unfinish_initialized = true;
            }
        }
        
        /// <summary> 未提交，推荐使用 "_"符号开头 </summary>
        public int Submit_unfinsh
        {
            get { return this.m_submit_unfinsh; }
            set //
            {
                if (!submit_unfinsh_initialized || m_submit_unfinsh != value)
                {
                    this.m_submit_unfinsh = value;
                }
                submit_unfinsh_initialized = true;
            }
        }
        
        /// <summary> 创建时间，推荐使用 "_"符号开头 </summary>
        public DateTime Creatime
        {
            get { return this.m_creatime; }
            set //
            {
                if (!creatime_initialized || m_creatime != value)
                {
                    this.m_creatime = value;
                }
                creatime_initialized = true;
            }
        }
        
        /// <summary> 课程id，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>标题</summary>
            public static AttributeItem Title =  new AttributeItem("[V_xt_courseTask].[Title]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[V_xt_courseTask].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>截止时间</summary>
            public static AttributeItem Endtime =  new AttributeItem("[V_xt_courseTask].[Endtime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>封面</summary>
            public static AttributeItem Cover =  new AttributeItem("[V_xt_courseTask].[Cover]", typeof(string), 100, default(string));
            
            /// <summary>作业id</summary>
            public static AttributeItem Task_id =  new AttributeItem("[V_xt_courseTask].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>已批改</summary>
            public static AttributeItem Correcting_finish =  new AttributeItem("[V_xt_courseTask].[Correcting_finish]", typeof(int), 4, default(int));
            
            /// <summary>未批改</summary>
            public static AttributeItem Correcting_unfinish =  new AttributeItem("[V_xt_courseTask].[Correcting_unfinish]", typeof(int), 4, default(int));
            
            /// <summary>未提交</summary>
            public static AttributeItem Submit_unfinsh =  new AttributeItem("[V_xt_courseTask].[Submit_unfinsh]", typeof(int), 4, default(int));
            
            /// <summary>创建时间</summary>
            public static AttributeItem Creatime =  new AttributeItem("[V_xt_courseTask].[Creatime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>课程id</summary>
            public static AttributeItem Course_id =  new AttributeItem("[V_xt_courseTask].[Course_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_endtime;
        /// <summary></summary>
        protected bool endtime_initialized = false;
        
        private string m_cover;
        /// <summary></summary>
        protected bool cover_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private int m_correcting_finish;
        /// <summary></summary>
        protected bool correcting_finish_initialized = false;
        
        private int m_correcting_unfinish;
        /// <summary></summary>
        protected bool correcting_unfinish_initialized = false;
        
        private int m_submit_unfinsh;
        /// <summary></summary>
        protected bool submit_unfinsh_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_xt_courseTask";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.title_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.endtime_initialized = IsLoadAllAttributes;this.cover_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.correcting_finish_initialized = IsLoadAllAttributes;this.correcting_unfinish_initialized = IsLoadAllAttributes;this.submit_unfinsh_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xt_courseTask value = new V_xt_courseTask();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Endtime"))
				value.endtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Cover"))
				value.cover_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_finish"))
				value.correcting_finish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_unfinish"))
				value.correcting_unfinish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_unfinsh"))
				value.submit_unfinsh_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new V_xt_courseTask Clone()
        {
            return (V_xt_courseTask)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static V_xt_courseTask()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public V_xt_courseTask() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public V_xt_courseTask(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public V_xt_courseTask(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public V_xt_courseTask(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public V_xt_courseTask(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public V_xt_courseTask(string title1, DateTime create_time1, DateTime endtime1, string cover1, string task_id1, int correcting_finish1, int correcting_unfinish1, int submit_unfinsh1, DateTime creatime1, string course_id1)
        {
            
            this.Title = title1;
            
            this.Create_time = create_time1;
            
            this.Endtime = endtime1;
            
            this.Cover = cover1;
            
            this.Task_id = task_id1;
            
            this.Correcting_finish = correcting_finish1;
            
            this.Correcting_unfinish = correcting_unfinish1;
            
            this.Submit_unfinsh = submit_unfinsh1;
            
            this.Creatime = creatime1;
            
            this.Course_id = course_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static V_xt_courseTask FromIView(IView view)
        {
            return (V_xt_courseTask)IView.GetITable(view, "V_xt_courseTask");
        }
        /// <summary>获得一个实例  </summary>
        public static V_xt_courseTask GetOneInstance()
        {
            V_xt_courseTask value = new V_xt_courseTask();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public V_xt_courseTask Retrieve()
        {
            BLLTable<V_xt_courseTask>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Title":
			        return Title;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Endtime":
			        return Endtime;
			    			
			    case "Cover":
			        return Cover;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Correcting_finish":
			        return Correcting_finish;
			    			
			    case "Correcting_unfinish":
			        return Correcting_unfinish;
			    			
			    case "Submit_unfinsh":
			        return Submit_unfinsh;
			    			
			    case "Creatime":
			        return Creatime;
			    			
			    case "Course_id":
			        return Course_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Endtime":
			        this.Endtime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Cover":
			        this.Cover = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Correcting_finish":
			        this.Correcting_finish = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Correcting_unfinish":
			        this.Correcting_unfinish = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Submit_unfinsh":
			        this.Submit_unfinsh = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
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
				case "Title":
					return title_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Endtime":
					return endtime_initialized;
				
				case "Cover":
					return cover_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Correcting_finish":
					return correcting_finish_initialized;
				
				case "Correcting_unfinish":
					return correcting_unfinish_initialized;
				
				case "Submit_unfinsh":
					return submit_unfinsh_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Endtime":
					endtime_initialized = ret;
					return true;
				
				case "Cover":
					cover_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Correcting_finish":
					correcting_finish_initialized = ret;
					return true;
				
				case "Correcting_unfinish":
					correcting_unfinish_initialized = ret;
					return true;
				
				case "Submit_unfinsh":
					submit_unfinsh_initialized = ret;
					return true;
				
				case "Creatime":
					creatime_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
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

			
			if (title_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (endtime_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Endtime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Endtime);
                }
			}
			
			if (cover_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Cover;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Cover);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (correcting_finish_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Correcting_finish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_finish);
                }
			}
			
			if (correcting_unfinish_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Correcting_unfinish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_unfinish);
                }
			}
			
			if (submit_unfinsh_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Submit_unfinsh;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_unfinsh);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
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
        public class V_xt_courseTaskJson
        {
            
            /// <summary>标题</summary>
            public string Title { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>截止时间</summary>
            public DateTime Endtime { get; set; }
            
            /// <summary>封面</summary>
            public string Cover { get; set; }
            
            /// <summary>作业id</summary>
            public string Task_id { get; set; }
            
            /// <summary>已批改</summary>
            public int Correcting_finish { get; set; }
            
            /// <summary>未批改</summary>
            public int Correcting_unfinish { get; set; }
            
            /// <summary>未提交</summary>
            public int Submit_unfinsh { get; set; }
            
            /// <summary>创建时间</summary>
            public DateTime Creatime { get; set; }
            
            /// <summary>课程id</summary>
            public string Course_id { get; set; }
        }
        #endregion
    }
}