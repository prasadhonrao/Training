/*jslint white: true */

// var score = 1000;

// function play() {
//     console.log("Being :" + score);
//     if (!score){
//         console.log("setting default score");
//         var score = 100; // gets hoisted within function
//     }
//     console.log("End :" + score);
// }

// console.log(score);
// play();
// console.log(score);


// Solution 1 - Declare function at the start
var score = 1000;

function play() {
    var score;
    console.log("Being :" + score);
    if (!score){
        console.log("setting default score");
        score = 100;
    }
    console.log("End :" + score);
}

console.log(score);
play();
console.log(score);

