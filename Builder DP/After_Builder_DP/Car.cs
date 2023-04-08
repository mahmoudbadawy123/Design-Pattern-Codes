using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_DP
{
    internal class Car:IBuilder
    {
        private string BrandName;
        private Product Product =  new Product();
        public Car(string _BrandName)
        {
            this.BrandName = _BrandName;
        }
        public void startOperations()
        {
            this.Product.Add($"Model Name {this.BrandName}");
        }
        public void BuildBody()
        {
            this.Product.Add($"Build Body");
        }
        public void InsertWheels()
        {
            this.Product.Add($"Insert Wheels");
        }
        public void InsertHeadLights()
        {
            this.Product.Add($"Insert Head Lights");
        }
        public void EndtOperations()
        {
            this.Product.Add("End Of Opertaions");
        }
        public Product GetVehicle()
        {
            return this.Product;
        }
    }
}
