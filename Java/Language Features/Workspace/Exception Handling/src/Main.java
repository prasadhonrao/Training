public class Main {

	public static void main(String[] args) {
		
		int i = 10;
		int j = 2;
		
		try {
			int result = i / (j-2);
			System.out.println(result);
		} catch (ArithmeticException e) {
			System.out.println("Invalid Value" + e.getMessage());
		} catch (Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
		} finally {
			System.out.println("exit...");
		}
	}

}
