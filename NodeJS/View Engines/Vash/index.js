var http = require("http");
var express = require("express");
var app = express();

// Setup View Engine
app.set("view engine", "vash");

app.get("/index1", function(req, res){
    res.render("index1", {title: "Express + Vash"});
});

app.get("/index2", function(req, res){
    res.render("index2", {title: "Express + Vash + Partial View"});
});

var server = http.createServer(app);

server.listen(3000);