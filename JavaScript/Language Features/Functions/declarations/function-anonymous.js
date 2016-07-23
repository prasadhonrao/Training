'use strict';

// Function Declaration
function callback() {
	console.log("Callback got called!");
}
callback();
console.log("Function declaration name is " + callback.name);

// Converted to anonymous function
var callback = function () {
	console.log("Callback got called, again!");
};
callback();
// Anonymous function doesn't have any name and 'callback' is just a variable referecen pointing to that function
console.log("Anonymous function name is " + callback.name);

// Always provide a way to anonymous function for
// 1. Better debugging support
// 2. Function can call itself using recursion or unbind event handler etc.

setTimeout(function callme() {
	console.log("Thanks for naming me!");
}, 3000);


// Anonymous functions are useful to achieve recursion
console.log("you can use recursion when an anonymous function is bound to a variable");
var printSeries = function(n){
    console.log('... SHOOOOOOOOOSH ....' + n);
    if (n > 0)
        printSeries(n-1);
};
printSeries(3);