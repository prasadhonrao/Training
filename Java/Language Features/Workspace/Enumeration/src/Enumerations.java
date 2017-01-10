
public class Enumerations {

	public static void main(String[] args) {
	
		// Iterating over enum values
		for (Colors color : Colors.values()) {
			System.out.println(color);
		}

	}
	
	public enum Colors {
		RED,
		GREEN,
		BLUE;
		
//		@Override
//		public String toString() {
//			return "Enum : "; 
//		}
	}

}
