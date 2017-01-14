(function () {

    var guidelineService = function ($http) {

        var getGuidelines = function () {
            return $http.get("/api/guidelines")
            .then(function (response) {
                return response.data;
            });
        };

        var addGuideline = function (guideline) {
            return $http.post("/api/guidelines", guideline)
        };

        // Revealing module pattern
        return {
            getGuidelines: getGuidelines,
            addGuideline: addGuideline
        };
    };

    var module = angular.module("app-guidelines")
        .factory("guidelineService", guidelineService)
})();
