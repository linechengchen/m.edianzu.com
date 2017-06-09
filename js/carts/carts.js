/**
 * @author liuguoqing@edianzu.cn
 * 购物车详细
 */
var errorMsg = '网络异常，请重试！';
var Carts = {
	
	/**
	 * 获取选中的数据
	 */
	getSelectedId : function (){
		var idArr = new Array;
		$(".main .p_cb").each(function(i) {
			if ( this.checked ){
				idArr.push($(this).val());
			}
		});
		return idArr;
	},
	
	/**
	 * 初始化所有商品的checkbox选中状态
	 */
	initProductCheckedStatus : function(){
		
		//判断租赁商品全选按钮是否选中
		Carts.handleAllcK($(".lease_product_cb"), $(".lease_product_cb_all"));
		
		//判断销售商品全选按钮是否选中
		Carts.handleAllcK($(".sale_product_cb"), $(".sale_product_cb_all"));
		
		// 判断所有商品是否应该选中
		Carts.handleAllcK($(".main .p_cb"), $(".product_cb_all"));
	},
	
	/**
	 * 商品数量改变后后台执行数据计算
	 * @param id
	 * @param num
	 * @param rentType
	 * @param month
	 * @param startDate
	 * @param isChecked
	 * @param timestamp
	 */
	doCalculationCarts : function( id ){
		
		var num = $('#num_'+id).val();
		var rentType = $('#rentType_'+id).attr('rent_type');
		var month = $('#rentType_'+id).attr('rent_month');
		var startDate = $('#startRentDate_'+id).val();
		var insuranceTypeId = $('#insurance_'+id).val(); //保险类型
		var serviceId = $('#serviceId_'+id).val(); //售后服务
		
		var isChecked ;
		if( $('#p_cb_'+id).prop('checked') ) isChecked = 1; else isChecked = 0; 
		
		var url = 'order/carts/modifyCarts';
		var data = {
			'id':id,
			'num':num,
			'rentType':rentType,
			'month':month,
			'startDate':startDate,
			'insuranceTypeId':insuranceTypeId,
			'serviceId':serviceId,
			'isChecked':isChecked,
			'source':1,
			'timestamp':Utils.getTimeStamp()
		};
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				//设置已选中商品的个数
				Carts.setSelectedCBCount();
				Carts.setCartsData( response.data );
			}else{
				alert( response.message );
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});	
	},
	
	/**
	 * 设置购物车各种数据
	 * @param data
	 */
	setCartsData : function( data ){
		
		if( Utils.isNotUndefined(data.cartsAbstracts) && Utils.isNotNull(data.cartsAbstracts) ){
			
			$( data.cartsAbstracts ).each(function(index,cartsAbstracts){
				var id = cartsAbstracts.id;
				var cartsProduct = cartsAbstracts.cartsProduct;
				
				//租赁商品：月租金
				$('#rentMonth_'+id).text( Utils.toFormatDecimal(cartsProduct.rent,2) );
				
				//租赁商品：押金
				$('#deposit_'+id).text( Utils.toFormatDecimal(cartsProduct.oldDeposit,2) );
				
				//租赁商品：首付期数
				$('#downPayMonth_'+id).text( Utils.toFormatDecimal(cartsProduct.downPayMonth,2) );
				
				//租赁商品：首付租金（小计行）
				$('#rentMonth_sum_'+id).text( Utils.toFormatDecimal(cartsProduct.downPayRent,2) );
				
				//租赁商品：总押金（小计行）
				$('#deposit_sum_'+id).text( Utils.toFormatDecimal(cartsProduct.oldDepositTotal,2) );
				
				//租赁商品：总租金（总行）
				$('#rentMonth_sum_total_'+id).text( Utils.toFormatDecimal(cartsProduct.rentTotal,2) );
				
				//租赁商品：总押金（总行）
				$('#deposit_sum_total_'+id).text( Utils.toFormatDecimal(cartsProduct.oldDepositTotal,2) );
				
				//销售商品：价格
				$('#salePrice_'+id).text( Utils.toFormatDecimal(cartsProduct.salePrice,2) );
				
				//销售商品：价格（小计行）
				$('#salePrice_sum_'+id).text( Utils.toFormatDecimal(cartsProduct.saleTotal,2) ); 
				
				//销售商品：总价格（总行）
				$('#salePrice_sum_total_'+id).text( Utils.toFormatDecimal(cartsProduct.saleTotal,2) );
				
				//商品有无货提示信息
				var $num = $('#num_'+id);
				var $stockDiv = $('#stock_div_'+id);
				if( cartsProduct.stock <= 0 || Number( $num.val() ) > cartsProduct.stock){
					$stockDiv.html('<p class="on">无货</p>');
				}else{
					$stockDiv.html('<p></p>');
				}
				
			});
			
			//押金总金额
			var depositTotal = data.depositTotal;
			$('.depositTotal').text(Utils.toFormatDecimal(depositTotal,2));
			
			//应付押金总计
			var payDepositTotal = data.payDepositTotal;
			$('.payDepositTotal').text(Utils.toFormatDecimal(payDepositTotal,2));
			
			//应付租金总计
			var payRentTotal = data.payRentTotal;
			$('.payRentTotal').text(Utils.toFormatDecimal(payRentTotal,2));
			
			//应付押金和租金总计
			var payTotal = data.payTotal;
			$('.payTotal').text(Utils.toFormatDecimal(payTotal,2));
			
			//本次为您减免押金
			var reliefDepositTotal = data.reliefDepositTotal;
			$('.reliefDepositTotal').text(Utils.toFormatDecimal(reliefDepositTotal,2));
			
			//保险
			var payInsuranceTotal = data.payInsuranceTotal;
			$('.payInsuranceTotal').text(Utils.toFormatDecimal(payInsuranceTotal,2));
			
			//销售商品总计
			var paySaleTotal = data.paySaleTotal;
			$('.paySaleTotal').text(Utils.toFormatDecimal(paySaleTotal,2));
			
		}else{
			window.location.reload();
		}
	},
	
	/**
	 * 全选 反全选数据计算
	 * @param isChecked true:选中 false:取消选中
	 * @param isSale 0:租赁 1：销售 2：全部
	 */
	checkAllCarts : function (isChecked,isSale){
		var url = 'order/carts/checkCarts';
		var data = {
			'isChecked':isChecked,
			'isSale':isSale,
			'timestamp':Utils.getTimeStamp()
		};
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				
				Carts.setCartsData( response.data );
			}else{
				alert( response.message );
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});	
	},
	
	/**
	 * 执行购物车删除
	 * @param id
	 * @param cartsIds
	 */
	doDelCarts : function( ids ){
		var url = 'order/carts/removeCarts';
		var data = {
			'ids':ids+'',
			'timestamp':Utils.getTimeStamp()
		};
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				
				Carts.hideConfirm();
				
				//执行页面伪删除
				Carts.doRemovePageElement(ids);
				
				//设置已选中商品的个数
				Carts.setSelectedCBCount();
				
				Carts.setCartsData( response.data );
				
				alert('操作成功！');
				
			}else{
				alert( errorMsg );
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});	
	},
	
	/**
	 * 服务器删除成功后，执行页面数据删除
	 * @param ids
	 */
	doRemovePageElement : function( ids ){
		
		if( Utils.isNull( ids ) ){
			//清空所有数据
			$('.carts_product_row_all').each(function(i,element){
				$(this).remove();
			});
		}else{
			if( ids.length>0 ){
				
				//删除指定数据
				var idArr = ids.split(',');
				$( idArr ).each(function(i,id){
					$('#carts_product_row_'+id).remove();
				});
			}
		}
	},
	
	/**
	 * 清空购物车
	 */
	doClearCarts : function(){
		var url = 'order/carts/cleanCarts';
		var data = null;
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			
			if (response.code == 0) {
				
				Carts.hideConfirm();
				
				//执行页面伪删除
				Carts.doRemovePageElement(null);
				
				//设置已选中商品的个数
				Carts.setSelectedCBCount();
				
				Carts.setCartsData( response.data );
				
				alert('操作成功！');
			}else{
				alert( errorMsg );
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});	
	},
	
	/**
	 * 处理全选相关
	 * @param $ck
	 * @param $ckAll
	 */
	handleAllcK : function ($ck, $ckAll) {

		var ck = 0;
		$ck.each(function() {
			if ($(this).prop("checked") == true) {
				ck++;
			}
		});

		if ( $ck.size() == ck ) {
			$ckAll.prop("checked", true);
			$ckAll.parent().addClass('on');
		}else {
			$ckAll.prop("checked", false);
			$ckAll.parent().removeClass('on');
		}
	},
	
	/**
	 * 设置已选中商品的个数
	 * @returns
	 */
	setSelectedCBCount : function(){
		
		//所有商品类型的选中个数	
		var rentProNum = 0;
		$('.lease_product_cb').each(function() {
			if ($(this).prop("checked") == true) {
				var id = $(this).val();
				var num = $('#num_'+id).val()
				rentProNum += Number(num);
			}
		});
		
		var saleProNum = 0;
		$('.sale_product_cb').each(function() {
			if ($(this).prop("checked") == true) {
				var id = $(this).val();
				var num = $('#num_'+id).val();
				saleProNum += Number(num);
			}
		});
		
		$('#selected_sum').text("("+Number(rentProNum+saleProNum)+")");
		
	},
	
	/**
	 * 显示询问，添加方法
	 * @param clickMethod
	 */
	showConfirm : function ( clickMethod,tipContent ){
		$('.bounced .cont_jg').html(tipContent);
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
	 * 执行购物车结算
	 * @param obj
	 */
	doSettlementCarts : function( obj ){
		
		//防止重复提交
		$(obj).attr('disabled','true');
		var ids = Carts.getSelectedId();
		if( ids.length == 0 ){
			$(obj).removeAttr("disabled");
			alert('请选择商品！');
			return;
		}
		
		if( !Utils.isLogin_ing() ){
			$(obj).removeAttr("disabled");
			alert('请先登录！');
			return;
		}
		
		var url = 'order/carts/validateCarts';
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			
			if (response.code == 0) {
				
				window.location = "order";
			}else{
				alert( response.message );
				$(obj).removeAttr("disabled");
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
			$(obj).removeAttr("disabled");
		});	
	},
	
	/**
	 * 获取商品库存
	 * @param productId
	 */
	getProductStock : function(productId){
		
		var stock = -999;
		var url = 'product/getProductStock';
		var data = {
			'productId':productId,
			'timestamp':Utils.getTimeStamp()
		};
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				
				stock = response.data;
			}else{
				console.log('获取库存失败。。。');
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			console.log('获取库存失败。。。');
		});	
		return stock;
	}
};

/**
 * 相关数据初始化
 */
$(document).ready(function() {
	
	var minDate = new Date().setDate(new Date().getDate() + 3);
	var maxDate = Utils.addMonth(new Date(minDate).Format("yyyy-MM-dd"),1);
	
	var opt = {
		theme: 'jqm', //皮肤其他参数【android-ics light】【android-ics】【ios】【jqm】【sense-ui】【sense-ui】【sense-ui】
		preset: 'date', //日期类型--datatime --time,
		dateFormat: 'yyyy-mm-dd', // 日期格式
        display: 'modal', //显示方式 
        mode: 'scroller', //日期选择模式
		lang:'zh',
        minDate: new Date(minDate),
        maxDate: new Date(maxDate),
        //defaultValue : new Date(outDate),
        height: 45,
        width: 90,
        rows: 3,
   	   	onSelect:function(valueText,inst){
   	   		//alert(valueText);
		}
    };
	
	//初始化所有起租日期
	$(".lease_product_cb").each(function(){
		
		var id = $(this).val();
		$("#startRentDate_"+id).mobiscroll(opt);
	});
	
	//初始化商品选中状态
	Carts.initProductCheckedStatus();
	
	//初始化所有起租日期
	$(".lease_product .lease_product_cb").each(function(){
		var id = $(this).val();
		jeDate({
			dateCell:"#startRentDate_"+id,
			format:"YYYY-MM-DD",
			isinitVal:false,   //是否初始化时间
			//isTime:false,     //是否开启时间选择
			isClear: true,    //是否显示清空
			festival:false,   //是否显示节日
			zIndex:999,   //弹出层的层级高度
			minDate:jeDate.now(3),
			choosefun:function(val) {
				//选择时间之后的回调函
			}  
		});
	});
	
	//初始化所有商品图片URL
	/*$(".carts_img").each(function(){
		
		var id = $(this).attr('img_data_id');
		if( Utils.isNotNull(id) ){
			$(this).attr('src',Utils.getImgUrl( Utils.BETA_IMG_DOMAIN,id,'s' ));
		}else{
			$(this).attr('src','images/no_pic/no_pic_60.png');
		}
	});*/
	
	// 租赁商品全选
	$(".lease_product_cb_all").click(function() {
		var isCheck = 0;
		var $leaseProductCb = $(".lease_product_cb");
		if (this.checked) {
			
			$leaseProductCb.prop("checked", true);
			$leaseProductCb.parent().addClass("on");
			
			$(this).parent().addClass("on");
			isCheck = 1;
		}else {
			
			$leaseProductCb.prop("checked", false);
			$leaseProductCb.parent().removeClass("on");
			
			$(this).parent().removeClass("on");
		}

		// 判断所有商品是否应该选中
		Carts.handleAllcK($(".main .p_cb"), $(".product_cb_all"));
		
		//设置已选中商品的个数
		Carts.setSelectedCBCount();
		
		Carts.checkAllCarts(isCheck,0);
		
	});

	// 销售商品全选
	$(".sale_product_cb_all").click(function() {
		var isCheck = 0;
		var $saleProductCb = $(".sale_product_cb");
		if (this.checked) {
			$(this).parent().addClass("on");
			$saleProductCb.prop("checked", true);
			$saleProductCb.parent().addClass("on");
			isCheck = 1;
		}else {
			$(this).parent().removeClass("on");
			$saleProductCb.prop("checked", false);
			$saleProductCb.parent().removeClass("on");
		}

		// 判断所有商品是否应该选中
		Carts.handleAllcK($(".main .p_cb"), $(".product_cb_all"));
		
		//设置已选中商品的个数
		Carts.setSelectedCBCount();
		
		Carts.checkAllCarts(isCheck,1);
	});

	// 所有商品全选
	$(".product_cb_all").click(function() {
		
		var isCheck = 0;
		var $saleProductCb = $(".sale_product_cb");
		var $leaseProductCb = $(".lease_product_cb");
		var $saleProductCbAll = $(".sale_product_cb_all");
		var $leaseProductCbAll = $(".lease_product_cb_all");
		
		if (this.checked) {

			$leaseProductCbAll.prop("checked", true);
			$leaseProductCbAll.parent().addClass('on');
			
			$leaseProductCb.prop("checked", true);
			$leaseProductCb.parent().addClass('on');
			
			$saleProductCbAll.prop("checked", true);
			$saleProductCbAll.parent().addClass('on');
			
			$saleProductCb.prop("checked", true);
			$saleProductCb.parent().addClass('on');
			
			$(this).parent().addClass('on');
			
			isCheck = 1;
		}else {
			
			$leaseProductCbAll.prop("checked", false);
			$leaseProductCbAll.parent().removeClass('on');
			
			$leaseProductCb.prop("checked", false);
			$leaseProductCb.parent().removeClass('on');

			$saleProductCbAll.prop("checked", false);
			$saleProductCbAll.parent().removeClass('on');
			
			$leaseProductCb.prop("checked", false);
			$saleProductCb.parent().removeClass('on');
			
			$(this).parent().removeClass('on');
		}
		
		//设置已选中商品的个数
		Carts.setSelectedCBCount();
		
		Carts.checkAllCarts(isCheck,2);
	});

	// 租赁商品单选:处理租赁商品全选 和 所有商品全选
	$(".lease_product_cb").click(function() {
		
		if (this.checked) {
			$(this).parent().addClass("on");
		}else {
			$(this).parent().removeClass("on");
		}
		
		//判断租赁商品全选按钮是否选中
		Carts.handleAllcK($(".lease_product_cb"), $(".lease_product_cb_all"));
		
		// 判断所有商品是否应该选中
		Carts.handleAllcK($(".main .p_cb"), $(".product_cb_all"));
		
		//设置已选中商品的个数
		Carts.setSelectedCBCount();
		
		//请求服务器数据计算
		Carts.doCalculationCarts( $(this).val() );
	});	

	// 销售商品单选:处理销售商品全选 和 所有商品全选
	$(".sale_product_cb").click(function() {
		
		if (this.checked) {
			$(this).parent().addClass("on");
		}else {
			$(this).parent().removeClass("on");
		}
		
		//判断销售商品全选按钮是否选中
		Carts.handleAllcK($(".sale_product_cb"), $(".sale_product_cb_all"));
		
		// 判断所有商品是否应该选中
		Carts.handleAllcK($(".main .p_cb"), $(".product_cb_all"));
		
		//设置已选中商品的个数
		Carts.setSelectedCBCount();
		
		//请求服务器数据计算
		Carts.doCalculationCarts( $(this).val() );
	});
	
	//租赁方式展示隐藏
	$(".main .select_div").click(function(){
		
		var $T = $(this);
		var displayText = $T.attr('d_s');
		if( displayText == 'hide' ){
			$T.find("ul").show();
			$T.attr('d_s','show');
		}else{
			$T.find("ul").hide();
			$T.attr('d_s','hide');
		}
	});
	
	//租赁方式确认选中此项
	$(".main .select_div ul li").click(function(){
		
		var $T = $(this);
		var id = $T.attr('data_id');
		var rentHtml = $T.html();
		var rentType = $T.attr('rent_type');
		var rentMonth = $T.attr('rent_month');
		var rent_desc = $T.attr('rent_desc');
		var $P = $T.parent("ul").siblings("p");
		
		$P.html( rentHtml );
		$P.attr('rent_type',rentType);
		$P.attr('rent_month',rentMonth);
		$('#rent_type_title_'+id).html(rent_desc);
		
		$T.parent().hide();
		
		//请求服务器数据计算
		Carts.doCalculationCarts( id );
	});
	
	//商品数量手动输入：有效性校验
	$(".main .ipt_sl").keyup(function(){
		
		var thisV = $(this).val();
		
		if( Utils.isNotNull( thisV ) ){
			
		    if( !new RegExp("^[0-9]*$").test(thisV) || !/^[0-9]*$/.test(thisV) ){
		    	
		    	var id = $(this).attr('data_id');
		    	
		    	$(this).val( 1 );
		    	
		    	$('#num_h_'+id).val(1);
		    	
		    	//请求服务器数据计算，考虑服务器性能不计算了 
				//Carts.doCalculationCarts( id );
		    }else{
		    	var reg = new RegExp("^(0|[1-9][0-9]*)$");
				if( !reg.test($(this).val()) || $(this).val() == 0 ){
					$(this).val(1);
				}
		    }
	    }
	    
	}).blur(function(){
		
		var id = $(this).attr('data_id');
		var productId = $(this).attr('data_pid');
		
		var stock = Carts.getProductStock( productId );
		
		var $this = $('#num_'+id);
		var $this_h = $('#num_h_'+id);
		
		if( Utils.isNull( $this.val() ) ){
			
			//库存变为1
			$this.val( 1 );
			
			//记录上一次
			$this_h.val( 1 );
		}else{
			
			if( stock != -999 ){
				
				if( stock >0 ){
					
					if( Number($this.val()) > stock ){
						
						//库存小于当前数量的情况下
						alert('商品数量不能大于'+stock);
						
						//当前的库存数显示为此次输入之前的库存数
						$this.val( stock );
						
					}else{
						
						//记录上一次
						$this_h.val( $this.val() );
					}
					
				}else{
					
					//库存变为1
					$this.val( 1 );
					
					//记录上一次
					$this_h.val( 1 );
					
					//库存为零的情况下，提示没货
					var $stockDiv = $('#stock_div_'+id);
					$stockDiv.html('<p class="on">无货</p>');
				}
				
			}else{
				
				
				//库存变为1
				//$this.val( 1 );
				
				//记录上一次
				$this_h.val( 1 );
				
				//获取库存异常的情况下，提示没货
				var $stockDiv = $('#stock_div_'+id);
				$stockDiv.html('<p class="on">无货</p>');
				
			}
		}
		
		//请求服务器数据计算
		Carts.doCalculationCarts( $(this).attr('data_id') );	
		
	});
	
	//商品数量加一、减一
	$(".main .num_add,.num_reduce").click(function(){
		
		var $T = $(this);
		var $this = $T.siblings('.num');
		var $NumReduce = $T;
		var id = $this.attr('data_id');
		var $this_h = $('#num_h_'+id);
		
		var productId = $this.attr('data_pid');

		var stock = Carts.getProductStock( productId );
		
		if( $T.attr('class').indexOf('num_add') != -1 ){
			
			//执行加法
			
			var num = Number($this.val())+1;
			

			if( stock != -999 ){
				
				if( stock >0 ){
					
					if( num > stock ){
						
						//库存小于当前数量的情况下
						alert('商品数量不能大于'+stock);
						
						//当前的库存数显示为此次输入之前的库存数
						$this.val( stock );
						
					}else{
						
						$this.val( num );
						
						//记录上一次
						$this_h.val( $this.val() );
						
						$NumReduce = $T.siblings('.num_reduce');
					}
					
				}else{
					
					//库存变为1
					$this.val( 1 );
					
					//记录上一次
					$this_h.val( 1 );
					
					//库存为零的情况下，提示没货
					var $stockDiv = $('#stock_div_'+id);
					$stockDiv.html('<p class="on">无货</p>');
					
				}
				
			}else{
				
				
				//库存变为1
				$this.val( 1 );
				
				//记录上一次
				$this_h.val( 1 );
				
				//获取库存异常的情况下，提示没货
				var $stockDiv = $('#stock_div_'+id);
				$stockDiv.html('<p class="on">无货</p>');
				
			}
			
		}else{
			
			//执行减法
			
			if( $this.val() >1 ){
				
				var num = Number($this.val())-1;

				// 针对此商品判断最少为10个
				if (productId == '100259' && num < 10) {
					alert("购买数量至少为10个");
					return;
				}

				$this.val(num );
				$('#num_h_'+id).val( num );
				
				if( num <= stock ){
					
					//提示无货
					var $stockDiv = $('#stock_div_'+id);
					$stockDiv.html('<p class="on">无货</p>');
				}
			}
		}
		
		//减号图标不可用
		if( Number($this.val()) == 1 ){
			$NumReduce.addClass('on');
		}else{
			$NumReduce.removeClass('on');
		}		
		
		//请求服务器数据计算
		Carts.doCalculationCarts( id );
		
	});	
	
	//日期改动
	$('.startRentDate').blur(function(){
		var $T = $(this);
		setTimeout(function(){
			//请求服务器数据计算
			Carts.doCalculationCarts( $T.attr('data_id') );
		},666); 
	});
	
	//保险改动
	$('.insurance').change(function(){
		
		//请求服务器数据计算
		Carts.doCalculationCarts( $(this).attr('data_id') );
	});
	
	//单个商品删除
	$(".deleteProduct").click(function(){
		
		var $T = $(this);
		var id = $T.attr('data_id');
		
		var ids = new Array;
		ids.push(id);
		
		Carts.showConfirm("Carts.doDelCarts('"+ids+"')","确认删除此商品吗？");
		
	});
	
	//选中的商品删除
	$("#del_selected").click(function(){
		
		//其它选中的数据
		var ids = Carts.getSelectedId();
		
		if( ids.length == 0 ){
			alert('请选择商品！');
			return;
		} 
		
		Carts.showConfirm("Carts.doDelCarts('"+ids+"')","确认删除选中的商品吗？");  
	});
	
	//清除购物车
	$("#clear_carts").click(function(){
		Carts.showConfirm("Carts.doClearCarts()","确认清除购物车吗？");  
	});
	
	//到货通知
	$(".main .goods_notice").click(function(){
		var productId = $(this).attr('data_id');
		var url = Utils.setTimeStamp('product/createProductLimit?productId='+productId);
		var data = null;
		
		Utils.doRequestAjax( url,data,'json',false,function(response) {
			if (response.code == 0) {
				alert('已收到通知，到货将第一时间提醒您！');
				$(this).remove();
			}else{
				alert( response.message );
			}
		},function(response,XMLHttpRequest, textStatus, errorThrown) {
			alert(errorMsg);
		});	   
	});
	
	//询问结束后点击取消
	$(".cancelDel").click(function(){
		Carts.hideConfirm();
	});
	
	//去结算
	$("#go_settlement").click(function(){
		Carts.doSettlementCarts( this );   
	});
	
});