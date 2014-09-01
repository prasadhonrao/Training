var edge = require('edge');

var helloWorld = edge.func(function () {/*
    async (input) => { 
    	Console.WriteLine("This is .Net code in JavaScript!!!");
		
		var numbers = new [] { 1, 2, 3, 4, 5};
		foreach (var i in numbers) 
		{
			Console.WriteLine(i);
		}

        return ".NET Welcomes " + input.ToString(); 
    }
*/});

helloWorld('JavaScript', function (error, result) {
    if (error) throw error;
    console.log(result);
});