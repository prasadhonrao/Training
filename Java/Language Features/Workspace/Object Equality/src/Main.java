public class Main {
	public static void main(String[] args) {
		Customer c1 = new Customer(1);
		Customer c2 = new Customer(1);
		
		System.out.println(c1 == c2); // reference equality check
		System.out.println(c1.equals(c2)); // reference equality check

		Customer c3 = c1;
		System.out.println(c1 == c3); // reference equality check
		System.out.println(c1.equals(c3)); // reference equality check

		Person p1 = new Person(1);
		Person p2 = new Person(1);
		
		System.out.println(p1 == p2); // reference equality check
		System.out.println(p1.equals(p2)); // overridden equals
		
		Person self = new Person(1); // self equality check
		System.out.println(self.equals(self));
	}
}