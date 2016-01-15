// Convert object to JSON
var customer = {
	firstName: 'Prasad',
	isProgrammer: true
};

var objectAsJSON = JSON.stringify(customer)
console.log(objectAsJSON); // Properties are enclosed in ""

// Converting a string into Object literal
var someString = '{"lastName": "Honrao"}';
var convertedObject = JSON.parse(someString);
console.log(convertedObject);