(function () {

    var guidelineService = function ($http) {

        var getGuidelines = function () {
            return $http.get("/api/guidelines")
            .then(function (response) {
                return response.data;
            });
        };

        var addGuideline = function (guideline) {
            return $http.post("/api/guidelines", guideline);
        };

        var getGuideline = function (id) {
            return $http.get("/api/guidelines/" + id)
            .then(function (response) {
                return response.data;
            });
        };

        // Revealing module pattern
        return {
            getGuidelines: getGuidelines,
            addGuideline: addGuideline,
            getGuideline: getGuideline
        };
    };

    var module = angular.module("app-guidelines")
        .factory("guidelineService", guidelineService)
})();
