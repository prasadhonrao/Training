// Array constructos is overloaded - If one value is passed it defines number of elements in an array. If multiple values are passed, those becomes array members.
// var firstArray = new Array(5),
//     secondArray = new Array(1, 2, 3),
//     combined = firstArray.concat(secondArray);

// console.log(JSON.stringify(combined));

var firstArray = [5],
    secondArray = [1, 2, 3],
    combined = firstArray.concat(secondArray);

console.log(JSON.stringify(combined));