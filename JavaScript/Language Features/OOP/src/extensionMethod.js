Array.prototype.giveMeCount = function () {
    return this.length;
};

var a = ["1", "11"];
var count = a.giveMeCount();
console.log(count);