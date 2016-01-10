// All objects are passed by reference

var greeting = {
	text : "Hello"
};
console.log(greeting.text);

var newYearGreeting = greeting; 
newYearGreeting.text = "Happy New Year"; //mutate! :)

console.log(greeting.text); // Changed the text value for original greeting object as well
console.log(newYearGreeting.text);