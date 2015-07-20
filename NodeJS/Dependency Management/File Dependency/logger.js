exports.welcomeMessage = "Welcome to Node.JS Dependency Management";

exports.author = {
    firstName : "Prasad",
    lastName : "Honrao",
    getFullName : function() {
        return this.firstName + " " + this.lastName;
    }
};

exports.log = function(message) {
    console.log("In Logger module log function");
    console.log(message);
}