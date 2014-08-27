var http = require("http");
var express = require("express");
var app = express();

// Setup View Engine
app.set("view engine", "jade");

app.get("/index1", function(req, res){
    res.render("index1", {title: "Express + Jade"});
});

app.get("/index2", function(req, res){
    res.render("index2", {title: "Express + Jade + Partial View"});
});

var server = http.createServer(app);

server.listen(3000);