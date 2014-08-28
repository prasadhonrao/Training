(function(service) {

    var customersService = require("./customersService");
    var productsService = require("./productsService");

    service.getCustomers = function(next) {
        next(null, customersService.getCustomers)
    };

    service.getProducts = function(next) {
        next(null, productsService.getProducts)
    };

}(module.exports));