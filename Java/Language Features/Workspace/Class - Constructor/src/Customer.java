public class Customer {
	private int id;
	private String name;

	public Customer(int id) {
		this.setId(id);
	}

	public Customer(String name) {
		this.setName(name);
	}

	public Customer(int id, String name) {
		this.setId(id);
		this.setName(name);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}
}
