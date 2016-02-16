class Person {
	constructor(firstName, lastName) {
		this.firstName = firstName;
		this.lastName = lastName;
	}

	greet() {
		return 'Hi ' + this.firstName;
	}
}

// set the prototype using extends 

class InformalPerson extends Person {
	constructor (firstName, lastName) {
		super(firstName, lastName);
	}
}

var prasad = new InformalPerson('Prasad', 'Honrao');
var greeting = prasad.greet();
console.log(greeting);