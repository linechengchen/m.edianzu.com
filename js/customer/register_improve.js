/*
 * 注册完善信息
 */
var register_improve = {
    init: function() {
        var CLICK_OR_TOUCHEND = 'ontouchend' in document ? 'touchend click' : 'click';
        $(document)
            .on('blur', '._company_name', register_improve.checkCompanyName)
            .on('blur', '._name', register_improve.checkName)
            .on('blur', '._job', register_improve.checkJob)
            .on('blur', '._email', register_improve.checkEmail)
            .on(CLICK_OR_TOUCHEND, '._num_select', register_improve.toggleNumList)
            .on(CLICK_OR_TOUCHEND, '._submit_btn', register_improve.submit)
            .on(CLICK_OR_TOUCHEND, '._num_list li', register_improve.choseNum)
            .on(CLICK_OR_TOUCHEND, function() {
                register_improve.hideNumList();
            });
    },
    //验证公司名
    checkCompanyName: function() {
        var value = $.trim($('._company_name').val());
        if (!value) {
            $('._company_name_error').show().text('请输入公司名');
            return false;
        } else if (!/^[a-zA-Z0-9\u4E00-\u9FA5（）()]{3,}$/.test(value)) {
            $('._company_name_error').show().text('请输入正确公司名');
            return false;
        } else {
            $('._company_name_error').hide().text('');
            return true;
        }
    },
    //验证公司人数
    checkNum: function() {
        var num = $('._num').attr('data-value');
        if (!num) {
            $('._num_error').show().text('请输入人数');
            return false;
        } else {
            $('._num_error').hide().text('');
            return true;
        }
    },
    //验证姓名
    checkName: function() {
        var name = $('._name').val();
        if (!name) {
            $('._name_error').show().text('请输入姓名');
            return false;
        } else if (!/^[a-zA-Z0-9\u4E00-\u9FA5]{2,}$/.test(name)) {
            $('._name_error').show().text('请输入正确姓名');
            return false;
        } else {
            $('._name_error').hide().text('');
            return true;
        }
    },
    //验证职位
    checkJob: function() {
        var value = $('._job').val();
        if (!value) {
            $('._job_error').show().text('请输入职位');
            return false;
        } else if (!/^[a-zA-Z0-9\u4E00-\u9FA5]{1,}$/.test(value)) {
            $('._job_error').show().text('请输入正确职位');
            return false;
        } else {
            $('._job_error').hide().text('');
            return true;
        }
    },
    //验证邮箱
    checkEmail: function() {
        var value = $('._email').val();
        if (!value) {
            $('._email_error').show().text('请输入邮箱');
            return false;
        } else if (!/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])+(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/.test(value)) {
            $('._email_error').show().text('请输入正确邮箱');
            return false;
        } else {
            $('._email_error').hide().text('');
            return true;
        }
    },
    //显示下拉菜单
    toggleNumList: function() {
        $('._num_list').toggle();
        return false;
    },
    //隐藏下拉菜单
    hideNumList: function() {
        $('._num_list').hide();
        return false;
    },
    //选择人数
    choseNum: function() {
        var $item = $(this).find('a');
        var num = $item.text();
        var value = $item.attr('data-value');
        $('._num')
            .text(num)
            .attr('data-value', value)
            .css('color', 'initial');
        $('._num_error').hide().text(''); //清除错误提示
    },
    //提交
    submit: function() {
        $('._submit_btn').attr('disabled','disabled');
        var valid = true;
        if (!register_improve.checkCompanyName()) {
            valid = false;
        }
        if (!register_improve.checkNum()) {
            valid = false;
        }
        if (!register_improve.checkName()) {
            valid = false;
        }
        if (!register_improve.checkJob()) {
            valid = false;
        }
        if (!register_improve.checkEmail()) {
            valid = false;
        }
        if (!valid) {
            return false;
        }
        var data = {
            companyName: $.trim($('._company_name').val()),
            employeeNumType: $('._num').attr('data-value'),
            registerName: $.trim($('._name').val()),
            registerJob: $.trim($('._job').val()),
            registerEmail: $.trim($('._email').val())
        };
        Utils.doRequestAjax('customer/registerImprove', data, 'json', false, function(response) {
            if (response.code == 0) {
                window.location.href = "index";
            } else {
                alert(response.message);
                $('._submit_btn').removeAttr('disabled');
            }
        }, function(response, XMLHttpRequest, textStatus, errorThrown) {
            alert('出现系统异常。');
        });
    }
};

$(document).ready(function() {
    register_improve.init();
});
