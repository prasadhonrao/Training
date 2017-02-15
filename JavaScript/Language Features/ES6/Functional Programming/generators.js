let numbers = function*() {
  for(let i=0; i<=5; i++) {
    console.log("Returning value : " + i);
    yield i;
  }
};

let sum = 0;
let iterator = numbers();
let next = iterator.next();
while(!next.done){
  sum+=next.value;
  next=iterator.next();
}

console.log(sum);