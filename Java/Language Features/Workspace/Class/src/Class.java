public class Class {
	public static void main(String[] args) {

		Customer newCustomer = new Customer("Prasad", 35);
		System.out.println(newCustomer.name + " " + newCustomer.age);

		Customer anotherCustomer = new Customer();
		anotherCustomer.age = 50;
		anotherCustomer.name = "Jacob";
		System.out.println(anotherCustomer.name + " " + anotherCustomer.age);

	}
}