// during scope traversal, if the variable is not found in current execution context, it will go 
// to outer execution context. In below case outer execution context is global and both a and b are 
// execution contexts at the same level (although b was called from a, calling does not matter!)

function b(){
	console.log(myVar);
}

function a(){
	var myVar = 2;
	b();
	console.log(myVar);
}

var myVar = 1;
a();