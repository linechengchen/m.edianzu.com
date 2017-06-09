/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/4 20:37:51
  Description:    数据表Wx_pay对应的业务逻辑层Wx_pay
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Wx_pay_Entity:Wx_pay
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Out_trade_no,Total_fee,Return_code,Appid,Mch_id,Device_info,Nonce_str,Sign,Sign_type,Body,Detail,Attach,Fee_type,Spbill_create_ip,Time_start,Time_expire,Goods_tag,Notify_url,Trade_type,Limit_pay,Openid,Return_msg,Time_end,Transaction_id,Coupon_fee_n,Coupon_id_n,Coupon_type_n,Coupon_count,Coupon_fee,Cash_fee_type,Cash_fee,Settlement_total_fee,Bank_type,Is_subscribe,Err_code_des,Err_code,Result_code from Wx_pay
delete from Wx_pay
INSERT INTO Wx_pay (Id,Out_trade_no,Total_fee,Return_code,Appid,Mch_id,Device_info,Nonce_str,Sign,Sign_type,Body,Detail,Attach,Fee_type,Spbill_create_ip,Time_start,Time_expire,Goods_tag,Notify_url,Trade_type,Limit_pay,Openid,Return_msg,Time_end,Transaction_id,Coupon_fee_n,Coupon_id_n,Coupon_type_n,Coupon_count,Coupon_fee,Cash_fee_type,Cash_fee,Settlement_total_fee,Bank_type,Is_subscribe,Err_code_des,Err_code,Result_code)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Wx_pay SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Out_trade_no = valObj2.Out_trade_no;
        valObj.Total_fee = valObj2.Total_fee;
        valObj.Return_code = valObj2.Return_code;
        valObj.Appid = valObj2.Appid;
        valObj.Mch_id = valObj2.Mch_id;
        valObj.Device_info = valObj2.Device_info;
        valObj.Nonce_str = valObj2.Nonce_str;
        valObj.Sign = valObj2.Sign;
        valObj.Sign_type = valObj2.Sign_type;
        valObj.Body = valObj2.Body;
        valObj.Detail = valObj2.Detail;
        valObj.Attach = valObj2.Attach;
        valObj.Fee_type = valObj2.Fee_type;
        valObj.Spbill_create_ip = valObj2.Spbill_create_ip;
        valObj.Time_start = valObj2.Time_start;
        valObj.Time_expire = valObj2.Time_expire;
        valObj.Goods_tag = valObj2.Goods_tag;
        valObj.Notify_url = valObj2.Notify_url;
        valObj.Trade_type = valObj2.Trade_type;
        valObj.Limit_pay = valObj2.Limit_pay;
        valObj.Openid = valObj2.Openid;
        valObj.Return_msg = valObj2.Return_msg;
        valObj.Time_end = valObj2.Time_end;
        valObj.Transaction_id = valObj2.Transaction_id;
        valObj.Coupon_fee_n = valObj2.Coupon_fee_n;
        valObj.Coupon_id_n = valObj2.Coupon_id_n;
        valObj.Coupon_type_n = valObj2.Coupon_type_n;
        valObj.Coupon_count = valObj2.Coupon_count;
        valObj.Coupon_fee = valObj2.Coupon_fee;
        valObj.Cash_fee_type = valObj2.Cash_fee_type;
        valObj.Cash_fee = valObj2.Cash_fee;
        valObj.Settlement_total_fee = valObj2.Settlement_total_fee;
        valObj.Bank_type = valObj2.Bank_type;
        valObj.Is_subscribe = valObj2.Is_subscribe;
        valObj.Err_code_des = valObj2.Err_code_des;
        valObj.Err_code = valObj2.Err_code;
        valObj.Result_code = valObj2.Result_code; 
        valObj.Id = "";
        valObj.Out_trade_no = "";
        valObj.Total_fee = "";
        valObj.Return_code = "";
        valObj.Appid = "";
        valObj.Mch_id = "";
        valObj.Device_info = "";
        valObj.Nonce_str = "";
        valObj.Sign = "";
        valObj.Sign_type = "";
        valObj.Body = "";
        valObj.Detail = "";
        valObj.Attach = "";
        valObj.Fee_type = "";
        valObj.Spbill_create_ip = "";
        valObj.Time_start = "";
        valObj.Time_expire = "";
        valObj.Goods_tag = "";
        valObj.Notify_url = "";
        valObj.Trade_type = "";
        valObj.Limit_pay = "";
        valObj.Openid = "";
        valObj.Return_msg = "";
        valObj.Time_end = "";
        valObj.Transaction_id = "";
        valObj.Coupon_fee_n = "";
        valObj.Coupon_id_n = "";
        valObj.Coupon_type_n = "";
        valObj.Coupon_count = "";
        valObj.Coupon_fee = "";
        valObj.Cash_fee_type = "";
        valObj.Cash_fee = "";
        valObj.Settlement_total_fee = "";
        valObj.Bank_type = "";
        valObj.Is_subscribe = "";
        valObj.Err_code_des = "";
        valObj.Err_code = "";
        valObj.Result_code = ""; 
        "Id": $("#txt_Id").val(),
        "Out_trade_no": $("#txt_Out_trade_no").val(),
        "Total_fee": $("#txt_Total_fee").val(),
        "Return_code": $("#txt_Return_code").val(),
        "Appid": $("#txt_Appid").val(),
        "Mch_id": $("#txt_Mch_id").val(),
        "Device_info": $("#txt_Device_info").val(),
        "Nonce_str": $("#txt_Nonce_str").val(),
        "Sign": $("#txt_Sign").val(),
        "Sign_type": $("#txt_Sign_type").val(),
        "Body": $("#txt_Body").val(),
        "Detail": $("#txt_Detail").val(),
        "Attach": $("#txt_Attach").val(),
        "Fee_type": $("#txt_Fee_type").val(),
        "Spbill_create_ip": $("#txt_Spbill_create_ip").val(),
        "Time_start": $("#txt_Time_start").val(),
        "Time_expire": $("#txt_Time_expire").val(),
        "Goods_tag": $("#txt_Goods_tag").val(),
        "Notify_url": $("#txt_Notify_url").val(),
        "Trade_type": $("#txt_Trade_type").val(),
        "Limit_pay": $("#txt_Limit_pay").val(),
        "Openid": $("#txt_Openid").val(),
        "Return_msg": $("#txt_Return_msg").val(),
        "Time_end": $("#txt_Time_end").val(),
        "Transaction_id": $("#txt_Transaction_id").val(),
        "Coupon_fee_n": $("#txt_Coupon_fee_n").val(),
        "Coupon_id_n": $("#txt_Coupon_id_n").val(),
        "Coupon_type_n": $("#txt_Coupon_type_n").val(),
        "Coupon_count": $("#txt_Coupon_count").val(),
        "Coupon_fee": $("#txt_Coupon_fee").val(),
        "Cash_fee_type": $("#txt_Cash_fee_type").val(),
        "Cash_fee": $("#txt_Cash_fee").val(),
        "Settlement_total_fee": $("#txt_Settlement_total_fee").val(),
        "Bank_type": $("#txt_Bank_type").val(),
        "Is_subscribe": $("#txt_Is_subscribe").val(),
        "Err_code_des": $("#txt_Err_code_des").val(),
        "Err_code": $("#txt_Err_code").val(),
        "Result_code": $("#txt_Result_code").val(), 
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
    /// <para></para>
    /// <para>与Wx_pay数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Wx_pay : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Wx_pay Factory()
        {
            return new Wx_pay();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Out_trade_no
        {            
            get { return this.Out_trade_no; }
            set { this.Out_trade_no = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Total_fee
        {            
            get { return this.Total_fee; }
            set { this.Total_fee = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Return_code
        {            
            get { return this.Return_code; }
            set { this.Return_code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Mch_id
        {            
            get { return this.Mch_id; }
            set { this.Mch_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Device_info
        {            
            get { return this.Device_info; }
            set { this.Device_info = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Nonce_str
        {            
            get { return this.Nonce_str; }
            set { this.Nonce_str = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sign
        {            
            get { return this.Sign; }
            set { this.Sign = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sign_type
        {            
            get { return this.Sign_type; }
            set { this.Sign_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Body
        {            
            get { return this.Body; }
            set { this.Body = value; }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Detail
        {            
            get { return this.Detail; }
            set { this.Detail = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Attach
        {            
            get { return this.Attach; }
            set { this.Attach = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Fee_type
        {            
            get { return this.Fee_type; }
            set { this.Fee_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Spbill_create_ip
        {            
            get { return this.Spbill_create_ip; }
            set { this.Spbill_create_ip = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Time_start
        {            
            get { return this.Time_start; }
            set { this.Time_start = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Time_expire
        {            
            get { return this.Time_expire; }
            set { this.Time_expire = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Goods_tag
        {            
            get { return this.Goods_tag; }
            set { this.Goods_tag = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Notify_url
        {            
            get { return this.Notify_url; }
            set { this.Notify_url = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Trade_type
        {            
            get { return this.Trade_type; }
            set { this.Trade_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Limit_pay
        {            
            get { return this.Limit_pay; }
            set { this.Limit_pay = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Return_msg
        {            
            get { return this.Return_msg; }
            set { this.Return_msg = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Time_end
        {            
            get { return this.Time_end; }
            set { this.Time_end = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Transaction_id
        {            
            get { return this.Transaction_id; }
            set { this.Transaction_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Coupon_fee_n
        {            
            get { return this.Coupon_fee_n; }
            set { this.Coupon_fee_n = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Coupon_id_n
        {            
            get { return this.Coupon_id_n; }
            set { this.Coupon_id_n = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Coupon_type_n
        {            
            get { return this.Coupon_type_n; }
            set { this.Coupon_type_n = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Coupon_count
        {            
            get { return this.Coupon_count; }
            set { this.Coupon_count = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Coupon_fee
        {            
            get { return this.Coupon_fee; }
            set { this.Coupon_fee = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Cash_fee_type
        {            
            get { return this.Cash_fee_type; }
            set { this.Cash_fee_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Cash_fee
        {            
            get { return this.Cash_fee; }
            set { this.Cash_fee = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Settlement_total_fee
        {            
            get { return this.Settlement_total_fee; }
            set { this.Settlement_total_fee = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Bank_type
        {            
            get { return this.Bank_type; }
            set { this.Bank_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_subscribe
        {            
            get { return this.Is_subscribe; }
            set { this.Is_subscribe = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Err_code_des
        {            
            get { return this.Err_code_des; }
            set { this.Err_code_des = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Err_code
        {            
            get { return this.Err_code; }
            set { this.Err_code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Result_code
        {            
            get { return this.Result_code; }
            set { this.Result_code = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Out_trade_no
        {
            get { return this.m_out_trade_no; }
            set //
            {
                if (!out_trade_no_initialized || m_out_trade_no != value)
                {
                    this.m_out_trade_no = value;
                }
                out_trade_no_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Total_fee
        {
            get { return this.m_total_fee; }
            set //
            {
                if (!total_fee_initialized || m_total_fee != value)
                {
                    this.m_total_fee = value;
                }
                total_fee_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Return_code
        {
            get { return this.m_return_code; }
            set //
            {
                if (!return_code_initialized || m_return_code != value)
                {
                    this.m_return_code = value;
                }
                return_code_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Appid
        {
            get { return this.m_appid; }
            set //
            {
                if (!appid_initialized || m_appid != value)
                {
                    this.m_appid = value;
                }
                appid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Mch_id
        {
            get { return this.m_mch_id; }
            set //
            {
                if (!mch_id_initialized || m_mch_id != value)
                {
                    this.m_mch_id = value;
                }
                mch_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Device_info
        {
            get { return this.m_device_info; }
            set //
            {
                if (!device_info_initialized || m_device_info != value)
                {
                    this.m_device_info = value;
                }
                device_info_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Nonce_str
        {
            get { return this.m_nonce_str; }
            set //
            {
                if (!nonce_str_initialized || m_nonce_str != value)
                {
                    this.m_nonce_str = value;
                }
                nonce_str_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sign
        {
            get { return this.m_sign; }
            set //
            {
                if (!sign_initialized || m_sign != value)
                {
                    this.m_sign = value;
                }
                sign_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sign_type
        {
            get { return this.m_sign_type; }
            set //
            {
                if (!sign_type_initialized || m_sign_type != value)
                {
                    this.m_sign_type = value;
                }
                sign_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Body
        {
            get { return this.m_body; }
            set //
            {
                if (!body_initialized || m_body != value)
                {
                    this.m_body = value;
                }
                body_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string Detail
        {
            get { return this.m_detail; }
            set //
            {
                if (!detail_initialized || m_detail != value)
                {
                    this.m_detail = value;
                }
                detail_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Attach
        {
            get { return this.m_attach; }
            set //
            {
                if (!attach_initialized || m_attach != value)
                {
                    this.m_attach = value;
                }
                attach_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Fee_type
        {
            get { return this.m_fee_type; }
            set //
            {
                if (!fee_type_initialized || m_fee_type != value)
                {
                    this.m_fee_type = value;
                }
                fee_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Spbill_create_ip
        {
            get { return this.m_spbill_create_ip; }
            set //
            {
                if (!spbill_create_ip_initialized || m_spbill_create_ip != value)
                {
                    this.m_spbill_create_ip = value;
                }
                spbill_create_ip_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Time_start
        {
            get { return this.m_time_start; }
            set //
            {
                if (!time_start_initialized || m_time_start != value)
                {
                    this.m_time_start = value;
                }
                time_start_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Time_expire
        {
            get { return this.m_time_expire; }
            set //
            {
                if (!time_expire_initialized || m_time_expire != value)
                {
                    this.m_time_expire = value;
                }
                time_expire_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Goods_tag
        {
            get { return this.m_goods_tag; }
            set //
            {
                if (!goods_tag_initialized || m_goods_tag != value)
                {
                    this.m_goods_tag = value;
                }
                goods_tag_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Notify_url
        {
            get { return this.m_notify_url; }
            set //
            {
                if (!notify_url_initialized || m_notify_url != value)
                {
                    this.m_notify_url = value;
                }
                notify_url_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Trade_type
        {
            get { return this.m_trade_type; }
            set //
            {
                if (!trade_type_initialized || m_trade_type != value)
                {
                    this.m_trade_type = value;
                }
                trade_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Limit_pay
        {
            get { return this.m_limit_pay; }
            set //
            {
                if (!limit_pay_initialized || m_limit_pay != value)
                {
                    this.m_limit_pay = value;
                }
                limit_pay_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Openid
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Return_msg
        {
            get { return this.m_return_msg; }
            set //
            {
                if (!return_msg_initialized || m_return_msg != value)
                {
                    this.m_return_msg = value;
                }
                return_msg_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Time_end
        {
            get { return this.m_time_end; }
            set //
            {
                if (!time_end_initialized || m_time_end != value)
                {
                    this.m_time_end = value;
                }
                time_end_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Transaction_id
        {
            get { return this.m_transaction_id; }
            set //
            {
                if (!transaction_id_initialized || m_transaction_id != value)
                {
                    this.m_transaction_id = value;
                }
                transaction_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Coupon_fee_n
        {
            get { return this.m_coupon_fee_n; }
            set //
            {
                if (!coupon_fee_n_initialized || m_coupon_fee_n != value)
                {
                    this.m_coupon_fee_n = value;
                }
                coupon_fee_n_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Coupon_id_n
        {
            get { return this.m_coupon_id_n; }
            set //
            {
                if (!coupon_id_n_initialized || m_coupon_id_n != value)
                {
                    this.m_coupon_id_n = value;
                }
                coupon_id_n_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Coupon_type_n
        {
            get { return this.m_coupon_type_n; }
            set //
            {
                if (!coupon_type_n_initialized || m_coupon_type_n != value)
                {
                    this.m_coupon_type_n = value;
                }
                coupon_type_n_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Coupon_count
        {
            get { return this.m_coupon_count; }
            set //
            {
                if (!coupon_count_initialized || m_coupon_count != value)
                {
                    this.m_coupon_count = value;
                }
                coupon_count_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Coupon_fee
        {
            get { return this.m_coupon_fee; }
            set //
            {
                if (!coupon_fee_initialized || m_coupon_fee != value)
                {
                    this.m_coupon_fee = value;
                }
                coupon_fee_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Cash_fee_type
        {
            get { return this.m_cash_fee_type; }
            set //
            {
                if (!cash_fee_type_initialized || m_cash_fee_type != value)
                {
                    this.m_cash_fee_type = value;
                }
                cash_fee_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Cash_fee
        {
            get { return this.m_cash_fee; }
            set //
            {
                if (!cash_fee_initialized || m_cash_fee != value)
                {
                    this.m_cash_fee = value;
                }
                cash_fee_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Settlement_total_fee
        {
            get { return this.m_settlement_total_fee; }
            set //
            {
                if (!settlement_total_fee_initialized || m_settlement_total_fee != value)
                {
                    this.m_settlement_total_fee = value;
                }
                settlement_total_fee_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Bank_type
        {
            get { return this.m_bank_type; }
            set //
            {
                if (!bank_type_initialized || m_bank_type != value)
                {
                    this.m_bank_type = value;
                }
                bank_type_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_subscribe
        {
            get { return this.m_is_subscribe; }
            set //
            {
                if (!is_subscribe_initialized || m_is_subscribe != value)
                {
                    this.m_is_subscribe = value;
                }
                is_subscribe_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Err_code_des
        {
            get { return this.m_err_code_des; }
            set //
            {
                if (!err_code_des_initialized || m_err_code_des != value)
                {
                    this.m_err_code_des = value;
                }
                err_code_des_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Err_code
        {
            get { return this.m_err_code; }
            set //
            {
                if (!err_code_initialized || m_err_code != value)
                {
                    this.m_err_code = value;
                }
                err_code_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Result_code
        {
            get { return this.m_result_code; }
            set //
            {
                if (!result_code_initialized || m_result_code != value)
                {
                    this.m_result_code = value;
                }
                result_code_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Wx_pay].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Out_trade_no =  new AttributeItem("[Wx_pay].[Out_trade_no]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Total_fee =  new AttributeItem("[Wx_pay].[Total_fee]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Return_code =  new AttributeItem("[Wx_pay].[Return_code]", typeof(string), 10, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Appid =  new AttributeItem("[Wx_pay].[Appid]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mch_id =  new AttributeItem("[Wx_pay].[Mch_id]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Device_info =  new AttributeItem("[Wx_pay].[Device_info]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Nonce_str =  new AttributeItem("[Wx_pay].[Nonce_str]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sign =  new AttributeItem("[Wx_pay].[Sign]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sign_type =  new AttributeItem("[Wx_pay].[Sign_type]", typeof(string), 128, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Body =  new AttributeItem("[Wx_pay].[Body]", typeof(string), 128, default(string));
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Detail =  new AttributeItem("[Wx_pay].[Detail]", typeof(string), 6000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Attach =  new AttributeItem("[Wx_pay].[Attach]", typeof(string), 127, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Fee_type =  new AttributeItem("[Wx_pay].[Fee_type]", typeof(string), 16, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Spbill_create_ip =  new AttributeItem("[Wx_pay].[Spbill_create_ip]", typeof(string), 16, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Time_start =  new AttributeItem("[Wx_pay].[Time_start]", typeof(string), 14, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Time_expire =  new AttributeItem("[Wx_pay].[Time_expire]", typeof(string), 14, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Goods_tag =  new AttributeItem("[Wx_pay].[Goods_tag]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Notify_url =  new AttributeItem("[Wx_pay].[Notify_url]", typeof(string), 256, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Trade_type =  new AttributeItem("[Wx_pay].[Trade_type]", typeof(string), 16, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Limit_pay =  new AttributeItem("[Wx_pay].[Limit_pay]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[Wx_pay].[Openid]", typeof(string), 128, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Return_msg =  new AttributeItem("[Wx_pay].[Return_msg]", typeof(string), 128, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Time_end =  new AttributeItem("[Wx_pay].[Time_end]", typeof(string), 14, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Transaction_id =  new AttributeItem("[Wx_pay].[Transaction_id]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Coupon_fee_n =  new AttributeItem("[Wx_pay].[Coupon_fee_n]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Coupon_id_n =  new AttributeItem("[Wx_pay].[Coupon_id_n]", typeof(string), 20, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Coupon_type_n =  new AttributeItem("[Wx_pay].[Coupon_type_n]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Coupon_count =  new AttributeItem("[Wx_pay].[Coupon_count]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Coupon_fee =  new AttributeItem("[Wx_pay].[Coupon_fee]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Cash_fee_type =  new AttributeItem("[Wx_pay].[Cash_fee_type]", typeof(string), 16, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Cash_fee =  new AttributeItem("[Wx_pay].[Cash_fee]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Settlement_total_fee =  new AttributeItem("[Wx_pay].[Settlement_total_fee]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Bank_type =  new AttributeItem("[Wx_pay].[Bank_type]", typeof(string), 16, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_subscribe =  new AttributeItem("[Wx_pay].[Is_subscribe]", typeof(string), 1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Err_code_des =  new AttributeItem("[Wx_pay].[Err_code_des]", typeof(string), 128, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Err_code =  new AttributeItem("[Wx_pay].[Err_code]", typeof(string), 32, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Result_code =  new AttributeItem("[Wx_pay].[Result_code]", typeof(string), 16, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_out_trade_no;
        /// <summary></summary>
        protected bool out_trade_no_initialized = false;
        
        private int m_total_fee;
        /// <summary></summary>
        protected bool total_fee_initialized = false;
        
        private string m_return_code;
        /// <summary></summary>
        protected bool return_code_initialized = false;
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private string m_mch_id;
        /// <summary></summary>
        protected bool mch_id_initialized = false;
        
        private string m_device_info;
        /// <summary></summary>
        protected bool device_info_initialized = false;
        
        private string m_nonce_str;
        /// <summary></summary>
        protected bool nonce_str_initialized = false;
        
        private string m_sign;
        /// <summary></summary>
        protected bool sign_initialized = false;
        
        private string m_sign_type;
        /// <summary></summary>
        protected bool sign_type_initialized = false;
        
        private string m_body;
        /// <summary></summary>
        protected bool body_initialized = false;
        
        private string m_detail;
        /// <summary></summary>
        protected bool detail_initialized = false;
        
        private string m_attach;
        /// <summary></summary>
        protected bool attach_initialized = false;
        
        private string m_fee_type;
        /// <summary></summary>
        protected bool fee_type_initialized = false;
        
        private string m_spbill_create_ip;
        /// <summary></summary>
        protected bool spbill_create_ip_initialized = false;
        
        private string m_time_start;
        /// <summary></summary>
        protected bool time_start_initialized = false;
        
        private string m_time_expire;
        /// <summary></summary>
        protected bool time_expire_initialized = false;
        
        private string m_goods_tag;
        /// <summary></summary>
        protected bool goods_tag_initialized = false;
        
        private string m_notify_url;
        /// <summary></summary>
        protected bool notify_url_initialized = false;
        
        private string m_trade_type;
        /// <summary></summary>
        protected bool trade_type_initialized = false;
        
        private string m_limit_pay;
        /// <summary></summary>
        protected bool limit_pay_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_return_msg;
        /// <summary></summary>
        protected bool return_msg_initialized = false;
        
        private string m_time_end;
        /// <summary></summary>
        protected bool time_end_initialized = false;
        
        private string m_transaction_id;
        /// <summary></summary>
        protected bool transaction_id_initialized = false;
        
        private int m_coupon_fee_n;
        /// <summary></summary>
        protected bool coupon_fee_n_initialized = false;
        
        private string m_coupon_id_n;
        /// <summary></summary>
        protected bool coupon_id_n_initialized = false;
        
        private int m_coupon_type_n;
        /// <summary></summary>
        protected bool coupon_type_n_initialized = false;
        
        private int m_coupon_count;
        /// <summary></summary>
        protected bool coupon_count_initialized = false;
        
        private int m_coupon_fee;
        /// <summary></summary>
        protected bool coupon_fee_initialized = false;
        
        private string m_cash_fee_type;
        /// <summary></summary>
        protected bool cash_fee_type_initialized = false;
        
        private int m_cash_fee;
        /// <summary></summary>
        protected bool cash_fee_initialized = false;
        
        private int m_settlement_total_fee;
        /// <summary></summary>
        protected bool settlement_total_fee_initialized = false;
        
        private string m_bank_type;
        /// <summary></summary>
        protected bool bank_type_initialized = false;
        
        private string m_is_subscribe;
        /// <summary></summary>
        protected bool is_subscribe_initialized = false;
        
        private string m_err_code_des;
        /// <summary></summary>
        protected bool err_code_des_initialized = false;
        
        private string m_err_code;
        /// <summary></summary>
        protected bool err_code_initialized = false;
        
        private string m_result_code;
        /// <summary></summary>
        protected bool result_code_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Wx_pay";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.out_trade_no_initialized = IsLoadAllAttributes;this.total_fee_initialized = IsLoadAllAttributes;this.return_code_initialized = IsLoadAllAttributes;this.appid_initialized = IsLoadAllAttributes;this.mch_id_initialized = IsLoadAllAttributes;this.device_info_initialized = IsLoadAllAttributes;this.nonce_str_initialized = IsLoadAllAttributes;this.sign_initialized = IsLoadAllAttributes;this.sign_type_initialized = IsLoadAllAttributes;this.body_initialized = IsLoadAllAttributes;this.detail_initialized = IsLoadAllAttributes;this.attach_initialized = IsLoadAllAttributes;this.fee_type_initialized = IsLoadAllAttributes;this.spbill_create_ip_initialized = IsLoadAllAttributes;this.time_start_initialized = IsLoadAllAttributes;this.time_expire_initialized = IsLoadAllAttributes;this.goods_tag_initialized = IsLoadAllAttributes;this.notify_url_initialized = IsLoadAllAttributes;this.trade_type_initialized = IsLoadAllAttributes;this.limit_pay_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.return_msg_initialized = IsLoadAllAttributes;this.time_end_initialized = IsLoadAllAttributes;this.transaction_id_initialized = IsLoadAllAttributes;this.coupon_fee_n_initialized = IsLoadAllAttributes;this.coupon_id_n_initialized = IsLoadAllAttributes;this.coupon_type_n_initialized = IsLoadAllAttributes;this.coupon_count_initialized = IsLoadAllAttributes;this.coupon_fee_initialized = IsLoadAllAttributes;this.cash_fee_type_initialized = IsLoadAllAttributes;this.cash_fee_initialized = IsLoadAllAttributes;this.settlement_total_fee_initialized = IsLoadAllAttributes;this.bank_type_initialized = IsLoadAllAttributes;this.is_subscribe_initialized = IsLoadAllAttributes;this.err_code_des_initialized = IsLoadAllAttributes;this.err_code_initialized = IsLoadAllAttributes;this.result_code_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema() 
		{ 
			Wx_pay value = new Wx_pay();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Out_trade_no"))
				value.out_trade_no_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_fee"))
				value.total_fee_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Return_code"))
				value.return_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mch_id"))
				value.mch_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Device_info"))
				value.device_info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nonce_str"))
				value.nonce_str_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign"))
				value.sign_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign_type"))
				value.sign_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Body"))
				value.body_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Detail"))
				value.detail_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Attach"))
				value.attach_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fee_type"))
				value.fee_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Spbill_create_ip"))
				value.spbill_create_ip_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_start"))
				value.time_start_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_expire"))
				value.time_expire_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_tag"))
				value.goods_tag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notify_url"))
				value.notify_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Trade_type"))
				value.trade_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Limit_pay"))
				value.limit_pay_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Return_msg"))
				value.return_msg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_end"))
				value.time_end_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Transaction_id"))
				value.transaction_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Coupon_fee_n"))
				value.coupon_fee_n_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Coupon_id_n"))
				value.coupon_id_n_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Coupon_type_n"))
				value.coupon_type_n_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Coupon_count"))
				value.coupon_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Coupon_fee"))
				value.coupon_fee_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Cash_fee_type"))
				value.cash_fee_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Cash_fee"))
				value.cash_fee_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Settlement_total_fee"))
				value.settlement_total_fee_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Bank_type"))
				value.bank_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_subscribe"))
				value.is_subscribe_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Err_code_des"))
				value.err_code_des_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Err_code"))
				value.err_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Result_code"))
				value.result_code_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Wx_pay Clone()
        {
            return (Wx_pay)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Wx_pay()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Wx_pay() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Wx_pay(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Wx_pay(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Wx_pay(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Wx_pay(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Wx_pay(int id1, string out_trade_no1, int total_fee1, string return_code1, string appid1, string mch_id1, string device_info1, string nonce_str1, string sign1, string sign_type1, string body1, string detail1, string attach1, string fee_type1, string spbill_create_ip1, string time_start1, string time_expire1, string goods_tag1, string notify_url1, string trade_type1, string limit_pay1, string openid1, string return_msg1, string time_end1, string transaction_id1, int coupon_fee_n1, string coupon_id_n1, int coupon_type_n1, int coupon_count1, int coupon_fee1, string cash_fee_type1, int cash_fee1, int settlement_total_fee1, string bank_type1, string is_subscribe1, string err_code_des1, string err_code1, string result_code1)
        {
            
            this.Id = id1;
            
            this.Out_trade_no = out_trade_no1;
            
            this.Total_fee = total_fee1;
            
            this.Return_code = return_code1;
            
            this.Appid = appid1;
            
            this.Mch_id = mch_id1;
            
            this.Device_info = device_info1;
            
            this.Nonce_str = nonce_str1;
            
            this.Sign = sign1;
            
            this.Sign_type = sign_type1;
            
            this.Body = body1;
            
            this.Detail = detail1;
            
            this.Attach = attach1;
            
            this.Fee_type = fee_type1;
            
            this.Spbill_create_ip = spbill_create_ip1;
            
            this.Time_start = time_start1;
            
            this.Time_expire = time_expire1;
            
            this.Goods_tag = goods_tag1;
            
            this.Notify_url = notify_url1;
            
            this.Trade_type = trade_type1;
            
            this.Limit_pay = limit_pay1;
            
            this.Openid = openid1;
            
            this.Return_msg = return_msg1;
            
            this.Time_end = time_end1;
            
            this.Transaction_id = transaction_id1;
            
            this.Coupon_fee_n = coupon_fee_n1;
            
            this.Coupon_id_n = coupon_id_n1;
            
            this.Coupon_type_n = coupon_type_n1;
            
            this.Coupon_count = coupon_count1;
            
            this.Coupon_fee = coupon_fee1;
            
            this.Cash_fee_type = cash_fee_type1;
            
            this.Cash_fee = cash_fee1;
            
            this.Settlement_total_fee = settlement_total_fee1;
            
            this.Bank_type = bank_type1;
            
            this.Is_subscribe = is_subscribe1;
            
            this.Err_code_des = err_code_des1;
            
            this.Err_code = err_code1;
            
            this.Result_code = result_code1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Wx_pay FromIView(IView view)
        {
            return (Wx_pay)IView.GetITable(view, "Wx_pay");
        }
        /// <summary>获得一个实例  </summary>
        public static Wx_pay GetOneInstance()
        {
            Wx_pay value = new Wx_pay();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Wx_pay Retrieve()
        {
            BLLTable<Wx_pay>.GetRowData(this);
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
			    			
			    case "Out_trade_no":
			        return Out_trade_no;
			    			
			    case "Total_fee":
			        return Total_fee;
			    			
			    case "Return_code":
			        return Return_code;
			    			
			    case "Appid":
			        return Appid;
			    			
			    case "Mch_id":
			        return Mch_id;
			    			
			    case "Device_info":
			        return Device_info;
			    			
			    case "Nonce_str":
			        return Nonce_str;
			    			
			    case "Sign":
			        return Sign;
			    			
			    case "Sign_type":
			        return Sign_type;
			    			
			    case "Body":
			        return Body;
			    			
			    case "Detail":
			        return Detail;
			    			
			    case "Attach":
			        return Attach;
			    			
			    case "Fee_type":
			        return Fee_type;
			    			
			    case "Spbill_create_ip":
			        return Spbill_create_ip;
			    			
			    case "Time_start":
			        return Time_start;
			    			
			    case "Time_expire":
			        return Time_expire;
			    			
			    case "Goods_tag":
			        return Goods_tag;
			    			
			    case "Notify_url":
			        return Notify_url;
			    			
			    case "Trade_type":
			        return Trade_type;
			    			
			    case "Limit_pay":
			        return Limit_pay;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Return_msg":
			        return Return_msg;
			    			
			    case "Time_end":
			        return Time_end;
			    			
			    case "Transaction_id":
			        return Transaction_id;
			    			
			    case "Coupon_fee_n":
			        return Coupon_fee_n;
			    			
			    case "Coupon_id_n":
			        return Coupon_id_n;
			    			
			    case "Coupon_type_n":
			        return Coupon_type_n;
			    			
			    case "Coupon_count":
			        return Coupon_count;
			    			
			    case "Coupon_fee":
			        return Coupon_fee;
			    			
			    case "Cash_fee_type":
			        return Cash_fee_type;
			    			
			    case "Cash_fee":
			        return Cash_fee;
			    			
			    case "Settlement_total_fee":
			        return Settlement_total_fee;
			    			
			    case "Bank_type":
			        return Bank_type;
			    			
			    case "Is_subscribe":
			        return Is_subscribe;
			    			
			    case "Err_code_des":
			        return Err_code_des;
			    			
			    case "Err_code":
			        return Err_code;
			    			
			    case "Result_code":
			        return Result_code;
			
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
			    			
			    case "Out_trade_no":
			        this.Out_trade_no = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Total_fee":
			        this.Total_fee = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Return_code":
			        this.Return_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mch_id":
			        this.Mch_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Device_info":
			        this.Device_info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Nonce_str":
			        this.Nonce_str = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sign":
			        this.Sign = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sign_type":
			        this.Sign_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Body":
			        this.Body = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Detail":
			        this.Detail = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Attach":
			        this.Attach = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Fee_type":
			        this.Fee_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Spbill_create_ip":
			        this.Spbill_create_ip = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time_start":
			        this.Time_start = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time_expire":
			        this.Time_expire = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Goods_tag":
			        this.Goods_tag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Notify_url":
			        this.Notify_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Trade_type":
			        this.Trade_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Limit_pay":
			        this.Limit_pay = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Return_msg":
			        this.Return_msg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time_end":
			        this.Time_end = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Transaction_id":
			        this.Transaction_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Coupon_fee_n":
			        this.Coupon_fee_n = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Coupon_id_n":
			        this.Coupon_id_n = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Coupon_type_n":
			        this.Coupon_type_n = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Coupon_count":
			        this.Coupon_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Coupon_fee":
			        this.Coupon_fee = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Cash_fee_type":
			        this.Cash_fee_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Cash_fee":
			        this.Cash_fee = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Settlement_total_fee":
			        this.Settlement_total_fee = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Bank_type":
			        this.Bank_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_subscribe":
			        this.Is_subscribe = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Err_code_des":
			        this.Err_code_des = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Err_code":
			        this.Err_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Result_code":
			        this.Result_code = Convert.ToString(AttributeValue);
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
				
				case "Out_trade_no":
					return out_trade_no_initialized;
				
				case "Total_fee":
					return total_fee_initialized;
				
				case "Return_code":
					return return_code_initialized;
				
				case "Appid":
					return appid_initialized;
				
				case "Mch_id":
					return mch_id_initialized;
				
				case "Device_info":
					return device_info_initialized;
				
				case "Nonce_str":
					return nonce_str_initialized;
				
				case "Sign":
					return sign_initialized;
				
				case "Sign_type":
					return sign_type_initialized;
				
				case "Body":
					return body_initialized;
				
				case "Detail":
					return detail_initialized;
				
				case "Attach":
					return attach_initialized;
				
				case "Fee_type":
					return fee_type_initialized;
				
				case "Spbill_create_ip":
					return spbill_create_ip_initialized;
				
				case "Time_start":
					return time_start_initialized;
				
				case "Time_expire":
					return time_expire_initialized;
				
				case "Goods_tag":
					return goods_tag_initialized;
				
				case "Notify_url":
					return notify_url_initialized;
				
				case "Trade_type":
					return trade_type_initialized;
				
				case "Limit_pay":
					return limit_pay_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Return_msg":
					return return_msg_initialized;
				
				case "Time_end":
					return time_end_initialized;
				
				case "Transaction_id":
					return transaction_id_initialized;
				
				case "Coupon_fee_n":
					return coupon_fee_n_initialized;
				
				case "Coupon_id_n":
					return coupon_id_n_initialized;
				
				case "Coupon_type_n":
					return coupon_type_n_initialized;
				
				case "Coupon_count":
					return coupon_count_initialized;
				
				case "Coupon_fee":
					return coupon_fee_initialized;
				
				case "Cash_fee_type":
					return cash_fee_type_initialized;
				
				case "Cash_fee":
					return cash_fee_initialized;
				
				case "Settlement_total_fee":
					return settlement_total_fee_initialized;
				
				case "Bank_type":
					return bank_type_initialized;
				
				case "Is_subscribe":
					return is_subscribe_initialized;
				
				case "Err_code_des":
					return err_code_des_initialized;
				
				case "Err_code":
					return err_code_initialized;
				
				case "Result_code":
					return result_code_initialized;
				
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
				
				case "Out_trade_no":
					out_trade_no_initialized = ret;
					return true;
				
				case "Total_fee":
					total_fee_initialized = ret;
					return true;
				
				case "Return_code":
					return_code_initialized = ret;
					return true;
				
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "Mch_id":
					mch_id_initialized = ret;
					return true;
				
				case "Device_info":
					device_info_initialized = ret;
					return true;
				
				case "Nonce_str":
					nonce_str_initialized = ret;
					return true;
				
				case "Sign":
					sign_initialized = ret;
					return true;
				
				case "Sign_type":
					sign_type_initialized = ret;
					return true;
				
				case "Body":
					body_initialized = ret;
					return true;
				
				case "Detail":
					detail_initialized = ret;
					return true;
				
				case "Attach":
					attach_initialized = ret;
					return true;
				
				case "Fee_type":
					fee_type_initialized = ret;
					return true;
				
				case "Spbill_create_ip":
					spbill_create_ip_initialized = ret;
					return true;
				
				case "Time_start":
					time_start_initialized = ret;
					return true;
				
				case "Time_expire":
					time_expire_initialized = ret;
					return true;
				
				case "Goods_tag":
					goods_tag_initialized = ret;
					return true;
				
				case "Notify_url":
					notify_url_initialized = ret;
					return true;
				
				case "Trade_type":
					trade_type_initialized = ret;
					return true;
				
				case "Limit_pay":
					limit_pay_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Return_msg":
					return_msg_initialized = ret;
					return true;
				
				case "Time_end":
					time_end_initialized = ret;
					return true;
				
				case "Transaction_id":
					transaction_id_initialized = ret;
					return true;
				
				case "Coupon_fee_n":
					coupon_fee_n_initialized = ret;
					return true;
				
				case "Coupon_id_n":
					coupon_id_n_initialized = ret;
					return true;
				
				case "Coupon_type_n":
					coupon_type_n_initialized = ret;
					return true;
				
				case "Coupon_count":
					coupon_count_initialized = ret;
					return true;
				
				case "Coupon_fee":
					coupon_fee_initialized = ret;
					return true;
				
				case "Cash_fee_type":
					cash_fee_type_initialized = ret;
					return true;
				
				case "Cash_fee":
					cash_fee_initialized = ret;
					return true;
				
				case "Settlement_total_fee":
					settlement_total_fee_initialized = ret;
					return true;
				
				case "Bank_type":
					bank_type_initialized = ret;
					return true;
				
				case "Is_subscribe":
					is_subscribe_initialized = ret;
					return true;
				
				case "Err_code_des":
					err_code_des_initialized = ret;
					return true;
				
				case "Err_code":
					err_code_initialized = ret;
					return true;
				
				case "Result_code":
					result_code_initialized = ret;
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
                AttributeItem attr = Wx_pay.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (out_trade_no_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Out_trade_no;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Out_trade_no);
                }
			}
			
			if (total_fee_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Total_fee;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_fee);
                }
			}
			
			if (return_code_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Return_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Return_code);
                }
			}
			
			if (appid_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (mch_id_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Mch_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mch_id);
                }
			}
			
			if (device_info_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Device_info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Device_info);
                }
			}
			
			if (nonce_str_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Nonce_str;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nonce_str);
                }
			}
			
			if (sign_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Sign;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign);
                }
			}
			
			if (sign_type_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Sign_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign_type);
                }
			}
			
			if (body_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Body;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Body);
                }
			}
			
			if (detail_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Detail;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Detail);
                }
			}
			
			if (attach_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Attach;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Attach);
                }
			}
			
			if (fee_type_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Fee_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fee_type);
                }
			}
			
			if (spbill_create_ip_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Spbill_create_ip;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Spbill_create_ip);
                }
			}
			
			if (time_start_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Time_start;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_start);
                }
			}
			
			if (time_expire_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Time_expire;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_expire);
                }
			}
			
			if (goods_tag_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Goods_tag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_tag);
                }
			}
			
			if (notify_url_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Notify_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notify_url);
                }
			}
			
			if (trade_type_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Trade_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Trade_type);
                }
			}
			
			if (limit_pay_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Limit_pay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Limit_pay);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (return_msg_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Return_msg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Return_msg);
                }
			}
			
			if (time_end_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Time_end;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_end);
                }
			}
			
			if (transaction_id_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Transaction_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Transaction_id);
                }
			}
			
			if (coupon_fee_n_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Coupon_fee_n;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Coupon_fee_n);
                }
			}
			
			if (coupon_id_n_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Coupon_id_n;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Coupon_id_n);
                }
			}
			
			if (coupon_type_n_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Coupon_type_n;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Coupon_type_n);
                }
			}
			
			if (coupon_count_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Coupon_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Coupon_count);
                }
			}
			
			if (coupon_fee_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Coupon_fee;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Coupon_fee);
                }
			}
			
			if (cash_fee_type_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Cash_fee_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Cash_fee_type);
                }
			}
			
			if (cash_fee_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Cash_fee;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Cash_fee);
                }
			}
			
			if (settlement_total_fee_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Settlement_total_fee;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Settlement_total_fee);
                }
			}
			
			if (bank_type_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Bank_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Bank_type);
                }
			}
			
			if (is_subscribe_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Is_subscribe;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_subscribe);
                }
			}
			
			if (err_code_des_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Err_code_des;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Err_code_des);
                }
			}
			
			if (err_code_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Err_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Err_code);
                }
			}
			
			if (result_code_initialized)
			{
                AttributeItem attr = Wx_pay.Attribute.Result_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Result_code);
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
        public class Wx_payJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Out_trade_no { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Total_fee { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Return_code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Appid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Mch_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Device_info { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Nonce_str { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sign { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sign_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Body { get; set; }
            
            /// <summary>[CtrlTypeDic-{HTML}]</summary>
            public string Detail { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Attach { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Fee_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Spbill_create_ip { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Time_start { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Time_expire { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Goods_tag { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Notify_url { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Trade_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Limit_pay { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Return_msg { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Time_end { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Transaction_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Coupon_fee_n { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Coupon_id_n { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Coupon_type_n { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Coupon_count { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Coupon_fee { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Cash_fee_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Cash_fee { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Settlement_total_fee { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Bank_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Is_subscribe { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Err_code_des { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Err_code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Result_code { get; set; }
        }
        #endregion
    }
}