/* 
When a function is invoked with 'new' in front of it, following things are done automatically

1. A brand new empty object is created 
2. The newly constructed object is [[Prototype]]-linked
3. The newly constructed object is set as the 'this' binding for that function call
4. Returns newly constructed object
*/ 

function Foo(a) {
	this.a = a;
}

var obj = new Foo(2);
console.log(obj.a);