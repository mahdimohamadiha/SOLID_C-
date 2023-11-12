using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_ISP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
			hPLaserJetPrinter.Print("Printing");
			hPLaserJetPrinter.Scan("Scanning");
			hPLaserJetPrinter.Fax("Faxing");
			hPLaserJetPrinter.PrintDuplex("PrintDuplex");

			LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
			liquidInkjetPrinter.Print("Printing");
			liquidInkjetPrinter.Scan("Scanning");
			liquidInkjetPrinter.Fax("Faxing");
			liquidInkjetPrinter.PrintDuplex("PrintDuplex");
			Console.ReadKey();
		}
	}
}
