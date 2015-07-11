// In ES3, JavaScript supported block scope in a catch block

try {
	undefined();
}
catch (err) {
	console.log(err); // works!
}
//console.log(err); // ReferenceError