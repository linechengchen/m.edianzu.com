/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:20
  Description:    数据表Jz_evaluationStar对应的业务逻辑层Jz_evaluationStar
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_evaluationStar_Entity:Jz_evaluationStar
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Uuid,CreateTime,WorkContentStar,StarCount,WorkEnvironmentStar,SettlementEfficiencyStar,ModifyTime,User_id,PartJobId,CompanyId,PartJobUuid from Jz_evaluationStar
delete from Jz_evaluationStar
INSERT INTO Jz_evaluationStar (Id,Uuid,CreateTime,WorkContentStar,StarCount,WorkEnvironmentStar,SettlementEfficiencyStar,ModifyTime,User_id,PartJobId,CompanyId,PartJobUuid)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Jz_evaluationStar SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.WorkContentStar = valObj2.WorkContentStar;
        valObj.StarCount = valObj2.StarCount;
        valObj.WorkEnvironmentStar = valObj2.WorkEnvironmentStar;
        valObj.SettlementEfficiencyStar = valObj2.SettlementEfficiencyStar;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.PartJobId = valObj2.PartJobId;
        valObj.CompanyId = valObj2.CompanyId;
        valObj.PartJobUuid = valObj2.PartJobUuid; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.WorkContentStar = "";
        valObj.StarCount = "";
        valObj.WorkEnvironmentStar = "";
        valObj.SettlementEfficiencyStar = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.PartJobId = "";
        valObj.CompanyId = "";
        valObj.PartJobUuid = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "WorkContentStar": $("#txt_WorkContentStar").val(),
        "StarCount": $("#txt_StarCount").val(),
        "WorkEnvironmentStar": $("#txt_WorkEnvironmentStar").val(),
        "SettlementEfficiencyStar": $("#txt_SettlementEfficiencyStar").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(),
        "PartJobId": $("#txt_PartJobId").val(),
        "CompanyId": $("#txt_CompanyId").val(),
        "PartJobUuid": $("#txt_PartJobUuid").val(), 
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
    /// <para>评价星级</para>
    /// <para>与Jz_evaluationStar数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_evaluationStar : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_evaluationStar Factory()
        {
            return new Jz_evaluationStar();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 工作内容星级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _WorkContentStar
        {            
            get { return this.WorkContentStar; }
            set { this.WorkContentStar = value; }
        }
        
        /// <summary> 星个数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _StarCount
        {            
            get { return this.StarCount; }
            set { this.StarCount = value; }
        }
        
        /// <summary> 工作环境星级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _WorkEnvironmentStar
        {            
            get { return this.WorkEnvironmentStar; }
            set { this.WorkEnvironmentStar = value; }
        }
        
        /// <summary> 结算效率的星级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _SettlementEfficiencyStar
        {            
            get { return this.SettlementEfficiencyStar; }
            set { this.SettlementEfficiencyStar = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 部分工作id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PartJobId
        {            
            get { return this.PartJobId; }
            set { this.PartJobId = value; }
        }
        
        /// <summary> 公司id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyId
        {            
            get { return this.CompanyId; }
            set { this.CompanyId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _PartJobUuid
        {            
            get { return this.PartJobUuid; }
            set { this.PartJobUuid = value; }
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
        
        /// <summary> 工作内容星级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal WorkContentStar
        {
            get { return this.m_workcontentstar; }
            set //
            {
                if (!workcontentstar_initialized || m_workcontentstar != value)
                {
                    this.m_workcontentstar = value;
                }
                workcontentstar_initialized = true;
            }
        }
        
        /// <summary> 星个数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal StarCount
        {
            get { return this.m_starcount; }
            set //
            {
                if (!starcount_initialized || m_starcount != value)
                {
                    this.m_starcount = value;
                }
                starcount_initialized = true;
            }
        }
        
        /// <summary> 工作环境星级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal WorkEnvironmentStar
        {
            get { return this.m_workenvironmentstar; }
            set //
            {
                if (!workenvironmentstar_initialized || m_workenvironmentstar != value)
                {
                    this.m_workenvironmentstar = value;
                }
                workenvironmentstar_initialized = true;
            }
        }
        
        /// <summary> 结算效率的星级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal SettlementEfficiencyStar
        {
            get { return this.m_settlementefficiencystar; }
            set //
            {
                if (!settlementefficiencystar_initialized || m_settlementefficiencystar != value)
                {
                    this.m_settlementefficiencystar = value;
                }
                settlementefficiencystar_initialized = true;
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
        
        /// <summary> 部分工作id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PartJobId
        {
            get { return this.m_partjobid; }
            set //
            {
                if (!partjobid_initialized || m_partjobid != value)
                {
                    this.m_partjobid = value;
                }
                partjobid_initialized = true;
            }
        }
        
        /// <summary> 公司id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CompanyId
        {
            get { return this.m_companyid; }
            set //
            {
                if (!companyid_initialized || m_companyid != value)
                {
                    this.m_companyid = value;
                }
                companyid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid PartJobUuid
        {
            get { return this.m_partjobuuid; }
            set //
            {
                if (!partjobuuid_initialized || m_partjobuuid != value)
                {
                    this.m_partjobuuid = value;
                }
                partjobuuid_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jz_evaluationStar].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jz_evaluationStar].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_evaluationStar].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>工作内容星级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkContentStar =  new AttributeItem("[Jz_evaluationStar].[WorkContentStar]", typeof(decimal), 18, default(decimal));
            
            /// <summary>星个数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StarCount =  new AttributeItem("[Jz_evaluationStar].[StarCount]", typeof(decimal), 18, default(decimal));
            
            /// <summary>工作环境星级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkEnvironmentStar =  new AttributeItem("[Jz_evaluationStar].[WorkEnvironmentStar]", typeof(decimal), 18, default(decimal));
            
            /// <summary>结算效率的星级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SettlementEfficiencyStar =  new AttributeItem("[Jz_evaluationStar].[SettlementEfficiencyStar]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_evaluationStar].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_evaluationStar].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>部分工作id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobId =  new AttributeItem("[Jz_evaluationStar].[PartJobId]", typeof(int), 4, default(int));
            
            /// <summary>公司id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyId =  new AttributeItem("[Jz_evaluationStar].[CompanyId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobUuid =  new AttributeItem("[Jz_evaluationStar].[PartJobUuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private decimal m_workcontentstar;
        /// <summary></summary>
        protected bool workcontentstar_initialized = false;
        
        private decimal m_starcount;
        /// <summary></summary>
        protected bool starcount_initialized = false;
        
        private decimal m_workenvironmentstar;
        /// <summary></summary>
        protected bool workenvironmentstar_initialized = false;
        
        private decimal m_settlementefficiencystar;
        /// <summary></summary>
        protected bool settlementefficiencystar_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_partjobid;
        /// <summary></summary>
        protected bool partjobid_initialized = false;
        
        private int m_companyid;
        /// <summary></summary>
        protected bool companyid_initialized = false;
        
        private Guid m_partjobuuid;
        /// <summary></summary>
        protected bool partjobuuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_evaluationStar";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.workcontentstar_initialized = IsLoadAllAttributes;this.starcount_initialized = IsLoadAllAttributes;this.workenvironmentstar_initialized = IsLoadAllAttributes;this.settlementefficiencystar_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.partjobid_initialized = IsLoadAllAttributes;this.companyid_initialized = IsLoadAllAttributes;this.partjobuuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_evaluationStar value = new Jz_evaluationStar();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkContentStar"))
				value.workcontentstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StarCount"))
				value.starcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkEnvironmentStar"))
				value.workenvironmentstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SettlementEfficiencyStar"))
				value.settlementefficiencystar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobId"))
				value.partjobid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyId"))
				value.companyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobUuid"))
				value.partjobuuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_evaluationStar Clone()
        {
            return (Jz_evaluationStar)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_evaluationStar()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_evaluationStar() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_evaluationStar(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_evaluationStar(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_evaluationStar(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_evaluationStar(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_evaluationStar(int id1, Guid uuid1, DateTime createtime1, decimal workcontentstar1, decimal starcount1, decimal workenvironmentstar1, decimal settlementefficiencystar1, DateTime modifytime1, Guid user_id1, int partjobid1, int companyid1, Guid partjobuuid1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.WorkContentStar = workcontentstar1;
            
            this.StarCount = starcount1;
            
            this.WorkEnvironmentStar = workenvironmentstar1;
            
            this.SettlementEfficiencyStar = settlementefficiencystar1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.PartJobId = partjobid1;
            
            this.CompanyId = companyid1;
            
            this.PartJobUuid = partjobuuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_evaluationStar FromIView(IView view)
        {
            return (Jz_evaluationStar)IView.GetITable(view, "Jz_evaluationStar");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_evaluationStar GetOneInstance()
        {
            Jz_evaluationStar value = new Jz_evaluationStar();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_evaluationStar Retrieve()
        {
            BLLTable<Jz_evaluationStar>.GetRowData(this);
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
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "WorkContentStar":
			        return WorkContentStar;
			    			
			    case "StarCount":
			        return StarCount;
			    			
			    case "WorkEnvironmentStar":
			        return WorkEnvironmentStar;
			    			
			    case "SettlementEfficiencyStar":
			        return SettlementEfficiencyStar;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "PartJobId":
			        return PartJobId;
			    			
			    case "CompanyId":
			        return CompanyId;
			    			
			    case "PartJobUuid":
			        return PartJobUuid;
			
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
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "WorkContentStar":
			        this.WorkContentStar = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "StarCount":
			        this.StarCount = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "WorkEnvironmentStar":
			        this.WorkEnvironmentStar = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "SettlementEfficiencyStar":
			        this.SettlementEfficiencyStar = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "PartJobId":
			        this.PartJobId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CompanyId":
			        this.CompanyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "PartJobUuid":
			        this.PartJobUuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "Uuid":
					return uuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "WorkContentStar":
					return workcontentstar_initialized;
				
				case "StarCount":
					return starcount_initialized;
				
				case "WorkEnvironmentStar":
					return workenvironmentstar_initialized;
				
				case "SettlementEfficiencyStar":
					return settlementefficiencystar_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "PartJobId":
					return partjobid_initialized;
				
				case "CompanyId":
					return companyid_initialized;
				
				case "PartJobUuid":
					return partjobuuid_initialized;
				
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
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "WorkContentStar":
					workcontentstar_initialized = ret;
					return true;
				
				case "StarCount":
					starcount_initialized = ret;
					return true;
				
				case "WorkEnvironmentStar":
					workenvironmentstar_initialized = ret;
					return true;
				
				case "SettlementEfficiencyStar":
					settlementefficiencystar_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "PartJobId":
					partjobid_initialized = ret;
					return true;
				
				case "CompanyId":
					companyid_initialized = ret;
					return true;
				
				case "PartJobUuid":
					partjobuuid_initialized = ret;
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
                AttributeItem attr = Jz_evaluationStar.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (workcontentstar_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.WorkContentStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkContentStar);
                }
			}
			
			if (starcount_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.StarCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StarCount);
                }
			}
			
			if (workenvironmentstar_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.WorkEnvironmentStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkEnvironmentStar);
                }
			}
			
			if (settlementefficiencystar_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.SettlementEfficiencyStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SettlementEfficiencyStar);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (partjobid_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.PartJobId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobId);
                }
			}
			
			if (companyid_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.CompanyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyId);
                }
			}
			
			if (partjobuuid_initialized)
			{
                AttributeItem attr = Jz_evaluationStar.Attribute.PartJobUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobUuid);
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
        public class Jz_evaluationStarJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>工作内容星级:[CtrlTypeDic-{InputString}]</summary>
            public decimal WorkContentStar { get; set; }
            
            /// <summary>星个数:[CtrlTypeDic-{InputString}]</summary>
            public decimal StarCount { get; set; }
            
            /// <summary>工作环境星级:[CtrlTypeDic-{InputString}]</summary>
            public decimal WorkEnvironmentStar { get; set; }
            
            /// <summary>结算效率的星级:[CtrlTypeDic-{InputString}]</summary>
            public decimal SettlementEfficiencyStar { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>部分工作id:[CtrlTypeDic-{InputString}]</summary>
            public int PartJobId { get; set; }
            
            /// <summary>公司id:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid PartJobUuid { get; set; }
        }
        #endregion
    }
}