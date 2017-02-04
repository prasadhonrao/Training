using System;

class Program
{
    static void Main(string[] args)
    {
        Nullable<int> nullable = 5;
        Object boxed = nullable;
        Console.WriteLine(boxed.GetType());
        
        int normal = (int)boxed;
        Console.WriteLine(normal);
        
        nullable = (Nullable<int>)boxed;
        Console.WriteLine(nullable);
        
        nullable = new Nullable<int>();
        boxed = nullable;
        
        Console.WriteLine(boxed == null);
        
        nullable = (Nullable<int>)boxed;
        Console.WriteLine(nullable.HasValue);
    }
}