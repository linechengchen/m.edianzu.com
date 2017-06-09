/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    数据表Xt_course_video对应的业务逻辑层Xt_course_video
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_course_video_Entity:Xt_course_video
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Course_id,Video_id,Creatime from Xt_course_video
delete from Xt_course_video
INSERT INTO Xt_course_video (Uuid,Course_id,Video_id,Creatime)
     VALUES
           ('','','','')
UPDATE Xt_course_video SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Course_id = valObj2.Course_id;
        valObj.Video_id = valObj2.Video_id;
        valObj.Creatime = valObj2.Creatime; 
        valObj.Uuid = "";
        valObj.Course_id = "";
        valObj.Video_id = "";
        valObj.Creatime = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Video_id": $("#txt_Video_id").val(),
        "Creatime": $("#txt_Creatime").val(), 
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
    /// <para></para>
    /// <para>与Xt_course_video数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_video : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_course_video Factory()
        {
            return new Xt_course_video();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> 测试id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Video_id
        {            
            get { return this.Video_id; }
            set { this.Video_id = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
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
        
        /// <summary> 课程id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 测试id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Video_id
        {
            get { return this.m_video_id; }
            set //
            {
                if (!video_id_initialized || m_video_id != value)
                {
                    this.m_video_id = value;
                }
                video_id_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_course_video].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_video].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>测试id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Video_id =  new AttributeItem("[Xt_course_video].[Video_id]", typeof(string), 36, default(string));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Creatime =  new AttributeItem("[Xt_course_video].[Creatime]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_video_id;
        /// <summary></summary>
        protected bool video_id_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_video";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.video_id_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_video value = new Xt_course_video();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Video_id"))
				value.video_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_course_video Clone()
        {
            return (Xt_course_video)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_course_video()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_course_video() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_course_video(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_course_video(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_course_video(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_course_video(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_course_video(Guid uuid1, string course_id1, string video_id1, DateTime creatime1)
        {
            
            this.Uuid = uuid1;
            
            this.Course_id = course_id1;
            
            this.Video_id = video_id1;
            
            this.Creatime = creatime1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_course_video FromIView(IView view)
        {
            return (Xt_course_video)IView.GetITable(view, "Xt_course_video");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_course_video GetOneInstance()
        {
            Xt_course_video value = new Xt_course_video();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_course_video Retrieve()
        {
            BLLTable<Xt_course_video>.GetRowData(this);
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
			    			
			    case "Video_id":
			        return Video_id;
			    			
			    case "Creatime":
			        return Creatime;
			
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
			    			
			    case "Video_id":
			        this.Video_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
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
				
				case "Video_id":
					return video_id_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
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
				
				case "Video_id":
					video_id_initialized = ret;
					return true;
				
				case "Creatime":
					creatime_initialized = ret;
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
                AttributeItem attr = Xt_course_video.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (video_id_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Video_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Video_id);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
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
        public class Xt_course_videoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>课程id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>测试id:[CtrlTypeDic-{InputString}]</summary>
            public string Video_id { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Creatime { get; set; }
        }
        #endregion
    }
}