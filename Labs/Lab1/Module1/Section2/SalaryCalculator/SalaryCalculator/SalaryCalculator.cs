
using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculator
{
    [TestClass]
    public class SalaryCalculator
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            SalaryCalc sc = new SalaryCalc();
            decimal annualSalary = sc.GetAnnualSalary(50);
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
