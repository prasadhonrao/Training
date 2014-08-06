var athlete = {
	swim : function() {
		console.log(this.name + " is swimming...");
	}
};

var person = {
	name : "Prasad",
	play : function(toy) {
		console.log(this.name + " playing with " + toy);
	}
};

person.__proto__ = athlete;

person.play("ball");
person.swim();