/*jslint white: true */

// var bacon = {
//   slices: 0,
//   buy: function (quantity, chocolate) {
//     if (quantity == 0) { console.log("WAT?"); }
//     if (chocolate == true) { console.log("Adding Joy") }
//     this.slices += quantity;
//     console.log(this.slices + " total slices of bacon!");
//   }
// };

// bacon.buy(0);
// bacon.buy(5);
// bacon.buy(10, true);
// bacon.buy("", "1");
// bacon.buy("!", { toString: function() { return "1" } });



var bacon = {
  slices: 0,
  buy: function (quantity, chocolate) {
    if (typeof quantity !== "number") { return; }
    if (quantity === 0) { console.log("WAT?"); }
    if (chocolate === true) { console.log("Adding Joy"); }
    this.slices += quantity;
    console.log(this.slices + " total slices of bacon!");
  }
};

bacon.buy(0);
bacon.buy(5);
bacon.buy(10, true);
bacon.buy("", "1");
bacon.buy("!", { toString: function() { return "1"; } });