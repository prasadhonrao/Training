
public class Printer <T> 
{
	T cartridge;
	Printer(T cartridge)
	{
		this.cartridge = cartridge;
	}
	
	public void print()
	{
		System.out.println(this.cartridge);
	}
	
	public <U> void printUsingCartridge(U cartridge)
	{
		System.out.println("Printing using cartridge " + cartridge.toString());
	}
}
