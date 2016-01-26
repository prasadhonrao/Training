import java.lang.String;

public class Main {

    public static void main(String[] args) {
        Customer newCustomer = new Customer("Prasad", 35);
        System.out.println(newCustomer.name + " " + newCustomer.age);
    }
}