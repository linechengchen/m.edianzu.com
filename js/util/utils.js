var Utils = {
		
	BETA_IMG_DOMAIN : 'http://beta.img.edianzu.com/',
		
	/**
	 * 将json字符串转成json对象
	 * @param jsonStr
	 * @returns
	 */
	serialiJson : function (jsonStr) {
		return eval('(' + jsonStr + ')');
	},

	/**
	 * 动态创建json对象
	 * @param jsonObj
	 * @param key
	 * @param value
	 * @returns
	 */
	createJson : function (jsonObj, key, value) {
		// 如果 value 被忽略
		if (typeof value === "undefined") {
			// 删除属性
			delete jsonObj[key];
		} else {
			// 添加 或 修改
			jsonObj[key] = value;
		}
		return jsonObj;
	},

	/**
	 * 得到url路径 /开头标识本项目路径，其他表示外部系统路径（直接返回）
	 * @param targetUrl
	 * @param domain
	 * @returns
	 */
	getUrl : function (targetUrl, domain) {
		if (!targetUrl || targetUrl == '') {
			return '';
		}
		if (/^\//.test(targetUrl)) { // 如果是/开头
			return domain + targetUrl;
		}
		return targetUrl;
	},

	/**
	 * 验证手机号码合法性
	 * @param value
	 * @returns {Boolean}
	 */
	validateMobile : function (value) {
		var reg= /^(((13[0-9]{1})|(14[0-9]{1})|(15[0-9]{1})|(17[0-9]{1})|(18[0-9]{1}))+\d{8})$/;
		if(reg.test(value)){
			return true;
		}	 
		return false;
	},

	/**
	 * 验证邮箱合法性
	 * @param value
	 * @returns {Boolean}
	 */
	validateMail : function (value) {
		var reg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
		if (reg.test(value)) {
			return true;
		}
		return false;
	},

	/**
	 * 验证固话合法性
	 * @param value
	 * @returns {Boolean}
	 */
	validateTel : function (value) {
		var reg = /^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$/;
		if (reg.test(value)) {
			return true;
		}
		return false;
	},
	
	/**
	 * 同时验证手机号和固定电话合法性
	 * @param value
	 * @returns {Boolean}
	 */
	vaidateMobilAndTel : function( value ){
		var reg =/^((0\d{2,3}-\d{7,8})|(1[35784]\d{9}))$/;
		if (reg.test(value)) {
			return true;
		}
		return false;
	},

	/**
	 * 验证邮编合法性
	 * @param value
	 * @returns {Boolean}
	 */
	validatePostal : function (value) {
		var reg = /^[a-zA-Z0-9 ]{3,12}$/;
		if (reg.test(value)) {
			return true;
		}
		return false;
	},

	/**
	 * 时间戳转换时间
	 * @param {}tm
	 * @return {} 如：2011-3-16 4:50:43 格式
	 */
	getLocalTime : function (tm) {
		
		var tmLen = tm.toString().length;
		var timeStamp = 0;
		
		if (tmLen == 13) {
			timeStamp = parseInt(tm);
		}else if(tmLen == 10){
			timeStamp = parseInt(tm) * 1000;
		}else{
			return tm;
		}
		
		return new Date(timeStamp).toLocaleString().replace(/年|月/g, "-")
		.replace(/日/g," ").replace(/上午|中午|下午/g, "").replace(/\//g, "-");
	},
	
	/**
	 * 时间戳转换时间
	 * @param tm
	 * @return {} 如：2011-3-16 16:50:43 格式
	 */
	getLocalTimes : function(tm){
		
		var tmLen = tm.toString().length;
		var timeStamp = 0;
		
		if (tmLen == 13) {
			timeStamp = parseInt(tm);
		}else if(tmLen == 10){
			timeStamp = parseInt(tm) * 1000;
		}else{
			return tm;
		}
		
		var date = new Date(timeStamp);
		Y = date.getFullYear() + '-';
		M = (date.getMonth()+1 < 10 ? '0'+(date.getMonth()+1) : date.getMonth()+1) + '-';
		D = date.getDate() + ' ';
		h = date.getHours() + ':';
		m = date.getMinutes() + ':';
		s = date.getSeconds(); 
		
		return Y+M+D+h+m+s;
	},

	/**
	 * 时间戳转换时间
	 * @param {}tm
	 * @return {} 如：2011年3月16日 16:50:43 格式
	 */
	getLocalTimeCN : function (tm) {
		
		var tmLen = tm.toString().length;
		var timeStamp = 0;
		
		if (tmLen == 13) {
			timeStamp = parseInt(tm);
		}else if(tmLen == 10){
			timeStamp = parseInt(tm) * 1000;
		}else{
			return tm;
		}
		
		return new Date(timeStamp).toLocaleString().replace(/\//g, "-");
	},

	/**
	 * 删除重复数据
	 * @param data
	 * @returns 
	 */
	uniqueArray : function (data){   
	    data = data || [];   
	        var a = {};   
	    for (var i=0; i<data.length; i++) {   
	        var v = data[i];   
	        if (typeof(a[v]) == 'undefined'){   
	            a[v] = 1;   
	        }   
	    };   
	    data.length=0;   
	    for (var i in a){   
	        data[data.length] = i;   
	    }   
	    return data;   
	},

	/**
	 * 转码
	 * @param data
	 * @returns
	 */
	_encodeURI : function (data){
		return encodeURIComponent(data);
	},

	/**
	 * 解码
	 * @param data
	 * @returns
	 */
	_decodeURI : function (data){
		return decodeURIComponent(data);
	},

	/**
	 * 获得指定Id内容
	 * @param tagId
	 * @returns
	 */
	_getTagValueById : function (tagId){
		return $("#" + tagId).val();
	},

	/**
	 * 判断是否为空
	 * @param value
	 * @returns {Boolean}
	 */
	isNotNull : function (value){
		return !(value == undefined || value == null || $.trim(value) == "");
	},

	/**
	 * 判断是否为空
	 * @param value
	 * @returns {Boolean}
	 */
	isNull : function (value){
		return value == undefined || value == null || $.trim(value) == "";
	},

	/**
	 * 判断某值不是undefined
	 * @param value
	 * @returns {Boolean}
	 */
	isNotUndefined : function (value){
		return !(typeof(value) == 'undefined');
	},

	/**
	 * 判断某值是undefined
	 * @param value
	 * @returns {Boolean}
	 */
	isUndefined : function (value){
		return (typeof(value) == 'undefined');
	},

	/**
	 * 验证是否为函数
	 * @param call
	 * @returns {Boolean}
	 */
	verifyFunction : function (call){
		if (typeof (call) == 'function') {
			return true;
		}
		return false;
	},

	/**
	   JS版
	   将传入数据转换为字符串,并清除字符串中非数字与.的字符
	   按数字格式补全字符串
	 * @param num
	 * @returns {String}
	 */
	getFloatStr : function (num){
	    num += '';
	    num = num.replace(/[^0-9|\.]/g, ''); //清除字符串中的非数字非.字符
	    if(/^0+/) //清除字符串开头的0
	        num = num.replace(/^0+/, '');
	    if(!/\./.test(num)) //为整数字符串在末尾添加.00
	        num += '.00';
	    if(/^\./.test(num)) //字符以.开头时,在开头添加0
	        num = '0' + num;
	    num += '00';        //在字符串末尾补零
	    num = num.match(/\d+\.\d{2}/)[0];
	    return num;
	},


	//* 名　　称：DataLength 
	//* 功    能：计算数据的长度 
	//* 入口参数：fData：需要计算的数据 
	//* 出口参数：返回fData的长度(Unicode长度为2，非Unicode长度为1) 
	dataLength : function (fData) {
	    var intLength=0 
	    for (var i=0;i<fData.length;i++) {
	        if ((fData.charCodeAt(i) < 0) || (fData.charCodeAt(i) > 255)) 
	            intLength=intLength+2 
	        else 
	            intLength=intLength+1    
	    } 
	    return intLength 
	}, 

	//获取contextpat
	getContextPath : function () {
		var pathName = document.location.pathname;
		var index = pathName.substr(1).indexOf("/");
		var result = pathName.substr(0,index+1);
		return result;
	},
	
	//加月
	addMonth : function(sDate,num) {
		
         var aYmd = sDate.toString().split('-');
        
         var aYmd1 = aYmd[1];
         
         //补充月份没0的
         if (aYmd1.indexOf('0') != -1 && aYmd1.length ==1 ){
        	 aYmd1 = '0'+aYmd1;
         }
         
         var dt = new Date(aYmd[0], aYmd1, aYmd[2]);
		 
         dt.setMonth(dt.getMonth() + num);

         var y = dt.getFullYear();
         var m = dt.getMonth();
         var d = dt.getDate();
         //坑爹啊，月份是从0开始啊！！！！
         if (m == 0) {
        	 m = 12; y = y - 1; 
         }

         if (m < 10) m = '0' + m;
         if (d < 10) d = '0' + d;
         
         return y + '-' + m + '-' + d;
     },
     
     //减月
     minusMonth : function(sDate,num) {
 		
          var aYmd = sDate.toString().split('-');
         
          var aYmd1 = aYmd[1];
          
          //补充月份没0的
          if (aYmd1.indexOf('0') != -1 && aYmd1.length ==1 ){
         	 aYmd1 = '0'+aYmd1;
          }
          
          var dt = new Date(aYmd[0], aYmd1, aYmd[2]);
 		 
          dt.setMonth(dt.getMonth() - num);

          var y = dt.getFullYear();
          var m = dt.getMonth();
          var d = dt.getDate();
          //坑爹啊，月份是从0开始啊！！！！
          if (m == 0) {
         	 m = 12; y = y - 1; 
          }

          if (m < 10) m = '0' + m;
          if (d < 10) d = '0' + d;
          
          return y + m + d;
      },

	/**
	 * 格式化数值为指定位数的小数
	 * @param v 值
	 * @param bit 指定的位数(20以内)
	 */
	toFormatDecimal : function( v,bit ){
		
		if( Utils.isNotNull(v) && !isNaN(v) && bit < 20 ){
			var vJia = new Number( (v*1)+1 ).toFixed( bit );  
			var vJian = new Number( vJia-1 ).toFixed( bit );
			return vJian;
		}else{
			return '';
		}
	},
	
	/**
	 * 转换URL 加时间戳
	 * @param url
	 * @returns {String}
	 */
	setTimeStamp : function( url ){
		return url + '&timestamp='+new Date().getTime();
	},
	
	/**
	 * 生成时间戳
	 * @param url
	 * @returns {String}
	 */
	getTimeStamp : function(){
		return new Date().getTime();
	},
	
	/**
	 * AJAX请求公用方法
	 * @param url 后台请求地址
	 * @param data 参数
	 * @param dataType 请求类型
	 * @param asyncFlag false 同步加载,true异步加载
	 * @param map index
	 * @param callBack
	 * @param errorBack
	 */
	doRequestAjax : function(url,data,dataType,asyncFlag,callBack, errorBack) {
		
		$.ajax({
			type : 'post',
			cache : false,// 从页面缓存获取加载信息
			async : asyncFlag,
			dataType : dataType,
			url : common.encode(url),
			data : data,
			error : function(XMLHttpRequest, textStatus, errorThrown) {
				if (common.verifyFunction(errorBack)) {
					errorBack(data,XMLHttpRequest, textStatus, errorThrown);
				}
			},
			success : function(data) {
				if (common.verifyFunction(callBack)) {
					/*if( data.code == 9999 ){
						window.location.href="login";
					}else{*/
						callBack(data);
					
				}
			}
		});
	},

	/**
	 *	以form表单形式提交数据
	 *  
	 *  @param url     后台请求地址
	 *  @param data    传入参数
	 *  @param isBanck 是否打开新页面  true:打开
	 *  
	 **/
	doFormSubmit:function(url, data,isBanck){

		// 创建form
		var form = $('<form></form>');
		// 设置属性  
		form.attr('action',  url);
		form.attr('method', 'post');
		if(isBanck==true){
			form.attr('target', '_blank');
		}
		var html = '';
		for(var key in data){
			html+='<input type="text" name="' + key + '" value="'+data[key]+'" />';
		}
		// $.each(data,function(key,value){
		// 	var nkey = $('<input type="text" name="' + key + '" />');
		// 	nkey.attr('value', value);
		// 	form.append(nkey);
		// });

		// 兼容ie
		form.appendTo("body");
		form.html(html);
        form.css('display','none');
        
		// 提交表单  
		form.submit(); 
	},
	
	//是否是已登录状态
	isLogin_ing : function(){
		var token = $.cookie('token');
		return (Utils.isNotUndefined(token) && Utils.isNotNull(token) )?true:false;
	},
	
	/**
	 * 不足3位时，高位用0补 
	 * @param v
	 * @returns {String}
	 */
	toThreeBitFormat : function(v) {
		while ( v.toString().length < 3 ) {
			v = "0" + v;
		}
		return v;
	},
	
	/**
	 * 获取图片URL地址
	 * @param imgDomain 图片服务器域名
	 * @param id 图片ID
	 * @param suffix 图片格式后缀
	 * @returns {String} 返回完整URL
	 */
	getImgUrl: function( imgDomain,id,suffix ) {
		
		if( Utils.isNotNull(id) ){
			
			var id_125 = Utils.toThreeBitFormat(id % 125);
			var id_255 = Utils.toThreeBitFormat(id % 255);
			var id_199 = Utils.toThreeBitFormat(id % 199);
			
			return imgDomain + id_125 + "/" + id_255 + "/" + id_199 + "/" + id + "-" + suffix + ".jpg";
		}else{
			return 'images/no_pic/no_pic_60.png';
		}
	}
};

/**
 * 对Date的扩展，将 Date 转化为指定格式的串
 * @param fmt
 * @return 将date类型转换为yyyy-MM-dd 或者 yyyy-MM-dd hh:ss:mm形式
 */
Date.prototype.Format = function (fmt) {
	
	var o = {
		"M+": this.getMonth() + 1, //月份 
		"d+": this.getDate(), //日 
		"h+": this.getHours(), //小时 
		"m+": this.getMinutes(), //分 
		"s+": this.getSeconds(), //秒 
		"q+": Math.floor((this.getMonth() + 3) / 3), //季度 
		"S": this.getMilliseconds() //毫秒 
	};
	
	if (/(y+)/.test(fmt)) {
		fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
	}
	
	for (var k in o){
		if (new RegExp("(" + k + ")").test(fmt)) {
			fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
		}
	}
	
	return fmt;
}

String.prototype.trim = function(){     
	return this.replace(/(^\s*)|(\s*$)/g, "");     
};
