import java.util.Scanner;

public class StaticBlockInitializers {

	public static int B = 0;
	public static int H = 0;
	public static boolean flag = false;

	static {
		Scanner scan = new Scanner(System.in);
		B = scan.nextInt();
		H = scan.nextInt();
		scan.close();

		if (B > 0 && H > 0) {
			flag = true;
		} else {
			System.out.println("java.lang.Exception: Breadth and height must be positive");
		}
	}

	public static void main(String[] args) {

		if (flag) {
			int area = B * H;
			System.out.println(area);
		}

	}

}
