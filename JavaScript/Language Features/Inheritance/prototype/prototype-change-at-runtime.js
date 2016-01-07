function Cat (name, color) {
	this.name = name;
	this.color = color;
}

Cat.prototype.age = 5;

var fluffy = new Cat('fluffy', 'white');
console.log(fluffy.age);

Cat.prototype = {age : 10};
console.log(fluffy.age); // stick to old prototype since instance was created before changing prototype

var tuffy = new Cat('tuffy', 'white');
console.log(tuffy.age); // will get new prototype