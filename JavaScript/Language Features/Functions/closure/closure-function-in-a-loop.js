'use strict';

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

// Solution using IIFE

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

console.log('---------------------------------')

// ES 6 Solution using 'let'

function buildFunctions3() {
	var arr = [];
	for (let i = 0; i < 3; i++) {
		arr.push( function() {
			console.log(i);	// remember function is not executed here.
		});
	};

	return arr;
}

var fs3 = buildFunctions3();
fs3[0]();
fs3[1]();
fs3[2]();