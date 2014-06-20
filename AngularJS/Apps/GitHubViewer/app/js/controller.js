(function(){

	var app = angular.module('GitHubViewer', []);

	var GitHubController = function($scope,$http){

		var onUserRetrieved = function(response){
			$scope.user = response.data;

			$http.get($scope.user.repos_url)
				 .then(onRepositoriesRetrieved, onRepoError)
		};

		var onRepositoriesRetrieved = function(response){
			$scope.repos = response.data;
		};

		var onRepoError = function(reason){
			console.log(reason);
			$scope.error = "Could not fetch repositories";
		};

		var onUserError = function(reason){
			console.log(reason);
			$scope.error = "Could not fetch the user";
		};

		$scope.onSearch = function(){
			console.log($scope.username);
			$http.get("https://api.github.com/users/" + $scope.username)
			 	 .then(onUserRetrieved, onUserError);	
		};

		$scope.onSort = function(sortParam){
			$scope.repoSortOrder = sortParam;	
		}

		$scope.appname = "GitHub Viewer";
		$scope.username = "angular";
		$scope.repoSortOrder = "name";
	};

	 app.controller('GitHubController', ["$scope","$http",GitHubController]); // passing array for bundiling and minification

}());








































// var work = function(){
// 	console.log('working...');	
// }

// var doWork = function(f){
// 	console.log('starting work...');
// 	f();
// 	console.log('ending work...');
// }

// doWork(work);

// (function(){
// 	var createWorker = function(){
// 		var workCount = 0;	
// 		var task1 = function(){
// 			workCount ++;
// 			console.log("doing job 1 " + workCount);
// 		};

// 		var task2 = function(){
// 			workCount ++;
// 			console.log("doing job 2 " + workCount);
// 		};

// 		return {
// 			job1:task1,
// 			job2:task2
// 		};
// 	}

// 	var worker = createWorker();
// 	worker.job1();
// 	worker.job2();
// 	worker.job1();
// }());

