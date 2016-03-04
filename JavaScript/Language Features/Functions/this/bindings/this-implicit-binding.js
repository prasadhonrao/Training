/*
Implicit Binding - Defines the object in context for the callsite
*/

function foo() {
  // "use strict";
	console.log(this.a);
}

var obj = {
	a: 10,
	foo: foo
};

obj.foo(); // setting obj as context for function foo

console.log('---------------------------------------------');

/*
In case of reference chain, only the last level of an object property matters
*/

function bar() {
	console.log(this.a);
}

var bar2 = {
	a: 100,
	bar: bar
};

var bar1 = {
	a: 99,
	bar2: bar2
};

console.log(bar1.bar2.bar());