// events defined in the function in the form of function!
function SmtpClient() {
    this.send = function (msg) {
        console.log("Sending email to " + msg.to);
    },
    this.complete = function (r) {
        console.log("function completed");
    },
    this.error = function (e) {
        console.log("error occurred");
    }
}

var msg = {
    to: "Prasad.Honrao@MyCompany.com",
    from: "Prasad.Honrao@MyCompany.com",
    body: "test message",
    subject: "Test"
};

var client = new SmtpClient();
try {
    client.send(msg);
    client.complete();
} catch (e) {
    client.error();
}