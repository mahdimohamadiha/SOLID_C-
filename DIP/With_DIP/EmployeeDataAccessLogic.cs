using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DIP
{
	public class EmployeeDataAccessLogic : IEmployeeDataAccessLogic
	{
		public Employee GetEmployeeDetails(int id)
		{
			Employee emp = new Employee()
			{
				ID = id,
				Name = "Pranaya",
				Department = "IT",
				Salary = 10000
			};
			return emp;
		}
	}
}
