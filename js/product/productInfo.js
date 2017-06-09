var productInfo = {
	buyCount: 1,
	productPrice: 0,
	credit: 0,
	tnsurance: 0,
	sumPrice: 0,
	productLimitPrice: 0,
	isQueryQa: false,
	rentsId: 0,
	rentsMonth: 0,
	insurance: 1,
	historyCount: 1,
	productId: "100259",
	initBind: function() {

		// 点击加入购物车
		$(".footer_div").click(function() {
			productInfo.submitCart();
		});

		$(".successful .jixu_gw").click(function() {
			$(".successful").hide();
		});


		$(".daohuo_tongzhi").click(function() {
			$(".daohuot_z").show();
		});

		$(".back_Dd2").click(function() {
			$(".daohuot_z").hide();
		});

		$(".back_Dd1").click(function() {
			$(".daohuot_z").hide();
			// 请求记录到货通知
			productInfo.createProductLimit();
		});

		// 选择保修类型
		$(".insurance_type").click(function() {
			// 保修类型被选中
			productInfo.selectTnsuranceType($(this).attr("id"));
			// 计算订单总额
			productInfo.changePrice();
		});

		//  租赁类型选中
		$("li[name=month]").click(function() {
			// 月租金被选中
			productInfo.changeRents($(this).attr("id"));
			// 计算订单总额
			productInfo.changePrice();

		});

		$("#reduceCount").click(function() {
			// 减少数量处理
			productInfo.reduceExecute();
			// 维护商品数量 进行加减操作
			productInfo.executeCredit();
			// 计算订单总额
			productInfo.changePrice();
			// 计算押金
			productInfo.updateDeposit();
		});

		$("#addCount").click(function() {
			// 添加数量处理
			productInfo.addExecute();
			// 维护商品数量 进行加减操作
			productInfo.executeCredit();
			// 验证库存数量
			productInfo.checkBuyCount();
			// 计算订单总额
			productInfo.changePrice();
			// 计算押金
			productInfo.updateDeposit();
		});

		$("#buyCount").blur(function() {
			productInfo.buyCount = $("#buyCount").val();
			// 维护商品数量 进行加减操作
			productInfo.executeCredit();
			// 验证库存数量
			productInfo.checkBuyCount();
			// 计算订单总额
			productInfo.changePrice();
			// 计算押金
			productInfo.updateDeposit();
		});

		$("#partAddCart").click(function() {
			productInfo.submitPartToCart();
		});

		$(".successfulA .jixu_gwA").click(function() {
			$(".successfulA").hide();
		});

	},
	selectTnsuranceType: function(id) {
		var insuranceList = $(".insurance_type");
		$(insuranceList).each(function(i) {
			var insurance = $(insuranceList[i]);
			if (insurance.attr("id") != id) {
				$(insurance).removeClass("on");
			} else {
				if (!insurance.hasClass("on")) {
					$(insurance).addClass("on");
					productInfo.insurance = insurance.attr("id").split("insurance_")[1];
					if (productInfo.insurance == 2) {
						productInfo.tnsurance = 15;
					}else if (productInfo.insurance == 3) {
						productInfo.tnsurance = 30;
					}else if (productInfo.insurance == 4) {
						productInfo.tnsurance = 25;
					}else if (productInfo.insurance == 5) {
						productInfo.tnsurance = 35;
					}else if (productInfo.insurance == 6) {
						productInfo.tnsurance = 40;
					}else if (productInfo.insurance == 7) {
						productInfo.tnsurance = 50;
					}else if (productInfo.insurance == 8) {
						productInfo.tnsurance = 60;
					}else if (productInfo.insurance == 9) {
						productInfo.tnsurance = 80;
					}else {
						productInfo.tnsurance = 0;
					}
				}
			}
		});
	},
	initRents: function() {
		var rents = $("li[name=month]");
		if (rents.length <= 0) {
			return;
		}
		var minPrice = -1;
		var minIndex = 0;
		$(rents).each(function(i) {
			if (minPrice == -1) {
				minPrice = $(rents[i]).attr("month");
				minIndex = i;
				return true;
			}

			if (parseFloat($(rents[i]).attr("month")) < parseFloat(minPrice)) {
				minPrice = $(rents[i]).attr("month");
				minIndex = i;
			}
		});

		$(rents[minIndex]).addClass("on");
		//  设置单月月租金
		productInfo.productPrice = parseFloat($(rents[minIndex]).attr("month"));

		//  设置租赁类型的id
		productInfo.rentsId = $(rents[minIndex]).attr("id").split("_")[1];

		//  设置租赁类型的租期
		productInfo.rentsMonth = $(rents[minIndex]).attr("id").split("_")[2];

		// 初始化总金额
		$("#sumPrice").html("￥" + parseFloat(productInfo.productPrice).toFixed(2));

		if ($("#productId").val() == productInfo.productId) {
			$("#buyCount").val("10");
			productInfo.historyCount = 10;
		}
	},
	changePrice: function() {
		productInfo.sumPrice = parseFloat(productInfo.productPrice * productInfo.buyCount + productInfo.buyCount * productInfo.tnsurance).toFixed(2);
		$("#sumPrice").html("￥" + productInfo.sumPrice);
	},
	changeRents: function(id) {
		productInfo.productPrice = parseFloat($("#" + id).attr("month"));
		var rents = $("li[name=month]");
		$(rents).each(function(i) {
			if ($(rents[i]).attr("id") == id) {
				$("#" + id).addClass("on");
			} else {
				$(rents[i]).removeClass("on");
			}
		});

		//  设置租赁类型的租期
		productInfo.rentsMonth = $("#" + id).attr("id").split("_")[2];
		productInfo.rentsId = $("#" + id).attr("id").split("_")[1];
	},
	getCartsCount: function() {
		var data = {};

		var url = 'order/carts/queryProductCount';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {
			if (response.code == 0) {
				$("#cartCount").html(response.data);
			}
		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('读取购物车数量出现系统异常。');
		});
	},
	reduceExecute: function() {
		var count = parseFloat($("#buyCount").val());
		if (count - 1 <= 0) {
			return;
		}
		productInfo.buyCount = count - 1;
		$("#buyCount").val(productInfo.buyCount);

	},
	addExecute: function() {
		var count = parseInt($("#buyCount").val());
		productInfo.buyCount = count + 1;
		$("#buyCount").val(productInfo.buyCount);
	},
	updateDeposit: function() {
		$("#depositPrice").html("￥" + (parseInt(productInfo.buyCount) * parseFloat($("#deposit").val())).toFixed(2));
	},
	checkBuyCount: function() {
		if ($("#buyCount").val() == 0 || $("#buyCount").val() == "") {
			$("#buyCount").val(productInfo.historyCount);
			return;
		}
	},
	getCustomerCreditBatch: function() {
		var data = {};

		var url = 'customer/getCustomerCreditBatch';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {

			if (response.code == 0) {

				var resultInfo = JSON.parse(response.data);
				if (resultInfo != null && resultInfo.availableAmount != null) {
					productInfo.credit = resultInfo.availableAmount;
					$("#credit_value").html(resultInfo.availableAmount);
				}
			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('获取免押金额度出现系统异常。');
		});

	},
	executeCredit: function() {
		if (productInfo.credit > 0) {
			var v = parseFloat($("#deposit").val()) * productInfo.buyCount;
			if (v >= productInfo.credit) {
				$("#needpay_deposit").html(v - productInfo.credit);
			} else {
				$("#needpay_deposit").html(0);
			}

		} else {
			$("#needpay_deposit").html(parseFloat($("#deposit").val()) * productInfo.buyCount);
		}
	},
	createProductLimit: function() {
		var data = {
			"productId": $("#productId").val()
		};

		var url = 'product/createProductLimit';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {

			if (response.code == 0) {
				$(".daohuo_tongz").show();
				$(".daohuo_tongzhi").unbind("click");
				alert("记录成功!");
			} else if (response.code == null) {
				alert("请先登录!");
			} else {
				alert(response.message);
			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('获取免押金额度出现系统异常。');
		});
	},
	//读取商品咨询
	queryProductQaAbstract: function() {
		var data = {
			"productId": $("#productId").val()
		};

		var url = 'product/queryProductQaAbstract';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {

			if (response.code == 0) {
				var content = "";

				var qaData = response.data.abstractList;
				$(qaData).each(function(i) {
					content += "<div class=\"details_ul\">";
					content += "<ul><li class=\"color_ccc\"><span>网&nbsp;&nbsp;友：</span><span>";
					content += qaData[i].customerPhone;
					content += "</span></span><span class=\"time_span\">";
					content += qaData[i].cdate;
					content += "</span></li><li class=\"li_font\"><span>咨询内容：</span><span>";
					content += qaData[i].question;
					content += "</span></li><li class=\"li_font li_red\"><span>商家回复：</span><span>";
					content += qaData[i].answer;
					content += "</span></li></ul></div>";
				});
				$("#productQa").html(content);
			} else {
				alert(response.message);
			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('获取免押金额度出现系统异常。');
		});
	},
	submitCart: function() { //添加到购物车

		if ($("#productId").val() == productInfo.productId) {
			if ($("#buyCount").val() == 0 || $("#buyCount").val() == "") {
				alert("起租数量不能为0");
				return;
			}
			if (parseInt($("#buyCount").val()) < 10) {
				alert("起租数量不能小于10");
				return;
			}
		}

		var postData = new Array();
		var obj = new Object();

		obj.productId = $("#productId").val();
		obj.num = $("#buyCount").val();
		obj.rentType = productInfo.rentsId;
		obj.month = productInfo.rentsMonth;
		obj.startDate = $("#startDate").val();
		obj.isSale = $("#isSale").val();
		obj.serviceId = $("#serviceId").val();
		obj.insuranceTypeId = productInfo.insurance;
		obj.rentTypeId = $('li[name="month"][class="on"]').attr('rentId');
		postData.push(obj);

		var url = 'order/carts/addCarts';
		Utils.doRequestAjax(url, {
			"orderCreateModels": JSON.stringify(postData)
		}, 'json', false, function(response) {

			if (response.code == 0) {
				productInfo.getCartsCount();
			} else if (response.code == 2) {
				var rentsMonth = $("li[name=month]").map(function() {
					if ($(this).attr("class") == "on") {
						return $(this).attr("id");
					}
				}).toArray();

				var parameter = productInfo.insurance + "," + rentsMonth[0] + "," + $("#startDate").val() + "," + $("#buyCount").val();
				// 设置回显参数
				$.cookie("productParameter", parameter, {
					path: "/"
				});
				window.location.href = "login?action=back";
			} else {
				alert(response.message);
			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('获取加入购物车出现系统异常。');
		});
	},
	setStartDate: function() {
		var responseDate = $("#responseStartDate").val();
		if (responseDate == null || responseDate == "") {
			responseDate = "19900101";
		}
		var date = new Date();
		date.setFullYear(responseDate.substring(0, 4));
		date.setMonth(parseInt(responseDate.substring(4, 6)) - 1);
		date.setDate(responseDate.substring(6, 8));

		var befor3day = new Date();
		befor3day.setTime(new Date().getTime() + 3 * 24 * 60 * 60 * 1000);

		if (befor3day.getTime() > date.getTime()) {
			//  设置月份  进行补0
			var month = befor3day.getMonth() + 1;
			if (month.toString().length < 2) {
				month = "0" + month;
			}

			//  设置天数  进行补0
			var day = befor3day.getDate();
			if (day.toString().length < 2) {
				day = "0" + day;
			}

			var year = befor3day.getFullYear() + "-" + month + "-" + day;

			var aflterDay = new Date();
			aflterDay.setTime(new Date().getTime() + 33 * 24 * 60 * 60 * 1000);
			//  设置月份  进行补0
			var aflterMonth = aflterDay.getMonth() + 1;
			if (aflterMonth.toString().length < 2) {
				aflterMonth = "0" + aflterMonth;
			}

			//  设置天数  进行补0
			var afterDay = aflterDay.getDate();
			if (afterDay.toString().length < 2) {
				afterDay = "0" + afterDay;
			}

			var afterYear = aflterDay.getFullYear() + "-" + aflterMonth + "-" + afterDay;

			$("#startDate").val(year);
			$("#startDate").removeAttr("onClick");
			$("#startDate").attr("onClick", "WdatePicker({minDate:'" + year + "',maxDate:'" + afterYear + "'})");
		} else {
			//  设置月份  进行补0
			var month = date.getMonth() + 1;
			if (month.toString().length < 2) {
				month = "0" + month;
			}

			//  设置天数  进行补0
			var day = date.getDate();
			if (day.toString().length < 2) {
				day = "0" + day;
			}

			var year = date.getFullYear() + "-" + month + "-" + day;


			var aflterDay = new Date();
			aflterDay.setTime(date.getTime() + 30 * 24 * 60 * 60 * 1000);
			//  设置月份  进行补0
			var aflterMonth = aflterDay.getMonth() + 1;
			if (aflterMonth.toString().length < 2) {
				aflterMonth = "0" + aflterMonth;
			}

			//  设置天数  进行补0
			var afterDay = aflterDay.getDate();
			if (afterDay.toString().length < 2) {
				afterDay = "0" + afterDay;
			}

			var afterYear = aflterDay.getFullYear() + "-" + aflterMonth + "-" + afterDay;
			$("#startDate").val(year);
			$("#startDate").removeAttr("onClick");
			$("#startDate").attr("onClick", "WdatePicker({minDate:'" + year + "',maxDate:'" + afterYear + "'})");
		}
	},
	dataBackView: function() {
		// 设置登录后回显
		var parameter = $.cookie("productParameter");
		if (null != parameter && parameter != "") {
			var parameters = parameter.split(",");
			// 保修类型被选中
			productInfo.selectTnsuranceType("insurance_" + parameters[0]);
			// 月租金类型选中
			$("#" + parameters[1]).click();
			// 设置起始日期
			$("#startDate").val(parameters[2]);
			// 设置起始日期
			$("#buyCount").val(parameters[3]);

			// 重置回显
			$.cookie("productParameter", "", {
				path: "/"
			});
		}
	}
}

/**
 * 商品详情页面
 */
$(document).ready(function() {
	// 初始化绑定事件
	productInfo.initBind();
	// 初始化租金项
	productInfo.initRents();
	// 设置起租日期
	productInfo.setStartDate();
	// 数据回显
	productInfo.dataBackView();
	// 初始化购物车数量
	productInfo.getCartsCount();
});