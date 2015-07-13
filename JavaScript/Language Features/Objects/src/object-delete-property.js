// Deleting object property

var customer = { firstName: 'Prasad' };
console.log(customer.firstName); 
delete customer.firstName;
if (customer.hasOwnProperty('firstName')) {
    console.log(customer.firstName);
}
else {
    console.log("FirstName property has been deleted");
}
