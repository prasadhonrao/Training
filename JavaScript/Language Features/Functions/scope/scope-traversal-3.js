var foo = function bar () {
	var foo = baz;

	function baz (foo) {
		foo = bar;
		foo;
		console.log(foo);
	}

	//console.log("Before baz executes foo = " + foo);

	baz();

	//console.log("After baz executes foo = " + foo);
};

foo();
//bar(); // error