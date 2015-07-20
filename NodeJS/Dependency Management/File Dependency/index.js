// File dependency
var logger = require("./logger.js")
console.log(logger.welcomeMessage);
logger.log("Hello World!");
console.log(logger.author.getFullName());

// Import only one member from external module
var logger2 = require("./logger.js").welcomeMessage;
console.log(logger2.welcomeMessage);
//logger2.log("Hello World!"); // log is not accessible

// Execute function each time, no caching
var alerter = require("./alerter.js");
console.log(alerter());
console.log(alerter());

// User defined class dependency
var Customer = require("./customer.js");
var c1 = new Customer();
console.log(c1.message);
