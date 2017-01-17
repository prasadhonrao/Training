public class Main {

	public static void main(String[] args) {
		// 1. INTEGER TYPES - byte (8), short (16), int (32), long (64)
		System.out.println("Whole Number / Integer Types");
		byte byteValue = 127;
		System.out.println(byteValue);
		System.out.println("Byte Min Value : " + Byte.MIN_VALUE);
		System.out.println("Byte Max Value : " + Byte.MAX_VALUE);

		short shortValue = 32767;
		System.out.println(shortValue);
		System.out.println("Short Min Value : " + Short.MIN_VALUE);
		System.out.println("Short Max Value : " + Short.MAX_VALUE);

		int intValue = 1000;
		System.out.println(intValue);
		System.out.println("Integer Min Value : " + Integer.MIN_VALUE);
		System.out.println("Integer Max Value : " + Integer.MAX_VALUE);

		long longValue = 22222235654677L; // Note L at the end which denotes
											// long value
		System.out.println(longValue);
		System.out.println("Long Min Value : " + Long.MIN_VALUE);
		System.out.println("Long Max Value : " + Long.MAX_VALUE);

		// 2. FLOATING POINT TYPE - float (32), double (64)
		System.out.println("\nFloating Point Types");
		float pi = 1.345f; // Note f at the end
		System.out.println(pi);
		System.out.println("Float Min Value : " + Float.MIN_VALUE);
		System.out.println("Float Max Value : " + Float.MAX_VALUE);

		double newPi = 1.34566778d; // Note d at the end
		System.out.println(newPi);
		System.out.println("Double Min Value : " + Double.MIN_VALUE);
		System.out.println("Double Max Value : " + Double.MAX_VALUE);

		// 3. CHARACTER - char
		System.out.println("\nCharacter Type");
		char charValue = 'c';
		System.out.println(charValue);
		System.out.println("Character Min Value : " + Character.MIN_VALUE);
		System.out.println("Character Max Value : " + Character.MAX_VALUE);

		char accentedU = '\u00DA';
		System.out.println("Unicode Accented U : " + accentedU);

		// 4. BOOLEAN
		System.out.println("\nBoolean Type");
		boolean iLoveJava = true;
		System.out.println(iLoveJava);
	}
}