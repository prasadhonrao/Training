// In case of function declaration / expression 'this' always points to global object
console.log(this);
console.log('----------------------------------------------------')

/*
function sayHello() {
	console.log('hello');
	console.log(this);
}
sayHello();

console.log('----------------------------------------------------')

var sayBye = function () {
	console.log('bye');
    console.log(this); 
};
sayBye();

console.log('----------------------------------------------------')

// If 'this' is referred in a method of an object, then 'this' refers to the object itself
var person = {
    name: 'Prasad',
    greet: function () {
    	console.log(this);
        console.log(this.name);
        
        this.name = "Prasad Honrao"; // property can be mutated as well
        console.log(this.name);
    }
};
person.greet();
*/