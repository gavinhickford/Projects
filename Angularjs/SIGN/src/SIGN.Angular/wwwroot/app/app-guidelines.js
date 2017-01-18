﻿// app-guidelines.js
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
                    controller: "guidelineAddController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/guidelineAddView.html"
                })
                .when("/view/:id", {
                    controller: "guidelineDetailsController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/guidelineDetailsView.html"
                })
                .when("/edit/:id", {
                    controller: "guidelineEditController",
                    controllerAs: "vm",
                    templateUrl: "/app/guidelines/guidelineEditView.html"
                })
                .otherwise({ redirectTo: "/" });
    });
})();