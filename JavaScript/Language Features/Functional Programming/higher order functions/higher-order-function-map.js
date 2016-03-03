var singles = [1, 2, 3];

// 1. Double input array without higher order function
var tempDouble = [];
for (var i = 0; i < singles.length; i++) {
	tempDouble.push(singles[i] *  2);
};
console.log(tempDouble);

// 2. Using higher order function map
var doubled = singles.map(function(input){
	return input * 2;
});
console.log(doubled); 

// 3. ES 6 arrow function
var esdoubled = singles.map((input) => { return input * 2 });
console.log(esdoubled);

// 4. ES 6 arrow function further reduced
var esdoubled = singles.map((input) => input * 2);
console.log(esdoubled);