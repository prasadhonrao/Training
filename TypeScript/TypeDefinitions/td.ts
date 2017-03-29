/// <reference path=".\typings\jquery\jquery.d.ts" />

function CheckTypeScript(wow) {
    var greeter = new Greeter<string>(wow);
    $("#demo")[0].innerHTML = greeter.greet ();
}

class Greeter<T> {
    greeting: T;
    constructor(message: T) {
        this.greeting = message;
    }
    greet() {
        return this.greeting;
    }
}