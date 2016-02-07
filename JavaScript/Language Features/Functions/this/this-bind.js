// bind
var obj = {
    findThis: function () {
        console.log(this);
    }
};
obj.findThis();

var f = obj.findThis.bind(this); //bind to global obhect
f();


function greetUser(message) {
    console.log(this + ' ' + message);
};

greetUser('Me', 'Message');
greetUser.call('Me', 'Message'); // first parameter passed as this.