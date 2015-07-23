var person = {
	firstName: "Prasad",
	lastName: "Honrao",
	age: 35 
};

// Old way
function displayPerson(p) {
	var first = p.firstName
	var last = p.lastName
	console.log(first + " " + last);
}

// New way
function displayPerson2(p) {
	var {firstName: first, lastName: last} = p;
	console.log(first + " " + last);
}

displayPerson(person);
displayPerson2(person);
