var foo = "bar";

function bar() {
	var foo = "baz";
	console.log("In bar : " + foo);

	function baz(foo) {
		foo = "bam";
		bam = "yay";
		console.log("In baz : " + foo);
	}
	baz();
}

console.log(foo); // global scope
bar();
console.log(foo);
console.log(bam);
//baz(); //error