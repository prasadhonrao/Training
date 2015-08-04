var foo = function (n) {
	if (n < 5) {
		return    // GOTCHA!!
			n*2;
	}
	else {
		return n;
	}
}

console.log(foo(6));
console.log(foo(2));