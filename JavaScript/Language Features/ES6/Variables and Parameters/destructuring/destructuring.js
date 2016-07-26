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

// Using ES6 template literal syntax
let [one, two, three] = ['globin', 'ghoul', 'ghost', 'white walker'];
console.log(`one is ${one}, two is ${two}, three is ${three}`);

// this comes very handy if you want to get the first element of an array
let [first, ...rest] = ['goblin', 'ghoul', 'ghost', 'white walker'];
console.log(`first is ${first} and then go all the rest: ${rest}`);
// => first is goblin and then go all the rest ghoul, ghost, white walker
