public class Main {

	public static void main(String[] args) {

		Integer i = 100;
		System.out.println(Integer.MIN_VALUE);
		System.out.println(Integer.MAX_VALUE);
		System.out.println(i.byteValue());

		Character ch = 'J';
		System.out.println(Character.isLetter(ch));
		System.out.println(Character.isDigit(ch));

		// Gotcha!! - Wrapper classes comparison works for int, short and byte
		// types if the value is between -128 to 127
		Integer first = 100 * 10;
		Integer second = 10 * 10 * 10;
		System.out.println(first == second);

		Integer third = 1000;
		Integer fourth = 990 + 100;
		System.out.println(third == fourth);

		Integer fifth = 100;
		Integer sixth = 90 + 10;
		System.out.println(fifth == sixth);
	}

}
