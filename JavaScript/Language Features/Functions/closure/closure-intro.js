function greet(message) {
	return function(name) {
		console.log(message + ', ' + name);
	}; 
}

greet('Welcome to Closure')('Sam');

// Closure allows program to save 'message' variable in memory even after its execution
var testGreet = greet('Welcome to Closure');
testGreet('Jack');