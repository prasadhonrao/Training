/*jslint white: true */
// Common trap to miss break statement in switch
function getPrice(item) {
    var price = 0;
    switch (item) {
    case "apple":
        price = 1.25;
        break;
    case "banana":
        price = 0.75;
        break;
    case "orange":
        price = 1;
        break;
    case "passionfruit":
        price = 1.5;
    case "pear":
        price = 0.5;
        break;
    default:
        price = 0;
    }
    return price;
}
console.log(getPrice("passionfruit"));

// Alternate solution to switch statement using object

var store = (function() {
    var prices = {
        apple : 1.25,
        banana : 0.75,
        orange : 1,
        passionfruit : 1.5,
        pear : 0.5
    },
        getPrice = function(item, quantity) {
            return prices[item] * quantity;
        };
    return {getPrice : getPrice};
}());

console.log(store.getPrice("passionfruit", 2));

// Alternate solution using function

var price = price || {};
price.apple = function(quantity) {
    return 1.25 * quantity;
};
price.banana = function(quantity) {
    return 0.75 * quantity;
};
console.log(price.apple(3));
console.log(price.banana(10));