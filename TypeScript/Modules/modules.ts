module Shapes {
    export class Rectangle {
        constructor (public height:number, public width:number) {
            console.log('Rectangle constructor called');
        }
    }
}

var rect = new Shapes.Rectangle(1, 2);

module Shapes {
    export class Circle {
        constructor (public radius:number) {
            console.log('Circle constructor called');
        }
    }

    class Square { // Note no export keyword
        constructor (public length:number) {
            console.log('Square constructor called');
        }
    }

    var s = new Square(5);
}

var cir = new Shapes.Circle(5);
//var s = new Square(5); // Square class is not exported so cant access outside module

// With TypeScript 1.5 modules should be declared using namespace word
namespace Inventory {
    var product;
    product = 'Sleeping Bag'
    console.log(product)
}