'use strict';

/*
Recursion - A function calls itself until it doesn't!
*/

function factorial(n) {
    if (n === 0 || n === 1) {
        return 1;
    }
    return n * factorial(n - 1); // function calling itself with new value
}

console.log(factorial(5));

console.log('---------------------------------');

// Another example using ES 6 syntax

let countdown = (num) => {
	if (num === 0) return;
	console.log(num);
	countdown(num - 1);
}

countdown(10);