// Run in browser as node's global context is different than browser

function foo() {
  // "use strict";
	console.log(this.a);
}

var a = 10;

foo();