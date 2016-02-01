public class Main {

	public static void main(String[] args) {
		Machine machine = new Machine();
		machine.turnOn();
		
		Machine machine2 = new Printer();
		machine2.turnOn();
		//System.out.println(machine2 instanceof Machine );
		
		Printer printer = new Printer();
		printer.turnOn();
	}

}
