// app-guidelines.js
(function () {
    "use strict";

    angular.module("app-guidelines", ["controls", "ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider.when("/", {
            controller: "guidelinesController",
            controllerAs: "viewModel",
            templateUrl: "/views/guidelinesView.html"
        });

        $routeProvider.when("/add", {
            controller: "addGuidelineController",
            controllerAs: "viewModel",
            templateUrl: "/views/addGuidelineView.html"
        });

        $routeProvider.otherwise({ redirectTo: "/" });
    });
})();