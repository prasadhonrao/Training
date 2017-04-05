var any1;
console.log(any1);
printTypeInfo(any1);
//console.log("Type of 'any' type is : - " + typeof(any1));

var number1 = 10;
var number2: number = 20;

console.log(typeof(number1) + " " + number1);
console.log(number2);
printTypeInfo(number2);

var number3 = number1 + 100;
console.log(number3);

var str = "typescript is powerful";
console.log(typeof(str) + " " + str);
printTypeInfo(str);

var isOld = true;
console.log(typeof(isOld) + " " + isOld);
printTypeInfo(isOld);

//var invalidNumber: number = "Hello" + 20; // Error!

function AddNumbers(n1, n2, n3) {
    let result = n1 + n2 + n3
    console.log("Sum is " + result);
}

AddNumbers(1, 2, 3);
AddNumbers(1, 2, "3");
AddNumbers(1, 2, " Holy!");

function AddTwoNumbers(n1: number, n2: number) {
    let result = n1 + n2
    console.log("Sum is " + result);
}
AddTwoNumbers(1, 2);
//AddTwoNumbers(1, "2"); // Error
//AddTwoNumbers(1, "Holy"); // Error


var developers: string[] = ['Prasad', 'Amit', 'Scott'];
var firstDeveloper = developers[0];
console.log(firstDeveloper);
printTypeInfo(firstDeveloper);

// Object
var person = { name: 'Prasad', age: 33 };
printTypeInfo(person);

function printTypeInfo(val)
{
    console.log("Type :" + typeof(val));
}