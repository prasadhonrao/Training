
public class Main {

	public static void main(String[] args) {
		
		// if...else
		
		if (args.length > 0) {
			System.out.println("You have provided command line argument : " + args[0]);
		} else {
			System.out.println("There are no command line argument");
		}
		
		// switch...case
		
		int weekdayNumber = 7;
		
		switch(weekdayNumber) {
			case 1:
				System.out.println("Hello, Monday!");
				break;
			case 2:
				System.out.println("Working Tuesday!");
				break;
			case 3:
				System.out.println("Wednesday Meetings!");
				break;
			case 4:
				System.out.println("Thursday Thunder");
				break;
			case 5:
				System.out.println("Friday Weekend Near");
				break;
			case 6:
			case 7:
				System.out.println("Happy Weekend!");
				break;
			default:
				System.out.println("Invalid input");
				break;
		}
		

	}

}
