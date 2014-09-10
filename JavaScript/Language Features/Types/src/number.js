// number is a floating points data type, no other numeric data type
console.log(typeof (1));
console.log(typeof (1.2));
console.log(typeof ('1'));

console.log(1 + 1);
// caveat - below result produces 11
console.log(1 + "1");

// basic arithmetic operations
console.log(1 - 1);
console.log(2.2 * 2);
console.log(4 / 2);
console.log(10 % 3);

// built-in functions
console.log(0.1 + 0.2);
console.log((0.1 + 0.2).toFixed(2));

var octalNumber = 070;
console.log(octalNumber);
console.log("Type of octalNumber is " + typeof(octalNumber));        

var hexNumber = 0x123456;
console.log(hexNumber);
console.log("Type of octalNumber is " + typeof(hexNumber));        

var exponentNumber = 1.34e5; // this expression is equal to (1.34*10)pow 5 = 134000    
console.log(exponentNumber);
console.log("Type of exponentNumber is " + typeof(exponentNumber));                

// special values
console.log(Number.MIN_VALUE);
console.log(Number.MAX_VALUE);
console.log(Number.POSITIVE_INFINITY);
console.log(Number.NEGATIVE_INFINITY);

// exponent
console.log(1e2) // this expression is equal to (1*10)pow 2 = 100                                                                