var people = [
	{name: 'Prasad', role:'developer'},
	{name: 'Scott', role:'manager'},
	{name: 'Jack', role:'developer'},
	{name: 'Jane', role:'manager'},
	{name: 'Amit', role:'developer'},
	{name: 'Rupa', role:'tester'}
];

// 1. Find developers without using higher order function
var developers = [];
for (var i = 0; i < people.length; i++) {
	if (people[i].role === 'developer') {
		developers.push(people[i]);
	}
};
console.log(developers);

// 2. Using higher order function
var developers = people.filter(function(person){
	return person.role === 'developer';
});
console.log(developers);

// 3. Customize higher order function
var isDeveloper = function(person) {
	return person.role === 'developer';
};

var developers = people.filter(isDeveloper);
console.log(developers);