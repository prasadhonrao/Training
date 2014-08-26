using System;
using System.Diagnostics;

namespace ExcelAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Type excelApp = Type.GetTypeFromProgID("Excel.Application");
            dynamic excel = Activator.CreateInstance(excelApp);
            excel.Visible = true;

            excel.Workbooks.Add();
            dynamic sheet = excel.ActiveSheet;

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                sheet.Cells[i + 1, "A"] = processes[i].ProcessName;
                sheet.Cells[i + 1, "B"] = processes[i].Threads.Count;
            }

            Console.ReadLine();
        }
    }
}
