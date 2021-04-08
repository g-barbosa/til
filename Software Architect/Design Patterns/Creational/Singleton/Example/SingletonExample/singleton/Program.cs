using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var classeComum1 = new ClasseParaInstanciarEComparar();
            var classeComum2 = new ClasseParaInstanciarEComparar();


            Console.WriteLine(singleton1.id);
            Console.WriteLine(singleton2.id);
            Console.WriteLine("--------------------");
            Console.WriteLine(singleton1 == singleton2);
            Console.WriteLine(classeComum1 == classeComum2);
        }
    }
}
