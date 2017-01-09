// Also check Static Block Initializer Code
public class Main {
	static String _serverName;
	
	static String GetServerName() {
		return "Main Server";
	}
	
	public static void main(String[] args) {
		System.out.println(Main.GetServerName());
		System.out.println(Customer.defaultCustomerName);
	}
}