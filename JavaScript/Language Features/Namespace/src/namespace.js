var namespace1 = namespace1 || {};

namespace1.currentDate = function(){
					var d = new Date();
					return d.getDate();
			};

var namespace2 = namespace2 || {};

namespace2.currentTime = function(){
					var d = new Date();
					return d.getTime();
			}

namespace2.currentDate = function(){
					var d = new Date();
					return d.getDate();
			};

console.log(namespace1.currentDate());
console.log(namespace2.currentTime());
console.log(namespace2.currentDate());
//console.log(currentDate()); //cant be accessed without namespace