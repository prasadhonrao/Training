/*
There is no such thing as method overloading in JavaScript, however arguments variable can be used to identify
number of arguments and call different functions
*/
var barbarian = {
    sayHi: function(){
        var args;
        if (arguments.length === 0) {
            console.log("hi!");
        }
        if (arguments.length === 1){
            console.log(arguments[0]);
        }
        if (arguments.length > 1){
            // this is like type casting the arguments array-like variable
            // to an actual array so that I can use the join method
            args = Array.prototype.slice.call(arguments);
            console.log("hi " + args.join(", "));
        }
    }
}

barbarian.sayHi();
barbarian.sayHi("Conan");
barbarian.sayHi("Conan" ,"Whoopsy");