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
foo.call(obj);
foo.call(obj2);