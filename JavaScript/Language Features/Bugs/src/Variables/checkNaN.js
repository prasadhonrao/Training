function purchase(item, amount){
    amount = parseFloat(amount);
    if (amount == NaN) {
        throw ("Not a number");
    }
    console.log("Got " + item + ": $" + amount.toFixed((2)));
}

try{
    purchase("Eggs", "01");
    purchase("Bacon", "free");
}catch(e){
    console.log(e);
}




// function purchase(item, amount){
//     amount = parseFloat(amount);
//     //if (amount == NaN) {
//     if (isNaN(amount)) {
//         throw ("Not a number");
//     }
//     console.log("Got " + item + ": $" + amount.toFixed((2)));
// }

// try{
//     purchase("Eggs", "01");
//     purchase("Bacon", "free");
// }catch(e){
//     console.log(e);
// }
