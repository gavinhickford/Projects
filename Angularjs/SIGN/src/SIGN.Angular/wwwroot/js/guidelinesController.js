(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("guidelinesController", guidelinesController);

    function guidelinesController(guidelineService) {
        var vm = this;

        var onSuccess = function (data)
        {
            angular.copy(data, vm.guidelines);
        };

        var onError = function (reason)
        {
            vm.errorMessage = "Failed to load guidelines: " + error.status + " " + error.statusText;
        };

        var onComplete = function () {
            vm.processing = false;
        };

        vm.guidelines = [];
        vm.errorMessage = "";
        vm.processing = true;

        guidelineService.getGuidelines()
            .then(onSuccess, onError)
            .finally(onComplete);
    }
})();