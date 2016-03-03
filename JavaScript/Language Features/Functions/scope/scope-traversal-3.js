var foo = function bar () {
	var foo = baz;

	function baz (foo) {
		// bar is accessible only within the function definition, but not outside
		foo = bar;
		foo;
		console.log(foo);
	}

	console.log("Before baz executes foo = " + foo);

	baz();

	console.log("After baz executes foo = " + foo);
};

foo();
//bar(); // error