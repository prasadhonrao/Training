// To run below program, compile the TypeScript file using tsc compiler and execute generated 
// JavaScript file using NodeJS

class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }
    greet() {
        return "Hello, " + this.greeting;
    }
}

let greeter = new Greeter("World");
console.log(greeter.greet())