/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    数据表Xt_student_test对应的业务逻辑层Xt_student_test
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_student_test_Entity:Xt_student_test
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Test_id,Student_id,Question_id,Approval,Approval_people,Approval_time,Task_result,Submit from Xt_student_test
delete from Xt_student_test
INSERT INTO Xt_student_test (Uuid,Test_id,Student_id,Question_id,Approval,Approval_people,Approval_time,Task_result,Submit)
     VALUES
           ('','','','','','','','','')
UPDATE Xt_student_test SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Test_id = valObj2.Test_id;
        valObj.Student_id = valObj2.Student_id;
        valObj.Question_id = valObj2.Question_id;
        valObj.Approval = valObj2.Approval;
        valObj.Approval_people = valObj2.Approval_people;
        valObj.Approval_time = valObj2.Approval_time;
        valObj.Task_result = valObj2.Task_result;
        valObj.Submit = valObj2.Submit; 
        valObj.Uuid = "";
        valObj.Test_id = "";
        valObj.Student_id = "";
        valObj.Question_id = "";
        valObj.Approval = "";
        valObj.Approval_people = "";
        valObj.Approval_time = "";
        valObj.Task_result = "";
        valObj.Submit = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Test_id": $("#txt_Test_id").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Question_id": $("#txt_Question_id").val(),
        "Approval": $("#txt_Approval").val(),
        "Approval_people": $("#txt_Approval_people").val(),
        "Approval_time": $("#txt_Approval_time").val(),
        "Task_result": $("#txt_Task_result").val(),
        "Submit": $("#txt_Submit").val(), 
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
    /// <para>学生测验关联表-学生答题表</para>
    /// <para>与Xt_student_test数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_test : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_student_test Factory()
        {
            return new Xt_student_test();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 测验id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Test_id
        {            
            get { return this.Test_id; }
            set { this.Test_id = value; }
        }
        
        /// <summary> 学生id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> 问题id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Question_id
        {            
            get { return this.Question_id; }
            set { this.Question_id = value; }
        }
        
        /// <summary> 批阅:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Approval
        {            
            get { return this.Approval; }
            set { this.Approval = value; }
        }
        
        /// <summary> 人数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Approval_people
        {            
            get { return this.Approval_people; }
            set { this.Approval_people = value; }
        }
        
        /// <summary> 批阅时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Approval_time
        {            
            get { return this.Approval_time; }
            set { this.Approval_time = value; }
        }
        
        /// <summary> 测验结果:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Task_result
        {            
            get { return this.Task_result; }
            set { this.Task_result = value; }
        }
        
        /// <summary> 提交:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Submit
        {            
            get { return this.Submit; }
            set { this.Submit = value; }
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
        
        /// <summary> 测验id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 学生id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 问题id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Question_id
        {
            get { return this.m_question_id; }
            set //
            {
                if (!question_id_initialized || m_question_id != value)
                {
                    this.m_question_id = value;
                }
                question_id_initialized = true;
            }
        }
        
        /// <summary> 批阅:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 人数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 批阅时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 测验结果:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 提交:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_test].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>测验id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Test_id =  new AttributeItem("[Xt_student_test].[Test_id]", typeof(string), 36, default(string));
            
            /// <summary>学生id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_test].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>问题id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_id =  new AttributeItem("[Xt_student_test].[Question_id]", typeof(string), 36, default(string));
            
            /// <summary>批阅:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Approval =  new AttributeItem("[Xt_student_test].[Approval]", typeof(string), 1, default(string));
            
            /// <summary>人数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Approval_people =  new AttributeItem("[Xt_student_test].[Approval_people]", typeof(string), 50, default(string));
            
            /// <summary>批阅时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Approval_time =  new AttributeItem("[Xt_student_test].[Approval_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>测验结果:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_result =  new AttributeItem("[Xt_student_test].[Task_result]", typeof(string), 1, default(string));
            
            /// <summary>提交:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Submit =  new AttributeItem("[Xt_student_test].[Submit]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_test_id;
        /// <summary></summary>
        protected bool test_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_question_id;
        /// <summary></summary>
        protected bool question_id_initialized = false;
        
        private string m_approval;
        /// <summary></summary>
        protected bool approval_initialized = false;
        
        private string m_approval_people;
        /// <summary></summary>
        protected bool approval_people_initialized = false;
        
        private DateTime m_approval_time;
        /// <summary></summary>
        protected bool approval_time_initialized = false;
        
        private string m_task_result;
        /// <summary></summary>
        protected bool task_result_initialized = false;
        
        private string m_submit;
        /// <summary></summary>
        protected bool submit_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_test";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.test_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.question_id_initialized = IsLoadAllAttributes;this.approval_initialized = IsLoadAllAttributes;this.approval_people_initialized = IsLoadAllAttributes;this.approval_time_initialized = IsLoadAllAttributes;this.task_result_initialized = IsLoadAllAttributes;this.submit_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_test value = new Xt_student_test();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Test_id"))
				value.test_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_id"))
				value.question_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval"))
				value.approval_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_people"))
				value.approval_people_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_time"))
				value.approval_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_result"))
				value.task_result_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit"))
				value.submit_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_student_test Clone()
        {
            return (Xt_student_test)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_student_test()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_student_test() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_student_test(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_student_test(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_student_test(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_student_test(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_student_test(Guid uuid1, string test_id1, string student_id1, string question_id1, string approval1, string approval_people1, DateTime approval_time1, string task_result1, string submit1)
        {
            
            this.Uuid = uuid1;
            
            this.Test_id = test_id1;
            
            this.Student_id = student_id1;
            
            this.Question_id = question_id1;
            
            this.Approval = approval1;
            
            this.Approval_people = approval_people1;
            
            this.Approval_time = approval_time1;
            
            this.Task_result = task_result1;
            
            this.Submit = submit1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_student_test FromIView(IView view)
        {
            return (Xt_student_test)IView.GetITable(view, "Xt_student_test");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_student_test GetOneInstance()
        {
            Xt_student_test value = new Xt_student_test();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_student_test Retrieve()
        {
            BLLTable<Xt_student_test>.GetRowData(this);
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
			    			
			    case "Test_id":
			        return Test_id;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Question_id":
			        return Question_id;
			    			
			    case "Approval":
			        return Approval;
			    			
			    case "Approval_people":
			        return Approval_people;
			    			
			    case "Approval_time":
			        return Approval_time;
			    			
			    case "Task_result":
			        return Task_result;
			    			
			    case "Submit":
			        return Submit;
			
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
			    			
			    case "Test_id":
			        this.Test_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question_id":
			        this.Question_id = Convert.ToString(AttributeValue);
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
			    			
			    case "Task_result":
			        this.Task_result = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit":
			        this.Submit = Convert.ToString(AttributeValue);
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
				
				case "Test_id":
					return test_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Question_id":
					return question_id_initialized;
				
				case "Approval":
					return approval_initialized;
				
				case "Approval_people":
					return approval_people_initialized;
				
				case "Approval_time":
					return approval_time_initialized;
				
				case "Task_result":
					return task_result_initialized;
				
				case "Submit":
					return submit_initialized;
				
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
				
				case "Test_id":
					test_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Question_id":
					question_id_initialized = ret;
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
				
				case "Task_result":
					task_result_initialized = ret;
					return true;
				
				case "Submit":
					submit_initialized = ret;
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
                AttributeItem attr = Xt_student_test.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (test_id_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Test_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Test_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (question_id_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Question_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_id);
                }
			}
			
			if (approval_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Approval;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval);
                }
			}
			
			if (approval_people_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Approval_people;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_people);
                }
			}
			
			if (approval_time_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Approval_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_time);
                }
			}
			
			if (task_result_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Task_result;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_result);
                }
			}
			
			if (submit_initialized)
			{
                AttributeItem attr = Xt_student_test.Attribute.Submit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit);
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
        public class Xt_student_testJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>测验id:[CtrlTypeDic-{InputString}]</summary>
            public string Test_id { get; set; }
            
            /// <summary>学生id:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>问题id:[CtrlTypeDic-{InputString}]</summary>
            public string Question_id { get; set; }
            
            /// <summary>批阅:[CtrlTypeDic-{InputString}]</summary>
            public string Approval { get; set; }
            
            /// <summary>人数:[CtrlTypeDic-{InputString}]</summary>
            public string Approval_people { get; set; }
            
            /// <summary>批阅时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Approval_time { get; set; }
            
            /// <summary>测验结果:[CtrlTypeDic-{InputString}]</summary>
            public string Task_result { get; set; }
            
            /// <summary>提交:[CtrlTypeDic-{InputString}]</summary>
            public string Submit { get; set; }
        }
        #endregion
    }
}