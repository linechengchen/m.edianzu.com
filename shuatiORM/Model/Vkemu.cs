/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:59
  Description:    数据表Vkemu对应的业务逻辑层Vkemu
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Vkemu_Entity:Vkemu
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,KemuId,KemuName,PId,ZsId,IsShowIndex,Icon,Sc,ScType,KemuType,ShortKemuName,TimuSum,Question_sum,Question_sumMore,CreateTime,Sc1,Sc2,Sc3,Seq,IsHot,ZsName,ZsTypeName,ZsTypeId from Vkemu
delete from Vkemu
INSERT INTO Vkemu (Id,KemuId,KemuName,PId,ZsId,IsShowIndex,Icon,Sc,ScType,KemuType,ShortKemuName,TimuSum,Question_sum,Question_sumMore,CreateTime,Sc1,Sc2,Sc3,Seq,IsHot,ZsName,ZsTypeName,ZsTypeId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Vkemu SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.KemuId = valObj2.KemuId;
        valObj.KemuName = valObj2.KemuName;
        valObj.PId = valObj2.PId;
        valObj.ZsId = valObj2.ZsId;
        valObj.IsShowIndex = valObj2.IsShowIndex;
        valObj.Icon = valObj2.Icon;
        valObj.Sc = valObj2.Sc;
        valObj.ScType = valObj2.ScType;
        valObj.KemuType = valObj2.KemuType;
        valObj.ShortKemuName = valObj2.ShortKemuName;
        valObj.TimuSum = valObj2.TimuSum;
        valObj.Question_sum = valObj2.Question_sum;
        valObj.Question_sumMore = valObj2.Question_sumMore;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Sc1 = valObj2.Sc1;
        valObj.Sc2 = valObj2.Sc2;
        valObj.Sc3 = valObj2.Sc3;
        valObj.Seq = valObj2.Seq;
        valObj.IsHot = valObj2.IsHot;
        valObj.ZsName = valObj2.ZsName;
        valObj.ZsTypeName = valObj2.ZsTypeName;
        valObj.ZsTypeId = valObj2.ZsTypeId; 
        valObj.Id = "";
        valObj.KemuId = "";
        valObj.KemuName = "";
        valObj.PId = "";
        valObj.ZsId = "";
        valObj.IsShowIndex = "";
        valObj.Icon = "";
        valObj.Sc = "";
        valObj.ScType = "";
        valObj.KemuType = "";
        valObj.ShortKemuName = "";
        valObj.TimuSum = "";
        valObj.Question_sum = "";
        valObj.Question_sumMore = "";
        valObj.CreateTime = "";
        valObj.Sc1 = "";
        valObj.Sc2 = "";
        valObj.Sc3 = "";
        valObj.Seq = "";
        valObj.IsHot = "";
        valObj.ZsName = "";
        valObj.ZsTypeName = "";
        valObj.ZsTypeId = ""; 
        "Id": $("#txt_Id").val(),
        "KemuId": $("#txt_KemuId").val(),
        "KemuName": $("#txt_KemuName").val(),
        "PId": $("#txt_PId").val(),
        "ZsId": $("#txt_ZsId").val(),
        "IsShowIndex": $("#txt_IsShowIndex").val(),
        "Icon": $("#txt_Icon").val(),
        "Sc": $("#txt_Sc").val(),
        "ScType": $("#txt_ScType").val(),
        "KemuType": $("#txt_KemuType").val(),
        "ShortKemuName": $("#txt_ShortKemuName").val(),
        "TimuSum": $("#txt_TimuSum").val(),
        "Question_sum": $("#txt_Question_sum").val(),
        "Question_sumMore": $("#txt_Question_sumMore").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Sc1": $("#txt_Sc1").val(),
        "Sc2": $("#txt_Sc2").val(),
        "Sc3": $("#txt_Sc3").val(),
        "Seq": $("#txt_Seq").val(),
        "IsHot": $("#txt_IsHot").val(),
        "ZsName": $("#txt_ZsName").val(),
        "ZsTypeName": $("#txt_ZsTypeName").val(),
        "ZsTypeId": $("#txt_ZsTypeId").val(), 
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
    /// <para>科目表(证书下面分科目)__证书表:[Inner-{St_kemuInfo:0},{St_TzsInfo:1}]</para>
    /// <para>与Vkemu数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Vkemu : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Vkemu Factory()
        {
            return new Vkemu();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 科目名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuName
        {            
            get { return this.KemuName; }
            set { this.KemuName = value; }
        }
        
        /// <summary> 父科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PId
        {            
            get { return this.PId; }
            set { this.PId = value; }
        }
        
        /// <summary> 证书Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _IsShowIndex
        {            
            get { return this.IsShowIndex; }
            set { this.IsShowIndex = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Icon
        {            
            get { return this.Icon; }
            set { this.Icon = value; }
        }
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _ScType
        {            
            get { return this.ScType; }
            set { this.ScType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _KemuType
        {            
            get { return this.KemuType; }
            set { this.KemuType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _ShortKemuName
        {            
            get { return this.ShortKemuName; }
            set { this.ShortKemuName = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _TimuSum
        {            
            get { return this.TimuSum; }
            set { this.TimuSum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Question_sum
        {            
            get { return this.Question_sum; }
            set { this.Question_sum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Question_sumMore
        {            
            get { return this.Question_sumMore; }
            set { this.Question_sumMore = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Sc1
        {            
            get { return this.Sc1; }
            set { this.Sc1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Sc2
        {            
            get { return this.Sc2; }
            set { this.Sc2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Sc3
        {            
            get { return this.Sc3; }
            set { this.Sc3 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> 证书名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsName
        {            
            get { return this.ZsName; }
            set { this.ZsName = value; }
        }
        
        /// <summary> 类型名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsTypeName
        {            
            get { return this.ZsTypeName; }
            set { this.ZsTypeName = value; }
        }
        
        /// <summary> 类型Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsTypeId
        {            
            get { return this.ZsTypeId; }
            set { this.ZsTypeId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> 科目名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KemuName
        {
            get { return this.m_kemuname; }
            set //
            {
                if (!kemuname_initialized || m_kemuname != value)
                {
                    this.m_kemuname = value;
                }
                kemuname_initialized = true;
            }
        }
        
        /// <summary> 父科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int PId
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string ScType
        {
            get { return this.m_sctype; }
            set //
            {
                if (!sctype_initialized || m_sctype != value)
                {
                    this.m_sctype = value;
                }
                sctype_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int KemuType
        {
            get { return this.m_kemutype; }
            set //
            {
                if (!kemutype_initialized || m_kemutype != value)
                {
                    this.m_kemutype = value;
                }
                kemutype_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string ShortKemuName
        {
            get { return this.m_shortkemuname; }
            set //
            {
                if (!shortkemuname_initialized || m_shortkemuname != value)
                {
                    this.m_shortkemuname = value;
                }
                shortkemuname_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int TimuSum
        {
            get { return this.m_timusum; }
            set //
            {
                if (!timusum_initialized || m_timusum != value)
                {
                    this.m_timusum = value;
                }
                timusum_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Question_sum
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Sc1
        {
            get { return this.m_sc1; }
            set //
            {
                if (!sc1_initialized || m_sc1 != value)
                {
                    this.m_sc1 = value;
                }
                sc1_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Sc2
        {
            get { return this.m_sc2; }
            set //
            {
                if (!sc2_initialized || m_sc2 != value)
                {
                    this.m_sc2 = value;
                }
                sc2_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Sc3
        {
            get { return this.m_sc3; }
            set //
            {
                if (!sc3_initialized || m_sc3 != value)
                {
                    this.m_sc3 = value;
                }
                sc3_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Vkemu].[Id]", typeof(int), 4, default(int));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[Vkemu].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>科目名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuName =  new AttributeItem("[Vkemu].[KemuName]", typeof(string), 50, default(string));
            
            /// <summary>父科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PId =  new AttributeItem("[Vkemu].[PId]", typeof(int), 4, default(int));
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[Vkemu].[ZsId]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem IsShowIndex =  new AttributeItem("[Vkemu].[IsShowIndex]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Icon =  new AttributeItem("[Vkemu].[Icon]", typeof(string), 50, default(string));
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[Vkemu].[Sc]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ScType =  new AttributeItem("[Vkemu].[ScType]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem KemuType =  new AttributeItem("[Vkemu].[KemuType]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ShortKemuName =  new AttributeItem("[Vkemu].[ShortKemuName]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem TimuSum =  new AttributeItem("[Vkemu].[TimuSum]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Question_sum =  new AttributeItem("[Vkemu].[Question_sum]", typeof(string), 20, default(string));
            
            /// <summary></summary>
            public static AttributeItem Question_sumMore =  new AttributeItem("[Vkemu].[Question_sumMore]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Vkemu].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Sc1 =  new AttributeItem("[Vkemu].[Sc1]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Sc2 =  new AttributeItem("[Vkemu].[Sc2]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Sc3 =  new AttributeItem("[Vkemu].[Sc3]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Seq =  new AttributeItem("[Vkemu].[Seq]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem IsHot =  new AttributeItem("[Vkemu].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsName =  new AttributeItem("[Vkemu].[ZsName]", typeof(string), 50, default(string));
            
            /// <summary>类型名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeName =  new AttributeItem("[Vkemu].[ZsTypeName]", typeof(string), 50, default(string));
            
            /// <summary>类型Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeId =  new AttributeItem("[Vkemu].[ZsTypeId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_kemuname;
        /// <summary></summary>
        protected bool kemuname_initialized = false;
        
        private int m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private int m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        
        private bool m_isshowindex;
        /// <summary></summary>
        protected bool isshowindex_initialized = false;
        
        private string m_icon;
        /// <summary></summary>
        protected bool icon_initialized = false;
        
        private int m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_sctype;
        /// <summary></summary>
        protected bool sctype_initialized = false;
        
        private int m_kemutype;
        /// <summary></summary>
        protected bool kemutype_initialized = false;
        
        private string m_shortkemuname;
        /// <summary></summary>
        protected bool shortkemuname_initialized = false;
        
        private int m_timusum;
        /// <summary></summary>
        protected bool timusum_initialized = false;
        
        private string m_question_sum;
        /// <summary></summary>
        protected bool question_sum_initialized = false;
        
        private string m_question_summore;
        /// <summary></summary>
        protected bool question_summore_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_sc1;
        /// <summary></summary>
        protected bool sc1_initialized = false;
        
        private string m_sc2;
        /// <summary></summary>
        protected bool sc2_initialized = false;
        
        private string m_sc3;
        /// <summary></summary>
        protected bool sc3_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private string m_zsname;
        /// <summary></summary>
        protected bool zsname_initialized = false;
        
        private string m_zstypename;
        /// <summary></summary>
        protected bool zstypename_initialized = false;
        
        private int m_zstypeid;
        /// <summary></summary>
        protected bool zstypeid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Vkemu";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.kemuname_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;this.isshowindex_initialized = IsLoadAllAttributes;this.icon_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.sctype_initialized = IsLoadAllAttributes;this.kemutype_initialized = IsLoadAllAttributes;this.shortkemuname_initialized = IsLoadAllAttributes;this.timusum_initialized = IsLoadAllAttributes;this.question_sum_initialized = IsLoadAllAttributes;this.question_summore_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.sc1_initialized = IsLoadAllAttributes;this.sc2_initialized = IsLoadAllAttributes;this.sc3_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.zsname_initialized = IsLoadAllAttributes;this.zstypename_initialized = IsLoadAllAttributes;this.zstypeid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Vkemu value = new Vkemu();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuName"))
				value.kemuname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PId"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsShowIndex"))
				value.isshowindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Icon"))
				value.icon_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ScType"))
				value.sctype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuType"))
				value.kemutype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShortKemuName"))
				value.shortkemuname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimuSum"))
				value.timusum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sum"))
				value.question_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question_sumMore"))
				value.question_summore_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc1"))
				value.sc1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc2"))
				value.sc2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc3"))
				value.sc3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsName"))
				value.zsname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeName"))
				value.zstypename_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeId"))
				value.zstypeid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Vkemu Clone()
        {
            return (Vkemu)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Vkemu()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Vkemu() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Vkemu(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Vkemu(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Vkemu(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Vkemu(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Vkemu(int id1, int kemuid1, string kemuname1, int pid1, int zsid1, bool isshowindex1, string icon1, int sc1, string sctype1, int kemutype1, string shortkemuname1, int timusum1, string question_sum1, string question_summore1, DateTime createtime1, string sc11, string sc21, string sc31, int seq1, bool ishot1, string zsname1, string zstypename1, int zstypeid1)
        {
            
            this.Id = id1;
            
            this.KemuId = kemuid1;
            
            this.KemuName = kemuname1;
            
            this.PId = pid1;
            
            this.ZsId = zsid1;
            
            this.IsShowIndex = isshowindex1;
            
            this.Icon = icon1;
            
            this.Sc = sc1;
            
            this.ScType = sctype1;
            
            this.KemuType = kemutype1;
            
            this.ShortKemuName = shortkemuname1;
            
            this.TimuSum = timusum1;
            
            this.Question_sum = question_sum1;
            
            this.Question_sumMore = question_summore1;
            
            this.CreateTime = createtime1;
            
            this.Sc1 = sc11;
            
            this.Sc2 = sc21;
            
            this.Sc3 = sc31;
            
            this.Seq = seq1;
            
            this.IsHot = ishot1;
            
            this.ZsName = zsname1;
            
            this.ZsTypeName = zstypename1;
            
            this.ZsTypeId = zstypeid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Vkemu FromIView(IView view)
        {
            return (Vkemu)IView.GetITable(view, "Vkemu");
        }
        /// <summary>获得一个实例  </summary>
        public static Vkemu GetOneInstance()
        {
            Vkemu value = new Vkemu();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Vkemu Retrieve()
        {
            BLLTable<Vkemu>.GetRowData(this);
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
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "KemuName":
			        return KemuName;
			    			
			    case "PId":
			        return PId;
			    			
			    case "ZsId":
			        return ZsId;
			    			
			    case "IsShowIndex":
			        return IsShowIndex;
			    			
			    case "Icon":
			        return Icon;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "ScType":
			        return ScType;
			    			
			    case "KemuType":
			        return KemuType;
			    			
			    case "ShortKemuName":
			        return ShortKemuName;
			    			
			    case "TimuSum":
			        return TimuSum;
			    			
			    case "Question_sum":
			        return Question_sum;
			    			
			    case "Question_sumMore":
			        return Question_sumMore;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Sc1":
			        return Sc1;
			    			
			    case "Sc2":
			        return Sc2;
			    			
			    case "Sc3":
			        return Sc3;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "ZsName":
			        return ZsName;
			    			
			    case "ZsTypeName":
			        return ZsTypeName;
			    			
			    case "ZsTypeId":
			        return ZsTypeId;
			
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
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "KemuName":
			        this.KemuName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PId":
			        this.PId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IsShowIndex":
			        this.IsShowIndex = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Icon":
			        this.Icon = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ScType":
			        this.ScType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuType":
			        this.KemuType = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ShortKemuName":
			        this.ShortKemuName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimuSum":
			        this.TimuSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Question_sum":
			        this.Question_sum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question_sumMore":
			        this.Question_sumMore = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Sc1":
			        this.Sc1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc2":
			        this.Sc2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc3":
			        this.Sc3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ZsName":
			        this.ZsName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsTypeName":
			        this.ZsTypeName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsTypeId":
			        this.ZsTypeId = Convert.ToInt32(AttributeValue);
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
				
				case "KemuId":
					return kemuid_initialized;
				
				case "KemuName":
					return kemuname_initialized;
				
				case "PId":
					return pid_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
				case "IsShowIndex":
					return isshowindex_initialized;
				
				case "Icon":
					return icon_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "ScType":
					return sctype_initialized;
				
				case "KemuType":
					return kemutype_initialized;
				
				case "ShortKemuName":
					return shortkemuname_initialized;
				
				case "TimuSum":
					return timusum_initialized;
				
				case "Question_sum":
					return question_sum_initialized;
				
				case "Question_sumMore":
					return question_summore_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Sc1":
					return sc1_initialized;
				
				case "Sc2":
					return sc2_initialized;
				
				case "Sc3":
					return sc3_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "ZsName":
					return zsname_initialized;
				
				case "ZsTypeName":
					return zstypename_initialized;
				
				case "ZsTypeId":
					return zstypeid_initialized;
				
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
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "KemuName":
					kemuname_initialized = ret;
					return true;
				
				case "PId":
					pid_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
					return true;
				
				case "IsShowIndex":
					isshowindex_initialized = ret;
					return true;
				
				case "Icon":
					icon_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "ScType":
					sctype_initialized = ret;
					return true;
				
				case "KemuType":
					kemutype_initialized = ret;
					return true;
				
				case "ShortKemuName":
					shortkemuname_initialized = ret;
					return true;
				
				case "TimuSum":
					timusum_initialized = ret;
					return true;
				
				case "Question_sum":
					question_sum_initialized = ret;
					return true;
				
				case "Question_sumMore":
					question_summore_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Sc1":
					sc1_initialized = ret;
					return true;
				
				case "Sc2":
					sc2_initialized = ret;
					return true;
				
				case "Sc3":
					sc3_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "ZsName":
					zsname_initialized = ret;
					return true;
				
				case "ZsTypeName":
					zstypename_initialized = ret;
					return true;
				
				case "ZsTypeId":
					zstypeid_initialized = ret;
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
                AttributeItem attr = Vkemu.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (kemuname_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.KemuName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuName);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.PId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PId);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ZsId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsId);
                }
			}
			
			if (isshowindex_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.IsShowIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsShowIndex);
                }
			}
			
			if (icon_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Icon;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Icon);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (sctype_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ScType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ScType);
                }
			}
			
			if (kemutype_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.KemuType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuType);
                }
			}
			
			if (shortkemuname_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ShortKemuName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShortKemuName);
                }
			}
			
			if (timusum_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.TimuSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimuSum);
                }
			}
			
			if (question_sum_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Question_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum);
                }
			}
			
			if (question_summore_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Question_sumMore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sumMore);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (sc1_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Sc1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc1);
                }
			}
			
			if (sc2_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Sc2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc2);
                }
			}
			
			if (sc3_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Sc3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc3);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (zsname_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ZsName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsName);
                }
			}
			
			if (zstypename_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ZsTypeName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeName);
                }
			}
			
			if (zstypeid_initialized)
			{
                AttributeItem attr = Vkemu.Attribute.ZsTypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeId);
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
        public class VkemuJson
        {
            
            /// <summary>自动Id:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
            /// <summary>科目名:[CtrlTypeDic-{InputString}]</summary>
            public string KemuName { get; set; }
            
            /// <summary>父科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int PId { get; set; }
            
            /// <summary>证书Id:[CtrlTypeDic-{InputString}]</summary>
            public int ZsId { get; set; }
            
            /// <summary></summary>
            public bool IsShowIndex { get; set; }
            
            /// <summary></summary>
            public string Icon { get; set; }
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public int Sc { get; set; }
            
            /// <summary></summary>
            public string ScType { get; set; }
            
            /// <summary></summary>
            public int KemuType { get; set; }
            
            /// <summary></summary>
            public string ShortKemuName { get; set; }
            
            /// <summary></summary>
            public int TimuSum { get; set; }
            
            /// <summary></summary>
            public string Question_sum { get; set; }
            
            /// <summary></summary>
            public string Question_sumMore { get; set; }
            
            /// <summary></summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary></summary>
            public string Sc1 { get; set; }
            
            /// <summary></summary>
            public string Sc2 { get; set; }
            
            /// <summary></summary>
            public string Sc3 { get; set; }
            
            /// <summary></summary>
            public int Seq { get; set; }
            
            /// <summary></summary>
            public bool IsHot { get; set; }
            
            /// <summary>证书名:[CtrlTypeDic-{InputString}]</summary>
            public string ZsName { get; set; }
            
            /// <summary>类型名:[CtrlTypeDic-{InputString}]</summary>
            public string ZsTypeName { get; set; }
            
            /// <summary>类型Id:[CtrlTypeDic-{InputString}]</summary>
            public int ZsTypeId { get; set; }
        }
        #endregion
    }
}