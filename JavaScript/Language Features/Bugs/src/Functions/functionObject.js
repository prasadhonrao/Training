var totalPrices = function(prices) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        total += prices[i];
    }
    return total;
};

var totalPricesOver30 = function(prices) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        if(prices[i] > 30){
            total += prices[i];
        }
    }
    return total;
};

var totalPricesLess30 = function(prices) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        if(prices[i] < 30){
            total += prices[i];
        }
    }
    return total;
};

var prices = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100];
console.log(totalPrices(prices));
console.log(totalPricesOver30(prices));
console.log(totalPricesLess30(prices));

// Solution 

// Pass lambda / function as argument
var totalPricesNew = function(prices, selector) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        if (selector(prices[i])) {
            total += prices[i];
        }
    }
    return total;
};

console.log(totalPricesNew(prices, function(price) { return price} ));
console.log(totalPricesNew(prices, function(price) { return price > 30} ));
console.log(totalPricesNew(prices, function(price) { return price < 30} ));