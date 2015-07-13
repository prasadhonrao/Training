let sum = function() {
  let result = 0;
  for(let i=0; i< arguments.length; i++) {
    result += arguments[i];
  }
  return result;
};

let result = sum(1,2,3);
console.log(result);

// Refactor using rest parameters
// Always the last parameter in the function
let sum2 = function(text, ...numbers) {
  let result = 0;
  for(let i=0; i< numbers.length; i++) {
    result += numbers[i];
  }
  return result;
};

let result = sum2("Sum", 1,2,3);
console.log(result);