!function(){"use strict";function e(e,i){var n=this;n.guideline={},n.processing=!0,n.errorMessage="";var r=function(e){n.guideline=e},t=function(e){n.errorMessage="Failed to retrieve the guideline"},l=function(){n.processing=!1};e.getGuideline(i.id).then(r,t).finally(l)}e.$inject=["guidelineService","$routeParams"],angular.module("app-guidelines").controller("guidelineDetailsController",e)}();