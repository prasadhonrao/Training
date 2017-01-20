public class Array {

	public static void main(String[] args) {
		IntArray();
		CharArray();
		StringArray();
		MultidimensionalArray();
	}

	private static void MultidimensionalArray() {
		int[][] table = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, };

		for (int row = 0; row < table.length; row++) {

			for (int col = 0; col < table[row].length; col++) {
				System.out.print(table[row][col] + "  ");
			}

			System.out.println();
		}

	}

	private static void StringArray() {
		// String Array
		String[] colors = { "Red", "Green", "Blue" };
		for (String color : colors) {
			System.out.println(color);
		}
	}

	private static void CharArray() {
		// Character Array
		char[] characters = { 'H', 'E', 'L', 'L', 'O' };
		for (int i = 0; i < characters.length; i++) {
			System.out.printf("%c", characters[i]);
		}
		System.out.println();
	}

	private static void IntArray() {
		int[] numbers = new int[5];

		numbers[0] = 100;
		System.out.println(numbers[0]);

		// int array elements gets initialized to zero by default
		System.out.println(numbers[1]);

		// Iterating over array element
		System.out.println("Array elements are - ");
		for (int i = 0; i < numbers.length; i++) {
			System.out.println(numbers[i]);
		}
	}

}
