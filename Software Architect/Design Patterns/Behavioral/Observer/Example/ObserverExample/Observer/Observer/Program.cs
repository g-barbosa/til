using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var gio = new Observer("Giovanne");
            var emicida = new Observer("Emicida");

            var daysWithoutAccident = new DaysWithoutAccident(0);

            daysWithoutAccident.Sub(gio);
            daysWithoutAccident.Sub(emicida);

            daysWithoutAccident.Days = 1;


        }
    }
}
