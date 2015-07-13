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