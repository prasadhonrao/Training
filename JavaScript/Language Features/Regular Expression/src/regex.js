// search - Returns the index of first instance of the given character. 
// If no character found then returns -1.
var resultS = "JavaScript".search(/S/);
console.log('Index of S in JavaScript : ' + resultS);
var resultQ = "JavaScript".search(/Q/);
console.log('Index of Q in JavaScript : ' + resultQ);


// exec
var input = "Text with some <strong>highlighted</strong> parts.";
var expression = /<strong>(.*)<\/strong>/;
var results = expression.exec(input);
console.log("matched string : " + results[0]);
console.log("first group : " + results[1]);


// test
var containsANumber = /\d/.test('JavaScript1');
console.log("JavaScript1 contains a number? :" + containsANumber);