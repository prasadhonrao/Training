(function (controllers) {

    var homeController = require("./homeController");
    var userController = require("./userController");

    controllers.init = function(app) {
        homeController.init(app);
        userController.init(app);
    }

}(module.exports));