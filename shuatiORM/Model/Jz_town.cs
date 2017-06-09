/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    数据表Jz_town对应的业务逻辑层Jz_town
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jz_town_Entity:Jz_town
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Opened,ProviceId,SpellCode,TownId,TownName,ClassificationId from Jz_town
delete from Jz_town
INSERT INTO Jz_town (Id,Opened,ProviceId,SpellCode,TownId,TownName,ClassificationId)
     VALUES
           ('','','','','','','')
UPDATE Jz_town SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Opened = valObj2.Opened;
        valObj.ProviceId = valObj2.ProviceId;
        valObj.SpellCode = valObj2.SpellCode;
        valObj.TownId = valObj2.TownId;
        valObj.TownName = valObj2.TownName;
        valObj.ClassificationId = valObj2.ClassificationId; 
        valObj.Id = "";
        valObj.Opened = "";
        valObj.ProviceId = "";
        valObj.SpellCode = "";
        valObj.TownId = "";
        valObj.TownName = "";
        valObj.ClassificationId = ""; 
        "Id": $("#txt_Id").val(),
        "Opened": $("#txt_Opened").val(),
        "ProviceId": $("#txt_ProviceId").val(),
        "SpellCode": $("#txt_SpellCode").val(),
        "TownId": $("#txt_TownId").val(),
        "TownName": $("#txt_TownName").val(),
        "ClassificationId": $("#txt_ClassificationId").val(), 
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
    /// <para>镇</para>
    /// <para>与Jz_town数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jz_town : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jz_town Factory()
        {
            return new Jz_town();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 开的:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Opened
        {            
            get { return this.Opened; }
            set { this.Opened = value; }
        }
        
        /// <summary> 省的ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ProviceId
        {            
            get { return this.ProviceId; }
            set { this.ProviceId = value; }
        }
        
        /// <summary> 法术代码:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SpellCode
        {            
            get { return this.SpellCode; }
            set { this.SpellCode = value; }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TownId
        {            
            get { return this.TownId; }
            set { this.TownId = value; }
        }
        
        /// <summary> 小镇的名字:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TownName
        {            
            get { return this.TownName; }
            set { this.TownName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Id
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
        
        /// <summary> 开的:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Opened
        {
            get { return this.m_opened; }
            set //
            {
                if (!opened_initialized || m_opened != value)
                {
                    this.m_opened = value;
                }
                opened_initialized = true;
            }
        }
        
        /// <summary> 省的ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ProviceId
        {
            get { return this.m_proviceid; }
            set //
            {
                if (!proviceid_initialized || m_proviceid != value)
                {
                    this.m_proviceid = value;
                }
                proviceid_initialized = true;
            }
        }
        
        /// <summary> 法术代码:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SpellCode
        {
            get { return this.m_spellcode; }
            set //
            {
                if (!spellcode_initialized || m_spellcode != value)
                {
                    this.m_spellcode = value;
                }
                spellcode_initialized = true;
            }
        }
        
        /// <summary> 镇上的ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int TownId
        {
            get { return this.m_townid; }
            set //
            {
                if (!townid_initialized || m_townid != value)
                {
                    this.m_townid = value;
                }
                townid_initialized = true;
            }
        }
        
        /// <summary> 小镇的名字:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TownName
        {
            get { return this.m_townname; }
            set //
            {
                if (!townname_initialized || m_townname != value)
                {
                    this.m_townname = value;
                }
                townname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_town].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>开的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Opened =  new AttributeItem("[Jz_town].[Opened]", typeof(bool), 1, default(bool));
            
            /// <summary>省的ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ProviceId =  new AttributeItem("[Jz_town].[ProviceId]", typeof(int), 4, default(int));
            
            /// <summary>法术代码:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SpellCode =  new AttributeItem("[Jz_town].[SpellCode]", typeof(string), 50, default(string));
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownId =  new AttributeItem("[Jz_town].[TownId]", typeof(int), 4, default(int));
            
            /// <summary>小镇的名字:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownName =  new AttributeItem("[Jz_town].[TownName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[Jz_town].[ClassificationId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_opened;
        /// <summary></summary>
        protected bool opened_initialized = false;
        
        private int m_proviceid;
        /// <summary></summary>
        protected bool proviceid_initialized = false;
        
        private string m_spellcode;
        /// <summary></summary>
        protected bool spellcode_initialized = false;
        
        private int m_townid;
        /// <summary></summary>
        protected bool townid_initialized = false;
        
        private string m_townname;
        /// <summary></summary>
        protected bool townname_initialized = false;
        
        private int m_classificationid;
        /// <summary></summary>
        protected bool classificationid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_town";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.opened_initialized = IsLoadAllAttributes;this.proviceid_initialized = IsLoadAllAttributes;this.spellcode_initialized = IsLoadAllAttributes;this.townid_initialized = IsLoadAllAttributes;this.townname_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_town value = new Jz_town();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Opened"))
				value.opened_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ProviceId"))
				value.proviceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SpellCode"))
				value.spellcode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownId"))
				value.townid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownName"))
				value.townname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationId"))
				value.classificationid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jz_town Clone()
        {
            return (Jz_town)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jz_town()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jz_town() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jz_town(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jz_town(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jz_town(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jz_town(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jz_town(Guid id1, bool opened1, int proviceid1, string spellcode1, int townid1, string townname1, int classificationid1)
        {
            
            this.Id = id1;
            
            this.Opened = opened1;
            
            this.ProviceId = proviceid1;
            
            this.SpellCode = spellcode1;
            
            this.TownId = townid1;
            
            this.TownName = townname1;
            
            this.ClassificationId = classificationid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jz_town FromIView(IView view)
        {
            return (Jz_town)IView.GetITable(view, "Jz_town");
        }
        /// <summary>获得一个实例  </summary>
        public static Jz_town GetOneInstance()
        {
            Jz_town value = new Jz_town();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jz_town Retrieve()
        {
            BLLTable<Jz_town>.GetRowData(this);
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
			    			
			    case "Opened":
			        return Opened;
			    			
			    case "ProviceId":
			        return ProviceId;
			    			
			    case "SpellCode":
			        return SpellCode;
			    			
			    case "TownId":
			        return TownId;
			    			
			    case "TownName":
			        return TownName;
			    			
			    case "ClassificationId":
			        return ClassificationId;
			
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
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Opened":
			        this.Opened = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ProviceId":
			        this.ProviceId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SpellCode":
			        this.SpellCode = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TownId":
			        this.TownId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TownName":
			        this.TownName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassificationId":
			        this.ClassificationId = Convert.ToInt32(AttributeValue);
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
				
				case "Opened":
					return opened_initialized;
				
				case "ProviceId":
					return proviceid_initialized;
				
				case "SpellCode":
					return spellcode_initialized;
				
				case "TownId":
					return townid_initialized;
				
				case "TownName":
					return townname_initialized;
				
				case "ClassificationId":
					return classificationid_initialized;
				
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
				
				case "Opened":
					opened_initialized = ret;
					return true;
				
				case "ProviceId":
					proviceid_initialized = ret;
					return true;
				
				case "SpellCode":
					spellcode_initialized = ret;
					return true;
				
				case "TownId":
					townid_initialized = ret;
					return true;
				
				case "TownName":
					townname_initialized = ret;
					return true;
				
				case "ClassificationId":
					classificationid_initialized = ret;
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
                AttributeItem attr = Jz_town.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (opened_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.Opened;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Opened);
                }
			}
			
			if (proviceid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.ProviceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ProviceId);
                }
			}
			
			if (spellcode_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.SpellCode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SpellCode);
                }
			}
			
			if (townid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.TownId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownId);
                }
			}
			
			if (townname_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.TownName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownName);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
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
        public class Jz_townJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public Guid Id { get; set; }
            
            /// <summary>开的:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Opened { get; set; }
            
            /// <summary>省的ID:[CtrlTypeDic-{InputString}]</summary>
            public int ProviceId { get; set; }
            
            /// <summary>法术代码:[CtrlTypeDic-{InputString}]</summary>
            public string SpellCode { get; set; }
            
            /// <summary>镇上的ID:[CtrlTypeDic-{InputString}]</summary>
            public int TownId { get; set; }
            
            /// <summary>小镇的名字:[CtrlTypeDic-{InputString}]</summary>
            public string TownName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ClassificationId { get; set; }
        }
        #endregion
    }
}