/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/6 1:00:03
  Description:    数据表Xb_renwu对应的业务逻辑层Xb_renwu
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_renwu_Entity:Xb_renwu
 * 
************************************************************/
/************************************************************
SQL代码：
select ApplyCount,AuthenticateStatus,Email,EvaluationStar,Fudaokemu,Gaokao,Getjiang,HasAuthenticate,HeadImg,Id,Introduction,Jiage,Jiajiaoqixian,Jiaoxuequyu,Mobile,Name,Nianji,Path,Qinkuang,Sex,Tags,Time,UserFreeTimeMatchIds,Yaoqiu from Xb_renwu
delete from Xb_renwu
INSERT INTO Xb_renwu (ApplyCount,AuthenticateStatus,Email,EvaluationStar,Fudaokemu,Gaokao,Getjiang,HasAuthenticate,HeadImg,Id,Introduction,Jiage,Jiajiaoqixian,Jiaoxuequyu,Mobile,Name,Nianji,Path,Qinkuang,Sex,Tags,Time,UserFreeTimeMatchIds,Yaoqiu)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_renwu SET ...
变量赋值代码：
 *         valObj.ApplyCount = valObj2.ApplyCount;
        valObj.AuthenticateStatus = valObj2.AuthenticateStatus;
        valObj.Email = valObj2.Email;
        valObj.EvaluationStar = valObj2.EvaluationStar;
        valObj.Fudaokemu = valObj2.Fudaokemu;
        valObj.Gaokao = valObj2.Gaokao;
        valObj.Getjiang = valObj2.Getjiang;
        valObj.HasAuthenticate = valObj2.HasAuthenticate;
        valObj.HeadImg = valObj2.HeadImg;
        valObj.Id = valObj2.Id;
        valObj.Introduction = valObj2.Introduction;
        valObj.Jiage = valObj2.Jiage;
        valObj.Jiajiaoqixian = valObj2.Jiajiaoqixian;
        valObj.Jiaoxuequyu = valObj2.Jiaoxuequyu;
        valObj.Mobile = valObj2.Mobile;
        valObj.Name = valObj2.Name;
        valObj.Nianji = valObj2.Nianji;
        valObj.Path = valObj2.Path;
        valObj.Qinkuang = valObj2.Qinkuang;
        valObj.Sex = valObj2.Sex;
        valObj.Tags = valObj2.Tags;
        valObj.Time = valObj2.Time;
        valObj.UserFreeTimeMatchIds = valObj2.UserFreeTimeMatchIds;
        valObj.Yaoqiu = valObj2.Yaoqiu; 
        valObj.ApplyCount = "";
        valObj.AuthenticateStatus = "";
        valObj.Email = "";
        valObj.EvaluationStar = "";
        valObj.Fudaokemu = "";
        valObj.Gaokao = "";
        valObj.Getjiang = "";
        valObj.HasAuthenticate = "";
        valObj.HeadImg = "";
        valObj.Id = "";
        valObj.Introduction = "";
        valObj.Jiage = "";
        valObj.Jiajiaoqixian = "";
        valObj.Jiaoxuequyu = "";
        valObj.Mobile = "";
        valObj.Name = "";
        valObj.Nianji = "";
        valObj.Path = "";
        valObj.Qinkuang = "";
        valObj.Sex = "";
        valObj.Tags = "";
        valObj.Time = "";
        valObj.UserFreeTimeMatchIds = "";
        valObj.Yaoqiu = ""; 
        "ApplyCount": $("#txt_ApplyCount").val(),
        "AuthenticateStatus": $("#txt_AuthenticateStatus").val(),
        "Email": $("#txt_Email").val(),
        "EvaluationStar": $("#txt_EvaluationStar").val(),
        "Fudaokemu": $("#txt_Fudaokemu").val(),
        "Gaokao": $("#txt_Gaokao").val(),
        "Getjiang": $("#txt_Getjiang").val(),
        "HasAuthenticate": $("#txt_HasAuthenticate").val(),
        "HeadImg": $("#txt_HeadImg").val(),
        "Id": $("#txt_Id").val(),
        "Introduction": $("#txt_Introduction").val(),
        "Jiage": $("#txt_Jiage").val(),
        "Jiajiaoqixian": $("#txt_Jiajiaoqixian").val(),
        "Jiaoxuequyu": $("#txt_Jiaoxuequyu").val(),
        "Mobile": $("#txt_Mobile").val(),
        "Name": $("#txt_Name").val(),
        "Nianji": $("#txt_Nianji").val(),
        "Path": $("#txt_Path").val(),
        "Qinkuang": $("#txt_Qinkuang").val(),
        "Sex": $("#txt_Sex").val(),
        "Tags": $("#txt_Tags").val(),
        "Time": $("#txt_Time").val(),
        "UserFreeTimeMatchIds": $("#txt_UserFreeTimeMatchIds").val(),
        "Yaoqiu": $("#txt_Yaoqiu").val(), 
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
    /// <para>任务</para>
    /// <para>与Xb_renwu数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_renwu : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_renwu Factory()
        {
            return new Xb_renwu();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 兼职次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ApplyCount
        {            
            get { return this.ApplyCount; }
            set { this.ApplyCount = value; }
        }
        
        /// <summary> 身份认证状态:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AuthenticateStatus
        {            
            get { return this.AuthenticateStatus; }
            set { this.AuthenticateStatus = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> 兼职评分:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _EvaluationStar
        {            
            get { return this.EvaluationStar; }
            set { this.EvaluationStar = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Fudaokemu
        {            
            get { return this.Fudaokemu; }
            set { this.Fudaokemu = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Gaokao
        {            
            get { return this.Gaokao; }
            set { this.Gaokao = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Getjiang
        {            
            get { return this.Getjiang; }
            set { this.Getjiang = value; }
        }
        
        /// <summary> 身份认证成功？:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _HasAuthenticate
        {            
            get { return this.HasAuthenticate; }
            set { this.HasAuthenticate = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _HeadImg
        {            
            get { return this.HeadImg; }
            set { this.HeadImg = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Introduction
        {            
            get { return this.Introduction; }
            set { this.Introduction = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Jiage
        {            
            get { return this.Jiage; }
            set { this.Jiage = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Jiajiaoqixian
        {            
            get { return this.Jiajiaoqixian; }
            set { this.Jiajiaoqixian = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Jiaoxuequyu
        {            
            get { return this.Jiaoxuequyu; }
            set { this.Jiaoxuequyu = value; }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Mobile
        {            
            get { return this.Mobile; }
            set { this.Mobile = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Nianji
        {            
            get { return this.Nianji; }
            set { this.Nianji = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Qinkuang
        {            
            get { return this.Qinkuang; }
            set { this.Qinkuang = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Tags
        {            
            get { return this.Tags; }
            set { this.Tags = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Time
        {            
            get { return this.Time; }
            set { this.Time = value; }
        }
        
        /// <summary> 空闲时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserFreeTimeMatchIds
        {            
            get { return this.UserFreeTimeMatchIds; }
            set { this.UserFreeTimeMatchIds = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Yaoqiu
        {            
            get { return this.Yaoqiu; }
            set { this.Yaoqiu = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 兼职次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int ApplyCount
        {
            get { return this.m_applycount; }
            set //
            {
                if (!applycount_initialized || m_applycount != value)
                {
                    this.m_applycount = value;
                }
                applycount_initialized = true;
            }
        }
        
        /// <summary> 身份认证状态:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AuthenticateStatus
        {
            get { return this.m_authenticatestatus; }
            set //
            {
                if (!authenticatestatus_initialized || m_authenticatestatus != value)
                {
                    this.m_authenticatestatus = value;
                }
                authenticatestatus_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string Email
        {
            get { return this.m_email; }
            set //
            {
                if (!email_initialized || m_email != value)
                {
                    this.m_email = value;
                }
                email_initialized = true;
            }
        }
        
        /// <summary> 兼职评分:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal EvaluationStar
        {
            get { return this.m_evaluationstar; }
            set //
            {
                if (!evaluationstar_initialized || m_evaluationstar != value)
                {
                    this.m_evaluationstar = value;
                }
                evaluationstar_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Fudaokemu
        {
            get { return this.m_fudaokemu; }
            set //
            {
                if (!fudaokemu_initialized || m_fudaokemu != value)
                {
                    this.m_fudaokemu = value;
                }
                fudaokemu_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Gaokao
        {
            get { return this.m_gaokao; }
            set //
            {
                if (!gaokao_initialized || m_gaokao != value)
                {
                    this.m_gaokao = value;
                }
                gaokao_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Getjiang
        {
            get { return this.m_getjiang; }
            set //
            {
                if (!getjiang_initialized || m_getjiang != value)
                {
                    this.m_getjiang = value;
                }
                getjiang_initialized = true;
            }
        }
        
        /// <summary> 身份认证成功？:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool HasAuthenticate
        {
            get { return this.m_hasauthenticate; }
            set //
            {
                if (!hasauthenticate_initialized || m_hasauthenticate != value)
                {
                    this.m_hasauthenticate = value;
                }
                hasauthenticate_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string HeadImg
        {
            get { return this.m_headimg; }
            set //
            {
                if (!headimg_initialized || m_headimg != value)
                {
                    this.m_headimg = value;
                }
                headimg_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string Introduction
        {
            get { return this.m_introduction; }
            set //
            {
                if (!introduction_initialized || m_introduction != value)
                {
                    this.m_introduction = value;
                }
                introduction_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Jiage
        {
            get { return this.m_jiage; }
            set //
            {
                if (!jiage_initialized || m_jiage != value)
                {
                    this.m_jiage = value;
                }
                jiage_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Jiajiaoqixian
        {
            get { return this.m_jiajiaoqixian; }
            set //
            {
                if (!jiajiaoqixian_initialized || m_jiajiaoqixian != value)
                {
                    this.m_jiajiaoqixian = value;
                }
                jiajiaoqixian_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Jiaoxuequyu
        {
            get { return this.m_jiaoxuequyu; }
            set //
            {
                if (!jiaoxuequyu_initialized || m_jiaoxuequyu != value)
                {
                    this.m_jiaoxuequyu = value;
                }
                jiaoxuequyu_initialized = true;
            }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Mobile
        {
            get { return this.m_mobile; }
            set //
            {
                if (!mobile_initialized || m_mobile != value)
                {
                    this.m_mobile = value;
                }
                mobile_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        public string Nianji
        {
            get { return this.m_nianji; }
            set //
            {
                if (!nianji_initialized || m_nianji != value)
                {
                    this.m_nianji = value;
                }
                nianji_initialized = true;
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
        public string Qinkuang
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Tags
        {
            get { return this.m_tags; }
            set //
            {
                if (!tags_initialized || m_tags != value)
                {
                    this.m_tags = value;
                }
                tags_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Time
        {
            get { return this.m_time; }
            set //
            {
                if (!time_initialized || m_time != value)
                {
                    this.m_time = value;
                }
                time_initialized = true;
            }
        }
        
        /// <summary> 空闲时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string UserFreeTimeMatchIds
        {
            get { return this.m_userfreetimematchids; }
            set //
            {
                if (!userfreetimematchids_initialized || m_userfreetimematchids != value)
                {
                    this.m_userfreetimematchids = value;
                }
                userfreetimematchids_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Yaoqiu
        {
            get { return this.m_yaoqiu; }
            set //
            {
                if (!yaoqiu_initialized || m_yaoqiu != value)
                {
                    this.m_yaoqiu = value;
                }
                yaoqiu_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>兼职次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ApplyCount =  new AttributeItem("[Xb_renwu].[ApplyCount]", typeof(int), 4, default(int));
            
            /// <summary>身份认证状态:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AuthenticateStatus =  new AttributeItem("[Xb_renwu].[AuthenticateStatus]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Email =  new AttributeItem("[Xb_renwu].[Email]", typeof(string), 50, default(string));
            
            /// <summary>兼职评分:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EvaluationStar =  new AttributeItem("[Xb_renwu].[EvaluationStar]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Fudaokemu =  new AttributeItem("[Xb_renwu].[Fudaokemu]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Gaokao =  new AttributeItem("[Xb_renwu].[Gaokao]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Getjiang =  new AttributeItem("[Xb_renwu].[Getjiang]", typeof(string), 200, default(string));
            
            /// <summary>身份认证成功？:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem HasAuthenticate =  new AttributeItem("[Xb_renwu].[HasAuthenticate]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem HeadImg =  new AttributeItem("[Xb_renwu].[HeadImg]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_renwu].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Introduction =  new AttributeItem("[Xb_renwu].[Introduction]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Jiage =  new AttributeItem("[Xb_renwu].[Jiage]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Jiajiaoqixian =  new AttributeItem("[Xb_renwu].[Jiajiaoqixian]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Jiaoxuequyu =  new AttributeItem("[Xb_renwu].[Jiaoxuequyu]", typeof(string), 200, default(string));
            
            /// <summary>手机号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mobile =  new AttributeItem("[Xb_renwu].[Mobile]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_renwu].[Name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Nianji =  new AttributeItem("[Xb_renwu].[Nianji]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xb_renwu].[Path]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qinkuang =  new AttributeItem("[Xb_renwu].[Qinkuang]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_renwu].[Sex]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tags =  new AttributeItem("[Xb_renwu].[Tags]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Time =  new AttributeItem("[Xb_renwu].[Time]", typeof(string), 200, default(string));
            
            /// <summary>空闲时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserFreeTimeMatchIds =  new AttributeItem("[Xb_renwu].[UserFreeTimeMatchIds]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Yaoqiu =  new AttributeItem("[Xb_renwu].[Yaoqiu]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_applycount;
        /// <summary></summary>
        protected bool applycount_initialized = false;
        
        private string m_authenticatestatus;
        /// <summary></summary>
        protected bool authenticatestatus_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private decimal m_evaluationstar;
        /// <summary></summary>
        protected bool evaluationstar_initialized = false;
        
        private string m_fudaokemu;
        /// <summary></summary>
        protected bool fudaokemu_initialized = false;
        
        private string m_gaokao;
        /// <summary></summary>
        protected bool gaokao_initialized = false;
        
        private string m_getjiang;
        /// <summary></summary>
        protected bool getjiang_initialized = false;
        
        private bool m_hasauthenticate;
        /// <summary></summary>
        protected bool hasauthenticate_initialized = false;
        
        private string m_headimg;
        /// <summary></summary>
        protected bool headimg_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_introduction;
        /// <summary></summary>
        protected bool introduction_initialized = false;
        
        private string m_jiage;
        /// <summary></summary>
        protected bool jiage_initialized = false;
        
        private string m_jiajiaoqixian;
        /// <summary></summary>
        protected bool jiajiaoqixian_initialized = false;
        
        private string m_jiaoxuequyu;
        /// <summary></summary>
        protected bool jiaoxuequyu_initialized = false;
        
        private string m_mobile;
        /// <summary></summary>
        protected bool mobile_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_nianji;
        /// <summary></summary>
        protected bool nianji_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private string m_qinkuang;
        /// <summary></summary>
        protected bool qinkuang_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_tags;
        /// <summary></summary>
        protected bool tags_initialized = false;
        
        private string m_time;
        /// <summary></summary>
        protected bool time_initialized = false;
        
        private string m_userfreetimematchids;
        /// <summary></summary>
        protected bool userfreetimematchids_initialized = false;
        
        private string m_yaoqiu;
        /// <summary></summary>
        protected bool yaoqiu_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_renwu";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.applycount_initialized = IsLoadAllAttributes;this.authenticatestatus_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.evaluationstar_initialized = IsLoadAllAttributes;this.fudaokemu_initialized = IsLoadAllAttributes;this.gaokao_initialized = IsLoadAllAttributes;this.getjiang_initialized = IsLoadAllAttributes;this.hasauthenticate_initialized = IsLoadAllAttributes;this.headimg_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.introduction_initialized = IsLoadAllAttributes;this.jiage_initialized = IsLoadAllAttributes;this.jiajiaoqixian_initialized = IsLoadAllAttributes;this.jiaoxuequyu_initialized = IsLoadAllAttributes;this.mobile_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.nianji_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.qinkuang_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.tags_initialized = IsLoadAllAttributes;this.time_initialized = IsLoadAllAttributes;this.userfreetimematchids_initialized = IsLoadAllAttributes;this.yaoqiu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_renwu value = new Xb_renwu();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ApplyCount"))
				value.applycount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AuthenticateStatus"))
				value.authenticatestatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EvaluationStar"))
				value.evaluationstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fudaokemu"))
				value.fudaokemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Gaokao"))
				value.gaokao_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Getjiang"))
				value.getjiang_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HasAuthenticate"))
				value.hasauthenticate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HeadImg"))
				value.headimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduction"))
				value.introduction_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jiage"))
				value.jiage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jiajiaoqixian"))
				value.jiajiaoqixian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jiaoxuequyu"))
				value.jiaoxuequyu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mobile"))
				value.mobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nianji"))
				value.nianji_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qinkuang"))
				value.qinkuang_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tags"))
				value.tags_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time"))
				value.time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserFreeTimeMatchIds"))
				value.userfreetimematchids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Yaoqiu"))
				value.yaoqiu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_renwu Clone()
        {
            return (Xb_renwu)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_renwu()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_renwu() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_renwu(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_renwu(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_renwu(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_renwu(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_renwu(int applycount1, string authenticatestatus1, string email1, decimal evaluationstar1, string fudaokemu1, string gaokao1, string getjiang1, bool hasauthenticate1, string headimg1, int id1, string introduction1, string jiage1, string jiajiaoqixian1, string jiaoxuequyu1, string mobile1, string name1, string nianji1, string path1, string qinkuang1, string sex1, string tags1, string time1, string userfreetimematchids1, string yaoqiu1)
        {
            
            this.ApplyCount = applycount1;
            
            this.AuthenticateStatus = authenticatestatus1;
            
            this.Email = email1;
            
            this.EvaluationStar = evaluationstar1;
            
            this.Fudaokemu = fudaokemu1;
            
            this.Gaokao = gaokao1;
            
            this.Getjiang = getjiang1;
            
            this.HasAuthenticate = hasauthenticate1;
            
            this.HeadImg = headimg1;
            
            this.Id = id1;
            
            this.Introduction = introduction1;
            
            this.Jiage = jiage1;
            
            this.Jiajiaoqixian = jiajiaoqixian1;
            
            this.Jiaoxuequyu = jiaoxuequyu1;
            
            this.Mobile = mobile1;
            
            this.Name = name1;
            
            this.Nianji = nianji1;
            
            this.Path = path1;
            
            this.Qinkuang = qinkuang1;
            
            this.Sex = sex1;
            
            this.Tags = tags1;
            
            this.Time = time1;
            
            this.UserFreeTimeMatchIds = userfreetimematchids1;
            
            this.Yaoqiu = yaoqiu1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_renwu FromIView(IView view)
        {
            return (Xb_renwu)IView.GetITable(view, "Xb_renwu");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_renwu GetOneInstance()
        {
            Xb_renwu value = new Xb_renwu();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_renwu Retrieve()
        {
            BLLTable<Xb_renwu>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ApplyCount":
			        return ApplyCount;
			    			
			    case "AuthenticateStatus":
			        return AuthenticateStatus;
			    			
			    case "Email":
			        return Email;
			    			
			    case "EvaluationStar":
			        return EvaluationStar;
			    			
			    case "Fudaokemu":
			        return Fudaokemu;
			    			
			    case "Gaokao":
			        return Gaokao;
			    			
			    case "Getjiang":
			        return Getjiang;
			    			
			    case "HasAuthenticate":
			        return HasAuthenticate;
			    			
			    case "HeadImg":
			        return HeadImg;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Introduction":
			        return Introduction;
			    			
			    case "Jiage":
			        return Jiage;
			    			
			    case "Jiajiaoqixian":
			        return Jiajiaoqixian;
			    			
			    case "Jiaoxuequyu":
			        return Jiaoxuequyu;
			    			
			    case "Mobile":
			        return Mobile;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Nianji":
			        return Nianji;
			    			
			    case "Path":
			        return Path;
			    			
			    case "Qinkuang":
			        return Qinkuang;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "Tags":
			        return Tags;
			    			
			    case "Time":
			        return Time;
			    			
			    case "UserFreeTimeMatchIds":
			        return UserFreeTimeMatchIds;
			    			
			    case "Yaoqiu":
			        return Yaoqiu;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ApplyCount":
			        this.ApplyCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AuthenticateStatus":
			        this.AuthenticateStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "EvaluationStar":
			        this.EvaluationStar = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Fudaokemu":
			        this.Fudaokemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Gaokao":
			        this.Gaokao = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Getjiang":
			        this.Getjiang = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HasAuthenticate":
			        this.HasAuthenticate = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "HeadImg":
			        this.HeadImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Introduction":
			        this.Introduction = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Jiage":
			        this.Jiage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Jiajiaoqixian":
			        this.Jiajiaoqixian = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Jiaoxuequyu":
			        this.Jiaoxuequyu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mobile":
			        this.Mobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Nianji":
			        this.Nianji = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qinkuang":
			        this.Qinkuang = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tags":
			        this.Tags = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time":
			        this.Time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserFreeTimeMatchIds":
			        this.UserFreeTimeMatchIds = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Yaoqiu":
			        this.Yaoqiu = Convert.ToString(AttributeValue);
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
				case "ApplyCount":
					return applycount_initialized;
				
				case "AuthenticateStatus":
					return authenticatestatus_initialized;
				
				case "Email":
					return email_initialized;
				
				case "EvaluationStar":
					return evaluationstar_initialized;
				
				case "Fudaokemu":
					return fudaokemu_initialized;
				
				case "Gaokao":
					return gaokao_initialized;
				
				case "Getjiang":
					return getjiang_initialized;
				
				case "HasAuthenticate":
					return hasauthenticate_initialized;
				
				case "HeadImg":
					return headimg_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Introduction":
					return introduction_initialized;
				
				case "Jiage":
					return jiage_initialized;
				
				case "Jiajiaoqixian":
					return jiajiaoqixian_initialized;
				
				case "Jiaoxuequyu":
					return jiaoxuequyu_initialized;
				
				case "Mobile":
					return mobile_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Nianji":
					return nianji_initialized;
				
				case "Path":
					return path_initialized;
				
				case "Qinkuang":
					return qinkuang_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "Tags":
					return tags_initialized;
				
				case "Time":
					return time_initialized;
				
				case "UserFreeTimeMatchIds":
					return userfreetimematchids_initialized;
				
				case "Yaoqiu":
					return yaoqiu_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ApplyCount":
					applycount_initialized = ret;
					return true;
				
				case "AuthenticateStatus":
					authenticatestatus_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "EvaluationStar":
					evaluationstar_initialized = ret;
					return true;
				
				case "Fudaokemu":
					fudaokemu_initialized = ret;
					return true;
				
				case "Gaokao":
					gaokao_initialized = ret;
					return true;
				
				case "Getjiang":
					getjiang_initialized = ret;
					return true;
				
				case "HasAuthenticate":
					hasauthenticate_initialized = ret;
					return true;
				
				case "HeadImg":
					headimg_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Introduction":
					introduction_initialized = ret;
					return true;
				
				case "Jiage":
					jiage_initialized = ret;
					return true;
				
				case "Jiajiaoqixian":
					jiajiaoqixian_initialized = ret;
					return true;
				
				case "Jiaoxuequyu":
					jiaoxuequyu_initialized = ret;
					return true;
				
				case "Mobile":
					mobile_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Nianji":
					nianji_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "Qinkuang":
					qinkuang_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "Tags":
					tags_initialized = ret;
					return true;
				
				case "Time":
					time_initialized = ret;
					return true;
				
				case "UserFreeTimeMatchIds":
					userfreetimematchids_initialized = ret;
					return true;
				
				case "Yaoqiu":
					yaoqiu_initialized = ret;
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

			
			if (applycount_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.ApplyCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ApplyCount);
                }
			}
			
			if (authenticatestatus_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.AuthenticateStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AuthenticateStatus);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (evaluationstar_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.EvaluationStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EvaluationStar);
                }
			}
			
			if (fudaokemu_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Fudaokemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fudaokemu);
                }
			}
			
			if (gaokao_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Gaokao;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Gaokao);
                }
			}
			
			if (getjiang_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Getjiang;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Getjiang);
                }
			}
			
			if (hasauthenticate_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.HasAuthenticate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HasAuthenticate);
                }
			}
			
			if (headimg_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.HeadImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HeadImg);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (introduction_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Introduction;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduction);
                }
			}
			
			if (jiage_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Jiage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jiage);
                }
			}
			
			if (jiajiaoqixian_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Jiajiaoqixian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jiajiaoqixian);
                }
			}
			
			if (jiaoxuequyu_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Jiaoxuequyu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jiaoxuequyu);
                }
			}
			
			if (mobile_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Mobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mobile);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (nianji_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Nianji;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nianji);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (qinkuang_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Qinkuang;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qinkuang);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (tags_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Tags;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tags);
                }
			}
			
			if (time_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time);
                }
			}
			
			if (userfreetimematchids_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.UserFreeTimeMatchIds;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserFreeTimeMatchIds);
                }
			}
			
			if (yaoqiu_initialized)
			{
                AttributeItem attr = Xb_renwu.Attribute.Yaoqiu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Yaoqiu);
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
        public class Xb_renwuJson
        {
            
            /// <summary>兼职次数:[CtrlTypeDic-{InputString}]</summary>
            public int ApplyCount { get; set; }
            
            /// <summary>身份认证状态:[CtrlTypeDic-{InputString}]</summary>
            public string AuthenticateStatus { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Email { get; set; }
            
            /// <summary>兼职评分:[CtrlTypeDic-{InputString}]</summary>
            public decimal EvaluationStar { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Fudaokemu { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Gaokao { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Getjiang { get; set; }
            
            /// <summary>身份认证成功？:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool HasAuthenticate { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string HeadImg { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Introduction { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Jiage { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Jiajiaoqixian { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Jiaoxuequyu { get; set; }
            
            /// <summary>手机号:[CtrlTypeDic-{InputString}]</summary>
            public string Mobile { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Nianji { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Qinkuang { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Sex { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Tags { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Time { get; set; }
            
            /// <summary>空闲时间:[CtrlTypeDic-{InputString}]</summary>
            public string UserFreeTimeMatchIds { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Yaoqiu { get; set; }
        }
        #endregion
    }
}