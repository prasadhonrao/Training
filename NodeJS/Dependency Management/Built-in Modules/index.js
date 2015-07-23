var os = require('os');
console.log(os.hostname());

var toMb = function(mem) {
	return Math.round((mem/1024/1024)*100/100);
}

console.log("Free memory " + toMb(os.freemem()));
console.log("Total memory " + toMb(os.totalmem()));