var foo = true;
const language = "JS";

if (foo) {
  var a = 2;
  const b = 10;  // Block level constant
  console.log("Inside explicit scope : " + language);
}
// console.log(b); // const b is not in scope

console.log(a);
console.log("Outside explicit scope : " + language);
//console.log(b); //ReferenceError