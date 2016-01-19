// Till ES 5 functions are used to defined a Class in JS. 
// ES6 provides a class contruct to define the class.

function Customer(firstName, lastName) {
    // firstName, lastName are public properties
    this.firstName = firstName;
    this.lastName = lastName;

    this.talk = function() {
        console.log("Hello, my name is " + this.firstName + " " + this.lastName)
    }
}

var cust1 = new Customer("Prasad", "Honrao");
cust1.talk();

var cust2 = new Customer("Jack", "Taylor");
cust2.talk();