using System;

class Program
{
    static void Main(string[] args)
    {
        Nullable<int> x = new Nullable<int>(5);
        Console.WriteLine("Instance with value");
        Display(x);

        x = new Nullable<int>();
        Console.WriteLine("Instance without value");
        Display(x);
        Console.ReadLine();

    }

    static void Display(Nullable<int> x)
    {
        Console.WriteLine("HasValue : {0}", x.HasValue);
        if (x.HasValue)
        {
            Console.WriteLine("Value : {0}", x.Value);
            Console.WriteLine("Explicit Conversion: {0}", (int)x);
        }
        Console.WriteLine("GetValueOrDefault() : {0}", x.GetValueOrDefault());
        Console.WriteLine("GetValueOrDefault(10) : {0}", x.GetValueOrDefault(10));
        Console.WriteLine("ToString() : \"{0}\"", x.ToString());
        Console.WriteLine("GetHashCode() : {0}", x.GetHashCode());
        Console.WriteLine();
    }
}

