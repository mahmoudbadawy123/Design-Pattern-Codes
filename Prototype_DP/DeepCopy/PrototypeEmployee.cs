using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    public abstract class PrototypeEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmpAddresss protEmpAddresss { get; set; }

        public abstract PrototypeEmployee DeepClone();


        public override string ToString()
        {
            return $"Emp Id : {this.Id}  - Name : {this.Name} - City : {protEmpAddresss.City} - Street : {protEmpAddresss.Street} - BuildingNum : {protEmpAddresss.BuildingNum} " ;
        }
    }
}
