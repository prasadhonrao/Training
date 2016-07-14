
public class Main {

	public static void main(String[] args) {
		// String declaration
		
		String message = "Hello World!";
		System.out.println(message);

		// String equality
		String greeting1 = "I Love ";
		greeting1 += "Java";
		
		String greeting2 = "I Love Java";
		
		System.out.println(greeting1 == greeting2); // Reference equality check
		System.out.println(greeting1.equals(greeting2)); // character by character comparison
		
		
	}

}
