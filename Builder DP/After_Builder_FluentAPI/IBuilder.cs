using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_FluentAPI
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
