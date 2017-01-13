(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("guidelinesController", guidelinesController);

    function guidelinesController($http) {
        var vm = this;

        vm.guidelines = [];
        vm.newGuideline = {};
        vm.errorMessage = "";
        vm.processing = true;
        vm.addGuideline = function () {
            vm.processing = true;
            vm.errorMessage = "";
            $http.post("/api/guidelines", vm.newGuideline)
            .then(function (response) {
                // successfully added
                vm.guidelines.push(response.data);
                vm.newGuideline = {};
            },
            function () {
                // failed
                vm.errorMessage = "Failed to save the guideline";
            })
            .finally(function() {
                vm.processing = false;
            });
        };

        $http.get("/api/guidelines")
            .then(function (response) {
                // successful retrieval
                angular.copy(response.data, vm.guidelines);
            },
            function (error) {
                // failed retrieval
                vm.errorMessage = "Failed to load guidelines: " + error.status + " " + error.statusText;
            })
        .finally(function () {
            vm.processing = false;
        });
    }
})();