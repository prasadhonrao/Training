var Calculator = function(){
	// instance shared code goes here...
};

Calculator.prototype = {
	add: function (x, y) {
		return x + y;
	},
	sub: function (x, y) {
		return x - y;
	}
};

var addInstance = new Calculator();
console.log(addInstance.add(10, 20));

var subInstance = new Calculator();
console.log(subInstance.sub(100, 20));