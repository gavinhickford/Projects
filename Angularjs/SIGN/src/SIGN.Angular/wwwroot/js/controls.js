// controls.js
(function () {
    "use strict";

    angular.module("controls", [])
        .directive("waitCursor", waitCursor)
        .directive("guidelineStatus", guidelineStatus);

    function waitCursor() {
        return {
            restrict: "E",
            scope: {
                displayWhen: "=displayWhen"
            },
            templateUrl: "/views/waitCursor.html"
        };
    };

    function guidelineStatus() {
        return {
            restrict: "E",
            templateUrl: "/views/guidelineStatus.html"
        };
    };
})();
