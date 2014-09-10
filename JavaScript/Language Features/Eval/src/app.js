eval(console.log('Hello World using eval'));

// eval with JSON
var input = '{"Customers":[{"Id":"1", "Name":"Prasad"}]}';
eval("var data = " + input);
console.log("Output using eval : " + data.Customers[0].Name);

//json
var output = JSON.parse(input);
console.log("Output using JSON : " + output.Customers[0].Name);
console.log("Original JSON Data :" + JSON.stringify(output));