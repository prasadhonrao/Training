function purchase(item, amount){
    //amount = parseInt(amount); // ES3 considers number starts with 0 as octal number
    amount = parseInt(amount, 10);
    console.log("Got " + item + ": $" + amount.toFixed((2)));
}

purchase("Eggs", "01");
purchase("Bacon", "08");