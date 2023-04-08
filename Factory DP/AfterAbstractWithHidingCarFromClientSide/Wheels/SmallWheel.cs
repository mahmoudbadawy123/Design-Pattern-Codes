using AfterAbstractWithHidingCarFromClientSide.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterAbstractWithHidingCarFromClientSide.Wheels
{
    class SmallWheel : Wheel
    {
        public SmallWheel()
        {
            WheelSizeName = "Small";
        }
    }
}
