var Timer = function(){
	var d = new Date();

	return function(){
		return d.getMilliseconds();
	}
};

var t1 = new Timer();
console.log(t1());

var t2 = new Timer();
console.log(t2());