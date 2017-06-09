/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    数据表Xt_student_test_result对应的业务逻辑层Xt_student_test_result
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_student_test_result_Entity:Xt_student_test_result
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Test_id,Course_id,Mark,Grade,Time,Student_id from Xt_student_test_result
delete from Xt_student_test_result
INSERT INTO Xt_student_test_result (Uuid,Test_id,Course_id,Mark,Grade,Time,Student_id)
     VALUES
           ('','','','','','','')
UPDATE Xt_student_test_result SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Test_id = valObj2.Test_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Mark = valObj2.Mark;
        valObj.Grade = valObj2.Grade;
        valObj.Time = valObj2.Time;
        valObj.Student_id = valObj2.Student_id; 
        valObj.Uuid = "";
        valObj.Test_id = "";
        valObj.Course_id = "";
        valObj.Mark = "";
        valObj.Grade = "";
        valObj.Time = "";
        valObj.Student_id = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Test_id": $("#txt_Test_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Mark": $("#txt_Mark").val(),
        "Grade": $("#txt_Grade").val(),
        "Time": $("#txt_Time").val(),
        "Student_id": $("#txt_Student_id").val(), 
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
    /// <para>学生测验结果表</para>
    /// <para>与Xt_student_test_result数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_test_result : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_student_test_result Factory()
        {
            return new Xt_student_test_result();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 测验id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Test_id
        {            
            get { return this.Test_id; }
            set { this.Test_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
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
        
        /// <summary> 时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Time
        {            
            get { return this.Time; }
            set { this.Time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Time
        {
            get { return this.m_time; }
            set //
            {
                if (!time_initialized || m_time != value)
                {
                    this.m_time = value;
                }
                time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_test_result].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>测验id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Test_id =  new AttributeItem("[Xt_student_test_result].[Test_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_student_test_result].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>成绩:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mark =  new AttributeItem("[Xt_student_test_result].[Mark]", typeof(int), 4, default(int));
            
            /// <summary>分数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xt_student_test_result].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Time =  new AttributeItem("[Xt_student_test_result].[Time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_test_result].[Student_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_test_id;
        /// <summary></summary>
        protected bool test_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private int m_mark;
        /// <summary></summary>
        protected bool mark_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private DateTime m_time;
        /// <summary></summary>
        protected bool time_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_test_result";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.test_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.mark_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.time_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_test_result value = new Xt_student_test_result();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Test_id"))
				value.test_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mark"))
				value.mark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time"))
				value.time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_student_test_result Clone()
        {
            return (Xt_student_test_result)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_student_test_result()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_student_test_result() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_student_test_result(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_student_test_result(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_student_test_result(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_student_test_result(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_student_test_result(Guid uuid1, string test_id1, string course_id1, int mark1, int grade1, DateTime time1, string student_id1)
        {
            
            this.Uuid = uuid1;
            
            this.Test_id = test_id1;
            
            this.Course_id = course_id1;
            
            this.Mark = mark1;
            
            this.Grade = grade1;
            
            this.Time = time1;
            
            this.Student_id = student_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_student_test_result FromIView(IView view)
        {
            return (Xt_student_test_result)IView.GetITable(view, "Xt_student_test_result");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_student_test_result GetOneInstance()
        {
            Xt_student_test_result value = new Xt_student_test_result();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_student_test_result Retrieve()
        {
            BLLTable<Xt_student_test_result>.GetRowData(this);
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
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Mark":
			        return Mark;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Time":
			        return Time;
			    			
			    case "Student_id":
			        return Student_id;
			
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
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mark":
			        this.Mark = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Time":
			        this.Time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
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
				
				case "Course_id":
					return course_id_initialized;
				
				case "Mark":
					return mark_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Time":
					return time_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
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
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Mark":
					mark_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Time":
					time_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
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
                AttributeItem attr = Xt_student_test_result.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (test_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Test_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Test_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (mark_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Mark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mark);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (time_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
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
        public class Xt_student_test_resultJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>测验id:[CtrlTypeDic-{InputString}]</summary>
            public string Test_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>成绩:[CtrlTypeDic-{InputString}]</summary>
            public int Mark { get; set; }
            
            /// <summary>分数:[CtrlTypeDic-{InputString}]</summary>
            public int Grade { get; set; }
            
            /// <summary>时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
        }
        #endregion
    }
}