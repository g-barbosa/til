using FactoryExample.ConcreteCreator;
using FactoryExample.Creator;
using FactoryExample.Product;
using System;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SkateFactory skateFactory = null;
            Console.Write("Digite o tipo de skate para montar: ");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "street":
                    skateFactory = new StreetFactory(7.75, 139, 31);
                    break;
                case "vertical":
                    skateFactory = new VerticalFactory(8.5, 149, 40);
                    break;
                case "mini":
                    skateFactory = new MiniCruiserFactory(7, 129, 46);
                    break;
                default:
                    break;
            }

            Skate skate = skateFactory.SearchSkate();
            Console.WriteLine("Skate montado:\n");
            Console.WriteLine($"Tamanho do shape: {skate.ShapeSize}");
            Console.WriteLine($"Tamanho do truck: {skate.TruckSize}");
            Console.WriteLine($"Tamanho da roda: {skate.WheelSize}");
            Console.ReadKey();
        }
    }
}
