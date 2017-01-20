package northwind;

public class Customer implements Comparable {

	public int Id;

	public Customer(int id) {
		this.Id = id;
	}

	public int compareTo(Object o) {
		Customer c = (Customer) o;
		if (this.Id < c.Id) {
			return -1;
		} else {
			return 0;
		}
	}
}
