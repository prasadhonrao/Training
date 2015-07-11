function foo() {
	var bar = "bar";

	return function() {
		console.log(bar);
	}; 
}

function bam() {
	foo()();
}

bam();