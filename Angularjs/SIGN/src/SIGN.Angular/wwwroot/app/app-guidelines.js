// app-guidelines.js
(function () {
    "use strict";

    angular.module("app-guidelines", ["controls", "ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider
                .when("/", {
                    controller: "guidelinesController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/guidelinesView.html"
                })
                .when("/add", {
                    controller: "addGuidelineController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/addGuidelineView.html"
                })
                .when("/view/:id", {
                    controller: "viewGuidelineController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/viewGuidelineView.html"
                })
                .when("/edit/:id", {
                    controller: "editGuidelineController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/editGuidelineView.html"
                })
                .otherwise({ redirectTo: "/" });
    });
})();