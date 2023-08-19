 AOS.init({
 	duration: 800,
 	easing: 'slide',
 	once: true
 });

jQuery(document).ready(function($) {

	"use strict";

	var slider = function() {
		$('.nonloop-block-3').owlCarousel({
	    center: false,
	    items: 1,
	    loop: false,
			stagePadding: 15,
	    margin: 20,
	    nav: true,
			navText: ['<span class="icon-arrow_back">', '<span class="icon-arrow_forward">'],
	    responsive:{
        600:{
        	margin: 20,
          items: 2
        },
        1000:{
        	margin: 20,
          items: 3
        },
        1200:{
        	margin: 20,
          items: 3
        }
	    }
		});
	};
	slider();


	var siteMenuClone = function() {

		$('<div class="site-mobile-menu"></div>').prependTo('.site-wrap');

		$('<div class="site-mobile-menu-header"></div>').prependTo('.site-mobile-menu');
		$('<div class="site-mobile-menu-close "></div>').prependTo('.site-mobile-menu-header');
		$('<div class="site-mobile-menu-logo"></div>').prependTo('.site-mobile-menu-header');

		$('<div class="site-mobile-menu-body"></div>').appendTo('.site-mobile-menu');

		

		$('.js-logo-clone').clone().appendTo('.site-mobile-menu-logo');

		$('<span class="ion-ios-close js-menu-toggle"></div>').prependTo('.site-mobile-menu-close');
		

		$('.js-clone-nav').each(function() {
			var $this = $(this);
			$this.clone().attr('class', 'site-nav-wrap').appendTo('.site-mobile-menu-body');
		});


		setTimeout(function() {
			
			var counter = 0;
      $('.site-mobile-menu .has-children').each(function(){
        var $this = $(this);
        
        $this.prepend('<span class="arrow-collapse collapsed">');

        $this.find('.arrow-collapse').attr({
          'data-toggle' : 'collapse',
          'data-target' : '#collapseItem' + counter,
        });

        $this.find('> ul').attr({
          'class' : 'collapse',
          'id' : 'collapseItem' + counter,
        });

        counter++;

      });

    }, 1000);

		$('body').on('click', '.arrow-collapse', function(e) {
      var $this = $(this);
      if ( $this.closest('li').find('.collapse').hasClass('show') ) {
        $this.removeClass('active');
      } else {
        $this.addClass('active');
      }
      e.preventDefault();  
      
    });

		$(window).resize(function() {
			var $this = $(this),
				w = $this.width();

			if ( w > 768 ) {
				if ( $('body').hasClass('offcanvas-menu') ) {
					$('body').removeClass('offcanvas-menu');
				}
			}
		})

		$('body').on('click', '.js-menu-toggle', function(e) {
			var $this = $(this);
			e.preventDefault();

			if ( $('body').hasClass('offcanvas-menu') ) {
				$('body').removeClass('offcanvas-menu');
				$this.removeClass('active');
			} else {
				$('body').addClass('offcanvas-menu');
				$this.addClass('active');
			}
		}) 

		// click outisde offcanvas
		$(document).mouseup(function(e) {
	    var container = $(".site-mobile-menu");
	    if (!container.is(e.target) && container.has(e.target).length === 0) {
	      if ( $('body').hasClass('offcanvas-menu') ) {
					$('body').removeClass('offcanvas-menu');
				}
	    }
		});
	}; 
	siteMenuClone();


	var sitePlusMinus = function() {
		$('.js-btn-minus').on('click', function(e){
			e.preventDefault();
			if ( $(this).closest('.input-group').find('.form-control').val() != 0  ) {
				$(this).closest('.input-group').find('.form-control').val(parseInt($(this).closest('.input-group').find('.form-control').val()) - 1);
			} else {
				$(this).closest('.input-group').find('.form-control').val(parseInt(0));
			}
		});
		$('.js-btn-plus').on('click', function(e){
			e.preventDefault();
			$(this).closest('.input-group').find('.form-control').val(parseInt($(this).closest('.input-group').find('.form-control').val()) + 1);
		});
	};
	sitePlusMinus();


	var siteSliderRange = function() {
    $( "#slider-range" ).slider({
      range: true,
      min: 0,
      max: 500,
      values: [ 75, 300 ],
      slide: function( event, ui ) {
        $( "#amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
      }
    });
    $( "#amount" ).val( "$" + $( "#slider-range" ).slider( "values", 0 ) +
      " - $" + $( "#slider-range" ).slider( "values", 1 ) );
	};
	siteSliderRange();


	var siteMagnificPopup = function() {
		$('.image-popup').magnificPopup({
	    type: 'image',
	    closeOnContentClick: true,
	    closeBtnInside: false,
	    fixedContentPos: true,
	    mainClass: 'mfp-no-margins mfp-with-zoom', // class to remove default margin from left and right side
	     gallery: {
	      enabled: true,
	      navigateByImgClick: true,
	      preload: [0,1] // Will preload 0 - before current, and 1 after the current image
	    },
	    image: {
	      verticalFit: true
	    },
	    zoom: {
	      enabled: true,
	      duration: 300 // don't foget to change the duration also in CSS
	    }
	  });

	  $('.popup-youtube, .popup-vimeo, .popup-gmaps').magnificPopup({
	    disableOn: 700,
	    type: 'iframe',
	    mainClass: 'mfp-fade',
	    removalDelay: 160,
	    preloader: false,

	    fixedContentPos: false
	  });
	};
	siteMagnificPopup();



});

//const images = [
//    'images/hero_1.jpg',
//    'images/hero_2.jpg',
//	'images/hero_3.jpg',
	
//  ];

//  let currentIndex = 0;

//  function changeSlide(direction) {
//    currentIndex += direction;

//    if (currentIndex < 0) {
//      currentIndex = images.length - 1;
//    } else if (currentIndex >= images.length) {
//      currentIndex = 0;
//    }

//    const siteBlocksCover = document.querySelector('.site-blocks-cover');
//    siteBlocksCover.style.backgroundImage = `url(${images[currentIndex]})`;
//  }

//  document.querySelector('.prev-btn').addEventListener('click', function() {
//    changeSlide(-1);
//  });

//  document.querySelector('.next-btn').addEventListener('click', function() {
//    changeSlide(1);
//  });



//document.getElementById('fullScreenButton').onclick = function () {
//	toggleFullScreen();
//};

function toggleFullScreen() {
	var elem = document.documentElement; // Tüm belgeyi alır
	if (!document.fullscreenElement) {
		// Tam ekran değilse tam ekrana geç
		if (elem.requestFullscreen) {
			elem.requestFullscreen();
		} else if (elem.mozRequestFullScreen) { /* Firefox */
			elem.mozRequestFullScreen();
		} else if (elem.webkitRequestFullscreen) { /* Chrome, Safari ve Opera */
			elem.webkitRequestFullscreen();
		} else if (elem.msRequestFullscreen) { /* Internet Explorer */
			elem.msRequestFullscreen();
		}
	} else {
		// Tam ekransa ise tam ekranı kapat
		if (document.exitFullscreen) {
			document.exitFullscreen();
		} else if (document.mozCancelFullScreen) { /* Firefox */
			document.mozCancelFullScreen();
		} else if (document.webkitExitFullscreen) { /* Chrome, Safari ve Opera */
			document.webkitExitFullscreen();
		} else if (document.msExitFullscreen) { /* Internet Explorer */
			document.msExitFullscreen();
		}
	}
}

$(document).ready(function () {
	$("#myCarousel").find(".carousel-item").first().addClass("active");
	$("#myCarousel").carousel();
});


function getCartCunt() {
	$.ajax({
		type: "GET",
		url: "/sepet/sepetsayisi",
		success: function (data) {
			$(".count").text(data)
		},
		error: function (e) {
			alert(e.ResponseText)
		}
	});
}


function addCart(productid, stock) {
	var istenilenMiktar = $(".inputQuantity").val();
	if (istenilenMiktar <= stock) {
		$.ajax({
			type: "POST",
			url: "/sepet/sepeteekle",
			data: { "productid": productid, "quantity": istenilenMiktar },
			success: function (data) {
				if (data.indexOf("~") == -1) {
					$("#modalSepet .modal-body").text(data + " ürününden " + istenilenMiktar + " adet sepete başarı ile eklendi...")
					$("#modalSepet").modal('show');
					getCartCunt()
				}
			},
			error: function (e) {
				alert(e.ResponseText)
			}
		});
	} else if (stock == 0) alert("Bu ürün stoklarımızda bulunmamaktadır...")
	else alert("Bu üründen en fazla " + stock + " adet sipariş verebilirsiniz...")
}

function checkOutControl() {
	var mesaj = "";
	if ($(".selectPaymentOption").val() == "") mesaj = "Lütfen bir ödeme seçneği belirtiniz"

	if (mesaj != "") {
		alert(mesaj)
		return false;
	}
}



function funcSelectPaymentOption(_obje) {
	var seciliOption = $(_obje).val();
	if (seciliOption != "") {
		$(".divPaymentOption").slideUp();
		switch (seciliOption) {
			case "1":
				$(".creditCard").slideDown();
				break;
			case "2":
				$(".bank").slideDown();
				break;
			case "3":
				$(".door").slideDown();
				break;
		}
	}
}
