using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_FluentAPI_With_RealExample
{
    internal class Car:IBuilder
    {
        private string BrandName;
        private Product Product =  new Product();
        public Car(string _BrandName)
        {
            this.BrandName = _BrandName;
        }
        public IBuilder startOperations()
        {
            this.Product.Model= $"Model Name {this.BrandName}";
            return this;
        }
        public IBuilder BuildBody()
        {
            this.Product.BodyPart = $"Build Body";
            return this;
        }
        public IBuilder InsertWheels()
        {
            this.Product.WheelsPart = $"Insert Wheels";
            return this;
        }
        public IBuilder InsertHeadLights()
        {
            this.Product.HeadLightPart= $"Insert Head Lights";
            return this;
        }
        public IBuilder EndtOperations()
        {
            this.Product.ProductSerial = ($"End Of Opertaions With product Serial  = {Guid.NewGuid()}");
            return this;
        }

        public Product GetVehicle()
        {
            return this.Product;
        }
    }
}
