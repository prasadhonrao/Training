module OOP
{
    class Car {

        // FIELDS
        private _engine: string;
        private _color: string;

        // CONSTRUCTOR
        constructor(engine: string, color:string) {
            // Do not set backing fields directly as property getter and setter can contain validation logic
            this.engine = engine;
            this.color = color;
        }

        // Above constructor can be implemented using below shorthand syntax
        // constructor(public engine: string, public color:string) { }

        // PROPERTIES
        get engine(): string {
            return this._engine;
        }

        set engine(value: string) {
            if (value === undefined) throw 'Supply an engine!';
            this._engine = value;
        }

        get color(): string {
            return this._color;
        }

        set color(value: string) {
            if (value === undefined) throw 'Supply a color!';
            this._color = value;
        }

        // FUNCTIONS
        start() {
            console.log("Engine started : " + this.engine);
        }

        stop() {
            console.log("Engine stopped : " + this.engine);
        }

        showCarInfo() {
            console.log("Car engine : " + this.engine + " Color : " + this.color);
        }
    }

    var alto = new Car('800', 'White');
    alto.start();
    alto.stop();
    alto.showCarInfo();

    var honda = new Car('City', 'Black');
    honda.color = null;
    honda.showCarInfo();
}