// Similar to C# ForEach

var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet"];
for(var color of colors){
    console.log(color);
}

console.log('--------------------------------------------------')

var customers = [
					{id: 1, name:'Prasad'},
					{id: 2, name:'Mili'},
					{id: 3, name:'Ashok'}
				];
for (var customer of customers) {
	console.log(customer.name);
}