using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            string[] colors = { "Red", "Green", "Blue" };
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }

            string[] teams = new string[3] { "India", "Australia", "England" };

            foreach (var item in teams)
            {
                Console.WriteLine(item);
            }

            object[] objects = new object[] { 1, "One", "1+1" };

            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            Array odds = new[] { 1, 3, 5, 7, 9 };
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }


            #region Static Method of Array Class
            // 1. Sort

            var rainbowColors = new string[7];
            rainbowColors[0] = "Red";
            rainbowColors[1] = "Orange";
            rainbowColors[2] = "Yellow";
            rainbowColors[3] = "Green";
            rainbowColors[4] = "Blue";
            rainbowColors[5] = "Indigo";
            rainbowColors[6] = "Violet";

            Array.Sort(rainbowColors);
            foreach (var color in rainbowColors)
            {
                Console.WriteLine(color);
            }

            // 2. IndexOf
            int invalidIndex = Array.IndexOf(rainbowColors, "Black");
            Console.WriteLine(invalidIndex == -1);

            // 3. BinarySearch
            int blueColorExists = Array.BinarySearch(rainbowColors, "Blue");
            Console.WriteLine("Rainbow contains Blue color? {0}", blueColorExists >= 0 ? "Yes" : "No");

            Console.WriteLine();

            // 4. ForEach
            Console.WriteLine("Iterating user Array.ForEach");
            Array.ForEach(rainbowColors, r =>
            {
                Console.WriteLine(r.ToString() + r.Length);
            });
            #endregion

            // Array clone

            var weekdays = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            string[] clonedWeekdays = (string[])weekdays.Clone();

            var original = weekdays[0];
            var cloned = clonedWeekdays[0];

            var sameReference = Object.ReferenceEquals(original, cloned);

            Console.WriteLine("Original and Cloned array element points to same reference? {0}", sameReference ? "Yes" : "No");

            // Multi dimensional array

            var board = new char[2, 2];
            board[0, 0] = 'A';
            board[0, 1] = 'B';
            board[1, 0] = 'C';
            board[1, 1] = 'D';
            Console.WriteLine("Multi dimensional array length" + board.Length);

            Console.ReadLine();
        }
    }
}
