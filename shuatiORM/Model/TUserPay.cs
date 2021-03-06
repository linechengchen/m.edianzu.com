/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:26
  Description:    数据表TUserPay对应的业务逻辑层TUserPay
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TUserPay_Entity:TUserPay
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,OpenId,User_id,TeacherId,ClassId,ClassInfoJson,PayInt,PaySum,PayUsed from TUserPay
delete from TUserPay
INSERT INTO TUserPay (Id,OpenId,User_id,TeacherId,ClassId,ClassInfoJson,PayInt,PaySum,PayUsed)
     VALUES
           ('','','','','','','','','')
UPDATE TUserPay SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.OpenId = valObj2.OpenId;
        valObj.User_id = valObj2.User_id;
        valObj.TeacherId = valObj2.TeacherId;
        valObj.ClassId = valObj2.ClassId;
        valObj.ClassInfoJson = valObj2.ClassInfoJson;
        valObj.PayInt = valObj2.PayInt;
        valObj.PaySum = valObj2.PaySum;
        valObj.PayUsed = valObj2.PayUsed; 
        valObj.Id = "";
        valObj.OpenId = "";
        valObj.User_id = "";
        valObj.TeacherId = "";
        valObj.ClassId = "";
        valObj.ClassInfoJson = "";
        valObj.PayInt = "";
        valObj.PaySum = "";
        valObj.PayUsed = ""; 
        "Id": $("#txt_Id").val(),
        "OpenId": $("#txt_OpenId").val(),
        "User_id": $("#txt_User_id").val(),
        "TeacherId": $("#txt_TeacherId").val(),
        "ClassId": $("#txt_ClassId").val(),
        "ClassInfoJson": $("#txt_ClassInfoJson").val(),
        "PayInt": $("#txt_PayInt").val(),
        "PaySum": $("#txt_PaySum").val(),
        "PayUsed": $("#txt_PayUsed").val(), 
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
    /// <para>用户支付</para>
    /// <para>与TUserPay数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TUserPay : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TUserPay Factory()
        {
            return new TUserPay();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> 评论人ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 教师ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherId
        {            
            get { return this.TeacherId; }
            set { this.TeacherId = value; }
        }
        
        /// <summary> 科目ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassId
        {            
            get { return this.ClassId; }
            set { this.ClassId = value; }
        }
        
        /// <summary> 类信息的JSON:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _ClassInfoJson
        {            
            get { return this.ClassInfoJson; }
            set { this.ClassInfoJson = value; }
        }
        
        /// <summary> 支付int:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PayInt
        {            
            get { return this.PayInt; }
            set { this.PayInt = value; }
        }
        
        /// <summary> 支付金额:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PaySum
        {            
            get { return this.PaySum; }
            set { this.PaySum = value; }
        }
        
        /// <summary> 要用:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PayUsed
        {            
            get { return this.PayUsed; }
            set { this.PayUsed = value; }
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
        
        /// <summary> 用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OpenId
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> 评论人ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string User_id
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
        
        /// <summary> 教师ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeacherId
        {
            get { return this.m_teacherid; }
            set //
            {
                if (!teacherid_initialized || m_teacherid != value)
                {
                    this.m_teacherid = value;
                }
                teacherid_initialized = true;
            }
        }
        
        /// <summary> 科目ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ClassId
        {
            get { return this.m_classid; }
            set //
            {
                if (!classid_initialized || m_classid != value)
                {
                    this.m_classid = value;
                }
                classid_initialized = true;
            }
        }
        
        /// <summary> 类信息的JSON:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string ClassInfoJson
        {
            get { return this.m_classinfojson; }
            set //
            {
                if (!classinfojson_initialized || m_classinfojson != value)
                {
                    this.m_classinfojson = value;
                }
                classinfojson_initialized = true;
            }
        }
        
        /// <summary> 支付int:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal PayInt
        {
            get { return this.m_payint; }
            set //
            {
                if (!payint_initialized || m_payint != value)
                {
                    this.m_payint = value;
                }
                payint_initialized = true;
            }
        }
        
        /// <summary> 支付金额:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal PaySum
        {
            get { return this.m_paysum; }
            set //
            {
                if (!paysum_initialized || m_paysum != value)
                {
                    this.m_paysum = value;
                }
                paysum_initialized = true;
            }
        }
        
        /// <summary> 要用:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal PayUsed
        {
            get { return this.m_payused; }
            set //
            {
                if (!payused_initialized || m_payused != value)
                {
                    this.m_payused = value;
                }
                payused_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TUserPay].[Id]", typeof(int), 4, default(int));
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[TUserPay].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>评论人ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[TUserPay].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>教师ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherId =  new AttributeItem("[TUserPay].[TeacherId]", typeof(string), 50, default(string));
            
            /// <summary>科目ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassId =  new AttributeItem("[TUserPay].[ClassId]", typeof(string), 200, default(string));
            
            /// <summary>类信息的JSON:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem ClassInfoJson =  new AttributeItem("[TUserPay].[ClassInfoJson]", typeof(string), 2000, default(string));
            
            /// <summary>支付int:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayInt =  new AttributeItem("[TUserPay].[PayInt]", typeof(decimal), 18, default(decimal));
            
            /// <summary>支付金额:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaySum =  new AttributeItem("[TUserPay].[PaySum]", typeof(decimal), 18, default(decimal));
            
            /// <summary>要用:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayUsed =  new AttributeItem("[TUserPay].[PayUsed]", typeof(decimal), 18, default(decimal));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_teacherid;
        /// <summary></summary>
        protected bool teacherid_initialized = false;
        
        private string m_classid;
        /// <summary></summary>
        protected bool classid_initialized = false;
        
        private string m_classinfojson;
        /// <summary></summary>
        protected bool classinfojson_initialized = false;
        
        private decimal m_payint;
        /// <summary></summary>
        protected bool payint_initialized = false;
        
        private decimal m_paysum;
        /// <summary></summary>
        protected bool paysum_initialized = false;
        
        private decimal m_payused;
        /// <summary></summary>
        protected bool payused_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TUserPay";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.teacherid_initialized = IsLoadAllAttributes;this.classid_initialized = IsLoadAllAttributes;this.classinfojson_initialized = IsLoadAllAttributes;this.payint_initialized = IsLoadAllAttributes;this.paysum_initialized = IsLoadAllAttributes;this.payused_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TUserPay value = new TUserPay();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherId"))
				value.teacherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassId"))
				value.classid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassInfoJson"))
				value.classinfojson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayInt"))
				value.payint_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaySum"))
				value.paysum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayUsed"))
				value.payused_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TUserPay Clone()
        {
            return (TUserPay)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TUserPay()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TUserPay() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TUserPay(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TUserPay(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TUserPay(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TUserPay(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TUserPay(int id1, string openid1, string user_id1, string teacherid1, string classid1, string classinfojson1, decimal payint1, decimal paysum1, decimal payused1)
        {
            
            this.Id = id1;
            
            this.OpenId = openid1;
            
            this.User_id = user_id1;
            
            this.TeacherId = teacherid1;
            
            this.ClassId = classid1;
            
            this.ClassInfoJson = classinfojson1;
            
            this.PayInt = payint1;
            
            this.PaySum = paysum1;
            
            this.PayUsed = payused1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TUserPay FromIView(IView view)
        {
            return (TUserPay)IView.GetITable(view, "TUserPay");
        }
        /// <summary>获得一个实例  </summary>
        public static TUserPay GetOneInstance()
        {
            TUserPay value = new TUserPay();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TUserPay Retrieve()
        {
            BLLTable<TUserPay>.GetRowData(this);
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
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "TeacherId":
			        return TeacherId;
			    			
			    case "ClassId":
			        return ClassId;
			    			
			    case "ClassInfoJson":
			        return ClassInfoJson;
			    			
			    case "PayInt":
			        return PayInt;
			    			
			    case "PaySum":
			        return PaySum;
			    			
			    case "PayUsed":
			        return PayUsed;
			
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
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherId":
			        this.TeacherId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassId":
			        this.ClassId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassInfoJson":
			        this.ClassInfoJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PayInt":
			        this.PayInt = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "PaySum":
			        this.PaySum = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "PayUsed":
			        this.PayUsed = Convert.ToDecimal(AttributeValue);
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
				
				case "OpenId":
					return openid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "TeacherId":
					return teacherid_initialized;
				
				case "ClassId":
					return classid_initialized;
				
				case "ClassInfoJson":
					return classinfojson_initialized;
				
				case "PayInt":
					return payint_initialized;
				
				case "PaySum":
					return paysum_initialized;
				
				case "PayUsed":
					return payused_initialized;
				
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
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "TeacherId":
					teacherid_initialized = ret;
					return true;
				
				case "ClassId":
					classid_initialized = ret;
					return true;
				
				case "ClassInfoJson":
					classinfojson_initialized = ret;
					return true;
				
				case "PayInt":
					payint_initialized = ret;
					return true;
				
				case "PaySum":
					paysum_initialized = ret;
					return true;
				
				case "PayUsed":
					payused_initialized = ret;
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
                AttributeItem attr = TUserPay.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (teacherid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.TeacherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherId);
                }
			}
			
			if (classid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.ClassId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassId);
                }
			}
			
			if (classinfojson_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.ClassInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassInfoJson);
                }
			}
			
			if (payint_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PayInt;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayInt);
                }
			}
			
			if (paysum_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PaySum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaySum);
                }
			}
			
			if (payused_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PayUsed;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayUsed);
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
        public class TUserPayJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>用户的标识，对当前公众号唯一:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>评论人ID:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>教师ID:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherId { get; set; }
            
            /// <summary>科目ID:[CtrlTypeDic-{InputString}]</summary>
            public string ClassId { get; set; }
            
            /// <summary>类信息的JSON:[CtrlTypeDic-{HTML}]</summary>
            public string ClassInfoJson { get; set; }
            
            /// <summary>支付int:[CtrlTypeDic-{InputString}]</summary>
            public decimal PayInt { get; set; }
            
            /// <summary>支付金额:[CtrlTypeDic-{InputString}]</summary>
            public decimal PaySum { get; set; }
            
            /// <summary>要用:[CtrlTypeDic-{InputString}]</summary>
            public decimal PayUsed { get; set; }
        }
        #endregion
    }
}