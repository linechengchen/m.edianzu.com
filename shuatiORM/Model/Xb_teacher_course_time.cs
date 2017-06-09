/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/2 20:30:47
  Description:    数据表Xb_teacher_course_time对应的业务逻辑层Xb_teacher_course_time
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_teacher_course_time_Entity:Xb_teacher_course_time
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,FavSum,ArticleCommentsSum,TearcherId,ClassTimerJson,TimerTemplate,TemplateType from Xb_teacher_course_time
delete from Xb_teacher_course_time
INSERT INTO Xb_teacher_course_time (Id,FavSum,ArticleCommentsSum,TearcherId,ClassTimerJson,TimerTemplate,TemplateType)
     VALUES
           ('','','','','','','')
UPDATE Xb_teacher_course_time SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.FavSum = valObj2.FavSum;
        valObj.ArticleCommentsSum = valObj2.ArticleCommentsSum;
        valObj.TearcherId = valObj2.TearcherId;
        valObj.ClassTimerJson = valObj2.ClassTimerJson;
        valObj.TimerTemplate = valObj2.TimerTemplate;
        valObj.TemplateType = valObj2.TemplateType; 
        valObj.Id = "";
        valObj.FavSum = "";
        valObj.ArticleCommentsSum = "";
        valObj.TearcherId = "";
        valObj.ClassTimerJson = "";
        valObj.TimerTemplate = "";
        valObj.TemplateType = ""; 
        "Id": $("#txt_Id").val(),
        "FavSum": $("#txt_FavSum").val(),
        "ArticleCommentsSum": $("#txt_ArticleCommentsSum").val(),
        "TearcherId": $("#txt_TearcherId").val(),
        "ClassTimerJson": $("#txt_ClassTimerJson").val(),
        "TimerTemplate": $("#txt_TimerTemplate").val(),
        "TemplateType": $("#txt_TemplateType").val(), 
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
    /// <para>教师更多的信息</para>
    /// <para>与Xb_teacher_course_time数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_course_time : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_teacher_course_time Factory()
        {
            return new Xb_teacher_course_time();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 最喜欢的笔:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _FavSum
        {            
            get { return this.FavSum; }
            set { this.FavSum = value; }
        }
        
        /// <summary> 文章评论和:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ArticleCommentsSum
        {            
            get { return this.ArticleCommentsSum; }
            set { this.ArticleCommentsSum = value; }
        }
        
        /// <summary> 教师身份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TearcherId
        {            
            get { return this.TearcherId; }
            set { this.TearcherId = value; }
        }
        
        /// <summary> JSON类计时器:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _ClassTimerJson
        {            
            get { return this.ClassTimerJson; }
            set { this.ClassTimerJson = value; }
        }
        
        /// <summary> 定时器模板:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _TimerTemplate
        {            
            get { return this.TimerTemplate; }
            set { this.TimerTemplate = value; }
        }
        
        /// <summary> 模板类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TemplateType
        {            
            get { return this.TemplateType; }
            set { this.TemplateType = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 最喜欢的笔:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int FavSum
        {
            get { return this.m_favsum; }
            set //
            {
                if (!favsum_initialized || m_favsum != value)
                {
                    this.m_favsum = value;
                }
                favsum_initialized = true;
            }
        }
        
        /// <summary> 文章评论和:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ArticleCommentsSum
        {
            get { return this.m_articlecommentssum; }
            set //
            {
                if (!articlecommentssum_initialized || m_articlecommentssum != value)
                {
                    this.m_articlecommentssum = value;
                }
                articlecommentssum_initialized = true;
            }
        }
        
        /// <summary> 教师身份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TearcherId
        {
            get { return this.m_tearcherid; }
            set //
            {
                if (!tearcherid_initialized || m_tearcherid != value)
                {
                    this.m_tearcherid = value;
                }
                tearcherid_initialized = true;
            }
        }
        
        /// <summary> JSON类计时器:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string ClassTimerJson
        {
            get { return this.m_classtimerjson; }
            set //
            {
                if (!classtimerjson_initialized || m_classtimerjson != value)
                {
                    this.m_classtimerjson = value;
                }
                classtimerjson_initialized = true;
            }
        }
        
        /// <summary> 定时器模板:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string TimerTemplate
        {
            get { return this.m_timertemplate; }
            set //
            {
                if (!timertemplate_initialized || m_timertemplate != value)
                {
                    this.m_timertemplate = value;
                }
                timertemplate_initialized = true;
            }
        }
        
        /// <summary> 模板类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TemplateType
        {
            get { return this.m_templatetype; }
            set //
            {
                if (!templatetype_initialized || m_templatetype != value)
                {
                    this.m_templatetype = value;
                }
                templatetype_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_course_time].[Id]", typeof(int), 4, default(int));
            
            /// <summary>最喜欢的笔:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FavSum =  new AttributeItem("[Xb_teacher_course_time].[FavSum]", typeof(int), 4, default(int));
            
            /// <summary>文章评论和:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ArticleCommentsSum =  new AttributeItem("[Xb_teacher_course_time].[ArticleCommentsSum]", typeof(int), 4, default(int));
            
            /// <summary>教师身份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TearcherId =  new AttributeItem("[Xb_teacher_course_time].[TearcherId]", typeof(int), 4, default(int));
            
            /// <summary>JSON类计时器:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem ClassTimerJson =  new AttributeItem("[Xb_teacher_course_time].[ClassTimerJson]", typeof(string), 2000, default(string));
            
            /// <summary>定时器模板:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem TimerTemplate =  new AttributeItem("[Xb_teacher_course_time].[TimerTemplate]", typeof(string), 2000, default(string));
            
            /// <summary>模板类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TemplateType =  new AttributeItem("[Xb_teacher_course_time].[TemplateType]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_favsum;
        /// <summary></summary>
        protected bool favsum_initialized = false;
        
        private int m_articlecommentssum;
        /// <summary></summary>
        protected bool articlecommentssum_initialized = false;
        
        private int m_tearcherid;
        /// <summary></summary>
        protected bool tearcherid_initialized = false;
        
        private string m_classtimerjson;
        /// <summary></summary>
        protected bool classtimerjson_initialized = false;
        
        private string m_timertemplate;
        /// <summary></summary>
        protected bool timertemplate_initialized = false;
        
        private string m_templatetype;
        /// <summary></summary>
        protected bool templatetype_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacher_course_time";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.favsum_initialized = IsLoadAllAttributes;this.articlecommentssum_initialized = IsLoadAllAttributes;this.tearcherid_initialized = IsLoadAllAttributes;this.classtimerjson_initialized = IsLoadAllAttributes;this.timertemplate_initialized = IsLoadAllAttributes;this.templatetype_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_course_time value = new Xb_teacher_course_time();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FavSum"))
				value.favsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ArticleCommentsSum"))
				value.articlecommentssum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TearcherId"))
				value.tearcherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTimerJson"))
				value.classtimerjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimerTemplate"))
				value.timertemplate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TemplateType"))
				value.templatetype_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_teacher_course_time Clone()
        {
            return (Xb_teacher_course_time)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_teacher_course_time()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_teacher_course_time() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_teacher_course_time(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_teacher_course_time(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_teacher_course_time(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_teacher_course_time(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_teacher_course_time(int id1, int favsum1, int articlecommentssum1, int tearcherid1, string classtimerjson1, string timertemplate1, string templatetype1)
        {
            
            this.Id = id1;
            
            this.FavSum = favsum1;
            
            this.ArticleCommentsSum = articlecommentssum1;
            
            this.TearcherId = tearcherid1;
            
            this.ClassTimerJson = classtimerjson1;
            
            this.TimerTemplate = timertemplate1;
            
            this.TemplateType = templatetype1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_teacher_course_time FromIView(IView view)
        {
            return (Xb_teacher_course_time)IView.GetITable(view, "Xb_teacher_course_time");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_teacher_course_time GetOneInstance()
        {
            Xb_teacher_course_time value = new Xb_teacher_course_time();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_teacher_course_time Retrieve()
        {
            BLLTable<Xb_teacher_course_time>.GetRowData(this);
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
			    			
			    case "FavSum":
			        return FavSum;
			    			
			    case "ArticleCommentsSum":
			        return ArticleCommentsSum;
			    			
			    case "TearcherId":
			        return TearcherId;
			    			
			    case "ClassTimerJson":
			        return ClassTimerJson;
			    			
			    case "TimerTemplate":
			        return TimerTemplate;
			    			
			    case "TemplateType":
			        return TemplateType;
			
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
			    			
			    case "FavSum":
			        this.FavSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ArticleCommentsSum":
			        this.ArticleCommentsSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TearcherId":
			        this.TearcherId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassTimerJson":
			        this.ClassTimerJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimerTemplate":
			        this.TimerTemplate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TemplateType":
			        this.TemplateType = Convert.ToString(AttributeValue);
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
				
				case "FavSum":
					return favsum_initialized;
				
				case "ArticleCommentsSum":
					return articlecommentssum_initialized;
				
				case "TearcherId":
					return tearcherid_initialized;
				
				case "ClassTimerJson":
					return classtimerjson_initialized;
				
				case "TimerTemplate":
					return timertemplate_initialized;
				
				case "TemplateType":
					return templatetype_initialized;
				
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
				
				case "FavSum":
					favsum_initialized = ret;
					return true;
				
				case "ArticleCommentsSum":
					articlecommentssum_initialized = ret;
					return true;
				
				case "TearcherId":
					tearcherid_initialized = ret;
					return true;
				
				case "ClassTimerJson":
					classtimerjson_initialized = ret;
					return true;
				
				case "TimerTemplate":
					timertemplate_initialized = ret;
					return true;
				
				case "TemplateType":
					templatetype_initialized = ret;
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
                AttributeItem attr = Xb_teacher_course_time.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (favsum_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.FavSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FavSum);
                }
			}
			
			if (articlecommentssum_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.ArticleCommentsSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ArticleCommentsSum);
                }
			}
			
			if (tearcherid_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TearcherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TearcherId);
                }
			}
			
			if (classtimerjson_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.ClassTimerJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTimerJson);
                }
			}
			
			if (timertemplate_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TimerTemplate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimerTemplate);
                }
			}
			
			if (templatetype_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TemplateType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TemplateType);
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
        public class Xb_teacher_course_timeJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>最喜欢的笔:[CtrlTypeDic-{InputString}]</summary>
            public int FavSum { get; set; }
            
            /// <summary>文章评论和:[CtrlTypeDic-{InputString}]</summary>
            public int ArticleCommentsSum { get; set; }
            
            /// <summary>教师身份:[CtrlTypeDic-{InputString}]</summary>
            public int TearcherId { get; set; }
            
            /// <summary>JSON类计时器:[CtrlTypeDic-{HTML}]</summary>
            public string ClassTimerJson { get; set; }
            
            /// <summary>定时器模板:[CtrlTypeDic-{HTML}]</summary>
            public string TimerTemplate { get; set; }
            
            /// <summary>模板类型:[CtrlTypeDic-{InputString}]</summary>
            public string TemplateType { get; set; }
        }
        #endregion
    }
}