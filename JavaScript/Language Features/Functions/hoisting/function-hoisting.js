console.log(foo());
//console.log(bar()); //Error

function foo() {
	return "foo";
};

// Function Expression does not hoist
var bar = function() {
	return "bar";
}

console.log(bar());
