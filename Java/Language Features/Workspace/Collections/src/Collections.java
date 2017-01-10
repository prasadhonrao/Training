import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Queue;
import java.util.Set;

public class Collections {

	/*
	 * 1. List - Ordered and sequential, can have duplicates
	 * 2. Map - Key-Value pair, unique keys, same as dictionary
	 * 3. Set - No duplicates, must be able to compare
	 * 4. Queue - FIFO, accepts duplicate
	 * */
	
	public static void main(String[] args) {
		
		ListDemo();
		MapDemo();
		SetDemo();
		QueueDemo();
	}

	private static void QueueDemo() {
		System.out.println("Queue");
		Queue<Integer> numbers = new LinkedList<Integer>();
		for (int i = 0; i < 10 ; i++) {
			numbers.add(i);
		}
		
		numbers.offer(10); // offer throws exception if queue is full
		
		int peekFirstItem = numbers.peek();
		System.out.println(peekFirstItem);
		
		int pollFirstItem = numbers.poll();
		System.out.println(pollFirstItem);
		
		int pollSecondItem = numbers.poll();
		System.out.println(pollSecondItem);
		
		System.out.println(numbers.size());
	}

	private static void SetDemo() {
		System.out.println("Set");
		Set<Integer> numbers = new HashSet<Integer>();
		for (int i = 0; i < 10 ; i++) {
			numbers.add(i);
		}
		
		numbers.add(1); // will not add to the set
		numbers.add(10); 
		
		for (Integer n : numbers) {
			System.out.println(n);
		}
	}

	private static void MapDemo() {
		System.out.println("Map");
		Map<Integer, Integer> numbers = new HashMap<Integer, Integer>();
		
		for (int i = 0; i < 10 ; i++) {
			numbers.put(i, i * 100);
		}
		
		System.out.println(numbers.get(5));
	}

	private static void ListDemo() {
		System.out.println("List");
		List<Integer> numbers = new ArrayList<Integer>();
		for (int i = 0; i < 10 ; i++) {
			numbers.add(i);
		}
		
		for (Integer n : numbers) {
			System.out.println(n);
		}
	}

}
