 function hello(msg) {
    console.log('Hello');
};

var paramLength = hello.length; // 
console.log("Number of parameters in function definition: " + paramLength);

var functionName = hello.name;
console.log("function name: " + functionName);

var functionbody = hello.toString();
console.log("function body: " + functionbody);