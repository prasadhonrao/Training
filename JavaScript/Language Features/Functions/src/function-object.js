function hello(msg) {
    console.log('Hello');
};

var paramLength = hello.length;
console.log("Number of parameters in function definition: " + paramLength);

var functionName = hello.name;
console.log("function name: " + functionName);

var functionbody = hello.toString();
console.log("function body: " + functionbody);

// Since functions are objects, you can add new members on the fly
hello.language = 'english';
console.log(hello.language);

// new function can be added as a property to user defined functions
hello.say = function() {
	console.log('Hello again!');
};

hello.say();