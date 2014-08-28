(function (homeController) {

    var data = require("../data");

    homeController.init = function(app) {
        console.log("Initializing home controller");

        app.get("/home/index", function(req, res){
            data.getNoteCategories(function (err, results) {
                res.render("index", {title: "In Home -Index View", error:err, categories: results});
            });
        });
    }

}(module.exports));