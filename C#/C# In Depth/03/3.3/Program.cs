using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<string> list = MakeList<String>("First", "Second");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }

    public static List<T> MakeList<T>(T first, T second)
    {
        List<T> list = new List<T>();
        list.Add(first);
        list.Add(second);
        return list;
    }

}