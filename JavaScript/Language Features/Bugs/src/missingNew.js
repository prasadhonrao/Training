/*jslint white: true */
// function Customer(fname, lname) {
//     this.firstName = fname;
//     this.lastName = lname;
// }

// var amit = new Customer("Amit","Deo"),
//     prasad = Customer("Prasad","Honrao");

// console.log(amit);
// console.log(prasad);

// Solution 1 using new
function Customer (fname, lname) {
    this.firstName = fname;
    this.lastName = lname;
}

var amit = new Customer("Amit","Deo"),
    prasad = new Customer("Prasad","Honrao");

console.log(amit);
console.log(prasad);

// Solution 2 - using instanceof
function Customer (fname, lname) {
    if(!(this instanceof Customer)) {
        return new Customer(fname, lname);
    }
    this.firstName = fname;
    this.lastName = lname;
}

var amit = new Customer("Amit","Deo"),
    prasad = Customer("Prasad","Honrao");

console.log(amit);
console.log(prasad);