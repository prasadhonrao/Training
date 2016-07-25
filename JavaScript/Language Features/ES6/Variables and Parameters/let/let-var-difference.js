'use strict';
// Scope difference between let and var
let a = 10;
let b = 20;

if (true) {
	let a = 100;
	//var b = 200; // Error - b is already declared
	console.log("1. Inside a : " + a + " b : " + b);
	a = 1000;
	b = 2000;
	console.log("2. Inside a : " + a + " b : " + b);
}
console.log("3. Outside a : " + a + " b : " + b);