using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SaudacaoMelhorada : ISaudacaoMelhorada
    {
        public void bomDia()
        {
            Console.WriteLine("booooooooom dia, dev");
        }
        public void boaTarde()
        {
            Console.WriteLine("boa tarde, dev! Como vai?");
        }
        public void boaNoite()
        {
            Console.WriteLine("Boa noite, dev! Até amanhã");
        }
    }
}
