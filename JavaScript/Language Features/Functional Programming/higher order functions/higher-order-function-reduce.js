var prices = [10, 20, 30, 40, 50, 60, 70];

// 1. Calculate total using without higher order function
var total = 0;
for (var i = 0; i < prices.length; i++) {
    total += prices[i];
}
console.log(total);

// 2. Use 'reduce' higher order function
var total = prices.reduce(function(sum, price) {
	return sum + price
}, 0); // 0 is initial value here

console.log(total);

// 3. ES6 arror function
var total = prices.reduce((sum, price) => sum = sum + price);
console.log(total);