(function (productController) {

    var service = require("../services");

    productController.init = function(app) {
        console.log("Initializing products controller");

        app.get("/products/index", function(req, res) {
            service.getProducts(function (err, results) {
                res.render("productsList", {title: "Products List", error:err, products: results});
            });

        });
    }

}(module.exports));