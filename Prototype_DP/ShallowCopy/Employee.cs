using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    public class Employee : PrototypeEmployee
    {
        public override PrototypeEmployee ShallowClone()
        {
            return (Employee)this.MemberwiseClone();
        }

       
    }
}
