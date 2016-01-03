// ARRAY METHODS

// push
console.log("Array push");
var numbers = [1, 2, 3, 4, 5];
numbers.push(6);
numbers.push('$');
console.log(numbers);

// pop - this will take out '$' from number array
console.log("Array pop");
var numbers = [1, 2, 3, 4, 5];
var lastnumber = numbers.pop();
console.log(lastnumber);

// shift - remove from beginning
console.log("Array shift");
var numbers = [1, 2, 3, 4, 5];
console.log('numbers array length- ' + numbers.length);
var firstElement = numbers.shift();
console.log('numbers array length- ' + numbers.length);
console.log(firstElement);

// unshift - add to beginning
console.log("Array unshift");
var numbers = [1, 2, 3, 4, 5];
console.log('numbers array length- ' + numbers.length);
var lastElement = numbers.unshift(0);
console.log('numbers array length- ' + numbers.length);

//reverse
console.log("Array reverse");
var numbers = [1, 2, 3, 4, 5];
var reverseNumbers = numbers.reverse();
console.log(reverseNumbers);

//slice(start,index of last param + 1) - copies part of an array
console.log("Array slice");
var numbers = [1, 2, 3, 4, 5];
var numberSlice = numbers.slice(0, 3);
console.log(numberSlice);

//splice(start,count of nubmer of char to remove); - changes original array
console.log("Array splice");
var numbers = [1, 2, 3, 4, 5];
var numberSplice = numbers.splice(0, 3);
console.log(numberSplice);
console.log(numbers);

//sort - by default its string sort
console.log("Array sort");
var companies = ['Microsoft', 'Cognizant', 'Apple', 'Google', 'Samsung'];
console.log(companies.sort());

// numeric sort trick
/*sort function takes optional function parameter,
function returns 0 if numbers are equal,
negative of numbers are in correct order,
positive if numbers needs to be swapped*/

console.log(numbers.sort(function (first, second) {
    return first - second;
}));