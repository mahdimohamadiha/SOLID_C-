﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_ISP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Using HPLaserJetPrinter we can access all Printer Services
			HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
			hPLaserJetPrinter.Print("Printing");
			hPLaserJetPrinter.Scan("Scanning");
			hPLaserJetPrinter.Fax("Faxing");
			hPLaserJetPrinter.PrintDuplex("PrintDuplex");
			//Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
			LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
			liquidInkjetPrinter.Print("Printing");
			liquidInkjetPrinter.Scan("Scanning");
			Console.ReadKey();
		}
	}
}
