(function(){

	var app = angular.module('GitHubViewer', []);

	var GitHubController = function($scope, gitHub){

		var onUserRetrieved = function(data){
			$scope.user = data;

			gitHub.getRepos($scope.user)
				  .then(onRepositoriesRetrieved, onRepoError)
		};

		var onRepositoriesRetrieved = function(data){
			$scope.repos = data;
			$anchorScroll();
		};

		var onRepoError = function(reason){
			console.log(reason);
			$scope.error = "Could not fetch repositories";
		};

		var onUserError = function(reason){
			console.log(reason);
			$scope.error = "Could not fetch the user";
		};

		$scope.onSearch = function(username){
			gitHub.getUser(username)
			 	  .then(onUserRetrieved, onUserError);	
		};

		$scope.onSort = function(sortParam){
			$scope.repoSortOrder = sortParam;	
		}

		$scope.appname = "GitHub Viewer";
		$scope.username = "angular";
		$scope.repoSortOrder = "name";
		$scope.countdown = 10;
	};

	 app.controller('GitHubController',GitHubController); 

}());
