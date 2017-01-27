using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }


        public static List<Order> GetSampleData()
        {
            return new List<Order>
            {
                new Order { Id =1, CustomerName ="Prasad" , Amount = 99.99m, Status ="Delivered" },
                new Order { Id =2, CustomerName ="Anil" , Amount = 59.50m, Status ="Pending" },
                new Order { Id =3, CustomerName ="Rita" , Amount = 59.50m, Status ="Refunded" },
                new Order { Id =4, CustomerName ="Girish" , Amount = 59.50m, Status ="Delivered" },
                new Order { Id =5, CustomerName ="Deepa" , Amount = 59.50m, Status ="Refunded" },
            };
        }
    }
}
