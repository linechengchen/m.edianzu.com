/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    数据表Jsj_entry对应的业务逻辑层Jsj_entry
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jsj_entry_Entity:Jsj_entry
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Uuid,ModifyTime,CreateTime,Serial_number,Field_21,Field_22,Field_23,Field_1,Field_2,Field_3,Field_4,Field_5,Field_6,Field_7,Field_13,Field_14,Field_18,Field_12,Field_15,Field_16,Field_24,Field_20,Field_17,X_field_weixin_nickname,X_field_weixin_gender,X_field_weixin_country,X_field_weixin_openid,X_field_weixin_headimgurl,Creator_name,Created_at,Updated_at,Info_remote_ip,Province,City,Form,Form_name from Jsj_entry
delete from Jsj_entry
INSERT INTO Jsj_entry (Id,Uuid,ModifyTime,CreateTime,Serial_number,Field_21,Field_22,Field_23,Field_1,Field_2,Field_3,Field_4,Field_5,Field_6,Field_7,Field_13,Field_14,Field_18,Field_12,Field_15,Field_16,Field_24,Field_20,Field_17,X_field_weixin_nickname,X_field_weixin_gender,X_field_weixin_country,X_field_weixin_openid,X_field_weixin_headimgurl,Creator_name,Created_at,Updated_at,Info_remote_ip,Province,City,Form,Form_name)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Jsj_entry SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Serial_number = valObj2.Serial_number;
        valObj.Field_21 = valObj2.Field_21;
        valObj.Field_22 = valObj2.Field_22;
        valObj.Field_23 = valObj2.Field_23;
        valObj.Field_1 = valObj2.Field_1;
        valObj.Field_2 = valObj2.Field_2;
        valObj.Field_3 = valObj2.Field_3;
        valObj.Field_4 = valObj2.Field_4;
        valObj.Field_5 = valObj2.Field_5;
        valObj.Field_6 = valObj2.Field_6;
        valObj.Field_7 = valObj2.Field_7;
        valObj.Field_13 = valObj2.Field_13;
        valObj.Field_14 = valObj2.Field_14;
        valObj.Field_18 = valObj2.Field_18;
        valObj.Field_12 = valObj2.Field_12;
        valObj.Field_15 = valObj2.Field_15;
        valObj.Field_16 = valObj2.Field_16;
        valObj.Field_24 = valObj2.Field_24;
        valObj.Field_20 = valObj2.Field_20;
        valObj.Field_17 = valObj2.Field_17;
        valObj.X_field_weixin_nickname = valObj2.X_field_weixin_nickname;
        valObj.X_field_weixin_gender = valObj2.X_field_weixin_gender;
        valObj.X_field_weixin_country = valObj2.X_field_weixin_country;
        valObj.X_field_weixin_openid = valObj2.X_field_weixin_openid;
        valObj.X_field_weixin_headimgurl = valObj2.X_field_weixin_headimgurl;
        valObj.Creator_name = valObj2.Creator_name;
        valObj.Created_at = valObj2.Created_at;
        valObj.Updated_at = valObj2.Updated_at;
        valObj.Info_remote_ip = valObj2.Info_remote_ip;
        valObj.Province = valObj2.Province;
        valObj.City = valObj2.City;
        valObj.Form = valObj2.Form;
        valObj.Form_name = valObj2.Form_name; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.ModifyTime = "";
        valObj.CreateTime = "";
        valObj.Serial_number = "";
        valObj.Field_21 = "";
        valObj.Field_22 = "";
        valObj.Field_23 = "";
        valObj.Field_1 = "";
        valObj.Field_2 = "";
        valObj.Field_3 = "";
        valObj.Field_4 = "";
        valObj.Field_5 = "";
        valObj.Field_6 = "";
        valObj.Field_7 = "";
        valObj.Field_13 = "";
        valObj.Field_14 = "";
        valObj.Field_18 = "";
        valObj.Field_12 = "";
        valObj.Field_15 = "";
        valObj.Field_16 = "";
        valObj.Field_24 = "";
        valObj.Field_20 = "";
        valObj.Field_17 = "";
        valObj.X_field_weixin_nickname = "";
        valObj.X_field_weixin_gender = "";
        valObj.X_field_weixin_country = "";
        valObj.X_field_weixin_openid = "";
        valObj.X_field_weixin_headimgurl = "";
        valObj.Creator_name = "";
        valObj.Created_at = "";
        valObj.Updated_at = "";
        valObj.Info_remote_ip = "";
        valObj.Province = "";
        valObj.City = "";
        valObj.Form = "";
        valObj.Form_name = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Serial_number": $("#txt_Serial_number").val(),
        "Field_21": $("#txt_Field_21").val(),
        "Field_22": $("#txt_Field_22").val(),
        "Field_23": $("#txt_Field_23").val(),
        "Field_1": $("#txt_Field_1").val(),
        "Field_2": $("#txt_Field_2").val(),
        "Field_3": $("#txt_Field_3").val(),
        "Field_4": $("#txt_Field_4").val(),
        "Field_5": $("#txt_Field_5").val(),
        "Field_6": $("#txt_Field_6").val(),
        "Field_7": $("#txt_Field_7").val(),
        "Field_13": $("#txt_Field_13").val(),
        "Field_14": $("#txt_Field_14").val(),
        "Field_18": $("#txt_Field_18").val(),
        "Field_12": $("#txt_Field_12").val(),
        "Field_15": $("#txt_Field_15").val(),
        "Field_16": $("#txt_Field_16").val(),
        "Field_24": $("#txt_Field_24").val(),
        "Field_20": $("#txt_Field_20").val(),
        "Field_17": $("#txt_Field_17").val(),
        "X_field_weixin_nickname": $("#txt_X_field_weixin_nickname").val(),
        "X_field_weixin_gender": $("#txt_X_field_weixin_gender").val(),
        "X_field_weixin_country": $("#txt_X_field_weixin_country").val(),
        "X_field_weixin_openid": $("#txt_X_field_weixin_openid").val(),
        "X_field_weixin_headimgurl": $("#txt_X_field_weixin_headimgurl").val(),
        "Creator_name": $("#txt_Creator_name").val(),
        "Created_at": $("#txt_Created_at").val(),
        "Updated_at": $("#txt_Updated_at").val(),
        "Info_remote_ip": $("#txt_Info_remote_ip").val(),
        "Province": $("#txt_Province").val(),
        "City": $("#txt_City").val(),
        "Form": $("#txt_Form").val(),
        "Form_name": $("#txt_Form_name").val(), 
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
    /// <para>金数据字段表</para>
    /// <para>与Jsj_entry数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jsj_entry : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jsj_entry Factory()
        {
            return new Jsj_entry();
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
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Serial_number
        {            
            get { return this.Serial_number; }
            set { this.Serial_number = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Field_21
        {            
            get { return this.Field_21; }
            set { this.Field_21 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Field_22
        {            
            get { return this.Field_22; }
            set { this.Field_22 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Field_23
        {            
            get { return this.Field_23; }
            set { this.Field_23 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_1
        {            
            get { return this.Field_1; }
            set { this.Field_1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_2
        {            
            get { return this.Field_2; }
            set { this.Field_2 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Field_3
        {            
            get { return this.Field_3; }
            set { this.Field_3 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Field_4
        {            
            get { return this.Field_4; }
            set { this.Field_4 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_5
        {            
            get { return this.Field_5; }
            set { this.Field_5 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_6
        {            
            get { return this.Field_6; }
            set { this.Field_6 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_7
        {            
            get { return this.Field_7; }
            set { this.Field_7 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_13
        {            
            get { return this.Field_13; }
            set { this.Field_13 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_14
        {            
            get { return this.Field_14; }
            set { this.Field_14 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_18
        {            
            get { return this.Field_18; }
            set { this.Field_18 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_12
        {            
            get { return this.Field_12; }
            set { this.Field_12 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_15
        {            
            get { return this.Field_15; }
            set { this.Field_15 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_16
        {            
            get { return this.Field_16; }
            set { this.Field_16 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_24
        {            
            get { return this.Field_24; }
            set { this.Field_24 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Field_20
        {            
            get { return this.Field_20; }
            set { this.Field_20 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Field_17
        {            
            get { return this.Field_17; }
            set { this.Field_17 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _X_field_weixin_nickname
        {            
            get { return this.X_field_weixin_nickname; }
            set { this.X_field_weixin_nickname = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _X_field_weixin_gender
        {            
            get { return this.X_field_weixin_gender; }
            set { this.X_field_weixin_gender = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _X_field_weixin_country
        {            
            get { return this.X_field_weixin_country; }
            set { this.X_field_weixin_country = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _X_field_weixin_openid
        {            
            get { return this.X_field_weixin_openid; }
            set { this.X_field_weixin_openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _X_field_weixin_headimgurl
        {            
            get { return this.X_field_weixin_headimgurl; }
            set { this.X_field_weixin_headimgurl = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Creator_name
        {            
            get { return this.Creator_name; }
            set { this.Creator_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Created_at
        {            
            get { return this.Created_at; }
            set { this.Created_at = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Updated_at
        {            
            get { return this.Updated_at; }
            set { this.Updated_at = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Info_remote_ip
        {            
            get { return this.Info_remote_ip; }
            set { this.Info_remote_ip = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form
        {            
            get { return this.Form; }
            set { this.Form = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form_name
        {            
            get { return this.Form_name; }
            set { this.Form_name = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Serial_number
        {
            get { return this.m_serial_number; }
            set //
            {
                if (!serial_number_initialized || m_serial_number != value)
                {
                    this.m_serial_number = value;
                }
                serial_number_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Field_21
        {
            get { return this.m_field_21; }
            set //
            {
                if (!field_21_initialized || m_field_21 != value)
                {
                    this.m_field_21 = value;
                }
                field_21_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Field_22
        {
            get { return this.m_field_22; }
            set //
            {
                if (!field_22_initialized || m_field_22 != value)
                {
                    this.m_field_22 = value;
                }
                field_22_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Field_23
        {
            get { return this.m_field_23; }
            set //
            {
                if (!field_23_initialized || m_field_23 != value)
                {
                    this.m_field_23 = value;
                }
                field_23_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_1
        {
            get { return this.m_field_1; }
            set //
            {
                if (!field_1_initialized || m_field_1 != value)
                {
                    this.m_field_1 = value;
                }
                field_1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_2
        {
            get { return this.m_field_2; }
            set //
            {
                if (!field_2_initialized || m_field_2 != value)
                {
                    this.m_field_2 = value;
                }
                field_2_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Field_3
        {
            get { return this.m_field_3; }
            set //
            {
                if (!field_3_initialized || m_field_3 != value)
                {
                    this.m_field_3 = value;
                }
                field_3_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Field_4
        {
            get { return this.m_field_4; }
            set //
            {
                if (!field_4_initialized || m_field_4 != value)
                {
                    this.m_field_4 = value;
                }
                field_4_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_5
        {
            get { return this.m_field_5; }
            set //
            {
                if (!field_5_initialized || m_field_5 != value)
                {
                    this.m_field_5 = value;
                }
                field_5_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_6
        {
            get { return this.m_field_6; }
            set //
            {
                if (!field_6_initialized || m_field_6 != value)
                {
                    this.m_field_6 = value;
                }
                field_6_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_7
        {
            get { return this.m_field_7; }
            set //
            {
                if (!field_7_initialized || m_field_7 != value)
                {
                    this.m_field_7 = value;
                }
                field_7_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_13
        {
            get { return this.m_field_13; }
            set //
            {
                if (!field_13_initialized || m_field_13 != value)
                {
                    this.m_field_13 = value;
                }
                field_13_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_14
        {
            get { return this.m_field_14; }
            set //
            {
                if (!field_14_initialized || m_field_14 != value)
                {
                    this.m_field_14 = value;
                }
                field_14_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_18
        {
            get { return this.m_field_18; }
            set //
            {
                if (!field_18_initialized || m_field_18 != value)
                {
                    this.m_field_18 = value;
                }
                field_18_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_12
        {
            get { return this.m_field_12; }
            set //
            {
                if (!field_12_initialized || m_field_12 != value)
                {
                    this.m_field_12 = value;
                }
                field_12_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_15
        {
            get { return this.m_field_15; }
            set //
            {
                if (!field_15_initialized || m_field_15 != value)
                {
                    this.m_field_15 = value;
                }
                field_15_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_16
        {
            get { return this.m_field_16; }
            set //
            {
                if (!field_16_initialized || m_field_16 != value)
                {
                    this.m_field_16 = value;
                }
                field_16_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_24
        {
            get { return this.m_field_24; }
            set //
            {
                if (!field_24_initialized || m_field_24 != value)
                {
                    this.m_field_24 = value;
                }
                field_24_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Field_20
        {
            get { return this.m_field_20; }
            set //
            {
                if (!field_20_initialized || m_field_20 != value)
                {
                    this.m_field_20 = value;
                }
                field_20_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Field_17
        {
            get { return this.m_field_17; }
            set //
            {
                if (!field_17_initialized || m_field_17 != value)
                {
                    this.m_field_17 = value;
                }
                field_17_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string X_field_weixin_nickname
        {
            get { return this.m_x_field_weixin_nickname; }
            set //
            {
                if (!x_field_weixin_nickname_initialized || m_x_field_weixin_nickname != value)
                {
                    this.m_x_field_weixin_nickname = value;
                }
                x_field_weixin_nickname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string X_field_weixin_gender
        {
            get { return this.m_x_field_weixin_gender; }
            set //
            {
                if (!x_field_weixin_gender_initialized || m_x_field_weixin_gender != value)
                {
                    this.m_x_field_weixin_gender = value;
                }
                x_field_weixin_gender_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string X_field_weixin_country
        {
            get { return this.m_x_field_weixin_country; }
            set //
            {
                if (!x_field_weixin_country_initialized || m_x_field_weixin_country != value)
                {
                    this.m_x_field_weixin_country = value;
                }
                x_field_weixin_country_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string X_field_weixin_openid
        {
            get { return this.m_x_field_weixin_openid; }
            set //
            {
                if (!x_field_weixin_openid_initialized || m_x_field_weixin_openid != value)
                {
                    this.m_x_field_weixin_openid = value;
                }
                x_field_weixin_openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string X_field_weixin_headimgurl
        {
            get { return this.m_x_field_weixin_headimgurl; }
            set //
            {
                if (!x_field_weixin_headimgurl_initialized || m_x_field_weixin_headimgurl != value)
                {
                    this.m_x_field_weixin_headimgurl = value;
                }
                x_field_weixin_headimgurl_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Creator_name
        {
            get { return this.m_creator_name; }
            set //
            {
                if (!creator_name_initialized || m_creator_name != value)
                {
                    this.m_creator_name = value;
                }
                creator_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Created_at
        {
            get { return this.m_created_at; }
            set //
            {
                if (!created_at_initialized || m_created_at != value)
                {
                    this.m_created_at = value;
                }
                created_at_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Updated_at
        {
            get { return this.m_updated_at; }
            set //
            {
                if (!updated_at_initialized || m_updated_at != value)
                {
                    this.m_updated_at = value;
                }
                updated_at_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Info_remote_ip
        {
            get { return this.m_info_remote_ip; }
            set //
            {
                if (!info_remote_ip_initialized || m_info_remote_ip != value)
                {
                    this.m_info_remote_ip = value;
                }
                info_remote_ip_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Province
        {
            get { return this.m_province; }
            set //
            {
                if (!province_initialized || m_province != value)
                {
                    this.m_province = value;
                }
                province_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Form
        {
            get { return this.m_form; }
            set //
            {
                if (!form_initialized || m_form != value)
                {
                    this.m_form = value;
                }
                form_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Form_name
        {
            get { return this.m_form_name; }
            set //
            {
                if (!form_name_initialized || m_form_name != value)
                {
                    this.m_form_name = value;
                }
                form_name_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jsj_entry].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jsj_entry].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jsj_entry].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jsj_entry].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Serial_number =  new AttributeItem("[Jsj_entry].[Serial_number]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_21 =  new AttributeItem("[Jsj_entry].[Field_21]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_22 =  new AttributeItem("[Jsj_entry].[Field_22]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_23 =  new AttributeItem("[Jsj_entry].[Field_23]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_1 =  new AttributeItem("[Jsj_entry].[Field_1]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_2 =  new AttributeItem("[Jsj_entry].[Field_2]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_3 =  new AttributeItem("[Jsj_entry].[Field_3]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Field_4 =  new AttributeItem("[Jsj_entry].[Field_4]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_5 =  new AttributeItem("[Jsj_entry].[Field_5]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_6 =  new AttributeItem("[Jsj_entry].[Field_6]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_7 =  new AttributeItem("[Jsj_entry].[Field_7]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_13 =  new AttributeItem("[Jsj_entry].[Field_13]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_14 =  new AttributeItem("[Jsj_entry].[Field_14]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_18 =  new AttributeItem("[Jsj_entry].[Field_18]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_12 =  new AttributeItem("[Jsj_entry].[Field_12]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_15 =  new AttributeItem("[Jsj_entry].[Field_15]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_16 =  new AttributeItem("[Jsj_entry].[Field_16]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_24 =  new AttributeItem("[Jsj_entry].[Field_24]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Field_20 =  new AttributeItem("[Jsj_entry].[Field_20]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Field_17 =  new AttributeItem("[Jsj_entry].[Field_17]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X_field_weixin_nickname =  new AttributeItem("[Jsj_entry].[X_field_weixin_nickname]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X_field_weixin_gender =  new AttributeItem("[Jsj_entry].[X_field_weixin_gender]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X_field_weixin_country =  new AttributeItem("[Jsj_entry].[X_field_weixin_country]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X_field_weixin_openid =  new AttributeItem("[Jsj_entry].[X_field_weixin_openid]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X_field_weixin_headimgurl =  new AttributeItem("[Jsj_entry].[X_field_weixin_headimgurl]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Creator_name =  new AttributeItem("[Jsj_entry].[Creator_name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Created_at =  new AttributeItem("[Jsj_entry].[Created_at]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Updated_at =  new AttributeItem("[Jsj_entry].[Updated_at]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Info_remote_ip =  new AttributeItem("[Jsj_entry].[Info_remote_ip]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[Jsj_entry].[Province]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[Jsj_entry].[City]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form =  new AttributeItem("[Jsj_entry].[Form]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form_name =  new AttributeItem("[Jsj_entry].[Form_name]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_serial_number;
        /// <summary></summary>
        protected bool serial_number_initialized = false;
        
        private int m_field_21;
        /// <summary></summary>
        protected bool field_21_initialized = false;
        
        private int m_field_22;
        /// <summary></summary>
        protected bool field_22_initialized = false;
        
        private int m_field_23;
        /// <summary></summary>
        protected bool field_23_initialized = false;
        
        private string m_field_1;
        /// <summary></summary>
        protected bool field_1_initialized = false;
        
        private string m_field_2;
        /// <summary></summary>
        protected bool field_2_initialized = false;
        
        private decimal m_field_3;
        /// <summary></summary>
        protected bool field_3_initialized = false;
        
        private DateTime m_field_4;
        /// <summary></summary>
        protected bool field_4_initialized = false;
        
        private string m_field_5;
        /// <summary></summary>
        protected bool field_5_initialized = false;
        
        private string m_field_6;
        /// <summary></summary>
        protected bool field_6_initialized = false;
        
        private string m_field_7;
        /// <summary></summary>
        protected bool field_7_initialized = false;
        
        private string m_field_13;
        /// <summary></summary>
        protected bool field_13_initialized = false;
        
        private string m_field_14;
        /// <summary></summary>
        protected bool field_14_initialized = false;
        
        private string m_field_18;
        /// <summary></summary>
        protected bool field_18_initialized = false;
        
        private string m_field_12;
        /// <summary></summary>
        protected bool field_12_initialized = false;
        
        private string m_field_15;
        /// <summary></summary>
        protected bool field_15_initialized = false;
        
        private string m_field_16;
        /// <summary></summary>
        protected bool field_16_initialized = false;
        
        private string m_field_24;
        /// <summary></summary>
        protected bool field_24_initialized = false;
        
        private string m_field_20;
        /// <summary></summary>
        protected bool field_20_initialized = false;
        
        private DateTime m_field_17;
        /// <summary></summary>
        protected bool field_17_initialized = false;
        
        private string m_x_field_weixin_nickname;
        /// <summary></summary>
        protected bool x_field_weixin_nickname_initialized = false;
        
        private string m_x_field_weixin_gender;
        /// <summary></summary>
        protected bool x_field_weixin_gender_initialized = false;
        
        private string m_x_field_weixin_country;
        /// <summary></summary>
        protected bool x_field_weixin_country_initialized = false;
        
        private string m_x_field_weixin_openid;
        /// <summary></summary>
        protected bool x_field_weixin_openid_initialized = false;
        
        private string m_x_field_weixin_headimgurl;
        /// <summary></summary>
        protected bool x_field_weixin_headimgurl_initialized = false;
        
        private string m_creator_name;
        /// <summary></summary>
        protected bool creator_name_initialized = false;
        
        private string m_created_at;
        /// <summary></summary>
        protected bool created_at_initialized = false;
        
        private string m_updated_at;
        /// <summary></summary>
        protected bool updated_at_initialized = false;
        
        private string m_info_remote_ip;
        /// <summary></summary>
        protected bool info_remote_ip_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_form;
        /// <summary></summary>
        protected bool form_initialized = false;
        
        private string m_form_name;
        /// <summary></summary>
        protected bool form_name_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jsj_entry";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.serial_number_initialized = IsLoadAllAttributes;this.field_21_initialized = IsLoadAllAttributes;this.field_22_initialized = IsLoadAllAttributes;this.field_23_initialized = IsLoadAllAttributes;this.field_1_initialized = IsLoadAllAttributes;this.field_2_initialized = IsLoadAllAttributes;this.field_3_initialized = IsLoadAllAttributes;this.field_4_initialized = IsLoadAllAttributes;this.field_5_initialized = IsLoadAllAttributes;this.field_6_initialized = IsLoadAllAttributes;this.field_7_initialized = IsLoadAllAttributes;this.field_13_initialized = IsLoadAllAttributes;this.field_14_initialized = IsLoadAllAttributes;this.field_18_initialized = IsLoadAllAttributes;this.field_12_initialized = IsLoadAllAttributes;this.field_15_initialized = IsLoadAllAttributes;this.field_16_initialized = IsLoadAllAttributes;this.field_24_initialized = IsLoadAllAttributes;this.field_20_initialized = IsLoadAllAttributes;this.field_17_initialized = IsLoadAllAttributes;this.x_field_weixin_nickname_initialized = IsLoadAllAttributes;this.x_field_weixin_gender_initialized = IsLoadAllAttributes;this.x_field_weixin_country_initialized = IsLoadAllAttributes;this.x_field_weixin_openid_initialized = IsLoadAllAttributes;this.x_field_weixin_headimgurl_initialized = IsLoadAllAttributes;this.creator_name_initialized = IsLoadAllAttributes;this.created_at_initialized = IsLoadAllAttributes;this.updated_at_initialized = IsLoadAllAttributes;this.info_remote_ip_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.form_initialized = IsLoadAllAttributes;this.form_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jsj_entry value = new Jsj_entry();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Serial_number"))
				value.serial_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_21"))
				value.field_21_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_22"))
				value.field_22_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_23"))
				value.field_23_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_1"))
				value.field_1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_2"))
				value.field_2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_3"))
				value.field_3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_4"))
				value.field_4_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_5"))
				value.field_5_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_6"))
				value.field_6_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_7"))
				value.field_7_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_13"))
				value.field_13_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_14"))
				value.field_14_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_18"))
				value.field_18_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_12"))
				value.field_12_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_15"))
				value.field_15_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_16"))
				value.field_16_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_24"))
				value.field_24_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_20"))
				value.field_20_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_17"))
				value.field_17_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X_field_weixin_nickname"))
				value.x_field_weixin_nickname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X_field_weixin_gender"))
				value.x_field_weixin_gender_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X_field_weixin_country"))
				value.x_field_weixin_country_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X_field_weixin_openid"))
				value.x_field_weixin_openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X_field_weixin_headimgurl"))
				value.x_field_weixin_headimgurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creator_name"))
				value.creator_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Created_at"))
				value.created_at_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Updated_at"))
				value.updated_at_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Info_remote_ip"))
				value.info_remote_ip_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form"))
				value.form_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form_name"))
				value.form_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jsj_entry Clone()
        {
            return (Jsj_entry)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jsj_entry()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jsj_entry() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jsj_entry(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jsj_entry(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jsj_entry(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jsj_entry(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jsj_entry(int id1, Guid uuid1, DateTime modifytime1, DateTime createtime1, int serial_number1, int field_211, int field_221, int field_231, string field_11, string field_21, decimal field_31, DateTime field_41, string field_51, string field_61, string field_71, string field_131, string field_141, string field_181, string field_121, string field_151, string field_161, string field_241, string field_201, DateTime field_171, string x_field_weixin_nickname1, string x_field_weixin_gender1, string x_field_weixin_country1, string x_field_weixin_openid1, string x_field_weixin_headimgurl1, string creator_name1, string created_at1, string updated_at1, string info_remote_ip1, string province1, string city1, string form1, string form_name1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.ModifyTime = modifytime1;
            
            this.CreateTime = createtime1;
            
            this.Serial_number = serial_number1;
            
            this.Field_21 = field_211;
            
            this.Field_22 = field_221;
            
            this.Field_23 = field_231;
            
            this.Field_1 = field_11;
            
            this.Field_2 = field_21;
            
            this.Field_3 = field_31;
            
            this.Field_4 = field_41;
            
            this.Field_5 = field_51;
            
            this.Field_6 = field_61;
            
            this.Field_7 = field_71;
            
            this.Field_13 = field_131;
            
            this.Field_14 = field_141;
            
            this.Field_18 = field_181;
            
            this.Field_12 = field_121;
            
            this.Field_15 = field_151;
            
            this.Field_16 = field_161;
            
            this.Field_24 = field_241;
            
            this.Field_20 = field_201;
            
            this.Field_17 = field_171;
            
            this.X_field_weixin_nickname = x_field_weixin_nickname1;
            
            this.X_field_weixin_gender = x_field_weixin_gender1;
            
            this.X_field_weixin_country = x_field_weixin_country1;
            
            this.X_field_weixin_openid = x_field_weixin_openid1;
            
            this.X_field_weixin_headimgurl = x_field_weixin_headimgurl1;
            
            this.Creator_name = creator_name1;
            
            this.Created_at = created_at1;
            
            this.Updated_at = updated_at1;
            
            this.Info_remote_ip = info_remote_ip1;
            
            this.Province = province1;
            
            this.City = city1;
            
            this.Form = form1;
            
            this.Form_name = form_name1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jsj_entry FromIView(IView view)
        {
            return (Jsj_entry)IView.GetITable(view, "Jsj_entry");
        }
        /// <summary>获得一个实例  </summary>
        public static Jsj_entry GetOneInstance()
        {
            Jsj_entry value = new Jsj_entry();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jsj_entry Retrieve()
        {
            BLLTable<Jsj_entry>.GetRowData(this);
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
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Serial_number":
			        return Serial_number;
			    			
			    case "Field_21":
			        return Field_21;
			    			
			    case "Field_22":
			        return Field_22;
			    			
			    case "Field_23":
			        return Field_23;
			    			
			    case "Field_1":
			        return Field_1;
			    			
			    case "Field_2":
			        return Field_2;
			    			
			    case "Field_3":
			        return Field_3;
			    			
			    case "Field_4":
			        return Field_4;
			    			
			    case "Field_5":
			        return Field_5;
			    			
			    case "Field_6":
			        return Field_6;
			    			
			    case "Field_7":
			        return Field_7;
			    			
			    case "Field_13":
			        return Field_13;
			    			
			    case "Field_14":
			        return Field_14;
			    			
			    case "Field_18":
			        return Field_18;
			    			
			    case "Field_12":
			        return Field_12;
			    			
			    case "Field_15":
			        return Field_15;
			    			
			    case "Field_16":
			        return Field_16;
			    			
			    case "Field_24":
			        return Field_24;
			    			
			    case "Field_20":
			        return Field_20;
			    			
			    case "Field_17":
			        return Field_17;
			    			
			    case "X_field_weixin_nickname":
			        return X_field_weixin_nickname;
			    			
			    case "X_field_weixin_gender":
			        return X_field_weixin_gender;
			    			
			    case "X_field_weixin_country":
			        return X_field_weixin_country;
			    			
			    case "X_field_weixin_openid":
			        return X_field_weixin_openid;
			    			
			    case "X_field_weixin_headimgurl":
			        return X_field_weixin_headimgurl;
			    			
			    case "Creator_name":
			        return Creator_name;
			    			
			    case "Created_at":
			        return Created_at;
			    			
			    case "Updated_at":
			        return Updated_at;
			    			
			    case "Info_remote_ip":
			        return Info_remote_ip;
			    			
			    case "Province":
			        return Province;
			    			
			    case "City":
			        return City;
			    			
			    case "Form":
			        return Form;
			    			
			    case "Form_name":
			        return Form_name;
			
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
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Serial_number":
			        this.Serial_number = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Field_21":
			        this.Field_21 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Field_22":
			        this.Field_22 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Field_23":
			        this.Field_23 = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Field_1":
			        this.Field_1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_2":
			        this.Field_2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_3":
			        this.Field_3 = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Field_4":
			        this.Field_4 = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Field_5":
			        this.Field_5 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_6":
			        this.Field_6 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_7":
			        this.Field_7 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_13":
			        this.Field_13 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_14":
			        this.Field_14 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_18":
			        this.Field_18 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_12":
			        this.Field_12 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_15":
			        this.Field_15 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_16":
			        this.Field_16 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_24":
			        this.Field_24 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_20":
			        this.Field_20 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_17":
			        this.Field_17 = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "X_field_weixin_nickname":
			        this.X_field_weixin_nickname = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X_field_weixin_gender":
			        this.X_field_weixin_gender = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X_field_weixin_country":
			        this.X_field_weixin_country = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X_field_weixin_openid":
			        this.X_field_weixin_openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X_field_weixin_headimgurl":
			        this.X_field_weixin_headimgurl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creator_name":
			        this.Creator_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Created_at":
			        this.Created_at = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Updated_at":
			        this.Updated_at = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Info_remote_ip":
			        this.Info_remote_ip = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Form":
			        this.Form = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Form_name":
			        this.Form_name = Convert.ToString(AttributeValue);
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
				
				case "Uuid":
					return uuid_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Serial_number":
					return serial_number_initialized;
				
				case "Field_21":
					return field_21_initialized;
				
				case "Field_22":
					return field_22_initialized;
				
				case "Field_23":
					return field_23_initialized;
				
				case "Field_1":
					return field_1_initialized;
				
				case "Field_2":
					return field_2_initialized;
				
				case "Field_3":
					return field_3_initialized;
				
				case "Field_4":
					return field_4_initialized;
				
				case "Field_5":
					return field_5_initialized;
				
				case "Field_6":
					return field_6_initialized;
				
				case "Field_7":
					return field_7_initialized;
				
				case "Field_13":
					return field_13_initialized;
				
				case "Field_14":
					return field_14_initialized;
				
				case "Field_18":
					return field_18_initialized;
				
				case "Field_12":
					return field_12_initialized;
				
				case "Field_15":
					return field_15_initialized;
				
				case "Field_16":
					return field_16_initialized;
				
				case "Field_24":
					return field_24_initialized;
				
				case "Field_20":
					return field_20_initialized;
				
				case "Field_17":
					return field_17_initialized;
				
				case "X_field_weixin_nickname":
					return x_field_weixin_nickname_initialized;
				
				case "X_field_weixin_gender":
					return x_field_weixin_gender_initialized;
				
				case "X_field_weixin_country":
					return x_field_weixin_country_initialized;
				
				case "X_field_weixin_openid":
					return x_field_weixin_openid_initialized;
				
				case "X_field_weixin_headimgurl":
					return x_field_weixin_headimgurl_initialized;
				
				case "Creator_name":
					return creator_name_initialized;
				
				case "Created_at":
					return created_at_initialized;
				
				case "Updated_at":
					return updated_at_initialized;
				
				case "Info_remote_ip":
					return info_remote_ip_initialized;
				
				case "Province":
					return province_initialized;
				
				case "City":
					return city_initialized;
				
				case "Form":
					return form_initialized;
				
				case "Form_name":
					return form_name_initialized;
				
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
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Serial_number":
					serial_number_initialized = ret;
					return true;
				
				case "Field_21":
					field_21_initialized = ret;
					return true;
				
				case "Field_22":
					field_22_initialized = ret;
					return true;
				
				case "Field_23":
					field_23_initialized = ret;
					return true;
				
				case "Field_1":
					field_1_initialized = ret;
					return true;
				
				case "Field_2":
					field_2_initialized = ret;
					return true;
				
				case "Field_3":
					field_3_initialized = ret;
					return true;
				
				case "Field_4":
					field_4_initialized = ret;
					return true;
				
				case "Field_5":
					field_5_initialized = ret;
					return true;
				
				case "Field_6":
					field_6_initialized = ret;
					return true;
				
				case "Field_7":
					field_7_initialized = ret;
					return true;
				
				case "Field_13":
					field_13_initialized = ret;
					return true;
				
				case "Field_14":
					field_14_initialized = ret;
					return true;
				
				case "Field_18":
					field_18_initialized = ret;
					return true;
				
				case "Field_12":
					field_12_initialized = ret;
					return true;
				
				case "Field_15":
					field_15_initialized = ret;
					return true;
				
				case "Field_16":
					field_16_initialized = ret;
					return true;
				
				case "Field_24":
					field_24_initialized = ret;
					return true;
				
				case "Field_20":
					field_20_initialized = ret;
					return true;
				
				case "Field_17":
					field_17_initialized = ret;
					return true;
				
				case "X_field_weixin_nickname":
					x_field_weixin_nickname_initialized = ret;
					return true;
				
				case "X_field_weixin_gender":
					x_field_weixin_gender_initialized = ret;
					return true;
				
				case "X_field_weixin_country":
					x_field_weixin_country_initialized = ret;
					return true;
				
				case "X_field_weixin_openid":
					x_field_weixin_openid_initialized = ret;
					return true;
				
				case "X_field_weixin_headimgurl":
					x_field_weixin_headimgurl_initialized = ret;
					return true;
				
				case "Creator_name":
					creator_name_initialized = ret;
					return true;
				
				case "Created_at":
					created_at_initialized = ret;
					return true;
				
				case "Updated_at":
					updated_at_initialized = ret;
					return true;
				
				case "Info_remote_ip":
					info_remote_ip_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Form":
					form_initialized = ret;
					return true;
				
				case "Form_name":
					form_name_initialized = ret;
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
                AttributeItem attr = Jsj_entry.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (serial_number_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Serial_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Serial_number);
                }
			}
			
			if (field_21_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_21;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_21);
                }
			}
			
			if (field_22_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_22;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_22);
                }
			}
			
			if (field_23_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_23;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_23);
                }
			}
			
			if (field_1_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_1);
                }
			}
			
			if (field_2_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_2);
                }
			}
			
			if (field_3_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_3);
                }
			}
			
			if (field_4_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_4;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_4);
                }
			}
			
			if (field_5_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_5);
                }
			}
			
			if (field_6_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_6;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_6);
                }
			}
			
			if (field_7_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_7;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_7);
                }
			}
			
			if (field_13_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_13;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_13);
                }
			}
			
			if (field_14_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_14;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_14);
                }
			}
			
			if (field_18_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_18;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_18);
                }
			}
			
			if (field_12_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_12;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_12);
                }
			}
			
			if (field_15_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_15;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_15);
                }
			}
			
			if (field_16_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_16;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_16);
                }
			}
			
			if (field_24_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_24;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_24);
                }
			}
			
			if (field_20_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_20;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_20);
                }
			}
			
			if (field_17_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Field_17;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_17);
                }
			}
			
			if (x_field_weixin_nickname_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.X_field_weixin_nickname;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X_field_weixin_nickname);
                }
			}
			
			if (x_field_weixin_gender_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.X_field_weixin_gender;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X_field_weixin_gender);
                }
			}
			
			if (x_field_weixin_country_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.X_field_weixin_country;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X_field_weixin_country);
                }
			}
			
			if (x_field_weixin_openid_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.X_field_weixin_openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X_field_weixin_openid);
                }
			}
			
			if (x_field_weixin_headimgurl_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.X_field_weixin_headimgurl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X_field_weixin_headimgurl);
                }
			}
			
			if (creator_name_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Creator_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creator_name);
                }
			}
			
			if (created_at_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Created_at;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Created_at);
                }
			}
			
			if (updated_at_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Updated_at;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Updated_at);
                }
			}
			
			if (info_remote_ip_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Info_remote_ip;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Info_remote_ip);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (form_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Form;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form);
                }
			}
			
			if (form_name_initialized)
			{
                AttributeItem attr = Jsj_entry.Attribute.Form_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form_name);
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
        public class Jsj_entryJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Serial_number { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Field_21 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Field_22 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Field_23 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_2 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Field_3 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Field_4 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_5 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_6 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_7 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_13 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_14 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_18 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_12 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_15 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_16 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_24 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Field_20 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Field_17 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string X_field_weixin_nickname { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string X_field_weixin_gender { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string X_field_weixin_country { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string X_field_weixin_openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string X_field_weixin_headimgurl { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Creator_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Created_at { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Updated_at { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Info_remote_ip { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form_name { get; set; }
        }
        #endregion
    }
}