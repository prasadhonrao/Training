// Functions are used to defined a Class in JS
function Customer(firstNameParam, lastNameParam) {
    // firstName, lastName are public properties
    this.firstName = firstNameParam;
    this.lastName = lastNameParam;

    this.talk = function() {
        console.log("Hello, my name is " + this.firstName + " " + this.lastName)
    }
}

var cust1 = new Customer("Prasad", "Honrao");
cust1.talk();

var cust2 = new Customer("Jack", "Taylor");
cust2.talk();