/*
Unlike other programming languages, array in JavaScript can hold data of different types.
*/

// Empty array
var empty = [];
console.log('Empty array length is ' + empty.length);
empty[0] = 0;
console.log('array length is ' + empty.length);
empty[4] = 0; // adding elements at 5th Index changes the length and adds undefined elements
console.log('array length is ' + empty.length);
for (var index = 0; index < empty.length; index++) {
	console.log(empty[index]);
}

// Array declaration and initialization
console.log("Numeric Array");
var numbers = [1, 2, 3, 4, 5];
console.log(numbers);

// Array declaration and adding value dynamically
var colors = [];
colors[0] = "Red";
colors[1] = "Orange";
colors[2] = "Yellow";
console.log('colors array length- ' + colors.length);
console.log(colors);

// numeric array
console.log("Numeric Array");
var numbers = [1, 2, 3, 4, 5];
for (i = 0; i < numbers.length; i++) {
    console.log(numbers[i]);
}

// string array
console.log("String Array");
var letters = ['a', 'q', 'z', 'd', 'm', 'p'];
for (i = 0; i < letters.length; i++) {
    console.log(letters[i]);
}

// alphanumeric array
console.log("Alphanumeric Array");
var alpha = ['1', '2', 'c', 'd', '%'];
for (i = 0; i < alpha.length; i++) {
    console.log(alpha[i]);
}

// associative array
console.log("Associative Array");
var rainbow = [];
rainbow["Red"] = "#FF0000";
rainbow["Orange"] = "#FFA500";
rainbow["Yellow"] = "#FFFF00";
rainbow["Green"] = "#008000";
rainbow["Blue"] = "#0000FF";
rainbow["Indigo"] = "#4B0082";
rainbow["Violet"] = "#EE82EE";

console.log(rainbow["Red"]);
// CANT ACCESS USING BELOW SYNTAX
//            console.log("Number of colors in rainbow " + rainbow.length);
//            for (var i = 0; i < rainbow.length; i++) {
//                console.log(rainbow[i]);
//            }


// Arrays can even hold a function

var funcArray = [
	1,
	"JavaScript",
	false,
	{
		name: 'Prasad',
		isProgrammer: true
	},
	function(name) {
		console.log('Hello ' + name);
	}
];

funcArray[4](funcArray[3].name);