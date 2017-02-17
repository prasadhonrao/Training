var arr = [1, 2, 3, 4, 5];
console.log(arr.length);

arr.push(6);
console.log(arr.length);
console.log(arr.pop());

console.log(arr.__proto__);
console.log(Object.getPrototypeOf(arr)); //recommended
console.log(arr.__proto__ == Object.getPrototypeOf(arr));

// Define hierarchy using __proto__

var vehicle = {
    drive : function() {
        console.log("Zoom racing car");
    }
};

var car = {
    drive : function() {
        console.log("driving normal car!");
    }
};

var bus = {
    drive : function() {
        console.log("driving a bus!");
    }
};
car.__proto__= vehicle;
car.drive();

console.log(Object.getPrototypeOf(car) === Object.getPrototypeOf(bus));
bus.__proto__ = vehicle;
console.log(Object.getPrototypeOf(car) === Object.getPrototypeOf(bus));

var o = {};

// inherit from the same prototype as an array object
o.__proto__ = Array.prototype;

// now we can invoke any of the array methods ...
o.push(3);
console.log(o.length);