class Person {
    constructor(public firstName:string, public lastName:string) {

    }

    getFullName() {
        return this.firstName + " " + this.lastName;
    }
}

class Employee extends Person {
    constructor(public firstName:string, public lastName:string, public designation:string) {
        super(firstName, lastName);
    }
}

var prasad = new Employee('Prasad', 'Honrao', 'Architect');
var fullname = prasad.getFullName();
console.log(fullname);