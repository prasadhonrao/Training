var http = require("http");
var express = require("express");
var app = express();
var controller = require("./controllers/homeController");

// Setup View Engine
app.set("view engine", "vash");

controller.init(app);

var server = http.createServer(app);

server.listen(3000);