using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    public class Employee : PrototypeEmployee
    {
     
        public override PrototypeEmployee DeepClone()
        { 
            Employee Emp = new Employee();
            Emp = (Employee)this.MemberwiseClone();
            // Changes in Refrence Types.
            EmpAddresss EmpAddr = new EmpAddresss();
            EmpAddr.City = protEmpAddresss.City;
            EmpAddr.Street = protEmpAddresss.Street;
            EmpAddr.BuildingNum = protEmpAddresss.BuildingNum;
            Emp.protEmpAddresss = EmpAddr;
            Emp.Id = this.Id;
            Emp.Name = this.Name;
            return Emp;
        }
    }
}
