(function ($) {
	function setChecked(target) {
		var checked = $(target).find("input[type='checkbox']:checked").length;
		if (checked) {
			$(target).find('select option:first').html('Выбрано: ' + checked);
		} else {
			$(target).find('select option:first').html('Выберите из списка');
		}
	}
 
	$.fn.checkselect = function() {
		this.wrapInner('<div class="checkselect-popup"></div>');
		this.prepend(
			'<div class="checkselect-control">' +
				'<select class="form-control"><option></option></select>' +
				'<div class="checkselect-over"></div>' +
			'</div>'
		);	
 
		this.each(function(){
			setChecked(this);
		});		
		this.find('input[type="checkbox"]').click(function(){
			setChecked($(this).parents('.checkselect'));
		});
 
		this.parent().find('.checkselect-control').on('click', function(){
			$popup = $(this).next();
			$('.checkselect-popup').not($popup).css('display', 'none');
			if ($popup.is(':hidden')) {
				$popup.css('display', 'block');
				$(this).find('select').focus();
			} else {
				$popup.css('display', 'none');
			}
		});
 
		$('html, body').on('click', function(e){
			if ($(e.target).closest('.checkselect').length == 0){
				$('.checkselect-popup').css('display', 'none');
			}
		});
	};
})(jQuery);	
 
$('.checkselect').checkselect();

/*function DropDown(el) {
	this.dd = el;
	this.placeholder = this.dd.children('span');
	this.opts = this.dd.find('ul.dropdown > li');
	this.result = $('.dropdown-result');
	this.resultClose = $('.dropdown-result .result-block .result-close');
	this.val = '';
	this.index = -1;
	this.initEvents();
	
}
DropDown.prototype = {
	initEvents : function() {
		var obj = this;
		obj.dd.data("value", {});
		obj.dd.on('click', function(event){
			$(this).toggleClass('active');
			return false;
		});

		obj.opts.on('click',function(){
			var opt = $(this);
			obj.val = opt.text();
			obj.index = opt.index();
			obj.placeholder.text('' + obj.val);
			
			var temp = obj.dd.data("value");
			temp[obj.val] = obj.val;
			obj.dd.data("value",temp);
			
			obj.result.html(obj.result.html()+"<div class='result-block' data-value='"+obj.val+"'>"+obj.val+"<div class='result-close'>x</div></div>");
			$('.result-close').on("click",function(){
				$(this).parent().remove();
				var temp = obj.dd.data("value");
				delete(temp[$(this).parent().data("value")]);
				obj.dd.data("value",temp);

			});
		});
		
		
	},
	getValue : function() {
		return  obj.dd.data("value");
	},
	getIndex : function() {
		return this.index;
	}
}

$(function() {
	var dd = new DropDown( $('#dd') );
	$(document).click(function() {
		// all dropdowns
		$('.wrapper-dropdown-1').removeClass('active');
	});

});*/