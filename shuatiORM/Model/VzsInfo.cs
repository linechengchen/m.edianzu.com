/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:59
  Description:    数据表VzsInfo对应的业务逻辑层VzsInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 VzsInfo_Entity:VzsInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select TypeName,Id,ZsName from VzsInfo
delete from VzsInfo
INSERT INTO VzsInfo (TypeName,Id,ZsName)
     VALUES
           ('','','')
UPDATE VzsInfo SET ...
变量赋值代码：
 *         valObj.TypeName = valObj2.TypeName;
        valObj.Id = valObj2.Id;
        valObj.ZsName = valObj2.ZsName; 
        valObj.TypeName = "";
        valObj.Id = "";
        valObj.ZsName = ""; 
        "TypeName": $("#txt_TypeName").val(),
        "Id": $("#txt_Id").val(),
        "ZsName": $("#txt_ZsName").val(), 
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
    /// <para>证书表__证书分类表:[Inner-{St_TzsInfo:0},{St_TzsTypeInfo:1}]</para>
    /// <para>与VzsInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class VzsInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static VzsInfo Factory()
        {
            return new VzsInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 分类名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TypeName
        {            
            get { return this.TypeName; }
            set { this.TypeName = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 证书名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsName
        {            
            get { return this.ZsName; }
            set { this.ZsName = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 分类名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TypeName
        {
            get { return this.m_typename; }
            set //
            {
                if (!typename_initialized || m_typename != value)
                {
                    this.m_typename = value;
                }
                typename_initialized = true;
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
        
        /// <summary> 证书名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ZsName
        {
            get { return this.m_zsname; }
            set //
            {
                if (!zsname_initialized || m_zsname != value)
                {
                    this.m_zsname = value;
                }
                zsname_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>分类名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TypeName =  new AttributeItem("[VzsInfo].[TypeName]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[VzsInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsName =  new AttributeItem("[VzsInfo].[ZsName]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_typename;
        /// <summary></summary>
        protected bool typename_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_zsname;
        /// <summary></summary>
        protected bool zsname_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "VzsInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.typename_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.zsname_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			VzsInfo value = new VzsInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"TypeName"))
				value.typename_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsName"))
				value.zsname_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new VzsInfo Clone()
        {
            return (VzsInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static VzsInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public VzsInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public VzsInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public VzsInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public VzsInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public VzsInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public VzsInfo(string typename1, int id1, string zsname1)
        {
            
            this.TypeName = typename1;
            
            this.Id = id1;
            
            this.ZsName = zsname1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static VzsInfo FromIView(IView view)
        {
            return (VzsInfo)IView.GetITable(view, "VzsInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static VzsInfo GetOneInstance()
        {
            VzsInfo value = new VzsInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public VzsInfo Retrieve()
        {
            BLLTable<VzsInfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "TypeName":
			        return TypeName;
			    			
			    case "Id":
			        return Id;
			    			
			    case "ZsName":
			        return ZsName;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "TypeName":
			        this.TypeName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsName":
			        this.ZsName = Convert.ToString(AttributeValue);
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
				case "TypeName":
					return typename_initialized;
				
				case "Id":
					return id_initialized;
				
				case "ZsName":
					return zsname_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "TypeName":
					typename_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "ZsName":
					zsname_initialized = ret;
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

			
			if (typename_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.TypeName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TypeName);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (zsname_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.ZsName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsName);
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
        public class VzsInfoJson
        {
            
            /// <summary>分类名:[CtrlTypeDic-{InputString}]</summary>
            public string TypeName { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public string ZsName { get; set; }
        }
        #endregion
    }
}