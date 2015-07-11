var variable;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = 10;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = 3.14;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = "3.14";
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = "";
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = "JavaScript";
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = true;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = new Date("01 Jan 1980");
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = undefined;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = null;
console.log("VALUE : " + variable + " TYPE : " + typeof(variable)); // weird!

variable = { language : "JavaScript" };
console.log("VALUE : " + variable + " TYPE : " + typeof(variable));

variable = [1, 2, 3, 4, 5];
console.log("VALUE : " + variable + " TYPE : " + typeof(variable)); 

variable = function () { return 42 ;};
console.log("VALUE : " + variable + " TYPE : " + typeof(variable)); 
console.log("VALUE : " + variable() + " TYPE : " + typeof(variable())); 