function Barbarian(name){
	this.name = name;
}

var conan = new Barbarian("conan");
var logenNinefingers = new Barbarian("The Bloody Nine")
var shivers = new Barbarian("Caul Shivers");

// check if ravage function exists on shivers instance
if (typeof shivers.ravage == 'function') {
	console.log(shivers.ravage());
}

// add function to prototype and it will be available to all instances
Barbarian.prototype.ravage = function(){console.log(this.name + " attaaaaack!!");}
conan.ravage();
logenNinefingers.ravage();
shivers.ravage();
