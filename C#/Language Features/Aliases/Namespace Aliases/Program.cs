using System;
using WebForms = System.Web.UI.WebControls;
using WinForms = System.Windows.Forms;

namespace Namespace.Aliases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(WinForms.Button));
            Console.WriteLine(typeof(WebForms.Button));
        }
    }
}
