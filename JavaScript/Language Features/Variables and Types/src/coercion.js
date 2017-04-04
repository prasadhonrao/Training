// Explicit Coercion
var a = "42";
console.log(typeof(a));

var b = Number(a); // using Number class
console.log(typeof(b));

// Implicit Coercion
var c = "42";
var d = c * 2;
console.log(typeof(d));

/*
arrays are by default coerced to strings by simply joining all the values with commas (,) in between. You might think that two arrays with the same contents would be == equal, but they’re not:
*/
var a = [1, 2, 3];
var b = [1, 2, 3];
var c = "1, 2, 3";
console.log(a == c); // true
console.log(b == c); // true
console.log(a == b); // false

/*
the b value is being coerced to the “invalid number value” NaN in the < and > comparisons, and the specification says that NaN is neither greater than nor less than any other value.
*/
var a = 42;
var b = "foo";
console.log(a < b); // false
console.log(a > b); // false
console.log(a == b); // false
