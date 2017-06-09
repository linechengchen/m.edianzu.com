/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    数据表Xs_bookCategory对应的业务逻辑层Xs_bookCategory
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xs_bookCategory_Entity:Xs_bookCategory
 * 
************************************************************/
/************************************************************
SQL代码：
select AutoId,Id,Name,Path,PId,IdPath,NamePath,SubCategoryJson,Level,Count,Type from Xs_bookCategory
delete from Xs_bookCategory
INSERT INTO Xs_bookCategory (AutoId,Id,Name,Path,PId,IdPath,NamePath,SubCategoryJson,Level,Count,Type)
     VALUES
           ('','','','','','','','','','','')
UPDATE Xs_bookCategory SET ...
变量赋值代码：
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Path = valObj2.Path;
        valObj.PId = valObj2.PId;
        valObj.IdPath = valObj2.IdPath;
        valObj.NamePath = valObj2.NamePath;
        valObj.SubCategoryJson = valObj2.SubCategoryJson;
        valObj.Level = valObj2.Level;
        valObj.Count = valObj2.Count;
        valObj.Type = valObj2.Type; 
        valObj.AutoId = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Path = "";
        valObj.PId = "";
        valObj.IdPath = "";
        valObj.NamePath = "";
        valObj.SubCategoryJson = "";
        valObj.Level = "";
        valObj.Count = "";
        valObj.Type = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Path": $("#txt_Path").val(),
        "PId": $("#txt_PId").val(),
        "IdPath": $("#txt_IdPath").val(),
        "NamePath": $("#txt_NamePath").val(),
        "SubCategoryJson": $("#txt_SubCategoryJson").val(),
        "Level": $("#txt_Level").val(),
        "Count": $("#txt_Count").val(),
        "Type": $("#txt_Type").val(), 
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
    /// <para>图书销售类别</para>
    /// <para>与Xs_bookCategory数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xs_bookCategory : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xs_bookCategory Factory()
        {
            return new Xs_bookCategory();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> 父科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PId
        {            
            get { return this.PId; }
            set { this.PId = value; }
        }
        
        /// <summary> 我的路径:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IdPath
        {            
            get { return this.IdPath; }
            set { this.IdPath = value; }
        }
        
        /// <summary> 名称路径:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NamePath
        {            
            get { return this.NamePath; }
            set { this.NamePath = value; }
        }
        
        /// <summary> 子类JSON:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _SubCategoryJson
        {            
            get { return this.SubCategoryJson; }
            set { this.SubCategoryJson = value; }
        }
        
        /// <summary> 评论用户等级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Level
        {            
            get { return this.Level; }
            set { this.Level = value; }
        }
        
        /// <summary> 数量统计:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Count
        {            
            get { return this.Count; }
            set { this.Count = value; }
        }
        
        /// <summary> 分类方法category0-post_tag1:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 路径:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }
        
        /// <summary> 父科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PId
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
            }
        }
        
        /// <summary> 我的路径:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string IdPath
        {
            get { return this.m_idpath; }
            set //
            {
                if (!idpath_initialized || m_idpath != value)
                {
                    this.m_idpath = value;
                }
                idpath_initialized = true;
            }
        }
        
        /// <summary> 名称路径:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NamePath
        {
            get { return this.m_namepath; }
            set //
            {
                if (!namepath_initialized || m_namepath != value)
                {
                    this.m_namepath = value;
                }
                namepath_initialized = true;
            }
        }
        
        /// <summary> 子类JSON:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string SubCategoryJson
        {
            get { return this.m_subcategoryjson; }
            set //
            {
                if (!subcategoryjson_initialized || m_subcategoryjson != value)
                {
                    this.m_subcategoryjson = value;
                }
                subcategoryjson_initialized = true;
            }
        }
        
        /// <summary> 评论用户等级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 数量统计:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Count
        {
            get { return this.m_count; }
            set //
            {
                if (!count_initialized || m_count != value)
                {
                    this.m_count = value;
                }
                count_initialized = true;
            }
        }
        
        /// <summary> 分类方法category0-post_tag1:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Type
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[Xs_bookCategory].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xs_bookCategory].[Id]", typeof(int), 4, default(int));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xs_bookCategory].[Name]", typeof(string), 50, default(string));
            
            /// <summary>路径:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xs_bookCategory].[Path]", typeof(string), 200, default(string));
            
            /// <summary>父科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PId =  new AttributeItem("[Xs_bookCategory].[PId]", typeof(int), 4, default(int));
            
            /// <summary>我的路径:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IdPath =  new AttributeItem("[Xs_bookCategory].[IdPath]", typeof(string), 200, default(string));
            
            /// <summary>名称路径:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NamePath =  new AttributeItem("[Xs_bookCategory].[NamePath]", typeof(string), 200, default(string));
            
            /// <summary>子类JSON:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem SubCategoryJson =  new AttributeItem("[Xs_bookCategory].[SubCategoryJson]", typeof(string), 2000, default(string));
            
            /// <summary>评论用户等级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Level =  new AttributeItem("[Xs_bookCategory].[Level]", typeof(int), 4, default(int));
            
            /// <summary>数量统计:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Count =  new AttributeItem("[Xs_bookCategory].[Count]", typeof(int), 4, default(int));
            
            /// <summary>分类方法category0-post_tag1:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xs_bookCategory].[Type]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private int m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private string m_idpath;
        /// <summary></summary>
        protected bool idpath_initialized = false;
        
        private string m_namepath;
        /// <summary></summary>
        protected bool namepath_initialized = false;
        
        private string m_subcategoryjson;
        /// <summary></summary>
        protected bool subcategoryjson_initialized = false;
        
        private int m_level;
        /// <summary></summary>
        protected bool level_initialized = false;
        
        private int m_count;
        /// <summary></summary>
        protected bool count_initialized = false;
        
        private int m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_bookCategory";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.idpath_initialized = IsLoadAllAttributes;this.namepath_initialized = IsLoadAllAttributes;this.subcategoryjson_initialized = IsLoadAllAttributes;this.level_initialized = IsLoadAllAttributes;this.count_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_bookCategory value = new Xs_bookCategory();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PId"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IdPath"))
				value.idpath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NamePath"))
				value.namepath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SubCategoryJson"))
				value.subcategoryjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Level"))
				value.level_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Count"))
				value.count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xs_bookCategory Clone()
        {
            return (Xs_bookCategory)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xs_bookCategory()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xs_bookCategory() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xs_bookCategory(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xs_bookCategory(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xs_bookCategory(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xs_bookCategory(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xs_bookCategory(int autoid1, int id1, string name1, string path1, int pid1, string idpath1, string namepath1, string subcategoryjson1, int level1, int count1, int type1)
        {
            
            this.AutoId = autoid1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Path = path1;
            
            this.PId = pid1;
            
            this.IdPath = idpath1;
            
            this.NamePath = namepath1;
            
            this.SubCategoryJson = subcategoryjson1;
            
            this.Level = level1;
            
            this.Count = count1;
            
            this.Type = type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xs_bookCategory FromIView(IView view)
        {
            return (Xs_bookCategory)IView.GetITable(view, "Xs_bookCategory");
        }
        /// <summary>获得一个实例  </summary>
        public static Xs_bookCategory GetOneInstance()
        {
            Xs_bookCategory value = new Xs_bookCategory();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xs_bookCategory Retrieve()
        {
            BLLTable<Xs_bookCategory>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Path":
			        return Path;
			    			
			    case "PId":
			        return PId;
			    			
			    case "IdPath":
			        return IdPath;
			    			
			    case "NamePath":
			        return NamePath;
			    			
			    case "SubCategoryJson":
			        return SubCategoryJson;
			    			
			    case "Level":
			        return Level;
			    			
			    case "Count":
			        return Count;
			    			
			    case "Type":
			        return Type;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PId":
			        this.PId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IdPath":
			        this.IdPath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NamePath":
			        this.NamePath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SubCategoryJson":
			        this.SubCategoryJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Level":
			        this.Level = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Count":
			        this.Count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToInt32(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Path":
					return path_initialized;
				
				case "PId":
					return pid_initialized;
				
				case "IdPath":
					return idpath_initialized;
				
				case "NamePath":
					return namepath_initialized;
				
				case "SubCategoryJson":
					return subcategoryjson_initialized;
				
				case "Level":
					return level_initialized;
				
				case "Count":
					return count_initialized;
				
				case "Type":
					return type_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "PId":
					pid_initialized = ret;
					return true;
				
				case "IdPath":
					idpath_initialized = ret;
					return true;
				
				case "NamePath":
					namepath_initialized = ret;
					return true;
				
				case "SubCategoryJson":
					subcategoryjson_initialized = ret;
					return true;
				
				case "Level":
					level_initialized = ret;
					return true;
				
				case "Count":
					count_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.PId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PId);
                }
			}
			
			if (idpath_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.IdPath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IdPath);
                }
			}
			
			if (namepath_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.NamePath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NamePath);
                }
			}
			
			if (subcategoryjson_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.SubCategoryJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SubCategoryJson);
                }
			}
			
			if (level_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Level;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Level);
                }
			}
			
			if (count_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Count);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
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
        public class Xs_bookCategoryJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>路径:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>父科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int PId { get; set; }
            
            /// <summary>我的路径:[CtrlTypeDic-{InputString}]</summary>
            public string IdPath { get; set; }
            
            /// <summary>名称路径:[CtrlTypeDic-{InputString}]</summary>
            public string NamePath { get; set; }
            
            /// <summary>子类JSON:[CtrlTypeDic-{HTML}]</summary>
            public string SubCategoryJson { get; set; }
            
            /// <summary>评论用户等级:[CtrlTypeDic-{InputString}]</summary>
            public int Level { get; set; }
            
            /// <summary>数量统计:[CtrlTypeDic-{InputString}]</summary>
            public int Count { get; set; }
            
            /// <summary>分类方法category0-post_tag1:[CtrlTypeDic-{InputString}]</summary>
            public int Type { get; set; }
        }
        #endregion
    }
}