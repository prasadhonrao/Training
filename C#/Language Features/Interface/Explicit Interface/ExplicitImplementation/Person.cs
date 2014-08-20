using System;

namespace ExplicitImplementation
{
    public class Person : ISaveable, IPersistable
    {
        #region Person Methods
        public void Save()
        {
            Console.WriteLine("In Concrete Save");
        }

        public string Load()
        {
            return "Fake data";
        } 
        #endregion

        #region ISaveable Method
        void ISaveable.Save()
        {
            Console.WriteLine("In ISaveable Save");
        } 
        #endregion

        #region IPersistable Method
        string IPersistable.Save()
        {
            return "In IPersistable Save";
        }

        string IPersistable.Load()
        {
            return "In IPersistable Load";
        }
        #endregion
    }
}
