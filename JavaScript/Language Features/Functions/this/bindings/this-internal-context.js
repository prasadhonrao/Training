function foo(el) {
  console.log(el, this.id);
}

var obj = {
  id: "awesome!"
};

// internally uses explicit binding
[10, 20, 30].forEach(foo, obj);