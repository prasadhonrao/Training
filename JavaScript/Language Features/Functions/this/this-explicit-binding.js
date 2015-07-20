function foo() {
	console.log(this.a);
}

var obj = {
	a: 2
};

// Explicitely providing 'this' reference using call method
foo.call(obj);