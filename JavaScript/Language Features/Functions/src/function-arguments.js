/* arguments is used to get access to variable number of arguments passed while calling the function*/

function getArgumentsLength() {
    console.log("number of arguments - " + arguments.length);
}

getArgumentsLength();
getArgumentsLength(1);
getArgumentsLength(1, '');
getArgumentsLength(1, '', 12 / 12 / 2012);

/* Use of arguments to calculate the total of variable number of arguments*/

function add() {
    var total = 0;
    for (var i = 0; i < arguments.length; i++) {
        total += arguments[i];
    }
    return total;
}
console.log(add());
console.log(add(1));
console.log(add(1, 2));
console.log(add(1, 2, 'wow, its working for string also!','£'));

/* Find missing arguments using if*/

function foo(one, two, three) {
    if (two) console.log(two);
    if (three) console.log(three);
}
foo(1, 2);

/* Access arguments using indexer syntax*/
function bar() {
    console.log("First argument value - " + arguments[0]);
}
bar(99, 2);
bar();