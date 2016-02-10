//Functions are used as classes
function Customer(name, company) {
    //public properties
    this.name = name;
    this.company = company;

    //private variables
    var mailserver = "mail.mycompany.com",
        sendMail = function () {
            console.log("sending email");
        }
}

var cust = new Customer("Prasad", "MyCompany");
cust.__proto__ = Array.__proto__;

for (var prop in cust) {
    // DETECT PROPERTY
    // var has = cust.hasOwnProperty("name")
    // var isEnum = cust.propertyIsEnumerable("name");
    console.log(prop + " : " + cust[prop]);
}