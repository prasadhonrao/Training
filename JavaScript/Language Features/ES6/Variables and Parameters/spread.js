function printNumbers(input1, input2) {
  console.log(input1);
  console.log(input2);
}

var numbers = [1, 2, 3, 4, 5];
printNumbers(...numbers); // passing entire array
printNumbers(numbers); // passing entire array will result into diff output

// Creating array on the fly
let first = [1, 2, 3, 4];
let second = [5, 6, 7, 8];
let mixed = [...first,...second];
console.log(mixed);
