public class Person {
    private int id;
    private String name;

    public int GetId() {
        return this.id;
    }
    public void SetId(int id) {
         this.id = id;
    }

    public String GetName() {
        return this.name;
    }
    public void SetName(String name) {
        this.name = name;
    }
    
    public String GetInformation() {
        return this.GetId() + " " + this.GetName();
    }
}
