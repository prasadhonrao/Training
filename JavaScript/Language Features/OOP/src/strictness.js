// WHAT IS DISALLOWED?
// undefined variables
// duplicate properties
// writing to read-only property
// modifying argument objects inside function

"use strict";
var greet = "Hello World";
console.log(greet);

var goodbyeMsg = "good Bye";
// goodbyeMsg = "good Bye"; // exception


function SayHello() {
    "use strict"; // strictness will be local to function
    var num1 = 10;
    // num1 = 10; //exception

    var y = "bye";
    // y = "bye"; //exception

    console.log(num1);
    console.log(y);
}

SayHello();