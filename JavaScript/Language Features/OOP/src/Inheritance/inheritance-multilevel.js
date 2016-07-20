// Inheritance Hierarchy:
//   Barbarian -> DrawableGameObject -> GameObject -> Object

function GameObject(){
    // game object ctor
}
function DrawableGameObject(){
    // drawable object ctor
}

DrawableGameObject.prototype = Object.create(GameObject.prototype);
DrawableGameObject.constructor = DrawableGameObject;

function Barbarian(){
    // barbarian ctor
}
Barbarian.prototype = Object.create(DrawableGameObject.prototype);
Barbarian.prototype.constructor = Barbarian;

var conan = new Barbarian();
console.log(conan instanceof Barbarian);
console.log(conan instanceof DrawableGameObject);
console.log(conan instanceof GameObject);
console.log(conan instanceof Object);