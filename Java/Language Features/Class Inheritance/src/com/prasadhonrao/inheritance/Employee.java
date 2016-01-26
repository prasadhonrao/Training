package com.prasadhonrao.inheritance;
public class Employee extends Person{
    private int employeeId;

    public Employee(int id, String name) {
        this.SetId(id);
        this.SetName(name);
    }

    public String GetEmployeeInformation() {
        String value = this.GetId() + " " + this.GetName();
        return  value;
    }
}
