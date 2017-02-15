class Employee {

  constructor (name) {
  	this._name = name;
  }

  doWork () {
    return "complete";
  }

  get name() {
    return this._name.toUpperCase();
  }

  set name (newValue) {
  	this._name = newValue;
  }
}

let e1 = new Employee("Prasad");
let e2 = new Employee("Scott");

console.log(e1.name);
console.log(e2.name);