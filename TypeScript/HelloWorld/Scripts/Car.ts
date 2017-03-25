class Car {
    engine: string;

    constructor(engine: string) {
        this.engine = engine;
    }

    start() {
        console.log("Engine started : " + this.engine);
    }

    stop() {
        console.log("Engine stopped : " + this.engine);
    }
}

window.onload = function () {
    var car = new Car("V8");
    car.start();
    car.stop();
}