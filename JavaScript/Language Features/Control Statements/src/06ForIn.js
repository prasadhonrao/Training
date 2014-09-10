//for - in  -- its NOT similar to C# for each. JS function returns index while C# returns value
var customer = {
    name: "Prasad",
    age: 32
}

for (var prop in customer) {
    console.log("Property - " + prop + " Value - " + customer[prop]);
}

var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet"];
for(var color in colors){
    console.log(colors[color]);
}