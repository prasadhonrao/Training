function foo() {
	console.log(this.a);
}

var obj = {
	a:2
};

var bar = function() {
	foo.call(obj);
};

bar();
setTimeout(bar, 1000);

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

var bar2 = foo2.bind(obj2);
var b2 = bar2(3);
console.log(b2);