// Two lets cant have same variable like var
var you = "you";
var you = "you";
let me = "me";
let me = "me"; //SyntaxError


let foo = "foo";
var bar = "bar";

(function printfoobar() {
  let zoo = "zoo";
  console.log(foo + bar + zoo);
}());

console.log(zoo); // ReferenceError