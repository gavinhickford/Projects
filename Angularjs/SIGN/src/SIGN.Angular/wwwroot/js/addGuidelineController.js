//addGuidelineController.js
(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("addGuidelineController", addGuidelineController);

    function addGuidelineController($http)
    {
        var vm = this;
        vm.newGuideline = {};
        vm.errorMessage = "";
        vm.processing = false;
        vm.addGuideline = function () {
            vm.processing = true;
            vm.errorMessage = "";
            $http.post("/api/guidelines", vm.newGuideline)
            .then(function (response) {
                // successfully added
                //vm.guidelines.push(response.data);
                vm.newGuideline = {};
            },
            function () {
                // failed
                vm.errorMessage = "Failed to save the guideline";
            })
            .finally(function () {
                vm.processing = false;
            });
        };
    }
})();