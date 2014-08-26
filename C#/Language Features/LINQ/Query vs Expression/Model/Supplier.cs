using System.Collections.Generic;

namespace Training.CSharp
{
    public class Supplier
    {
        //public int Id { get; set; }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name { get; set; }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier { Id = 1, Name = "Venus"},
                new Supplier { Id = 2, Name = "Ajanta"},
                new Supplier { Id = 3, Name = "Compware"},
                new Supplier { Id = 4, Name = "XYZ Computing"},
                new Supplier { Id = 5, Name = "All In One Sales"}
            };
        }
    }
}
