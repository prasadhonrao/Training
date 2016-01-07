function Cat (name, color) {
	this.name = name;
	this.color = color;
}

Cat.prototype.age = 4;

var fluffy = new Cat('fluffy', 'white');
var tuffy = new Cat('tuffy', 'white');

console.log(fluffy.age);
console.log(tuffy.age);

// defining a dynamic age property on fluffy
fluffy.age = 5;

console.log(fluffy.age);
console.log(tuffy.age); // get it from prototype if not defined on object itself