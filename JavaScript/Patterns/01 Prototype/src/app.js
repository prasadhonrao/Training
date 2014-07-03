var Calculator = function(){
	// shared code across instance goes here
};

Calculator.prototype = {
	add: function (x, y) {
		return x + y;
	},
	sub: function (x, y) {
		return x - y;
	}
};

window.onload = function(){
	var addInstance = new Calculator();
	console.log(addInstance.add(10, 20));

	var subInstance = new Calculator();
	console.log(subInstance.sub(100, 20));
};
