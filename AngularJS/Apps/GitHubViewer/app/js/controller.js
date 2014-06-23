(function(){

	var app = angular.module('GitHubViewer', []);

	var GitHubController = function($scope, gitHub, $interval, $log, $anchorScroll, $location){

		var onUserRetrieved = function(data){
			$scope.user = data;

			gitHub.getRepos($scope.user)
				  .then(onRepositoriesRetrieved, onRepoError)
		};

		var onRepositoriesRetrieved = function(data){
			$scope.repos = data;
			$location.hash("userDetails");
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

		var decrementCountdown = function(){
			$scope.countdown -= 1;
			if ($scope.countdown < 1){
				$scope.onSearch();
			}
		}

		$scope.onSearch = function(username){
			$log.info("Searching for " + $scope.username);
			console.log($scope.username);
			gitHub.getUser(username)
			 	  .then(onUserRetrieved, onUserError);	
			if (countdownInterval){
				$interval.cancel(countdownInterval);
				$scope.countdown = null;
			}
		};

		$scope.onSort = function(sortParam){
			$scope.repoSortOrder = sortParam;	
		}

		var countdownInterval = null;
		var startCountdown = function(){
			countdownInterval= $interval(decrementCountdown, 1000);
		}

		startCountdown();

		$scope.appname = "GitHub Viewer";
		$scope.username = "angular";
		$scope.repoSortOrder = "name";
		$scope.countdown = 10;
	};

	 app.controller('GitHubController',GitHubController); 

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

