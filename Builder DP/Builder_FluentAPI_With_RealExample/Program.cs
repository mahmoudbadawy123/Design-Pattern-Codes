using System;

namespace Builder_FluentAPI_With_RealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder CarBuilder = new Car("BMW");
            director.Construct_Prodcut(CarBuilder);
            Product product = CarBuilder.GetVehicle();
            Console.WriteLine(product.Show());

            // can Build Some Parts Only 
            IBuilder SomePartsCarBuilder = new Car("BMW Some Parts");
            SomePartsCarBuilder.startOperations().BuildBody().EndtOperations();
            product = SomePartsCarBuilder.GetVehicle();
            Console.WriteLine(product.Show());
        }
    }
}
