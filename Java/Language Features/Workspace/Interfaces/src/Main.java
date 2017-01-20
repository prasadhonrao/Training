import java.util.Arrays;
import hardware.*;
import northwind.*;

public class Main {

	public static void main(String[] args) {

		IMachine machine = new Machine();
		machine.turnOn();
		System.out.println();

		// comparing two objects using comparable interface
		System.out.println("Comparison using comparable interface");
		Customer c1 = new Customer(10);
		Customer c2 = new Customer(1);
		Customer c3 = new Customer(3);

		Customer[] customers = { c1, c2, c3 };

		Arrays.sort(customers);

		for (Customer customer : customers) {
			System.out.println(customer.Id);
		}
		System.out.println();

		// comparing two objects using comparable<T> interface
		System.out.println("Comparison using comparable<T> generic interface");
		Person p1 = new Person(10);
		Person p2 = new Person(1);
		Person p3 = new Person(3);
		Person p4 = new Person(2);

		Person[] people = { p1, p2, p3, p4 };

		Arrays.sort(people);

		for (Person person : people) {
			System.out.println(person.Id);
		}
	}

}
