function doWork(){
	console.log("doing work");
}

function monitorWork(f){
	console.log("monitoring work");
	return f();
}

monitorWork(doWork);