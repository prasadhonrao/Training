let foo = "foo";
var bar = "bar";

(function printfoobar() {
  console.log(foo + bar);
}());

// Two lets cant have same variable like var
var you = "you";
var you = "you";
let me = "me";
let me = "me"; //SyntaxError

// Scope difference between let and var
let a = 10;
let b = 20;
if (true) {
	let a = 100;
	var b = 200
	console.log("1. Inside a : " + a + " b : " + b);
	a = 1000;
	b = 2000;
	console.log("2. Inside a : " + a + " b : " + b);
}
console.log("3. Outside a : " + a + " b : " + b);
