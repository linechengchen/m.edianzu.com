/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    数据表TErrQestionPhoto对应的业务逻辑层TErrQestionPhoto
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TErrQestionPhoto_Entity:TErrQestionPhoto
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,PhotoImg,StudentId,Kemu from TErrQestionPhoto
delete from TErrQestionPhoto
INSERT INTO TErrQestionPhoto (Id,PhotoImg,StudentId,Kemu)
     VALUES
           ('','','','')
UPDATE TErrQestionPhoto SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.PhotoImg = valObj2.PhotoImg;
        valObj.StudentId = valObj2.StudentId;
        valObj.Kemu = valObj2.Kemu; 
        valObj.Id = "";
        valObj.PhotoImg = "";
        valObj.StudentId = "";
        valObj.Kemu = ""; 
        "Id": $("#txt_Id").val(),
        "PhotoImg": $("#txt_PhotoImg").val(),
        "StudentId": $("#txt_StudentId").val(),
        "Kemu": $("#txt_Kemu").val(), 
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
    /// <para>错误问题的照片</para>
    /// <para>与TErrQestionPhoto数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TErrQestionPhoto : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TErrQestionPhoto Factory()
        {
            return new TErrQestionPhoto();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 照片IMG:[CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _PhotoImg
        {            
            get { return this.PhotoImg; }
            set { this.PhotoImg = value; }
        }
        
        /// <summary> 学生证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _StudentId
        {            
            get { return this.StudentId; }
            set { this.StudentId = value; }
        }
        
        /// <summary> 克木:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
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
        
        /// <summary> 照片IMG:[CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string PhotoImg
        {
            get { return this.m_photoimg; }
            set //
            {
                if (!photoimg_initialized || m_photoimg != value)
                {
                    this.m_photoimg = value;
                }
                photoimg_initialized = true;
            }
        }
        
        /// <summary> 学生证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int StudentId
        {
            get { return this.m_studentid; }
            set //
            {
                if (!studentid_initialized || m_studentid != value)
                {
                    this.m_studentid = value;
                }
                studentid_initialized = true;
            }
        }
        
        /// <summary> 克木:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Kemu
        {
            get { return this.m_kemu; }
            set //
            {
                if (!kemu_initialized || m_kemu != value)
                {
                    this.m_kemu = value;
                }
                kemu_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TErrQestionPhoto].[Id]", typeof(int), 4, default(int));
            
            /// <summary>照片IMG:[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem PhotoImg =  new AttributeItem("[TErrQestionPhoto].[PhotoImg]", typeof(string), 300, default(string));
            
            /// <summary>学生证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StudentId =  new AttributeItem("[TErrQestionPhoto].[StudentId]", typeof(int), 4, default(int));
            
            /// <summary>克木:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[TErrQestionPhoto].[Kemu]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_photoimg;
        /// <summary></summary>
        protected bool photoimg_initialized = false;
        
        private int m_studentid;
        /// <summary></summary>
        protected bool studentid_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TErrQestionPhoto";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.photoimg_initialized = IsLoadAllAttributes;this.studentid_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TErrQestionPhoto value = new TErrQestionPhoto();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PhotoImg"))
				value.photoimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StudentId"))
				value.studentid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TErrQestionPhoto Clone()
        {
            return (TErrQestionPhoto)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TErrQestionPhoto()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TErrQestionPhoto() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TErrQestionPhoto(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TErrQestionPhoto(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TErrQestionPhoto(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TErrQestionPhoto(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TErrQestionPhoto(int id1, string photoimg1, int studentid1, string kemu1)
        {
            
            this.Id = id1;
            
            this.PhotoImg = photoimg1;
            
            this.StudentId = studentid1;
            
            this.Kemu = kemu1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TErrQestionPhoto FromIView(IView view)
        {
            return (TErrQestionPhoto)IView.GetITable(view, "TErrQestionPhoto");
        }
        /// <summary>获得一个实例  </summary>
        public static TErrQestionPhoto GetOneInstance()
        {
            TErrQestionPhoto value = new TErrQestionPhoto();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TErrQestionPhoto Retrieve()
        {
            BLLTable<TErrQestionPhoto>.GetRowData(this);
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
			    			
			    case "PhotoImg":
			        return PhotoImg;
			    			
			    case "StudentId":
			        return StudentId;
			    			
			    case "Kemu":
			        return Kemu;
			
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
			    			
			    case "PhotoImg":
			        this.PhotoImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StudentId":
			        this.StudentId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
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
				
				case "PhotoImg":
					return photoimg_initialized;
				
				case "StudentId":
					return studentid_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
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
				
				case "PhotoImg":
					photoimg_initialized = ret;
					return true;
				
				case "StudentId":
					studentid_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
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
                AttributeItem attr = TErrQestionPhoto.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (photoimg_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.PhotoImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PhotoImg);
                }
			}
			
			if (studentid_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.StudentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StudentId);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
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
        public class TErrQestionPhotoJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>照片IMG:[CtrlTypeDic-{SmallText}]</summary>
            public string PhotoImg { get; set; }
            
            /// <summary>学生证:[CtrlTypeDic-{InputString}]</summary>
            public int StudentId { get; set; }
            
            /// <summary>克木:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu { get; set; }
        }
        #endregion
    }
}