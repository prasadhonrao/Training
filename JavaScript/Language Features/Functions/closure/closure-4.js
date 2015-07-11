function foo() {
	var bar = "bar";

	setInterval(function(){
		console.log(bar);
	}, 1000);
}

foo();