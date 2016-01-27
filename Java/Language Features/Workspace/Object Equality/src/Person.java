public class Person {
	private int id;

	public Person(int id) {
		this.id = id;
	}

	@Override
	public boolean equals(Object o) {
		if (o instanceof Person) {
			Person p = (Person) o;
			return id == p.id;
		} else {
			return false;
		}
	}
}