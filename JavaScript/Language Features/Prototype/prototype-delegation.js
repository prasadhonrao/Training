function Foo(who) {
	this.me = who;
}

Foo.prototype.identify = function() {
	return "I am " + this.me;
};

Foo.prototype.speak = function() {
	return "Hello " + this.identify() + "."; // speak is delegating work to identify within same prototype
};

var a1 = new Foo("a1");
console.log(a1.speak());