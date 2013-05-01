using System;

namespace FinanceCalc
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double pv = 62.5;
			double i = .0625;
			int n = 10;
			double fv = Calc.CFtoPVAN(pv,i,n);

			Console.WriteLine ("The future value annuity with cashflow of {0:C} dollars, at an interest rate of {1:P} over {2} years, is {3:C} dollars.",pv,i,n,fv);
		}

	}
		/*
		public static double Value([double pv = 0],
		                           [double fv = 0],
		                           [double i = 0],
		                           [int n = 0],)
		{
	
		}
		*/
}



