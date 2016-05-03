// Try to avoid shadowing as much as possible as it adds complexity to the program.
// Check prorotype-delegation for better solution

function Person(firstname, lastname){
	this.firstname = firstname;
	this.lastname = lastname;
}

Person.prototype.identify = function() {
	return "I am " + this.firstname + ' ' + this.lastname;
};

var prasad = new Person("Prasad", "Honrao");
console.log(prasad.identify());

var john = new Person("John", "Papa");
console.log(john.identify());

// Below function is shadowing function identify declared in Person [base]
john.identify = function() {
	return ("Hello from john function");
};
console.log(john.identify());

// Creating a function for prasad object and calling Person [base] method
prasad.identify = function() {
	return ("Hello, " + Person.prototype.identify.call(this) + ".");
};
console.log(prasad.identify());