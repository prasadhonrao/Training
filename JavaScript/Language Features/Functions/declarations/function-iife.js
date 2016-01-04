/*
	IIFE can be declared using both function expression or function statement syntax
*/

// Function Expression Syntax
var greeting = function (name) {
	return 'Hello ' + name;
}('Prasad');
console.log(greeting);

// Function Statement Syntax
(function greet(name) {
	console.log('Hello ' + name);
}('John'));