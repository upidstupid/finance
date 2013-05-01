using System;

namespace FinanceCalc
{
	public static class Calc
	{
		public static double PVtoFV(double pv, double i, int n)
		{
			return (pv * Math.Pow(1+i,n));
		}

		public static double FVtoPV(double fv, double i, int n)
		{
			return (fv / Math.Pow(1+i,n));
		}

		public static double FVANtoCF(double fvan, double i, int n)
		{
			return (fvan / ((Math.Pow(1+i,n) - 1) / 1));
		}
	
		public static double CFtoFVAN(double cf, double i, int n)
		{
			return (cf * ((Math.Pow(1+i,n) - 1) / 1));
		}

		public static double CFtoPVAN(double cf, double i, int n)
		{
			return (cf * ((1 - (1 / Math.Pow(1+i,n)))/ 1));
		}
	}
}

