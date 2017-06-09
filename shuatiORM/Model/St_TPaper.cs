/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    数据表St_TPaper对应的业务逻辑层St_TPaper
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TPaper_Entity:St_TPaper
 * 
************************************************************/
/************************************************************
SQL代码：
select AutoId,AddTime,ClassId,ClickNum,Id,PaperName,PaperStatus,ProblemCount,RecTf,RightProblemCount,Url from St_TPaper
delete from St_TPaper
INSERT INTO St_TPaper (AutoId,AddTime,ClassId,ClickNum,Id,PaperName,PaperStatus,ProblemCount,RecTf,RightProblemCount,Url)
     VALUES
           ('','','','','','','','','','','')
UPDATE St_TPaper SET ...
变量赋值代码：
 *         valObj.AutoId = valObj2.AutoId;
        valObj.AddTime = valObj2.AddTime;
        valObj.ClassId = valObj2.ClassId;
        valObj.ClickNum = valObj2.ClickNum;
        valObj.Id = valObj2.Id;
        valObj.PaperName = valObj2.PaperName;
        valObj.PaperStatus = valObj2.PaperStatus;
        valObj.ProblemCount = valObj2.ProblemCount;
        valObj.RecTf = valObj2.RecTf;
        valObj.RightProblemCount = valObj2.RightProblemCount;
        valObj.Url = valObj2.Url; 
        valObj.AutoId = "";
        valObj.AddTime = "";
        valObj.ClassId = "";
        valObj.ClickNum = "";
        valObj.Id = "";
        valObj.PaperName = "";
        valObj.PaperStatus = "";
        valObj.ProblemCount = "";
        valObj.RecTf = "";
        valObj.RightProblemCount = "";
        valObj.Url = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "AddTime": $("#txt_AddTime").val(),
        "ClassId": $("#txt_ClassId").val(),
        "ClickNum": $("#txt_ClickNum").val(),
        "Id": $("#txt_Id").val(),
        "PaperName": $("#txt_PaperName").val(),
        "PaperStatus": $("#txt_PaperStatus").val(),
        "ProblemCount": $("#txt_ProblemCount").val(),
        "RecTf": $("#txt_RecTf").val(),
        "RightProblemCount": $("#txt_RightProblemCount").val(),
        "Url": $("#txt_Url").val(), 
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
    /// <para>纸类</para>
    /// <para>与St_TPaper数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TPaper : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TPaper Factory()
        {
            return new St_TPaper();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 添加时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AddTime
        {            
            get { return this.AddTime; }
            set { this.AddTime = value; }
        }
        
        /// <summary> 科目ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassId
        {            
            get { return this.ClassId; }
            set { this.ClassId = value; }
        }
        
        /// <summary> 点击次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClickNum
        {            
            get { return this.ClickNum; }
            set { this.ClickNum = value; }
        }
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 试卷名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperName
        {            
            get { return this.PaperName; }
            set { this.PaperName = value; }
        }
        
        /// <summary> 试题状态:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperStatus
        {            
            get { return this.PaperStatus; }
            set { this.PaperStatus = value; }
        }
        
        /// <summary> 题目总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ProblemCount
        {            
            get { return this.ProblemCount; }
            set { this.ProblemCount = value; }
        }
        
        /// <summary> 是否回顾:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RecTf
        {            
            get { return this.RecTf; }
            set { this.RecTf = value; }
        }
        
        /// <summary> 判断题总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RightProblemCount
        {            
            get { return this.RightProblemCount; }
            set { this.RightProblemCount = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> 添加时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AddTime
        {
            get { return this.m_addtime; }
            set //
            {
                if (!addtime_initialized || m_addtime != value)
                {
                    this.m_addtime = value;
                }
                addtime_initialized = true;
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
        
        /// <summary> 点击次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ClickNum
        {
            get { return this.m_clicknum; }
            set //
            {
                if (!clicknum_initialized || m_clicknum != value)
                {
                    this.m_clicknum = value;
                }
                clicknum_initialized = true;
            }
        }
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 试卷名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperName
        {
            get { return this.m_papername; }
            set //
            {
                if (!papername_initialized || m_papername != value)
                {
                    this.m_papername = value;
                }
                papername_initialized = true;
            }
        }
        
        /// <summary> 试题状态:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperStatus
        {
            get { return this.m_paperstatus; }
            set //
            {
                if (!paperstatus_initialized || m_paperstatus != value)
                {
                    this.m_paperstatus = value;
                }
                paperstatus_initialized = true;
            }
        }
        
        /// <summary> 题目总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ProblemCount
        {
            get { return this.m_problemcount; }
            set //
            {
                if (!problemcount_initialized || m_problemcount != value)
                {
                    this.m_problemcount = value;
                }
                problemcount_initialized = true;
            }
        }
        
        /// <summary> 是否回顾:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string RecTf
        {
            get { return this.m_rectf; }
            set //
            {
                if (!rectf_initialized || m_rectf != value)
                {
                    this.m_rectf = value;
                }
                rectf_initialized = true;
            }
        }
        
        /// <summary> 判断题总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string RightProblemCount
        {
            get { return this.m_rightproblemcount; }
            set //
            {
                if (!rightproblemcount_initialized || m_rightproblemcount != value)
                {
                    this.m_rightproblemcount = value;
                }
                rightproblemcount_initialized = true;
            }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TPaper].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>添加时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AddTime =  new AttributeItem("[St_TPaper].[AddTime]", typeof(string), 200, default(string));
            
            /// <summary>科目ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassId =  new AttributeItem("[St_TPaper].[ClassId]", typeof(string), 200, default(string));
            
            /// <summary>点击次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClickNum =  new AttributeItem("[St_TPaper].[ClickNum]", typeof(string), 200, default(string));
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TPaper].[Id]", typeof(string), 200, default(string));
            
            /// <summary>试卷名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperName =  new AttributeItem("[St_TPaper].[PaperName]", typeof(string), 200, default(string));
            
            /// <summary>试题状态:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperStatus =  new AttributeItem("[St_TPaper].[PaperStatus]", typeof(string), 200, default(string));
            
            /// <summary>题目总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ProblemCount =  new AttributeItem("[St_TPaper].[ProblemCount]", typeof(string), 200, default(string));
            
            /// <summary>是否回顾:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RecTf =  new AttributeItem("[St_TPaper].[RecTf]", typeof(string), 200, default(string));
            
            /// <summary>判断题总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RightProblemCount =  new AttributeItem("[St_TPaper].[RightProblemCount]", typeof(string), 200, default(string));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[St_TPaper].[Url]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_addtime;
        /// <summary></summary>
        protected bool addtime_initialized = false;
        
        private string m_classid;
        /// <summary></summary>
        protected bool classid_initialized = false;
        
        private string m_clicknum;
        /// <summary></summary>
        protected bool clicknum_initialized = false;
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_papername;
        /// <summary></summary>
        protected bool papername_initialized = false;
        
        private string m_paperstatus;
        /// <summary></summary>
        protected bool paperstatus_initialized = false;
        
        private string m_problemcount;
        /// <summary></summary>
        protected bool problemcount_initialized = false;
        
        private string m_rectf;
        /// <summary></summary>
        protected bool rectf_initialized = false;
        
        private string m_rightproblemcount;
        /// <summary></summary>
        protected bool rightproblemcount_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TPaper";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.addtime_initialized = IsLoadAllAttributes;this.classid_initialized = IsLoadAllAttributes;this.clicknum_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.papername_initialized = IsLoadAllAttributes;this.paperstatus_initialized = IsLoadAllAttributes;this.problemcount_initialized = IsLoadAllAttributes;this.rectf_initialized = IsLoadAllAttributes;this.rightproblemcount_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TPaper value = new St_TPaper();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddTime"))
				value.addtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassId"))
				value.classid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClickNum"))
				value.clicknum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperName"))
				value.papername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperStatus"))
				value.paperstatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ProblemCount"))
				value.problemcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RecTf"))
				value.rectf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RightProblemCount"))
				value.rightproblemcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TPaper Clone()
        {
            return (St_TPaper)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TPaper()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TPaper() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TPaper(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TPaper(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TPaper(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TPaper(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TPaper(int autoid1, string addtime1, string classid1, string clicknum1, string id1, string papername1, string paperstatus1, string problemcount1, string rectf1, string rightproblemcount1, string url1)
        {
            
            this.AutoId = autoid1;
            
            this.AddTime = addtime1;
            
            this.ClassId = classid1;
            
            this.ClickNum = clicknum1;
            
            this.Id = id1;
            
            this.PaperName = papername1;
            
            this.PaperStatus = paperstatus1;
            
            this.ProblemCount = problemcount1;
            
            this.RecTf = rectf1;
            
            this.RightProblemCount = rightproblemcount1;
            
            this.Url = url1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TPaper FromIView(IView view)
        {
            return (St_TPaper)IView.GetITable(view, "St_TPaper");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TPaper GetOneInstance()
        {
            St_TPaper value = new St_TPaper();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TPaper Retrieve()
        {
            BLLTable<St_TPaper>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "AddTime":
			        return AddTime;
			    			
			    case "ClassId":
			        return ClassId;
			    			
			    case "ClickNum":
			        return ClickNum;
			    			
			    case "Id":
			        return Id;
			    			
			    case "PaperName":
			        return PaperName;
			    			
			    case "PaperStatus":
			        return PaperStatus;
			    			
			    case "ProblemCount":
			        return ProblemCount;
			    			
			    case "RecTf":
			        return RecTf;
			    			
			    case "RightProblemCount":
			        return RightProblemCount;
			    			
			    case "Url":
			        return Url;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AddTime":
			        this.AddTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassId":
			        this.ClassId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClickNum":
			        this.ClickNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperName":
			        this.PaperName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperStatus":
			        this.PaperStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ProblemCount":
			        this.ProblemCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RecTf":
			        this.RecTf = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RightProblemCount":
			        this.RightProblemCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "AddTime":
					return addtime_initialized;
				
				case "ClassId":
					return classid_initialized;
				
				case "ClickNum":
					return clicknum_initialized;
				
				case "Id":
					return id_initialized;
				
				case "PaperName":
					return papername_initialized;
				
				case "PaperStatus":
					return paperstatus_initialized;
				
				case "ProblemCount":
					return problemcount_initialized;
				
				case "RecTf":
					return rectf_initialized;
				
				case "RightProblemCount":
					return rightproblemcount_initialized;
				
				case "Url":
					return url_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "AddTime":
					addtime_initialized = ret;
					return true;
				
				case "ClassId":
					classid_initialized = ret;
					return true;
				
				case "ClickNum":
					clicknum_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "PaperName":
					papername_initialized = ret;
					return true;
				
				case "PaperStatus":
					paperstatus_initialized = ret;
					return true;
				
				case "ProblemCount":
					problemcount_initialized = ret;
					return true;
				
				case "RecTf":
					rectf_initialized = ret;
					return true;
				
				case "RightProblemCount":
					rightproblemcount_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (addtime_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.AddTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddTime);
                }
			}
			
			if (classid_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ClassId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassId);
                }
			}
			
			if (clicknum_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ClickNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClickNum);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (papername_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.PaperName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperName);
                }
			}
			
			if (paperstatus_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.PaperStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperStatus);
                }
			}
			
			if (problemcount_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ProblemCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ProblemCount);
                }
			}
			
			if (rectf_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.RecTf;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RecTf);
                }
			}
			
			if (rightproblemcount_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.RightProblemCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RightProblemCount);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
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
        public class St_TPaperJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>添加时间:[CtrlTypeDic-{InputString}]</summary>
            public string AddTime { get; set; }
            
            /// <summary>科目ID:[CtrlTypeDic-{InputString}]</summary>
            public string ClassId { get; set; }
            
            /// <summary>点击次数:[CtrlTypeDic-{InputString}]</summary>
            public string ClickNum { get; set; }
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>试卷名:[CtrlTypeDic-{InputString}]</summary>
            public string PaperName { get; set; }
            
            /// <summary>试题状态:[CtrlTypeDic-{InputString}]</summary>
            public string PaperStatus { get; set; }
            
            /// <summary>题目总数:[CtrlTypeDic-{InputString}]</summary>
            public string ProblemCount { get; set; }
            
            /// <summary>是否回顾:[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public string RecTf { get; set; }
            
            /// <summary>判断题总数:[CtrlTypeDic-{InputString}]</summary>
            public string RightProblemCount { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
        }
        #endregion
    }
}