/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表TggInfo对应的业务逻辑层TggInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TggInfo_Entity:TggInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,GgSourceUrl,GgName,GgImage,GgUrl,Sc,KemuId,ZsId,ZsTypeId,GgShowCount,GgShowMax,GgOnePay,GgSumPay from TggInfo
delete from TggInfo
INSERT INTO TggInfo (Id,GgSourceUrl,GgName,GgImage,GgUrl,Sc,KemuId,ZsId,ZsTypeId,GgShowCount,GgShowMax,GgOnePay,GgSumPay)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE TggInfo SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.GgSourceUrl = valObj2.GgSourceUrl;
        valObj.GgName = valObj2.GgName;
        valObj.GgImage = valObj2.GgImage;
        valObj.GgUrl = valObj2.GgUrl;
        valObj.Sc = valObj2.Sc;
        valObj.KemuId = valObj2.KemuId;
        valObj.ZsId = valObj2.ZsId;
        valObj.ZsTypeId = valObj2.ZsTypeId;
        valObj.GgShowCount = valObj2.GgShowCount;
        valObj.GgShowMax = valObj2.GgShowMax;
        valObj.GgOnePay = valObj2.GgOnePay;
        valObj.GgSumPay = valObj2.GgSumPay; 
        valObj.Id = "";
        valObj.GgSourceUrl = "";
        valObj.GgName = "";
        valObj.GgImage = "";
        valObj.GgUrl = "";
        valObj.Sc = "";
        valObj.KemuId = "";
        valObj.ZsId = "";
        valObj.ZsTypeId = "";
        valObj.GgShowCount = "";
        valObj.GgShowMax = "";
        valObj.GgOnePay = "";
        valObj.GgSumPay = ""; 
        "Id": $("#txt_Id").val(),
        "GgSourceUrl": $("#txt_GgSourceUrl").val(),
        "GgName": $("#txt_GgName").val(),
        "GgImage": $("#txt_GgImage").val(),
        "GgUrl": $("#txt_GgUrl").val(),
        "Sc": $("#txt_Sc").val(),
        "KemuId": $("#txt_KemuId").val(),
        "ZsId": $("#txt_ZsId").val(),
        "ZsTypeId": $("#txt_ZsTypeId").val(),
        "GgShowCount": $("#txt_GgShowCount").val(),
        "GgShowMax": $("#txt_GgShowMax").val(),
        "GgOnePay": $("#txt_GgOnePay").val(),
        "GgSumPay": $("#txt_GgSumPay").val(), 
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
    /// <para>广告信息:[IDField-{Id:0}]</para>
    /// <para>与TggInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TggInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TggInfo Factory()
        {
            return new TggInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 广告匹配源Url:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgSourceUrl
        {            
            get { return this.GgSourceUrl; }
            set { this.GgSourceUrl = value; }
        }
        
        /// <summary> 广告名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgName
        {            
            get { return this.GgName; }
            set { this.GgName = value; }
        }
        
        /// <summary> 广告图片:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgImage
        {            
            get { return this.GgImage; }
            set { this.GgImage = value; }
        }
        
        /// <summary> 广告链接:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgUrl
        {            
            get { return this.GgUrl; }
            set { this.GgUrl = value; }
        }
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 证书Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        
        /// <summary> 证书类型Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsTypeId
        {            
            get { return this.ZsTypeId; }
            set { this.ZsTypeId = value; }
        }
        
        /// <summary> 广告显示次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _GgShowCount
        {            
            get { return this.GgShowCount; }
            set { this.GgShowCount = value; }
        }
        
        /// <summary> 广告显示最大次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _GgShowMax
        {            
            get { return this.GgShowMax; }
            set { this.GgShowMax = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _GgOnePay
        {            
            get { return this.GgOnePay; }
            set { this.GgOnePay = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _GgSumPay
        {            
            get { return this.GgSumPay; }
            set { this.GgSumPay = value; }
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
        
        /// <summary> 广告匹配源Url:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string GgSourceUrl
        {
            get { return this.m_ggsourceurl; }
            set //
            {
                if (!ggsourceurl_initialized || m_ggsourceurl != value)
                {
                    this.m_ggsourceurl = value;
                }
                ggsourceurl_initialized = true;
            }
        }
        
        /// <summary> 广告名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string GgName
        {
            get { return this.m_ggname; }
            set //
            {
                if (!ggname_initialized || m_ggname != value)
                {
                    this.m_ggname = value;
                }
                ggname_initialized = true;
            }
        }
        
        /// <summary> 广告图片:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string GgImage
        {
            get { return this.m_ggimage; }
            set //
            {
                if (!ggimage_initialized || m_ggimage != value)
                {
                    this.m_ggimage = value;
                }
                ggimage_initialized = true;
            }
        }
        
        /// <summary> 广告链接:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string GgUrl
        {
            get { return this.m_ggurl; }
            set //
            {
                if (!ggurl_initialized || m_ggurl != value)
                {
                    this.m_ggurl = value;
                }
                ggurl_initialized = true;
            }
        }
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> 证书Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ZsId
        {
            get { return this.m_zsid; }
            set //
            {
                if (!zsid_initialized || m_zsid != value)
                {
                    this.m_zsid = value;
                }
                zsid_initialized = true;
            }
        }
        
        /// <summary> 证书类型Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ZsTypeId
        {
            get { return this.m_zstypeid; }
            set //
            {
                if (!zstypeid_initialized || m_zstypeid != value)
                {
                    this.m_zstypeid = value;
                }
                zstypeid_initialized = true;
            }
        }
        
        /// <summary> 广告显示次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int GgShowCount
        {
            get { return this.m_ggshowcount; }
            set //
            {
                if (!ggshowcount_initialized || m_ggshowcount != value)
                {
                    this.m_ggshowcount = value;
                }
                ggshowcount_initialized = true;
            }
        }
        
        /// <summary> 广告显示最大次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int GgShowMax
        {
            get { return this.m_ggshowmax; }
            set //
            {
                if (!ggshowmax_initialized || m_ggshowmax != value)
                {
                    this.m_ggshowmax = value;
                }
                ggshowmax_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double GgOnePay
        {
            get { return this.m_ggonepay; }
            set //
            {
                if (!ggonepay_initialized || m_ggonepay != value)
                {
                    this.m_ggonepay = value;
                }
                ggonepay_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double GgSumPay
        {
            get { return this.m_ggsumpay; }
            set //
            {
                if (!ggsumpay_initialized || m_ggsumpay != value)
                {
                    this.m_ggsumpay = value;
                }
                ggsumpay_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TggInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>广告匹配源Url:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgSourceUrl =  new AttributeItem("[TggInfo].[GgSourceUrl]", typeof(string), 200, default(string));
            
            /// <summary>广告名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgName =  new AttributeItem("[TggInfo].[GgName]", typeof(string), 50, default(string));
            
            /// <summary>广告图片:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgImage =  new AttributeItem("[TggInfo].[GgImage]", typeof(string), 50, default(string));
            
            /// <summary>广告链接:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgUrl =  new AttributeItem("[TggInfo].[GgUrl]", typeof(string), 200, default(string));
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[TggInfo].[Sc]", typeof(string), 50, default(string));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[TggInfo].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[TggInfo].[ZsId]", typeof(string), 50, default(string));
            
            /// <summary>证书类型Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeId =  new AttributeItem("[TggInfo].[ZsTypeId]", typeof(string), 50, default(string));
            
            /// <summary>广告显示次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgShowCount =  new AttributeItem("[TggInfo].[GgShowCount]", typeof(int), 4, default(int));
            
            /// <summary>广告显示最大次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgShowMax =  new AttributeItem("[TggInfo].[GgShowMax]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgOnePay =  new AttributeItem("[TggInfo].[GgOnePay]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgSumPay =  new AttributeItem("[TggInfo].[GgSumPay]", typeof(double), 8, default(double));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_ggsourceurl;
        /// <summary></summary>
        protected bool ggsourceurl_initialized = false;
        
        private string m_ggname;
        /// <summary></summary>
        protected bool ggname_initialized = false;
        
        private string m_ggimage;
        /// <summary></summary>
        protected bool ggimage_initialized = false;
        
        private string m_ggurl;
        /// <summary></summary>
        protected bool ggurl_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        
        private string m_zstypeid;
        /// <summary></summary>
        protected bool zstypeid_initialized = false;
        
        private int m_ggshowcount;
        /// <summary></summary>
        protected bool ggshowcount_initialized = false;
        
        private int m_ggshowmax;
        /// <summary></summary>
        protected bool ggshowmax_initialized = false;
        
        private double m_ggonepay;
        /// <summary></summary>
        protected bool ggonepay_initialized = false;
        
        private double m_ggsumpay;
        /// <summary></summary>
        protected bool ggsumpay_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TggInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.ggsourceurl_initialized = IsLoadAllAttributes;this.ggname_initialized = IsLoadAllAttributes;this.ggimage_initialized = IsLoadAllAttributes;this.ggurl_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;this.zstypeid_initialized = IsLoadAllAttributes;this.ggshowcount_initialized = IsLoadAllAttributes;this.ggshowmax_initialized = IsLoadAllAttributes;this.ggonepay_initialized = IsLoadAllAttributes;this.ggsumpay_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TggInfo value = new TggInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgSourceUrl"))
				value.ggsourceurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgName"))
				value.ggname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgImage"))
				value.ggimage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgUrl"))
				value.ggurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeId"))
				value.zstypeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgShowCount"))
				value.ggshowcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgShowMax"))
				value.ggshowmax_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgOnePay"))
				value.ggonepay_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgSumPay"))
				value.ggsumpay_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TggInfo Clone()
        {
            return (TggInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TggInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TggInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TggInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TggInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TggInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TggInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TggInfo(int id1, string ggsourceurl1, string ggname1, string ggimage1, string ggurl1, string sc1, string kemuid1, string zsid1, string zstypeid1, int ggshowcount1, int ggshowmax1, double ggonepay1, double ggsumpay1)
        {
            
            this.Id = id1;
            
            this.GgSourceUrl = ggsourceurl1;
            
            this.GgName = ggname1;
            
            this.GgImage = ggimage1;
            
            this.GgUrl = ggurl1;
            
            this.Sc = sc1;
            
            this.KemuId = kemuid1;
            
            this.ZsId = zsid1;
            
            this.ZsTypeId = zstypeid1;
            
            this.GgShowCount = ggshowcount1;
            
            this.GgShowMax = ggshowmax1;
            
            this.GgOnePay = ggonepay1;
            
            this.GgSumPay = ggsumpay1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TggInfo FromIView(IView view)
        {
            return (TggInfo)IView.GetITable(view, "TggInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static TggInfo GetOneInstance()
        {
            TggInfo value = new TggInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TggInfo Retrieve()
        {
            BLLTable<TggInfo>.GetRowData(this);
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
			    			
			    case "GgSourceUrl":
			        return GgSourceUrl;
			    			
			    case "GgName":
			        return GgName;
			    			
			    case "GgImage":
			        return GgImage;
			    			
			    case "GgUrl":
			        return GgUrl;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "ZsId":
			        return ZsId;
			    			
			    case "ZsTypeId":
			        return ZsTypeId;
			    			
			    case "GgShowCount":
			        return GgShowCount;
			    			
			    case "GgShowMax":
			        return GgShowMax;
			    			
			    case "GgOnePay":
			        return GgOnePay;
			    			
			    case "GgSumPay":
			        return GgSumPay;
			
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
			    			
			    case "GgSourceUrl":
			        this.GgSourceUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgName":
			        this.GgName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgImage":
			        this.GgImage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgUrl":
			        this.GgUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsTypeId":
			        this.ZsTypeId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgShowCount":
			        this.GgShowCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GgShowMax":
			        this.GgShowMax = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GgOnePay":
			        this.GgOnePay = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "GgSumPay":
			        this.GgSumPay = Convert.ToDouble(AttributeValue);
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
				
				case "GgSourceUrl":
					return ggsourceurl_initialized;
				
				case "GgName":
					return ggname_initialized;
				
				case "GgImage":
					return ggimage_initialized;
				
				case "GgUrl":
					return ggurl_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
				case "ZsTypeId":
					return zstypeid_initialized;
				
				case "GgShowCount":
					return ggshowcount_initialized;
				
				case "GgShowMax":
					return ggshowmax_initialized;
				
				case "GgOnePay":
					return ggonepay_initialized;
				
				case "GgSumPay":
					return ggsumpay_initialized;
				
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
				
				case "GgSourceUrl":
					ggsourceurl_initialized = ret;
					return true;
				
				case "GgName":
					ggname_initialized = ret;
					return true;
				
				case "GgImage":
					ggimage_initialized = ret;
					return true;
				
				case "GgUrl":
					ggurl_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
					return true;
				
				case "ZsTypeId":
					zstypeid_initialized = ret;
					return true;
				
				case "GgShowCount":
					ggshowcount_initialized = ret;
					return true;
				
				case "GgShowMax":
					ggshowmax_initialized = ret;
					return true;
				
				case "GgOnePay":
					ggonepay_initialized = ret;
					return true;
				
				case "GgSumPay":
					ggsumpay_initialized = ret;
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
                AttributeItem attr = TggInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (ggsourceurl_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgSourceUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgSourceUrl);
                }
			}
			
			if (ggname_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgName);
                }
			}
			
			if (ggimage_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgImage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgImage);
                }
			}
			
			if (ggurl_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgUrl);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.ZsId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsId);
                }
			}
			
			if (zstypeid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.ZsTypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeId);
                }
			}
			
			if (ggshowcount_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgShowCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgShowCount);
                }
			}
			
			if (ggshowmax_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgShowMax;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgShowMax);
                }
			}
			
			if (ggonepay_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgOnePay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgOnePay);
                }
			}
			
			if (ggsumpay_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgSumPay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgSumPay);
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
        public class TggInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>广告匹配源Url:[CtrlTypeDic-{InputString}]</summary>
            public string GgSourceUrl { get; set; }
            
            /// <summary>广告名:[CtrlTypeDic-{InputString}]</summary>
            public string GgName { get; set; }
            
            /// <summary>广告图片:[CtrlTypeDic-{InputString}]</summary>
            public string GgImage { get; set; }
            
            /// <summary>广告链接:[CtrlTypeDic-{InputString}]</summary>
            public string GgUrl { get; set; }
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public string ZsId { get; set; }
            
            /// <summary>证书类型Id:[CtrlTypeDic-{InputString}]</summary>
            public string ZsTypeId { get; set; }
            
            /// <summary>广告显示次数:[CtrlTypeDic-{InputString}]</summary>
            public int GgShowCount { get; set; }
            
            /// <summary>广告显示最大次数:[CtrlTypeDic-{InputString}]</summary>
            public int GgShowMax { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double GgOnePay { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double GgSumPay { get; set; }
        }
        #endregion
    }
}