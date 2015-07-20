function isNumeric(input) {
        return typeof (input) === 'number';
    }

function CheckEvenOdd(input) {
    try {
        //alert(input + " is a " + typeof (input));

        if (!isNumeric(input)) {
            throw {
                name: "SomethingWrongExcpetion",
                message: "You have provided invalid input."
            }
        }
        else {
            if (parseInt(input) % 2 === 0) {
                console.log(input + " is an even number");
            }
            else {
                console.log(input + " is an odd number");
            }
        }
    } catch (e) {
        console.log("In catch block");
        console.log(e.message);
    }
    finally {
        console.log("In finally block");
    }
}

CheckEvenOdd(2);
CheckEvenOdd("Invalid Input");