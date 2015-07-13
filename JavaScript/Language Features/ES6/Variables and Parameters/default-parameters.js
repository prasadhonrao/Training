var doWork = function(hours = 8) {
  for (var i=0; i< hours; i++) {
    console.log("Doing work " + i);
  }
}

doWork(5);
doWork();

let add = function (number1, number2 = 10) {
  return number1 + number2;
};

console.log(add(1));