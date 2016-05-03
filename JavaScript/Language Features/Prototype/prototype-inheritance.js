function Person(firstname, lastname){
	this.firstname = firstname;
	this.lastname = lastname;
}

Person.prototype.getFullName = function() {
	return this.firstname + ' ' + this.lastname;
}

function Employee(firstname, lastname) {
	Person.call(this, firstname, lastname);
}

// setting up the inhertiance
Employee.prototype = Object.create(Person.prototype);
// OR
//Employee.prototype = new Person();

Employee.prototype.identify = function() {
	console.log("Hello, " + this.getFullName() + ".");
}

var e1 = new Employee("Prasad", "Honrao");
e1.identify();