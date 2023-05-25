using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
   public class EmployeeSalaryCalculator
    {
        public void GetEmpFinancialInfo( Employee Emp)
        {
            Console.WriteLine($"Employee Name : {Emp.FullName}" );
            Console.WriteLine($"Employee Salary : {Emp.Salary}");
        }
    }
}
