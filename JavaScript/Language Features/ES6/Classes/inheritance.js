class Person {

  constructor (name) {
  	this._name = name;
  }

  get name() {
    return this._name.toUpperCase();
  }

  set name (newValue) {
  	this._name = newValue;
  }
}

class Employee extends Person {
  doWork() {
    console.log(this.name + " is working");
  }
}

let e1 = new Employee("Prasad");
console.log(e1.doWork());
