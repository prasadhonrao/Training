public class Main {
    public static void main(String[] args) {
	    
    	Employee e1 = new Employee(100, "Prasad");
    	System.out.println(e1.GetEmployeeInformation());
        System.out.println(e1.GetInformation()); // Base class function is available as well
        
        Person p1 = new Person();
        p1.SetId(1);
        p1.SetName("John");
        System.out.println(p1.GetInformation()); // Child class function GetEmployeeInformation is not available
         
    }
}