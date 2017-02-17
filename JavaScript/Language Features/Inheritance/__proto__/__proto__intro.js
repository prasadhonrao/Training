var person = {
	firstname: 'default',
	lastname: 'default',
	getFullName: function() {
		return this.firstname + ' ' + this.lastname;
	}
};

var prasad = {
	firstname: 'Prasad',
	lastname: 'Honrao'
};

// Dont do this EVER as it has serious performance issues
prasad.__proto__ = person;
console.log(prasad.getFullName());
console.log(prasad.firstname);

var scott = {
	firstname: 'Scott'
};
scott.__proto__ = person;
console.log(scott.getFullName());  // Since lastname doesn't exist, it will get it from prototype