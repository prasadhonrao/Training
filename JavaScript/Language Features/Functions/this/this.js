var h = function hello(msg) {
    console.log(this); // this applies to owner of the function. Since its a global function, this ex will return Window / globals object
};
h();


//Below example owner of 'this' is obj.
var obj = {
    name: 'Prasad',
    greet: function () {
        console.log(this.name);
    }
};
obj.greet();

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