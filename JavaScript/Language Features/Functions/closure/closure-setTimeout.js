function foo(message) {

	setTimeout(function(){
		console.log(message);
	}, 2000);
}

foo('Hello, closure');