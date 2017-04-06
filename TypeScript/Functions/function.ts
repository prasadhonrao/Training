var square = function(x) {
    return x * x;
};
console.log(square(5));

var square2 = x => x * x;
console.log(square2(5));

var area = (h, w) => h * w;
console.log(area(10,20));

var greet : (msg:string) => void; // function contract
greet = function(msg) {
    console.log(msg);
}
greet('hello prasad');

// function with optional parameter
var greetAgain : (name?:string)  => void;
greetAgain = function(name?:string) {
    console.log('Hello ' + name || 'unknown person')
}
greetAgain();
greetAgain('Prasad');