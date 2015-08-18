/*
Built-in Objects
	String
	Number
	Boolean
	Object
	Function
	Array
	Date
	RegExp
	Error
*/

var str = "I am a string";
console.log(typeof(str));
console.log(str instanceof String);

var str2 = new String("I am new string"); // Note String is an object
console.log(typeof(str2));
console.log(str2 instanceof String);

console.log(Object.prototype.toString.call(str2)); // to inspect object's subtype