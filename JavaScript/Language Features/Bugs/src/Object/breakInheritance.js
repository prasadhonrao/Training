// function Animal(name) {
//     this.name = name;
// }

// Animal.prototype.eat = function () {
//     console.log(this.name + " is eating");
// };

// Animal.prototype.sleep = function () {
//     console.log(this.name + " is sleeping");
// };

// function Cat(name) {
//     this.name = name;
// }

// Cat.prototype = Animal.prototype;

// Cat.prototype.eat = function () {
//     console.log(this.name + " is eating");
//     this.sleep();
// };

// function Dog(name) {
//     this.name = name;
// }

// Dog.prototype = Animal.prototype;

// Dog.prototype.sleep = function (){
//     console.log("Attack the humans!");
//     console.log(this.name + " is sleeping");
// };

// var cat = new Cat("Fluffy");
// cat.eat();

// var dog = new Dog("Ralph");
// dog.sleep();


// console.log(cat instanceof Animal);
// console.log(cat instanceof Cat);
// console.log(cat.constructor === Animal);
// console.log(cat.constructor === Cat);


// Solution

function Animal(name) {
    this.name = name;
}

Animal.prototype.eat = function () {
    console.log(this.name + " is eating");
};

Animal.prototype.sleep = function () {
    console.log(this.name + " is sleeping");
};

function Cat(name) {
    this.name = name;
}

Cat.prototype = Object.create(Animal.prototype);
Cat.prototype.constructor = Cat;

Cat.prototype.eat = function () {
    console.log(this.name + " is eating");
    this.sleep();
};

function Dog(name) {
    this.name = name;
}

Dog.prototype = Object.create(Animal.prototype);
Dog.prototype.constructor = Dog;

Dog.prototype.sleep = function (){
    console.log(this.name + " attacks the humans!");
    console.log(this.name + " is sleeping");
};

var cat = new Cat("Fluffy");
cat.eat();

var dog = new Dog("Ralph");
dog.sleep();

console.log(cat instanceof Animal);
console.log(cat instanceof Cat);
console.log(cat.constructor === Animal);
console.log(cat.constructor === Cat);