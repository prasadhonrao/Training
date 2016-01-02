/*
 Q. - What is null? 
 A. - It represents absence of a value
 */

// 1. Declare a null variable
var customer = null;
if (!customer) {
    console.log("customer variable has a value : " + customer);
}

// 2. Override a null variable
var customer = 1;
if (customer) {
    console.log("customer has a value :" + customer);
}

// 3. Null check in boolean condition
var customer = null;
if (!customer) {
    console.log("null variable returns false in boolean condition.");
}

// 4. 0 is exception to null test
var zeroVariable = 0;
if (!zeroVariable) {
    console.log("zero value returns true in boolean condition.");
}