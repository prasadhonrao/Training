let x = 10,
    y = 20;

console.log("X = " + x + ", Y = " + y);

// swap using destructuring
[x, y] = [y, x];
console.log("X = " + x + ", Y = " + y);

// add expression
[x, y] = [x + 10, y + 10];
console.log("X = " + x + ", Y = " + y);

// Another way to declare variable using destructuring
let [firstName, lastName] = ["Prasad", "Honrao"];
console.log(firstName + " " + lastName);

