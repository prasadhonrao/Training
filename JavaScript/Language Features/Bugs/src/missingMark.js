// function getNames() {
//  var length = 0, names = ""

//  ['Prasad', 'Colin', 'Anil'].forEach(function(name, i){
//      length = i + 1
//      names += name + ' '
//  })

//  return
//  {
//      length: length,
//      names: names
//  }
// }
// console.log(getNames());

function getNames() {
    var length = 0,
        names = "";

    ['Prasad', 'Colin', 'Anil'].forEach(function (name, i) {
        length = i + 1;
        names += name + ' ';
    });

    return {
        length: length,
        names: names
    };
}

console.log(getNames());