var first = true,
 	second = false;

console.log(first && second);
console.log(first || second);

/* 
JavaScript OR operator ( || ) returns the first value in the expression 
which can be coerced to true
*/

function greet(name) {
	name = name || '<Default Value>';
	console.log(name);
}

greet('Prasad');
greet();