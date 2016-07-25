/*
	arguments is used to get access to variable number of arguments passed while calling the function. However, note that arguments is an object that is present within every function in JavaScript and which provides access to the arguments used to call a function:
*/
function getArgumentsLength() {
    console.log("number of arguments - " + arguments.length);
}

getArgumentsLength();
getArgumentsLength(1);
getArgumentsLength(1, '');
getArgumentsLength(1, '', 12 / 12 / 2012);

/*
	Use of arguments to calculate the total of variable number of arguments
*/
function add() {
    var total = 0;
    for (var i = 0; i < arguments.length; i++) {
        total += arguments[i];
    }
    return total;
}
console.log(add());
console.log(add(1));
console.log(add(1, 2));
console.log(add(1, 2, 'wow, its working for string also!','£'));

/*
	Access arguments using indexer syntax
*/
function bar() {
    console.log("First argument value - " + arguments[0]);
}
bar(99, 2);
bar();

/*
	Find missing arguments using if
*/
function foo(one, two, three) {
    if (two) console.log(two);
    if (three) console.log(three);
}
foo(1, 2);

/*
	Initialize arguments using 'OR' operator
*/
function greet(firstName, lastName, message){
	message = message || 'Welcome ';
	console.log(message + firstName + " " + lastName);
}
greet('Prasad', 'Honrao');


// Convert arguments to an array
function print(){
    console.log("In print function");
    //...
    var series = Array.prototype.slice.call(arguments, /* startFromIndex */ 0);
    series.forEach(function(item){
        console.log(item);
    });
    //...
}

print(1,2,3,4,5,[6,7,8,9],'10','JavaScript');

// ES6 provides rest parameters which is an array of arguments passed
function printAgain(...series){
    console.log("In printAgain function");
    series.forEach(function(item){
        console.log(item);
    });
}

printAgain('Hi',1,2,3,[1,2]);