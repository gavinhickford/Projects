(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("guidelinesController", guidelinesController);

    function guidelinesController(guidelineService) {
        var vm = this;

        var onGetSuccess = function (data)
        {
            angular.copy(data, vm.guidelines);
        };

        var onGetError = function (reason)
        {
            vm.errorMessage = "Failed to load guidelines: " + error.status + " " + error.statusText;
        };

        //var onPostSuccess = function (response)
        //{
        //    // successfully added
        //    vm.guidelines.push(response.data);
        //    vm.newGuideline = {};
        //};

        //var onPostError =function(reason)
        //{
        //    // failed
        //    vm.errorMessage = "Failed to save the guideline";
        //};

        var onComplete = function () {
            vm.processing = false;
        };

        vm.guidelines = [];
        //vm.newGuideline = {};
        vm.errorMessage = "";
        vm.processing = true;
        //vm.addGuideline = function () {
        //    vm.processing = true;
        //    vm.errorMessage = "";
        //    guidelineService.addGuideline(newGuideline)
        //        .then(onPostSuccess, onPostError)
        //        .finally(onComplete);
        //};

        guidelineService.getGuidelines()
            .then(onGetSuccess, onGetError)
            .finally(onComplete);
    }
})();