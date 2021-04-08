using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagemSemAdapter = new MensagemService(new Saudacao());
            var mensagemComAdapter = new MensagemService(new SaudacaoAdapter(new SaudacaoMelhorada()));

            Console.WriteLine("Sem adapter:");
            mensagemSemAdapter.EnviarBomDia();

            Console.WriteLine("-----------------");

            Console.WriteLine("Sem adapter:");
            mensagemComAdapter.EnviarBomDia();
        }
    }
}
