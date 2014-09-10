 // Construct a namespace
var namespace1 = namespace1 || {};
var namespace2 = namespace2 || {};

// add a function to namespace
namespace1.hello = function () {
    return "Hello from namespace 1";
};

// add a function to namespace
namespace2.hello = function () {
    return "Hello from namespace 2";
};

// nested namespace
namespace2.functions = namespace2.functions || {};
namespace2.functions.hello = function () {
    return "Hello from nested namespace";
}

console.log(namespace1.hello());
console.log(namespace2.hello());
console.log(namespace2.functions.hello());