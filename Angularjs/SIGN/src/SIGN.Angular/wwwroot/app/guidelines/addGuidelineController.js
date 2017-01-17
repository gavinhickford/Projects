//addGuidelineController.js
(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("addGuidelineController", addGuidelineController);

    function addGuidelineController(guidelineService)
    {
        var vm = this;

        var onSuccess = function (data) {
            vm.newGuideline = {};
            window.location.href = '/app/guidelines';
        }

        var onError = function (reason) {
            vm.errorMessage = "Failed to save the guideline";
        };

        var onComplete = function () {
            vm.processing = false;
        };

        vm.newGuideline = {};
        vm.errorMessage = "";
        vm.processing = false;
        vm.addGuideline = function () {
            vm.processing = true;
            vm.errorMessage = "";
            guidelineService.addGuideline(vm.newGuideline)
                .then(onSuccess, onError)
                .finally(onComplete);
        };
    }
})();