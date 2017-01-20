public class Main {

	private static String message = "Class level variable";

	public static void main(String[] args) {

		System.out.println(message);

		// Anonymous block!
		{
			String message = "Block level variable";
			System.out.println(message);
		}

		String message = "Method level variable";
		System.out.println(message);

	}

}