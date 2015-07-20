// == with type conversion
console.log('1 == "1" ? ' + (1 == "1"));
console.log('0 == "" ? ' + (0 == ""));
console.log('A == "a" ? ' + ("A" == "a"));

console.log('0 == true ? ' + (0 == true));
console.log('0 == "true" ? ' + (0 == "true"));
console.log('0 == false ? ' + (0 == false));
console.log('0 == "false" ? ' + (0 == "false"));

console.log('1 == true ? ' + (1 == true));
console.log('1 == "true" ? ' + (1 == "true"));
console.log('1 == false ? ' + (1 == false));
console.log('1 == "false" ? ' + (1 == "false"));

console.log("Boolean object equality")
console.log(new Boolean(true) == new Boolean(true));

// === strict equal
// objects are equal to themselves
var customer = {};
console.log('customer === customer ? ' + (customer === customer));

// objects are not equal to other objects even they contain same value
var anotherCustomer = {};
console.log('customer === anotherCustomer ? ' + (customer === anotherCustomer));

// primitive type equality
console.log("JavaScript === JavaScript ? " + ("JavaScript" === "JavaScript"));
console.log("JavaScript === JAVASCRIPT ? " + ("JavaScript" === "JAVASCRIPT"));
console.log("Microsoft === Apple ? " + ("Microsoft" === "Apple"));
console.log("13 === 13 ? " + ("13" === "13"));
console.log('1 === "1" ? ' + (1 === "1"));

console.log("Boolean object strict equality")
console.log(new Boolean(true) === new Boolean(true));

// inequality
console.log("13 !== 14 ? " + ("13" !== "14"));

//convert to boolean
console.log(!!("false"));
console.log(!!(true));
console.log(Boolean("false"));
console.log(Boolean("  "));
console.log(Boolean(NaN));