'use strict';

/*
Function curring - is a way in which function does not take all the arguments upfront, instead it 
wants you to provide first argument and it returns another function, which is supposed to call with 
second argument, which in turns returns another function, which is supposed to call with third
argument. Repeat this process until all the arguments are passed
*/

// 1. Function without curring i.e passing all the parameters in one go
let dragon = (name, size, element) =>
	name + 'is a ' +
	size + ' dragon that brethes ' +
	element + '!';

console.log(dragon('fluffy', 'tiny','lightning'));

// 2. Curry it now
let dragon2 = 
	name => 
		size =>
			element =>
				name + 'is a ' +
				size + ' dragon that brethes ' +
				element + '!';

console.log(dragon2('fluffy')('tiny')('lightning'));