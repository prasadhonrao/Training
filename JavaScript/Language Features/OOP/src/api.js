function SmtpClient() {
    this.send = function (msg) {
        console.log("Sending email to " + msg.to);
    }
}

var msg = {
    to: "Prasad.Honrao@MyCompany.com",
    from: "Prasad.Honrao@MyCompany.com",
    body: "test message",
    subject: "Test"
};

var client = new SmtpClient();
client.send(msg);

// sending anonymous object
client.send({
    to: "Prasad.Honrao@MyCompany.com",
    from: "Prasad.Honrao@MyCompany.com",
    body: "test message",
    subject: "Test"
});


// Defining default property on function
SmtpClient.prototype.sendUsingDefault = function (msg) {
    if (!msg.hasOwnProperty("from")) {
        msg.from = "Prasad.Honrao@MyCompany.com";
    }

    console.log("Default from property value : " + msg.from);
};

// default property, note not sending from value
client.sendUsingDefault({
    to: "Prasad.Honrao@MyCompany.com",
    body: "test message",
    subject: "Test"
});