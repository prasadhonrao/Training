function buildFunctions() {
	var arr = [];

	for (var i = 0; i < 3; i++) {
		arr.push( function() {
			console.log(i);	// remember function is not executed here.
		});
	};

	return arr;
}

var fs = buildFunctions();
fs[0]();
fs[1]();
fs[2]();

console.log('---------------------------------')

// Solution

function buildFunctions2() {
	var arr = [];

	for (var i = 0; i < 3; i++) {
		arr.push(
			(function(j) {
				return function() {
					console.log(j);
				}
			}(i))
		);
	};

	return arr;
}

var fs2 = buildFunctions2();
fs2[0]();
fs2[1]();
fs2[2]();