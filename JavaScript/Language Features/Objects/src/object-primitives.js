// Everything in JS is object except primitive types.
var b = new Boolean();
console.log("type of new Boolean() is : " + typeof(b));
b = true;
console.log("type of boolean is : " + typeof (b));

var n = new Number();
console.log("type of new Number() is : " + typeof(n));
n = 100;
console.log("type of number is : " + typeof(n));

var s = new String();
console.log("type of new String() is : " + typeof (s));
s = "JavaScript";
console.log("type of string is : " + typeof (s));

var d = new Date();
console.log("type of new Date() is : " + typeof (d));

var a = new Array();
console.log("type of Array is :" + typeof (a));

// Using Object constructor
var customer = new Object();
customer.fullName = 'Prasad Honrao';
console.log(customer.fullName);