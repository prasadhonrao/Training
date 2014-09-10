var _ = require("./lib/underscore-min.js");

// empty array
var empty = [];
console.log('empty length array - ' + empty.length);

// numeric array
console.log("Populating numeric array");
var numbers = [1, 2, 3, 4, 5];
_(numbers).each(function (num) {
    console.log(num);
});

// map - copies array into another using functional logic
var squaredArray = _(numbers).map(function (num) {
    return num * num;
});
console.log('map ' + squaredArray);


// reduce - reduces all the array element to one value using functional logic. 
// Below example does the summation of all numbers in array
var total = _(numbers).reduce(function (memo, num) {
    return memo += num;
}, 0);

console.log('reduce ' + total);

// select - Used to filter a collection
var even = _(numbers).select(function (num) {
    return num % 2 === 0;
});
console.log('select :' + even);

// all - Returns true if function returns true
numbers.push('a');
var allNumbers = _(numbers).all(function (item) {
    return typeof item === "number";
});
console.log('all : ' + allNumbers);

numbers.pop();
var allNumbers = _(numbers).all(function (item) {
    return typeof item === "number";
});
console.log('all :' + allNumbers);

// include - to check if collection contains certain item
var has5 = [1,2,3,4,5]
console.log('has5 Arary element : ' + has5); //true
console.log('has5 contains 6? : ' + _(has5).include('6')); //false

// max
console.log("Max in numbers " + numbers + " is " +  _(numbers).max());

// min
console.log("Min in numbers " + numbers + " is " + _(numbers).min());