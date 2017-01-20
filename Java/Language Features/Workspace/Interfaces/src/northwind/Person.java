package northwind;

public class Person implements Comparable<Person> {
	public int Id;

	public Person(int id) {
		this.Id = id;
	}

	public int compareTo(Person o) {
		Person p = o;
		if (this.Id < p.Id) {
			return -1;
		} else {
			return 0;
		}
	}
}
