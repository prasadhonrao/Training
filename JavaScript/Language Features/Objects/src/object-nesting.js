// Nested objects
var customer = {
    firstName: "Prasad",
    lastName: "Honrao",
    address: {
        street: "University st",
        postcode: "Z12CV4"
    },
    "telephone number": "1234567890",  // note property name can contain space but needs to be enclosed in ""
    colors: [  // adding array as a property
        { id: 1, name: "Red" },
        { id: 2, name: "Blue" }
    ]
};

console.log(customer.address.street);
console.log(customer["address"]["postcode"]);
console.log(customer["telephone number"]); // cant use customer."telephone number"
console.log(customer.colors[0].name);