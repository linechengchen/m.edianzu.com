/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:03
  Description:    数据表Xb_product_type对应的业务逻辑层Xb_product_type
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_product_type_Entity:Xb_product_type
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Code,CreateTime,Desc,Feature_title,ModifyTime,Title,Type,Uuid from Xb_product_type
delete from Xb_product_type
INSERT INTO Xb_product_type (Id,Code,CreateTime,Desc,Feature_title,ModifyTime,Title,Type,Uuid)
     VALUES
           ('','','','','','','','','')
UPDATE Xb_product_type SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Code = valObj2.Code;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Desc = valObj2.Desc;
        valObj.Feature_title = valObj2.Feature_title;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Title = valObj2.Title;
        valObj.Type = valObj2.Type;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Code = "";
        valObj.CreateTime = "";
        valObj.Desc = "";
        valObj.Feature_title = "";
        valObj.ModifyTime = "";
        valObj.Title = "";
        valObj.Type = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Code": $("#txt_Code").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Desc": $("#txt_Desc").val(),
        "Feature_title": $("#txt_Feature_title").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Title": $("#txt_Title").val(),
        "Type": $("#txt_Type").val(),
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
    /// <para>套餐类型</para>
    /// <para>与Xb_product_type数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_product_type : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_product_type Factory()
        {
            return new Xb_product_type();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Code
        {            
            get { return this.Code; }
            set { this.Code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 描述:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Desc
        {            
            get { return this.Desc; }
            set { this.Desc = value; }
        }
        
        /// <summary> 特色标题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Feature_title
        {            
            get { return this.Feature_title; }
            set { this.Feature_title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Code
        {
            get { return this.m_code; }
            set //
            {
                if (!code_initialized || m_code != value)
                {
                    this.m_code = value;
                }
                code_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 描述:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Desc
        {
            get { return this.m_desc; }
            set //
            {
                if (!desc_initialized || m_desc != value)
                {
                    this.m_desc = value;
                }
                desc_initialized = true;
            }
        }
        
        /// <summary> 特色标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Feature_title
        {
            get { return this.m_feature_title; }
            set //
            {
                if (!feature_title_initialized || m_feature_title != value)
                {
                    this.m_feature_title = value;
                }
                feature_title_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }
        
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_product_type].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Code =  new AttributeItem("[Xb_product_type].[Code]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_product_type].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>描述:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Desc =  new AttributeItem("[Xb_product_type].[Desc]", typeof(string), 100, default(string));
            
            /// <summary>特色标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Feature_title =  new AttributeItem("[Xb_product_type].[Feature_title]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_product_type].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xb_product_type].[Title]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xb_product_type].[Type]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_product_type].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_code;
        /// <summary></summary>
        protected bool code_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_desc;
        /// <summary></summary>
        protected bool desc_initialized = false;
        
        private string m_feature_title;
        /// <summary></summary>
        protected bool feature_title_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
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
            return "Xb_product_type";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.code_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.desc_initialized = IsLoadAllAttributes;this.feature_title_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_product_type value = new Xb_product_type();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Code"))
				value.code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Desc"))
				value.desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Feature_title"))
				value.feature_title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_product_type Clone()
        {
            return (Xb_product_type)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_product_type()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_product_type() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_product_type(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_product_type(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_product_type(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_product_type(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_product_type(int id1, int code1, DateTime createtime1, string desc1, string feature_title1, DateTime modifytime1, string title1, string type1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Code = code1;
            
            this.CreateTime = createtime1;
            
            this.Desc = desc1;
            
            this.Feature_title = feature_title1;
            
            this.ModifyTime = modifytime1;
            
            this.Title = title1;
            
            this.Type = type1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_product_type FromIView(IView view)
        {
            return (Xb_product_type)IView.GetITable(view, "Xb_product_type");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_product_type GetOneInstance()
        {
            Xb_product_type value = new Xb_product_type();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_product_type Retrieve()
        {
            BLLTable<Xb_product_type>.GetRowData(this);
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
			    			
			    case "Code":
			        return Code;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Desc":
			        return Desc;
			    			
			    case "Feature_title":
			        return Feature_title;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Type":
			        return Type;
			    			
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
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Code":
			        this.Code = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Desc":
			        this.Desc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Feature_title":
			        this.Feature_title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Code":
					return code_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Desc":
					return desc_initialized;
				
				case "Feature_title":
					return feature_title_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Type":
					return type_initialized;
				
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
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Code":
					code_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Desc":
					desc_initialized = ret;
					return true;
				
				case "Feature_title":
					feature_title_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (code_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Code);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (desc_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Desc);
                }
			}
			
			if (feature_title_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Feature_title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Feature_title);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Uuid;
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
        public class Xb_product_typeJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>描述:[CtrlTypeDic-{InputString}]</summary>
            public string Desc { get; set; }
            
            /// <summary>特色标题:[CtrlTypeDic-{InputString}]</summary>
            public string Feature_title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}