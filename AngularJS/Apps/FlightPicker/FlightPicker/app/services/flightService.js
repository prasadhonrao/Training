(function (app) {
    var flightService = function () {

        var testData = [
        {
            id: 1,
            airLine: "Air India",
            from: "Mumbai",
            to: "New York",
            isDirect: true,
            stops: [],
            startDate: new Date(2014, 0, 1),
            endDate: new Date(2014, 0, 1),
            duration: 16,
            price: 500,
            selected: false
        },
        {
            id: 2,
            airLine: "British Airways",
            from: "London",
            to: "New York",
            isDirect: true,
            stops: [],
            startDate: new Date(2014, 1, 2),
            endDate: new Date(2014, 1, 2),
            duration: 7,
            price: 400,
            selected: false
        },
        {
            id: 3,
            airLine: "Jet Airways",
            from: "Pune",
            to: "New York",
            isDirect: false,
            stops: ["London"],
            startDate: new Date(2014, 2, 3),
            endDate: new Date(2014, 2, 3),
            duration: 20,
            price: 600,
            selected: false
        },
        {
            id: 4,
            airLine: "Qatar Airways",
            from: "Dubai",
            to: "Singapore",
            isDirect: true,
            stops: [],
            startDate: new Date(2014, 3, 4),
            endDate: new Date(2014, 3, 4),
            duration: 20,
            price: 600,
            selected: false
        },
        {
            id: 5,
            airLine: "United Airlines",
            from: "New York",
            to: "Las Vegas",
            isDirect: true,
            stops: [],
            startDate: new Date(2014, 10, 10),
            endDate: new Date(2014, 10, 10),
            duration: 7,
            price: 499,
            selected: false
        }
        ];

        var flightFactory = {};
        flightFactory.getFlights = function () {
            return testData;
        };

        return flightFactory;
    };

    app.factory("flightService", flightService);

}(angular.module("FlightPicker")));