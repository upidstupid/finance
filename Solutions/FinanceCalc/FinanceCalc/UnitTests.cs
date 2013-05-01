using System;
//using NUnit.Framework;
namespace FinanceCalc
{

	//[TestFixture]
	public class UnitTests
	{
		//[Test]
		public void TestOne()
		{
			double pv = 1000;
			double i = .1;
			int n = 10;
			double fv = Calc.PVtoFV(pv,i,n);
			//Assert.AreEqual(2593.74, fv, .01);
		}
	}
}

