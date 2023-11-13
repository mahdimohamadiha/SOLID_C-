using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_DIP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
			Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
			Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
			Console.ReadKey();
		}
	}
}
