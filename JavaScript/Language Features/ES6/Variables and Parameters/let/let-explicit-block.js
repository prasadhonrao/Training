var foo = true;

if (foo) {
	{ //Explicit Block
		let bar = foo * 2;
		console.log(Number(foo)); //1
		console.log(bar);
	}
}