function Customer(name, company) {
    // public properties
    this.name = name;
    this.company = company;

    // private member
    var mailServer = "mail.MyCompany.com";

    // public member function
    this.sendMail = function (mailAddress) {
        sendMailViaServer(mailAddress, mailServer);
    };
}

function sendMailViaServer(address, server) {
    console.log("Sending mail to " + address + " using " + server);
}

var cust = new Customer("Prasad", "MyCompany");
cust.sendMail("Prasad.Honrao@MyCompany.com");