/*
	JavaScript does NOT support function overloading
*/
function add(num1, num2, num3) {
    return num1 + num2 + num3;
}

function add(num1, num2) {
    return num1 + num2;
}

console.log(add(1, 2));
console.log(add(1, 2, 3));

/*
	Implement smaller functions and pass on default values
*/
function greet(firstName, lastName, language) {
	language = language || 'en';

	if (language === 'en') {
		message = 'Hello';
	} else {
		message = 'Hola';
	}

	console.log(message + ' ' + firstName + ' ' + lastName)
}

function greetEnglish(firstName, lastName) {
	greet(firstName, lastName ,'en');
}

function greetSpanish(firstName, lastName) {
	greet(firstName, lastName ,'es');
}

greetEnglish('Prasad', 'Honrao');
greetSpanish('Colin', 'Malia');