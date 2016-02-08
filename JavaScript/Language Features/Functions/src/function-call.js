/*
As opposed to 'bind' method, in 'call' method you can pass additional arguments.
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

// You need to use 'call' function which will set 'this' object to something, person in below case

var logPersonName = function() {
	logName.call(person); // setting person object as 'this' in getFullName function
};

logPersonName();

/*
var greet1 = function(name){
	console.log(this.toUpperCase() + " "  + name);
};

greet1.call("Hello", "Prasad"); // passing "Hello" as context


var greet2 = function(name1, name2){
	console.log(this.toUpperCase() + " "  + name1 + " and " + name2);
};
greet2.call("Hello", "Prasad" , "Rahul"); // passing "Hello" as context

function foo() {
	console.log(this.bar);
}

var bar = "bar1";
var obj = {bar : "bar2"};

foo();
foo.call(obj);
*/