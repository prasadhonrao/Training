class Employee {
  constructor (name) {
  	this._name = name;
  }

  doWork () {
    return "complete";
  }

  getName () {
    return this._name;
  }
}

let e1 = new Employee("Prasad");
let e2 = new Employee("Scott");

console.log(e1.getName());
console.log(e2.getName());