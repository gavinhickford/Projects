// controls.js
(function () {
    "use strict";

    angular.module("controls", [])
        .directive("waitCursor", waitCursor);

    function waitCursor() {
        return {
            restrict: "E",
            scope: {
                displayWhen: "=displayWhen"
            },
            templateUrl: "/views/waitCursor.html"
        };
    };
})();
