package com.prasadhonrao.classproperties;

/**
 * Created by 130043 on 1/23/2016.
 */
public class Customer {
    private int id;
    private String name;

    public int GetId() { return id; }
    public void SetId(int id) { this.id = id;}

    public String GetName() { return name; }
    public void SetName(String name) { this.name = name;}

    public String GetCustomerInfo() {
        return this.GetId() + this.GetName();
    }
}
