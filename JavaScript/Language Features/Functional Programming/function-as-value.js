var triple = function(input) {
	return input * 3;
};

// function is passed as value, not possible in non-functional programming languages
var maketriple = triple;

console.log(maketriple(2));