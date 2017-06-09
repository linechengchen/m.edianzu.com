var login = {
    cPhone: true,
    cPass: true,
    checkPhone: function() {
        var phoneNum = $("#phone").val();
        $(".error-pass").html("");
        // 验证手机号码是否填写
        if (phoneNum.length == 0) {
            $(".error-pass").html("登录账号不能为空!");
            login.cPhone = false;
            return;
        }

        // if (!/^[A-Za-z0-9]{6,20}$/.test(phoneNum)) {
        //     $(".error-pass").html("登录账号格式不正确!");
        //     login.cPhone = false;
        //     return;
        // }

        // 验证手机号位数
        // if (phoneNum.length != 11) {
        // 	alert("手机号码不是有效的11位电话号!");
        // 	login.cPhone = false;
        // 	return;
        // }

        // 匹配是否是正确的手机号
        //var myreg = /^(((13[0-9]{1})|(15[0-9]{1})|(17[0-9]{1})|(18[0-9]{1}))+\d{8})$/;
        // if (!Utils.validateMobile(phoneNum)) {
        // 	alert("手机号码不正确!");
        // 	login.cPhone = false;
        // 	return;
        // }
        login.cPhone = true;
    },
    checkPass: function() {
        var pass = $("#pass").val();
        $(".error-pass").html("");
        if (pass == "") {
            $(".error-pass").html("请填写密码!");
            login.cPass = false;
        }

        if (pass.length < 6) {
            $(".error-pass").html("密码为长度最少6位!");
            login.cPass = false;
            return;
        }

        if (pass.length > 32) {
            $(".error-pass").html("密码长度最长32位!");
            login.cPass = false;
            return;
        }
        login.cPass = true;
    },
    submitData: function(action, parameter) {
        if (login.cPass && login.cPhone) {
            var data = {
                "phone": $("#phone").val(),
                "password": $("#pass").val()
            };

            if($("#codeImage").is(':visible')) {
                data.imageCode = $("#imageCode").val();
            }else{
                data.code = $("#imageCode").val()
            }
            var url = 'customer/login';
            Utils.doRequestAjax(url, data, 'json', false, function(response) {
                $(".error-pass").html('');
                if (response.code == 0) {
                    if (response.data.isActivate == 0) {
                        window.location.href = "/toActivateUser";
                        return;
                    }


                    if (action == "back") {
                        window.history.back();
                    } else if (action == "submitOrder") {
                        login.productSubmit(parameter);
                    } else {
                        window.location.href = "index";
                    }
                } else {
                    $(".error-pass").html(response.message);
                    $('.form-error').each(function(){
                        if($(this).html()== ''){
                            $(this).addClass('hide');
                        }
                        else{
                            $(this).removeClass('hide');

                        }
                    });
                    setTimeout(function(){$('.error-pass').addClass('hide')},3000);
                    // login.checkLoginCount();
                    login.flushImageCode();
                }

            }, function() {
                if (response, XMLHttpRequest, textStatus, errorThrown) {
                    $(".error-pass").html('账号或密码错误。');
                } else {
                    $(".error-pass").html('');
                }

            });
        }
    },
    flushImageCode: function() {
        $("#codeImage").attr("src", "getCaptcha?count=5");
    },

    // checkLoginCount: function() {
    //     if (login.cPhone) {
    //         var data = {
    //             "phone": $("#phone").val()
    //         };

    //         var url = 'customer/checkLoginCount';
    //         Utils.doRequestAjax(url, data, 'json', false, function(response) {

    //             if (response.code == 0) {
    //                 if (response.data) {
    //                     $(".login_yanZ").attr("style", "display:block");
    //                 }
    //             }

    //         }, function() {
    //             if (response, XMLHttpRequest, textStatus, errorThrown) {
    //                 $(".error-pass").html('验证码错误！');
    //             } else {
    //                 $(".error-pass").html('');
    //             }
    //         });
    //     }
    // },
    //判断登录用户的验证码类型
    getAuthType: function(account) {
        if (!account) {
            //当没有输入用户时要不要将验证设为默认的图形验证码
            return;
        }
        Utils.doRequestAjax('/customer/getAuthType', {phone: account}, 'json', false, function(response) {
            if (!response.code) {
                login.setAuthType(response.data); // 0 or 1
            }else{
                login.setAuthType(0); // 0 or 1
            }
        });
    },
    // 0图片验证码， 1动态验证码
    setAuthType: function(type) {
        if (type == 1) {
            $('#codeImage').parent().hide();
            // $('#imgCode').attr({
            //     error: "动态验证码不正确",
            //     emptyError: "请输入动态验证码"
            // });
        }else{
            $('#codeImage').parent().show();
            // $('#imgCode').attr({
            //     error: "图形验证码不正确",
            //     emptyError: "请输入图形验证码"
            // });
        }
    },

    GetQueryString: function(name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
        var r = window.location.search.substr(1).match(reg);
        if (r != null) return (r[2]);
        return null;
    },
    productSubmit: function(parameter) {
        var datas = JSON.parse(parameter.replace(/%22/g, "\""));

        // 创建form
        var form = $('<form></form>');
        // 设置属性
        form.attr('action', 'order');
        form.attr('method', 'post');

        var productId = $('<input type="text" name="productId" />');
        productId.attr('value', datas["productId"]);

        var buyCount = $('<input type="text" name="num" />');
        buyCount.attr('value', datas["num"]);

        var rentType = $('<input type="text" name="rentType" />');
        rentType.attr('value', datas["rentType"]);

        var rentsMonth = $('<input type="text" name="month" />');
        rentsMonth.attr('value', datas["month"]);

        var startDate = $('<input type="text" name="startDate" />');
        startDate.attr('value', datas["startDate"]);

        var isSale = $('<input type="text" name="isSale" />');
        isSale.attr('value', datas["isSale"]);

        var serviceId = $('<input type="text" name="serviceId" />');
        serviceId.attr('value', datas["serviceId"]);

        var insuranceTypeId = $('<input type="text" name="insuranceTypeId" />');
        insuranceTypeId.attr('value', datas["insuranceTypeId"]);

        form.append(productId);
        form.append(buyCount);
        form.append(rentType);
        form.append(rentsMonth);
        form.append(startDate);
        form.append(isSale);
        form.append(serviceId);
        form.append(insuranceTypeId);

        // 兼容ie
        form.appendTo("body");
        form.css('display', 'none');

        // 提交表单
        form.submit();
    }
};
    /**
     * 准备函数
     */
$(document).ready(function() {
    // 验证手机号
    $('.form-error').addClass('hide');

    $("#phone").on("blur", function() {
        $(this).prev(".login-ico").removeClass("login-name-focus");
        login.checkPhone();
        // login.checkLoginCount();
        checkerror();
        login.getAuthType($.trim($(this).val()));
    });
    //解决浏览自动带出用户名的情况
    setTimeout(function() {
        $('#phone').blur();
    }, 200);

    // 验证密码
    $("#pass").on("blur", function() {
        $(this).prev(".login-ico").removeClass("login-pass-focus");
        login.checkPass();
        checkerror();
    });

    $(".dl-lj").on("click", function() {
        if(login.checkPhone() && login.checkPhone()){
        }
        //login.checkPass();
        checkerror();
        login.submitData(login.GetQueryString("action"), login.GetQueryString("parameter"));
    });

    //$.cookie("example", "foo");
    //alert($.cookie("example"));
    $("#phone").on("focus", function() {
        $(this).prev(".login-ico").addClass("login-name-focus");
    });
    $("#pass").on("focus", function() {
        $(this).prev(".login-ico").addClass("login-pass-focus");
    });

    //验证错误提示是否显示
    function checkerror(){
        if($('.form-error').html()== ''){
            $('.form-error').addClass('hide');
        }
        else{
            $('.form-error').removeClass('hide');
        }
        setTimeout(function(){$('.error-pass').addClass('hide')},3000);
    }
});
