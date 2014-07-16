/*jslint white: true */
// function sell(item, price) {
//     "use strict";
//     if (price) {
//         price  = price === 0 ? "Free" : "$" + price.toFixed(2);
//         console.log("Selling " + item + " for " + price);
//     }
//     else {
//         console.log("Please provide a price");
//     }
// }

// sell("New Things", 0.50);
// sell("Old Things", 0);
// sell("Nothing");



function sell(item, price) {
    if (price !== undefined) {
        price = price === 0 ? "Free" : "$" + price.toFixed(2);
        console.log("Selling " + item + " for " + price);
    }
    else {
        console.log("Please provide a price");
    }
}

sell("New Things", 0.50);
sell("Old Things", 0);
sell("Nothing");