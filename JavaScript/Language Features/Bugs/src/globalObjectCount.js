/*jslint white: true */
(function() {

    function sayHello(person) {
        message = "Hello, " + person; // adding to global object
        // var message = "Hello, " + person;
        console.log(message);
        document.getElementById("message").innerText = message;
    }

    function sayHelloShouldNotAddToGlobalScope(globalObject) {
        var initialGlobalCount = Object.keys(globalObject).length; // Object.keys is not supported in older browsers
        console.log(initialGlobalCount);
        sayHello("@PrasadHonrao");
        var endGlobalCount = Object.keys(globalObject).length;
        if(initialGlobalCount == endGlobalCount) {
            console.log("Success!");
        } else {
            console.log("Failed - Initial Count: " +
               initialGlobalCount +
               " End Count: " +
               endGlobalCount);
        }
    }

    sayHelloShouldNotAddToGlobalScope(window);
}());