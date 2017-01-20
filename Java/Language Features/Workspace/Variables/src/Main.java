public class Main {
	public static void main(String[] args) {
		int dataValue = 100;
		System.out.println(dataValue);

		String message = "Java is a strongly type langauge";
		System.out.println(message);

		if (args.length > 0) {
			System.out.println("First command line argument value is : " + args[0]);
		} else {
			System.out.println("No command line arguments were passed");
		}
	}
}