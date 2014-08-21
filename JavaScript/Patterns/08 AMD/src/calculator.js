var Calculator = function () {
    // private member variable
    var addMessage = "calling add function",
        subMessage = "calling sub function",

    // private member function
    log = function (message) {
        console.log(message);
    };

    //public members
    return {
        add : function (x, y) {
            log(addMessage);
            return x + y;
        },
        sub : function (x, y) {
            log(subMessage);
            return x - y;
        }
    }
};

module.exports = Calculator;