function Customer(name, company) {
	this.name = name;
	this.company = company;
}

Customer.prototype.send = function(mail) {
	console.log(this.name + " " + mail);
}

var cust = new Customer("Prasad");
cust.send("test@gmail.com");