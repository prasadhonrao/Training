// CLASS DECLARATION
function Customer(name) {
    this.name = name;
}

// STATIC DATA DECLARATION
Customer.mailServer = "mail.MyCompany.com"
var server = Customer.mailServer;

// INSTANCE DATA DECLARATION
Customer newCust = new Customer();
newCust.name = "Prasad";