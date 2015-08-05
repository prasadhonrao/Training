// Closure Gotcha!

for (var i = 1; i <= 5; i++) {
	setTimeout(function() {
		console.log("i : " + i);
	}, i*1000);
};

// Solution 1
// for (var i = 1; i <= 5; i++) {
// 	(function(i){
// 		setTimeout(function() {
// 			console.log("i : " + i);
// 		}, i*1000);
// 	}(i))
// };

// Solution 2
// for (let i = 1; i <= 5; i++) {
// 	setTimeout(function() {
// 		console.log("i : " + i);
// 	}, i*1000);
// };