// Note : Switch case is case sensitive
var month = "March";

switch (month) {
    case "January":
    case "February":
    case "March":
        console.log(month + " comes in first quarter");
        break;

    case "April":
    case "May":
    case "June":
        console.log(month + " comes in second quarter");
        break;

    case "July":
    case "August":
    case "September":
        console.log(month + " comes in third quarter");
        break;

    case "October":
    case "November":
    case "December":
        console.log(month + " comes in fourth quarter");
        break;

    default:
        console.log("Please enter a valid month");
}