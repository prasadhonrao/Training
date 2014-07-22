(function(){
    Object.defineProperty(global,"MEANING_OF_LIFE",{
        writable: false,
        value : 50
    });

    console.log(global.MEANING_OF_LIFE);
    global.MEANING_OF_LIFE = 100;
    console.log(global.MEANING_OF_LIFE);

}());


// Solution - use strict
(function(){
    "use strict";
    Object.defineProperty(global,"MEANING_OF_LIFE",{
        writable: false,
        value : 50
    });

    console.log(global.MEANING_OF_LIFE);
    global.MEANING_OF_LIFE = 100;
    console.log(global.MEANING_OF_LIFE);

}());