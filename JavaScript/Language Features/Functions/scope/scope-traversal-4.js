var bar = "bar";

function foo(str) {
	eval(str); //eval interpretes string code as JS code and executes it! CHEATING!! use strict to fix it!
	console.log(bar);
}

foo("var bar = 42");