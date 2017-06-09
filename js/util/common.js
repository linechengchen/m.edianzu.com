/**
 * 获取项目根路径
 */
function getRootPath() {
	var roorPath = "";
	// 获取当前网址
	var curWwwPath = window.document.location.href;
	// 获取主机地址之后的目录
	var pathName = window.document.location.pathname;
	var pos = curWwwPath.indexOf(pathName);
	// 获取主机地址
	var localhostPath = curWwwPath.substring(0, pos);
	// 获取带"/"的项目名
	var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);

	// 返回路径
	roorPath = localhostPath + projectName + "/";
	return roorPath;
}

/**
 * 处理异常
 */
function showErrorMsg($code, $message) {
	if ($code < 3) {
		var result = window.confirm($message + ',请重新登录!');
		if (typeof (result) == "undefined" || result == null || result == false) {
			return;
		}
		else {
			window.location.href = 'login';
		}
	}
	else {
		if ($message.length > 100) {
			$message = "系统错误,请联系管理员!";
		}
		$bs.alert($message);
	}
}

/**
 * 处理其他异常
 */
function showOtherErrorMsg() {
	$bs.alert('获取数据失败!');
}

/**
 * 随机数
 * 
 * @param Min
 * @param Max
 * @returns
 */
function GetRandomNum(Min, Max) {
	var Range = Max - Min;
	var Rand = Math.random();
	return (Min + Math.round(Rand * Range));
}

var common = {

	// 根路径
	ctx : "",

	application_ajax : "application/json",

	// form 表单提交
	formSubmit : function(formId, url) {
		url = encodeURI(url);
		$("#" + formId).attr("action", url);
		$("#" + formId).submit();
	},
	// 验证方法
	verifyFunction : function(call) {
		if (typeof (call) == 'function') {
			return true;
		}
		return false;
	},
	// 不为空
	isNotNull : function(value) {
		return !(value == undefined || value == null || value.trim == "");
	},

	// ajax post
	/**
	 * @params url 请求地址
	 * @params map new HashMap()
	 * @params formId form表单id
	 * @params params 请求参数 a=XX&b=oo
	 * @params asyncFlag 是否异步 true/false
	 * @params callBack 回调地址
	 * @params errorBack 错误回调地址
	 * 
	 * post请求
	 * 
	 * formId 和params参数 二选一
	 */

	ajax_post : function(url, map, formId, params, asyncFlag, callBack, errorBack) {
		var posturl = encodeURI(encodeURI(url)) + "?timestamp=" + new Date().getTime();
		var parameter = "";
		if (common.isNotNull(formId)) {
			parameter = $("#" + formId).serialize();// 表单序列化
		}
		else if (common.isNotNull(params)) {
			parameter = params;// 参数化
		}
		$.ajax({
			type : 'POST',
			cache : false,// 从页面缓存获取加载信息
			async : asyncFlag, // false 同步加载,true异步加载
			dataType : 'json',
			url : posturl,
			data : parameter,
			error : function(XMLHttpRequest, textStatus, errorThrown) {
				if (common.verifyFunction(errorBack)) {
					errorBack(data, map, XMLHttpRequest, textStatus, errorThrown);
				}
			},
			success : function(data) {
				if (common.verifyFunction(callBack)) {
					callBack(data, map);
				}
			}
		});
	},
	/**
	 * @params url 请求地址
	 * @params map new HashMap()
	 * @params formId form表单id
	 * @params params 请求参数 a=XX&b=oo
	 * @params asyncFlag 是否异步 true/false
	 * @params callBack 回调地址
	 * @params errorBack 错误回调地址
	 * 
	 * get请求
	 * 
	 * formId 和params参数 二选一
	 */
	// ajax get
	ajax_get : function(url, map, formId, params, asyncFlag, callBack, errorBack) {
		var geturl = encodeURI(encodeURI(url)) + "?timestamp=" + new Date().getTime();
		var parameter = "";
		if (common.isNotNull(formId)) {
			parameter = $("#" + formId).serialize();// 表单序列化
		}
		else if (common.isNotNull(params)) {
			parameter = params;// 参数化
		}

		$.ajax({
			type : 'GET',
			cache : false,// 从页面缓存获取加载信息
			async : asyncFlag, // false 同步加载,true异步加载
			dataType : 'json',
			url : geturl,
			data : parameter,
			error : function(XMLHttpRequest, textStatus, errorThrown) {
				if (common.verifyFunction(errorBack)) {
					errorBack(resultData, map);
				}
			},
			success : function(data) {
				if (common.verifyFunction(callBack)) {
					callBack(data, map);
				}
			}
		});
	},
	// 转码
	encode : function(url) {
		return encodeURI(encodeURI(url));
	},

	// 匹配手机号
	isMobile : function isMobile(str) {
		if (str == null || str == "") {

			return false;
		}
		var result = str.match(/^1[3|4|5|8][7][0-9]\d{4,8}$/);
		if (result == null) {
			return false;
		}
		return true;
	}

}
