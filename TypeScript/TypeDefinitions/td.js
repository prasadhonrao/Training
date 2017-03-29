/// <reference path=".\typings\jquery\jquery.d.ts" />
function CheckTypeScript(wow) {
    var greeter = new Greeter(wow);
    $("#demo")[0].innerHTML = greeter.greet();
}
var Greeter = (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return this.greeting;
    };
    return Greeter;
}());
