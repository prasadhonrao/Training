var people = [
	{name: 'Prasad', role:'developer'},
	{name: 'Scott', role:'manager'},
	{name: 'Jack', role:'developer'},
	{name: 'Jane', role:'manager'},
	{name: 'Amit', role:'developer'},
	{name: 'Rupa', role:'tester'}
];

// 1. Find developers without using higher order function
var firstDeveloper;
for (var i = 0; i < people.length; i++) {
	if (people[i].role === 'developer') {
		firstDeveloper = people[i];
		break;
	}
};
console.log(firstDeveloper);

// 2. Using higher order function 'find' which returns first item
var developers = people.find(function(person){
	return person.role === 'developer';
});
console.log(developers);