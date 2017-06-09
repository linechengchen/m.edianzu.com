/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:40
  Description:    数据表St_TzsInfo对应的业务逻辑层St_TzsInfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TzsInfo_Entity:St_TzsInfo
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Icon,IsHot,IsShowIndex,Question_sum,Question_sum_time,Question_sum0,Question_sum1,Question_sum2,Question_sum3,Question_sum4,Question_sum5,Question_sum6,Question_sum7,Question_sum8,Question_sumMore,Seq,ZsId,ZsName,ZsTypeId,ZsTypeName from St_TzsInfo
delete from St_TzsInfo
INSERT INTO St_TzsInfo (Id,Icon,IsHot,IsShowIndex,Question_sum,Question_sum_time,Question_sum0,Question_sum1,Question_sum2,Question_sum3,Question_sum4,Question_sum5,Question_sum6,Question_sum7,Question_sum8,Question_sumMore,Seq,ZsId,ZsName,ZsTypeId,ZsTypeName)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','')
UPDATE St_TzsInfo SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Icon = valObj2.Icon;
        valObj.IsHot = valObj2.IsHot;
        valObj.IsShowIndex = valObj2.IsShowIndex;
        valObj.Question_sum = valObj2.Question_sum;
        valObj.Question_sum_time = valObj2.Question_sum_time;
        valObj.Question_sum0 = valObj2.Question_sum0;
        valObj.Question_sum1 = valObj2.Question_sum1;
        valObj.Question_sum2 = valObj2.Question_sum2;
        valObj.Question_sum3 = valObj2.Question_sum3;
        valObj.Question_sum4 = valObj2.Question_sum4;
        valObj.Question_sum5 = valObj2.Question_sum5;
        valObj.Question_sum6 = valObj2.Question_sum6;
        valObj.Question_sum7 = valObj2.Question_sum7;
        valObj.Question_sum8 = valObj2.Question_sum8;
        valObj.Question_sumMore = valObj2.Question_sumMore;
        valObj.Seq = valObj2.Seq;
        valObj.ZsId = valObj2.ZsId;
        valObj.ZsName = valObj2.ZsName;
        valObj.ZsTypeId = valObj2.ZsTypeId;
        valObj.ZsTypeName = valObj2.ZsTypeName; 
        valObj.Id = "";
        valObj.Icon = "";
        valObj.IsHot = "";
        valObj.IsShowIndex = "";
        valObj.Question_sum = "";
        valObj.Question_sum_time = "";
        valObj.Question_sum0 = "";
        valObj.Question_sum1 = "";
        valObj.Question_sum2 = "";
        valObj.Question_sum3 = "";
        valObj.Question_sum4 = "";
        valObj.Question_sum5 = "";
        valObj.Question_sum6 = "";
        valObj.Question_sum7 = "";
        valObj.Question_sum8 = "";
        valObj.Question_sumMore = "";
        valObj.Seq = "";
        valObj.ZsId = "";
        valObj.ZsName = "";
        valObj.ZsTypeId = "";
        valObj.ZsTypeName = ""; 
        "Id": $("#txt_Id").val(),
        "Icon": $("#txt_Icon").val(),
        "IsHot": $("#txt_IsHot").val(),
        "IsShowIndex": $("#txt_IsShowIndex").val(),
        "Question_sum": $("#txt_Question_sum").val(),
        "Question_sum_time": $("#txt_Question_sum_time").val(),
        "Question_sum0": $("#txt_Question_sum0").val(),
        "Question_sum1": $("#txt_Question_sum1").val(),
        "Question_sum2": $("#txt_Question_sum2").val(),
        "Question_sum3": $("#txt_Question_sum3").val(),
        "Question_sum4": $("#txt_Question_sum4").val(),
        "Question_sum5": $("#txt_Question_sum5").val(),
        "Question_sum6": $("#txt_Question_sum6").val(),
        "Question_sum7": $("#txt_Question_sum7").val(),
        "Question_sum8": $("#txt_Question_sum8").val(),
        "Question_sumMore": $("#txt_Question_sumMore").val(),
        "Seq": $("#txt_Seq").val(),
        "ZsId": $("#txt_ZsId").val(),
        "ZsName": $("#txt_ZsName").val(),
        "ZsTypeId": $("#txt_ZsTypeId").val(),
        "ZsTypeName": $("#txt_ZsTypeName").val(), 
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
    /// <para>证书表:[IDField-{Id:0}]</para>
    /// <para>与St_TzsInfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TzsInfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TzsInfo Factory()
        {
            return new St_TzsInfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Icon
        {            
            get { return this.Icon; }
            set { this.Icon = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _IsShowIndex
        {            
            get { return this.IsShowIndex; }
            set { this.IsShowIndex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum
        {            
            get { return this.Question_sum; }
            set { this.Question_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Question_sum_time
        {            
            get { return this.Question_sum_time; }
            set { this.Question_sum_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum0
        {            
            get { return this.Question_sum0; }
            set { this.Question_sum0 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum1
        {            
            get { return this.Question_sum1; }
            set { this.Question_sum1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum2
        {            
            get { return this.Question_sum2; }
            set { this.Question_sum2 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum3
        {            
            get { return this.Question_sum3; }
            set { this.Question_sum3 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum4
        {            
            get { return this.Question_sum4; }
            set { this.Question_sum4 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum5
        {            
            get { return this.Question_sum5; }
            set { this.Question_sum5 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum6
        {            
            get { return this.Question_sum6; }
            set { this.Question_sum6 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum7
        {            
            get { return this.Question_sum7; }
            set { this.Question_sum7 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Question_sum8
        {            
            get { return this.Question_sum8; }
            set { this.Question_sum8 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Question_sumMore
        {            
            get { return this.Question_sumMore; }
            set { this.Question_sumMore = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> 证书Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        
        /// <summary> 证书名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsName
        {            
            get { return this.ZsName; }
            set { this.ZsName = value; }
        }
        
        /// <summary> 类型Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsTypeId
        {            
            get { return this.ZsTypeId; }
            set { this.ZsTypeId = value; }
        }
        
        /// <summary> 类型名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsTypeName
        {            
            get { return this.ZsTypeName; }
            set { this.ZsTypeName = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        public string Icon
        {
            get { return this.m_icon; }
            set //
            {
                if (!icon_initialized || m_icon != value)
                {
                    this.m_icon = value;
                }
                icon_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool IsShowIndex
        {
            get { return this.m_isshowindex; }
            set //
            {
                if (!isshowindex_initialized || m_isshowindex != value)
                {
                    this.m_isshowindex = value;
                }
                isshowindex_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum
        {
            get { return this.m_question_sum; }
            set //
            {
                if (!question_sum_initialized || m_question_sum != value)
                {
                    this.m_question_sum = value;
                }
                question_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Question_sum_time
        {
            get { return this.m_question_sum_time; }
            set //
            {
                if (!question_sum_time_initialized || m_question_sum_time != value)
                {
                    this.m_question_sum_time = value;
                }
                question_sum_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum0
        {
            get { return this.m_question_sum0; }
            set //
            {
                if (!question_sum0_initialized || m_question_sum0 != value)
                {
                    this.m_question_sum0 = value;
                }
                question_sum0_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum1
        {
            get { return this.m_question_sum1; }
            set //
            {
                if (!question_sum1_initialized || m_question_sum1 != value)
                {
                    this.m_question_sum1 = value;
                }
                question_sum1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum2
        {
            get { return this.m_question_sum2; }
            set //
            {
                if (!question_sum2_initialized || m_question_sum2 != value)
                {
                    this.m_question_sum2 = value;
                }
                question_sum2_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum3
        {
            get { return this.m_question_sum3; }
            set //
            {
                if (!question_sum3_initialized || m_question_sum3 != value)
                {
                    this.m_question_sum3 = value;
                }
                question_sum3_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum4
        {
            get { return this.m_question_sum4; }
            set //
            {
                if (!question_sum4_initialized || m_question_sum4 != value)
                {
                    this.m_question_sum4 = value;
                }
                question_sum4_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum5
        {
            get { return this.m_question_sum5; }
            set //
            {
                if (!question_sum5_initialized || m_question_sum5 != value)
                {
                    this.m_question_sum5 = value;
                }
                question_sum5_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum6
        {
            get { return this.m_question_sum6; }
            set //
            {
                if (!question_sum6_initialized || m_question_sum6 != value)
                {
                    this.m_question_sum6 = value;
                }
                question_sum6_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum7
        {
            get { return this.m_question_sum7; }
            set //
            {
                if (!question_sum7_initialized || m_question_sum7 != value)
                {
                    this.m_question_sum7 = value;
                }
                question_sum7_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Question_sum8
        {
            get { return this.m_question_sum8; }
            set //
            {
                if (!question_sum8_initialized || m_question_sum8 != value)
                {
                    this.m_question_sum8 = value;
                }
                question_sum8_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Question_sumMore
        {
            get { return this.m_question_summore; }
            set //
            {
                if (!question_summore_initialized || m_question_summore != value)
                {
                    this.m_question_summore = value;
                }
                question_summore_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
            }
        }
        
        /// <summary> 证书Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ZsId
        {
            get { return this.m_zsid; }
            set //
            {
                if (!zsid_initialized || m_zsid != value)
                {
                    this.m_zsid = value;
                }
                zsid_initialized = true;
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
        
        /// <summary> 类型Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ZsTypeId
        {
            get { return this.m_zstypeid; }
            set //
            {
                if (!zstypeid_initialized || m_zstypeid != value)
                {
                    this.m_zstypeid = value;
                }
                zstypeid_initialized = true;
            }
        }
        
        /// <summary> 类型名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ZsTypeName
        {
            get { return this.m_zstypename; }
            set //
            {
                if (!zstypename_initialized || m_zstypename != value)
                {
                    this.m_zstypename = value;
                }
                zstypename_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_TzsInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Icon =  new AttributeItem("[St_TzsInfo].[Icon]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[St_TzsInfo].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsShowIndex =  new AttributeItem("[St_TzsInfo].[IsShowIndex]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum =  new AttributeItem("[St_TzsInfo].[Question_sum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Question_sum_time =  new AttributeItem("[St_TzsInfo].[Question_sum_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum0 =  new AttributeItem("[St_TzsInfo].[Question_sum0]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum1 =  new AttributeItem("[St_TzsInfo].[Question_sum1]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum2 =  new AttributeItem("[St_TzsInfo].[Question_sum2]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum3 =  new AttributeItem("[St_TzsInfo].[Question_sum3]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum4 =  new AttributeItem("[St_TzsInfo].[Question_sum4]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum5 =  new AttributeItem("[St_TzsInfo].[Question_sum5]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum6 =  new AttributeItem("[St_TzsInfo].[Question_sum6]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum7 =  new AttributeItem("[St_TzsInfo].[Question_sum7]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum8 =  new AttributeItem("[St_TzsInfo].[Question_sum8]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sumMore =  new AttributeItem("[St_TzsInfo].[Question_sumMore]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[St_TzsInfo].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[St_TzsInfo].[ZsId]", typeof(int), 4, default(int));
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsName =  new AttributeItem("[St_TzsInfo].[ZsName]", typeof(string), 50, default(string));
            
            /// <summary>类型Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeId =  new AttributeItem("[St_TzsInfo].[ZsTypeId]", typeof(int), 4, default(int));
            
            /// <summary>类型名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeName =  new AttributeItem("[St_TzsInfo].[ZsTypeName]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_icon;
        /// <summary></summary>
        protected bool icon_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private bool m_isshowindex;
        /// <summary></summary>
        protected bool isshowindex_initialized = false;
        
        private int m_question_sum;
        /// <summary></summary>
        protected bool question_sum_initialized = false;
        
        private DateTime m_question_sum_time;
        /// <summary></summary>
        protected bool question_sum_time_initialized = false;
        
        private int m_question_sum0;
        /// <summary></summary>
        protected bool question_sum0_initialized = false;
        
        private int m_question_sum1;
        /// <summary></summary>
        protected bool question_sum1_initialized = false;
        
        private int m_question_sum2;
        /// <summary></summary>
        protected bool question_sum2_initialized = false;
        
        private int m_question_sum3;
        /// <summary></summary>
        protected bool question_sum3_initialized = false;
        
        private int m_question_sum4;
        /// <summary></summary>
        protected bool question_sum4_initialized = false;
        
        private int m_question_sum5;
        /// <summary></summary>
        protected bool question_sum5_initialized = false;
        
        private int m_question_sum6;
        /// <summary></summary>
        protected bool question_sum6_initialized = false;
        
        private int m_question_sum7;
        /// <summary></summary>
        protected bool question_sum7_initialized = false;
        
        private int m_question_sum8;
        /// <summary></summary>
        protected bool question_sum8_initialized = false;
        
        private string m_question_summore;
        /// <summary></summary>
        protected bool question_summore_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private int m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        
        private string m_zsname;
        /// <summary></summary>
        protected bool zsname_initialized = false;
        
        private int m_zstypeid;
        /// <summary></summary>
        protected bool zstypeid_initialized = false;
        
        private string m_zstypename;
        /// <summary></summary>
        protected bool zstypename_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TzsInfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.icon_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.isshowindex_initialized = IsLoadAllAttributes;this.question_sum_initialized = IsLoadAllAttributes;this.question_sum_time_initialized = IsLoadAllAttributes;this.question_sum0_initialized = IsLoadAllAttributes;this.question_sum1_initialized = IsLoadAllAttributes;this.question_sum2_initialized = IsLoadAllAttributes;this.question_sum3_initialized = IsLoadAllAttributes;this.question_sum4_initialized = IsLoadAllAttributes;this.question_sum5_initialized = IsLoadAllAttributes;this.question_sum6_initialized = IsLoadAllAttributes;this.question_sum7_initialized = IsLoadAllAttributes;this.question_sum8_initialized = IsLoadAllAttributes;this.question_summore_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;this.zsname_initialized = IsLoadAllAttributes;this.zstypeid_initialized = IsLoadAllAttributes;this.zstypename_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TzsInfo value = new St_TzsInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Icon"))
				value.icon_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsShowIndex"))
				value.isshowindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum"))
				value.question_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum_time"))
				value.question_sum_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum0"))
				value.question_sum0_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum1"))
				value.question_sum1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum2"))
				value.question_sum2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum3"))
				value.question_sum3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum4"))
				value.question_sum4_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum5"))
				value.question_sum5_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum6"))
				value.question_sum6_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum7"))
				value.question_sum7_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum8"))
				value.question_sum8_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sumMore"))
				value.question_summore_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsName"))
				value.zsname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeId"))
				value.zstypeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeName"))
				value.zstypename_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TzsInfo Clone()
        {
            return (St_TzsInfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TzsInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TzsInfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TzsInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TzsInfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TzsInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TzsInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TzsInfo(int id1, string icon1, bool ishot1, bool isshowindex1, int question_sum1, DateTime question_sum_time1, int question_sum01, int question_sum11, int question_sum21, int question_sum31, int question_sum41, int question_sum51, int question_sum61, int question_sum71, int question_sum81, string question_summore1, int seq1, int zsid1, string zsname1, int zstypeid1, string zstypename1)
        {
            
            this.Id = id1;
            
            this.Icon = icon1;
            
            this.IsHot = ishot1;
            
            this.IsShowIndex = isshowindex1;
            
            this.Question_sum = question_sum1;
            
            this.Question_sum_time = question_sum_time1;
            
            this.Question_sum0 = question_sum01;
            
            this.Question_sum1 = question_sum11;
            
            this.Question_sum2 = question_sum21;
            
            this.Question_sum3 = question_sum31;
            
            this.Question_sum4 = question_sum41;
            
            this.Question_sum5 = question_sum51;
            
            this.Question_sum6 = question_sum61;
            
            this.Question_sum7 = question_sum71;
            
            this.Question_sum8 = question_sum81;
            
            this.Question_sumMore = question_summore1;
            
            this.Seq = seq1;
            
            this.ZsId = zsid1;
            
            this.ZsName = zsname1;
            
            this.ZsTypeId = zstypeid1;
            
            this.ZsTypeName = zstypename1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TzsInfo FromIView(IView view)
        {
            return (St_TzsInfo)IView.GetITable(view, "St_TzsInfo");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TzsInfo GetOneInstance()
        {
            St_TzsInfo value = new St_TzsInfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TzsInfo Retrieve()
        {
            BLLTable<St_TzsInfo>.GetRowData(this);
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
			    			
			    case "Icon":
			        return Icon;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "IsShowIndex":
			        return IsShowIndex;
			    			
			    case "Question_sum":
			        return Question_sum;
			    			
			    case "Question_sum_time":
			        return Question_sum_time;
			    			
			    case "Question_sum0":
			        return Question_sum0;
			    			
			    case "Question_sum1":
			        return Question_sum1;
			    			
			    case "Question_sum2":
			        return Question_sum2;
			    			
			    case "Question_sum3":
			        return Question_sum3;
			    			
			    case "Question_sum4":
			        return Question_sum4;
			    			
			    case "Question_sum5":
			        return Question_sum5;
			    			
			    case "Question_sum6":
			        return Question_sum6;
			    			
			    case "Question_sum7":
			        return Question_sum7;
			    			
			    case "Question_sum8":
			        return Question_sum8;
			    			
			    case "Question_sumMore":
			        return Question_sumMore;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "ZsId":
			        return ZsId;
			    			
			    case "ZsName":
			        return ZsName;
			    			
			    case "ZsTypeId":
			        return ZsTypeId;
			    			
			    case "ZsTypeName":
			        return ZsTypeName;
			
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
			    			
			    case "Icon":
			        this.Icon = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsShowIndex":
			        this.IsShowIndex = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Question_sum":
			        this.Question_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum_time":
			        this.Question_sum_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Question_sum0":
			        this.Question_sum0 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum1":
			        this.Question_sum1 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum2":
			        this.Question_sum2 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum3":
			        this.Question_sum3 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum4":
			        this.Question_sum4 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum5":
			        this.Question_sum5 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum6":
			        this.Question_sum6 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum7":
			        this.Question_sum7 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum8":
			        this.Question_sum8 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sumMore":
			        this.Question_sumMore = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsName":
			        this.ZsName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsTypeId":
			        this.ZsTypeId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsTypeName":
			        this.ZsTypeName = Convert.ToString(AttributeValue);
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
				
				case "Icon":
					return icon_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "IsShowIndex":
					return isshowindex_initialized;
				
				case "Question_sum":
					return question_sum_initialized;
				
				case "Question_sum_time":
					return question_sum_time_initialized;
				
				case "Question_sum0":
					return question_sum0_initialized;
				
				case "Question_sum1":
					return question_sum1_initialized;
				
				case "Question_sum2":
					return question_sum2_initialized;
				
				case "Question_sum3":
					return question_sum3_initialized;
				
				case "Question_sum4":
					return question_sum4_initialized;
				
				case "Question_sum5":
					return question_sum5_initialized;
				
				case "Question_sum6":
					return question_sum6_initialized;
				
				case "Question_sum7":
					return question_sum7_initialized;
				
				case "Question_sum8":
					return question_sum8_initialized;
				
				case "Question_sumMore":
					return question_summore_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
				case "ZsName":
					return zsname_initialized;
				
				case "ZsTypeId":
					return zstypeid_initialized;
				
				case "ZsTypeName":
					return zstypename_initialized;
				
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
				
				case "Icon":
					icon_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "IsShowIndex":
					isshowindex_initialized = ret;
					return true;
				
				case "Question_sum":
					question_sum_initialized = ret;
					return true;
				
				case "Question_sum_time":
					question_sum_time_initialized = ret;
					return true;
				
				case "Question_sum0":
					question_sum0_initialized = ret;
					return true;
				
				case "Question_sum1":
					question_sum1_initialized = ret;
					return true;
				
				case "Question_sum2":
					question_sum2_initialized = ret;
					return true;
				
				case "Question_sum3":
					question_sum3_initialized = ret;
					return true;
				
				case "Question_sum4":
					question_sum4_initialized = ret;
					return true;
				
				case "Question_sum5":
					question_sum5_initialized = ret;
					return true;
				
				case "Question_sum6":
					question_sum6_initialized = ret;
					return true;
				
				case "Question_sum7":
					question_sum7_initialized = ret;
					return true;
				
				case "Question_sum8":
					question_sum8_initialized = ret;
					return true;
				
				case "Question_sumMore":
					question_summore_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
					return true;
				
				case "ZsName":
					zsname_initialized = ret;
					return true;
				
				case "ZsTypeId":
					zstypeid_initialized = ret;
					return true;
				
				case "ZsTypeName":
					zstypename_initialized = ret;
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
                AttributeItem attr = St_TzsInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (icon_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Icon;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Icon);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (isshowindex_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.IsShowIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsShowIndex);
                }
			}
			
			if (question_sum_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum);
                }
			}
			
			if (question_sum_time_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum_time);
                }
			}
			
			if (question_sum0_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum0;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum0);
                }
			}
			
			if (question_sum1_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum1);
                }
			}
			
			if (question_sum2_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum2);
                }
			}
			
			if (question_sum3_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum3);
                }
			}
			
			if (question_sum4_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum4;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum4);
                }
			}
			
			if (question_sum5_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum5);
                }
			}
			
			if (question_sum6_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum6;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum6);
                }
			}
			
			if (question_sum7_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum7;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum7);
                }
			}
			
			if (question_sum8_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sum8;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum8);
                }
			}
			
			if (question_summore_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Question_sumMore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sumMore);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.ZsId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsId);
                }
			}
			
			if (zsname_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.ZsName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsName);
                }
			}
			
			if (zstypeid_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.ZsTypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeId);
                }
			}
			
			if (zstypename_initialized)
			{
                AttributeItem attr = St_TzsInfo.Attribute.ZsTypeName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeName);
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
        public class St_TzsInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Icon { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsShowIndex { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Question_sum_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum0 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum2 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum3 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum4 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum5 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum6 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum7 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Question_sum8 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Question_sumMore { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public int ZsId { get; set; }
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public string ZsName { get; set; }
            
            /// <summary>类型Id:[CtrlTypeDic-{InputString}]</summary>
            public int ZsTypeId { get; set; }
            
            /// <summary>类型名:[CtrlTypeDic-{InputString}]</summary>
            public string ZsTypeName { get; set; }
        }
        #endregion
    }
}