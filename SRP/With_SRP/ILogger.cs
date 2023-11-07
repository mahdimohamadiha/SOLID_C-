﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_SRP
{
	public interface ILogger
	{
		void Info(string info);
		void Debug(string info);
		void Error(string message, Exception ex);
	}
}
