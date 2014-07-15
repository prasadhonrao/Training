//  var start = function(){

// 	var sayHello = function(){
// 		console.log("Hello...");
// 	};

// 	var sayBye = function(){
// 		console.log("Bye...");
// 	};

// 	setInterval(sayHello, 3000);
// 	setInterval(sayBye, 2000);
// }();


var start = function(){
	var sayHello = function(){
		console.log("Hello...");
	};

	var sayBye = function(){
		console.log("Bye...");
	};

	setTimeout(sayHello, 3000);
	setTimeout(sayBye, 2000);
}();