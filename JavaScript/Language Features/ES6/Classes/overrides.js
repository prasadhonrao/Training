class Person {
  constructor (name) {
    this._name = name;
    console.log("Person constructor called");
  }

  get name() {
    return this._name.toUpperCase();
  }

  set name (newValue) {
    this._name = newValue;
  }

  doWork() {
    return "free";
  }
}

class Employee extends Person {
  constructor(name, title) {
    super(name);
    this._title = title;
    console.log("Employee constructor called");
  }

  get title() {
    return this._title.toUpperCase();
  }

  set title (newValue) {
    this._title = newValue;
  }

  doWork() {
    // to call super method, use super() or super.doWork syntax
    return "paid";
  }
}

let e1 = new Employee("Prasad", "Architect");
let p1 = new Person("Scott");
console.log(e1.doWork());
console.log(p1.doWork());
