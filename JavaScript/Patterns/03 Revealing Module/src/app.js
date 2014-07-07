var calculator = function(){
	// private members
	var addMessage = "calling add function",
		subMessage = "calling sub function",

		doAdd = function(x, y){
			log(addMessage);
			return x + y;
		},

		doSub = function(x, y){
			log(subMessage);
			return x - y;
		},

		log = function (message) {
			console.log(message);
		};

	// public members
	return {
		add : doAdd,
		sub : doSub
	};
}(); // self invoking function, so no need to use new keyword while creating instance


console.log(calculator.add(10,20));
console.log(calculator.sub(10,20));
// console.log(calculator.log('Test')); log function is not accessible
// console.log(calculator.doAdd(10,20)); doAdd function is not accessible

