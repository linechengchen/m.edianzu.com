var productList = {
	//  所有数据条数
	total: 0,
	// 当前页
	pageIndex: 1,
	// 每页显示数据条数
	pageSize: 10,
	condition: 0,
	lte: 0,
	gte: 0,
	brand_id: 0,
	category_id: 0,
	sort: "",
	stop: true,
	easyreturn:-1,
	init: function() {

		// 绑定租金范围事件
		$(".zjfw").on("click", function() {
			productList.select_zjfw($(this));
			productList.getList();
			
		});

		// 绑定新旧属性事件
		$(".xjsx").on("click", function() {
			productList.select_xjsx($(this));
			productList.getList();
			
		});


		// 绑定品牌事件
		$(".brand").on("click", function() {
			productList.select_pp($(this));
			productList.getList();
		});

		// 绑定分类事件
		$(".category").on("click", function() {
			productList.select_category($(this));
			productList.getList();
		});


		// 绑定排序按钮事件
		$(".sort").on("click", function() {
			setTimeout(function() {
				productList.select_sort();
				productList.getList();
				$(".chiseA_main").hide();
				$(".choise_main").hide();
				return false;
			}, 10);
		});

		// 绑定排序按钮事件
		$("a[name=zl]").on("click", function() {
			productList.select_szsh($(this));
			productList.getList();
		});


		$(".listClass_ul li").click(function(e) {
			$(this).find("a.clearfix").removeClass("color");
			$(this).find("a.clearfix").addClass("color");
			$(this).siblings(".listClass_ul li").find("a.clearfix").removeClass("color");		
			if($(".listClass_ul .list_sales").find("a.clearfix").hasClass("color")){

				if($(this).find(".list_ico1 .listIco2").is(":hidden")){
					$(this).find(".list_ico1 .listIco2").show().siblings(".list_ico1 .listIco1").hide();
					$(this).find(".list_ico2 .listIco2").hide().siblings(".list_ico2 .listIco1").show();
				}else{
					$(this).find(".list_ico1 .listIco2").hide().siblings(".list_ico1 .listIco1").show();
					$(this).find(".list_ico2 .listIco2").show().siblings(".list_ico2 .listIco1").hide();
				};
				
			}else{
				$(".listClass_ul .list_sales span").find(".listIco1").show();
				$(".listClass_ul .list_sales span").find(".listIco2").hide();
			}
			if($(".listClass_ul .list_money").find("a.clearfix").hasClass("color")){

				if($(this).find(".list_ico1 .listIco2").is(":hidden")){
					$(this).find(".list_ico1 .listIco2").show().siblings(".list_ico1 .listIco1").hide();
					$(this).find(".list_ico2 .listIco2").hide().siblings(".list_ico2 .listIco1").show();
				}else{
					$(this).find(".list_ico1 .listIco2").hide().siblings(".list_ico1 .listIco1").show();
					$(this).find(".list_ico2 .listIco2").show().siblings(".list_ico2 .listIco1").hide();
				};
				
			}else{
				$(".listClass_ul .list_money span").find(".listIco1").show();
				$(".listClass_ul .list_money span").find(".listIco2").hide();
			}
		});
		$(".choice_word").click(function() {
			$(".choise_main").show();
		})
		$(".choise_sureA").click(function() {
			$(".choise_main").hide();
		});
		$(".chosi_a").click(function() {
			$(this).find(".chiseA_main").show();
		})
		$(".choise_sureBfs").click(function() {
			$(".chiseA_main").hide();
			return false;
		});
		$(".choise_sureBsure").click(function() {
			$(".choise_main").hide();
			return false;
		});
		$(".chiseA_main li").click(function() {
			Zepto(this).find("a").css({
				"color": "#e45050"
			});
			Zepto(this).siblings("li").find("a").css({
				"color": "#333"
			});

		});
		//查询用户购物车数量
		var data2={};
		var url2 = "order/carts/queryProductCount";
		Utils.doRequestAjax(url2, data2, 'json', false, function(response) {
			if(response.code==0){
				if(response.data!=null){
					$("#carts_amount").html(response.data);
				}else{
					$("#carts_amount").html("0");
				}

			}
		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			//alert('读取购物车数量出现系统异常。');
		});
	},
	getList: function() {
		productList.pageIndex = 1;

		var data = {
			"page": productList.pageIndex,
			"size": productList.pageSize
		};

		if (productList.condition != 0) {
			data["condition"] = productList.condition;
		}

		if (productList.lte != 0) {
			data["lte"] = productList.lte;
		}

		if (productList.gte != 0) {
			data["gte"] = productList.gte;
		}

		if (productList.brand_id != 0) {
			data["brand_id"] = productList.brand_id;
		}

		if (productList.category_id != 0) {
			data["categoryId"] = productList.category_id;
		}

		if (productList.sort != "") {
			data["sort"] = productList.sort;
		}

		if(productList.easyreturn!=-1){
			data["easyreturn"] = productList.easyreturn;
		}

		var url = 'product/getProductList';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {

			if (response.code == 0) {
				var hitsList = response.data;
				var content = "";
				$(hitsList).each(function(i) {
					if(hitsList[i]._id=="1000088"){
						console.log("11111");
					}
					content += "<dl class=\"clearfix\"><dt class=\"fl\"><a href=\"queryProductDetail?id=" + hitsList[i]._id + "\" >";
					content += "<img src=\"" + hitsList[i]._source.pic + "\" /></a></dt><dd class=\"fr\"><a href=\"queryProductDetail?id=" + hitsList[i]._id + "\"<p><h3>";
					content += hitsList[i]._source.title + "</h3></p><em class=\"list_jg\">";
					content += "¥" + (hitsList[i]._source.sort_rent / 100).toFixed(2);
					if (hitsList[i]._source.is_sale == 1) {
						content += "</span></a></li>";
					} else {
						content += " /月</span></a></li>";
					}
					content += "</em><span class=\"list_fx\">";
					if (hitsList[i]._source.condition == 1) {
						content += "全新设备";
					} else if (hitsList[i]._source.condition == 2) {
						content += "非全新设备";
					} else if (hitsList[i]._source.condition == 3) {
						content += "翻新设备";
					}

					if(hitsList[i]._source.easyreturn==1){
						content += "</span><span class=\"list_fx\">随租随还</span></a>";
					}
					content += "</dd></dl>";
				});

				//  设置商品列表
				$("#contentDiv").html(content);

			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('加载商品列表出现系统异常。');
		});
	},
	getNextList: function() {

		$("#loading").show();

		var data = {
			"page": productList.pageIndex,
			"size": productList.pageSize
		};

		if (productList.condition != 0) {
			data["condition"] = productList.condition;
		}

		if (productList.lte != 0) {
			data["lte"] = productList.lte;
		}

		if (productList.gte != 0) {
			data["gte"] = productList.gte;
		}

		if (productList.brand_id != 0) {
			data["brand_id"] = productList.brand_id;
		}

		if (productList.category_id != 0) {
			data["categoryId"] = productList.category_id;
		}

		if (productList.sort != "") {
			data["sort"] = productList.sort;
		}

		if(productList.easyreturn!=-1){
			data["easyreturn"] = productList.easyreturn;
		}

		var url = 'product/getProductList';
		Utils.doRequestAjax(url, data, 'json', false, function(response) {

			if (response.code == 0) {
				var hitsList = response.data;
				var content = "";
				$(hitsList).each(function(i) {
					content += "<dl class=\"clearfix\"><dt class=\"fl\"><a href=\"queryProductDetail?id=" + hitsList[i]._id + "\" >";
					content += "<img src=\"" + hitsList[i]._source.pic + "\" /></a></dt><dd class=\"fr\"><a href=\"queryProductDetail?id=" + hitsList[i]._id + "\"<p><h3>";
					content += hitsList[i]._source.title + "</h3></p><em class=\"list_jg\">";
					content += "¥" + (hitsList[i]._source.sort_rent / 100).toFixed(2);
					if (hitsList[i]._source.is_sale == 1) {
						content += "</span></a></li>";
					} else {
						content += "/月</span></a></li>";
					}
					content += "</em><span class=\"list_fx\">";
					if (hitsList[i]._source.condition == 1) {
						content += "全新设备";
					} else if (hitsList[i]._source.condition == 2) {
						content += "非全新设备";
					} else if (hitsList[i]._source.condition == 3) {
						content += "翻新设备";
					}
					
					if(hitsList[i]._source.easyreturn==1){
						content += "</span><span class=\"list_fx\">随租随还</span></a>";
					}
					content += "</dd></dl>";
				});

				//  设置商品列表
				$("#contentDiv").append(content);
				productList.stop = true;
				$("#loading").hide();
				if (hitsList.length == 0) {
					$("#noData").show();
				}
			}

		}, function(response, XMLHttpRequest, textStatus, errorThrown) {
			alert('加载商品列表出现系统异常。');
		});
	},
	sumData: function(v) {
		while (v.toString().length < 3) {
			v = "0" + v;
		}
		return v;
	},
	select_zjfw: function(target) {

		if ($(target).attr("value") == "zjfw_0") {
			productList.lte = 0;
			productList.gte = 0;
		} else if ($(target).attr("value") == "zjfw_1") {
			productList.lte = 90;
			productList.gte = 0;
		} else if ($(target).attr("value") == "zjfw_2") {
			productList.lte = 150;
			productList.gte = 90;
		} else if ($(target).attr("value") == "zjfw_3") {
			productList.lte = 99999999;
			productList.gte = 150;
		}
	},
	select_xjsx: function(target) {
		productList.condition = $(target).attr("value");
	},
	select_pp: function(target) {
		productList.brand_id = $(target).attr("value");
	},
	select_category: function(target) {
		productList.category_id = $(target).attr("value");
	},
	select_szsh: function(target) {
		productList.easyreturn = $(target).attr("value");
	},
	select_sort: function() {
		if (!$("#xl_asc").is(":hidden")) {
			productList.sort = "sale_count_desc";
		} else if (!$("#xl_desc").is(":hidden")) {
			productList.sort = "sale_count_asc";
		} else if (!$("#zj_asc").is(":hidden")) {
			productList.sort = "sort_rent_asc";
		} else if (!$("#zj_desc").is(":hidden")) {
			productList.sort = "sort_rent_desc";
		} else {
			productList.sort = "";
		}
	},
	select_upPage: function() {
		var page = $("#page").val();
		if (parseInt(page) == 1) {
			return;
		}
		$("#page").val(parseInt(page) - 1);
	},
	select_nextPage: function() {
		var page = $("#page").val();
		var maxPage = $("#maxPage").val();
		if ((parseInt(page) + 1) > parseInt(maxPage)) {
			return;
		}

		$("#page").val(parseInt(page) + 1);
	},
	submitData: function() {
		$("#productListForm").submit();
	}
}


/**
 * 准备函数
 */
$(document).ready(function() {
	console.log("22222");
	// 加载品牌数据
	//productList.getBrandList();
	// 加载数据
	//productList.getList();

	// 初始化页面信息
	productList.init();
});


$(window).scroll(function() {
	totalheight = parseFloat($(window).height()) + parseFloat($(window).scrollTop());
	if ($(document).height() <= totalheight) {
		if (productList.stop == true) {
			productList.stop = false;
			productList.pageIndex += 1;
			productList.getNextList();
		}
	}
});