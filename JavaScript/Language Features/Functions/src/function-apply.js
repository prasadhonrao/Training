var greet1 = function(name){
	console.log(this.toUpperCase() + " "  + name);
};

var names = ["Prasad"];
greet1.apply("Hello", names); // passing "Hello" as context


var greet2 = function(name1, name2){
	console.log(this.toUpperCase() + " "  + name1 + " and " + name2);
};

names = ["Prasad", "Amit"];

greet2.apply("Hello", names); // passing "Hello" as context