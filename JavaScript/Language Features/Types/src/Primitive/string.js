var language = "JavaScript";
var authorName = "Prasad Honrao";

// Declaration using double quote
language = "JavaScript";
console.log(language);

// Declaration using single quote
language = 'JavaScript';
console.log(language);

// Add single quote inside a string
language = "'JavaScript'";
console.log(language);

// Add double quote inside a string
language = '"JavaScript"';
console.log(language);

// Add single quote inside a string using escape sequence
language = 'Java \' Script';
console.log(language);

// add Unicode character
var copyright = 'Copyright symbol \u00a9';
console.log(copyright);

// string concatenation
var authorfullName = "Prasad" + "Honrao";
console.log(authorfullName);

// string concatenation again
console.log("cat match");
console.log('c' + 'a' + 't' == "cat");

//charAt(index) - 0 based
language = "JavaScript";
console.log("6th character in string JavaScript is " + (language).charAt(5));

// indexOf(string)
language = "JavaScript";
console.log("Index of 'S' in JavaScript is :" + language.indexOf('S'));

// replace(from,to)
language = 'JavaScript';
var newLanguage = language.replace('Java', 'Type');
console.log(newLanguage);

// replace using regular expression
var text = "303 is a magic number";
//console.log("replace using regular expression : " + text.replace('3', '4'));
//console.log("replace using regular expression : " + text.replace(/3/, '4'));
console.log("replace using regular expression : " + text.replace(/3/g, '4'));

//slice(index, index+1) - returns a substring of a string
var letters = "JavaScript";
console.log(letters.slice(4, 9));

//split(separator)
var sentence = "JavaScript is really a powerful language";
var words = sentence.split(" ");
for (i = 0; i < words.length; i++) {
    console.log(words[i]);
}

// case
console.log("JavaScript".toUpperCase());
console.log("JavaScript".toLowerCase());

console.log(+42 + " " + typeof +42);
console.log(42..toString() + " " + typeof 42..toString());