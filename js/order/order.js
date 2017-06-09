/**
 * @author liuguoqing@edianzu.cn
 * 订单确认
 */
var errorMsg = '网络异常，请重试！';
var Order = {
	
	divArray : new Array('order_div','address_list_div','address_modify_div','coupon_div'),
	
	showElement : function ( showDivId ){
		 
		 $.each(Order.divArray, function() {
		  	if( showDivId == this ){
		 		$("#"+this).show();
		 	}else{
		 		$("#"+this).hide();
		 	}
		 }); 
	},
	
	/**
	 * 提交订单(☆_☆)/~~
	 * @param obj
	 */
	submitOrder : function( obj ){
		
		$(obj).attr('disabled',true);
		
		if( !Utils.isLogin_ing() ){
			$(obj).removeAttr("disabled");
			window.location = 'login';
		}
		
		//商品集合
		var arrayParam = new Array();
		$('.cartsId').each(function(index,element){
			var id = $(element).val();
			var obj = new Object();
			obj.cartId = id;
			obj.productId = $(element).attr('data_pid');
			obj.rentType = $('#rentType_'+id).val();
			obj.month = $('#month_'+id).val();
			obj.startDate = $('#startDate_'+id).val();
			obj.num = $('#num_'+id).val();
			obj.isSale = $('#isSale_'+id).val();
			obj.insuranceTypeId = $('#insuranceTypeId_'+id).val();
			obj.serviceId = $('#serviceId_'+id).val();
			obj.rentTypeId = $('#monthRentLabel'+id).attr('rentType');
			arrayParam.push( obj );
		});
		
		if( arrayParam.length <1 ){
			alert('商品信息缺失，请刷新重试！');
			$(obj).removeAttr("disabled");
			return;
		}
		
		//所选地址
		var customerAddressId = $('#default_Info').attr('data_id');
		
		if( Utils.isUndefined(customerAddressId) || Utils.isNull(customerAddressId) ){
			alert('请选择配送地址！');
			location.hash="#navBarCustomerAddress"; 
			$(obj).removeAttr("disabled");
			return;
		}
		
		//是否使用了余额
		var balance = '0';
		if( Order.isUsedBalance() ){
			var balance = $('.js_info_ye').text();
			if( Utils.isNotNull(balance) && balance.length>1){
				balance = balance.substring(1,balance.length);
			}
		}
		
		//买家留言
		var userRemark = $('#user_remark').val();
		if( Order.lenFor(userRemark) >200 ){
			alert('买家留言不能超出200个字符！');
			$('#user_remark').focus();
			$(obj).removeAttr("disabled");
			return;
		}
		
		//支付方式
		var paymentType = $("input[name='paymentType']:checked").val();
		if( Utils.isUndefined(paymentType) ){
			alert('请选择支付方式！');
			//location.hash="#navBarPaymentType"; 
			$(obj).removeAttr("disabled");
			return;
		}
		
		//优惠券信息
		var couponId = Order.getCouponData().couponId;
		
		var url = 'orders/createOrders';
		var data = {
			'source':2,
			'orderCreateModels':JSON.stringify( arrayParam ),
			'customerAddressId':customerAddressId,
			'paymentType':paymentType,
			'balance':balance, 
			'userRemark':userRemark,
			'couponId':couponId,
			'timestamp':Utils.getTimeStamp()
		};
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			
			if (response.code == 0) {
				
				alert('提交订单成功');
				
				var result = response.data;
				if( result.paymentType == 3 ) {
					window.location = 'order_detail?mainOrderId='+result.mainOrderId;
				}else if( result.isPayedAll ){
					window.location = 'orderPayedSuccess?payedAmount='+result.payedAmount;
				}else{
					window.location = 'orderPay?orderId='+result.mainOrderId;
				}
				
			}else{
				$(obj).removeAttr("disabled");
				alert(response.message);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			$(obj).removeAttr("disabled");
			alert(errorMsg);
		});
	},
	
	lenFor : function(str){
	    var byteLen=0,len=str.length;
	    if(str){
	        for(var i=0; i<len; i++){
	            if(str.charCodeAt(i)>255){
	                byteLen += 2;
	            }else{
	                byteLen++;
	            }
	        }
	        return byteLen/2;
	    }else{
	        return 0;
	    }
	}, 
	
	//加载省级数据
	initProvinceData : function(){
		
		var url = 'manager/queryAllProvince';
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				var provinceHtml = '<option value="">请选择</option>';
				$( response.data ).each(function(index,vo){
					provinceHtml += '<option value="' + vo.id + '">' + vo.name + '</option>';
				});
				$("#province_data").html( provinceHtml );
				$("#bcity_data").html('<option value="">请选择</option>');
				$("#scity_data").html('<option value="">请选择</option>');
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	},
	
	/**
	 * 获得选中优惠券的ID 和 满减价格
	 * @returns {Object}
	 */
	getCouponData : function(){
		
		var obj = new Object();
		obj.couponId =  '';
		obj.couponPrice = 0;
		
		$('.availableCouponCB').each(function(){
			if( $(this).prop('checked') ){
				var id = $(this).val();
				obj.couponId = id;
				obj.couponPrice = $('#disJian_'+id).val();
			}
		});
		return obj;
	},
	
	/**
	 * 是否使用了账户余额
	 */
	isUsedBalance : function(){
		return $('#used_balance').prop('checked');
	},
	
	/**
	 * 加载市级数据
	 * @param pId
	 */
	initBcityData : function( pId ){
		
		var $T = $(this);
		var url = Utils.setTimeStamp('manager/queryBcitys?pid='+pId);
		var data = null;
		
		$("#bcity_data").empty().html('<option value="">请选择</option>');
		$("#scity_data").empty().html('<option value="">请选择</option>');
		
		if( Utils.isNull(pId) ){
			return;
		}
			
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				var bCityHtml = '<option value="">请选择</option>';
				$( response.data ).each(function(index,vo){
					bCityHtml += '<option value="' + vo.id + '">' + vo.name + '</option>';
				});
				$("#bcity_data").html( bCityHtml );
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	},
	
	/**
	 * 加载县级数据
	 * @param pId
	 */
	initScityData : function( pId ){
		
		$("#scity_data").empty().html('<option value="">请选择</option>');
		var url = Utils.setTimeStamp('manager/queryScitys?pid='+pId);
		var data = null;
		
		if( Utils.isNull(pId) ){
			return;
		}
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				var sCityHtml = '<option value="">请选择</option>';
				$( response.data ).each(function(index,vo){
					sCityHtml += '<option value="' + vo.id + '">' + vo.name + '</option>';
				});
				$("#scity_data").html( sCityHtml );
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	},
	
	/**
	 * 执行客户配货地址删除
	 * @param id
	 */
	doDelAddress : function(id){
		
		var url = Utils.setTimeStamp('customer/removeCustomerAddress?id='+id);
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				$('#address_rows_'+id).remove();
				Order.hideConfirm();
				alert('删除成功！');
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	},
	
	/**
	 * 初始化配送地址修改完成后的相关数据
	 * @param name
	 * @param provinceId
	 * @param address
	 * @param phone
	 * @param isDefault
	 */
	setAfterEditData : function(id,name,pbsText,address,phone,isDefault){
		
		var $rows = $('#address_rows_'+id);
		$rows.find('.consignee_name').text(name);
		$rows.find('.consignee_phone').text(phone);
		$rows.find('.province').text(pbsText+address);
		//$rows.find('.consignee_address').text(address);
	},
	
	/**
	 * 初始化配送地址添加完成后的相关数据
	 * @param resultId
	 * @param name
	 * @param provinceId
	 * @param address
	 * @param phone
	 * @param isDefault
	 */
	setAfterAddData : function(resultId,name,pbsText,address,phone){
		
		/*var html = '<dl class="ps_dz clearfix" style="display: block;" id="address_rows_'+resultId+'">'+
						'<dt class="fl">'+
							'<span class="consignee_name_tit">'+name+'</span> <label></label>'+
						'</dt>'+
						'<dd class="fl">'+
							'<span class="consignee_name_cont">'+name+'</span> '+
							'<span class="province">'+pbsText+'</span> '+
							'<span class="consignee_address">'+address+'</span>'+
							'<span class="consignee_phone">'+phone+'</span> '+
								'<span class="mor_dz"></span>'+
							'<div class="zt">'+
								'<span class="shewei_dz set_default" data_id="'+resultId+'">设为默认地址</span> '+
								'<span class="address_edit" data_id="'+resultId+'" >修改</span>'+
								'<span class="address_del" data_id="'+resultId+'" >删除</span>'+
							'</div>'+
						'</dd>'+
					'</dl>';*/
		
		var strVar = "";
		
	    strVar += "			<div class=\"receipt_content\" id=\"address_rows_'+resultId+'\">";
	    strVar += "				<div class=\"select_address\">";
	    strVar += "					<dl class=\"receipt_name clearfix\">";
	    strVar += "						<dt class=\"fl\">";
	    strVar += "							"+name+"";
	    strVar += "						<\/dt>";
	    strVar += "						<dd class=\"fr\">";
	    strVar += "							"+phone+"";
	    strVar += "						<\/dd>";
	    strVar += "					<\/dl>";
	    strVar += "					<p class=\"receipt_dz\">"+pbsText+address+"<\/p>";
	    strVar += "				<\/div>";
	    strVar += "				<dl class=\"receipt_sz clearfix\">";
	    strVar += "					<dt class=\"fl set_default\" data_id=\""+resultId+"\">";
	    strVar += "						<label class=\"receipt_label\">";
	    strVar += "							<span>";
	    strVar += "								<img class=\"receipt_img1\" src=\"images/receipt_ico1.jpg\" />";
	    strVar += "								<img class=\"receipt_img2\" src=\"images/receipt_ico1_click.jpg\" />";
	    strVar += "							<\/span>";
	    strVar += "							默认地址";
	    strVar += "						<\/label>";
	    strVar += "					<\/dt>";
	    strVar += "					<dd class=\"fr\">";
	    strVar += "						<a class=\"address_edit\" data_id=\""+resultId+"\">";
	    strVar += "							<img src=\"images/receipt_ico12.jpg\" />";
	    strVar += "							修改";
	    strVar += "						<\/a>";
	    strVar += "					<\/dd>";
	    strVar += "				<\/dl>";
	    strVar += "			<\/div>";
	    
		$('.address_content').html(strVar+$('.address_content').html());
	},
	
	/**
	 * 保存配货地址
	 */
	doSaveAddress : function(){
		
		var $Cn = $('#consignee_name');
		
		var $Pd = $('#province_data');
		
		var $Bd = $('#bcity_data');
		
		var $Sd = $('#scity_data');
		
		var $Ca = $('#consignee_address');
		
		var $Cp = $('#consignee_phone');
		
		var flag = true;
		if( Utils.isNull($Cn.val()) ){
			$Cn.parent().siblings('.zy').show().html('请填写收货人');
			flag = false;
		}else{
			if( Order.lenFor($Cn.val()) >16 ){
				$Cn.parent().siblings('.zy').show().html('收货人姓名应小于16字');
				flag = false;
			}else{
				$Cn.parent().siblings('.zy').hide();
			}
		}
		
		if( Utils.isNull($Pd.val()) || Utils.isNull($Bd.val()) || Utils.isNull($Sd.val()) ){
			$Sd.parent().siblings('.zy').show().html('地区填写不完整');
			flag = false;
		}else{
			$Sd.parent().siblings('.zy').hide();
		}
		
		if( Utils.isNull($Ca.val()) ){
			$Ca.parent().siblings('.zy').show().html('请填写详细地址');
			flag = false;
		}else{
			if( Order.lenFor($Ca.val()) >150 ){
				$Ca.parent().siblings('.zy').show().html('详细地址信息应小于150字');
				flag = false;
			}else{
				$Ca.parent().siblings('.zy').hide();
			}
		}
		
		if( Utils.isNull($Cp.val()) ){
			$Cp.parent().siblings('.zy').show().html('请填写联系电话');
			flag = false;
		}else{
			if( !Utils.validateMobile(( $Cp.val() )) ){
				//手机号格式不正确 或者 固定电话不正确
				$Cp.parent().siblings('.zy').show().html('联系电话(手机)格式不正确');
				flag = false;
			}else{
				$Cp.parent().siblings('.zy').hide();
			}
		}
		
		if( !flag ){
			return;
		}else{
			
			var id = $('#address_id').val();
			var url = 'customer/createCustomerAddress';
			
			if( Utils.isNotNull(id) ){
				url = 'customer/modifyCustomerAddress';
			}
			
			var data = {
				'id':id,
				'name':$Cn.val(),	
				'address':$Ca.val(),	
				'phone':$Cp.val(),	
				'provinceId':$Pd.val(),	
				'bcityId':$Bd.val(),	
				'scityId':$Sd.val(),
				'customerId':$('#customer_id').val(),
				'isDefault':0,
				'timestamp':Utils.getTimeStamp()
			};
			
			Utils.doRequestAjax( url,data,'json',false,function(response) {
				if (response.code == 0) {
					
					var provinceName = $('#province_data').find('option:selected').text();
					var bcityName = $('#bcity_data').find('option:selected').text();
					var scityName = $('#scity_data').find('option:selected').text();
					var pbsText = provinceName+' '+bcityName+' '+scityName;
					if( Utils.isNotNull(id) ){
						Order.setAfterEditData(id,$Cn.val(),pbsText,$Ca.val(),$Cp.val(),null);
					}else{
						var resultId = response.data;
						Order.setAfterAddData(resultId,$Cn.val(),pbsText,$Ca.val(),$Cp.val());
					}
					
					alert('保存成功！');
					Order.showElement('address_list_div');
				}else{
					alert(response.message);
				}
			},function(response,XMLHttpRequest, textStatus, errorThrown) {
				alert(errorMsg);
			});
		}
	},
	
	/**
	 * 获取优惠券列表
	 * @param amount
	 */
	getCouponList : function(amount){
		
		var url = Utils.setTimeStamp('coupon/queryMyEnableCoupon?amount='+amount+'&isFirstMonth='+true);
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			
			if (response.code == 0) {
				
				var ecList = response.data.enableCouponList;
				var ocList = response.data.otherCouponList;
				
				var couponHtml = "";
				var couponListTitle = '<tr><th>券号</th><th>券名称</th><th>有效期</th><th>使用条件</th></tr>';
				var couponListContent = '';
				var ecListIsEmtpy = '<tr class="tbody_tr"><td colspan="4">暂无可用优惠券信息！</td></tr>';
				var ocListIsEmtpy = '<tr class="tbody_tr"><td colspan="4">暂无其它优惠券信息！</td></tr>';
				
				//可用数量
				var ecListSize = ecList.length;
				
				//可用优惠券列表
				if( Utils.isNotNull(ecList) ){
					$(ecList).each(function(index,couponVO){
						
						var disVals = couponVO.discountValue;
						var disMan = 0;
						var disJian = 0;
						if( Utils.isNotNull(disVals) ){
							disVals = disVals.substring(1,disVals.length-1).split(',');
							disMan = disVals[0];
							disJian = disVals[1];
						}
						
						couponListContent += '<tr class="tbody_tr availableCouponTR">'+
												'<td>'+
													'<input type="checkbox" class="radio_ipt" name="availableCoupon availableCouponCB" value="'+couponVO.id+'" />'+couponVO.id+
												'</td>'+
												'<td>'+
													''+couponVO.name+
												'</td>'+
												'<td>'+
													''+couponVO.startTime+ '至'+ couponVO.endTime +
													'<label for="a_label"></label>'+
												'</td>'+
												'<td>'+
													'<b>满'+Utils.toFormatDecimal(disMan,2)+ '减 '+Utils.toFormatDecimal(disJian,2)+'</b>'+
													'<input type="hidden" id="disMan_'+couponVO.id+'" value="'+disMan+'">'+
													'<input type="hidden" id="disJian_'+couponVO.id+'" value="'+disJian+'">'+
												'</td>'+
											'</tr>';
					});
					
				}else{
					couponHtml = couponListTitle + ecListIsEmtpy;
				}
				
				$('.available_coupon_count').text(ecListSize);
				
				$('#available_coupon').html( couponHtml );
				
				couponHtml = '';
				couponListContent = '';
				
				//其它数量
				var ocListSize = ocList.length;
				//其它优惠券列表
				if( Utils.isNotNull(ocList) ){
					$(ocList).each(function(index,couponVO){
						
						var disVals = couponVO.discountValue;
						var disMan = 0;
						var disJian = 0;
						if( Utils.isNotNull(disVals) ){
							disVals = disVals.substring(1,disVals.length-1).split(',');
							disMan = disVals[0];
							disJian = disVals[1];
						}
						
						couponListContent += '<tr class="tbody_tr">'+
												'<td>'+
													''+couponVO.id+
												'</td>'+
												'<td>'+
													''+couponVO.name+
												'</td>'+
												'<td>'+
													''+couponVO.startTime+ '至'+ couponVO.endTime +
													'<label for="a_label"></label>'+
												'</td>'+
												'<td>'+
													'<b>满'+Utils.toFormatDecimal(disMan,2)+ '减 '+Utils.toFormatDecimal(disJian,2)+'</b>'+
												'</td>'+
											'</tr>';
					});
					couponHtml = couponListTitle + couponListContent;
				}else{
					couponHtml = couponListTitle + ocListIsEmtpy;
				}
				
				$('.other_coupon_count').text(ocListSize);				
				$('#other_coupon').html( couponHtml );
				
			}else{
				alert(response.message);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	},
	
	//初始化优惠券信息
	initSetCouponMD5 : function(){
		
		var md5_begin = $.md5('begin');
		var md5_end = $.md5('end');
		var $rent_h = $('#rentT_H');
		var $isHdfk = $('#isUsedHdfk');
		$rent_h.val( md5_begin+$rent_h.val()+md5_end );
		$isHdfk.val( md5_begin+$isHdfk.val()+md5_end );
	},
	
	//获取优惠券相关金额
	getAmount : function(){
		
		var amount = new Number(0);
		var rent;
		
		var md5_begin = $.md5('begin');
		var md5_end = $.md5('end');
		var rentV = $('#rentT_H').val();
		
		rent = rentV.substring( md5_begin.length,rentV.length-md5_end.length );
		
		if( Utils.isNotNull(rent) && new Number(rent) > 0 ){
			amount = new Number(rent);
		}
		
		return amount;
	},
	
	//计算余额，返回实付款
	calculationBalance : function(){
		
		var $usedBalance = $('#used_balance');
		var balance = $usedBalance.val(); //客户账户余额
		var $balancePay = $('.balancePay'); //余额支付
		var $zxPay = $('.zxPay');//在线支付
		var $hdPay = $('.hdPay');//货到付款
		var $ye = $('.js_info_ye');	 //抵扣的余额
		
		var $sourceSfk = $('.js_info_sfk_h');//原始实付款
		var $sfk = $('.js_info_sfk');//实付款
		
		if( new Number($sourceSfk.val()) == 0 ){
			$usedBalance.prop('checked',false);
			return;
		}
		
		var $ubParent = $usedBalance.parent();
		if( $usedBalance.prop('checked') ){
			//使用余额
			
			if( !$ubParent.hasClass('on') ){
				$ubParent.addClass('on');
			}
			
			if( new Number(balance)==0 ){
				//A:余额等于零的情况：
				
				//余额 ==>余额	支付 ==>0
				$balancePay.text('0.00');
				//在线	==> 支付0
				$zxPay.text('0.00');
				//货到	==> 支付0
				$hdPay.text('0.00');
				//抵扣	==> 0
				$ye.text('-0.00');
				//实付款	==> 实付款
				$sfk.text( Utils.toFormatDecimal($sourceSfk.val(),2) );
				
			}else{
				//B:余额不等于零的情况：
				
				//1.余额大于实付款（例如：余额：100 实付款：90）
				if( new Number(balance) > new Number($sourceSfk.val()) ){
					//余额 ==> 余额	支付 ==> 实付款
					$balancePay.text( Utils.toFormatDecimal($sfk.text(),2) );
					//在线	==> 支付 0
					$zxPay.text('0.00');
					//货到	==> 支付 0
					$hdPay.text('0.00');
					//抵扣	==> 实付款
					$ye.text('-'+Utils.toFormatDecimal($sfk.text(),2));
					//实付款	==> 0
					$sfk.text('0.00');
				}
				
				//2.余额小于实付款（例如：余额：100 实付款：120）
				if( new Number(balance) < new Number($sourceSfk.val()) ){

					//余额 ==> 余额	支付 ==> 余额
					$balancePay.text( Utils.toFormatDecimal(balance,2));
					//在线	==> 支付 = 实付款-余额
					var sfkText = new Number($sourceSfk.val()) - new Number(balance);
					var v = Order.addDecimal(sfkText,2);
					$zxPay.text( v );
					//货到	==> 支付 = 实付款-余额
					$hdPay.text( v );
					//抵扣	==> 余额
					$ye.text('-'+Order.addDecimal(balance,2));
					//实付款	==> 实付款-余额
					$sfk.text( v );
				}
				
				//3.余额等于实付款
				if( new Number(balance) - new Number($sourceSfk.val()) == 0 ){
					
					//余额 ==> 余额	支付 ==> 余额
					$balancePay.text('0.00');
					//在线	==> 支付 0
					$zxPay.text('0.00');
					//货到	==> 支付 0
					$hdPay.text('0.00');
					//抵扣	==> 余额
					$ye.text('-'+Order.addDecimal(balance,2));
					//实付款	==> 0 
					$sfk.text('0.00');
				}
			}
			
		}else{
			//取消使用余额
			
			if( $ubParent.hasClass('on') ){
				$ubParent.removeClass('on');
			}
			
			if( new Number(balance)==0 ){
				//A:余额等于零的情况：
				
				//余额 ==>余额	支付 ==>0
				$balancePay.text('0.00');
				//在线	==> 支付0
				$zxPay.text('0.00');
				//货到	==> 支付0
				$hdPay.text('0.00');
				//抵扣	==> 0
				$ye.text('-0.00');
				//实付款	==> 实付款
				$sfk.text( Order.addDecimal($sourceSfk.val(),2) );
				
			}else{
				//B:余额不等于零的情况：
				
				//余额 ==> 余额	支付 ==> 0
				$balancePay.text('0.00');
				//在线	==> 支付 ==> 原始实付款
				$zxPay.text( Order.addDecimal($sourceSfk.val(),2) );
				//货到	==> 支付 ==> 原始实付款
				$hdPay.text( Order.addDecimal($sourceSfk.val(),2) );
				//抵扣	==> 0
				$ye.text( '-0.00' );
				//实付款	==> 原始实付款
				$sfk.text( Order.addDecimal($sourceSfk.val(),2) );
			}
		}
		
		return new Number($sfk.text());
	},
	
	//计算优惠券相关
	calculationCoupon : function( sfkVal ){
		
		//var usedCouponPrice = $('#usedCouponPrice').val();
		var $yhq = $('.js_info_yhq'); //优惠券抵扣金额
		var $sfk = $('.js_info_sfk');//实付款
		
		var $zxPay = $('.zxPay');//在线支付
		var $hdPay = $('.hdPay');//货到付款
		
		//使用的优惠券ID 为空为未使用
		var id = Order.getCouponData().couponId;
		var couponPrice = Order.getCouponData().couponPrice;
		
		var couponCount = $('#orderEnableCouponCount').attr('data_count');
		
		if( Utils.isNotNull(id) ){
			
			//使用优惠券
			if( sfkVal > Number(couponPrice)){
				
				var sfkText = new Number(sfkVal) - new Number(couponPrice);
				//使用优惠券后 实付款相应改变
				$sfk.text(Order.addDecimal(sfkText,2));
				$zxPay.text(Order.addDecimal(sfkText,2));
				$hdPay.text(Order.addDecimal(sfkText,2));
				
			}else{
				
				$sfk.text('0.00');
			}
			
			$yhq.text('-'+Order.addDecimal(couponPrice,2));
			
			$('#orderEnableCouponCount').text(Number(couponCount)-1);
			$('#selectCouponCount').text(1);
		}else{
			//不使用优惠券
			
			$yhq.text('-0.00');
			$('#orderEnableCouponCount').text(Number(couponCount));
			$('#selectCouponCount').text(0);
		}
		
		//金额为0的项不显示
		/*var yhqV = $('.js_info_yhq').text(); //优惠券抵扣金额
		var sfkV = $('.js_info_sfk').text();//实付款 
		var yeV = $('.js_info_ye').text();//余额
		
		if( Number(yhqV.substring(1,yhqV.length)) == 0 ){
			$('.yhq_dk_li').hide();
		}else{
			$('.yhq_dk_li').show();
		}
		
		if( Number(yeV.substring(1,yeV.length)) == 0 ){
			$('.ye_dk_li').hide();
		}else{
			$('.ye_dk_li').show();
		}
		
		if( Number(sfkV) == 0 ){
			$('.sfk_dk_li').hide();
		}else{
			$('.sfk_dk_li').show();
		}*/
		
	},
	
initHdfk : function(){
		
		var newLevel = $('#newLevel').val();
		var usedLevel = $('#usedLevel').val();
		var availableAmount = $('#availableAmount').val();
		var payDepositTotal = $('#payDepositTotal').val();
		
		var flag = true;
		$(".productRisk").each(function(){
			
			var v = $(this).val();
			var condition = $(this).attr('data_pc');
			var renType = $(this).attr('renttype');
			if( Utils.isNotNull(v) && renType != "5" ){
				
				var xs = 0;
				if( condition == '1' ){
					xs = parseInt(v) + parseInt(newLevel);
				}else{
					xs = parseInt(v) + parseInt(usedLevel);
				}
				if( parseInt(xs) > 2 ){
					flag = false;
				}
			}
			if( Utils.isNotNull(v) && renType == "5" ){
				//短租，用户风险系数大于2不能货到
				var xs = 0;
				if( condition == '1' ){
					xs = parseInt(newLevel);
				}else{
					xs = parseInt(usedLevel);
				}
				if( parseInt(xs) > 2 ){
					flag = false;
				}
			}
		});
		
		//（1）商品风险系数和客户风险系数之和大于2时， 不支持货到付款
		//（2）不申请免押金额度时或者押金额度为0时， 不支持货到付款
		//（3）可用额度<押金总金额时，不支持货到付款 
		//（4）客户押金比例不为1时， 不支持货到付款   

		if( !flag || availableAmount<payDepositTotal || !Order.getCustomerCreditBatch()){
			
			var $uh = $(".used_hdfk");
			var $hdDiv = $uh.closest('div');
			if( $hdDiv.hasClass('zf_fsB') ){
				$hdDiv.removeClass('zf_fsB').addClass('zf_fsB');
			}
			$(".used_hdfk").prop("disabled",true);
		}
	},
	
	/**
	 * 申请免押金额度时或者押金额度为0
	 * 客户押金比例不为1时
	 * data 等于空的情况下相当于授信信息未申请 
	 */
	getCustomerCreditBatch : function(){
		
		var url = 'customer/getCustomerCreditBatch';
		var data = null;
		var t = false;
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if ( response.code == 0 ) {
				
				if( Utils.isNotNull(response.data) ){
					
					var customer = eval('(' + response.data + ')');
					if( Utils.isNotNull(customer) ){ 
						if( Utils.isNotNull(customer.availableAmount) && Utils.isNotNull(customer.newDiscountPercent) && Utils.isNotNull(customer.usedDiscountPercent) ){
							if( Number(customer.availableAmount) != 0 && Number(customer.newDiscountPercent) == 1 && Number(customer.usedDiscountPercent) == 1 ){
								t = true;
							}
						}  
					} 
				}
			}
			
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			t = false;
		});
		return t;
	},
	
	/**
	 * 显示询问，添加方法
	 * @param clickMethod
	 */
	showConfirm : function ( clickMethod ){
		$('.btn_sc').attr('onclick',clickMethod);
		$(".bounced").show();
	},
	
	/**
	 * 隐藏询问，去除方法
	 * @param clickMethod
	 */
	hideConfirm : function (){
		$(".bounced").hide();
		$('.btn_sc').removeAttr('onclick');
	},
	
	/**
	 * 格式化数值为'd'位小数
	 * @param value
	 */
	addDecimal  : function( v,d ){
		
		if( Utils.isNotNull(v) && !isNaN(v) ){
			var VJia = new Number( (v*1)+1 ).toFixed(d);  
			var VJian = new Number( VJia-1 ).toFixed(d);
			return VJian;
		}else{
			return '';
		}
	},
};

/**
 * 相关数据初始化
 */
$(document).ready(function() {
	 
	//默认加载省级数据
	Order.initProvinceData();
	
	//初始化货到付款 (改为后端判断)
	//Order.initHdfk();
	
	//YHQ
	Order.initSetCouponMD5();
	 
	//图片数据初始化
	/*$(".carts_img").each(function(){
		var id = $(this).attr('img_data_id');
		if( Utils.isNotNull(id) ){
			$(this).attr('src',Utils.getImgUrl( Utils.BETA_IMG_DOMAIN,id,'s' ));
		}else{
			$(this).attr('src','images/no_pic/no_pic_60.png');
		}
	});*/

	// 计算金额
	Order.calculationCoupon( Order.calculationBalance() );
	 
	/**
	 * “使用”余额后，余额支付、余额抵扣和实付款的计算逻辑
	 */
	$('#used_balance').click(function(){
		
		var balance = Order.calculationBalance();
		
		Order.calculationCoupon( balance );
	});
	
	//支付方式选择
	$("input[name='paymentType']").click(function(){
		
		var $thisParent = $(this).parent();
		
		if( $thisParent.hasClass('hdfk_noaviable') ){
			$thisParent.removeClass('hdfk_noaviable').addClass('hdfk_noaviable');
			$(".used_hdfk").prop("disabled",true);
		}else{
			
			$('.zhif_AA').removeClass('on');
			
			if( !$thisParent.hasClass('on') ){
				$thisParent.addClass('on');
			}
		}
		
	});
	
	//优惠卷
	$(document).on('click','.coupon_mainK',function(event){
		//event.stopPropagation();
		
		var $thisCB = $(this).find('.availableCouponCB');
		
		if( $thisCB.prop('checked') ){
			//当前是选中的
			$(this).find(".coupon_click").hide();
			
			//设置所有样式为未选中样式
			//$('.availableCouponCB').removeClass("on");
			
			//当前置为未选中
			$thisCB.prop('checked',false);
			 
		}else{
			//当前是未选中的
			$(this).find(".coupon_click").show();
			$(this).siblings(".coupon_mainK").find(".coupon_click").hide();
			
			//加当前选中样式， 去除其它选中样式
			//$(this).addClass("on").siblings().removeClass("on");
			
			//其它全部不选中
			$('.availableCouponCB').prop('checked',false);
			
			//当前置为选中
			$thisCB.prop('checked',true);
			
			//当前所用优惠券金额
			//var id = $thisCB.val();
			//$('#usedCouponPrice').val($('#disJian_'+id).val());
		}  
	});
	
	//确定使用优惠券 和 从优惠券列表返回
	$(".submitCouponOk").click(function(){
		
		var balance = Order.calculationBalance();
		Order.calculationCoupon( balance );
		
		Order.showElement('order_div');
	});
	
	//优惠卷
	$(".main2_ul li").click(function(){
		$(this).addClass("on").siblings().removeClass("on");
		var tabId = $(this).attr("tabId");
		$("#"+tabId).show().siblings().hide();
	});
	
	//地址查看更多
	$(".ps_main .chakan").click(function(){
		$(this).hide().siblings().show();
		$('.address_content .ps_dz').show();
	});
	
	//配送地址取消
	$(".clearfix .close").click(function(){
		$(".address_dialog").hide();
	})
	
	//删除询问结束后点击取消
	$(".bounced .btn_qx,h6 a").click(function(){
		Order.hideConfirm();
	});
	
	//返回购物车修改
	$(".to_cartsEdit").click(function(){
		
		var isFromCarts = $('#isFromCarts').val();
		if( isFromCarts ){
			window.location = "carts";
		}else{
			
			var url = Utils.setTimeStamp('order/carts/addCarts');
			
			//商品集合
			var arrayParam = new Array();
			$('.productId').each(function(index,element){
				var id = $(element).val();
				var obj = new Object();
				obj.cartId = id;
				obj.productId = $(element).attr('data_pid');
				obj.rentType = $('#rentType_'+id).val();
				obj.month = $('#month_'+id).val();
				obj.startDate = $('#startDate_'+id).val();
				obj.num = $('#num_'+id).val();
				obj.isSale = $('#isSale_'+id).val();
				obj.insuranceTypeId = $('#insuranceTypeId_'+id).val();
				obj.serviceId = $('#serviceId_'+id).val();
				arrayParam.push( obj );
			});
			
			if( arrayParam.length <1 ){
				alert('商品信息缺失，请刷新重试！');
				return;
			}
			
			var data = {
				'orderCreateModels':JSON.stringify( arrayParam ),
				'source':2,
				'timestamp':Utils.getTimeStamp()	
			};
			
			Utils.doRequestAjax( url,data,'json',false,function(response) {
				if (response.code == 0) {
					window.location = "carts";
				}else{
					alert(errorMsg);
				}
			},function(response,XMLHttpRequest, textStatus, errorThrown) {
				alert(errorMsg);
			});
		}
		
	});
	
	//********************UI提供的脚本结束*********************//
	
	//有优惠券领取码
	$('.coupon_a').click(function(){
		$('.coupon_text,.coupon_button').show();
	});
	
	//领取优惠券
	$('.coupon_button').click(function(){
		var code = $('.coupon_text').val();
		if( Utils.isNull(code) ){
			alert('请输入优惠券码');
			return;
		}
		
		var url = Utils.setTimeStamp('coupon/createCustomerCoupon?getCode='+code);
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				
				var amount = Order.getAmount();
				
				if( amount > 0 ){
					Order.getCouponList( amount );
				}
			}else{
				alert(response.message);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	});
	
	//保存收货人地址
	$('.saveAddressInfo').click(function(){
		Order.doSaveAddress();
	});
	
	// 省：市级联查询
	$('#province_data').change(function() {
		Order.initBcityData( $(this).val() );
	});

	// 市：县级联查询
	$('#bcity_data').change(function() {
		Order.initScityData( $(this).val() );
	});
	
	//选择快递地址
	$(".select_address").click(function(){
		
		var id = $(this).attr('data_id');
		var isDef = $(this).parent().attr('data_isDef');
		var name = $(this).find('.consignee_name').text();
		var phone = $(this).find('.consignee_phone').text();
		var address = $(this).find('.province').text();
		
		$('.nowSelectedAddress').find('.consignee_name_tit_phone').text(name+"  "+phone);
		$('.nowSelectedAddress').find('.province').text(address);
		
		$('#default_Info').attr('data_id',id);
		
		if( isDef = '1' ){
			$('#default_Info').html('<label class="fr">默认地址</label>');
		}else{
			$('#default_Info').html('');
		}
		
		Order.showElement('order_div');
		location.hash="#navBarCustomerAddress"; 
	});

	//添加快递地址
	$("#to_add_address").click(function(){
		
		$('#address_title').html('新增快递地址');
		$('.receipt_main .modify_main .zy').hide();
		
		$('#address_id').val('');
		$('#consignee_name').val('');
		$('#province_data').val('');
		$('#bcity_data').empty().html('<option value="">请选择</option>');
		$('#scity_data').empty().html('<option value="">请选择</option>');
		$('#consignee_address').val('');
		$('#consignee_phone').val('');
		
		Order.showElement('address_modify_div');
	});
	
	//去修改快递地址
	$(document).on('click','.address_edit',function(){
		
		$('#address_title').html('修改快递地址');
		$('.receipt_main .modify_main .zy').hide();
		
		var id = $(this).attr('data_id');
		var url = Utils.setTimeStamp('customer/getCustomerAddress?id='+id);
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				
				var data = response.data;
				$('#address_id').val(id);
				$('#consignee_name').val(data.name);
				
				$('#province_data').val(data.provinceId);
				
				Order.initBcityData( data.provinceId );
				$('#bcity_data').val(data.bcityId);
				
				Order.initScityData( data.bcityId );
				$('#scity_data').val(data.scityId);
				
				$('#consignee_address').val(data.address);
				$('#consignee_phone').val(data.phone);
				
				Order.showElement('address_modify_div');
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	});
	
	//快递地址设为默认
	$(document).on('click','.set_default',function(){
		
		var $isDefault = $(this).children();
		if( $isDefault.hasClass('receipt_show') ){
			return;
		}
		
		var id = $(this).attr('data_id');
		var url = 'customer/modifyCustomerAddress';
		var data = {
			'id':id,
			'isDefault':1,
			'timestamp':Utils.getTimeStamp()
		};
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				 
				$('.set_default .receipt_label').removeClass('receipt_show');
				$isDefault.addClass('receipt_show');
				
				var this_select_id = $('#default_Info').attr('data_id');
				
				if( id == this_select_id ){
					$('#default_Info').html('<label class="fr">默认地址</label>');
				}else{
					$('#default_Info').html('');
				}
				
				alert('设置成功！');
			}else{
				alert(errorMsg);
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});
	});
	
	//删除快递地址
	$(document).on('click','.address_del',function(){
		var id = $(this).attr('data_id');
		Order.showConfirm("Order.doDelAddress('"+id+"')");
	});
	
	//同意《易点租电脑设备租赁协议》
	$(".selectAgree").click(function(){
		var $so = $('#submit_order');
		if($(this).prop("checked")){
			$so.removeAttr("disabled");
			$so.removeClass('gray');
		}else{
			$so.attr('disabled',true);
			$so.removeClass('gray').addClass('gray');
		}
	});
	
});