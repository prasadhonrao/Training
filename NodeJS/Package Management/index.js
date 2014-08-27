var _ = require("underscore");
_.map([1, 2, 3], function(num){ console.log (num * 3); });

var containsThree = _.contains([1, 2, 3], 3);
console.log(containsThree);