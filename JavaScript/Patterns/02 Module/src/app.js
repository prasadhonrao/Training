var Calculator = function () {
	// private member variable
	var addMessage = "calling add function",
		subMessage = "calling sub function",

	// private member function
	log = function (message) {
		console.log(message);
	};

	//public members
	return {
		add : function (x, y) {
			log(addMessage);
			return x + y;
		},
		sub : function (x, y) {
			log(subMessage);
			return x - y;
		}
	}
};

var calc = new Calculator();
console.log(calc.add(1,2));
console.log(calc.sub(1,2));
// console.log(calc.log('test')); log function is private


