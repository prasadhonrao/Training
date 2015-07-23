// destructuring with functions
let {city, state, zip} = getAddress();

function getAddress() {
	return {
		city: "Woodbridge",
		state: "NJ",
		zip: "12345"
	};
}

console.log(city + " " + state + " " + zip);