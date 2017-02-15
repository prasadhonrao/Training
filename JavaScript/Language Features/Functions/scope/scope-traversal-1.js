var foo = "bar";

function bar() {
	var foo = "baz";
	console.log("In bar : " + foo);
}

function baz(foo) {
	foo = "bam"; // refers to local parameter. Rename foo param to something else, it will refer to global variable
	bam = "yay";
	console.log("In baz : " + foo);
}

console.log(foo);
bar();
baz();
console.log(foo);