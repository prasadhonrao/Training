var message = "Global Variable";

function displayMessage(){
	var message = "Local Variable"; // variable declared using 'var'
	console.log(message);
}

function displayMessage2(){
	message = "Local Variable 2"; // overridding global variable
	console.log(message);
}

console.log(message);
displayMessage();
displayMessage2();
console.log(message); // display overridden value instead of original global value