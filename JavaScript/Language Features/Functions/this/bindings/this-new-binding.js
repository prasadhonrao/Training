/* 
When a functio is invoked with 'new' in front of it, following things are done automatically

1. A brand new object is created 
2. The newly constructed object is [[Prototype]]-linked
3. The newly constructed object is set as ths 'this' binding for that function call
4. Returns newly constructed object
*/ 

function foo(a) {
	this.a = a;
}

var obj = new foo(2);
console.log(obj.a);