using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_ISP
{
	public interface IPrinterTasks
	{
		void Print(string PrintContent);
		void Scan(string ScanContent);
	}
}
