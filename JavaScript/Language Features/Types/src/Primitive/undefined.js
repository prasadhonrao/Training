// 1. Undefined variable
var customer; // even though variable has been defined, its not initialized
console.log("customer variable value : " + customer);

// 2. Undefined check
var flag;
if (flag === undefined) {
    console.log("flag variable is undefined");
}

// 3. Undefined Object Property
if (!customer) {
    console.log('undefined evaluates to false in boolean expression');
}

// Accessing undefined property of an object
var customer = {
    name: "Prasad"
}
console.log("Customer Name : " + customer.name);
console.log("Customer Age : " + customer.Age); // undefined property