var a = "a";

var outer = function () {
    var b = "b";

    var middle = function () {
        var c = "c";

        var inner = function () {
            // can access all variables declared in outer scope
            console.log(a + b + c);
        };

        inner();
    };

    middle();
};

outer();