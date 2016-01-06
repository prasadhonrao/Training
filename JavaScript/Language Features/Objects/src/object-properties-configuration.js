// Example to demonstrate different configuration options of object properties

var customer1 = Object.create(Object.prototype, {
	firstname: {value: 'Prasad', enumerable: true, writable: true, configurable: true},
	lastname: {value: 'Honrao', enumerable: true, writable: true, configurable: true},
	gender: {value: 'M', enumerable: true, writable: true, configurable: true}
});

for (var prop in customer1) {
    console.log("Property - " + prop + ", Value - " + customer1[prop]);
}

// Hide properties from enumeration
var customer2 = Object.create(Object.prototype, {
	firstname: {value: 'Prasad', enumerable: true, writable: true, configurable: true},
	lastname: {value: 'Honrao', enumerable: true, writable: true, configurable: true},
	gender: {value: 'M', enumerable: false, writable: true, configurable: true}
});

for (var prop in customer2) {
    console.log("Property - " + prop + ", Value - " + customer2[prop]);
}

// Define read only properties, RUN in browser
var customer3 = Object.create(Object.prototype, {
	firstname: {value: 'Prasad', enumerable: true, writable: false, configurable: true},
	lastname: {value: 'Honrao', enumerable: true, writable: false, configurable: true},
	gender: {value: 'M', enumerable: true, writable: true, configurable: true}
});

try {
	customer3.firstname = "Tom";
} 
catch (e) {
	console.log(e);
} 

// Restrict property configuration after declaration
// Once configuration is set to false, you cannot change enumerable, configurable attributes and 
// you cannot delete the property

var customer4= Object.create(Object.prototype, {
	//firstname: {value: 'Prasad', enumerable: true, writable: true, configurable: false},
	lastname: {value: 'Honrao', enumerable: true, writable: true, configurable: true},
	gender: {value: 'M', enumerable: true, writable: true, configurable: true}
});

Object.defineProperty(customer4, 'firstname', {configurable:false}); // error
delete customer4.firstname;
console.log(customer4.firstname);