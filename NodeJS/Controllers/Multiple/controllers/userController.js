(function (userController) {

    userController.init = function(app) {
        console.log("Initializing user controller");

        app.get("/user/index", function(req, res){
            res.render("index", {title: "In User -Index View "});
        });
    }

}(module.exports));