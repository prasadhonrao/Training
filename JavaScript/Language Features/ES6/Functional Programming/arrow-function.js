let add = (x, y) => x + y;
console.log(add(1,2));

let square = (x) => x*x;
console.log(square(add(2,3)));

let three = () => 3;
console.log(square(add(2,three())));

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