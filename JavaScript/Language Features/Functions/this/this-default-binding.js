// Run in browser

function foo() {
  // "use strict";
	console.log(this.a);
}

var a = 10;

foo();