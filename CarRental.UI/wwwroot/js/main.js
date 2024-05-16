(function (window, document, undefined) {
	'use strict';

	/*==============================
	Header
	==============================*/
	if (document.querySelector('.header')) {
		const headerBtn = document.querySelector('.header__btn');
		const headerNav = document.querySelector('.header__menu');
		const header = document.querySelector('.header');

		function toggleHeaderMenu() {
			headerBtn.classList.toggle('header__btn--active');
			headerNav.classList.toggle('header__menu--active');
		}

		function toggleHeaderActive() {
			header.classList.toggle('header--active', window.scrollY > 0);
		}

		headerBtn.addEventListener('click', toggleHeaderMenu);
		window.addEventListener('scroll', toggleHeaderActive);
		toggleHeaderActive();
	}


	/*==============================
	price__groups
	==============================*/
	function formSpanStyle(groups, inputs, firstInputName) {
		inputs.forEach((input) => {
			const focused = input.name === firstInputName ? groups[0] : groups[1];
			input.addEventListener("focus", () => {
				focused.classList.remove("done");
				focused.classList.add("active");
			})
			input.addEventListener("blur", () => {
				if (input.value.trim().length == 0) {
					focused.classList.remove("active");
				}
				else {
					focused.classList.remove("active");
					focused.classList.add("done");
				}
			})
		})
	}

	const price_groups = document.querySelectorAll(".home__group.price__group");
	const price_inputs = document.querySelectorAll(".home__group.price__group input");
	formSpanStyle(price_groups, price_inputs, "min-price");

	/*==============================
	calenders
	==============================*/
	const calender_groups = document.querySelectorAll(".home__group.date__group");
	const calender_icons = document.querySelectorAll(".home__group.date__group svg");
	const calender_inputs = document.querySelectorAll(".home__group.date__group input.calender");
	formSpanStyle(calender_groups, calender_inputs, "from");

	for (const input of calender_inputs) {
		input.addEventListener("focus", () => {
			input.type = 'date';
			input.min = new Date().toISOString().split("T")[0];
			if (calender_inputs[0].value) {
				calender_inputs[1].min = calender_inputs[0].value;
			}
			input.showPicker();
			input.nextElementSibling.classList.add("d-none");
		})

		input.addEventListener("blur", () => {
			if (!input.value) {
				input.type = 'text';
				input.nextElementSibling.classList.remove("d-none");
			}
		})
	}

	for (const icon of calender_icons) {
		icon.addEventListener("click", () => {
			icon.previousElementSibling.focus();
		});
	}



	/*==============================
	Carousel
	==============================*/
	if (document.querySelector('.car__slider')) {
		var elms = document.getElementsByClassName('car__slider');

		for ( var i = 0; i < elms.length; i++ ) {
			new Splide(elms[ i ], {
				type: 'loop',
				drag: true,
				pagination: true,
				speed: 800,
				gap: 10,
				arrows: false,
				focus: 0,
			}).mount();
		}
	}

	if (document.querySelector('.main__carousel')) {
		var elms = document.getElementsByClassName('main__carousel');

		for ( var i = 0; i < elms.length; i++ ) {
			new Splide(elms[ i ], {
				type: 'loop',
				perPage: 1,
				drag: true,
				pagination: false,
				autoWidth: true,
				autoHeight: false,
				speed: 800,
				gap: 24,
				focus: 'center',
				arrows: false,
				breakpoints: {
					767: {
						gap: 20,
						focus: 1,
						autoHeight: true,
						pagination: true,
						arrows: false,
					},
					1199: {
						focus: 1,
						autoHeight: true,
						pagination: true,
						arrows: false,
					},
				}
			}).mount();
		}
	}

	if (document.querySelector('.details__slider')) {
		var details = new Splide('.details__slider', {
				type: 'loop',
				drag: true,
				pagination: false,
				speed: 800,
				gap: 15,
				arrows: false,
				focus: 0,
		});

		var thumbnails = document.getElementsByClassName("thumbnail");
		var current;

		for (var i = 0; i < thumbnails.length; i++) {
			initThumbnail(thumbnails[i], i);
		}

		function initThumbnail(thumbnail, index) {
			thumbnail.addEventListener("click", function () {
				details.go(index);
			});
		}

		details.on("mounted move", function () {
			var thumbnail = thumbnails[details.index];

			if (thumbnail) {
				if (current) {
					current.classList.remove("is-active");
				}

				thumbnail.classList.add("is-active");
				current = thumbnail;
			}
		});

		details.mount();
	}

	if (document.querySelector('#partners-slider')) {
		var partners = new Splide('#partners-slider', {
			type: 'loop',
			perPage: 6,
			drag: true,
			pagination: false,
			speed: 800,
			gap: 30,
			focus: 1,
			arrows: false,
			autoplay: true,
			interval: 4000,
			breakpoints: {
				575: {
					gap: 20,
					perPage: 2,
				},
				767: {
					gap: 20,
					perPage: 3,
				},
				991: {
					perPage: 4,
				},
				1199: {
					perPage: 5,
				},
			}
		});
		partners.mount();
	}

	/*==============================
	Filter
	==============================*/
	if (document.querySelector('.mfilter')) {
		var mfilterBtn = document.querySelector('.main__filter-menu');
		var mfilterClose = document.querySelector('.mfilter__close');
		var mfilter = document.querySelector('.mfilter');

		function toggleMfilter() {
			mfilter.classList.toggle('mfilter--active');
		}

		mfilterBtn.addEventListener('click', toggleMfilter);
		mfilterClose.addEventListener('click', toggleMfilter);
	}

	/*==============================
	Select
	==============================*/
	if (document.querySelector('#filter__status')) {
		new SlimSelect({
			select: '#filter__status',
			settings: {
				showSearch: false,
			}
		});
	}

	if (document.querySelector('#filter__category')) {
		new SlimSelect({
			select: '#filter__category'
		});
	}
	if (document.querySelector('#filter__seats')) {
		new SlimSelect({
			select: '#filter__seats'
		});
	}
	if (document.querySelector('#mfilter__status')) {
		new SlimSelect({
			select: '#mfilter__status',
			settings: {
				showSearch: false,
			}
		});
	}

	if (document.querySelector('#mfilter__category')) {
		new SlimSelect({
			select: '#mfilter__category'
		});
	}
	if (document.querySelector('#mfilter__seats')) {
		new SlimSelect({
			select: '#mfilter__seats'
		});
	}
	/*==============================
	Favorite
	==============================*/
	document.querySelectorAll('.car__favorite').forEach(function (element) {
		element.addEventListener('click', function () {
			var carId = element.getAttribute('cardata');
			// Make an AJAX request to the AddFavourite endpoint
			$.ajax({
				url: '/Cars/AddFavourite',
				type: 'GET',
				data: { id: carId },
				success: function (result) {
					if (result === 'add') {
						element.classList.add('car__favorite--active');
					} else if (result === 'del') {
						element.classList.remove('car__favorite--active');
					}
				},
				error: function () {
					// Handle the error if the request fails
				}
			});
		});
	});

	/*==============================
	Favorite
	==============================*/
	document.querySelectorAll('.brand-selection').forEach(function (element) {
		element.addEventListener('click', function () {
			var id = element.getAttribute('data-id');
			// Make an AJAX request to the AddFavourite endpoint
			$.ajax({
				url: '/Home/Models',
				type: 'GET',
				data: { id: id },
				success: function (result)
				{
					const selectioninput = document.querySelector(".model-input"); 
					const options = document.querySelector('.Model-selection');

					options.innerHTML = ''; // Remove all child elements
					for (let i = 0; i < result.length; i++) {
						var model = result[i].name;
						
						let li = document.createElement('li');
						li.addEventListener('click', function () {

							var value = li.getAttribute("data-id");
							if (value == null) {
								value = this.textContent;
							}
							selectioninput.value = value;
							selectioninput.textContent = this.textContent;
						})
						li.setAttribute("data-id", result[i].id);
						let txt = document.createTextNode(model);
						li.appendChild(txt);
						options.appendChild(li);
					}
				},
				error: function () {
					//alert("fuck!!");
				}
			});
		});
	});
	document.querySelectorAll('.offer__favorite').forEach(function (element) {
		element.addEventListener('click', function () {
			element.classList.toggle('offer__favorite--active');
		});
	});

	/*==============================
	Scrollbar
	==============================*/
	var Scrollbar = window.Scrollbar;

	if (document.querySelector('.cart__table-scroll')) {
		Scrollbar.init(document.querySelector('.cart__table-scroll'), {
			damping: 0.1,
			renderByPixels: true,
			alwaysShowTracks: true,
			continuousScrolling: true
		});
	}

	/*==============================
	Section bg
	==============================*/
	if (document.querySelector('.main--sign')) {
		var mainBg = document.querySelector('.main--sign');

		if (mainBg.getAttribute('data-bg')) {
			mainBg.style.background = `url(${mainBg.getAttribute('data-bg')})`;
			mainBg.style.backgroundPosition = 'center center';
			mainBg.style.backgroundRepeat = 'no-repeat';
			mainBg.style.backgroundSize = 'cover';
		}
	}

	/*==============================
	Modal
	==============================*/
	if (document.querySelector('#plan-modal')) {
		const myModalEl = document.getElementById('plan-modal');

		myModalEl.addEventListener('show.bs.modal', event => {
			if (window.innerWidth > 1200) {
				var header = document.querySelector('.header');
				var scrollBarWidth = window.innerWidth - document.documentElement.clientWidth;
				header.style.paddingRight = scrollBarWidth + "px";
			}
		});

		myModalEl.addEventListener('hidden.bs.modal', event => {
			if (window.innerWidth > 1200) {
				var header = document.querySelector('.header');
				header.style.paddingRight = '';
			}
		});
	}

	if (document.querySelector('#rent-modal')) {
		const myModalEl = document.getElementById('rent-modal');

		myModalEl.addEventListener('show.bs.modal', event => {
			if (window.innerWidth > 1200) {
				var header = document.querySelector('.header');
				var scrollBarWidth = window.innerWidth - document.documentElement.clientWidth;
				header.style.paddingRight = scrollBarWidth + "px";
			}
		});

		myModalEl.addEventListener('hidden.bs.modal', event => {
			if (window.innerWidth > 1200) {
				var header = document.querySelector('.header');
				header.style.paddingRight = '';
			}
		});
	}

})(window, document);