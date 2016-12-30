public class Main {

	public static void main(String[] args) {
		Machine machine = new Machine();
		machine.turnOn();
		
		Machine machine2 = new Printer();
		machine2.turnOn();
		boolean isMachine2Printer = machine2 instanceof Machine; 
		System.out.println("Is machine 2 as instance of Printer? " + isMachine2Printer );
		 
		Printer printer = new Printer();
		printer.turnOn();
	}

}
