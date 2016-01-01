console.log(0.1 + 0.2 === 0.3);

console.log("abc"[0]);

console.log(Math.min() < Math.max());

var es = [];
for (var i = 0; i < 10; i++) {
  es[i] = function () {
    console.log("Upcoming edition of ECMAScript is ES" + i);
  };
}
es[6](); // Upcoming edition of ECMAScript is ES10