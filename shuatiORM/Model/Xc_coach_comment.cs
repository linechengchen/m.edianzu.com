/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:29
  Description:    数据表Xc_coach_comment对应的业务逻辑层Xc_coach_comment
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xc_coach_comment_Entity:Xc_coach_comment
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,User_Id,Content,Zan,Star,Create_time,Reply from Xc_coach_comment
delete from Xc_coach_comment
INSERT INTO Xc_coach_comment (Id,User_Id,Content,Zan,Star,Create_time,Reply)
     VALUES
           ('','','','','','','')
UPDATE Xc_coach_comment SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.User_Id = valObj2.User_Id;
        valObj.Content = valObj2.Content;
        valObj.Zan = valObj2.Zan;
        valObj.Star = valObj2.Star;
        valObj.Create_time = valObj2.Create_time;
        valObj.Reply = valObj2.Reply; 
        valObj.Id = "";
        valObj.User_Id = "";
        valObj.Content = "";
        valObj.Zan = "";
        valObj.Star = "";
        valObj.Create_time = "";
        valObj.Reply = ""; 
        "Id": $("#txt_Id").val(),
        "User_Id": $("#txt_User_Id").val(),
        "Content": $("#txt_Content").val(),
        "Zan": $("#txt_Zan").val(),
        "Star": $("#txt_Star").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Reply": $("#txt_Reply").val(), 
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
    /// <para>教练的评论</para>
    /// <para>与Xc_coach_comment数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xc_coach_comment : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xc_coach_comment Factory()
        {
            return new Xc_coach_comment();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 用户ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_Id
        {            
            get { return this.User_Id; }
            set { this.User_Id = value; }
        }
        
        /// <summary> 内容:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> 赞:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Zan
        {            
            get { return this.Zan; }
            set { this.Zan = value; }
        }
        
        /// <summary> 星级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Star
        {            
            get { return this.Star; }
            set { this.Star = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 回复:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Reply
        {            
            get { return this.Reply; }
            set { this.Reply = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 用户ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid User_Id
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
        
        /// <summary> 内容:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Content
        {
            get { return this.m_content; }
            set //
            {
                if (!content_initialized || m_content != value)
                {
                    this.m_content = value;
                }
                content_initialized = true;
            }
        }
        
        /// <summary> 赞:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Zan
        {
            get { return this.m_zan; }
            set //
            {
                if (!zan_initialized || m_zan != value)
                {
                    this.m_zan = value;
                }
                zan_initialized = true;
            }
        }
        
        /// <summary> 星级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Star
        {
            get { return this.m_star; }
            set //
            {
                if (!star_initialized || m_star != value)
                {
                    this.m_star = value;
                }
                star_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> 回复:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Reply
        {
            get { return this.m_reply; }
            set //
            {
                if (!reply_initialized || m_reply != value)
                {
                    this.m_reply = value;
                }
                reply_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xc_coach_comment].[Id]", typeof(int), 4, default(int));
            
            /// <summary>用户ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_Id =  new AttributeItem("[Xc_coach_comment].[User_Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>内容:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xc_coach_comment].[Content]", typeof(string), 1000, default(string));
            
            /// <summary>赞:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Zan =  new AttributeItem("[Xc_coach_comment].[Zan]", typeof(int), 4, default(int));
            
            /// <summary>星级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Star =  new AttributeItem("[Xc_coach_comment].[Star]", typeof(int), 4, default(int));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xc_coach_comment].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>回复:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Reply =  new AttributeItem("[Xc_coach_comment].[Reply]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private int m_zan;
        /// <summary></summary>
        protected bool zan_initialized = false;
        
        private int m_star;
        /// <summary></summary>
        protected bool star_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_reply;
        /// <summary></summary>
        protected bool reply_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xc_coach_comment";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.zan_initialized = IsLoadAllAttributes;this.star_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.reply_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xc_coach_comment value = new Xc_coach_comment();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_Id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Zan"))
				value.zan_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Star"))
				value.star_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Reply"))
				value.reply_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xc_coach_comment Clone()
        {
            return (Xc_coach_comment)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xc_coach_comment()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xc_coach_comment() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xc_coach_comment(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xc_coach_comment(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xc_coach_comment(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xc_coach_comment(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xc_coach_comment(int id1, Guid user_id1, string content1, int zan1, int star1, DateTime create_time1, string reply1)
        {
            
            this.Id = id1;
            
            this.User_Id = user_id1;
            
            this.Content = content1;
            
            this.Zan = zan1;
            
            this.Star = star1;
            
            this.Create_time = create_time1;
            
            this.Reply = reply1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xc_coach_comment FromIView(IView view)
        {
            return (Xc_coach_comment)IView.GetITable(view, "Xc_coach_comment");
        }
        /// <summary>获得一个实例  </summary>
        public static Xc_coach_comment GetOneInstance()
        {
            Xc_coach_comment value = new Xc_coach_comment();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xc_coach_comment Retrieve()
        {
            BLLTable<Xc_coach_comment>.GetRowData(this);
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
			    			
			    case "User_Id":
			        return User_Id;
			    			
			    case "Content":
			        return Content;
			    			
			    case "Zan":
			        return Zan;
			    			
			    case "Star":
			        return Star;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Reply":
			        return Reply;
			
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
			    			
			    case "User_Id":
			        this.User_Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Zan":
			        this.Zan = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Star":
			        this.Star = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Reply":
			        this.Reply = Convert.ToString(AttributeValue);
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
				
				case "User_Id":
					return user_id_initialized;
				
				case "Content":
					return content_initialized;
				
				case "Zan":
					return zan_initialized;
				
				case "Star":
					return star_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Reply":
					return reply_initialized;
				
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
				
				case "User_Id":
					user_id_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "Zan":
					zan_initialized = ret;
					return true;
				
				case "Star":
					star_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Reply":
					reply_initialized = ret;
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
                AttributeItem attr = Xc_coach_comment.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.User_Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_Id);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (zan_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.Zan;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Zan);
                }
			}
			
			if (star_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.Star;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Star);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (reply_initialized)
			{
                AttributeItem attr = Xc_coach_comment.Attribute.Reply;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Reply);
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
        public class Xc_coach_commentJson
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>用户ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid User_Id { get; set; }
            
            /// <summary>内容:[CtrlTypeDic-{Text}]</summary>
            public string Content { get; set; }
            
            /// <summary>赞:[CtrlTypeDic-{InputString}]</summary>
            public int Zan { get; set; }
            
            /// <summary>星级:[CtrlTypeDic-{InputString}]</summary>
            public int Star { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>回复:[CtrlTypeDic-{InputString}]</summary>
            public string Reply { get; set; }
        }
        #endregion
    }
}