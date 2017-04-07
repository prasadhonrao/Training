var Shapes;
(function (Shapes) {
    var Rectangle = (function () {
        function Rectangle(height, width) {
            this.height = height;
            this.width = width;
            console.log('Rectangle constructor called');
        }
        return Rectangle;
    }());
    Shapes.Rectangle = Rectangle;
})(Shapes || (Shapes = {}));
var rect = new Shapes.Rectangle(1, 2);
(function (Shapes) {
    var Circle = (function () {
        function Circle(radius) {
            this.radius = radius;
            console.log('Circle constructor called');
        }
        return Circle;
    }());
    Shapes.Circle = Circle;
    var Square = (function () {
        function Square(length) {
            this.length = length;
            console.log('Square constructor called');
        }
        return Square;
    }());
    var s = new Square(5);
})(Shapes || (Shapes = {}));
var cir = new Shapes.Circle(5);
//var s = new Square(5); // Square class is not exported so cant access outside module
// With TypeScript 1.5 modules should be declared using namespace word
var Inventory;
(function (Inventory) {
    var product;
    product = 'Sleeping Bag';
    console.log(product);
})(Inventory || (Inventory = {}));
