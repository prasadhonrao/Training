var colors = [];
colors [1] = "Black";
colors [6] = "Red";

Array.prototype.myColor = "Transparent";

// for(i=0; i< colors.length; ++i){
//     console.log(colors[i]);
// }

// for (name in colors){
//     console.log(colors[name]);
// }

for (name in colors) {
    if (colors.hasOwnProperty(name)) {
        console.log(colors[name]);
    }
}

// ES 5
colors.forEach(function(color){
    console.log(color);
});