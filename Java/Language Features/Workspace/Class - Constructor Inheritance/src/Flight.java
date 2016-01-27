public class Flight {
	private int flightNumber;

	public Flight() {
		System.out.println("In Flight Base Constructor");
	}

	public Flight(int flightNumber) {
		System.out.print("In Flight Overloaded Constructor ");
		System.out.println("Flight Number " + flightNumber);
		this.setFlightNumber(flightNumber);
	}

	public int getFlightNumber() {
		return flightNumber;
	}

	public void setFlightNumber(int flightNumber) {
		this.flightNumber = flightNumber;
	}
}