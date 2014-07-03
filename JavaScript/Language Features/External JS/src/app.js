console.log("logging through external javascript file");

// onload fires when all the external files / images / css are downloaded
window.onload = function(){
	console.log("window loaded");
};

// use jQuery document.load event for faster response