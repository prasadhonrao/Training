/*
Two rules of module pattern
1. The function must execute using IIFE or using some other form [expression or declaration]
2. It must return a function and can optionally access private memnbers
*/

var greeter = (function() {
	// private variable
	var message = "Hello "

	return {
		// public functions
		greet: function(user) {
			console.log(message + user);
		}
	}
}());

greeter.greet('Prasad');