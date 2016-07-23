// Named function declaration
var squareFunc = function square (num) {
    return num * num;
};

console.log(squareFunc.name); //square
console.log("2 Square : " + squareFunc(2));
//console.log("2 Square : " + square(2)); //error