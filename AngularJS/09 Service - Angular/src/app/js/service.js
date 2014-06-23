(function(){

	var app = angular.module("Animation",[]);

	var animationController = function($scope, $interval){

		var decrementCountdown = function(){
			$scope.value = $scope.value - 1;
			if ($scope.value < 0){
				$scope.value = null;				
			}
		};

		var countdownInterval = null;
		var startCountdown = function(){
			countdownInterval= $interval(decrementCountdown, 1000);
		};

		startCountdown();

		$scope.value = 10;
	}

	app.controller("AnimationController", animationController);

}());