console.log("Hello World");

var author = {
    firstName : "Prasad",
    lastName : "Honrao",
    getFullName : function() {
        return this.firstName + " " + this.lastName;
    }
}
console.log(author.getFullName());

var players = ["Sachin Tendular", "Roger Federer", "Shane Warne", "Mike Tyson", "Steffi Graf"];
for (var i = 0; i < players.length; i++) {
    console.log("\t" + players[i]);
};