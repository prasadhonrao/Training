function getArgumentsLength() {
    console.log("number of arguments - " + arguments.length);
}

getArgumentsLength();
getArgumentsLength(1);
getArgumentsLength(1, '');
getArgumentsLength(1, '', 12 / 12 / 2012);

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

function foo(one, two, three) {
    if (two) console.log(two);
    if (three) console.log(three);
}
foo(1, 2);

function bar() {
    console.log("First argument value - " + arguments[0]);
}
bar(99, 2);
bar();