using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Training.CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region LINQ with XElement
			
			XElement employees = new XElement("Employees",
										new XElement("Employee", "Prasad"),
										new XElement("Employee", "Amit"),
										new XElement("Employee", "Colin"),
										new XElement("Employee", "Prasad")
									 );
			Console.WriteLine(employees.ToString());
			Console.WriteLine("Writing XML information to EmployeeInfo.XML");
			employees.Save("EmployeeInfo.XML");

			var NumberOfEmpWithPrasadAsName = employees.Descendants("Employee").Where(e => e.Value.Equals("Prasad")).Count();
			Console.WriteLine("Number of employees with Prasad as Name are {0}", NumberOfEmpWithPrasadAsName);

			#endregion

			#region LINQ with XDocument & XElement
			Console.WriteLine("Display Process information using LINQ");
			
			XDocument processDocument = new XDocument(
								new XElement("Processes",
								from p in Process.GetProcesses()
								orderby p.ProcessName
								select new XElement("Process",
									   new XAttribute("PID", p.Id),
									   new XAttribute("Name", p.ProcessName),
									   new XAttribute("Threads", p.Threads.Count))
							   ));
			Console.WriteLine("Writing XML information to ProcessInfo.XML");
			processDocument.Save("ProcessInfo.XML");

			// Query XML document to find out process ids for DEVENV process
			
			#region Expression
			var pidsExpression = processDocument.Descendants("Process")
												.Where(e => e.Attribute("Name").Value.Equals("devenv"))
												.Select(e => (int)e.Attribute("PID"));

			foreach (var item in pidsExpression)
			{
				Console.WriteLine(item);
			} 
			#endregion

			#region Query
			IEnumerable<int> pidsQuery = from e in processDocument.Descendants("Process")
										 where e.Attribute("Name").Value == "devenv"
										 select (int)e.Attribute("PID");

			foreach (var item in pidsQuery)
			{
				Console.WriteLine(item);
			} 
			#endregion
			
			Console.WriteLine();

			#endregion

			#region Read XML Data
			
            Console.WriteLine("Read XML document using LINQ ");

			XDocument doc = XDocument.Load("data.xml");
			var products = doc.Descendants("Product");
			var suppliers = doc.Descendants("Supplier");

			#region Query
			var query = from p in products
						join s in suppliers
						on (int)p.Attribute("SupplierID")
						equals (int)s.Attribute("SupplierID")
						select new
						{
							SupplierName = (string)s.Attribute("Name"),
							ProductName = (string)p.Attribute("Name")
						};

			foreach (var item in query)
			{
				Console.WriteLine("{0} : {1}", item.SupplierName, item.ProductName);
			}
			Console.WriteLine(); 
			#endregion

			#region Expression

			var expression = products.Join (suppliers, 
											p => p.Attribute("SupplierID").Value , 
											s => s.Attribute("SupplierID").Value, 
											(p, s) => new 
													{ 
														ProductName = p.Attribute("Name").Value , 
														SupplierName = s.Attribute("Name").Value 
													}, 
											null );
			
			foreach (var item in expression) 
			{
				Console.WriteLine("{0} : {1}", item.SupplierName, item.ProductName);
			}

			#endregion

			#endregion

			Console.ReadLine();
		}
	}
}
