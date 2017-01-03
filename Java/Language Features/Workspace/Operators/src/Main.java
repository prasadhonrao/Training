public class Main {

    public static void main(String[] args) {
	    int firstNumber = 100;
        int secondNumber = 10;

        // ARITHMETIC
        System.out.println(firstNumber + secondNumber);
        System.out.println(firstNumber - secondNumber);
        System.out.println(firstNumber * secondNumber);
        System.out.println(firstNumber / secondNumber);
        System.out.println(firstNumber % secondNumber);

        // RELATIONAL
        System.out.println(firstNumber > secondNumber);
        System.out.println(firstNumber >= secondNumber);
        System.out.println(firstNumber < secondNumber);
        System.out.println(firstNumber <= secondNumber);

        secondNumber = secondNumber + 1;
        System.out.println(firstNumber == secondNumber);

        secondNumber = secondNumber + 1;
        System.out.println(firstNumber != secondNumber);

        // TURNARY
        firstNumber++;
        secondNumber++;
        System.out.println(firstNumber);
        System.out.println(secondNumber);

        // LOGICAL OPERATORS
        if (firstNumber > 10 & secondNumber > 10) {
            System.out.println("Both the numbers are greater than 10");
        } else {
            System.out.println("One of the number is not greater than 10");
        }

        // OR
        if (firstNumber > 10 | secondNumber > 10) {
            System.out.println("Either of the number is greater than 10");
        } else {
            System.out.println("Both the numbers are not greater than 10");
        }
        
        // EXCLUSIVE OR - Either of the value must be true or else expression will return false
        boolean firstBool = true;
        boolean secondBool = false;
        boolean thridBool = true;
        System.out.print("XOR : ");
        System.out.println(firstBool ^ secondBool);
        System.out.print("XOR : ");
        System.out.println(firstBool ^ thridBool);

        // NEGATION
        boolean someValue = true;
        boolean anotherValue = !someValue;
        System.out.println(anotherValue);

        // CONDITIONAL LOGICAL OPERATORS
        // RHS executes only if LHS is true
        // AND
        if (firstNumber > 10 && secondNumber > 10) {
            System.out.println("Both the numbers are greater than 10");
        } else {
            System.out.println("One of the number is not greater than 10");
        }

        // OR
        if (firstNumber > 10 || secondNumber > 10) {
            System.out.println("Either of the number is greater than 10");
        } else {
            System.out.println("Both the numbers are not greater than 10");
        }

    }
}