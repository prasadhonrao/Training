var customerModule = angular.module('customerApp',[]);

var customersController = function($scope){
	console.log('Initializing customer controller');
	$scope.customers = [
							{name:'Prasad Honrao', company:'Cognizant'},
							{name:'Girish Kamble', company:'Cognizant'},
							{name:'Colin Gray', company:'JPMC'},
							{name:'Anil Sathe', company:'Cognizant'},
							{name:'John Papa', company:'Pluralsight'},
							{name:'Dan Wahlin', company:'Wahlin Group'},
							{name:'Sangram Patil', company:'Infosys'},
							{name:'Scott Hanselman', company:'Microsoft'}
						];
};

customerModule.controller('customersController', customersController);