/* RULEs
1. Function can contain only one rest paramter
2. Cannot contain default value
3. Must be the last paramter
4. Cannot use 'arguments' once declared a rest parameter
*/

var doWork = function(name,...other) {
  console.log("Hello " + name);
  console.log(other.join (' '));
}

doWork("Prasad");
doWork("Prasad", "analysis", "development", "defect fixing");