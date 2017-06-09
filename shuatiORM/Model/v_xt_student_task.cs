/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    数据表V_xt_student_task对应的业务逻辑层V_xt_student_task
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 V_xt_student_task_Entity:V_xt_student_task
 * 
************************************************************/
/************************************************************
SQL代码：
select Taskfile,Student_id,Submit,Task_result,Approval,Approval_people,Approval_time,Submit_time,Mark,Grade,Task_id from V_xt_student_task
delete from V_xt_student_task
INSERT INTO V_xt_student_task (Taskfile,Student_id,Submit,Task_result,Approval,Approval_people,Approval_time,Submit_time,Mark,Grade,Task_id)
     VALUES
           ('','','','','','','','','','','')
UPDATE V_xt_student_task SET ...
变量赋值代码：
 *         valObj.Taskfile = valObj2.Taskfile;
        valObj.Student_id = valObj2.Student_id;
        valObj.Submit = valObj2.Submit;
        valObj.Task_result = valObj2.Task_result;
        valObj.Approval = valObj2.Approval;
        valObj.Approval_people = valObj2.Approval_people;
        valObj.Approval_time = valObj2.Approval_time;
        valObj.Submit_time = valObj2.Submit_time;
        valObj.Mark = valObj2.Mark;
        valObj.Grade = valObj2.Grade;
        valObj.Task_id = valObj2.Task_id; 
        valObj.Taskfile = "";
        valObj.Student_id = "";
        valObj.Submit = "";
        valObj.Task_result = "";
        valObj.Approval = "";
        valObj.Approval_people = "";
        valObj.Approval_time = "";
        valObj.Submit_time = "";
        valObj.Mark = "";
        valObj.Grade = "";
        valObj.Task_id = ""; 
        "Taskfile": $("#txt_Taskfile").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Submit": $("#txt_Submit").val(),
        "Task_result": $("#txt_Task_result").val(),
        "Approval": $("#txt_Approval").val(),
        "Approval_people": $("#txt_Approval_people").val(),
        "Approval_time": $("#txt_Approval_time").val(),
        "Submit_time": $("#txt_Submit_time").val(),
        "Mark": $("#txt_Mark").val(),
        "Grade": $("#txt_Grade").val(),
        "Task_id": $("#txt_Task_id").val(), 
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
    /// <para>学生作业关联表__学生作业结果表:[Inner-{Xt_student_task:0},{Xt_student_task_result:1}]</para>
    /// <para>与V_xt_student_task数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class V_xt_student_task : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static V_xt_student_task Factory()
        {
            return new V_xt_student_task();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 作业文件 Attribute_IsNotNull </summary>
        public string _Taskfile
        {            
            get { return this.Taskfile; }
            set { this.Taskfile = value; }
        }
        
        /// <summary> 学生ID Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> 提交时间 Attribute_IsNotNull </summary>
        public string _Submit
        {            
            get { return this.Submit; }
            set { this.Submit = value; }
        }
        
        /// <summary> 作业结果 Attribute_IsNotNull </summary>
        public string _Task_result
        {            
            get { return this.Task_result; }
            set { this.Task_result = value; }
        }
        
        /// <summary> 审批状态 Attribute_IsNotNull </summary>
        public string _Approval
        {            
            get { return this.Approval; }
            set { this.Approval = value; }
        }
        
        /// <summary> 审批人 Attribute_IsNotNull </summary>
        public string _Approval_people
        {            
            get { return this.Approval_people; }
            set { this.Approval_people = value; }
        }
        
        /// <summary> 审批时间 Attribute_IsNotNull </summary>
        public DateTime _Approval_time
        {            
            get { return this.Approval_time; }
            set { this.Approval_time = value; }
        }
        
        /// <summary> 提交时间 Attribute_IsNotNull </summary>
        public DateTime _Submit_time
        {            
            get { return this.Submit_time; }
            set { this.Submit_time = value; }
        }
        
        /// <summary> 成绩 Attribute_IsNotNull </summary>
        public int _Mark
        {            
            get { return this.Mark; }
            set { this.Mark = value; }
        }
        
        /// <summary> 分数 Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> 作业ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 作业文件，推荐使用 "_"符号开头 </summary>
        public string Taskfile
        {
            get { return this.m_taskfile; }
            set //
            {
                if (!taskfile_initialized || m_taskfile != value)
                {
                    this.m_taskfile = value;
                }
                taskfile_initialized = true;
            }
        }
        
        /// <summary> 学生ID，推荐使用 "_"符号开头 </summary>
        public string Student_id
        {
            get { return this.m_student_id; }
            set //
            {
                if (!student_id_initialized || m_student_id != value)
                {
                    this.m_student_id = value;
                }
                student_id_initialized = true;
            }
        }
        
        /// <summary> 提交时间，推荐使用 "_"符号开头 </summary>
        public string Submit
        {
            get { return this.m_submit; }
            set //
            {
                if (!submit_initialized || m_submit != value)
                {
                    this.m_submit = value;
                }
                submit_initialized = true;
            }
        }
        
        /// <summary> 作业结果，推荐使用 "_"符号开头 </summary>
        public string Task_result
        {
            get { return this.m_task_result; }
            set //
            {
                if (!task_result_initialized || m_task_result != value)
                {
                    this.m_task_result = value;
                }
                task_result_initialized = true;
            }
        }
        
        /// <summary> 审批状态，推荐使用 "_"符号开头 </summary>
        public string Approval
        {
            get { return this.m_approval; }
            set //
            {
                if (!approval_initialized || m_approval != value)
                {
                    this.m_approval = value;
                }
                approval_initialized = true;
            }
        }
        
        /// <summary> 审批人，推荐使用 "_"符号开头 </summary>
        public string Approval_people
        {
            get { return this.m_approval_people; }
            set //
            {
                if (!approval_people_initialized || m_approval_people != value)
                {
                    this.m_approval_people = value;
                }
                approval_people_initialized = true;
            }
        }
        
        /// <summary> 审批时间，推荐使用 "_"符号开头 </summary>
        public DateTime Approval_time
        {
            get { return this.m_approval_time; }
            set //
            {
                if (!approval_time_initialized || m_approval_time != value)
                {
                    this.m_approval_time = value;
                }
                approval_time_initialized = true;
            }
        }
        
        /// <summary> 提交时间，推荐使用 "_"符号开头 </summary>
        public DateTime Submit_time
        {
            get { return this.m_submit_time; }
            set //
            {
                if (!submit_time_initialized || m_submit_time != value)
                {
                    this.m_submit_time = value;
                }
                submit_time_initialized = true;
            }
        }
        
        /// <summary> 成绩，推荐使用 "_"符号开头 </summary>
        public int Mark
        {
            get { return this.m_mark; }
            set //
            {
                if (!mark_initialized || m_mark != value)
                {
                    this.m_mark = value;
                }
                mark_initialized = true;
            }
        }
        
        /// <summary> 分数，推荐使用 "_"符号开头 </summary>
        public int Grade
        {
            get { return this.m_grade; }
            set //
            {
                if (!grade_initialized || m_grade != value)
                {
                    this.m_grade = value;
                }
                grade_initialized = true;
            }
        }
        
        /// <summary> 作业ID，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>作业文件</summary>
            public static AttributeItem Taskfile =  new AttributeItem("[V_xt_student_task].[Taskfile]", typeof(string), 50, default(string));
            
            /// <summary>学生ID</summary>
            public static AttributeItem Student_id =  new AttributeItem("[V_xt_student_task].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>提交时间</summary>
            public static AttributeItem Submit =  new AttributeItem("[V_xt_student_task].[Submit]", typeof(string), 36, default(string));
            
            /// <summary>作业结果</summary>
            public static AttributeItem Task_result =  new AttributeItem("[V_xt_student_task].[Task_result]", typeof(string), 1, default(string));
            
            /// <summary>审批状态</summary>
            public static AttributeItem Approval =  new AttributeItem("[V_xt_student_task].[Approval]", typeof(string), 1, default(string));
            
            /// <summary>审批人</summary>
            public static AttributeItem Approval_people =  new AttributeItem("[V_xt_student_task].[Approval_people]", typeof(string), 50, default(string));
            
            /// <summary>审批时间</summary>
            public static AttributeItem Approval_time =  new AttributeItem("[V_xt_student_task].[Approval_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>提交时间</summary>
            public static AttributeItem Submit_time =  new AttributeItem("[V_xt_student_task].[Submit_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>成绩</summary>
            public static AttributeItem Mark =  new AttributeItem("[V_xt_student_task].[Mark]", typeof(int), 4, default(int));
            
            /// <summary>分数</summary>
            public static AttributeItem Grade =  new AttributeItem("[V_xt_student_task].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>作业ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[V_xt_student_task].[Task_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_taskfile;
        /// <summary></summary>
        protected bool taskfile_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_submit;
        /// <summary></summary>
        protected bool submit_initialized = false;
        
        private string m_task_result;
        /// <summary></summary>
        protected bool task_result_initialized = false;
        
        private string m_approval;
        /// <summary></summary>
        protected bool approval_initialized = false;
        
        private string m_approval_people;
        /// <summary></summary>
        protected bool approval_people_initialized = false;
        
        private DateTime m_approval_time;
        /// <summary></summary>
        protected bool approval_time_initialized = false;
        
        private DateTime m_submit_time;
        /// <summary></summary>
        protected bool submit_time_initialized = false;
        
        private int m_mark;
        /// <summary></summary>
        protected bool mark_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_xt_student_task";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.taskfile_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.submit_initialized = IsLoadAllAttributes;this.task_result_initialized = IsLoadAllAttributes;this.approval_initialized = IsLoadAllAttributes;this.approval_people_initialized = IsLoadAllAttributes;this.approval_time_initialized = IsLoadAllAttributes;this.submit_time_initialized = IsLoadAllAttributes;this.mark_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xt_student_task value = new V_xt_student_task();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Taskfile"))
				value.taskfile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit"))
				value.submit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_result"))
				value.task_result_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval"))
				value.approval_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_people"))
				value.approval_people_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_time"))
				value.approval_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_time"))
				value.submit_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mark"))
				value.mark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new V_xt_student_task Clone()
        {
            return (V_xt_student_task)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static V_xt_student_task()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public V_xt_student_task() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public V_xt_student_task(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public V_xt_student_task(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public V_xt_student_task(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public V_xt_student_task(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public V_xt_student_task(string taskfile1, string student_id1, string submit1, string task_result1, string approval1, string approval_people1, DateTime approval_time1, DateTime submit_time1, int mark1, int grade1, string task_id1)
        {
            
            this.Taskfile = taskfile1;
            
            this.Student_id = student_id1;
            
            this.Submit = submit1;
            
            this.Task_result = task_result1;
            
            this.Approval = approval1;
            
            this.Approval_people = approval_people1;
            
            this.Approval_time = approval_time1;
            
            this.Submit_time = submit_time1;
            
            this.Mark = mark1;
            
            this.Grade = grade1;
            
            this.Task_id = task_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static V_xt_student_task FromIView(IView view)
        {
            return (V_xt_student_task)IView.GetITable(view, "V_xt_student_task");
        }
        /// <summary>获得一个实例  </summary>
        public static V_xt_student_task GetOneInstance()
        {
            V_xt_student_task value = new V_xt_student_task();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public V_xt_student_task Retrieve()
        {
            BLLTable<V_xt_student_task>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Taskfile":
			        return Taskfile;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Submit":
			        return Submit;
			    			
			    case "Task_result":
			        return Task_result;
			    			
			    case "Approval":
			        return Approval;
			    			
			    case "Approval_people":
			        return Approval_people;
			    			
			    case "Approval_time":
			        return Approval_time;
			    			
			    case "Submit_time":
			        return Submit_time;
			    			
			    case "Mark":
			        return Mark;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Task_id":
			        return Task_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Taskfile":
			        this.Taskfile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit":
			        this.Submit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_result":
			        this.Task_result = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval":
			        this.Approval = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval_people":
			        this.Approval_people = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval_time":
			        this.Approval_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Submit_time":
			        this.Submit_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Mark":
			        this.Mark = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
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
				case "Taskfile":
					return taskfile_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Submit":
					return submit_initialized;
				
				case "Task_result":
					return task_result_initialized;
				
				case "Approval":
					return approval_initialized;
				
				case "Approval_people":
					return approval_people_initialized;
				
				case "Approval_time":
					return approval_time_initialized;
				
				case "Submit_time":
					return submit_time_initialized;
				
				case "Mark":
					return mark_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Taskfile":
					taskfile_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Submit":
					submit_initialized = ret;
					return true;
				
				case "Task_result":
					task_result_initialized = ret;
					return true;
				
				case "Approval":
					approval_initialized = ret;
					return true;
				
				case "Approval_people":
					approval_people_initialized = ret;
					return true;
				
				case "Approval_time":
					approval_time_initialized = ret;
					return true;
				
				case "Submit_time":
					submit_time_initialized = ret;
					return true;
				
				case "Mark":
					mark_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
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

			
			if (taskfile_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Taskfile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Taskfile);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (submit_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Submit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit);
                }
			}
			
			if (task_result_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Task_result;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_result);
                }
			}
			
			if (approval_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval);
                }
			}
			
			if (approval_people_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval_people;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_people);
                }
			}
			
			if (approval_time_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_time);
                }
			}
			
			if (submit_time_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Submit_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_time);
                }
			}
			
			if (mark_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Mark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mark);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
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
        public class V_xt_student_taskJson
        {
            
            /// <summary>作业文件</summary>
            public string Taskfile { get; set; }
            
            /// <summary>学生ID</summary>
            public string Student_id { get; set; }
            
            /// <summary>提交时间</summary>
            public string Submit { get; set; }
            
            /// <summary>作业结果</summary>
            public string Task_result { get; set; }
            
            /// <summary>审批状态</summary>
            public string Approval { get; set; }
            
            /// <summary>审批人</summary>
            public string Approval_people { get; set; }
            
            /// <summary>审批时间</summary>
            public DateTime Approval_time { get; set; }
            
            /// <summary>提交时间</summary>
            public DateTime Submit_time { get; set; }
            
            /// <summary>成绩</summary>
            public int Mark { get; set; }
            
            /// <summary>分数</summary>
            public int Grade { get; set; }
            
            /// <summary>作业ID</summary>
            public string Task_id { get; set; }
        }
        #endregion
    }
}