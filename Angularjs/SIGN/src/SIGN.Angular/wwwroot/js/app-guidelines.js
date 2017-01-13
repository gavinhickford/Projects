// app-guidelines.js
(function () {
    "use strict";

    angular.module("app-guidelines", ["controls", "ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider
                .when("/", {
                    controller: "guidelinesController",
                    controllerAs: "vm",
                    templateUrl: "/views/guidelinesView.html"
                })
                .when("/add", {
                    controller: "addGuidelineController",
                    //controllerAs: "viewModel",
                    templateUrl: "/views/addGuidelineView.html"
                })
                .otherwise({ redirectTo: "/" });
    });
})();