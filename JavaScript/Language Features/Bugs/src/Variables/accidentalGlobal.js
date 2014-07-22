// function Bank(balance) {
//     this.fee = 0.01;
//     this.account = { balance: balance };
// }

// Bank.prototype.deposit = function (amount) {
//     var amountWithFee = fee = this.fee;
//     amountWithFee = amount - (amount * fee);
//     this.account.balance += amountWithFee;
// };

// Bank.prototype.withdrawal = function (amount) {
//     amountWithFee = amount + (amount * this.fee);
//     this.account.balance -= amountWithFee;
// };

// var bank = new Bank(1000);
// bank.withdrawal(250);
// console.log(JSON.stringify(bank));
// console.log(global.amountWithFee, global.fee);
// bank.deposit(250);
// console.log(JSON.stringify(bank));
// console.log(global.amountWithFee, global.fee);



function Bank(balance) {
    this.fee = 0.01;
    this.account = { balance: balance };
}

Bank.prototype.deposit = function (amount) {
    var fee = this.fee, // declare multiple variables with comma
        amountWithFee = amount - (amount * fee);
    this.account.balance += amountWithFee;
};

Bank.prototype.withdrawal = function (amount) {
    var amountWithFee = amount + (amount * this.fee); // declared using var
    this.account.balance -= amountWithFee;
};

var bank = new Bank(1000);
bank.withdrawal(250);
console.log(JSON.stringify(bank));
console.log(global.amountWithFee, global.fee);
bank.deposit(250);
console.log(JSON.stringify(bank));
console.log(global.amountWithFee, global.fee);