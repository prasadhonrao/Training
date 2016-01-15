// Dynamic properties and methods
var customer = {
    firstName: "Colin"
};

customer.lastName = "Gray"; // adding new property dynamically
customer.phone = "0123456789"; // adding new property dynamically

customer.call = function () { // adding function dynamically
    var toCall = this.phone;
    console.log("calling customer");
};

console.log(customer.firstName + " " + customer.lastName + " " + customer.phone);
customer.call();