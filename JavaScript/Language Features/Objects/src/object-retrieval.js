// Object retrieval
var customer = {
    name: "Prasad"
}

var city = customer["city"] || 'Pune';
console.log('Customer ' + customer.name + ' lives in city ' + city);