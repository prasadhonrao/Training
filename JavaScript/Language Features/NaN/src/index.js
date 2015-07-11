// isNan checks if the input is a number or not.

console.log("isNaN(1) - " + isNaN(1));
console.log("isNaN('1') - " + isNaN('1'));
console.log("isNaN(1 / 2) - " + isNaN(1 / 2));
console.log("isNaN('2' / '1') - " + isNaN('2' / '1'));

console.log("isNaN('Hello') - " + isNaN('Hello'));
console.log("isNaN(isNaN) - " + isNaN(isNaN));
console.log("isNaN(NaN) - " + isNaN(NaN));

console.log(10 / "zero"); // this returns NaN

console.log(NaN !== NaN); // NaN is the only value which returns true for Nan !== Nan