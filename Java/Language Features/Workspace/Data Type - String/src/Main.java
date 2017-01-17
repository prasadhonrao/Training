public class Main {

	public static void main(String[] args) {

		// String declaration
		String message = "Hello World!";
		System.out.println(message);

		// String is an object so can be declared using constructor
		String greeting = new String("Hello World 2!");
		System.out.println(greeting);

		// Strings are immutable
		String user = "Prasad";
		user = user + " Honrao"; // creates a new string (immutable)
		System.out.println(user);

		// String Methods

		// 1. String equality
		String greeting1 = "I Love ";
		greeting1 += "Java";

		String greeting2 = "I Love Java";

		System.out.println(greeting1 == greeting2); // Reference equality check
		System.out.println(greeting1.equals(greeting2)); // character by
															// character
															// comparison

		String greeting3 = greeting1.intern();
		String greeting4 = greeting2.intern();
		System.out.print("Intern : ");
		System.out.println(greeting3 == greeting4); // Useful for lot of string
													// comparison, inexpensive
													// as compared to character
													// by character comparison

		// 2. Length
		System.out.println("Number of characters in " + message + " are " + message.length());

		// 3. toUpperCase
		System.out.println("hello world".toUpperCase());

		// 4. indexOf
		System.out.println("hello world".indexOf('d'));

		// 5. replaceAll
		System.out.println("hello world".replaceAll("hello", "hola"));
	}

}
