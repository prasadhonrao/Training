public class BoxingUnboxing {

	public static void main(String[] args) {

		// Before Java 5 valueOf and xxxValue pattern was compulsory
		Integer i1 = Integer.valueOf(100); // boxing
		int i2 = i1.intValue(); // unboxing
		System.out.println(i1);
		System.out.println(i2);

		// Java 5 and above infers the type based on the value
		Integer a = 200; // boxing
		int b = a; // unboxing
		Integer c = b; // boxing

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);

	}

}
