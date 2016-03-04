/*

Explicit Binding - In this case, you need to explicitly provides a context/ value
which can be used as 'this' during function execution.

call and apply methods are commonly used for this pattern, which accept first parameter
for 'this'
*/

function foo() {
	console.log(this.a);
}

var obj = {
	a: 2
};

var obj2 = {
	a: 20
};

// Explicitely providing 'this' reference using call method
foo(); // this will use default binding
foo.call(obj);
foo.call(obj2);
foo.apply(obj); // apply can be used to send more arguments to function
