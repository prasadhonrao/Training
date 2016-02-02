/*
 Q. - What is undefined? 
 A. - It represents an unknown value
 */

// 1. undefined variable
var customer; // even though variable has been defined, its not initialized
console.log("customer variable value : " + customer);

// 2. undefined check
var flag;
if (flag === undefined) {
    console.log("flag variable is undefined");
} else {
	console.log("flag variable is defined");
}

// 3. undefined Object Property
if (!customer) {
    console.log('undefined evaluates to false in boolean expression');
}

// Accessing undefined property of an object
var customer = {
    name: "Prasad"
};

console.log("Customer Name : " + customer.name);
console.log("Customer Age : " + customer.Age); // undefined property