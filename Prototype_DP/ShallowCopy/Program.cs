using System;

namespace ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeEmployee Original_Emp = new Employee();
            Original_Emp.Id = 1;
            Original_Emp.Name = "Mahmoud Badawy";

            Original_Emp.protEmpAddresss = new EmpAddresss
            {
                City = "Cairo",
                Street = "Badawy St",
                BuildingNum = 20
            };

            PrototypeEmployee ShallowCopy_Emp = Original_Emp.ShallowClone();
            Console.WriteLine($" Original => " + Original_Emp.ToString());
            Console.WriteLine($" Shallow => " + ShallowCopy_Emp.ToString());

            Console.WriteLine("");
            Console.WriteLine(" ####################################### ");
            Console.WriteLine(" Change Original Object and you will find that shallow clone make" +
                " Refrence types values changed in Shallow Object as orginal except string type");
            Console.WriteLine(" ####################################### ");
            Console.WriteLine("");

            Original_Emp.Id = 2;
            Original_Emp.Name = "Shallow M Badawy";
            Original_Emp.protEmpAddresss.City = "Shallow New Cairo";
            Original_Emp.protEmpAddresss.Street = "Shallow Badawy Street";
            Original_Emp.protEmpAddresss.BuildingNum = 25;
            Console.WriteLine($" Original after Change => " + Original_Emp.ToString());
            Console.WriteLine($" Shallow  after Change  => " + ShallowCopy_Emp.ToString());
            Console.WriteLine(" ####################################### ");
        }
    }
}
