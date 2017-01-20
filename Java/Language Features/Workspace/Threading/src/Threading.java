public class Threading {

	public static void main(String[] args) {
		// create a thread and start running in parallel of main thread
		MessageProcessor mp = new MessageProcessor();
		mp.start();

		for (int i = 0; i < 10; i++) {
			System.out.println("Main thread : " + i);
		}
	}

}
