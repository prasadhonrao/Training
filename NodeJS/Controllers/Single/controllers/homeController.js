(function (homeController) {

    homeController.init = function(app) {
        console.log("Initializing home controller");

        app.get("/index", function(req, res){
            res.render("index", {title: "Express + Vash"});
        });
    }

}(module.exports));