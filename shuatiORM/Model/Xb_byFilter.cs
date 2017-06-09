/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:01
  Description:    数据表Xb_byFilter对应的业务逻辑层Xb_byFilter
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_byFilter_Entity:Xb_byFilter
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Catelog,Grade,Kemu,Service_type,Sex,SortRules,Teach_exp,Teacher_mode,Teacher_type from Xb_byFilter
delete from Xb_byFilter
INSERT INTO Xb_byFilter (Id,Catelog,Grade,Kemu,Service_type,Sex,SortRules,Teach_exp,Teacher_mode,Teacher_type)
     VALUES
           ('','','','','','','','','','')
UPDATE Xb_byFilter SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Catelog = valObj2.Catelog;
        valObj.Grade = valObj2.Grade;
        valObj.Kemu = valObj2.Kemu;
        valObj.Service_type = valObj2.Service_type;
        valObj.Sex = valObj2.Sex;
        valObj.SortRules = valObj2.SortRules;
        valObj.Teach_exp = valObj2.Teach_exp;
        valObj.Teacher_mode = valObj2.Teacher_mode;
        valObj.Teacher_type = valObj2.Teacher_type; 
        valObj.Id = "";
        valObj.Catelog = "";
        valObj.Grade = "";
        valObj.Kemu = "";
        valObj.Service_type = "";
        valObj.Sex = "";
        valObj.SortRules = "";
        valObj.Teach_exp = "";
        valObj.Teacher_mode = "";
        valObj.Teacher_type = ""; 
        "Id": $("#txt_Id").val(),
        "Catelog": $("#txt_Catelog").val(),
        "Grade": $("#txt_Grade").val(),
        "Kemu": $("#txt_Kemu").val(),
        "Service_type": $("#txt_Service_type").val(),
        "Sex": $("#txt_Sex").val(),
        "SortRules": $("#txt_SortRules").val(),
        "Teach_exp": $("#txt_Teach_exp").val(),
        "Teacher_mode": $("#txt_Teacher_mode").val(),
        "Teacher_type": $("#txt_Teacher_type").val(), 
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
    /// <para>条件过滤</para>
    /// <para>与Xb_byFilter数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_byFilter : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_byFilter Factory()
        {
            return new Xb_byFilter();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> Tab大类:[Enum-{0:家教},{1:外教},{2:小班课},{3:暑期课}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Catelog
        {            
            get { return this.Catelog; }
            set { this.Catelog = value; }
        }
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> 科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> 服务方式:[Enum-{0:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Service_type
        {            
            get { return this.Service_type; }
            set { this.Service_type = value; }
        }
        
        /// <summary> 性别:[Enum-{0:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> 排序方式:[Enum-{0:不限},{1:口碑最好},{2:授课最多},{3:距离最近},{4:智能排序}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _SortRules
        {            
            get { return this.SortRules; }
            set { this.SortRules = value; }
        }
        
        /// <summary> 教课经验:[Enum-{0:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teach_exp
        {            
            get { return this.Teach_exp; }
            set { this.Teach_exp = value; }
        }
        
        /// <summary> 教学模式:[Enum-{0:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teacher_mode
        {            
            get { return this.Teacher_mode; }
            set { this.Teacher_mode = value; }
        }
        
        /// <summary> 讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teacher_type
        {            
            get { return this.Teacher_type; }
            set { this.Teacher_type = value; }
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
        
        /// <summary> Tab大类:[Enum-{0:家教},{1:外教},{2:小班课},{3:暑期课}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Catelog
        {
            get { return this.m_catelog; }
            set //
            {
                if (!catelog_initialized || m_catelog != value)
                {
                    this.m_catelog = value;
                }
                catelog_initialized = true;
            }
        }
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Kemu
        {
            get { return this.m_kemu; }
            set //
            {
                if (!kemu_initialized || m_kemu != value)
                {
                    this.m_kemu = value;
                }
                kemu_initialized = true;
            }
        }
        
        /// <summary> 服务方式:[Enum-{0:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Service_type
        {
            get { return this.m_service_type; }
            set //
            {
                if (!service_type_initialized || m_service_type != value)
                {
                    this.m_service_type = value;
                }
                service_type_initialized = true;
            }
        }
        
        /// <summary> 性别:[Enum-{0:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> 排序方式:[Enum-{0:不限},{1:口碑最好},{2:授课最多},{3:距离最近},{4:智能排序}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string SortRules
        {
            get { return this.m_sortrules; }
            set //
            {
                if (!sortrules_initialized || m_sortrules != value)
                {
                    this.m_sortrules = value;
                }
                sortrules_initialized = true;
            }
        }
        
        /// <summary> 教课经验:[Enum-{0:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Teach_exp
        {
            get { return this.m_teach_exp; }
            set //
            {
                if (!teach_exp_initialized || m_teach_exp != value)
                {
                    this.m_teach_exp = value;
                }
                teach_exp_initialized = true;
            }
        }
        
        /// <summary> 教学模式:[Enum-{0:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Teacher_mode
        {
            get { return this.m_teacher_mode; }
            set //
            {
                if (!teacher_mode_initialized || m_teacher_mode != value)
                {
                    this.m_teacher_mode = value;
                }
                teacher_mode_initialized = true;
            }
        }
        
        /// <summary> 讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int Teacher_type
        {
            get { return this.m_teacher_type; }
            set //
            {
                if (!teacher_type_initialized || m_teacher_type != value)
                {
                    this.m_teacher_type = value;
                }
                teacher_type_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_byFilter].[Id]", typeof(int), 4, default(int));
            
            /// <summary>Tab大类:[Enum-{0:家教},{1:外教},{2:小班课},{3:暑期课}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Catelog =  new AttributeItem("[Xb_byFilter].[Catelog]", typeof(int), 4, default(int));
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_byFilter].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[Xb_byFilter].[Kemu]", typeof(int), 4, default(int));
            
            /// <summary>服务方式:[Enum-{0:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Service_type =  new AttributeItem("[Xb_byFilter].[Service_type]", typeof(int), 4, default(int));
            
            /// <summary>性别:[Enum-{0:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_byFilter].[Sex]", typeof(int), 4, default(int));
            
            /// <summary>排序方式:[Enum-{0:不限},{1:口碑最好},{2:授课最多},{3:距离最近},{4:智能排序}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem SortRules =  new AttributeItem("[Xb_byFilter].[SortRules]", typeof(string), 50, default(string));
            
            /// <summary>教课经验:[Enum-{0:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teach_exp =  new AttributeItem("[Xb_byFilter].[Teach_exp]", typeof(int), 4, default(int));
            
            /// <summary>教学模式:[Enum-{0:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teacher_mode =  new AttributeItem("[Xb_byFilter].[Teacher_mode]", typeof(int), 4, default(int));
            
            /// <summary>讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teacher_type =  new AttributeItem("[Xb_byFilter].[Teacher_type]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_catelog;
        /// <summary></summary>
        protected bool catelog_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private int m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private int m_service_type;
        /// <summary></summary>
        protected bool service_type_initialized = false;
        
        private int m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_sortrules;
        /// <summary></summary>
        protected bool sortrules_initialized = false;
        
        private int m_teach_exp;
        /// <summary></summary>
        protected bool teach_exp_initialized = false;
        
        private int m_teacher_mode;
        /// <summary></summary>
        protected bool teacher_mode_initialized = false;
        
        private int m_teacher_type;
        /// <summary></summary>
        protected bool teacher_type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_byFilter";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.catelog_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.service_type_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.sortrules_initialized = IsLoadAllAttributes;this.teach_exp_initialized = IsLoadAllAttributes;this.teacher_mode_initialized = IsLoadAllAttributes;this.teacher_type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_byFilter value = new Xb_byFilter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Catelog"))
				value.catelog_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Service_type"))
				value.service_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SortRules"))
				value.sortrules_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teach_exp"))
				value.teach_exp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_mode"))
				value.teacher_mode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_type"))
				value.teacher_type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_byFilter Clone()
        {
            return (Xb_byFilter)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_byFilter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_byFilter() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_byFilter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_byFilter(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_byFilter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_byFilter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_byFilter(int id1, int catelog1, int grade1, int kemu1, int service_type1, int sex1, string sortrules1, int teach_exp1, int teacher_mode1, int teacher_type1)
        {
            
            this.Id = id1;
            
            this.Catelog = catelog1;
            
            this.Grade = grade1;
            
            this.Kemu = kemu1;
            
            this.Service_type = service_type1;
            
            this.Sex = sex1;
            
            this.SortRules = sortrules1;
            
            this.Teach_exp = teach_exp1;
            
            this.Teacher_mode = teacher_mode1;
            
            this.Teacher_type = teacher_type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_byFilter FromIView(IView view)
        {
            return (Xb_byFilter)IView.GetITable(view, "Xb_byFilter");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_byFilter GetOneInstance()
        {
            Xb_byFilter value = new Xb_byFilter();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_byFilter Retrieve()
        {
            BLLTable<Xb_byFilter>.GetRowData(this);
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
			    			
			    case "Catelog":
			        return Catelog;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "Service_type":
			        return Service_type;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "SortRules":
			        return SortRules;
			    			
			    case "Teach_exp":
			        return Teach_exp;
			    			
			    case "Teacher_mode":
			        return Teacher_mode;
			    			
			    case "Teacher_type":
			        return Teacher_type;
			
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
			    			
			    case "Catelog":
			        this.Catelog = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Service_type":
			        this.Service_type = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SortRules":
			        this.SortRules = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teach_exp":
			        this.Teach_exp = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_mode":
			        this.Teacher_mode = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_type":
			        this.Teacher_type = Convert.ToInt32(AttributeValue);
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
				
				case "Catelog":
					return catelog_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "Service_type":
					return service_type_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "SortRules":
					return sortrules_initialized;
				
				case "Teach_exp":
					return teach_exp_initialized;
				
				case "Teacher_mode":
					return teacher_mode_initialized;
				
				case "Teacher_type":
					return teacher_type_initialized;
				
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
				
				case "Catelog":
					catelog_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "Service_type":
					service_type_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "SortRules":
					sortrules_initialized = ret;
					return true;
				
				case "Teach_exp":
					teach_exp_initialized = ret;
					return true;
				
				case "Teacher_mode":
					teacher_mode_initialized = ret;
					return true;
				
				case "Teacher_type":
					teacher_type_initialized = ret;
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
                AttributeItem attr = Xb_byFilter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (catelog_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Catelog;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Catelog);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (service_type_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Service_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Service_type);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (sortrules_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.SortRules;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SortRules);
                }
			}
			
			if (teach_exp_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teach_exp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teach_exp);
                }
			}
			
			if (teacher_mode_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teacher_mode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_mode);
                }
			}
			
			if (teacher_type_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teacher_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_type);
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
        public class Xb_byFilterJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>Tab大类:[Enum-{0:家教},{1:外教},{2:小班课},{3:暑期课}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Catelog { get; set; }
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Grade { get; set; }
            
            /// <summary>科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Kemu { get; set; }
            
            /// <summary>服务方式:[Enum-{0:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Service_type { get; set; }
            
            /// <summary>性别:[Enum-{0:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Sex { get; set; }
            
            /// <summary>排序方式:[Enum-{0:不限},{1:口碑最好},{2:授课最多},{3:距离最近},{4:智能排序}][CtrlTypeDic-{SelectDrop}]</summary>
            public string SortRules { get; set; }
            
            /// <summary>教课经验:[Enum-{0:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teach_exp { get; set; }
            
            /// <summary>教学模式:[Enum-{0:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teacher_mode { get; set; }
            
            /// <summary>讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teacher_type { get; set; }
        }
        #endregion
    }
}