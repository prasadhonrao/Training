/*
	First all the function execution context gets executed and then JS engine processes 
	the event handlers
*/

function waitThreeSeconds() {
	var ms = 3000 + new Date().getTime();
	while(new Date() < ms) {
		// do nothing
	}
	console.log('finished function')
}

function clickHandler() {
	console.log('click event');
}

document.addEventListener('click', clickHandler);

waitThreeSeconds();

console.log('finished execution');