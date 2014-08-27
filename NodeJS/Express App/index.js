var http = require("http");
var express = require("express");

var app = express();

app.get("/", function(req, res) {
    res.send("<html><body><h1>" + "Express" + "</h1></body></html>");
});

app.get("/foo", function(req, res) {
    res.send("<html><body><h1>" + req.url + "</h1></body></html>");
});

app.get("/author", function(req, res) {
    res.send({firstName: "Prasad", lastName: "Honrao", role: "Node Developer"});
});

var server = http.createServer(app);

server.listen(3000);