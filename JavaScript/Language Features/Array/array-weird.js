var weird = [];
weird[0] = "JavaScript";
weird[3] = "Is Crazy";

console.log("Weird Array Length : " + weird.length);

for (var item in weird) {
	console.log(weird[item]);
}

console.log(weird[0]);
console.log(weird[1]);
console.log(weird[2]);
console.log(weird[3]);