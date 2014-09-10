var KBC = {
    ans: "Red",
    askQuestion: function (answered) {
        console.log("Your fav color :" + this.ans);
        answered(this.ans);
    }
}

KBC.askQuestion(function (answer) {
    console.log("Answer is " + answer);
});