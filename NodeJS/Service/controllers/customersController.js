(function (customersController) {

    var service = require("../services");

    customersController.init = function(app) {
        console.log("Initializing customers controller");

        app.get("/customers/index", function(req, res) {
            service.getCustomers(function (err, results) {
                res.render("customersList", {title: "Customers List", error:err, customers: results});
            });

        });
    }

}(module.exports));