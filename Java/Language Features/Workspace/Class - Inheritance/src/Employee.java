public class Employee extends Person{
    public Employee(int id, String name) {
        this.SetId(id);
        this.SetName(name);
    }

    public String GetEmployeeInformation() {
        return this.GetId() + " " + this.GetName();
    }
}
