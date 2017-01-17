// controls.js
(function () {
    "use strict";

    angular.module("controls", [])
        .directive("waitCursor", waitCursor)
        .directive("guidelineStatus", guidelineStatus)
        .directive('convertToNumber', convertToNumber);

    function convertToNumber() {
        return {
            require: 'ngModel',
            link: function (scope, element, attrs, ngModel) {
                ngModel.$parsers.push(function (val) {
                    return val != null ? parseInt(val, 10) : null;
                });
                ngModel.$formatters.push(function (val) {
                    return val != null ? '' + val : null;
                });
            }
        };
    };

    function waitCursor() {
        return {
            restrict: "E",
            scope: {
                displayWhen: "=displayWhen"
            },
            templateUrl: "/app/controls/waitCursor.html"
        };
    };

    function guidelineStatus() {
        return {
            restrict: "E",
            scope: {
                statusId: "=statusId"
            },
            templateUrl: "/app/controls/guidelineStatus.html"
        };
    };
})();
