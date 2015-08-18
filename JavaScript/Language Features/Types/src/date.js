// Date Variable declaration - default to today's date
var birthDate = new Date();
console.log(birthDate);
console.log("Type of birthDate Variable is " + typeof (birthDate));

// Date Variable declaration - default to date value specified
var birthDate = new Date(1980, 0, 1);
console.log(birthDate);

// Date Variable declaration - default to date value specified
birthDate = new Date("January 01 1980");
console.log(birthDate);

// Date Variable declaration - default to date and time value
var birthDate = new Date(1980, 0, 1, 15, 30, 45);
console.log(birthDate);

// Date Variable declaration - default to date and time value
var birthDate = new Date();
birthDate = new Date("August 01, 1979 11:12:13");
console.log(birthDate);

// Date Comparison
var firstDate = new Date(2012, 09, 15);
var today = new Date();
if (today === firstDate) {
    console.log("Eq");
}
else {
    console.log("Today is before 12 Nov 2012");
}

//Date Subtraction
var from = new Date();
for (var i = 1; i <= 10; i++) {
    var result = Math.pow(i, 2);
    console.log(i + ":" + result);
}
var to = new Date();
var elapsed = to - from;
console.log("Took " + elapsed + " milliseconds to calculate square of 10 numbers");

// Date function
var someDate = new Date();

// get
console.log(someDate.getDate());
console.log(someDate.getMonth());
console.log(someDate.getHours());
console.log(someDate.getFullYear());

//set
someDate.setDate(20);
someDate.setMonth(05);
someDate.setYear(1999);
console.log(someDate);