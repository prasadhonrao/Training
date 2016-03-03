var pricelist = [10, 20, 30, 40, 50, 60, 70];

var totalPrices = function (prices) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        total += prices[i];
    }
    return total;
};


var totalPricesOver30 = function (prices) {
    var total2 = 0;
    for (var i = 0; i < prices.length; i++) {
        if (prices[i] > 30) {
            total2 += prices[i];
        }
    }
    return total2;
};

var totalPricesLess30 = function (prices) {
    var total2 = 0;
    for (var i = 0; i < prices.length; i++) {
        if (prices[i] < 30) {
            total2 += prices[i];
        }
    }
    return total2;
};

console.log(totalPrices(pricelist));
console.log(totalPricesOver30(pricelist));
console.log(totalPricesLess30(pricelist));

// Higher Order Function
var totalPricesNew = function (prices, selector) {
    var total = 0;
    for (var i = 0; i < prices.length; i++) {
        if(selector(prices[i])) {
            total += prices[i];
        }
    }

    return total;
};

console.log(totalPricesNew(pricelist, function(price) { return true; }));
console.log(totalPricesNew(pricelist, function(price) { return price > 30;}));
console.log(totalPricesNew(pricelist, function(price) { return price < 30;}));