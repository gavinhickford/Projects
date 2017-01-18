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

        var onRetrievalSuccess = function (data) {
            vm.guideline = data;
            vm.guideline.datePublished = new Date(data.datePublished);
        };

        var onRetrievalError = function (reason) {
            vm.errorMessage = "Failed to retrieve the guideline";
        };

        var onSaveSuccess = function (data) {
            //vm.guideline = data;
        };

        var onSaveError = function (reason) {
            vm.errorMessage = "Failed to save the guideline";
        };

        var onComplete = function () {
            vm.processing = false;
        };

        guidelineService.getGuideline($routeParams.id)
           .then(onRetrievalSuccess, onRetrievalError)
           .finally(onComplete);

        vm.editGuideline = function(){
            vm.processing = true;
            vm.errorMessage = "";
            guidelineService.saveGuideline(vm.guideline)
                .then(onSaveSuccess, onSaveError)
                .finally(onComplete);
        };
    }
})();