/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/1 21:52:11
  Description:    数据表TUserRecharge对应的业务逻辑层TUserRecharge
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TUserRecharge_Entity:TUserRecharge
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Order_No,User_id,Recharge_type,Pay_type,Amount,CreateTime,UpdateTime,Status,RelativeID,Note,Device_type,Receipt,Receipt_verified from TUserRecharge
delete from TUserRecharge
INSERT INTO TUserRecharge (Id,Order_No,User_id,Recharge_type,Pay_type,Amount,CreateTime,UpdateTime,Status,RelativeID,Note,Device_type,Receipt,Receipt_verified)
     VALUES
           ('','','','','','','','','','','','','','')
UPDATE TUserRecharge SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Order_No = valObj2.Order_No;
        valObj.User_id = valObj2.User_id;
        valObj.Recharge_type = valObj2.Recharge_type;
        valObj.Pay_type = valObj2.Pay_type;
        valObj.Amount = valObj2.Amount;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.UpdateTime = valObj2.UpdateTime;
        valObj.Status = valObj2.Status;
        valObj.RelativeID = valObj2.RelativeID;
        valObj.Note = valObj2.Note;
        valObj.Device_type = valObj2.Device_type;
        valObj.Receipt = valObj2.Receipt;
        valObj.Receipt_verified = valObj2.Receipt_verified; 
        valObj.Id = "";
        valObj.Order_No = "";
        valObj.User_id = "";
        valObj.Recharge_type = "";
        valObj.Pay_type = "";
        valObj.Amount = "";
        valObj.CreateTime = "";
        valObj.UpdateTime = "";
        valObj.Status = "";
        valObj.RelativeID = "";
        valObj.Note = "";
        valObj.Device_type = "";
        valObj.Receipt = "";
        valObj.Receipt_verified = ""; 
        "Id": $("#txt_Id").val(),
        "Order_No": $("#txt_Order_No").val(),
        "User_id": $("#txt_User_id").val(),
        "Recharge_type": $("#txt_Recharge_type").val(),
        "Pay_type": $("#txt_Pay_type").val(),
        "Amount": $("#txt_Amount").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "UpdateTime": $("#txt_UpdateTime").val(),
        "Status": $("#txt_Status").val(),
        "RelativeID": $("#txt_RelativeID").val(),
        "Note": $("#txt_Note").val(),
        "Device_type": $("#txt_Device_type").val(),
        "Receipt": $("#txt_Receipt").val(),
        "Receipt_verified": $("#txt_Receipt_verified").val(), 
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
    /// <para>用户充值表</para>
    /// <para>与TUserRecharge数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TUserRecharge : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TUserRecharge Factory()
        {
            return new TUserRecharge();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute </summary>
        public Guid _Order_No
        {            
            get { return this.Order_No; }
            set { this.Order_No = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Int16 _Recharge_type
        {            
            get { return this.Recharge_type; }
            set { this.Recharge_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Int16 _Pay_type
        {            
            get { return this.Pay_type; }
            set { this.Pay_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Amount
        {            
            get { return this.Amount; }
            set { this.Amount = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _UpdateTime
        {            
            get { return this.UpdateTime; }
            set { this.UpdateTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public byte _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _RelativeID
        {            
            get { return this.RelativeID; }
            set { this.RelativeID = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Note
        {            
            get { return this.Note; }
            set { this.Note = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Device_type
        {            
            get { return this.Device_type; }
            set { this.Device_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Receipt
        {            
            get { return this.Receipt; }
            set { this.Receipt = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Receipt_verified
        {            
            get { return this.Receipt_verified; }
            set { this.Receipt_verified = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid Order_No
        {
            get { return this.m_order_no; }
            set //
            {
                if (!order_no_initialized || m_order_no != value)
                {
                    this.m_order_no = value;
                }
                order_no_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Int16 Recharge_type
        {
            get { return this.m_recharge_type; }
            set //
            {
                if (!recharge_type_initialized || m_recharge_type != value)
                {
                    this.m_recharge_type = value;
                }
                recharge_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Int16 Pay_type
        {
            get { return this.m_pay_type; }
            set //
            {
                if (!pay_type_initialized || m_pay_type != value)
                {
                    this.m_pay_type = value;
                }
                pay_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Amount
        {
            get { return this.m_amount; }
            set //
            {
                if (!amount_initialized || m_amount != value)
                {
                    this.m_amount = value;
                }
                amount_initialized = true;
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime UpdateTime
        {
            get { return this.m_updatetime; }
            set //
            {
                if (!updatetime_initialized || m_updatetime != value)
                {
                    this.m_updatetime = value;
                }
                updatetime_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public byte Status
        {
            get { return this.m_status; }
            set //
            {
                if (!status_initialized || m_status != value)
                {
                    this.m_status = value;
                }
                status_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string RelativeID
        {
            get { return this.m_relativeid; }
            set //
            {
                if (!relativeid_initialized || m_relativeid != value)
                {
                    this.m_relativeid = value;
                }
                relativeid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Note
        {
            get { return this.m_note; }
            set //
            {
                if (!note_initialized || m_note != value)
                {
                    this.m_note = value;
                }
                note_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Device_type
        {
            get { return this.m_device_type; }
            set //
            {
                if (!device_type_initialized || m_device_type != value)
                {
                    this.m_device_type = value;
                }
                device_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Receipt
        {
            get { return this.m_receipt; }
            set //
            {
                if (!receipt_initialized || m_receipt != value)
                {
                    this.m_receipt = value;
                }
                receipt_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Receipt_verified
        {
            get { return this.m_receipt_verified; }
            set //
            {
                if (!receipt_verified_initialized || m_receipt_verified != value)
                {
                    this.m_receipt_verified = value;
                }
                receipt_verified_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TUserRecharge].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Order_No =  new AttributeItem("[TUserRecharge].[Order_No]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[TUserRecharge].[User_id]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Recharge_type =  new AttributeItem("[TUserRecharge].[Recharge_type]", typeof(Int16), 2, default(Int16));
            
            /// <summary></summary>
            public static AttributeItem Pay_type =  new AttributeItem("[TUserRecharge].[Pay_type]", typeof(Int16), 2, default(Int16));
            
            /// <summary></summary>
            public static AttributeItem Amount =  new AttributeItem("[TUserRecharge].[Amount]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem CreateTime =  new AttributeItem("[TUserRecharge].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem UpdateTime =  new AttributeItem("[TUserRecharge].[UpdateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Status =  new AttributeItem("[TUserRecharge].[Status]", typeof(byte), 1, default(byte));
            
            /// <summary></summary>
            public static AttributeItem RelativeID =  new AttributeItem("[TUserRecharge].[RelativeID]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Note =  new AttributeItem("[TUserRecharge].[Note]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Device_type =  new AttributeItem("[TUserRecharge].[Device_type]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Receipt =  new AttributeItem("[TUserRecharge].[Receipt]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Receipt_verified =  new AttributeItem("[TUserRecharge].[Receipt_verified]", typeof(bool), 1, default(bool));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_order_no;
        /// <summary></summary>
        protected bool order_no_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Int16 m_recharge_type;
        /// <summary></summary>
        protected bool recharge_type_initialized = false;
        
        private Int16 m_pay_type;
        /// <summary></summary>
        protected bool pay_type_initialized = false;
        
        private int m_amount;
        /// <summary></summary>
        protected bool amount_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private DateTime m_updatetime;
        /// <summary></summary>
        protected bool updatetime_initialized = false;
        
        private byte m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_relativeid;
        /// <summary></summary>
        protected bool relativeid_initialized = false;
        
        private string m_note;
        /// <summary></summary>
        protected bool note_initialized = false;
        
        private string m_device_type;
        /// <summary></summary>
        protected bool device_type_initialized = false;
        
        private string m_receipt;
        /// <summary></summary>
        protected bool receipt_initialized = false;
        
        private bool m_receipt_verified;
        /// <summary></summary>
        protected bool receipt_verified_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TUserRecharge";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.order_no_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.recharge_type_initialized = IsLoadAllAttributes;this.pay_type_initialized = IsLoadAllAttributes;this.amount_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.updatetime_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.relativeid_initialized = IsLoadAllAttributes;this.note_initialized = IsLoadAllAttributes;this.device_type_initialized = IsLoadAllAttributes;this.receipt_initialized = IsLoadAllAttributes;this.receipt_verified_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TUserRecharge value = new TUserRecharge();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Order_No"))
				value.order_no_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Recharge_type"))
				value.recharge_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pay_type"))
				value.pay_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Amount"))
				value.amount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UpdateTime"))
				value.updatetime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RelativeID"))
				value.relativeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Note"))
				value.note_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Device_type"))
				value.device_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Receipt"))
				value.receipt_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Receipt_verified"))
				value.receipt_verified_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TUserRecharge Clone()
        {
            return (TUserRecharge)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TUserRecharge()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TUserRecharge() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TUserRecharge(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TUserRecharge(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TUserRecharge(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TUserRecharge(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TUserRecharge(int id1, Guid order_no1, string user_id1, Int16 recharge_type1, Int16 pay_type1, int amount1, DateTime createtime1, DateTime updatetime1, byte status1, string relativeid1, string note1, string device_type1, string receipt1, bool receipt_verified1)
        {
            
            this.Id = id1;
            
            this.Order_No = order_no1;
            
            this.User_id = user_id1;
            
            this.Recharge_type = recharge_type1;
            
            this.Pay_type = pay_type1;
            
            this.Amount = amount1;
            
            this.CreateTime = createtime1;
            
            this.UpdateTime = updatetime1;
            
            this.Status = status1;
            
            this.RelativeID = relativeid1;
            
            this.Note = note1;
            
            this.Device_type = device_type1;
            
            this.Receipt = receipt1;
            
            this.Receipt_verified = receipt_verified1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TUserRecharge FromIView(IView view)
        {
            return (TUserRecharge)IView.GetITable(view, "TUserRecharge");
        }
        /// <summary>获得一个实例  </summary>
        public static TUserRecharge GetOneInstance()
        {
            TUserRecharge value = new TUserRecharge();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TUserRecharge Retrieve()
        {
            BLLTable<TUserRecharge>.GetRowData(this);
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
			    			
			    case "Order_No":
			        return Order_No;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Recharge_type":
			        return Recharge_type;
			    			
			    case "Pay_type":
			        return Pay_type;
			    			
			    case "Amount":
			        return Amount;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "UpdateTime":
			        return UpdateTime;
			    			
			    case "Status":
			        return Status;
			    			
			    case "RelativeID":
			        return RelativeID;
			    			
			    case "Note":
			        return Note;
			    			
			    case "Device_type":
			        return Device_type;
			    			
			    case "Receipt":
			        return Receipt;
			    			
			    case "Receipt_verified":
			        return Receipt_verified;
			
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
			    			
			    case "Order_No":
			        this.Order_No = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Recharge_type":
			        this.Recharge_type = Convert.ToInt16(AttributeValue);
                    return true;
			    			
			    case "Pay_type":
			        this.Pay_type = Convert.ToInt16(AttributeValue);
                    return true;
			    			
			    case "Amount":
			        this.Amount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "UpdateTime":
			        this.UpdateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToByte(AttributeValue);
                    return true;
			    			
			    case "RelativeID":
			        this.RelativeID = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Note":
			        this.Note = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Device_type":
			        this.Device_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Receipt":
			        this.Receipt = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Receipt_verified":
			        this.Receipt_verified = Convert.ToBoolean(AttributeValue);
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
				
				case "Order_No":
					return order_no_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Recharge_type":
					return recharge_type_initialized;
				
				case "Pay_type":
					return pay_type_initialized;
				
				case "Amount":
					return amount_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "UpdateTime":
					return updatetime_initialized;
				
				case "Status":
					return status_initialized;
				
				case "RelativeID":
					return relativeid_initialized;
				
				case "Note":
					return note_initialized;
				
				case "Device_type":
					return device_type_initialized;
				
				case "Receipt":
					return receipt_initialized;
				
				case "Receipt_verified":
					return receipt_verified_initialized;
				
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
				
				case "Order_No":
					order_no_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Recharge_type":
					recharge_type_initialized = ret;
					return true;
				
				case "Pay_type":
					pay_type_initialized = ret;
					return true;
				
				case "Amount":
					amount_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "UpdateTime":
					updatetime_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "RelativeID":
					relativeid_initialized = ret;
					return true;
				
				case "Note":
					note_initialized = ret;
					return true;
				
				case "Device_type":
					device_type_initialized = ret;
					return true;
				
				case "Receipt":
					receipt_initialized = ret;
					return true;
				
				case "Receipt_verified":
					receipt_verified_initialized = ret;
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
                AttributeItem attr = TUserRecharge.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (order_no_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Order_No;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Order_No);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (recharge_type_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Recharge_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Recharge_type);
                }
			}
			
			if (pay_type_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Pay_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pay_type);
                }
			}
			
			if (amount_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Amount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Amount);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (updatetime_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.UpdateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UpdateTime);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (relativeid_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.RelativeID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RelativeID);
                }
			}
			
			if (note_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Note;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Note);
                }
			}
			
			if (device_type_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Device_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Device_type);
                }
			}
			
			if (receipt_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Receipt;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Receipt);
                }
			}
			
			if (receipt_verified_initialized)
			{
                AttributeItem attr = TUserRecharge.Attribute.Receipt_verified;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Receipt_verified);
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
        public class TUserRechargeJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public Guid Order_No { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
            
            /// <summary></summary>
            public Int16 Recharge_type { get; set; }
            
            /// <summary></summary>
            public Int16 Pay_type { get; set; }
            
            /// <summary></summary>
            public int Amount { get; set; }
            
            /// <summary></summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary></summary>
            public DateTime UpdateTime { get; set; }
            
            /// <summary></summary>
            public byte Status { get; set; }
            
            /// <summary></summary>
            public string RelativeID { get; set; }
            
            /// <summary></summary>
            public string Note { get; set; }
            
            /// <summary></summary>
            public string Device_type { get; set; }
            
            /// <summary></summary>
            public string Receipt { get; set; }
            
            /// <summary></summary>
            public bool Receipt_verified { get; set; }
        }
        #endregion
    }
}