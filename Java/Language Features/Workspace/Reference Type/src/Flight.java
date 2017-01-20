public class Flight {
	String code;
	int passengers;
	int seats;

	public Flight(String code, int passengers, int seats) {
		this.code = code;
		this.passengers = passengers;
		this.seats = seats;
	}

	public void Add1Passenger() {
		this.passengers++;
	}
}
