var http = require("http");
var fs = require("fs");

var callback = function(request, response) {
	fs.readFile('index.html', function(err, contents){
		response.end(contents);
	});
};

http.createServer(callback)
    .listen(9000);

console.log("Server is listing at http://localhost:9000");