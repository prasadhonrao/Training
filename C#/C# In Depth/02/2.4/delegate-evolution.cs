using System;
					
public class Program
{
	public static void Main()
	{
		// C# 1.0 
		EventHandler handler;
		handler = new EventHandler(HandleDemoEvent);
		handler(null, EventArgs.Empty);
		
		// Implicit Conversion
		handler = HandleDemoEvent;
		handler(null, EventArgs.Empty);
		
		// Anonymous Methods
		handler = delegate(object sender, EventArgs e)
		{
			Console.WriteLine("Handled Anonymously");
		};
		handler(null, EventArgs.Empty);
		
		// Anonymous Method using shortcut
		handler = delegate
		{
			Console.WriteLine("Handled Anonymously again!");
		};
		handler(null, EventArgs.Empty);
		
		// lambda
		handler += (s,e) => 
		{
			Console.WriteLine("Handled by lambda!");
		};
		handler(null, EventArgs.Empty);
		
	}
	
	
	static void HandleDemoEvent(object sender, EventArgs e)
	{
		Console.WriteLine("Handled by HandleDemoEvent");
	}
	
}