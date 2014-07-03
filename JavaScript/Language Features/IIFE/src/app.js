(function () {

	var createWorker = function () {
		var task1 = function () {
			console.log("Doing Job1");
		};

		var task2 = function () {
			console.log("Doing Job2");
		};

		return {
			job1 : task1,
			job2 : task2
		};
	};

	var worker1 = createWorker();
	worker1.job1();

	var worker2 = createWorker();
	worker2.job2();

}());