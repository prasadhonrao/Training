(function (controllers) {

    var customersController = require("./customersController");
    var productsController = require("./productsController");

    controllers.init = function(app) {
        customersController.init(app);
        productsController.init(app);

        app.get("/", function(req, res) {
           res.render("index");
        });

    }

}(module.exports));