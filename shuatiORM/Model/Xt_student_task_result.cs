/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    数据表Xt_student_task_result对应的业务逻辑层Xt_student_task_result
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_student_task_result_Entity:Xt_student_task_result
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Task_id,Submit_time,Mark,Grade from Xt_student_task_result
delete from Xt_student_task_result
INSERT INTO Xt_student_task_result (Uuid,Task_id,Submit_time,Mark,Grade)
     VALUES
           ('','','','','')
UPDATE Xt_student_task_result SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Task_id = valObj2.Task_id;
        valObj.Submit_time = valObj2.Submit_time;
        valObj.Mark = valObj2.Mark;
        valObj.Grade = valObj2.Grade; 
        valObj.Uuid = "";
        valObj.Task_id = "";
        valObj.Submit_time = "";
        valObj.Mark = "";
        valObj.Grade = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Submit_time": $("#txt_Submit_time").val(),
        "Mark": $("#txt_Mark").val(),
        "Grade": $("#txt_Grade").val(), 
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
    /// <para>学生作业结果表</para>
    /// <para>与Xt_student_task_result数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_task_result : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_student_task_result Factory()
        {
            return new Xt_student_task_result();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 作业id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> 提交时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Submit_time
        {            
            get { return this.Submit_time; }
            set { this.Submit_time = value; }
        }
        
        /// <summary> 成绩:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Mark
        {            
            get { return this.Mark; }
            set { this.Mark = value; }
        }
        
        /// <summary> 分数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
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
        
        /// <summary> 作业id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 提交时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 成绩:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 分数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_task_result].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>作业id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Xt_student_task_result].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>提交时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Submit_time =  new AttributeItem("[Xt_student_task_result].[Submit_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>成绩:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mark =  new AttributeItem("[Xt_student_task_result].[Mark]", typeof(int), 4, default(int));
            
            /// <summary>分数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xt_student_task_result].[Grade]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private DateTime m_submit_time;
        /// <summary></summary>
        protected bool submit_time_initialized = false;
        
        private int m_mark;
        /// <summary></summary>
        protected bool mark_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_task_result";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.submit_time_initialized = IsLoadAllAttributes;this.mark_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_task_result value = new Xt_student_task_result();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_time"))
				value.submit_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mark"))
				value.mark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_student_task_result Clone()
        {
            return (Xt_student_task_result)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_student_task_result()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_student_task_result() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_student_task_result(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_student_task_result(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_student_task_result(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_student_task_result(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_student_task_result(Guid uuid1, string task_id1, DateTime submit_time1, int mark1, int grade1)
        {
            
            this.Uuid = uuid1;
            
            this.Task_id = task_id1;
            
            this.Submit_time = submit_time1;
            
            this.Mark = mark1;
            
            this.Grade = grade1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_student_task_result FromIView(IView view)
        {
            return (Xt_student_task_result)IView.GetITable(view, "Xt_student_task_result");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_student_task_result GetOneInstance()
        {
            Xt_student_task_result value = new Xt_student_task_result();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_student_task_result Retrieve()
        {
            BLLTable<Xt_student_task_result>.GetRowData(this);
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
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Submit_time":
			        return Submit_time;
			    			
			    case "Mark":
			        return Mark;
			    			
			    case "Grade":
			        return Grade;
			
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
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
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
				
				case "Task_id":
					return task_id_initialized;
				
				case "Submit_time":
					return submit_time_initialized;
				
				case "Mark":
					return mark_initialized;
				
				case "Grade":
					return grade_initialized;
				
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
				
				case "Task_id":
					task_id_initialized = ret;
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
                AttributeItem attr = Xt_student_task_result.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Xt_student_task_result.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (submit_time_initialized)
			{
                AttributeItem attr = Xt_student_task_result.Attribute.Submit_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_time);
                }
			}
			
			if (mark_initialized)
			{
                AttributeItem attr = Xt_student_task_result.Attribute.Mark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mark);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xt_student_task_result.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
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
        public class Xt_student_task_resultJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>作业id:[CtrlTypeDic-{InputString}]</summary>
            public string Task_id { get; set; }
            
            /// <summary>提交时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Submit_time { get; set; }
            
            /// <summary>成绩:[CtrlTypeDic-{InputString}]</summary>
            public int Mark { get; set; }
            
            /// <summary>分数:[CtrlTypeDic-{InputString}]</summary>
            public int Grade { get; set; }
        }
        #endregion
    }
}