﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_DIP
{
	public class DataAccessFactory
	{
		public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
		{
			return new EmployeeDataAccessLogic();
		}
	}
}
