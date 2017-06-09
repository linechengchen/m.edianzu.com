var register = {
    cPhone: false,
    cSmsCode: false,
    cPass: false,
    cPass2: false,
    channelId: 1,
    cImageCode: false,
    isRegisted: false,
    isReg: true,
    type: 0,
    init: function() {
        btntrue = true;
        // 绑定服务条款事件
        //TODO 改为a
        $("#fwtkText").on("click", function() {
            window.location.href = "help_server_role";
        });
        // 验证用户名
        $("#name").on("blur", function() {
            register.checkName();
        });

        // 验证绑定手机号
        $("#phone").on("blur", function() {
            register.checkPhone();
        });

        // 验证图片验证码
        $("#imageCode").on("blur", function() {
            register.checkImageCode();
        });


        // 验证手机验证码
        $("#smsCode").on("blur", function() {
            register.checkSmsCode();
        });

        // 验证密码是否正确
        $("#pass1").on("blur", function() {
            register.checkPassword();
        });

        // 切换验证码
        $("#codeImage").on("click", function() {
            register.flushImageCode();
        });

        // 验证两次密码是否一致
        /*$("#pass2").on("blur", function() {
            register.checkPassword2();
        });*/

        // 验证 提交注册
        $(".dl_ljA").on("click", function() {
            if(btntrue){
                btntrue = false;
                register.checkAll();
            }
        });
        //验证错误提示是否显示
        /*function checkerror(_this){
            if(_this.closest('li').next('.prefect-error').html() == ''){
                _this.closest('li').next('.prefect-error').addClass('hide');
            }
            else{
                _this.closest('li').next('.prefect-error').removeClass('hide');
            }
        }*/
    },
    checkName: function() {
        var account = $("#name").val();
        $(".error-register-name").html("");
        if (account.length == 0) {
            $(".error-register-name").html("用户名不为空！");
            register.cPhone = false;
            return;
        }
        if (!/^[A-Za-z0-9]{8,32}$/.test(account) || /^\d*$/.test(account)) {
            $(".error-register-name").html("用户名格式不正确（要求8-32位字母或数字字母组合，不能是纯数字）");
            register.cPhone = false;
            return;
        }

        var data = {
            "account": account
        };

        var url = 'customer/checkAccountIsRegisted';
        Utils.doRequestAjax(url, data, 'json', false, function(response) {
            if (response.code == 0) {
                // 电话号验证通过
                register.cPhone = true;
                $(".error-register-name").html('');
            } else {
                $(".error-register-name").html(response.message);
                register.cPhone = false;
                return;
            }

        }, function() {
            if (response, XMLHttpRequest, textStatus, errorThrown) {
                $(".error-register-name").html('验证用户名出现系统异常。');
            } else {
                $(".error-register-name").html('');
            }
        });
    },

    checkPhone: function() {
        var phoneNum = $("#phone").val();
        // 验证手机号码是否填写
        if (phoneNum.length == 0) {
            // $("#phoneCheck").attr("class", "sx_zq1");
            $(".error-register-number").html("请输入手机号码!");
            register.cPhone = false;
            return;
        } else {
            $(".error-register-number").html("");
        }

        // 验证手机号位数
        if (phoneNum.length != 11) {
            // $("#phoneCheck").attr("class", "sx_zq1");
            $(".error-register-number").html("手机号码不足11位!");
            register.cPhone = false;
            return;
        } else {
            $(".error-register-number").html("");
        }

        // 匹配是否是正确的手机号
        //var myreg = /^(((13[0-9]{1})|(15[0-9]{1})|(17[0-9]{1})|(18[0-9]{1}))+\d{8})$/;
        if (!Utils.validateMobile(phoneNum)) {
            // $("#phoneCheck").attr("class", "sx_zq1");
            $(".error-register-number").html("手机号码格式不正确!");
            register.cPhone = false;
            return;
        } else {
            $(".error-register-number").html("");
        }

        var data = {
            "phone": phoneNum
        };

        var url = 'customer/checkPhoneIsRegisted';
        Utils.doRequestAjax(url, data, 'json', false, function(response) {

            if (response.code == 0) {
                // 电话号验证通过
                register.cPhone = true;
                $(".error-register-number").html('');
            } else if (response.code == 1003) {
                $(".error-register-number").html("该手机号已被绑定!");
                register.isRegisted = false;
                register.cPhone = false;
            } else {
                $(".error-register-number").html(response.message);
            }
        }, function() {
            if (response, XMLHttpRequest, textStatus, errorThrown) {
                $(".error-register-number").html('验证手机号码出现系统异常。');
            } else {
                $(".error-register-number").html('');
            }
        });
    },
    flushImageCode: function() {
        $("#codeImage").attr("src", "getCaptcha?count=5&t=" + new Date());
    },
    pushSms: function() {
        var phoneNum = $("#phone").val();
        var imgCode = $("#imageCode").val();

        if (imgCode == "") {
            $(".error-register-yz").html("请先填写图片验证码!");
            return;
        } else {
            $(".error-register-yz").html("");
        }

        // 验证手机号码是否填写
        if (phoneNum.length == 0) {
            // $("#phoneCheck").attr("class", "sx_zq1");
            $(".error-register-number").html("请输入手机号码!");
            register.cPhone = false;
            return;
        } else {
            $(".error-register-number").html("");
        }

        if (!register.cImageCode) {
            register.cImageCode = true;
            return;
        }
        var phoneNum = $("#phone").val();
        if (phoneNum == "") {
            $(".error-register-number").html("请先填写手机号码!");
            return;
        } else {
            $(".error-register-number").html("");
        }

        if (register.isRegisted) {
            $(".error-register-number").html("手机号码已被绑定!");
            return;
        } else {
            $(".error-register-number").html("");
        }


        if (!register.cPhone) {
            $(".error-register-number").html("手机号码格式不正确!");
            return;
        } else {
            $(".error-register-number").html("");
        }


        var data = {
            "phone": phoneNum,
            "imgCode": imgCode,
            "channelId": register.channelId,
            "typeId": register.type
        };
        var url = 'customer/pushSms2';
        Utils.doRequestAjax(url, data, 'json', false, function(response) {
            if (response.code == 0) {
                $(".regis_get").attr("href", "javascript:void(0);");
                $(".regis_get").attr("style", "color:#cbcbcb");
                register.pushSmsCd();
                alert("发送成功!");
                if (register.channelId == 2) {
                    register.channelId = 1;
                } else {
                    register.channelId = 2;
                }
                if (isReg) {
                    register.type = 0;
                } else {
                    register.type = 1;
                }
            } else {
                register.flushImageCode();
                $(".error-register-dxyz").html(response.message);
            }

        }, function() {
            if (response, XMLHttpRequest, textStatus, errorThrown) {
                $(".error-register-dxyz").html('发送短信验证码出现系统异常。');
            } else {
                $(".error-register-dxyz").html('');
            }
        });
    },
    pushSmsCd: function() {
        var timer;
        // 倒计时
        var count = 60;
        // 间隔时间
        var timeout = 1000;

        $(".regis_get").html("60s获取验证码");
        timer = $.timer(timeout, function() {
            count--;
            if (count > 0) {
                if (count >= 10) {
                    $(".regis_get").html(count + "s获取验证码");
                } else {
                    $(".regis_get").html(count + "s获取验证码");
                }
            } else {
                $(".regis_get").html("获取验证码");
                $(".regis_get").attr("style", "");
                $(".regis_get").attr("href", "javascript:register.pushSms();");
                register.flushImageCode();
                timer.stop();
            }
        });
    },
    checkSmsCode: function() {
        var code = $("#smsCode").val();
        if (code.length != 6) {
            $(".error-register-dxyz").html("请输入6位短信验证码");
            register.cSmsCode = false;
            return;
        } else {
            $(".error-register-dxyz").html("");
        }

        var data = {
            "phone": $("#phone").val(),
            "phoneCode": code
        };

        var url = 'customer/checkPhoneCode';
        Utils.doRequestAjax(url, data, 'json', false, function(response) {
            if (response.code == 0) {
                // $("#smsCodeCheck").attr("class", "sx_zq");
                $("#smsCodeErrorText").html("");
                // 手机验证码验证通过
                register.cSmsCode = true;
            } else if (response.code == 1002) {
                register.flushImageCode();
                $(".error-register-dxyz").html("验证码错误!");
                register.cSmsCode = false;
            } else {
                register.flushImageCode();
                $(".error-register-dxyz").html(response.message);
            }

        }, function() {
            if (response, XMLHttpRequest, textStatus, errorThrown) {
                $(".error-register-dxyz").html('验证手机号码出现系统异常。');
            } else {
                $(".error-register-dxyz").html('');
            }

        });
    },
    checkImageCode: function() {
        var code = $("#imageCode").val();
        // 如果没有填写验证码
        if (code.length == 0) {
            // $("#imgCodeCheck").attr("class", "sx_zq1");
            $(".error-register-yz").html("请输入验证码!");
            register.cImageCode = false;
            return;
        } else {
            $(".error-register-yz").html("");
        }

        // 验证码位数不一致
        if (code.length != 5 && code.length != 6) {
            // $("#imgCodeCheck").attr("class", "sx_zq1");
            $(".error-register-yz").html("图片验证码错误!");
            register.cImageCode = false;
            register.flushImageCode();
            return;
        } else {
            $(".error-register-yz").html("");
        }

        register.cImageCode = true;
    },
    checkPassword: function() {
        var pass = $("#pass1").val();
        if (pass == "") {
            $(".error-register-pass").html("请输入密码!");
            register.cPass = false;
            return false;
        } else {
            $(".error-register-pass").html("");
        }

        if (pass.length < 8) {
            $(".error-register-pass").html("密码长度最少8位!");
            register.cPass = false;
            return false;
        } else {
            $(".error-register-pass").html("");
        }

        if (pass.length > 32) {
            $(".error-register-pass").html("密码长度最长32位!");
            register.cPass = false;
            return false;
        } else {
            $(".error-register-pass").html("");
        }

        var pass = $("#pass1").val();
        var re = new RegExp("[a-zA-Z]");
        var zimu = re.test(pass);
        re = new RegExp("[0-9]");
        var shuzi = re.test(pass);
        //re = new RegExp("((?=[\x21-\x7e]+)[^A-Za-z0-9])");
        //var zifu = re.test(pass);

        if (!zimu || !shuzi) {
            $(".error-register-pass").html("密码至少8位，且同时包含字母、数字!");
            register.cPass = false;
            return false;
        } else {
            $(".error-register-pass").html("");
        }


        // $("#pass1Check").attr("class", "sx_zq");
        // $("#pass1ErrorText").html("");

        // 密码验证通过
        register.cPass = true;

        // if ($("#pass2").val() != "") {
        // 	register.checkPassword2();
        // }
        return true;
    },
    /*checkPassword2: function() {
        var pass1 = $("#pass1").val();
        var pass2 = $("#pass2").val();
        if (pass2 == "") {
            $(".error-register-sure").html("请输入确认密码");
            register.cPass2 = false;
            return false;
        } else {
            $(".error-register-sure").html("");
        }
        if (pass1 != pass2) {
            $(".error-register-sure").html("两次输入密码不一致");
            register.cPass2 = false;
            return false;
        } else {
            $(".error-register-sure").html("");
        }

        // 	确认密码验证通过
        //register.cPass2 = true;
        return true;
    },*/
    checkAll: function() {
        if (!register.cPhone) {
            register.checkPhone();
            return;
        } else if (!register.cSmsCode) {
            register.checkSmsCode();
            return;
        } else if (!register.checkPassword()) {
            return;
        }

        /*if (!$("#fwtk").is(":checked")) {
            alert("请阅读并接受《易点租服务条款》");
            return;
        }*/
        var data = {
            "account": $("#name").val(),
            "phone": $("#phone").val(),
            "smsCode": $("#smsCode").val(),
            "password": $("#pass1").val(),
            "from_ad_source": $.cookie("from_ad_source")
        };
        var url = 'customer/registerByPhone';
        Utils.doRequestAjax(url, data, 'json', false, function(response) {
            if (response.code == 0) {
                $.cookie("token", response.data, {
                    path: "/"
                });
                window.location.href = "/toRegisterImprove";
            } else {
                register.flushImageCode();
                btntrue = true;
                alert(response.message);
            }

        }, function(response, XMLHttpRequest, textStatus, errorThrown) {
            alert('注册出现系统异常。');
        });
    }
    // getCartsCount: function() {
    //     var data = {};

    //     var url = 'order/carts/queryProductCount';
    //     Utils.doRequestAjax(url, data, 'json', false, function(response) {
    //         $("#cartsCount").html(response.data);
    //     }, function(response, XMLHttpRequest, textStatus, errorThrown) {
    //         //alert('读取购物车数量出现系统异常。');
    //     });
    // }
}
/**
 * 准备函数
 */
$(document).ready(function() {
    // 初始化
    register.init();

    // 查看购物车商品数量
    // register.getCartsCount();

    $(".blid-phone").click(function() {
        $(".bind-box").show();
    });

    $(".bind-main span").click(function() {
        $(".bind-box").hide();
    });
});


