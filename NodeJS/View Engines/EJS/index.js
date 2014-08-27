var http = require("http");
var express = require("express");
var app = express();

// Setup View Engine
var ejsEngine = require("ejs-locals")
app.engine("ejs",ejsEngine) // to support master pages
app.set("view engine","ejs");

app.get("/", function(req, res){
    res.send("success!");
});

app.get("/index1", function(req, res){
    res.render("index1", {title: "Express + EJS"});
});

app.get("/index2", function(req, res){
    res.render("index2", {title: "Express + EJS + Partial View"});
});

var server = http.createServer(app);

server.listen(3000);