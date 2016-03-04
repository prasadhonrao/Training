/*
Default Binding - If you're in strict mode, default 'this' keyword to 'undefined' value 
or assign it to global object. i.e. this will always either point to undefined or global
object
*/

// Run in browser as node's global context is different than browser

function foo() {
    // "use strict";
	console.log(this.a);
}

var a = 10;

foo();