public class Main {

    public static void main(String[] args) {
        int number = 1;

        // WHILE
        System.out.println("WHILE");
        while (number <= 10) {
            System.out.println(number);
            number++;
        }

        // DO...WHILE
        System.out.println("DO...WHILE");
        number = 1;
        do {
            System.out.println(number);
            number++;
        } while (number <= 10);

        // FOR
        System.out.println("FOR");
        number = 1;
        for (number = 1; number <= 10; number++) {
            System.out.println(number);
        }

        // FOR EACH
        int[] numbers = {1, 2, 3, 4, 5};
        int sum = 0;
        for (int num: numbers) {
            sum = sum + num;
        }
        System.out.println("Sum is " + sum);
    }
}
