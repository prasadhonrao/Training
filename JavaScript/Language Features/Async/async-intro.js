// Callback
setTimeout(function() {
	console.log("callback function called");
},1000);

// Callback Hell!
setTimeout(function(){
	console.log("One");
	setTimeout(function(){
		console.log("Two");
		setTimeout(function(){
			console.log("Three");
		},1000);
	},1000)
},1000);


// Solving callback Hell
function one(cb) {
	console.log("One");
	setTimeout(cb,1000);
}
function two(cb) {
	console.log("Two");
	setTimeout(cb,1000);
}
function three() {
	
	console.log("Three");
}
one(function(){
	two(three);
});