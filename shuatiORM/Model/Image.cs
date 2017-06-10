/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/10 9:44:26
  Description:    数据表Image对应的业务逻辑层Image
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Image_Entity:Image
 * 
************************************************************/
/************************************************************
SQL代码：
select Goods_img,Id,Is_index,Uuid from Image
delete from Image
INSERT INTO Image (Goods_img,Id,Is_index,Uuid)
     VALUES
           ('','','','')
UPDATE Image SET ...
变量赋值代码：
 *         valObj.Goods_img = valObj2.Goods_img;
        valObj.Id = valObj2.Id;
        valObj.Is_index = valObj2.Is_index;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Goods_img = "";
        valObj.Id = "";
        valObj.Is_index = "";
        valObj.Uuid = ""; 
        "Goods_img": $("#txt_Goods_img").val(),
        "Id": $("#txt_Id").val(),
        "Is_index": $("#txt_Is_index").val(),
        "Uuid": $("#txt_Uuid").val(), 
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
    /// <para></para>
    /// <para>与Image数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Image : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Image Factory()
        {
            return new Image();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Goods_img
        {            
            get { return this.Goods_img; }
            set { this.Goods_img = value; }
        }
        
        /// <summary>  Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Is_index
        {            
            get { return this.Is_index; }
            set { this.Is_index = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Goods_img
        {
            get { return this.m_goods_img; }
            set //
            {
                if (!goods_img_initialized || m_goods_img != value)
                {
                    this.m_goods_img = value;
                }
                goods_img_initialized = true;
            }
        }
        
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
        public bool Is_index
        {
            get { return this.m_is_index; }
            set //
            {
                if (!is_index_initialized || m_is_index != value)
                {
                    this.m_is_index = value;
                }
                is_index_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Goods_img =  new AttributeItem("[Image].[Goods_img]", typeof(string), 500, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Image].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Is_index =  new AttributeItem("[Image].[Is_index]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Image].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_goods_img;
        /// <summary></summary>
        protected bool goods_img_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_is_index;
        /// <summary></summary>
        protected bool is_index_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Image";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.goods_img_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.is_index_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Image value = new Image();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_img"))
				value.goods_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_index"))
				value.is_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Image Clone()
        {
            return (Image)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Image()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Image() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Image(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Image(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Image(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Image(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Image(string goods_img1, int id1, bool is_index1, Guid uuid1)
        {
            
            this.Goods_img = goods_img1;
            
            this.Id = id1;
            
            this.Is_index = is_index1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Image FromIView(IView view)
        {
            return (Image)IView.GetITable(view, "Image");
        }
        /// <summary>获得一个实例  </summary>
        public static Image GetOneInstance()
        {
            Image value = new Image();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Image Retrieve()
        {
            BLLTable<Image>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Goods_img":
			        return Goods_img;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Is_index":
			        return Is_index;
			    			
			    case "Uuid":
			        return Uuid;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Goods_img":
			        this.Goods_img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_index":
			        this.Is_index = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				case "Goods_img":
					return goods_img_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Is_index":
					return is_index_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Goods_img":
					goods_img_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_index":
					is_index_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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

			
			if (goods_img_initialized)
			{
                AttributeItem attr = Image.Attribute.Goods_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_img);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Image.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_index_initialized)
			{
                AttributeItem attr = Image.Attribute.Is_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_index);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Image.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
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
        public class ImageJson
        {
            
            /// <summary></summary>
            public string Goods_img { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public bool Is_index { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}