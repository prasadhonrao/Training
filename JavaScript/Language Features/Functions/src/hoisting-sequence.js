// Functions [Function Declaration, not Expression!] are hoisted first and then Variables

foo();

var foo;

function foo() {
	console.log(1);
}

foo = function() {
	console.log(2);
}