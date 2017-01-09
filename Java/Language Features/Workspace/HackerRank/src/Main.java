import java.util.*;

public class Main {

	public static void main(String []argh){
        Scanner scanner = new Scanner(System.in);
        
        for(int i = 1; scanner.hasNext()== true; i++){
            System.out.println(i + " " + scanner.nextLine());
        }
     
        scanner.close();
    }

}
