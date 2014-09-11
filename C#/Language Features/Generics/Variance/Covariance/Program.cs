using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C# 2.0 Code valid at compile time
            
            Animal[] animals = new Cat[5];
            animals[0] = new Dog(); 

            #endregion

            #region Generic covariance
    		
            // List<Animal> newAnimals = new List<Cat>;  // THIS IS NOT ALLOWED
            // newAnimals.Add(new Dog()); 
	        
            #endregion
            
        }
    }

    public class Animal { }
    public class Cat : Animal { }
    public class Dog : Animal { }
}
