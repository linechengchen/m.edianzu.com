/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    数据表V_Jz_childrenPartJobClassifications对应的业务逻辑层V_Jz_childrenPartJobClassifications
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 V_Jz_childrenPartJobClassifications_Entity:V_Jz_childrenPartJobClassifications
 * 
************************************************************/
/************************************************************
SQL代码：
select Pname1,Pname2,Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id,Root from V_Jz_childrenPartJobClassifications
delete from V_Jz_childrenPartJobClassifications
INSERT INTO V_Jz_childrenPartJobClassifications (Pname1,Pname2,Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id,Root)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE V_Jz_childrenPartJobClassifications SET ...
变量赋值代码：
 *         valObj.Pname1 = valObj2.Pname1;
        valObj.Pname2 = valObj2.Pname2;
        valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ClassificationEnum = valObj2.ClassificationEnum;
        valObj.ClassificationId = valObj2.ClassificationId;
        valObj.ClassificationName = valObj2.ClassificationName;
        valObj.PartJobCount = valObj2.PartJobCount;
        valObj.ParentId = valObj2.ParentId;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.Root = valObj2.Root; 
        valObj.Pname1 = "";
        valObj.Pname2 = "";
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.ClassificationEnum = "";
        valObj.ClassificationId = "";
        valObj.ClassificationName = "";
        valObj.PartJobCount = "";
        valObj.ParentId = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.Root = ""; 
        "Pname1": $("#txt_Pname1").val(),
        "Pname2": $("#txt_Pname2").val(),
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ClassificationEnum": $("#txt_ClassificationEnum").val(),
        "ClassificationId": $("#txt_ClassificationId").val(),
        "ClassificationName": $("#txt_ClassificationName").val(),
        "PartJobCount": $("#txt_PartJobCount").val(),
        "ParentId": $("#txt_ParentId").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(),
        "Root": $("#txt_Root").val(), 
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
    /// <para>兼职分类:[Inner-{Jz_childrenPartJobClassifications:0}]</para>
    /// <para>与V_Jz_childrenPartJobClassifications数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class V_Jz_childrenPartJobClassifications : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static V_Jz_childrenPartJobClassifications Factory()
        {
            return new V_Jz_childrenPartJobClassifications();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Pname1
        {            
            get { return this.Pname1; }
            set { this.Pname1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Pname2
        {            
            get { return this.Pname2; }
            set { this.Pname2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 分类枚举 Attribute_IsNotNull </summary>
        public string _ClassificationEnum
        {            
            get { return this.ClassificationEnum; }
            set { this.ClassificationEnum = value; }
        }
        
        /// <summary> 分类 Attribute_IsNotNull </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        
        /// <summary> 分类名称 Attribute_IsNotNull </summary>
        public string _ClassificationName
        {            
            get { return this.ClassificationName; }
            set { this.ClassificationName = value; }
        }
        
        /// <summary> 部分工作数 Attribute_IsNotNull </summary>
        public int _PartJobCount
        {            
            get { return this.PartJobCount; }
            set { this.PartJobCount = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _ParentId
        {            
            get { return this.ParentId; }
            set { this.ParentId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Root
        {            
            get { return this.Root; }
            set { this.Root = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Pname1
        {
            get { return this.m_pname1; }
            set //
            {
                if (!pname1_initialized || m_pname1 != value)
                {
                    this.m_pname1 = value;
                }
                pname1_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Pname2
        {
            get { return this.m_pname2; }
            set //
            {
                if (!pname2_initialized || m_pname2 != value)
                {
                    this.m_pname2 = value;
                }
                pname2_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 分类枚举，推荐使用 "_"符号开头 </summary>
        public string ClassificationEnum
        {
            get { return this.m_classificationenum; }
            set //
            {
                if (!classificationenum_initialized || m_classificationenum != value)
                {
                    this.m_classificationenum = value;
                }
                classificationenum_initialized = true;
            }
        }
        
        /// <summary> 分类，推荐使用 "_"符号开头 </summary>
        public int ClassificationId
        {
            get { return this.m_classificationid; }
            set //
            {
                if (!classificationid_initialized || m_classificationid != value)
                {
                    this.m_classificationid = value;
                }
                classificationid_initialized = true;
            }
        }
        
        /// <summary> 分类名称，推荐使用 "_"符号开头 </summary>
        public string ClassificationName
        {
            get { return this.m_classificationname; }
            set //
            {
                if (!classificationname_initialized || m_classificationname != value)
                {
                    this.m_classificationname = value;
                }
                classificationname_initialized = true;
            }
        }
        
        /// <summary> 部分工作数，推荐使用 "_"符号开头 </summary>
        public int PartJobCount
        {
            get { return this.m_partjobcount; }
            set //
            {
                if (!partjobcount_initialized || m_partjobcount != value)
                {
                    this.m_partjobcount = value;
                }
                partjobcount_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int ParentId
        {
            get { return this.m_parentid; }
            set //
            {
                if (!parentid_initialized || m_parentid != value)
                {
                    this.m_parentid = value;
                }
                parentid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid User_id
        {
            get { return this.m_user_id; }
            set //
            {
                if (!user_id_initialized || m_user_id != value)
                {
                    this.m_user_id = value;
                }
                user_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Root
        {
            get { return this.m_root; }
            set //
            {
                if (!root_initialized || m_root != value)
                {
                    this.m_root = value;
                }
                root_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Pname1 =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Pname1]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Pname2 =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Pname2]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem CreateTime =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>分类枚举</summary>
            public static AttributeItem ClassificationEnum =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationEnum]", typeof(string), 100, default(string));
            
            /// <summary>分类</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationId]", typeof(int), 4, default(int));
            
            /// <summary>分类名称</summary>
            public static AttributeItem ClassificationName =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationName]", typeof(string), 100, default(string));
            
            /// <summary>部分工作数</summary>
            public static AttributeItem PartJobCount =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[PartJobCount]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ParentId =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ParentId]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Root =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Root]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_pname1;
        /// <summary></summary>
        protected bool pname1_initialized = false;
        
        private string m_pname2;
        /// <summary></summary>
        protected bool pname2_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_classificationenum;
        /// <summary></summary>
        protected bool classificationenum_initialized = false;
        
        private int m_classificationid;
        /// <summary></summary>
        protected bool classificationid_initialized = false;
        
        private string m_classificationname;
        /// <summary></summary>
        protected bool classificationname_initialized = false;
        
        private int m_partjobcount;
        /// <summary></summary>
        protected bool partjobcount_initialized = false;
        
        private int m_parentid;
        /// <summary></summary>
        protected bool parentid_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_root;
        /// <summary></summary>
        protected bool root_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_Jz_childrenPartJobClassifications";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.pname1_initialized = IsLoadAllAttributes;this.pname2_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.classificationenum_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;this.classificationname_initialized = IsLoadAllAttributes;this.partjobcount_initialized = IsLoadAllAttributes;this.parentid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.root_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_Jz_childrenPartJobClassifications value = new V_Jz_childrenPartJobClassifications();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pname1"))
				value.pname1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pname2"))
				value.pname2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationEnum"))
				value.classificationenum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationId"))
				value.classificationid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationName"))
				value.classificationname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobCount"))
				value.partjobcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ParentId"))
				value.parentid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Root"))
				value.root_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new V_Jz_childrenPartJobClassifications Clone()
        {
            return (V_Jz_childrenPartJobClassifications)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static V_Jz_childrenPartJobClassifications()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public V_Jz_childrenPartJobClassifications() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public V_Jz_childrenPartJobClassifications(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public V_Jz_childrenPartJobClassifications(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public V_Jz_childrenPartJobClassifications(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public V_Jz_childrenPartJobClassifications(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public V_Jz_childrenPartJobClassifications(string pname11, string pname21, int id1, Guid uuid1, DateTime createtime1, string classificationenum1, int classificationid1, string classificationname1, int partjobcount1, int parentid1, DateTime modifytime1, Guid user_id1, int root1)
        {
            
            this.Pname1 = pname11;
            
            this.Pname2 = pname21;
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.ClassificationEnum = classificationenum1;
            
            this.ClassificationId = classificationid1;
            
            this.ClassificationName = classificationname1;
            
            this.PartJobCount = partjobcount1;
            
            this.ParentId = parentid1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.Root = root1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static V_Jz_childrenPartJobClassifications FromIView(IView view)
        {
            return (V_Jz_childrenPartJobClassifications)IView.GetITable(view, "V_Jz_childrenPartJobClassifications");
        }
        /// <summary>获得一个实例  </summary>
        public static V_Jz_childrenPartJobClassifications GetOneInstance()
        {
            V_Jz_childrenPartJobClassifications value = new V_Jz_childrenPartJobClassifications();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public V_Jz_childrenPartJobClassifications Retrieve()
        {
            BLLTable<V_Jz_childrenPartJobClassifications>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Pname1":
			        return Pname1;
			    			
			    case "Pname2":
			        return Pname2;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ClassificationEnum":
			        return ClassificationEnum;
			    			
			    case "ClassificationId":
			        return ClassificationId;
			    			
			    case "ClassificationName":
			        return ClassificationName;
			    			
			    case "PartJobCount":
			        return PartJobCount;
			    			
			    case "ParentId":
			        return ParentId;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Root":
			        return Root;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Pname1":
			        this.Pname1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pname2":
			        this.Pname2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ClassificationEnum":
			        this.ClassificationEnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassificationId":
			        this.ClassificationId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassificationName":
			        this.ClassificationName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobCount":
			        this.PartJobCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ParentId":
			        this.ParentId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Root":
			        this.Root = Convert.ToInt32(AttributeValue);
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
				case "Pname1":
					return pname1_initialized;
				
				case "Pname2":
					return pname2_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ClassificationEnum":
					return classificationenum_initialized;
				
				case "ClassificationId":
					return classificationid_initialized;
				
				case "ClassificationName":
					return classificationname_initialized;
				
				case "PartJobCount":
					return partjobcount_initialized;
				
				case "ParentId":
					return parentid_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Root":
					return root_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Pname1":
					pname1_initialized = ret;
					return true;
				
				case "Pname2":
					pname2_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ClassificationEnum":
					classificationenum_initialized = ret;
					return true;
				
				case "ClassificationId":
					classificationid_initialized = ret;
					return true;
				
				case "ClassificationName":
					classificationname_initialized = ret;
					return true;
				
				case "PartJobCount":
					partjobcount_initialized = ret;
					return true;
				
				case "ParentId":
					parentid_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Root":
					root_initialized = ret;
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

			
			if (pname1_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Pname1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pname1);
                }
			}
			
			if (pname2_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Pname2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pname2);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (classificationenum_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationEnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationEnum);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
                }
			}
			
			if (classificationname_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationName);
                }
			}
			
			if (partjobcount_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.PartJobCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobCount);
                }
			}
			
			if (parentid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ParentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ParentId);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (root_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Root;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Root);
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
        public class V_Jz_childrenPartJobClassificationsJson
        {
            
            /// <summary></summary>
            public string Pname1 { get; set; }
            
            /// <summary></summary>
            public string Pname2 { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>分类枚举</summary>
            public string ClassificationEnum { get; set; }
            
            /// <summary>分类</summary>
            public int ClassificationId { get; set; }
            
            /// <summary>分类名称</summary>
            public string ClassificationName { get; set; }
            
            /// <summary>部分工作数</summary>
            public int PartJobCount { get; set; }
            
            /// <summary></summary>
            public int ParentId { get; set; }
            
            /// <summary></summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public int Root { get; set; }
        }
        #endregion
    }
}