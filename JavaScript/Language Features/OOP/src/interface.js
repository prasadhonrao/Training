//JS does not support interface like C#, however can be implemented like below

function sendEmail(r) {
    var to = r.email;
    var name = r.name;
    console.log(name);
}

function Customer(name, email) {
    this.name = name;
    this.email = email;
}

var cust = new Customer("Prasad", "Prasad.Honrao@MyCompany.com");
sendEmail(cust);

// passing an object with required properties
var fakeObject = {
    email: '',
    name: 'Fake'
}
sendEmail(fakeObject);