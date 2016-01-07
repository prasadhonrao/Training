var arr = ['red', 'blue', 'green'];

console.log(arr[arr.length-1]);

// Add a new property to access last element

Object.defineProperty(arr, 'last', {get : function() {
	return this[this.length-1];
}})

console.log(arr.last);

// Add a new array
var arr2 = ['One', 'Two', 'Three'];
console.log(arr2.last); // note last property is not accessible on arr2

Object.defineProperty(Array.prototype, 'last', {get : function() {
	return this[this.length-1];
}}) 

console.log(arr.last);
console.log(arr2.last); // Now its accessible in both the arrays