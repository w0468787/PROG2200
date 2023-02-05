using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    { const int HoursInYear =2080;
        //negatiive tests thrown
        public decimal GetAnnualSalary(decimal hourlyWage) {
            if (hourlyWage <= 0)
                throw new InvalidOperationException();
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
        //negatiive tests thrown
        public decimal GetHourlyWage(int annualSalary) {
            if (annualSalary / HoursInYear <= 0)
                throw new InvalidOperationException("Hourly wage must be greater than 0");
            return annualSalary/HoursInYear;
        }
        //negatiive tests thrown and tax calculated
        public TaxData TaxWithheld(double weeklySalary, int numDependents) {
            TaxData td = new TaxData();
            if (weeklySalary <= 0||numDependents<0)
                throw new InvalidOperationException();
            td.ProvincialTaxWithheld = (weeklySalary * .06);
            td.FederalTaxWithheld = (weeklySalary * .25);
            td.DependentDeduction = (weeklySalary * .02) * (numDependents);
            td.TotalWithheld = td.ProvincialTaxWithheld + td.FederalTaxWithheld - td.DependentDeduction;
            td.TotalTakeHome = weeklySalary - td.TotalWithheld;
            return td;
        }
        
    }
}
