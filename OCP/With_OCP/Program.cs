using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_OCP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Invoice Amount: 10000");
			Invoice FInvoice = new FinalInvoice();
			double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
			Console.WriteLine($"Final Invoive : {FInvoiceAmount}");
			Invoice PInvoice = new ProposedInvoice();
			double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
			Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");
			Invoice RInvoice = new RecurringInvoice();
			double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
			Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");
			Console.ReadKey();
		}
	}
}
