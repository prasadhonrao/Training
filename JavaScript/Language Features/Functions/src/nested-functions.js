function doWork() {
	console.log("doing work");

	function monitorWork() {
		console.log("monitoring work");
	}

	return monitorWork();
}

doWork();