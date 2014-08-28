var http = require("http");
var express = require("express");
var app = express();
var controllers = require("./controllers");

// Setup View Engine
app.set("view engine", "vash");

controllers.init(app);

var server = http.createServer(app);

server.listen(3000);