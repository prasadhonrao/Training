'use strict';

// Block Level Scope using let

for (let i=0; i<5; i++) {
  console.log(i);
}

// console.log(i); // ReferenceError

console.log('------------------------------------------------')

// Variables declared using let do not hoist
// Enclosing {} is gramatically correct, is known is explicit block
{
  let p = 0;
  console.log(p);

  // console.log(q); // Error
  let q = 10;
}