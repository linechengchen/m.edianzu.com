/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:20
  Description:    数据表Jz_partJobEvaluations对应的业务逻辑层Jz_partJobEvaluations
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_partJobEvaluations_Entity:Jz_partJobEvaluations
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Uuid,CompanyLogo,CompanyName,CreateTime,EvaluationDesc,HasClickEvaluation,PartJobEvaluationId,SettlementEfficiencyStar,StarCount,UsefulCount,WorkContentStar,WorkEnvironmentStar,ModifyTime,User_id from Jz_partJobEvaluations
delete from Jz_partJobEvaluations
INSERT INTO Jz_partJobEvaluations (Id,Uuid,CompanyLogo,CompanyName,CreateTime,EvaluationDesc,HasClickEvaluation,PartJobEvaluationId,SettlementEfficiencyStar,StarCount,UsefulCount,WorkContentStar,WorkEnvironmentStar,ModifyTime,User_id)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Jz_partJobEvaluations SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CompanyLogo = valObj2.CompanyLogo;
        valObj.CompanyName = valObj2.CompanyName;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.EvaluationDesc = valObj2.EvaluationDesc;
        valObj.HasClickEvaluation = valObj2.HasClickEvaluation;
        valObj.PartJobEvaluationId = valObj2.PartJobEvaluationId;
        valObj.SettlementEfficiencyStar = valObj2.SettlementEfficiencyStar;
        valObj.StarCount = valObj2.StarCount;
        valObj.UsefulCount = valObj2.UsefulCount;
        valObj.WorkContentStar = valObj2.WorkContentStar;
        valObj.WorkEnvironmentStar = valObj2.WorkEnvironmentStar;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CompanyLogo = "";
        valObj.CompanyName = "";
        valObj.CreateTime = "";
        valObj.EvaluationDesc = "";
        valObj.HasClickEvaluation = "";
        valObj.PartJobEvaluationId = "";
        valObj.SettlementEfficiencyStar = "";
        valObj.StarCount = "";
        valObj.UsefulCount = "";
        valObj.WorkContentStar = "";
        valObj.WorkEnvironmentStar = "";
        valObj.ModifyTime = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CompanyLogo": $("#txt_CompanyLogo").val(),
        "CompanyName": $("#txt_CompanyName").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "EvaluationDesc": $("#txt_EvaluationDesc").val(),
        "HasClickEvaluation": $("#txt_HasClickEvaluation").val(),
        "PartJobEvaluationId": $("#txt_PartJobEvaluationId").val(),
        "SettlementEfficiencyStar": $("#txt_SettlementEfficiencyStar").val(),
        "StarCount": $("#txt_StarCount").val(),
        "UsefulCount": $("#txt_UsefulCount").val(),
        "WorkContentStar": $("#txt_WorkContentStar").val(),
        "WorkEnvironmentStar": $("#txt_WorkEnvironmentStar").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(), 
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
    /// <para>兼职评价表</para>
    /// <para>与Jz_partJobEvaluations数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_partJobEvaluations : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_partJobEvaluations Factory()
        {
            return new Jz_partJobEvaluations();
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
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyLogo
        {            
            get { return this.CompanyLogo; }
            set { this.CompanyLogo = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyName
        {            
            get { return this.CompanyName; }
            set { this.CompanyName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _EvaluationDesc
        {            
            get { return this.EvaluationDesc; }
            set { this.EvaluationDesc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _HasClickEvaluation
        {            
            get { return this.HasClickEvaluation; }
            set { this.HasClickEvaluation = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PartJobEvaluationId
        {            
            get { return this.PartJobEvaluationId; }
            set { this.PartJobEvaluationId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SettlementEfficiencyStar
        {            
            get { return this.SettlementEfficiencyStar; }
            set { this.SettlementEfficiencyStar = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _StarCount
        {            
            get { return this.StarCount; }
            set { this.StarCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _UsefulCount
        {            
            get { return this.UsefulCount; }
            set { this.UsefulCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WorkContentStar
        {            
            get { return this.WorkContentStar; }
            set { this.WorkContentStar = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WorkEnvironmentStar
        {            
            get { return this.WorkEnvironmentStar; }
            set { this.WorkEnvironmentStar = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyLogo
        {
            get { return this.m_companylogo; }
            set //
            {
                if (!companylogo_initialized || m_companylogo != value)
                {
                    this.m_companylogo = value;
                }
                companylogo_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CompanyName
        {
            get { return this.m_companyname; }
            set //
            {
                if (!companyname_initialized || m_companyname != value)
                {
                    this.m_companyname = value;
                }
                companyname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string CreateTime
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string EvaluationDesc
        {
            get { return this.m_evaluationdesc; }
            set //
            {
                if (!evaluationdesc_initialized || m_evaluationdesc != value)
                {
                    this.m_evaluationdesc = value;
                }
                evaluationdesc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool HasClickEvaluation
        {
            get { return this.m_hasclickevaluation; }
            set //
            {
                if (!hasclickevaluation_initialized || m_hasclickevaluation != value)
                {
                    this.m_hasclickevaluation = value;
                }
                hasclickevaluation_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PartJobEvaluationId
        {
            get { return this.m_partjobevaluationid; }
            set //
            {
                if (!partjobevaluationid_initialized || m_partjobevaluationid != value)
                {
                    this.m_partjobevaluationid = value;
                }
                partjobevaluationid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SettlementEfficiencyStar
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int UsefulCount
        {
            get { return this.m_usefulcount; }
            set //
            {
                if (!usefulcount_initialized || m_usefulcount != value)
                {
                    this.m_usefulcount = value;
                }
                usefulcount_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WorkContentStar
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WorkEnvironmentStar
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_partJobEvaluations].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jz_partJobEvaluations].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyLogo =  new AttributeItem("[Jz_partJobEvaluations].[CompanyLogo]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyName =  new AttributeItem("[Jz_partJobEvaluations].[CompanyName]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_partJobEvaluations].[CreateTime]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EvaluationDesc =  new AttributeItem("[Jz_partJobEvaluations].[EvaluationDesc]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem HasClickEvaluation =  new AttributeItem("[Jz_partJobEvaluations].[HasClickEvaluation]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobEvaluationId =  new AttributeItem("[Jz_partJobEvaluations].[PartJobEvaluationId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SettlementEfficiencyStar =  new AttributeItem("[Jz_partJobEvaluations].[SettlementEfficiencyStar]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StarCount =  new AttributeItem("[Jz_partJobEvaluations].[StarCount]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UsefulCount =  new AttributeItem("[Jz_partJobEvaluations].[UsefulCount]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkContentStar =  new AttributeItem("[Jz_partJobEvaluations].[WorkContentStar]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WorkEnvironmentStar =  new AttributeItem("[Jz_partJobEvaluations].[WorkEnvironmentStar]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_partJobEvaluations].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_partJobEvaluations].[User_id]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_companylogo;
        /// <summary></summary>
        protected bool companylogo_initialized = false;
        
        private string m_companyname;
        /// <summary></summary>
        protected bool companyname_initialized = false;
        
        private string m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_evaluationdesc;
        /// <summary></summary>
        protected bool evaluationdesc_initialized = false;
        
        private bool m_hasclickevaluation;
        /// <summary></summary>
        protected bool hasclickevaluation_initialized = false;
        
        private int m_partjobevaluationid;
        /// <summary></summary>
        protected bool partjobevaluationid_initialized = false;
        
        private string m_settlementefficiencystar;
        /// <summary></summary>
        protected bool settlementefficiencystar_initialized = false;
        
        private decimal m_starcount;
        /// <summary></summary>
        protected bool starcount_initialized = false;
        
        private int m_usefulcount;
        /// <summary></summary>
        protected bool usefulcount_initialized = false;
        
        private string m_workcontentstar;
        /// <summary></summary>
        protected bool workcontentstar_initialized = false;
        
        private string m_workenvironmentstar;
        /// <summary></summary>
        protected bool workenvironmentstar_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_partJobEvaluations";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.companylogo_initialized = IsLoadAllAttributes;this.companyname_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.evaluationdesc_initialized = IsLoadAllAttributes;this.hasclickevaluation_initialized = IsLoadAllAttributes;this.partjobevaluationid_initialized = IsLoadAllAttributes;this.settlementefficiencystar_initialized = IsLoadAllAttributes;this.starcount_initialized = IsLoadAllAttributes;this.usefulcount_initialized = IsLoadAllAttributes;this.workcontentstar_initialized = IsLoadAllAttributes;this.workenvironmentstar_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_partJobEvaluations value = new Jz_partJobEvaluations();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyLogo"))
				value.companylogo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyName"))
				value.companyname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EvaluationDesc"))
				value.evaluationdesc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HasClickEvaluation"))
				value.hasclickevaluation_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobEvaluationId"))
				value.partjobevaluationid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SettlementEfficiencyStar"))
				value.settlementefficiencystar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StarCount"))
				value.starcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UsefulCount"))
				value.usefulcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkContentStar"))
				value.workcontentstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WorkEnvironmentStar"))
				value.workenvironmentstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_partJobEvaluations Clone()
        {
            return (Jz_partJobEvaluations)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_partJobEvaluations()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_partJobEvaluations() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_partJobEvaluations(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_partJobEvaluations(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_partJobEvaluations(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_partJobEvaluations(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_partJobEvaluations(int id1, Guid uuid1, string companylogo1, string companyname1, string createtime1, string evaluationdesc1, bool hasclickevaluation1, int partjobevaluationid1, string settlementefficiencystar1, decimal starcount1, int usefulcount1, string workcontentstar1, string workenvironmentstar1, DateTime modifytime1, Guid user_id1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CompanyLogo = companylogo1;
            
            this.CompanyName = companyname1;
            
            this.CreateTime = createtime1;
            
            this.EvaluationDesc = evaluationdesc1;
            
            this.HasClickEvaluation = hasclickevaluation1;
            
            this.PartJobEvaluationId = partjobevaluationid1;
            
            this.SettlementEfficiencyStar = settlementefficiencystar1;
            
            this.StarCount = starcount1;
            
            this.UsefulCount = usefulcount1;
            
            this.WorkContentStar = workcontentstar1;
            
            this.WorkEnvironmentStar = workenvironmentstar1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_partJobEvaluations FromIView(IView view)
        {
            return (Jz_partJobEvaluations)IView.GetITable(view, "Jz_partJobEvaluations");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_partJobEvaluations GetOneInstance()
        {
            Jz_partJobEvaluations value = new Jz_partJobEvaluations();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_partJobEvaluations Retrieve()
        {
            BLLTable<Jz_partJobEvaluations>.GetRowData(this);
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
			    			
			    case "CompanyLogo":
			        return CompanyLogo;
			    			
			    case "CompanyName":
			        return CompanyName;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "EvaluationDesc":
			        return EvaluationDesc;
			    			
			    case "HasClickEvaluation":
			        return HasClickEvaluation;
			    			
			    case "PartJobEvaluationId":
			        return PartJobEvaluationId;
			    			
			    case "SettlementEfficiencyStar":
			        return SettlementEfficiencyStar;
			    			
			    case "StarCount":
			        return StarCount;
			    			
			    case "UsefulCount":
			        return UsefulCount;
			    			
			    case "WorkContentStar":
			        return WorkContentStar;
			    			
			    case "WorkEnvironmentStar":
			        return WorkEnvironmentStar;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			
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
			    			
			    case "CompanyLogo":
			        this.CompanyLogo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyName":
			        this.CompanyName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "EvaluationDesc":
			        this.EvaluationDesc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HasClickEvaluation":
			        this.HasClickEvaluation = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "PartJobEvaluationId":
			        this.PartJobEvaluationId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SettlementEfficiencyStar":
			        this.SettlementEfficiencyStar = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StarCount":
			        this.StarCount = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "UsefulCount":
			        this.UsefulCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "WorkContentStar":
			        this.WorkContentStar = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WorkEnvironmentStar":
			        this.WorkEnvironmentStar = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				
				case "CompanyLogo":
					return companylogo_initialized;
				
				case "CompanyName":
					return companyname_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "EvaluationDesc":
					return evaluationdesc_initialized;
				
				case "HasClickEvaluation":
					return hasclickevaluation_initialized;
				
				case "PartJobEvaluationId":
					return partjobevaluationid_initialized;
				
				case "SettlementEfficiencyStar":
					return settlementefficiencystar_initialized;
				
				case "StarCount":
					return starcount_initialized;
				
				case "UsefulCount":
					return usefulcount_initialized;
				
				case "WorkContentStar":
					return workcontentstar_initialized;
				
				case "WorkEnvironmentStar":
					return workenvironmentstar_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "CompanyLogo":
					companylogo_initialized = ret;
					return true;
				
				case "CompanyName":
					companyname_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "EvaluationDesc":
					evaluationdesc_initialized = ret;
					return true;
				
				case "HasClickEvaluation":
					hasclickevaluation_initialized = ret;
					return true;
				
				case "PartJobEvaluationId":
					partjobevaluationid_initialized = ret;
					return true;
				
				case "SettlementEfficiencyStar":
					settlementefficiencystar_initialized = ret;
					return true;
				
				case "StarCount":
					starcount_initialized = ret;
					return true;
				
				case "UsefulCount":
					usefulcount_initialized = ret;
					return true;
				
				case "WorkContentStar":
					workcontentstar_initialized = ret;
					return true;
				
				case "WorkEnvironmentStar":
					workenvironmentstar_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = Jz_partJobEvaluations.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (companylogo_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.CompanyLogo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyLogo);
                }
			}
			
			if (companyname_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.CompanyName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyName);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (evaluationdesc_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.EvaluationDesc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EvaluationDesc);
                }
			}
			
			if (hasclickevaluation_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.HasClickEvaluation;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HasClickEvaluation);
                }
			}
			
			if (partjobevaluationid_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.PartJobEvaluationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobEvaluationId);
                }
			}
			
			if (settlementefficiencystar_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.SettlementEfficiencyStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SettlementEfficiencyStar);
                }
			}
			
			if (starcount_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.StarCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StarCount);
                }
			}
			
			if (usefulcount_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.UsefulCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UsefulCount);
                }
			}
			
			if (workcontentstar_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.WorkContentStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkContentStar);
                }
			}
			
			if (workenvironmentstar_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.WorkEnvironmentStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WorkEnvironmentStar);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_partJobEvaluations.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
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
        public class Jz_partJobEvaluationsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyLogo { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CompanyName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string EvaluationDesc { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool HasClickEvaluation { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PartJobEvaluationId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string SettlementEfficiencyStar { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal StarCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int UsefulCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WorkContentStar { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WorkEnvironmentStar { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
        }
        #endregion
    }
}