/* RULEs
1. Function can contain only one rest paramter
2. Cannot contain default value
3. Must be the last paramter
4. Cannot use 'arguments' once declared a rest parameter
*/

var doWork = function(name,...other) {
  console.log("Hello " + name);
  console.log(other.join (' '));
}

doWork("Prasad");
doWork("Prasad", "analysis", "development", "defect fixing");

// -----------------------------------------------------------

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