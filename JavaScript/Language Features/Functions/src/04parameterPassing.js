var name = "Prasad";
var customer = { name: "Prasad" };

// Primitive types are passed by value
function reverse(anything) {
    anything = anything.split('').reverse().join('');
    return anything;
}

// Object values are passed by reference
function reverseCustomerName(c) {
    c.name = reverse(c.name);
    return c;
}

console.log(reverse(name));
console.log(name); // note no change to original name variable

console.log(reverseCustomerName(customer).name);
console.log(customer.name); // note original customer variable value has changed