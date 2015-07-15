let arr = [1, 2, 3, 4, 5];
let iterator = arr.values();
let next = iterator.next();
console.log(next.value);
let sum = 0;

while(!next.done) {
  sum += next.value;
  next = iterator.next();
}
console.log(sum);