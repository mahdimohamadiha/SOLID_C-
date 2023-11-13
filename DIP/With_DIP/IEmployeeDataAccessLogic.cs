using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DIP
{
	public interface IEmployeeDataAccessLogic
	{
		Employee GetEmployeeDetails(int id);
	}
}
