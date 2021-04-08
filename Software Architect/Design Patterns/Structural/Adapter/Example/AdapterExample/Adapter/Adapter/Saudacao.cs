using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Saudacao : ISaudacao
    {
        public void bomDia()
        {
            Console.WriteLine("Bom dia, dev");
        }
        public void boaTarde()
        {
            Console.WriteLine("Boa tarde, dev");
        }
        public void boaNoite()
        {
            Console.WriteLine("Boa noite, dev");
        }
    }
}
