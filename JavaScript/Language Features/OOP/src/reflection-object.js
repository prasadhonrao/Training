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

// Extract all the properties from object including from its prototype
for(var prop in prasad) {
	console.log(prop + ' ' + prasad[prop]);
}

// Extract only object specific properties
console.log('-----------------------------');
for(var prop in prasad) {
	if(prasad.hasOwnProperty(prop)){
		console.log(prop + ' ' + prasad[prop]);
	}	
}