using System;

namespace DeepCopy
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

            PrototypeEmployee DeepCopy_Emp = Original_Emp.DeepClone();

            Console.WriteLine($" Original => " + Original_Emp.ToString());
            Console.WriteLine($" DeepCopy => " + DeepCopy_Emp.ToString());

            Console.WriteLine("");
            Console.WriteLine(" ####################################### ");
            Console.WriteLine(" Change Orginal Will not Affect Deep Object Ever .");
            Console.WriteLine(" ####################################### ");
            Console.WriteLine("");

            Original_Emp.Id = 3;
            Original_Emp.Name = "Deep M Badawy";
            Original_Emp.protEmpAddresss.City = "Deep New Cairo";
            Original_Emp.protEmpAddresss.Street = "Deep Badawy Street";
            Original_Emp.protEmpAddresss.BuildingNum = 50;
            Console.WriteLine($" Original after Change => " + Original_Emp.ToString());
            Console.WriteLine($" Deep obj after Change => " + DeepCopy_Emp.ToString());
            Console.WriteLine(" ####################################### ");
        }
    }
}
