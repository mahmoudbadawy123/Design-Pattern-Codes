using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_FluentAPI_With_RealExample
{
    internal interface IBuilder
    {
        IBuilder startOperations();
        IBuilder BuildBody();
        IBuilder InsertWheels();
        IBuilder InsertHeadLights();
        IBuilder EndtOperations();
        Product GetVehicle();
    }
}
