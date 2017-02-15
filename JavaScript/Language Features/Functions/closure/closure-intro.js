/*
Q. What is closure?
A. Closure is when a function remembers its lexical scope even when the function is
   executed outside that lexical scope
*/

function greet(message) {
	return function(name) {
		console.log(message + ', ' + name);
	};
}
greet('Welcome to Closure')('Sam');

// store function as a variable
var testGreet = greet('Welcome to Closure');
testGreet('Jack');