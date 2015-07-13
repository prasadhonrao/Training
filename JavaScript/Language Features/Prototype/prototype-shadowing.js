// Try to avoid shadowing as much as possible as it adds complexity to the program.
// Check prorotype-delegation for better solution

function Foo(who) {
	this.me = who;
}

Foo.prototype.identify = function() {
	return "I am " + this.me;
};

var a1 = new Foo("a1");
var a2 = new Foo("a2");
console.log(a1.identify());
console.log(a2.identify());

// Creating a function for a1 object and calling Foo [base] method
a1.identify = function() {
	return ("Hello" + Foo.prototype.identify.call(this) + ".");
};
console.log(a1.identify());

// Below function is shadowing as well, without calling base function
a2.identify = function() {
	return ("Hello from a2 function");
};
console.log(a2.identify());
