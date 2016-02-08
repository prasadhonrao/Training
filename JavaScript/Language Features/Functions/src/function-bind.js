var person = {
	firstName: 'Prasad',
	lastName: 'Honrao',
	getFullName: function() {
		var fullName =  this.firstName + ' ' + this.lastName;
		return fullName;
	}
};

var logName = function() {
	console.log('Logged : ' + this.getFullName()); // this is a global object here, so cant call getFullName directly
};

// You need to use 'bind' function which will set 'this' object to something, person in below case

var logPersonName = function() {
	logName.bind(person); // setting person object as 'this' in getFullName function
};

logPersonName();