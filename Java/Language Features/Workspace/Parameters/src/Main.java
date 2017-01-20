/*
* Both value and reference types are passed by value
*/

public class Main {

	public static void main(String[] args) {

		// Value Type
		int first = 100;
		int second = 200;
		System.out.println("Before Primitive Swap");
		System.out.println("First : " + first + " Second: " + second);
		System.out.println("After Primitive Swap");
		Swap(first, second);
		System.out.println("First : " + first + " Second: " + second);

		System.out.println();

		// Reference Type
		Customer c1 = new Customer(100);
		Customer c2 = new Customer(200);
		System.out.println("Before Reference Type Swap");
		System.out.println("First : " + c1.GetId() + " Second: " + c2.GetId());
		System.out.println("After Reference Type Swap");
		Swap(c1, c2);
		System.out.println("First : " + c1.GetId() + " Second: " + c2.GetId());

		System.out.println("Variable number of parameters");
		PrintCustomers(c1, c2);
	}

	// Value type swap
	private static void Swap(int first, int second) {
		int temp = first;
		first = second;
		second = temp;
	}

	// Reference type swap
	private static void Swap(Customer first, Customer second) {
		Customer temp = first;
		first = second;
		second = temp;
	}

	// Rest parameter
	private static void PrintCustomers(Customer... customers) {
		for (Customer customer : customers) {
			System.out.println(customer.GetId());
		}
	}
}
