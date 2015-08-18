var firstNumber = 10,
	result = 0;
	
result = ++firstNumber;
console.log("Pre Increment : "  + result);

firstNumber = 10;
result = firstNumber++;
console.log("Post Increment : "  + result);

firstNumber = 10;
result = --firstNumber;
console.log("Pre Decrement : "  + result);

firstNumber = 10;
result = firstNumber--;
console.log("Post Decrement : "  + result);