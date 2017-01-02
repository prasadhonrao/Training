
public class Main {

	public static void main(String[] args) {
		
		Printer<ColorCartridge> color = new Printer<ColorCartridge>(new ColorCartridge());
		color.print();

		Printer<BWCartridge> bw = new Printer<BWCartridge>(new BWCartridge());
		bw.print();
		
		// Generic Method - Color printer is using BW cartridge
		Printer<ColorCartridge> color2 = new Printer<ColorCartridge>(new ColorCartridge());
		color2.printUsingCartridge(new BWCartridge());
		
		// Warning !! - Any type can be passed as generic type, so use generic constraints to avoid this
		Printer<ColorCartridge> color3 = new Printer<ColorCartridge>(new ColorCartridge());
		color3.printUsingCartridge(3);
	}

}
