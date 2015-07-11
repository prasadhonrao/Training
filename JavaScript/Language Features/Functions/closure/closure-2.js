function foo() {
	var bar = "bar";

	function baz() {
		console.log(bar);
	}

	bam(baz); // taking reference to baz function and passing it to bam
}

function bam(baz) {
	baz(); // executing outside foo execution environment is closure
}

foo();