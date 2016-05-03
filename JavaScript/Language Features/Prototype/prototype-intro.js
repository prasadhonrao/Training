function Person(firstname, lastname){
	this.firstname = firstname;
	this.lastname = lastname;
}

/* Adding a method on prototype creates just one copy of the method, rather than 
   in constructor which creates separate copy for each object instance. */
Person.prototype.getFullName = function() {
	return this.firstname + ' ' + this.lastname;
}

var prasad = new Person('Prasad', 'Honrao');
console.log(prasad.getFullName());

var colin = new Person('Colin', 'Gray');
console.log(colin.getFullName());

/*

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
*/