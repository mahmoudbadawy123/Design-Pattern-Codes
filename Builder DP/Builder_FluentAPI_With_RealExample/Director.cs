using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_FluentAPI_With_RealExample
{
    internal class Director
    {
        IBuilder Builder;
        //steps to create Complex Object
        public void Construct_Prodcut(IBuilder _Builder)
        {
            this.Builder = _Builder;
            Builder.startOperations().BuildBody().InsertHeadLights()
               .InsertWheels().EndtOperations();
        }
    }
}
