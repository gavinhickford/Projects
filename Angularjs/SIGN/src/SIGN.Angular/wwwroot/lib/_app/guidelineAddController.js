!function(){"use strict";function e(e){var n=this,i=function(e){n.newGuideline={},window.location.href="/app/guidelines"},o=function(e){n.errorMessage="Failed to save the guideline"},r=function(){n.processing=!1};n.newGuideline={},n.errorMessage="",n.processing=!1,n.addGuideline=function(){n.processing=!0,n.errorMessage="",e.saveGuideline(n.newGuideline).then(i,o).finally(r)}}angular.module("app-guidelines").controller("guidelineAddController",e)}();