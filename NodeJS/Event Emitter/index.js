var EventEmitter = require("events").EventEmitter;

var logger = new EventEmitter();

var errorCallback = function(message){
	console.log("In error event handler. Message : " + message);	
};

var warnCallback = function(message){
	console.log("In warn event handler. Message : " + message);
};

var infoCallback = function(message){
	console.log("In info event handler. Message : " + message);
};

var customCallback = function(message){
	console.log("In custom event handler. Message : " + message);
};

logger.on("error", errorCallback);
logger.on("warn", warnCallback);
logger.on("info", infoCallback);
logger.on("custom", customCallback);

logger.emit("error","Take 1 : Something is wrong!!");
logger.emit("warn","Take 1 : This is a warning, you better fix it.");
logger.emit("info","Take 1 : This is just for you information buddy...");
logger.emit("custom","Take 1 : Custom");

logger.removeListener("error", errorCallback);

//logger.emit("error","Take 2 : Something is wrong!!");  // exception
logger.emit("warn","Take 2 : This is a warning, you better fix it.");
logger.emit("info","Take 2 : This is just for you information buddy...");
logger.emit("custom","Take 2 : Custom");


logger.removeAllListeners();
//logger.emit("error","Take 3 : Something is wrong!!");  // exception
// logger.emit("warn","Take 3 : This is a warning, you better fix it."); // exception
// logger.emit("info","Take 3 : This is just for you information buddy..."); // exception
// logger.emit("custom","Take 3 : Custom"); // exception