import java.util.Scanner;

public class UserInput {

	public static void main(String[] args) {
		GetContinuousInputs();
		GetMultilineInputs();
	}

	private static void GetContinuousInputs() {
		int value;
		Scanner scanner = new Scanner(System.in);
		do {
			System.out.println("Enter a number");
			value = scanner.nextInt();
		} while (value != 5);
		scanner.close();
		System.out.println("Got 5!");
	}

	private static void GetMultilineInputs() {
		/*
		 * Sample Input 10 10.2 hi
		 */
		int i = 4;
		double d = 4.0;
		String s = "HackerRank ";

		Scanner scan = new Scanner(System.in);

		/* Declare second integer, double, and String variables. */
		int i2;
		double d2;
		String s2;

		/* Read and save an integer, double, and String to your variables. */
		i2 = scan.nextInt();
		d2 = scan.nextDouble();
		scan.nextLine();
		s2 = scan.nextLine();

		/* Print the sum of both integer variables on a new line. */
		System.out.println(i + i2);

		/* Print the sum of the double variables on a new line. */
		System.out.println(d + d2);

		/*
		 * Concatenate and print the String variables on a new line; the 's'
		 * variable above should be printed first.
		 */
		System.out.println(s + s2);

		scan.close();
	}

}
