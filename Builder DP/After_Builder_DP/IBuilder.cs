using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_DP
{
    internal interface IBuilder
    {
         void startOperations();
         void BuildBody();
         void InsertWheels();
         void InsertHeadLights();
         void EndtOperations();
         Product GetVehicle();
    }
}
