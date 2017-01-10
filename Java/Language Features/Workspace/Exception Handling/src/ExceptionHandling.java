import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class ExceptionHandling {

	public static void main(String[] args) {
		HandleDivideByZeroException();
		HandleFileException();
		CatchThrownException();
	}
	
	private static void CatchThrownException() {
		int i = 10;
		int j = 0; // accept this input from user in real example
		
		try {
			if (j == 0) { 
				throw new IllegalArgumentException("Can not divide by zero");
			}
			else {
				int result = i / (j);
				System.out.println(result);	
			}
		} 
		catch (IllegalArgumentException e) {
			System.out.println("Invalid Value : Message : " + e.getMessage());
		} 
	}

	public static void HandleDivideByZeroException() {
		int i = 10;
		int j = 2;
		
		try {
			int result = i / (j-2);
			System.out.println(result);
		} catch (ArithmeticException e) {
			System.out.println("Invalid Value : Message : " + e.getMessage());
		} catch (Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
		} finally {
			//System.out.println("exit...");
		}
	}

	public static void HandleFileException() {
		
		BufferedReader reader = null;
		int total = 0;
		String line = null;
		String filePath;
		
		try {
			filePath = new File("numbers.txt").getAbsolutePath();
			reader = new BufferedReader(new FileReader(filePath));
		
			while((line = reader.readLine()) != null) {
				total += Integer.valueOf(line);
			}

			System.out.println("Total is :" + total);
		} catch (NumberFormatException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		finally {
			try {
				if (reader != null){
					reader.close();
				}
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
}
