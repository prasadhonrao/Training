
public class MessageProcessor extends Thread {
	@Override
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println("In MessageProcessor Thread  : " + i);
		}
		super.run();
	}
}
