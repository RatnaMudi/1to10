using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string name;
        public double salary=0;
        public double houseRent;
        public double medical;

        public double Get_Salary()
        {
            double totalSalary = salary + ((houseRent * salary)/100) + ((medical*salary)/100) ;
            return totalSalary;
        }
    }
}
