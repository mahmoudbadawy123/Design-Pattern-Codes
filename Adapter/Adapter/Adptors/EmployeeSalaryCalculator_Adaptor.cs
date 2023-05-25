using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adptors
{
  public  class EmployeeSalaryCalculator_Adaptor : EmployeeSalaryCalculator
    {

        private Employee _employee;
        public void GetEmpFinancialInfo(MerchantOperatorEmp MerchantOperator)
        {
            _employee = new Employee();
            _employee.FullName = $"{MerchantOperator.FristName} {MerchantOperator.SecondName} {MerchantOperator.LastName}";
            if(MerchantOperator.IsManager == true)
            {
                _employee.Salary = MerchantOperator.BasicSalary * 1.5;
            }
            else
            {
                _employee.Salary = MerchantOperator.BasicSalary ;
            }

            base.GetEmpFinancialInfo(_employee);
        }
    }
}
