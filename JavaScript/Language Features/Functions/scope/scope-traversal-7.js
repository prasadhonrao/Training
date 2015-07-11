var o1 = {
  bar: 'bar1',
  foo: function () {
    console.log(this.bar);
  }
};

var o2 = {
  bar: 'bar2',
  foo: o1.foo
};

var bar = 'bar3';
var foo = o1.foo;
console.log(o1.foo());
console.log(o2.foo());
console.log(foo());
