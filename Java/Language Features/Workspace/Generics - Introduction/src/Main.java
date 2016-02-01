
public class Main {

	public static void main(String[] args) {
		
		Printer<ColorCartridge> color = new Printer<ColorCartridge>(new ColorCartridge());
		color.print();

		Printer<BWCartridge> bw = new Printer<BWCartridge>(new BWCartridge());
		bw.print();

	}

}
