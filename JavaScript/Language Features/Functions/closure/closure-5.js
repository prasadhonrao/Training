function foo() {
	var bar = 0;

	setTimeout(function(){
		console.log(bar++);
	}, 1000);

	setTimeout(function(){
		console.log(bar++);
	}, 2000);
}

foo();