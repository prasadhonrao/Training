var arr = [1, 2, 3];
console.log(arr);

var doubled = [];

for (var i = 0; i < arr.length; i++) {
	doubled.push(arr[i] * 2);
};
console.log(doubled);

/*
	Implementation using custom function 
*/

function mapForEach(arr, fn) {
	var newArr = [];
	for (var i = 0; i < arr.length; i++) {
		newArr.push(
			fn(arr[i])
		);
	};
	return newArr;
}

var newDoubled = mapForEach(arr, function(item) {
	return item * 2;
});
console.log(newDoubled);

// Reuse function
var triple = mapForEach(arr, function (item) {
	return item * 3;
});
console.log(triple);

// Reuse function
var greaterThanTwo = mapForEach(arr, function (item) {
	return item > 2;
});
console.log(greaterThanTwo);