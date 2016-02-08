/*
'apply' method is almost similar as 'call' method, excepts it accepts parameters using array
*/

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

// You need to use 'apply' function which will set 'this' object to something, person in below case

var logPersonName = function() {
	logName.apply(person); // setting person object as 'this' in getFullName function
};

logPersonName();


var greet1 = function(name){
	console.log(this.toUpperCase() + " "  + name);
};

var names = ["Prasad"];
greet1.apply("Hello", names); // passing "Hello" as context


var greet2 = function(name1, name2){
	console.log(this.toUpperCase() + " "  + name1 + " and " + name2);
};

names = ["Prasad", "Amit"];

greet2.apply("Hello", names); // passing "Hello" as context