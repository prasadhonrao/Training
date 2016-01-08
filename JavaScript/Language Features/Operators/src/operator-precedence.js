var a = 1,
	b = 2,
	c = 3;

// assignment
a = b = c;

console.log(a);
console.log(b);
console.log(c);

// When operators precedence is at same level, expression will always execute from left to right
// In below case y * 2 will execute before foo call

var y = 10,
	z = 20;

var x = y * 2 + foo(z * 10);
console.log(x);

function foo(input) {
	console.log('In foo : ' + input);
	return input;
}