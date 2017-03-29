var any1;
console.log(any1);
var number1 = 10;
var number2 = 20;
console.log(typeof (number1) + " " + number1);
console.log(number2);
var number3 = number1 + 100;
console.log(number3);
var str = "typescript is powerful";
console.log(typeof (str) + " " + str);
var isOld = true;
console.log(typeof (isOld) + " " + isOld);
//var invalidNumber: number = "Hello" + 20; // Error!
function AddNumbers(n1, n2, n3) {
    var result = n1 + n2 + n3;
    console.log("Sum is " + result);
}
AddNumbers(1, 2, 3);
AddNumbers(1, 2, "3");
AddNumbers(1, 2, " Holy!");
function AddTwoNumbers(n1, n2) {
    var result = n1 + n2;
    console.log("Sum is " + result);
}
AddTwoNumbers(1, 2);
