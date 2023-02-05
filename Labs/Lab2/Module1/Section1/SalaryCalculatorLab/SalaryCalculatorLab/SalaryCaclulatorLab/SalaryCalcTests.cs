﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorLab
{
    /*		
        To get hourly, divide annual salary by 2080     
        $100,006.40 / 2080 = $48.08  hr

        To get annual, multiply hourly by 2080 
        $48.08 * 2080 = $100,006.40
    */

    [Test Class]
    public class SalaryCalcTests
    {
        [Test Method]
        public void AnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);
            //Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [Test Method]
        public void AnnualSalaryTestNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal annualSalary = sc.GetAnnualSalary(-50);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must be greater than zero.", ex.Message);
            }
        }

        [Test Method]
        public void HourlyWageTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            decimal hourlyWage = sc.GetHourlyWage(52000);
            //Assert
            Assert.AreEqual(25, hourlyWage);
        }

        [Test Method]
        public void AnnualHourlyWageNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal hourlyWage = sc.GetHourlyWage(0);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly salary must be greater than zero.", ex.Message);
            }
        }
        // ADD THE FOLLOWING FOUR TESTS FOR LAB 2 MODULE 1 PART 2
        /*
                [TestMethod]
                public void TaxWithholdingTest()
                {
                    //Arrange
                    SalaryCalculator sc = new SalaryCalculator();
                    //Act
                    TaxData taxData = sc.TaxWithheld(1000, 2);
                    //Assert
                    Assert.AreEqual(60.0, taxData.ProvincialTaxWithheld);
                    Assert.AreEqual(250.0, taxData.FederalTaxWithheld);
                    Assert.AreEqual(40.0, taxData.DependentDeduction);
                    Assert.AreEqual(270.0, taxData.TotalWithheld);
                    Assert.AreEqual(730.0, taxData.TotalTakeHome);
                }

                [TestMethod]
                public void TaxWithholdingTestNoChildren()
                {
                    //Arrange
                    SalaryCalculator sc = new SalaryCalculator();
                    //Act
                    TaxData taxData = sc.TaxWithheld(2000, 0);
                    //Assert
                    Assert.AreEqual(120.0, taxData.ProvincialTaxWithheld);
                    Assert.AreEqual(500.0, taxData.FederalTaxWithheld);
                    Assert.AreEqual(0, taxData.DependentDeduction);
                    Assert.AreEqual(620.0, taxData.TotalWithheld);
                    Assert.AreEqual(1380.0, taxData.TotalTakeHome);
                }

                [TestMethod]
                public void TaxWithholdingTestNegativeChildren()
                {
                    //Arrange
                    SalaryCalculator sc = new SalaryCalculator();
                    //Act
                    try
                    { // A negative test. Should throw an exception
                        sc.TaxWithheld(1000, -1);
                        //Assert
                        Assert.Fail("This code should not be run. Exception expected.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Assert.AreEqual("Number dependents cannot be negative.", ex.Message);
                    }
                }
                [TestMethod]
                public void TaxWithholdingZeroSalary()
                {
                    //Arrange
                    SalaryCalculator sc = new SalaryCalculator();
                    //Act
                    try
                    { // A negative test. Should throw an exception
                        sc.TaxWithheld(0, 0);
                        //Assert
                        Assert.Fail("This code should not be run. Exception expected.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Assert.AreEqual("Weekly salary must be greater than zero.", ex.Message);
                    }
                }
                */
    }
}
