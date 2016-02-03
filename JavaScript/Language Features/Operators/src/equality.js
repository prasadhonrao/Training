// MDN Link - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Equality_comparisons_and_sameness

var first = 10,
 	second = "10";

console.log(first == second);
console.log(first != second);

// Strict Equal - No Coercion
console.log(first === second);
console.log(first !== second);