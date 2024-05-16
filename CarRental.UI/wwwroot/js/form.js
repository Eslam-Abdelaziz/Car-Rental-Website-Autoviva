function filterFunction(that, event) {
	let container, input, filter, li, input_val;
	container = $(that).closest(".select-box");
	input_val = container.find("input").val().toUpperCase();

	if (event.key === "Enter") {
		container.find("input").val(container.find("ul li.selected").text()).blur();
		container.find("ul").removeClass("active")
		onSelect(container.find("ul li.selected").text());
		container.find("ul li.selected")[0].scrollIntoView({
			behavior: "smooth",
		});
	} else {
		li = container.find("ul li");
		li.each(function (i, obj) {
			if ($(this).text().toUpperCase().indexOf(input_val) > -1) {
					$(this).show();
			} else {
					$(this).hide();
			}
		});

		container.find("ul li").removeClass("selected");
		setTimeout(function () {
				container.find("ul li:visible").first().addClass("selected");
		}, 100)
	}
}

$(".select-box input").focus(function () {

	$(this).closest(".select-box").find("ul").addClass("active");
	$(this).closest(".select-box").addClass("active");
	$(this).closest(".select-box").find("ul li").show();
	$(this).closest(".select-box").find("svg").addClass("active");
});

$(document).on('click', '.select-box ul li', function () {

	$(this).closest(".select-box").find("input").val($(this).text()).blur();
	$(this).closest(".select-box ul").removeClass("active");
	$(this).closest(".select-box").addClass("done");
});
 
$(".select-box input").blur(function () {
	let that = this;

	setTimeout(function () {


	

		$(that).closest(".select-box").find("ul").removeClass("active");
			$(that).closest(".select-box").removeClass("active");
			$(that).closest(".select-box").find("svg").removeClass("active");
		}, 300)
	});

$(document).on('click', '.select-box svg', function () {				
	$(this).closest(".select-box").find("ul").toggleClass("active");
	$(this).closest(".select-box").toggleClass("active");
	$(this).closest(".select-box").find("svg").toggleClass("active");
});

$(".select-box ul li").hover(function () {
	$(this).closest(".select-box").find("ul li.selected").removeClass("selected");
	$(this).addClass("selected");
});