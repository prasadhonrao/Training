//'use strict';
var bar = "bar";

function foo(str) {
	//eval interpretes string code as JS code and executes it! CHEATING!! use strict to fix it!
	eval(str);
	console.log(bar);
}

foo("var bar = 42");