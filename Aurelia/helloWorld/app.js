import {sayHello} from 'greeter';

export class App{
    
    constructor() {
        this.message = "";
    }

    activate() {
        this.message = "Hello From Aurelia!!";
    }

    changeMessage() {
        this.message = "Goodbye!";
    }
}
