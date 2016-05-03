function Person(firstname, lastname){
	this.firstname = firstname;
	this.lastname = lastname;
}

Person.prototype.identify = function() {
	return "I am " + this.firstname + ' ' + this.lastname;
};

Person.prototype.speak = function() {
	return "Hello " + this.identify() + "."; // speak is delegating work to identify within same prototype
};

var prasad = new Person("Prasad", "Honrao");
console.log(prasad.speak());