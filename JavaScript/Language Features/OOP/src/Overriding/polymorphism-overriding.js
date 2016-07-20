function Barbarian(name){
    this.name = name;
}
var conan = new Barbarian('Conan');
console.log(conan.toString());

// override toString (Need to create new function to avoid hoisting issue)
function Barbarian2(name){
    this.name = name;
    this.toString = function(){
        return "Barbarian2: " + name;
    };
}
var conanTheDestroyer = new Barbarian2('Conan The Destroyer');
console.log(conanTheDestroyer.toString());

// OR add it to prototype
Barbarian.prototype.toString = function() {
	return "Barbarian prototype " + this.name;
}
var conan = new Barbarian('Conan');
console.log(conan.toString());
