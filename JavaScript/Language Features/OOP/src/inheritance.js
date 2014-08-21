function Animal(foodType){
    this.foodType = foodType;
}

Animal.prototype.feed = function(){
    console.log("Fed the animal: " + this.foodType);
}

var dog = new Animal("dog food"),
    cat = new Animal("milk");

dog.feed();
cat.feed();

var dogIsAnimal = dog instanceof Animal;
console.log("dog is Animal? : " + dogIsAnimal);

//Inheritance
function Cow(color){
    this.color = color;
}

Cow.prototype = new Animal("cow food");

var myCow = new Cow("White");
myCow.feed();

var cowIsAnimal = myCow instanceof Animal;
console.log("cow is Animal? : " + cowIsAnimal);