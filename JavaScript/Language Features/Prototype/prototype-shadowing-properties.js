function Person(firstname, lastname){
	this.firstname = firstname;
	this.lastname = lastname;
}

// base property
Person.prototype.age = 40;

var prasad = new Person("Prasad", "Honrao");
var john = new Person("John", "Papa");
console.log(prasad.age);
console.log(john.age);

// defining a shadowing property age property on prasad
prasad.age = 35;

console.log(prasad.age);
console.log(john.age); // get it from prototype if not defined on object itself