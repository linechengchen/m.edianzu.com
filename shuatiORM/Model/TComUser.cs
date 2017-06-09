/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表TComUser对应的业务逻辑层TComUser
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TComUser_Entity:TComUser
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Headimgurl,Level,NickName,PayMoney from TComUser
delete from TComUser
INSERT INTO TComUser (Id,Headimgurl,Level,NickName,PayMoney)
     VALUES
           ('','','','','')
UPDATE TComUser SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Headimgurl = valObj2.Headimgurl;
        valObj.Level = valObj2.Level;
        valObj.NickName = valObj2.NickName;
        valObj.PayMoney = valObj2.PayMoney; 
        valObj.Id = "";
        valObj.Headimgurl = "";
        valObj.Level = "";
        valObj.NickName = "";
        valObj.PayMoney = ""; 
        "Id": $("#txt_Id").val(),
        "Headimgurl": $("#txt_Headimgurl").val(),
        "Level": $("#txt_Level").val(),
        "NickName": $("#txt_NickName").val(),
        "PayMoney": $("#txt_PayMoney").val(), 
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
    /// <para>评论用户表:[IDField-{Id:0}]</para>
    /// <para>与TComUser数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TComUser : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TComUser Factory()
        {
            return new TComUser();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public string _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 评论用户头像:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Headimgurl
        {            
            get { return this.Headimgurl; }
            set { this.Headimgurl = value; }
        }
        
        /// <summary> 评论用户等级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Level
        {            
            get { return this.Level; }
            set { this.Level = value; }
        }
        
        /// <summary> 评论用户昵称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NickName
        {            
            get { return this.NickName; }
            set { this.NickName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PayMoney
        {            
            get { return this.PayMoney; }
            set { this.PayMoney = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Id
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
        
        /// <summary> 评论用户头像:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Headimgurl
        {
            get { return this.m_headimgurl; }
            set //
            {
                if (!headimgurl_initialized || m_headimgurl != value)
                {
                    this.m_headimgurl = value;
                }
                headimgurl_initialized = true;
            }
        }
        
        /// <summary> 评论用户等级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Level
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
        
        /// <summary> 评论用户昵称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NickName
        {
            get { return this.m_nickname; }
            set //
            {
                if (!nickname_initialized || m_nickname != value)
                {
                    this.m_nickname = value;
                }
                nickname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PayMoney
        {
            get { return this.m_paymoney; }
            set //
            {
                if (!paymoney_initialized || m_paymoney != value)
                {
                    this.m_paymoney = value;
                }
                paymoney_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TComUser].[Id]", typeof(string), 50, default(string));
            
            /// <summary>评论用户头像:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Headimgurl =  new AttributeItem("[TComUser].[Headimgurl]", typeof(string), 50, default(string));
            
            /// <summary>评论用户等级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Level =  new AttributeItem("[TComUser].[Level]", typeof(string), 50, default(string));
            
            /// <summary>评论用户昵称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NickName =  new AttributeItem("[TComUser].[NickName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayMoney =  new AttributeItem("[TComUser].[PayMoney]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_headimgurl;
        /// <summary></summary>
        protected bool headimgurl_initialized = false;
        
        private string m_level;
        /// <summary></summary>
        protected bool level_initialized = false;
        
        private string m_nickname;
        /// <summary></summary>
        protected bool nickname_initialized = false;
        
        private string m_paymoney;
        /// <summary></summary>
        protected bool paymoney_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TComUser";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.headimgurl_initialized = IsLoadAllAttributes;this.level_initialized = IsLoadAllAttributes;this.nickname_initialized = IsLoadAllAttributes;this.paymoney_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TComUser value = new TComUser();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Headimgurl"))
				value.headimgurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Level"))
				value.level_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NickName"))
				value.nickname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayMoney"))
				value.paymoney_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TComUser Clone()
        {
            return (TComUser)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TComUser()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TComUser() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TComUser(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TComUser(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TComUser(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TComUser(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TComUser(string id1, string headimgurl1, string level1, string nickname1, string paymoney1)
        {
            
            this.Id = id1;
            
            this.Headimgurl = headimgurl1;
            
            this.Level = level1;
            
            this.NickName = nickname1;
            
            this.PayMoney = paymoney1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TComUser FromIView(IView view)
        {
            return (TComUser)IView.GetITable(view, "TComUser");
        }
        /// <summary>获得一个实例  </summary>
        public static TComUser GetOneInstance()
        {
            TComUser value = new TComUser();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TComUser Retrieve()
        {
            BLLTable<TComUser>.GetRowData(this);
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
			    			
			    case "Headimgurl":
			        return Headimgurl;
			    			
			    case "Level":
			        return Level;
			    			
			    case "NickName":
			        return NickName;
			    			
			    case "PayMoney":
			        return PayMoney;
			
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
			        this.Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Headimgurl":
			        this.Headimgurl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Level":
			        this.Level = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NickName":
			        this.NickName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PayMoney":
			        this.PayMoney = Convert.ToString(AttributeValue);
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
				
				case "Headimgurl":
					return headimgurl_initialized;
				
				case "Level":
					return level_initialized;
				
				case "NickName":
					return nickname_initialized;
				
				case "PayMoney":
					return paymoney_initialized;
				
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
				
				case "Headimgurl":
					headimgurl_initialized = ret;
					return true;
				
				case "Level":
					level_initialized = ret;
					return true;
				
				case "NickName":
					nickname_initialized = ret;
					return true;
				
				case "PayMoney":
					paymoney_initialized = ret;
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
                AttributeItem attr = TComUser.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (headimgurl_initialized)
			{
                AttributeItem attr = TComUser.Attribute.Headimgurl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Headimgurl);
                }
			}
			
			if (level_initialized)
			{
                AttributeItem attr = TComUser.Attribute.Level;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Level);
                }
			}
			
			if (nickname_initialized)
			{
                AttributeItem attr = TComUser.Attribute.NickName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NickName);
                }
			}
			
			if (paymoney_initialized)
			{
                AttributeItem attr = TComUser.Attribute.PayMoney;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayMoney);
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
        public class TComUserJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>评论用户头像:[CtrlTypeDic-{InputString}]</summary>
            public string Headimgurl { get; set; }
            
            /// <summary>评论用户等级:[CtrlTypeDic-{InputString}]</summary>
            public string Level { get; set; }
            
            /// <summary>评论用户昵称:[CtrlTypeDic-{InputString}]</summary>
            public string NickName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PayMoney { get; set; }
        }
        #endregion
    }
}