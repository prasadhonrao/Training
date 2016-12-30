public class Printer extends Machine {
	// @Override keyword is optional as all the methods in Java are virtual by default
	@Override
	public void turnOn() {
		System.out.println("Printer is on");
	}
}
