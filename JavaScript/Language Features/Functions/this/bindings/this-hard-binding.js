/*
ES5 provides bind function to support hard binding out of the box
*/

function foo2(something) {
	console.log(this.a, something);
    return this.a + something;
}

var obj2 = {
	a:2
};

//bind creates a copy of the function
var bar2 = foo2.bind(obj2);
var b2 = bar2(3);
console.log(b2);