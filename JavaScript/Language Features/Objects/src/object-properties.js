// Empty object
var emptyObject = {};
console.log("Empty Object : " + emptyObject);

// Object with single property
var customer = { firstName: 'Prasad' };
console.log(customer.firstName);

// Object with multiple properties
var customer = { firstName: 'Prasad', Age: '30' };
console.log(customer.firstName);
console.log(customer.Age);

// Object property key stored in a variable
var obj = {
    a : "Hello World",
    b : 42
};

var b = "a";
console.log(obj[b]);
console.log(obj["b"]);

// Computed Property
var prefix = "foo";
var newObject = {
	[prefix + "bar"]:'Hello',
	[prefix + "baz"]:'World',
};
console.log(newObject.foobar  + " " + newObject.foobaz);