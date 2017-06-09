/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    数据表Xt_course_group对应的业务逻辑层Xt_course_group
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_course_group_Entity:Xt_course_group
 * 
************************************************************/
/************************************************************
SQL代码：
select Group_id,Course_id,Group_name,User_count from Xt_course_group
delete from Xt_course_group
INSERT INTO Xt_course_group (Group_id,Course_id,Group_name,User_count)
     VALUES
           ('','','','')
UPDATE Xt_course_group SET ...
变量赋值代码：
 *         valObj.Group_id = valObj2.Group_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Group_name = valObj2.Group_name;
        valObj.User_count = valObj2.User_count; 
        valObj.Group_id = "";
        valObj.Course_id = "";
        valObj.Group_name = "";
        valObj.User_count = ""; 
        "Group_id": $("#txt_Group_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Group_name": $("#txt_Group_name").val(),
        "User_count": $("#txt_User_count").val(), 
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
    /// <para>分组</para>
    /// <para>与Xt_course_group数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_group : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_course_group Factory()
        {
            return new Xt_course_group();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 分组ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Group_id
        {            
            get { return this.Group_id; }
            set { this.Group_id = value; }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 分组名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Group_name
        {            
            get { return this.Group_name; }
            set { this.Group_name = value; }
        }
        
        /// <summary> 人数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _User_count
        {            
            get { return this.User_count; }
            set { this.User_count = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 分组ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Group_id
        {
            get { return this.m_group_id; }
            set //
            {
                if (!group_id_initialized || m_group_id != value)
                {
                    this.m_group_id = value;
                }
                group_id_initialized = true;
            }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 分组名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Group_name
        {
            get { return this.m_group_name; }
            set //
            {
                if (!group_name_initialized || m_group_name != value)
                {
                    this.m_group_name = value;
                }
                group_name_initialized = true;
            }
        }
        
        /// <summary> 人数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int User_count
        {
            get { return this.m_user_count; }
            set //
            {
                if (!user_count_initialized || m_user_count != value)
                {
                    this.m_user_count = value;
                }
                user_count_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>分组ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_id =  new AttributeItem("[Xt_course_group].[Group_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_group].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>分组名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_name =  new AttributeItem("[Xt_course_group].[Group_name]", typeof(string), 100, default(string));
            
            /// <summary>人数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_count =  new AttributeItem("[Xt_course_group].[User_count]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_group_id;
        /// <summary></summary>
        protected bool group_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_group_name;
        /// <summary></summary>
        protected bool group_name_initialized = false;
        
        private int m_user_count;
        /// <summary></summary>
        protected bool user_count_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_group";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.group_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.group_name_initialized = IsLoadAllAttributes;this.user_count_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_group value = new Xt_course_group();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_id"))
				value.group_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_name"))
				value.group_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_count"))
				value.user_count_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_course_group Clone()
        {
            return (Xt_course_group)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_course_group()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_course_group() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_course_group(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_course_group(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_course_group(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_course_group(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_course_group(Guid group_id1, string course_id1, string group_name1, int user_count1)
        {
            
            this.Group_id = group_id1;
            
            this.Course_id = course_id1;
            
            this.Group_name = group_name1;
            
            this.User_count = user_count1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_course_group FromIView(IView view)
        {
            return (Xt_course_group)IView.GetITable(view, "Xt_course_group");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_course_group GetOneInstance()
        {
            Xt_course_group value = new Xt_course_group();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_course_group Retrieve()
        {
            BLLTable<Xt_course_group>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Group_id":
			        return Group_id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Group_name":
			        return Group_name;
			    			
			    case "User_count":
			        return User_count;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Group_id":
			        this.Group_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Group_name":
			        this.Group_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_count":
			        this.User_count = Convert.ToInt32(AttributeValue);
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
				case "Group_id":
					return group_id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Group_name":
					return group_name_initialized;
				
				case "User_count":
					return user_count_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Group_id":
					group_id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Group_name":
					group_name_initialized = ret;
					return true;
				
				case "User_count":
					user_count_initialized = ret;
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

			
			if (group_id_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Group_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (group_name_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Group_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_name);
                }
			}
			
			if (user_count_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.User_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_count);
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
        public class Xt_course_groupJson
        {
            
            /// <summary>分组ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Group_id { get; set; }
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>分组名:[CtrlTypeDic-{InputString}]</summary>
            public string Group_name { get; set; }
            
            /// <summary>人数:[CtrlTypeDic-{InputString}]</summary>
            public int User_count { get; set; }
        }
        #endregion
    }
}