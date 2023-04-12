using System;

namespace After_Builder_FluentAPI
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
        }
    }
}
