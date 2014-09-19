/// <reference path="../../scripts/angular.min.js" />

(function (app) {

    var flightsController = function ($scope, flightService, $timeout) {
        var init = function () {
            $scope.flights = flightService.getFlights();
            $scope.selectedFlight = null;
        }

        $scope.selectFlight = function (flight) {
            $scope.selectedFlight = flight;
            flight.selected = true;
            $timeout(function () {
                $scope.selectedFlight = null;
            }, 3000);
        };

        init();
    }

    app.controller('flightsController', ["$scope", "flightService", "$timeout", flightsController]);

}(angular.module("FlightPicker")));