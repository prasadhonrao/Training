// for...if loop over the collection values unlike for...in which loops over collection index
let arr = [1, 2, 3, 4, 5];
let sum = 0;

for (let v of arr) {
	sum += v;
}

console.log('1 + 2 + 3 + 4 + 5 =', sum);