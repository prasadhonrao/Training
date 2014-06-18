var customerApp = angular.module('customerApp',['ngRoute']);

customerApp.config(['$routeProvider',
                    function($routeProvider) {
                        $routeProvider
                          .when('/', {
                              controller:'customersController',
                              templateUrl: 'partials/home.html'
                          })
                          .when('/list', {
                              controller:'customersController',
                        			templateUrl: 'partials/list.html'
                        	})
                          .when('/add', {
                            	controller:'customersController',
                    			    templateUrl: 'partials/add.html'
                        	})
                          .otherwise({
                              redirectTo: '/'
                          });
}]);

customerApp.factory('customerFactory', function (){
    var customers = [
                          {name:'Prasad Honrao', company:'Cognizant'},
                          {name:'Rahul Gorule', company:'Cognizant'},
                          {name:'Girish Kamble', company:'Cognizant'},
                          {name:'Colin Gray', company:'JPMC'},
                          {name:'Anil Sathe', company:'Cognizant'},
                          {name:'John Papa', company:'Pluralsight'},
                          {name:'Dan Wahlin', company:'Wahlin Group'},
                          {name:'Sangram Patil', company:'Infosys'},
                          {name:'Scott Hanselman', company:'Microsoft'}
                    ];
    var factory = {};
    factory.getCustomers = function(){
      return customers;
    };

    return factory;
});

var customersController = function($scope,customerFactory){
    $scope.customers = customerFactory.getCustomers();
    
    $scope.addCustomer = function(){
        $scope.customers.push(
          {
              name:$scope.newCustomer.name, 
              company:$scope.newCustomer.company
          });
    };
};

customerApp.controller('customersController', customersController);