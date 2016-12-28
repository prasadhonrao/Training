import java.util.Calendar;

public class Main {

	public static void main(String[] args) {
		
		//1. if...else
		if (args.length > 0) {
			System.out.println("You have provided command line argument : " + args[0]);
		} else {
			System.out.println("There are no command line argument");
		}
		
		// relational operator works on all integer and character types
		if ('c' > 'a') {
			System.out.println("Character c is greater than character a");
		} 
		
		// 2. Conditional assignment using ?
		int students = 30;
		int rooms = 5;
		int studentsPerRoom = rooms == 0 ? 0 : students / rooms;
		System.out.println("Students per room " + studentsPerRoom);
		
		// 3. switch...case
		Calendar c = Calendar.getInstance();
		int dayOfWeek = c.get(Calendar.DAY_OF_WEEK) - 1;
				
		switch(dayOfWeek) {
			case 0:
				System.out.println("OMG, its Sunday!!!");
				break;
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
				System.out.println("Saturday Night!");
				break;
			default:
				System.out.println("Invalid input");
				break;
		}
	}
}