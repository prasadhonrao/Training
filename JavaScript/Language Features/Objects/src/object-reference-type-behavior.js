// Object acts as a reference type
var customer = {
	firstName : 'Prasad'
};

var newCustomer = customer;

newCustomer.firstName = "Scott";
console.log(customer.firstName);