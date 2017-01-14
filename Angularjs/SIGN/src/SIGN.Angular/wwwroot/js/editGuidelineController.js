// editGuidelineController.js
(function () {
    "use strict";

    angular.module("app-guidelines")
    .controller("editGuidelineController", editGuidelineController);

    function editGuidelineController(guidelineService, $routeParams) {
        var vm = this;
        vm.guideline = {};
        vm.processing = true;
        vm.errorMessage = "";

        var onSuccess = function (response) {
            vm.guideline = response.data;
        };

        var onError = function (reason) {
            vm.errorMessage = "Failed to retrieve the guideline";
        };

        var onComplete = function () {
            vm.processing = false;
        };

        guidelineService.getGuideline($routeParams.id)
           .then(onSuccess, onError)
           .finally(onComplete);
    }
})();