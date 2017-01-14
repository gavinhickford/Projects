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
                    controllerAs: "vm",
                    templateUrl: "/views/addGuidelineView.html"
                })
                .when("/view/:id", {
                    controller: "viewGuidelineController",
                    controllerAs: "vm",
                    templateUrl: "/views/viewGuidelineView.html"
                })
                .when("/edit/:id", {
                    controller: "editGuidelineController",
                    controllerAs: "vm",
                    templateUrl: "/views/editGuidelineView.html"
                })
                .otherwise({ redirectTo: "/" });
    });
})();