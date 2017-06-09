/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:03
  Description:    数据表Xb_ParentYaoQiu对应的业务逻辑层Xb_ParentYaoQiu
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_ParentYaoQiu_Entity:Xb_ParentYaoQiu
 * 
************************************************************/
/************************************************************
SQL代码：
select Area,Gender,Id,Name,Path,Phone,QinKuang,TeacherClass,Teachergender,TeacherYaoQiu,XueYuanNianJi,YaoQiuKeCi,YaoQiukeMu from Xb_ParentYaoQiu
delete from Xb_ParentYaoQiu
INSERT INTO Xb_ParentYaoQiu (Area,Gender,Id,Name,Path,Phone,QinKuang,TeacherClass,Teachergender,TeacherYaoQiu,XueYuanNianJi,YaoQiuKeCi,YaoQiukeMu)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xb_ParentYaoQiu SET ...
变量赋值代码：
 *         valObj.Area = valObj2.Area;
        valObj.Gender = valObj2.Gender;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Path = valObj2.Path;
        valObj.Phone = valObj2.Phone;
        valObj.QinKuang = valObj2.QinKuang;
        valObj.TeacherClass = valObj2.TeacherClass;
        valObj.Teachergender = valObj2.Teachergender;
        valObj.TeacherYaoQiu = valObj2.TeacherYaoQiu;
        valObj.XueYuanNianJi = valObj2.XueYuanNianJi;
        valObj.YaoQiuKeCi = valObj2.YaoQiuKeCi;
        valObj.YaoQiukeMu = valObj2.YaoQiukeMu; 
        valObj.Area = "";
        valObj.Gender = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Path = "";
        valObj.Phone = "";
        valObj.QinKuang = "";
        valObj.TeacherClass = "";
        valObj.Teachergender = "";
        valObj.TeacherYaoQiu = "";
        valObj.XueYuanNianJi = "";
        valObj.YaoQiuKeCi = "";
        valObj.YaoQiukeMu = ""; 
        "Area": $("#txt_Area").val(),
        "Gender": $("#txt_Gender").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Path": $("#txt_Path").val(),
        "Phone": $("#txt_Phone").val(),
        "QinKuang": $("#txt_QinKuang").val(),
        "TeacherClass": $("#txt_TeacherClass").val(),
        "Teachergender": $("#txt_Teachergender").val(),
        "TeacherYaoQiu": $("#txt_TeacherYaoQiu").val(),
        "XueYuanNianJi": $("#txt_XueYuanNianJi").val(),
        "YaoQiuKeCi": $("#txt_YaoQiuKeCi").val(),
        "YaoQiukeMu": $("#txt_YaoQiukeMu").val(), 
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
    /// <para>家长要求</para>
    /// <para>与Xb_ParentYaoQiu数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_ParentYaoQiu : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_ParentYaoQiu Factory()
        {
            return new Xb_ParentYaoQiu();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Area
        {            
            get { return this.Area; }
            set { this.Area = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Gender
        {            
            get { return this.Gender; }
            set { this.Gender = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone
        {            
            get { return this.Phone; }
            set { this.Phone = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QinKuang
        {            
            get { return this.QinKuang; }
            set { this.QinKuang = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherClass
        {            
            get { return this.TeacherClass; }
            set { this.TeacherClass = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teachergender
        {            
            get { return this.Teachergender; }
            set { this.Teachergender = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherYaoQiu
        {            
            get { return this.TeacherYaoQiu; }
            set { this.TeacherYaoQiu = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _XueYuanNianJi
        {            
            get { return this.XueYuanNianJi; }
            set { this.XueYuanNianJi = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YaoQiuKeCi
        {            
            get { return this.YaoQiuKeCi; }
            set { this.YaoQiuKeCi = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YaoQiukeMu
        {            
            get { return this.YaoQiukeMu; }
            set { this.YaoQiukeMu = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Area
        {
            get { return this.m_area; }
            set //
            {
                if (!area_initialized || m_area != value)
                {
                    this.m_area = value;
                }
                area_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Gender
        {
            get { return this.m_gender; }
            set //
            {
                if (!gender_initialized || m_gender != value)
                {
                    this.m_gender = value;
                }
                gender_initialized = true;
            }
        }
        
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
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone
        {
            get { return this.m_phone; }
            set //
            {
                if (!phone_initialized || m_phone != value)
                {
                    this.m_phone = value;
                }
                phone_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string QinKuang
        {
            get { return this.m_qinkuang; }
            set //
            {
                if (!qinkuang_initialized || m_qinkuang != value)
                {
                    this.m_qinkuang = value;
                }
                qinkuang_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeacherClass
        {
            get { return this.m_teacherclass; }
            set //
            {
                if (!teacherclass_initialized || m_teacherclass != value)
                {
                    this.m_teacherclass = value;
                }
                teacherclass_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teachergender
        {
            get { return this.m_teachergender; }
            set //
            {
                if (!teachergender_initialized || m_teachergender != value)
                {
                    this.m_teachergender = value;
                }
                teachergender_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TeacherYaoQiu
        {
            get { return this.m_teacheryaoqiu; }
            set //
            {
                if (!teacheryaoqiu_initialized || m_teacheryaoqiu != value)
                {
                    this.m_teacheryaoqiu = value;
                }
                teacheryaoqiu_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string XueYuanNianJi
        {
            get { return this.m_xueyuannianji; }
            set //
            {
                if (!xueyuannianji_initialized || m_xueyuannianji != value)
                {
                    this.m_xueyuannianji = value;
                }
                xueyuannianji_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string YaoQiuKeCi
        {
            get { return this.m_yaoqiukeci; }
            set //
            {
                if (!yaoqiukeci_initialized || m_yaoqiukeci != value)
                {
                    this.m_yaoqiukeci = value;
                }
                yaoqiukeci_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string YaoQiukeMu
        {
            get { return this.m_yaoqiukemu; }
            set //
            {
                if (!yaoqiukemu_initialized || m_yaoqiukemu != value)
                {
                    this.m_yaoqiukemu = value;
                }
                yaoqiukemu_initialized = true;
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
            public static AttributeItem Area =  new AttributeItem("[Xb_ParentYaoQiu].[Area]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Gender =  new AttributeItem("[Xb_ParentYaoQiu].[Gender]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_ParentYaoQiu].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_ParentYaoQiu].[Name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xb_ParentYaoQiu].[Path]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone =  new AttributeItem("[Xb_ParentYaoQiu].[Phone]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QinKuang =  new AttributeItem("[Xb_ParentYaoQiu].[QinKuang]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherClass =  new AttributeItem("[Xb_ParentYaoQiu].[TeacherClass]", typeof(string), 20, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teachergender =  new AttributeItem("[Xb_ParentYaoQiu].[Teachergender]", typeof(string), 20, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherYaoQiu =  new AttributeItem("[Xb_ParentYaoQiu].[TeacherYaoQiu]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem XueYuanNianJi =  new AttributeItem("[Xb_ParentYaoQiu].[XueYuanNianJi]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YaoQiuKeCi =  new AttributeItem("[Xb_ParentYaoQiu].[YaoQiuKeCi]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YaoQiukeMu =  new AttributeItem("[Xb_ParentYaoQiu].[YaoQiukeMu]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_area;
        /// <summary></summary>
        protected bool area_initialized = false;
        
        private string m_gender;
        /// <summary></summary>
        protected bool gender_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private string m_phone;
        /// <summary></summary>
        protected bool phone_initialized = false;
        
        private string m_qinkuang;
        /// <summary></summary>
        protected bool qinkuang_initialized = false;
        
        private string m_teacherclass;
        /// <summary></summary>
        protected bool teacherclass_initialized = false;
        
        private string m_teachergender;
        /// <summary></summary>
        protected bool teachergender_initialized = false;
        
        private string m_teacheryaoqiu;
        /// <summary></summary>
        protected bool teacheryaoqiu_initialized = false;
        
        private string m_xueyuannianji;
        /// <summary></summary>
        protected bool xueyuannianji_initialized = false;
        
        private string m_yaoqiukeci;
        /// <summary></summary>
        protected bool yaoqiukeci_initialized = false;
        
        private string m_yaoqiukemu;
        /// <summary></summary>
        protected bool yaoqiukemu_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_ParentYaoQiu";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.area_initialized = IsLoadAllAttributes;this.gender_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.phone_initialized = IsLoadAllAttributes;this.qinkuang_initialized = IsLoadAllAttributes;this.teacherclass_initialized = IsLoadAllAttributes;this.teachergender_initialized = IsLoadAllAttributes;this.teacheryaoqiu_initialized = IsLoadAllAttributes;this.xueyuannianji_initialized = IsLoadAllAttributes;this.yaoqiukeci_initialized = IsLoadAllAttributes;this.yaoqiukemu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_ParentYaoQiu value = new Xb_ParentYaoQiu();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Area"))
				value.area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Gender"))
				value.gender_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone"))
				value.phone_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QinKuang"))
				value.qinkuang_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherClass"))
				value.teacherclass_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teachergender"))
				value.teachergender_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherYaoQiu"))
				value.teacheryaoqiu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"XueYuanNianJi"))
				value.xueyuannianji_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YaoQiuKeCi"))
				value.yaoqiukeci_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YaoQiukeMu"))
				value.yaoqiukemu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_ParentYaoQiu Clone()
        {
            return (Xb_ParentYaoQiu)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_ParentYaoQiu()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_ParentYaoQiu() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_ParentYaoQiu(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_ParentYaoQiu(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_ParentYaoQiu(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_ParentYaoQiu(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_ParentYaoQiu(string area1, string gender1, int id1, string name1, string path1, string phone1, string qinkuang1, string teacherclass1, string teachergender1, string teacheryaoqiu1, string xueyuannianji1, string yaoqiukeci1, string yaoqiukemu1)
        {
            
            this.Area = area1;
            
            this.Gender = gender1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Path = path1;
            
            this.Phone = phone1;
            
            this.QinKuang = qinkuang1;
            
            this.TeacherClass = teacherclass1;
            
            this.Teachergender = teachergender1;
            
            this.TeacherYaoQiu = teacheryaoqiu1;
            
            this.XueYuanNianJi = xueyuannianji1;
            
            this.YaoQiuKeCi = yaoqiukeci1;
            
            this.YaoQiukeMu = yaoqiukemu1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_ParentYaoQiu FromIView(IView view)
        {
            return (Xb_ParentYaoQiu)IView.GetITable(view, "Xb_ParentYaoQiu");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_ParentYaoQiu GetOneInstance()
        {
            Xb_ParentYaoQiu value = new Xb_ParentYaoQiu();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_ParentYaoQiu Retrieve()
        {
            BLLTable<Xb_ParentYaoQiu>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Area":
			        return Area;
			    			
			    case "Gender":
			        return Gender;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Path":
			        return Path;
			    			
			    case "Phone":
			        return Phone;
			    			
			    case "QinKuang":
			        return QinKuang;
			    			
			    case "TeacherClass":
			        return TeacherClass;
			    			
			    case "Teachergender":
			        return Teachergender;
			    			
			    case "TeacherYaoQiu":
			        return TeacherYaoQiu;
			    			
			    case "XueYuanNianJi":
			        return XueYuanNianJi;
			    			
			    case "YaoQiuKeCi":
			        return YaoQiuKeCi;
			    			
			    case "YaoQiukeMu":
			        return YaoQiukeMu;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Area":
			        this.Area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Gender":
			        this.Gender = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone":
			        this.Phone = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QinKuang":
			        this.QinKuang = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherClass":
			        this.TeacherClass = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teachergender":
			        this.Teachergender = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherYaoQiu":
			        this.TeacherYaoQiu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "XueYuanNianJi":
			        this.XueYuanNianJi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YaoQiuKeCi":
			        this.YaoQiuKeCi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YaoQiukeMu":
			        this.YaoQiukeMu = Convert.ToString(AttributeValue);
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
				case "Area":
					return area_initialized;
				
				case "Gender":
					return gender_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Path":
					return path_initialized;
				
				case "Phone":
					return phone_initialized;
				
				case "QinKuang":
					return qinkuang_initialized;
				
				case "TeacherClass":
					return teacherclass_initialized;
				
				case "Teachergender":
					return teachergender_initialized;
				
				case "TeacherYaoQiu":
					return teacheryaoqiu_initialized;
				
				case "XueYuanNianJi":
					return xueyuannianji_initialized;
				
				case "YaoQiuKeCi":
					return yaoqiukeci_initialized;
				
				case "YaoQiukeMu":
					return yaoqiukemu_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Area":
					area_initialized = ret;
					return true;
				
				case "Gender":
					gender_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "Phone":
					phone_initialized = ret;
					return true;
				
				case "QinKuang":
					qinkuang_initialized = ret;
					return true;
				
				case "TeacherClass":
					teacherclass_initialized = ret;
					return true;
				
				case "Teachergender":
					teachergender_initialized = ret;
					return true;
				
				case "TeacherYaoQiu":
					teacheryaoqiu_initialized = ret;
					return true;
				
				case "XueYuanNianJi":
					xueyuannianji_initialized = ret;
					return true;
				
				case "YaoQiuKeCi":
					yaoqiukeci_initialized = ret;
					return true;
				
				case "YaoQiukeMu":
					yaoqiukemu_initialized = ret;
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

			
			if (area_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Area);
                }
			}
			
			if (gender_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Gender;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Gender);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (phone_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Phone;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone);
                }
			}
			
			if (qinkuang_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.QinKuang;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QinKuang);
                }
			}
			
			if (teacherclass_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.TeacherClass;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherClass);
                }
			}
			
			if (teachergender_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.Teachergender;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teachergender);
                }
			}
			
			if (teacheryaoqiu_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.TeacherYaoQiu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherYaoQiu);
                }
			}
			
			if (xueyuannianji_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.XueYuanNianJi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(XueYuanNianJi);
                }
			}
			
			if (yaoqiukeci_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.YaoQiuKeCi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YaoQiuKeCi);
                }
			}
			
			if (yaoqiukemu_initialized)
			{
                AttributeItem attr = Xb_ParentYaoQiu.Attribute.YaoQiukeMu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YaoQiukeMu);
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
        public class Xb_ParentYaoQiuJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Area { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Gender { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string QinKuang { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeacherClass { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teachergender { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string TeacherYaoQiu { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string XueYuanNianJi { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string YaoQiuKeCi { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string YaoQiukeMu { get; set; }
        }
        #endregion
    }
}