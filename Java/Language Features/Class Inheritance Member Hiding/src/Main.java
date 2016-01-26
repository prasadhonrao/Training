public class Main {

    public static void main(String[] args) {
	    Flight f1 = new Flight();
        System.out.println("Flight Capacity : " + f1.capacity);

        CargoFlight cf1 = new CargoFlight();
        System.out.println("Cargo Flight Capacity : " + cf1.capacity);

        Flight f2 = new CargoFlight();
        System.out.println("Flight Capacity : " + f2.capacity);
    }
}