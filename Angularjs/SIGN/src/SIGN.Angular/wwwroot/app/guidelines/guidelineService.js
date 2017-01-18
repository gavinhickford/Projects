(function () {

    var guidelineService = function ($http) {

        var getGuidelines = function () {
            return $http.get("/api/guidelines")
            .then(function (response) {
                return response.data;
            });
        };

        var saveGuideline = function (guideline) {
            return $http.post("/api/guidelines", guideline)
            .then(function (response) {
                return response.data;
            });
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
            saveGuideline: saveGuideline,
            getGuideline: getGuideline
        };
    };

    var module = angular.module("app-guidelines")
        .factory("guidelineService", guidelineService)
})();
