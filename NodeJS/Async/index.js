var async = require("async");

var one = function(callback){
	callback(null, "one");
};

var two = function(callback){
	callback(null, "two");	
}

async.parallel({
    				first: one,
    				second: two
				}, function(err, results) {
   	console.log(results);
});