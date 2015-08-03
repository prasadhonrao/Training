using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Initializers
{
    class Program
    {

        static void Main(string[] args)
        {
            IntializeUsingOldestSyntax();
            IntializeUsingOlderSyntax();
            InitializeUsingNewSyntax();
        }

        private static void InitializeUsingNewSyntax()
        {
            var defaultUsers = new Dictionary<string, string>
            {
                ["admin"] = "Admin",  // Compiler interna
                ["guest"] = "Guest"
            };
        }

        private static void IntializeUsingOlderSyntax()
        {
            Dictionary<string, string> defaultUsers = new Dictionary<string, string>()
            {
                {"admin", "Admin" }, // Compiler internally calls the Add method
                {"guest", "Guest" }
            };
        }

        private static void IntializeUsingOldestSyntax()
        {
            Dictionary<string, string> defaultUsers = new Dictionary<string, string>();
            defaultUsers.Add("admin", "Admin");
            defaultUsers.Add("guest", "Guest");
        }
    }
}
