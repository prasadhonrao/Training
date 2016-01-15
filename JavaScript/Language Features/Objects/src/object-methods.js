// Object with single property and single function
var customer = {
    name: "Prasad",
    Greet: function (userName) {
        console.log("Hello " + userName);
    }
}

console.log(customer.name);
customer.Greet("Prasad");