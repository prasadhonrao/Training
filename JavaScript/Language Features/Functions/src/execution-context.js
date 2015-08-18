function b() {  // execution context = function b
	var myVar;
	console.log(myVar);
}

function a() { // execution context == function a
	var myVar = "a";
	b();
	console.log(myVar);
}

var myVar = "global";
console.log(myVar); // global execution context
a();