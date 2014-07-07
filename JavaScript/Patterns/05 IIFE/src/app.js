(function () {
	var Calculator = function () {

		var add = function (x, y) {
			return x + y;
		};

		return {
			add : add
		}
	};

	var instance = Calculator();
	console.log(instance.add(1,2));
}());