function Cat (name, color) {
	this.name = name;
	this.color = color;
}

var fluffy = new Cat('fluffy', 'white');

console.log(Cat.prototype === fluffy.__proto__);