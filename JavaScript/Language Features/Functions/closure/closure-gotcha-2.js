// Gotcha - it's not a closure, its just a object reference since return value is just an object

var foo = (function () {
	var obj = { bar: "bar"};
	return { obj: obj };
}());

console.log(foo.obj.bar);