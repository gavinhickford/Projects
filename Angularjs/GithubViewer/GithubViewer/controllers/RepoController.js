(function () {
    var app = angular.module("githubViewer");

    var RepoController = function ($scope, github, $routeParams) {
        var onRepoDetailsComplete = function (data) {
            $scope.repo = data;
        };

        var onError = function (response) {
            $scope.error = "Could not fetch the data.";
        };

        $scope.username = $routeParams.username;
        $scope.reponame = $routeParams.reponame;
        
        github.getRepoDetails($scope.username, $scope.repoName)
            .then(onRepoDetailsComplete, onError);
    }

    app.controller("RepoController", RepoController);
}());
