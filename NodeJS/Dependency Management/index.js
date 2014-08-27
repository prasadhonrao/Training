// File dependency
var logger = require("./logger.js")
console.log(logger.welcomeMessage);
logger.log("Hello World!");
console.log(logger.author.getFullName());

// Execute function each time, no caching
var alerter = require("./alerter.js");
console.log(alerter());
console.log(alerter());

// User defined class dependency
var Customer = require("./customerClass.js");
var c1 = new Customer();
console.log(c1.message);

// Folder dependency
var log = require("./Messenger");
log.log("Test");