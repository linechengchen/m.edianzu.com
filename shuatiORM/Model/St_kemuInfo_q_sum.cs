/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/7 1:49:06
  Description:    数据表St_kemuInfo_q_sum对应的业务逻辑层St_kemuInfo_q_sum
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_kemuInfo_q_sum_Entity:St_kemuInfo_q_sum
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,KemuId,Question_sum,Question_sum_time,Question_sum0,Question_sum1,Question_sum2,Question_sum3,Question_sum4,Question_sum5,Question_sum6,Question_sum7,Question_sum8,Question_sumMore,Sc,School_id from St_kemuInfo_q_sum
delete from St_kemuInfo_q_sum
INSERT INTO St_kemuInfo_q_sum (Id,KemuId,Question_sum,Question_sum_time,Question_sum0,Question_sum1,Question_sum2,Question_sum3,Question_sum4,Question_sum5,Question_sum6,Question_sum7,Question_sum8,Question_sumMore,Sc,School_id)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE St_kemuInfo_q_sum SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.KemuId = valObj2.KemuId;
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
        valObj.Sc = valObj2.Sc;
        valObj.School_id = valObj2.School_id; 
        valObj.Id = "";
        valObj.KemuId = "";
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
        valObj.Sc = "";
        valObj.School_id = ""; 
        "Id": $("#txt_Id").val(),
        "KemuId": $("#txt_KemuId").val(),
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
        "Sc": $("#txt_Sc").val(),
        "School_id": $("#txt_School_id").val(), 
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
    /// <para>科目题目统计（按大学划分）</para>
    /// <para>与St_kemuInfo_q_sum数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_kemuInfo_q_sum : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_kemuInfo_q_sum Factory()
        {
            return new St_kemuInfo_q_sum();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动Id:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
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
        
        /// <summary> 源（学校）:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_kemuInfo_q_sum].[Id]", typeof(int), 4, default(int));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_kemuInfo_q_sum].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Question_sum_time =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum0 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum0]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum1 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum1]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum2 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum2]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum3 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum3]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum4 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum4]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum5 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum5]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum6 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum6]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum7 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum7]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sum8 =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sum8]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question_sumMore =  new AttributeItem("[St_kemuInfo_q_sum].[Question_sumMore]", typeof(string), 200, default(string));
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[St_kemuInfo_q_sum].[Sc]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[St_kemuInfo_q_sum].[School_id]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
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
        
        private int m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_kemuInfo_q_sum";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.question_sum_initialized = IsLoadAllAttributes;this.question_sum_time_initialized = IsLoadAllAttributes;this.question_sum0_initialized = IsLoadAllAttributes;this.question_sum1_initialized = IsLoadAllAttributes;this.question_sum2_initialized = IsLoadAllAttributes;this.question_sum3_initialized = IsLoadAllAttributes;this.question_sum4_initialized = IsLoadAllAttributes;this.question_sum5_initialized = IsLoadAllAttributes;this.question_sum6_initialized = IsLoadAllAttributes;this.question_sum7_initialized = IsLoadAllAttributes;this.question_sum8_initialized = IsLoadAllAttributes;this.question_summore_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_kemuInfo_q_sum value = new St_kemuInfo_q_sum();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
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
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_kemuInfo_q_sum Clone()
        {
            return (St_kemuInfo_q_sum)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_kemuInfo_q_sum()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_kemuInfo_q_sum() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_kemuInfo_q_sum(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_kemuInfo_q_sum(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_kemuInfo_q_sum(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_kemuInfo_q_sum(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_kemuInfo_q_sum(int id1, int kemuid1, int question_sum1, DateTime question_sum_time1, int question_sum01, int question_sum11, int question_sum21, int question_sum31, int question_sum41, int question_sum51, int question_sum61, int question_sum71, int question_sum81, string question_summore1, int sc1, string school_id1)
        {
            
            this.Id = id1;
            
            this.KemuId = kemuid1;
            
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
            
            this.Sc = sc1;
            
            this.School_id = school_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_kemuInfo_q_sum FromIView(IView view)
        {
            return (St_kemuInfo_q_sum)IView.GetITable(view, "St_kemuInfo_q_sum");
        }
        /// <summary>获得一个实例  </summary>
        public static St_kemuInfo_q_sum GetOneInstance()
        {
            St_kemuInfo_q_sum value = new St_kemuInfo_q_sum();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_kemuInfo_q_sum Retrieve()
        {
            BLLTable<St_kemuInfo_q_sum>.GetRowData(this);
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
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "School_id":
			        return School_id;
			
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
			    			
			    case "Sc":
			        this.Sc = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToString(AttributeValue);
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
				
				case "Sc":
					return sc_initialized;
				
				case "School_id":
					return school_id_initialized;
				
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
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
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
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (question_sum_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum);
                }
			}
			
			if (question_sum_time_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum_time);
                }
			}
			
			if (question_sum0_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum0;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum0);
                }
			}
			
			if (question_sum1_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum1);
                }
			}
			
			if (question_sum2_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum2);
                }
			}
			
			if (question_sum3_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum3);
                }
			}
			
			if (question_sum4_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum4;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum4);
                }
			}
			
			if (question_sum5_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum5);
                }
			}
			
			if (question_sum6_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum6;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum6);
                }
			}
			
			if (question_sum7_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum7;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum7);
                }
			}
			
			if (question_sum8_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sum8;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sum8);
                }
			}
			
			if (question_summore_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Question_sumMore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question_sumMore);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = St_kemuInfo_q_sum.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
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
        public class St_kemuInfo_q_sumJson
        {
            
            /// <summary>自动Id:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
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
            
            /// <summary>源（学校）:[CtrlTypeDic-{InputString}]</summary>
            public int Sc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string School_id { get; set; }
        }
        #endregion
    }
}