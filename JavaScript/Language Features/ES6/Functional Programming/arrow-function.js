let add = (x, y) => x + y;
console.log(add(1,2));

let square = (x) => x*x;
console.log(square(5));

// parenthis are optional if you just have one parameter
let square2 = x => x*x;
console.log(square2(5));

let three = () => 3;
console.log(square(add(2,three())));

// if you add a {} in function body, you have to use return statement
let four = () => { return 4 };
console.log(four());

// Multiple statements needs a return keyword
let add2 = (x, y) => {
  var temp = x + y;
  return temp;
}
console.log(add2(10,20));

// array function
let arr = [1, 2, 3, 4, 5];
var sum = 0;
arr.forEach(n => sum +=n);
console.log(sum);

// REAL Benefit - lexical binding of this