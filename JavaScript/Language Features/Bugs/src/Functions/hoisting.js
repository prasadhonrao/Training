function foo(n) {
    console.log("Function foo was called with value " + n);
}

foo(10);

function foo(n) {
    console.log("Redefining function foo with value " + n);
}

foo(20);

// var bar = function (n) {
//     console.log("Function bar was called with value " + n);
// }

// bar(10);

// bar = function(n) {
//     console.log("Redefining function bar with value " + n);
// }

// bar(20);