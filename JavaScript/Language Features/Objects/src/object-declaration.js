// Object literal syntax
var customer = {
	firstName: 'Prasad',
	lastName: 'Honrao',
	gender: 'M'
};
console.log(customer.firstName + " " + customer.lastName + " " + customer.gender)

// Object constructor syntax
var employee = new Object();
employee.firstName = 'Prasad';
employee["lastName"] = 'Honrao';
employee.gender = 'M';

console.log(employee.firstName + " " + employee.lastName + " " + employee["gender"])
var lastnameProperty = "lastName";
console.log(employee[lastnameProperty]);

// Object.create
var dog = Object.create(Object.prototype, {
	name: {value: 'tommy', enumerable: true, writable: true, configurable: true},
	color: {value: 'white', enumerable: true, writable: true, configurable: true}
})

console.log(dog.name + " is a " + dog.color + " dog");

// Function Constructor OR 'new' operator
function Book(id, name) {
	this.id = id;
	this.name = name;
}
var kiterunner = new Book(1,'Kite Runner');
console.log(kiterunner.name);

// ES6 classes
class Person {
	constructor(firstName, lastName) {
		this.firstName = firstName;
		this.lastName = lastName;
	}

	greet() {
		return 'Hi ' + this.firstName;
	}
}
var john = new Person('John','Papa');
console.log(john.greet());