// Using String
String.prototype.isLengthGreaterThan = function (limit) {
	return this.length > limit;
}

var langugae = "JavaScript";
console.log(langugae.isLengthGreaterThan(3));

/*-------------------------------------------------------------------------------*/

// Using Number 
Number.prototype.isPositive = function() {
	return this > 0;
}

// console.log(1.isPositive()); // It can not be called on primities directly, 
// instead create an object which wraps the primitive value
var n = new Number(10);
console.log(n.isPositive());

/*-------------------------------------------------------------------------------*/