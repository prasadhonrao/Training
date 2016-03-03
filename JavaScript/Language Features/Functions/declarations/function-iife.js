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

// IIFE creates separate execution context and avoids member collission

var message = "Outside IIFE: Hello";

(function greetWithMessage(name) {

	var message = "Inside IIFE :  Hello";
	console.log(message + ' ' + name);

}('Roy'));

console.log(message);