using After_abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_abstract_Factory.Wheels
{
    class LargeWheel : Wheel
    {
        public LargeWheel()
        {
            WheelSizeName = "Large";
        }
    }
}
