'use strict';
// Function Declaration
function callback() {
	console.log("Done");
}
setTimeout(callback, 1000);

// Converted to anonymous function
setTimeout(function () {
	console.log("Done again!");
}, 2000);

// Always provide a way to anonymous function for 
// 1. Better debugging support
// 2. Function can call itself using recursion or unbind event handler etc.

setTimeout(function callme() {
	console.log("Thanks for naming me!");
}, 3000);