import java.lang.reflect.Method;

public class Reflection {

	public static void main(String[] args) {
		Customer c = new Customer();
		Method[] methods = c.getClass().getMethods();

		for (Method method : methods) {
			System.out.println(method.getName());
		}
	}

}
