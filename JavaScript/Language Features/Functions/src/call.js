var greet1 = function(name){
	console.log(this.toUpperCase() + " "  + name);
};

greet1.call("Hello", "Prasad"); // passing "Hello" as context


var greet2 = function(name1, name2){
	console.log(this.toUpperCase() + " "  + name1 + " and " + name2);
};
greet2.call("Hello", "Prasad" , "Rahul"); // passing "Hello" as context