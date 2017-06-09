$(document).ready(function(){
	$(".regis_yd label").click(function(){
		var check = $(this).find("input").prop("checked");
		if(check == true){
			$(".dl_ljA").css({
				"color":"#fff",
				"background":"#37a3ff"
			});
		}
		if(check == false){
			$(".dl_ljA").css({
				"background":"#dee2e6",
				"color":"#333"
			});
		}
	})
});

$(document).ready(function(){
	$(".main2_ul li").click(function(){
		$(this).addClass("on").siblings().removeClass("on");
		var tabId = $(this).attr("tabId");
		$("#"+tabId).show().siblings().hide();
	});
	$(".main2_ulCho li").click(function(){
		$(this).addClass("on").siblings().removeClass("on");
		var tabIdlist = $(this).attr("tabId");
		$("#"+tabIdlist).show().siblings().hide();
	});
	$(".coupon_mainK").click(function(){
		if($(this).find(".coupon_click").is(":hidden")){
			$(this).find(".coupon_click").show();
			$(this).siblings(".coupon_mainK").find(".coupon_click").hide();
		}else{
			$(this).find(".coupon_click").hide();
		}
	})
})
$(document).ready(function(){
	
});
$(document).ready(function(){
	$(".receipt_label").click(function(){
		$(this).addClass("receipt_show")
		$(this).parent("dt").parent(".receipt_sz").parent(".receipt_content").siblings(".receipt_content").children(".receipt_sz").children("dt").find("label").removeClass("receipt_show")
	})
});
$(document).ready(function(){
	$(".modify_text,.modify_text1").focus(function(){
		$(this).css({"border":"1px solid #cccccc"})
	});
	$(".modify_text,.modify_text1").blur(function(){
		$(this).css({"border":"1px solid #e5e4e4"})
	})
})
	
$(document).ready(function(){
	$(".receipt_move").click(function(){
		$(".receipt_moveMain").show();
	});
	$(".move_btn2").click(function(){
		$(".receipt_moveMain").hide();
	})
})

$(document).ready(function(){
	$(".receipt_sz dd.btn_sc").click(function(){
		$(".delete_tk").show();
	})
	$(".delete_tk .delete_cont p.btn_p1 input").click(function(){
		$(".delete_tk").hide();
	})
})

$(document).ready(function(){
	$(".regis_get").one("click",function(){
		$(this).html(60+"s 后可点击重新发送");
		$(this).addClass("on");
		/*$(this).hide();
		$(".zhuce_dl dt p.yz_p").show()
		$(".zhuce_dl dt p.yz_p span.sp_btn input").addClass("on");*/
		var i = 5;
		var setin = setInterval(function(){
			i--;
			if(i==0){
				clearInterval(setin)
				$(".regis_get").html("未收着验证码");
				$(".regis_get").removeClass("on")
				$(".regis_get").one("click",function(){
					$(".denglu_dl p .yz_p").show();
				})
			}else{
				$(".regis_get").html(""+i+"s 后可点击重新发送");
			}
		},1000)
	})
	$(".denglu_dl p .yz_p span input").click(function(){
		$(".regis_get").html(60+"s 后可点击重新发送");
		$(".regis_get").addClass("on");
		$(".denglu_dl p .yz_p").hide();
		var b = 5;
		var setin2 = setInterval(function(){
			b--;
			if(b==0){
				clearInterval(setin2)
				$(".regis_get").html("未收着验证码");
				$(".regis_get").removeClass("on");
				$(".regis_get").one("click",function(){
					$(".denglu_dl p .yz_p").show();
				})
			}else{
				$(".regis_get").html(""+b+"s 后可点击重新发送")
				}
			},1000)
		})
	})