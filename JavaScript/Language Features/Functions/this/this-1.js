"use strict";

function foo() {
    console.log(this.bar);
}

var bar = "bar1";
var obj = {bar : "bar2"};

foo();
foo.call(obj);