/*jslint white: true */
var numbers = [10, 20, 30, 40, 50];

console.log("Array : [" + numbers + "] , " + "Length : " + numbers.length);

// Iterate using for...each
var i;
for (i = 0; i < numbers.length; i++) {
    console.log("Index: " + i + " , " + "Value: " + numbers[i]);
}

console.log("");

// Iterate using for...in
for (i in numbers) {
    console.log("Index: " + i + " , " + "Value: " + numbers[i]);
}

// 1. Inserting number at random index!

numbers[10] = 100;
console.log("Array : [" + numbers + "] , " + "Length : " + numbers.length);
var i;
for (i = 0; i < numbers.length; i++) {
    console.log(numbers[i]);
}

console.log("");

for (i in numbers) {
    console.log("Index: " + i + " , " + "Value: " + numbers[i]);
}


// 2. Array being an object can contain functions as well!

numbers.foo = function () {
    console.log("foo");
};
var i;
for (i = 0; i < numbers.length; i++) {
    console.log(numbers[i]);
}

console.log("");

for (i in numbers) {
    console.log("Index: " + i + " , " + "Value: " + numbers[i]);
}