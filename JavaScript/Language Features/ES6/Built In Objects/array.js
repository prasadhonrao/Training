// array find method returns the actual value;
var arr = [1, 2, 3, 4, 5];
console.log(arr.find(n => n > 3));

// findIndex returns the index of the matched element
console.log(arr.findIndex(n => n > 3));

// fill function fills the array with passed value
console.log(arr.fill("p"));
console.log(arr.fill("A", 2, 3));