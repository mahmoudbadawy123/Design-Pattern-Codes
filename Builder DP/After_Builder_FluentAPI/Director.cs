using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_FluentAPI
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
