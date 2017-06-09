/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:29
  Description:    数据表Xs_book对应的业务逻辑层Xs_book
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xs_book_Entity:Xs_book
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,OldId,OldPath,Title,MarketPrice,Publisher,Author,Supply,NewSupply,NewMarketPrice,Intro,CategoryId,RecommendId,CreateTime,ReadSum,Path,BookZyId,OldPath2,Path2,City_id from Xs_book
delete from Xs_book
INSERT INTO Xs_book (Id,OldId,OldPath,Title,MarketPrice,Publisher,Author,Supply,NewSupply,NewMarketPrice,Intro,CategoryId,RecommendId,CreateTime,ReadSum,Path,BookZyId,OldPath2,Path2,City_id)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','')
UPDATE Xs_book SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.OldId = valObj2.OldId;
        valObj.OldPath = valObj2.OldPath;
        valObj.Title = valObj2.Title;
        valObj.MarketPrice = valObj2.MarketPrice;
        valObj.Publisher = valObj2.Publisher;
        valObj.Author = valObj2.Author;
        valObj.Supply = valObj2.Supply;
        valObj.NewSupply = valObj2.NewSupply;
        valObj.NewMarketPrice = valObj2.NewMarketPrice;
        valObj.Intro = valObj2.Intro;
        valObj.CategoryId = valObj2.CategoryId;
        valObj.RecommendId = valObj2.RecommendId;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ReadSum = valObj2.ReadSum;
        valObj.Path = valObj2.Path;
        valObj.BookZyId = valObj2.BookZyId;
        valObj.OldPath2 = valObj2.OldPath2;
        valObj.Path2 = valObj2.Path2;
        valObj.City_id = valObj2.City_id; 
        valObj.Id = "";
        valObj.OldId = "";
        valObj.OldPath = "";
        valObj.Title = "";
        valObj.MarketPrice = "";
        valObj.Publisher = "";
        valObj.Author = "";
        valObj.Supply = "";
        valObj.NewSupply = "";
        valObj.NewMarketPrice = "";
        valObj.Intro = "";
        valObj.CategoryId = "";
        valObj.RecommendId = "";
        valObj.CreateTime = "";
        valObj.ReadSum = "";
        valObj.Path = "";
        valObj.BookZyId = "";
        valObj.OldPath2 = "";
        valObj.Path2 = "";
        valObj.City_id = ""; 
        "Id": $("#txt_Id").val(),
        "OldId": $("#txt_OldId").val(),
        "OldPath": $("#txt_OldPath").val(),
        "Title": $("#txt_Title").val(),
        "MarketPrice": $("#txt_MarketPrice").val(),
        "Publisher": $("#txt_Publisher").val(),
        "Author": $("#txt_Author").val(),
        "Supply": $("#txt_Supply").val(),
        "NewSupply": $("#txt_NewSupply").val(),
        "NewMarketPrice": $("#txt_NewMarketPrice").val(),
        "Intro": $("#txt_Intro").val(),
        "CategoryId": $("#txt_CategoryId").val(),
        "RecommendId": $("#txt_RecommendId").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ReadSum": $("#txt_ReadSum").val(),
        "Path": $("#txt_Path").val(),
        "BookZyId": $("#txt_BookZyId").val(),
        "OldPath2": $("#txt_OldPath2").val(),
        "Path2": $("#txt_Path2").val(),
        "City_id": $("#txt_City_id").val(), 
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
    /// <para>图书销售</para>
    /// <para>与Xs_book数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xs_book : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xs_book Factory()
        {
            return new Xs_book();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 身份证件:[CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 旧身份证:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _OldId
        {            
            get { return this.OldId; }
            set { this.OldId = value; }
        }
        
        /// <summary> 旧路:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OldPath
        {            
            get { return this.OldPath; }
            set { this.OldPath = value; }
        }
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> 市场价格:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MarketPrice
        {            
            get { return this.MarketPrice; }
            set { this.MarketPrice = value; }
        }
        
        /// <summary> 出版商:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Publisher
        {            
            get { return this.Publisher; }
            set { this.Publisher = value; }
        }
        
        /// <summary> 作者:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Author
        {            
            get { return this.Author; }
            set { this.Author = value; }
        }
        
        /// <summary> 供应:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Supply
        {            
            get { return this.Supply; }
            set { this.Supply = value; }
        }
        
        /// <summary> 新的供应:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _NewSupply
        {            
            get { return this.NewSupply; }
            set { this.NewSupply = value; }
        }
        
        /// <summary> 新的市场价格:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NewMarketPrice
        {            
            get { return this.NewMarketPrice; }
            set { this.NewMarketPrice = value; }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> 类别ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CategoryId
        {            
            get { return this.CategoryId; }
            set { this.CategoryId = value; }
        }
        
        /// <summary> 推荐ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _RecommendId
        {            
            get { return this.RecommendId; }
            set { this.RecommendId = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 阅读量:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ReadSum
        {            
            get { return this.ReadSum; }
            set { this.ReadSum = value; }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> 本书ZYID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _BookZyId
        {            
            get { return this.BookZyId; }
            set { this.BookZyId = value; }
        }
        
        /// <summary> 2岁的路径:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OldPath2
        {            
            get { return this.OldPath2; }
            set { this.OldPath2 = value; }
        }
        
        /// <summary> 路径2:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path2
        {            
            get { return this.Path2; }
            set { this.Path2 = value; }
        }
        
        /// <summary> 城市ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
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
        
        /// <summary> 旧身份证:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int OldId
        {
            get { return this.m_oldid; }
            set //
            {
                if (!oldid_initialized || m_oldid != value)
                {
                    this.m_oldid = value;
                }
                oldid_initialized = true;
            }
        }
        
        /// <summary> 旧路:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OldPath
        {
            get { return this.m_oldpath; }
            set //
            {
                if (!oldpath_initialized || m_oldpath != value)
                {
                    this.m_oldpath = value;
                }
                oldpath_initialized = true;
            }
        }
        
        /// <summary> 标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> 市场价格:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MarketPrice
        {
            get { return this.m_marketprice; }
            set //
            {
                if (!marketprice_initialized || m_marketprice != value)
                {
                    this.m_marketprice = value;
                }
                marketprice_initialized = true;
            }
        }
        
        /// <summary> 出版商:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Publisher
        {
            get { return this.m_publisher; }
            set //
            {
                if (!publisher_initialized || m_publisher != value)
                {
                    this.m_publisher = value;
                }
                publisher_initialized = true;
            }
        }
        
        /// <summary> 作者:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Author
        {
            get { return this.m_author; }
            set //
            {
                if (!author_initialized || m_author != value)
                {
                    this.m_author = value;
                }
                author_initialized = true;
            }
        }
        
        /// <summary> 供应:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Supply
        {
            get { return this.m_supply; }
            set //
            {
                if (!supply_initialized || m_supply != value)
                {
                    this.m_supply = value;
                }
                supply_initialized = true;
            }
        }
        
        /// <summary> 新的供应:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int NewSupply
        {
            get { return this.m_newsupply; }
            set //
            {
                if (!newsupply_initialized || m_newsupply != value)
                {
                    this.m_newsupply = value;
                }
                newsupply_initialized = true;
            }
        }
        
        /// <summary> 新的市场价格:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string NewMarketPrice
        {
            get { return this.m_newmarketprice; }
            set //
            {
                if (!newmarketprice_initialized || m_newmarketprice != value)
                {
                    this.m_newmarketprice = value;
                }
                newmarketprice_initialized = true;
            }
        }
        
        /// <summary> 简介:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Intro
        {
            get { return this.m_intro; }
            set //
            {
                if (!intro_initialized || m_intro != value)
                {
                    this.m_intro = value;
                }
                intro_initialized = true;
            }
        }
        
        /// <summary> 类别ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int CategoryId
        {
            get { return this.m_categoryid; }
            set //
            {
                if (!categoryid_initialized || m_categoryid != value)
                {
                    this.m_categoryid = value;
                }
                categoryid_initialized = true;
            }
        }
        
        /// <summary> 推荐ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int RecommendId
        {
            get { return this.m_recommendid; }
            set //
            {
                if (!recommendid_initialized || m_recommendid != value)
                {
                    this.m_recommendid = value;
                }
                recommendid_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 阅读量:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ReadSum
        {
            get { return this.m_readsum; }
            set //
            {
                if (!readsum_initialized || m_readsum != value)
                {
                    this.m_readsum = value;
                }
                readsum_initialized = true;
            }
        }
        
        /// <summary> 路径:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 本书ZYID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int BookZyId
        {
            get { return this.m_bookzyid; }
            set //
            {
                if (!bookzyid_initialized || m_bookzyid != value)
                {
                    this.m_bookzyid = value;
                }
                bookzyid_initialized = true;
            }
        }
        
        /// <summary> 2岁的路径:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OldPath2
        {
            get { return this.m_oldpath2; }
            set //
            {
                if (!oldpath2_initialized || m_oldpath2 != value)
                {
                    this.m_oldpath2 = value;
                }
                oldpath2_initialized = true;
            }
        }
        
        /// <summary> 路径2:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Path2
        {
            get { return this.m_path2; }
            set //
            {
                if (!path2_initialized || m_path2 != value)
                {
                    this.m_path2 = value;
                }
                path2_initialized = true;
            }
        }
        
        /// <summary> 城市ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int City_id
        {
            get { return this.m_city_id; }
            set //
            {
                if (!city_id_initialized || m_city_id != value)
                {
                    this.m_city_id = value;
                }
                city_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xs_book].[Id]", typeof(int), 4, default(int));
            
            /// <summary>旧身份证:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldId =  new AttributeItem("[Xs_book].[OldId]", typeof(int), 4, default(int));
            
            /// <summary>旧路:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldPath =  new AttributeItem("[Xs_book].[OldPath]", typeof(string), 200, default(string));
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xs_book].[Title]", typeof(string), 200, default(string));
            
            /// <summary>市场价格:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MarketPrice =  new AttributeItem("[Xs_book].[MarketPrice]", typeof(string), 50, default(string));
            
            /// <summary>出版商:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Publisher =  new AttributeItem("[Xs_book].[Publisher]", typeof(string), 200, default(string));
            
            /// <summary>作者:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Author =  new AttributeItem("[Xs_book].[Author]", typeof(string), 200, default(string));
            
            /// <summary>供应:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Supply =  new AttributeItem("[Xs_book].[Supply]", typeof(int), 4, default(int));
            
            /// <summary>新的供应:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NewSupply =  new AttributeItem("[Xs_book].[NewSupply]", typeof(int), 4, default(int));
            
            /// <summary>新的市场价格:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NewMarketPrice =  new AttributeItem("[Xs_book].[NewMarketPrice]", typeof(string), 50, default(string));
            
            /// <summary>简介:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[Xs_book].[Intro]", typeof(string), -1, default(string));
            
            /// <summary>类别ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CategoryId =  new AttributeItem("[Xs_book].[CategoryId]", typeof(int), 4, default(int));
            
            /// <summary>推荐ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RecommendId =  new AttributeItem("[Xs_book].[RecommendId]", typeof(int), 4, default(int));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xs_book].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>阅读量:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ReadSum =  new AttributeItem("[Xs_book].[ReadSum]", typeof(int), 4, default(int));
            
            /// <summary>路径:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xs_book].[Path]", typeof(string), 200, default(string));
            
            /// <summary>本书ZYID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BookZyId =  new AttributeItem("[Xs_book].[BookZyId]", typeof(int), 4, default(int));
            
            /// <summary>2岁的路径:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OldPath2 =  new AttributeItem("[Xs_book].[OldPath2]", typeof(string), 200, default(string));
            
            /// <summary>路径2:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path2 =  new AttributeItem("[Xs_book].[Path2]", typeof(string), 200, default(string));
            
            /// <summary>城市ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[Xs_book].[City_id]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_oldid;
        /// <summary></summary>
        protected bool oldid_initialized = false;
        
        private string m_oldpath;
        /// <summary></summary>
        protected bool oldpath_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_marketprice;
        /// <summary></summary>
        protected bool marketprice_initialized = false;
        
        private string m_publisher;
        /// <summary></summary>
        protected bool publisher_initialized = false;
        
        private string m_author;
        /// <summary></summary>
        protected bool author_initialized = false;
        
        private int m_supply;
        /// <summary></summary>
        protected bool supply_initialized = false;
        
        private int m_newsupply;
        /// <summary></summary>
        protected bool newsupply_initialized = false;
        
        private string m_newmarketprice;
        /// <summary></summary>
        protected bool newmarketprice_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private int m_categoryid;
        /// <summary></summary>
        protected bool categoryid_initialized = false;
        
        private int m_recommendid;
        /// <summary></summary>
        protected bool recommendid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_readsum;
        /// <summary></summary>
        protected bool readsum_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private int m_bookzyid;
        /// <summary></summary>
        protected bool bookzyid_initialized = false;
        
        private string m_oldpath2;
        /// <summary></summary>
        protected bool oldpath2_initialized = false;
        
        private string m_path2;
        /// <summary></summary>
        protected bool path2_initialized = false;
        
        private int m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_book";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.oldid_initialized = IsLoadAllAttributes;this.oldpath_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.marketprice_initialized = IsLoadAllAttributes;this.publisher_initialized = IsLoadAllAttributes;this.author_initialized = IsLoadAllAttributes;this.supply_initialized = IsLoadAllAttributes;this.newsupply_initialized = IsLoadAllAttributes;this.newmarketprice_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.categoryid_initialized = IsLoadAllAttributes;this.recommendid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.readsum_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.bookzyid_initialized = IsLoadAllAttributes;this.oldpath2_initialized = IsLoadAllAttributes;this.path2_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_book value = new Xs_book();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldId"))
				value.oldid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldPath"))
				value.oldpath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MarketPrice"))
				value.marketprice_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Publisher"))
				value.publisher_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Author"))
				value.author_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Supply"))
				value.supply_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NewSupply"))
				value.newsupply_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NewMarketPrice"))
				value.newmarketprice_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CategoryId"))
				value.categoryid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RecommendId"))
				value.recommendid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ReadSum"))
				value.readsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BookZyId"))
				value.bookzyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OldPath2"))
				value.oldpath2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path2"))
				value.path2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xs_book Clone()
        {
            return (Xs_book)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xs_book()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xs_book() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xs_book(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xs_book(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xs_book(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xs_book(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xs_book(int id1, int oldid1, string oldpath1, string title1, string marketprice1, string publisher1, string author1, int supply1, int newsupply1, string newmarketprice1, string intro1, int categoryid1, int recommendid1, DateTime createtime1, int readsum1, string path1, int bookzyid1, string oldpath21, string path21, int city_id1)
        {
            
            this.Id = id1;
            
            this.OldId = oldid1;
            
            this.OldPath = oldpath1;
            
            this.Title = title1;
            
            this.MarketPrice = marketprice1;
            
            this.Publisher = publisher1;
            
            this.Author = author1;
            
            this.Supply = supply1;
            
            this.NewSupply = newsupply1;
            
            this.NewMarketPrice = newmarketprice1;
            
            this.Intro = intro1;
            
            this.CategoryId = categoryid1;
            
            this.RecommendId = recommendid1;
            
            this.CreateTime = createtime1;
            
            this.ReadSum = readsum1;
            
            this.Path = path1;
            
            this.BookZyId = bookzyid1;
            
            this.OldPath2 = oldpath21;
            
            this.Path2 = path21;
            
            this.City_id = city_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xs_book FromIView(IView view)
        {
            return (Xs_book)IView.GetITable(view, "Xs_book");
        }
        /// <summary>获得一个实例  </summary>
        public static Xs_book GetOneInstance()
        {
            Xs_book value = new Xs_book();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xs_book Retrieve()
        {
            BLLTable<Xs_book>.GetRowData(this);
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
			    			
			    case "OldId":
			        return OldId;
			    			
			    case "OldPath":
			        return OldPath;
			    			
			    case "Title":
			        return Title;
			    			
			    case "MarketPrice":
			        return MarketPrice;
			    			
			    case "Publisher":
			        return Publisher;
			    			
			    case "Author":
			        return Author;
			    			
			    case "Supply":
			        return Supply;
			    			
			    case "NewSupply":
			        return NewSupply;
			    			
			    case "NewMarketPrice":
			        return NewMarketPrice;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "CategoryId":
			        return CategoryId;
			    			
			    case "RecommendId":
			        return RecommendId;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ReadSum":
			        return ReadSum;
			    			
			    case "Path":
			        return Path;
			    			
			    case "BookZyId":
			        return BookZyId;
			    			
			    case "OldPath2":
			        return OldPath2;
			    			
			    case "Path2":
			        return Path2;
			    			
			    case "City_id":
			        return City_id;
			
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
			    			
			    case "OldId":
			        this.OldId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OldPath":
			        this.OldPath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MarketPrice":
			        this.MarketPrice = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Publisher":
			        this.Publisher = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Author":
			        this.Author = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Supply":
			        this.Supply = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "NewSupply":
			        this.NewSupply = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "NewMarketPrice":
			        this.NewMarketPrice = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CategoryId":
			        this.CategoryId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "RecommendId":
			        this.RecommendId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ReadSum":
			        this.ReadSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BookZyId":
			        this.BookZyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OldPath2":
			        this.OldPath2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path2":
			        this.Path2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToInt32(AttributeValue);
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
				
				case "OldId":
					return oldid_initialized;
				
				case "OldPath":
					return oldpath_initialized;
				
				case "Title":
					return title_initialized;
				
				case "MarketPrice":
					return marketprice_initialized;
				
				case "Publisher":
					return publisher_initialized;
				
				case "Author":
					return author_initialized;
				
				case "Supply":
					return supply_initialized;
				
				case "NewSupply":
					return newsupply_initialized;
				
				case "NewMarketPrice":
					return newmarketprice_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "CategoryId":
					return categoryid_initialized;
				
				case "RecommendId":
					return recommendid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ReadSum":
					return readsum_initialized;
				
				case "Path":
					return path_initialized;
				
				case "BookZyId":
					return bookzyid_initialized;
				
				case "OldPath2":
					return oldpath2_initialized;
				
				case "Path2":
					return path2_initialized;
				
				case "City_id":
					return city_id_initialized;
				
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
				
				case "OldId":
					oldid_initialized = ret;
					return true;
				
				case "OldPath":
					oldpath_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "MarketPrice":
					marketprice_initialized = ret;
					return true;
				
				case "Publisher":
					publisher_initialized = ret;
					return true;
				
				case "Author":
					author_initialized = ret;
					return true;
				
				case "Supply":
					supply_initialized = ret;
					return true;
				
				case "NewSupply":
					newsupply_initialized = ret;
					return true;
				
				case "NewMarketPrice":
					newmarketprice_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "CategoryId":
					categoryid_initialized = ret;
					return true;
				
				case "RecommendId":
					recommendid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ReadSum":
					readsum_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "BookZyId":
					bookzyid_initialized = ret;
					return true;
				
				case "OldPath2":
					oldpath2_initialized = ret;
					return true;
				
				case "Path2":
					path2_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
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
                AttributeItem attr = Xs_book.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (oldid_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.OldId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldId);
                }
			}
			
			if (oldpath_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.OldPath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldPath);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (marketprice_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.MarketPrice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MarketPrice);
                }
			}
			
			if (publisher_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Publisher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Publisher);
                }
			}
			
			if (author_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Author;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Author);
                }
			}
			
			if (supply_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Supply;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Supply);
                }
			}
			
			if (newsupply_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.NewSupply;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NewSupply);
                }
			}
			
			if (newmarketprice_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.NewMarketPrice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NewMarketPrice);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (categoryid_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.CategoryId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CategoryId);
                }
			}
			
			if (recommendid_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.RecommendId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RecommendId);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (readsum_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.ReadSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ReadSum);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (bookzyid_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.BookZyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BookZyId);
                }
			}
			
			if (oldpath2_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.OldPath2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OldPath2);
                }
			}
			
			if (path2_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.Path2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path2);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = Xs_book.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
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
        public class Xs_bookJson
        {
            
            /// <summary>身份证件:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>旧身份证:[CtrlTypeDic-{InputString}]</summary>
            public int OldId { get; set; }
            
            /// <summary>旧路:[CtrlTypeDic-{InputString}]</summary>
            public string OldPath { get; set; }
            
            /// <summary>标题:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>市场价格:[CtrlTypeDic-{InputString}]</summary>
            public string MarketPrice { get; set; }
            
            /// <summary>出版商:[CtrlTypeDic-{InputString}]</summary>
            public string Publisher { get; set; }
            
            /// <summary>作者:[CtrlTypeDic-{InputString}]</summary>
            public string Author { get; set; }
            
            /// <summary>供应:[CtrlTypeDic-{InputString}]</summary>
            public int Supply { get; set; }
            
            /// <summary>新的供应:[CtrlTypeDic-{InputString}]</summary>
            public int NewSupply { get; set; }
            
            /// <summary>新的市场价格:[CtrlTypeDic-{InputString}]</summary>
            public string NewMarketPrice { get; set; }
            
            /// <summary>简介:[CtrlTypeDic-{InputString}]</summary>
            public string Intro { get; set; }
            
            /// <summary>类别ID:[CtrlTypeDic-{InputString}]</summary>
            public int CategoryId { get; set; }
            
            /// <summary>推荐ID:[CtrlTypeDic-{InputString}]</summary>
            public int RecommendId { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>阅读量:[CtrlTypeDic-{InputString}]</summary>
            public int ReadSum { get; set; }
            
            /// <summary>路径:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>本书ZYID:[CtrlTypeDic-{InputString}]</summary>
            public int BookZyId { get; set; }
            
            /// <summary>2岁的路径:[CtrlTypeDic-{InputString}]</summary>
            public string OldPath2 { get; set; }
            
            /// <summary>路径2:[CtrlTypeDic-{InputString}]</summary>
            public string Path2 { get; set; }
            
            /// <summary>城市ID:[CtrlTypeDic-{InputString}]</summary>
            public int City_id { get; set; }
        }
        #endregion
    }
}