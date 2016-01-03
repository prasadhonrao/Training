var _ = require("./lib/underscore-min.js");

var arr = [1, 2, 3, 4, 5];

// functional style
_.each(arr, function(num) {
	console.log(num);
})

// Object oriented style
_(arr).each(function (num) {
    console.log(num);
});