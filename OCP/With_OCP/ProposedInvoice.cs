﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_OCP
{
	public class ProposedInvoice : Invoice
	{
		public override double GetInvoiceDiscount(double amount)
		{
			return base.GetInvoiceDiscount(amount) - 40;
		}
	}
}
