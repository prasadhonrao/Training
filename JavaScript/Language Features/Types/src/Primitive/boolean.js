var isActive = true;
console.log("Value : " + isActive + " Type : " + typeof (isActive));

isActive = false;
console.log("Value : " + isActive + " Type : " + typeof (isActive));

isActive = 'false';
console.log("Value : " + isActive + " Type : " + typeof (isActive));

/* 
	These values returns false in an if statement
		undefined
		null
		empty string
        0
        -0
*/

var flag = "some text";
if (flag) {
    console.log("String value is a true condition");
}
else {
    console.log("String value is a false condition");
}

flag = 100;
if (flag) {
    console.log("Number value is a true condition");
}
else {
    console.log("Number value is a false condition");
}

flag = null;
if (flag) {
    console.log("Null value is a true condition");
}
else {
    console.log("Null value is a false condition");
}

if (!undefined) {
	console.log("undefined returns false in if condition")
}

flag = "";
if (flag) {
    console.log("Empty string is a true condition");
}
else {
    console.log("Empty string is a false condition");
}

flag = 0;
if (flag) {
    console.log("0 is a true condition");
}
else {
    console.log("0 is a false condition");
}

flag = -0;
if (flag) {
    console.log("-0 is a true condition");
}
else {
    console.log("-0 is a false condition");
}
