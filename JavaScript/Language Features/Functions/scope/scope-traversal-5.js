var obj = {
	a: 2,
	b: 3,
	c: 4
};

obj.a = obj.b + obj.c;
obj.c = obj.b - obj.a;

// with creates a new lexical scope at runtime
with(obj) {
	a = b + c;
	c = b - a;
	d = 3;
}

console.log(obj.d); // global variable not available at obj scope!
console.log(d); // created a global variable at line 13