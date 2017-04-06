//Empty object
var point = {};

var point1 = { x :1, y: 2 };
var x = point1.x;

var point2 = {};
point2 = { x :1, y: 2 }; //changing the shape at runtime

var point3: Object = {};
point3 = { x :1, y: 2 };

// Object with method
var rectangle = {
    h: 10,
    w: 20,
    calculateArea: function() {
        return this.h * this.w;
    }
};
console.log("Rectangle area = " + rectangle.calculateArea());