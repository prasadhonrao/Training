"use strict";

var author = "Prasad Honrao";
console.log(author);

// Undefined variables are not allowed in strict mode
language = "JavaScript";
console.log(language); // throws an exception

// Duplicate object properties are not allowed
var customer = {
	name : "Prasad",
	name : "Prasad Honrao"
}
console.log(customer.name);

// Write to readonly property is not allowed
var cities = ["Pune","Mumbai"];
cities.length = 10;

console.log(cities.length);

var printArguments = function(){
	arguments = 100;
	console.log(arguments[0]);
	console.log(arguments.length);
};

printArguments(1,2);