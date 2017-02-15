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
}

let e1 = new Employee("Prasad", "Architect");
console.log(e1.name + " "  + e1.title);
