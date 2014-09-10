// Function declaration
function add(num1, num2) {
    return num1 + num2;
}
console.log("1 + 2 = " + add(1, 2));

// By default all the functions returns some value.
// If return is not defined, then its value is undefined
function hello() {};
var x = hello();
console.log(x);