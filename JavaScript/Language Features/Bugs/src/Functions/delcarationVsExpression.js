(function(){
    function foo(){
        function bar() {
            return 3;
        }
        return bar();
        function bar() {
            return 8;
        }
    }
    console.log(foo());
}());


(function(){
    function foo(){
        var bar = function() {
            return 3;
        };
        return bar();
        var bar = function() {
            return 8;
        };
    }
    console.log(foo());
}());

(function(){
    console.log(foo());
    function foo(){
        var bar = function() {
            return 3;
        };
        return bar();
        var bar = function() {
            return 8;
        };
    }
}());

// (function(){
//     function foo(){
//         return bar();
//         var bar = function() {
//             return 3;
//         };
//         var bar = function() {
//             return 8;
//         };
//     }
//     console.log(foo());
// }());
