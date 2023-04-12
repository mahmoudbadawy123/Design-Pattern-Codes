using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_FluentAPI
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
            this.Product.Add($"Model Name {this.BrandName}");
            return this;
        }
        public IBuilder BuildBody()
        {
            this.Product.Add($"Build Body");
            return this;
        }
        public IBuilder InsertWheels()
        {
            this.Product.Add($"Insert Wheels");
            return this;
        }
        public IBuilder InsertHeadLights()
        {
            this.Product.Add($"Insert Head Lights");
            return this;
        }
        public IBuilder EndtOperations()
        {
            this.Product.Add("End Of Opertaions");
            return this;
        }

        public Product GetVehicle()
        {
            return this.Product;
        }
    }
}
