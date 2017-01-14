// editGuidelineController.js
(function () {
    "use strict";

    angular.module("app-guidelines")
    .controller("editGuidelineController", editGuidelineController);

    function editGuidelineController($http, $routeParams) {

        var onSuccess = function (response) {
            vm.guideline = response.data;
        };

        var onError = function (reason) {
            vm.errorMessage = "Failed to retrieve the guideline";
        };

        var vm = this;
        vm.guideline = {};
        vm.processing = true;
        vm.errorMessage = "";
        var id = $routeParams.id;
        $http.get("/api/guidelines/" + id)
           .then(onSuccess, onError)
           .finally(function () {
               vm.processing = false;
           });
    }
})();