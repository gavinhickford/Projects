(function () {
    "use strict";

    angular.module("app-guidelines")
        .controller("guidelinesController", guidelinesController);

    function guidelinesController($http) {
        var viewModel = this;

        viewModel.guidelines = [];
        viewModel.newGuideline = {};
        viewModel.errorMessage = "";
        viewModel.processing = true;
        viewModel.addGuideline = function () {
            viewModel.processing = true;
            viewModel.errorMessage = "";
            $http.post("/api/guidelines", viewModel.newGuideline)
            .then(function (response) {
                // successfully added
                viewModel.guidelines.push(response.data);
                viewModel.newGuideline = {};
            },
            function () {
                // failed
                viewModel.errorMessage = "Failed to save the guideline";
            })
            .finally(function() {
                viewModel.processing = false;
            });
        };

        $http.get("/api/guidelines")
            .then(function (response) {
                // successful retrieval
                angular.copy(response.data, viewModel.guidelines);
            },
            function (error) {
                // failed retrieval
                viewModel.errorMessage = "Failed to load guidelines: " + error.status + " " + error.statusText;
            })
        .finally(function () {
            viewModel.processing = false;
        });


    };

})();