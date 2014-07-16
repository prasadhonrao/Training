/*jslint white: true */
(function() {
    // Error in IE7
    var customer = {
        name: "Prasad",
        age : 35,
    };
    console.log(customer);

    // Error in IE7, Length = 4 in IE8
    var numbers = [1, 2, 3, ];
    console.log(numbers.length);
    var i;
    for (i = 0; i < numbers.length; i++) {
        console.log(numbers[i]);
    };
}());