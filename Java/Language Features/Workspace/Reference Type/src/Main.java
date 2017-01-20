public class Main {
	public static void main(String[] args) {
		Flight flight1 = new Flight("E1234", 100, 150);
		Flight flight2 = new Flight("KY7493", 20, 100);

		flight2.Add1Passenger();
		System.out.println("Number of passengers in flight 1 = " + flight1.passengers);
		System.out.println("Number of passengers in flight 2 = " + flight2.passengers);

		flight2 = flight1;
		System.out.println("Number of passengers in flight 1 = " + flight1.passengers);
		System.out.println("Number of passengers in flight 2 = " + flight2.passengers);

		flight2.Add1Passenger();
		System.out.println("Number of passengers in flight 1 = " + flight1.passengers);
		System.out.println("Number of passengers in flight 2 = " + flight2.passengers);
	}
}