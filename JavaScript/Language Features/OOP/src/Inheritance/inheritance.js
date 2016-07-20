/*
Every function in javascript has a prototype property that holds an object that will act as a prototype – will provide shared properties – for all objects created via that function and the new keyword. The prototype object has in its turn a constructor property that points back to the constructor function:

Each property defined in the constructor function will be part of every single object instance, whilst each property defined in the prototype will be shared amongst all object instances.
*/

function Barbarian(name) {
	this.name = name;
}

console.log(Barbarian.prototype);
console.log(Barbarian.prototype.constructor);
var coder = new Barbarian('Jack');
console.log(coder.name);
//console.log(coder.sayHi()); // sayHi function is not available in function or its prototype

// setting up new prototype
Barbarian.prototype = {
	sayHi: function () {
		console.log('Hi, I am ' + this.name);
	}
}
console.log(Barbarian.prototype);

var coder = new Barbarian('Smith');
coder.sayHi();