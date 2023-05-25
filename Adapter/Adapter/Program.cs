using Adapter.Adptors;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSalaryCalculator_Adaptor Adaptor = new EmployeeSalaryCalculator_Adaptor();

            MerchantOperatorEmp Emp_1 = new MerchantOperatorEmp();
            Emp_1.FristName = "Mahmoud";
            Emp_1.SecondName = "Ahmed";
            Emp_1.LastName = "Badawy";
            Emp_1.BasicSalary = 9000;
            Emp_1.IsManager = true;
            Adaptor.GetEmpFinancialInfo(Emp_1);

            MerchantOperatorEmp Emp_2 = new MerchantOperatorEmp();
            Emp_2.FristName = "khalil";
            Emp_2.SecondName = "Adel";
            Emp_2.LastName = "Khalil";
            Emp_2.BasicSalary = 9000;
            Adaptor.GetEmpFinancialInfo(Emp_2);

        }
    }
}
