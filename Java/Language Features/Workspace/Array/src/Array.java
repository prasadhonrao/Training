public class Array {

	public static void main(String[] args) {
		int[] numbers = new int[5];
		
		numbers[0] = 100;
		System.out.println(numbers[0]);
		System.out.println(numbers[1]); // int array elements gets initialized to zero by default
		
		// Iterating over array element
		System.out.println("Array elements are - ");
		for (int i = 0; i < numbers.length; i++) {
			System.out.println(numbers[i]);
		}
	}

}
