using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button b = new Button();
            b.Text = "Click Me";
            b.Click += new EventHandler(LogPlainEvent);
            b.KeyPress += new KeyPressEventHandler(LogKeyEvent);
            b.MouseClick += new MouseEventHandler(LogMouseEvent);

        }

        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }
        static void LogKeyEvent(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("LogKey");
        }

        static void LogMouseEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LogMouse");
        }


    }
}
