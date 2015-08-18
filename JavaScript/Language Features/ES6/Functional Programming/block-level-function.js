'use strict';
function f() { return 1; }
{
  function f() { return 2; }
}
console.log(f() === 1);