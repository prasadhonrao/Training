namespace Training.CSharp
{
    public class Product
    {
        private int price;
        private string name;

        public int Price { get { return price; } } // for external access
        public string Name { get { return name; } } // for external access

        public static implicit operator Product(int price)
        {
            Product p = new Product();
            p.price = price;
            return p;
        }

        public static explicit operator Product(string name)
        {
            Product p = new Product();
            p.name = name;
            return p;
        }
    }
}
