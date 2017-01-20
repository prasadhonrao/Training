public class Annotations {
	public static void main(String[] args) {
		deprecatedMethod();
	}

	@Deprecated
	static void deprecatedMethod() {
		System.out.println("This is deprecated method");
	}
}
