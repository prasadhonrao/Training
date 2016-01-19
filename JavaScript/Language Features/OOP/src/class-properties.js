function Customer(fname, lname) {
    this.lastName = lname;

    var _name = fname;

    // Note this syntax doesn't work in older browsers like IE8, so run in Firefox
    Object.defineProperty(this, "firstName", {
        get: function () { return _name; },
        set: function (value) { _name = value; }
    });

    this.talk = function() {
        console.log("Hello, my name is " + this.firstName + " " + this.lastName)
    }
}

var cust = new Customer("Prasad", "Honrao");
cust.talk();