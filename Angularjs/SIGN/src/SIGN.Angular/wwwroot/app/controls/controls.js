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
