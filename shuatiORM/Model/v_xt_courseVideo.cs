/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    数据表V_xt_courseVideo对应的业务逻辑层V_xt_courseVideo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 V_xt_courseVideo_Entity:V_xt_courseVideo
 * 
************************************************************/
/************************************************************
SQL代码：
select Course_id,Name,Url,Level,CreateTime,Duration,Category,Uuid from V_xt_courseVideo
delete from V_xt_courseVideo
INSERT INTO V_xt_courseVideo (Course_id,Name,Url,Level,CreateTime,Duration,Category,Uuid)
     VALUES
           ('','','','','','','','')
UPDATE V_xt_courseVideo SET ...
变量赋值代码：
 *         valObj.Course_id = valObj2.Course_id;
        valObj.Name = valObj2.Name;
        valObj.Url = valObj2.Url;
        valObj.Level = valObj2.Level;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Duration = valObj2.Duration;
        valObj.Category = valObj2.Category;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Course_id = "";
        valObj.Name = "";
        valObj.Url = "";
        valObj.Level = "";
        valObj.CreateTime = "";
        valObj.Duration = "";
        valObj.Category = "";
        valObj.Uuid = ""; 
        "Course_id": $("#txt_Course_id").val(),
        "Name": $("#txt_Name").val(),
        "Url": $("#txt_Url").val(),
        "Level": $("#txt_Level").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Duration": $("#txt_Duration").val(),
        "Category": $("#txt_Category").val(),
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
    /// <para>班级表__Xt_course_video:[Inner-{Xt_course:0},{Xt_course_video:1}]</para>
    /// <para>与V_xt_courseVideo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class V_xt_courseVideo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static V_xt_courseVideo Factory()
        {
            return new V_xt_courseVideo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 课程id Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 名称 Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Level
        {            
            get { return this.Level; }
            set { this.Level = value; }
        }
        
        /// <summary> 创建时间 Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Duration
        {            
            get { return this.Duration; }
            set { this.Duration = value; }
        }
        
        /// <summary> 课程分类 Attribute_IsNotNull </summary>
        public string _Category
        {            
            get { return this.Category; }
            set { this.Category = value; }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        
        /// <summary> 名称，推荐使用 "_"符号开头 </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Level
        {
            get { return this.m_level; }
            set //
            {
                if (!level_initialized || m_level != value)
                {
                    this.m_level = value;
                }
                level_initialized = true;
            }
        }
        
        /// <summary> 创建时间，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Duration
        {
            get { return this.m_duration; }
            set //
            {
                if (!duration_initialized || m_duration != value)
                {
                    this.m_duration = value;
                }
                duration_initialized = true;
            }
        }
        
        /// <summary> 课程分类，推荐使用 "_"符号开头 </summary>
        public string Category
        {
            get { return this.m_category; }
            set //
            {
                if (!category_initialized || m_category != value)
                {
                    this.m_category = value;
                }
                category_initialized = true;
            }
        }
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
            
            /// <summary>课程id</summary>
            public static AttributeItem Course_id =  new AttributeItem("[V_xt_courseVideo].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>名称</summary>
            public static AttributeItem Name =  new AttributeItem("[V_xt_courseVideo].[Name]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Url =  new AttributeItem("[V_xt_courseVideo].[Url]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Level =  new AttributeItem("[V_xt_courseVideo].[Level]", typeof(int), 4, default(int));
            
            /// <summary>创建时间</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[V_xt_courseVideo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Duration =  new AttributeItem("[V_xt_courseVideo].[Duration]", typeof(string), 100, default(string));
            
            /// <summary>课程分类</summary>
            public static AttributeItem Category =  new AttributeItem("[V_xt_courseVideo].[Category]", typeof(string), 100, default(string));
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[V_xt_courseVideo].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private int m_level;
        /// <summary></summary>
        protected bool level_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_duration;
        /// <summary></summary>
        protected bool duration_initialized = false;
        
        private string m_category;
        /// <summary></summary>
        protected bool category_initialized = false;
        
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
            return "V_xt_courseVideo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.course_id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.level_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.duration_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xt_courseVideo value = new V_xt_courseVideo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Level"))
				value.level_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Duration"))
				value.duration_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new V_xt_courseVideo Clone()
        {
            return (V_xt_courseVideo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static V_xt_courseVideo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public V_xt_courseVideo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public V_xt_courseVideo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public V_xt_courseVideo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public V_xt_courseVideo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public V_xt_courseVideo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public V_xt_courseVideo(string course_id1, string name1, string url1, int level1, DateTime createtime1, string duration1, string category1, Guid uuid1)
        {
            
            this.Course_id = course_id1;
            
            this.Name = name1;
            
            this.Url = url1;
            
            this.Level = level1;
            
            this.CreateTime = createtime1;
            
            this.Duration = duration1;
            
            this.Category = category1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static V_xt_courseVideo FromIView(IView view)
        {
            return (V_xt_courseVideo)IView.GetITable(view, "V_xt_courseVideo");
        }
        /// <summary>获得一个实例  </summary>
        public static V_xt_courseVideo GetOneInstance()
        {
            V_xt_courseVideo value = new V_xt_courseVideo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public V_xt_courseVideo Retrieve()
        {
            BLLTable<V_xt_courseVideo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Course_id":
			        return Course_id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Url":
			        return Url;
			    			
			    case "Level":
			        return Level;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Duration":
			        return Duration;
			    			
			    case "Category":
			        return Category;
			    			
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
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Level":
			        this.Level = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Duration":
			        this.Duration = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category":
			        this.Category = Convert.ToString(AttributeValue);
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
				case "Course_id":
					return course_id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Url":
					return url_initialized;
				
				case "Level":
					return level_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Duration":
					return duration_initialized;
				
				case "Category":
					return category_initialized;
				
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
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "Level":
					level_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Duration":
					duration_initialized = ret;
					return true;
				
				case "Category":
					category_initialized = ret;
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

			
			if (course_id_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (level_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Level;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Level);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (duration_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Duration;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Duration);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = V_xt_courseVideo.Attribute.Uuid;
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
        public class V_xt_courseVideoJson
        {
            
            /// <summary>课程id</summary>
            public string Course_id { get; set; }
            
            /// <summary>名称</summary>
            public string Name { get; set; }
            
            /// <summary></summary>
            public string Url { get; set; }
            
            /// <summary></summary>
            public int Level { get; set; }
            
            /// <summary>创建时间</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary></summary>
            public string Duration { get; set; }
            
            /// <summary>课程分类</summary>
            public string Category { get; set; }
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}