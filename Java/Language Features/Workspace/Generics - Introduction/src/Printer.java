public class Printer<T> {
	private T cartridge;
	
	public Printer(T cartridge) {
		this.cartridge = cartridge;
	}
	
	public void print() {
		System.out.println(this.cartridge);
	}
}
