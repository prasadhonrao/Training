// Encapsulation is the packing of data and functions into a single component.

// Single Instance
var conan = {
    name: "Conan, The Barbarian",
    "character class": "barbarian",
    hp : 200,
    weapons: [{
        name: "two-handed sword",
        type: "sword",
        damage: "2d20+10",
        material: "cimmerian steel",
        status: "well maintained",
        equipped: true
    }],
    talk: function(){ console.log("I am " + this.name + " !!!");}
}

conan.talk();
// User defined objects are derived from Object base class
console.log(conan instanceof Object);

console.log("---------------------------------------------------------");

// Constructor function to create multiple instances
function Barbarian(name){
    this.name = name;
    this["character class"] = "barbarian";
    this.hp = 200;
    this.weapons = [];
    this.talk = function(){
        console.log("I am " + this.name + " !!!");
    };
    this.equipWeapon = function(weapon){
        weapon.equipped = true;
        this.weapons.push(weapon);
    };
}

var conan = new Barbarian("Conan, the Barbarian");
conan.equipWeapon({
        name: "two-handed sword",
        type: "sword",
        damage: "2d20+10",
        material: "cimmerian steel",
        status: "well maintained"
    });
conan.talk();
console.log("Number of weapons " + conan.weapons.length);
console.log(conan instanceof Barbarian)
console.log(conan instanceof Object)