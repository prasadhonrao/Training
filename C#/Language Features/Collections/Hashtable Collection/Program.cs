using System;
using System.Collections;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var favPlayers = new Hashtable();
            
            favPlayers.Add("1", "Sachin Tendulkar");
            favPlayers.Add("2", "Roger Federer");
            favPlayers.Add("3", "Usain Bolt");
            favPlayers.Add("4", "Mike Tyson");
            favPlayers.Add("5", "Bill Goldberg");

            // Note DictionaryEntry Key and Value properties are of type Object, so for each performs implicit type conversion 
            Console.WriteLine("My favorite sports players are");
            foreach (DictionaryEntry player in favPlayers)
            {
                Console.WriteLine("{0} : {1}", player.Key, player.Value);
            }

            Console.ReadLine();
        }
    }
}
