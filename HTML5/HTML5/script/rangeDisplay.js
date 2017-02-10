// rangeDisplay.js

(function() {
	$("#devExperienceRange").on("change",
			function () {
				$("#rangeValue").text(this.value);
			});
})();