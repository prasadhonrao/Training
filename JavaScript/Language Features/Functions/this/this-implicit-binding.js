function foo() {
  // "use strict";
	console.log(this.a);
}

var obj = {
	a: 10,
	foo: foo
};

obj.foo();