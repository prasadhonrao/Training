/*
Abstraction -  Information hiding is the principle of segregation of the design decisions in a computer program
that are most likely to change, thus protecting other parts of the program from extensive modification
if the design decision is changed.
*/
function Barbarian(name){
    // this variables are only available in the scope of this function.
    // Remember, in JavaScript, only functions create new scopes!
    var weapons = [],
        characterClass = "barbarian",
        hp = 200;

    this.name = name;
    this.talk = function(){
        console.log("I am " + this.name + " !!!");
    };
    this.equipWeapon = function(weapon){
        weapon.equipped = true;
        // Now we reference the weapons variable directly creating a closure.
        // You cannot use this.weapons to access this variable any more
        // It is so private that the only way to access it is via closure
        weapons.push(weapon);
    };
}

var conan = new Barbarian("Conan");
conan.talk();
conan.equipWeapon("Sword");
console.log(conan.weapons); // weapons not accessible!