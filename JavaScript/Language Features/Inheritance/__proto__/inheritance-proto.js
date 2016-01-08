var person = {
	firstName: 'Default',
	lastName: 'Default',
	getFullName: function() {
		return this.firstName + " " + this.lastName;
	}
};

var John = {
	firstName:'John',
	lastName: 'Papa'
};

/*
	do NOT use __proto__ in production application due to performance issues
*/

John.__proto__ = person;
console.log(John.getFullName());

var Scott = {
	firstName: 'Scott'
};

Scott.__proto__ = person;
console.log(Scott.getFullName());