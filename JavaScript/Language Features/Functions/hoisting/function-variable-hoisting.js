foo();

var foo = 2; // function declartion hoists before variable declaration

function foo() {
	console.log("In foo function");
}

//overrides earlier foo function
function foo() {
	console.log("In foo2 function");
}